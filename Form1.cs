//using Newtonsoft.Json;
using DownloaderAllTheLinks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DownloaderAllTheLinks
{
	public partial class Form1 : Form
	{
		private int sortColumn = -1;
		private List<WebClient> clients = new List<WebClient>();
		List<string> office = new List<string> { "pdf", "doc", "docx", "xls", "xlsx", "odt", "rtf", "txt", "ppt", "pptx", "ods","xps","csv","html", "shtml"};
		List<string> images = new List<string> { "png", "tiff", "jpg", "jpeg", "gif", "ico"};
		List<string> archives = new List<string> { "rar", "zip", "tar", "7z"};
		

		string placeholder = "filetypes";

		const string regPattern = @"(<a.+?href=""([^\""]+?(filetypes))""[^>]*?>([^<]+?)<\/a)";


		public Form1()
		{
			InitializeComponent();

			string downloadsPath = AppDomain.CurrentDomain.BaseDirectory + "Downloads";
			if (!Directory.Exists(downloadsPath))
			{
				Directory.CreateDirectory(downloadsPath);
			}
			
			RegexBox.Text = regPattern;
			FolderBox.Text = downloadsPath;
			UpdateLinkTextBoxGroupState();
		}

		private void LoadWebPage(string url)
		{
			try
			{
				using (WebClient client = new WebClient())
				{
					client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
					client.Encoding = Encoding.UTF8;
					client.DownloadStringCompleted += Client_DownloadStringCompleted;
					client.DownloadStringAsync(new Uri(url));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
		{
			PopulateList(e.Result);
		}

		private void PopulateList(string text)
		{
			listView1.Items.Clear();

			try
			{
				AppDomain domain = AppDomain.CurrentDomain;
				domain.SetData("REGEX_DEFAULT_MATCH_TIMEOUT", TimeSpan.FromSeconds(5));

				Hashtable links = new Hashtable();

				List<string> fileTypes = GetFileTypes();

				string CurrentRegPattern = RegexBox.Text.Replace(placeholder, String.Join("|", fileTypes));
				Regex reg = new Regex(CurrentRegPattern, RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
				
				Uri host = new Uri(textBox1.Text);
				if (!reg.IsMatch(text))
				{
					MessageBox.Show("No matches found");
					return;
				}
				MatchCollection mcol = reg.Matches(text);
				foreach (Match m in mcol)
				{
					string link = m.Groups[GetLinkGroupNumber()].Value;
					string fullLink = "";
					if (link.StartsWith("/"))
						fullLink = host.Scheme + Uri.SchemeDelimiter + host.Host + link;
					else if (link.StartsWith("http"))
						fullLink = link;
					else
						fullLink = host.Scheme + Uri.SchemeDelimiter + host.Host + "/" + link;

					ListViewItem lvi = new ListViewItem(fullLink);
					if (UseFileNamesBox.Checked)
						lvi.SubItems.Add(new Uri(fullLink).Segments.LastOrDefault());
					else
					{
						if (InnerTextGroupNoBox.Text.Take(InnerTextGroupNoBox.Text.Length).All(char.IsDigit))
						{
							lvi.SubItems.Add(m.Groups[GetLinkTextGroupNumber()].Value);
						}
						else
						{
							object[] pars = new string[m.Groups.Count];
							for (int i = 0; i < m.Groups.Count; i++)
							{
								pars[i] = m.Groups[i].Value;
							}

							lvi.SubItems.Add(String.Format(InnerTextGroupNoBox.Text, pars));
						}
					}
					lvi.Checked = true;
					listView1.Items.Add(lvi);
				}

				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private int GetLinkGroupNumber()
		{
			return Convert.ToInt32(LinkGroupNoBox.Text);
		}

		private int GetLinkTextGroupNumber()
		{
			return Convert.ToInt32(InnerTextGroupNoBox.Text);
		}

		private List<string> GetFileTypes()
		{
			List<string> fileTypes = new List<string>();
			if (OfficeBox.Checked)
				fileTypes = fileTypes.Concat(office).ToList();
			if (ArchivesBox.Checked)
				fileTypes = fileTypes.Concat(archives).ToList();
			if (ImagesBox.Checked)
				fileTypes = fileTypes.Concat(images).ToList();

			return fileTypes;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StatusBox.Text = "";
			if (textBox1.Text.Length != 0)
			{
				LoadWebPage(textBox1.Text);
			}
			else
			{
				MessageBox.Show("You must specify URL!");
			}
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(FolderBox.Text))
			{
				Directory.CreateDirectory(FolderBox.Text);
			}
			try
			{
				stopBtn.Enabled = true;
				await GrabThemAll();
			}
			catch { }
			finally
			{
				MessageBox.Show("Finished");
				StatusBox.Text = "Finished!";
				ProgressBox.Value = 0;
			}
		}

		private async Task GrabThemAll()
		{
			int counter = 0;
			ProgressBox.Value = 0;
			ProgressBox.Maximum = 0;
			foreach (ListViewItem lvi in listView1.Items)
			{
				if (lvi.Checked)
				{
					ProgressBox.Maximum++;
				}
			}
			string dir = FolderBox.Text;
			Dictionary<string, string> urls = new Dictionary<string, string>();
			int checkedCount = listView1.CheckedItems.Count;
			foreach (ListViewItem lvi in listView1.Items)
			{
				if (lvi.Checked)
				{
					
					counter++;
					StatusBox.Text = "Downloading " + counter + " of " + checkedCount + "...";
					string localFile = dir + "\\" + lvi.SubItems[1].Text + (!UseFileNamesBox.Checked && !lvi.Text.EndsWith("/") && !lvi.Text.Substring(lvi.Text.LastIndexOf('.')).Contains("/") ? ("." + lvi.Text.Substring(lvi.Text.LastIndexOf('.'))) : "");
					if (UseFileNamesBox.Checked)
					{
						localFile = dir + "\\" + lvi.SubItems[1].Text;
					}
					localFile = localFile.Replace("...", ".").Replace("..", ".");
					if (File.Exists(localFile))
					{
						File.Delete(localFile);
					}
					string UriString = lvi.Text;
					urls[UriString] = localFile;

					
					using (WebClient client = new WebClient())
					{
						clients.Add(client);
						client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

						client.DownloadProgressChanged += Client_DownloadProgressChanged;
						await client.DownloadFileTaskAsync(new Uri(UriString), localFile);
						UpdateProgress(1, checkedCount, counter);
						//client.DownloadFile(new Uri(UriString), localFile);
					}
				}
				//break;
			}

			/*
			var tasks = urls
						   .Select(url => Task.Factory.StartNew(
							   state =>
							   {
								   using (WebClient client = new WebClient())
								   {
									   try
									   {
										   client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
										   client.DownloadFile(new Uri(url.Key), url.Value);

										   //this.InvokeIfRequired(c => { c.UpdateProgress(1); });
									   }
									   catch
									   { }
									   finally
									   {
										   UpdateProgress(1);
									   }
									   //client.DownloadFile(new Uri(UriString), localFile);
								   }
							   }, url)
						   )
						   .ToArray();

			Task.WaitAll(tasks);
			*/
		}

		private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() => Client_DownloadProgressChanged(sender, e)));
			}
			else
			{
				if (DateTime.Now.Ticks % 100 == 0)
				{
					toolStripStatusLabel1.Text = String.Format("Текущий файл: {0} из {1}, {2}%", SizeString(e.BytesReceived), SizeString(e.TotalBytesToReceive), e.ProgressPercentage);
				}

				//TaskbarItemInfo.ProgressValue = current / (double)total;
			}
		}

		public void UpdateProgress(int v, int total, int current)
		{
			/*
			ProgressBox.InvokeIfRequired(() =>
			{
				// Do anything you want with the control here
				ProgressBox.RtfText = value;
				RtfHelpers.AddMissingStyles(richEditControl1);
			});
			*/
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() => UpdateProgress(v, total, current)));
			}
			else
			{
				ProgressBox.Value += v;
				
				//TaskbarItemInfo.ProgressValue = current / (double)total;
			}
			
		}

		
		/*
		public static void InvokeIfRequired1(this Control obj,
										 MethodInvoker action)
		{
			if (obj.InvokeRequired)
			{
				var args = new object[0];
				obj.Invoke(action, args);
			}
			else
			{
				action();
			}
		}
		*/

		/*
		public static T GetObject<T>(string text)
		{
			T obj = JsonConvert.DeserializeObject<T>(text);
			return obj;
		}
		*/

		private void CheckAllBtn_Click(object sender, EventArgs e)
		{
			SetCheckState(true);
		}

		private void InvertCheckState()
		{
			foreach (ListViewItem lvi in listView1.SelectedItems)
			{
				lvi.Checked = !lvi.Checked;
			}
		}

		private void SetCheckState(bool v)
		{
			foreach (ListViewItem lvi in listView1.Items)
			{
				lvi.Checked = v;
			}
		}

		private void UncheckAllBtn_Click(object sender, EventArgs e)
		{
			SetCheckState(false);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					FolderBox.Text = fbd.SelectedPath;
				}
			}
		}

		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			// Determine whether the column is the same as the last column clicked.
			if (e.Column != sortColumn)
			{
				// Set the sort column to the new column.
				sortColumn = e.Column;
				// Set the sort order to ascending by default.
				listView1.Sorting = SortOrder.Ascending;
			}
			else
			{
				// Determine what the last sort order was and change it.
				if (listView1.Sorting == SortOrder.Ascending)
					listView1.Sorting = SortOrder.Descending;
				else
					listView1.Sorting = SortOrder.Ascending;
			}

			// Call the sort method to manually sort.
			listView1.Sort();
			// Set the ListViewItemSorter property to a new ListViewItemComparer
			// object.
			this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
		}

		private void InvertBtn_Click(object sender, EventArgs e)
		{
			InvertCheckState();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
			ProcessStartInfo StartInformation = new ProcessStartInfo();

			StartInformation.FileName = FolderBox.Text;

			Process process = Process.Start(StartInformation);
		}

		private void ResetRegExBtn_Click(object sender, EventArgs e)
		{
			RegexBox.Text = regPattern;
			InnerTextGroupNoBox.Text = "5";
			LinkGroupNoBox.Text = "2";
		}

		
		private void UseFileNamesBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateLinkTextBoxGroupState();
		}

		private void UpdateLinkTextBoxGroupState()
		{
			InnerTextGroupNoBox.Enabled = !UseFileNamesBox.Checked;
		}

		private void listView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.C)
			{
				CopyListBox(listView1);
			}
		}

		public void CopyListBox(ListView list)
		{

			StringBuilder sb = new StringBuilder();
			foreach (var item in list.SelectedItems)
			{
				ListViewItem l = item as ListViewItem;
				if (l != null)
					foreach (ListViewItem.ListViewSubItem sub in l.SubItems)
						sb.Append(sub.Text + "\t");
				sb.AppendLine();
			}
			Clipboard.SetDataObject(sb.ToString());

		}

		private void stopBtn_Click(object sender, EventArgs e)
		{
			foreach (WebClient client in clients)
			{
				try
				{
					if (client!= null)
						client.CancelAsync();
				}
				catch { }
				stopBtn.Enabled = false;
			}
		}

		static readonly string[] SizeSuffixes =
				   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
		
		static string SizeString(Int64 value, int decimalPlaces = 1)
		{
			if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
			if (value < 0) { return "-" + SizeString(-value); }
			if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

			// mag is 0 for bytes, 1 for KB, 2, for MB, etc.
			int mag = (int)Math.Log(value, 1024);

			// 1L << (mag * 10) == 2 ^ (10 * mag) 
			// [i.e. the number of bytes in the unit corresponding to mag]
			decimal adjustedSize = (decimal)value / (1L << (mag * 10));

			// make adjustment when the value is large enough that
			// it would round up to 1000 or more
			if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
			{
				mag += 1;
				adjustedSize /= 1024;
			}

			return string.Format("{0:n" + decimalPlaces + "} {1}",
				adjustedSize,
				SizeSuffixes[mag]);
		}
	}

	public class Link
	{
		public string Url { get; set; }
		public string Name { get; set; }
	}

	public class RootObject
	{
		public List<Link> Links { get; set; }
	}

	public class ListViewItemComparer : IComparer
	{

		private int col;
		private SortOrder order;
		public ListViewItemComparer()
		{
			col = 0;
			order = SortOrder.Ascending;
		}
		public ListViewItemComparer(int column, SortOrder order)
		{
			col = column;
			this.order = order;
		}
		public int Compare(object x, object y)
		{
			int returnVal = -1;
			returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
							((ListViewItem)y).SubItems[col].Text);
			// Determine whether the sort order is descending.
			if (order == SortOrder.Descending)
				// Invert the value returned by String.Compare.
				returnVal *= -1;
			return returnVal;
		}
	}
}
