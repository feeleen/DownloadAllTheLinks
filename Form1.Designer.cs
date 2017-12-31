namespace DownloaderAllTheLinks
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.OfficeBox = new System.Windows.Forms.CheckBox();
			this.ArchivesBox = new System.Windows.Forms.CheckBox();
			this.ImagesBox = new System.Windows.Forms.CheckBox();
			this.CheckAllBtn = new System.Windows.Forms.Button();
			this.UncheckAllBtn = new System.Windows.Forms.Button();
			this.FolderBox = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.UseFileNamesBox = new System.Windows.Forms.CheckBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ProgressBox = new System.Windows.Forms.ToolStripProgressBar();
			this.StatusBox = new System.Windows.Forms.ToolStripStatusLabel();
			this.InvertBtn = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.RegexBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ResetRegExBtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.LinkGroupNoBox = new System.Windows.Forms.TextBox();
			this.InnerTextGroupNoBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(12, 183);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(716, 240);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "URL";
			this.columnHeader1.Width = 414;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Saved File Name";
			this.columnHeader2.Width = 286;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(734, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 56);
			this.button1.TabIndex = 1;
			this.button1.Text = "1. Parse Url";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(47, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(681, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "List Of Found Items";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(734, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 56);
			this.button2.TabIndex = 1;
			this.button2.Text = "2. Download";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// OfficeBox
			// 
			this.OfficeBox.AutoSize = true;
			this.OfficeBox.Checked = true;
			this.OfficeBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.OfficeBox.Location = new System.Drawing.Point(170, 41);
			this.OfficeBox.Name = "OfficeBox";
			this.OfficeBox.Size = new System.Drawing.Size(78, 17);
			this.OfficeBox.TabIndex = 4;
			this.OfficeBox.Text = "Office Files";
			this.OfficeBox.UseVisualStyleBackColor = true;
			// 
			// ArchivesBox
			// 
			this.ArchivesBox.AutoSize = true;
			this.ArchivesBox.Checked = true;
			this.ArchivesBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ArchivesBox.Location = new System.Drawing.Point(256, 41);
			this.ArchivesBox.Name = "ArchivesBox";
			this.ArchivesBox.Size = new System.Drawing.Size(67, 17);
			this.ArchivesBox.TabIndex = 4;
			this.ArchivesBox.Text = "Archives";
			this.ArchivesBox.UseVisualStyleBackColor = true;
			// 
			// ImagesBox
			// 
			this.ImagesBox.AutoSize = true;
			this.ImagesBox.Checked = true;
			this.ImagesBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ImagesBox.Location = new System.Drawing.Point(329, 41);
			this.ImagesBox.Name = "ImagesBox";
			this.ImagesBox.Size = new System.Drawing.Size(60, 17);
			this.ImagesBox.TabIndex = 4;
			this.ImagesBox.Text = "Images";
			this.ImagesBox.UseVisualStyleBackColor = true;
			// 
			// CheckAllBtn
			// 
			this.CheckAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CheckAllBtn.Location = new System.Drawing.Point(734, 183);
			this.CheckAllBtn.Name = "CheckAllBtn";
			this.CheckAllBtn.Size = new System.Drawing.Size(75, 23);
			this.CheckAllBtn.TabIndex = 1;
			this.CheckAllBtn.Text = "Check All";
			this.CheckAllBtn.UseVisualStyleBackColor = true;
			this.CheckAllBtn.Click += new System.EventHandler(this.CheckAllBtn_Click);
			// 
			// UncheckAllBtn
			// 
			this.UncheckAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UncheckAllBtn.Location = new System.Drawing.Point(734, 212);
			this.UncheckAllBtn.Name = "UncheckAllBtn";
			this.UncheckAllBtn.Size = new System.Drawing.Size(75, 23);
			this.UncheckAllBtn.TabIndex = 1;
			this.UncheckAllBtn.Text = "Check None";
			this.UncheckAllBtn.UseVisualStyleBackColor = true;
			this.UncheckAllBtn.Click += new System.EventHandler(this.UncheckAllBtn_Click);
			// 
			// FolderBox
			// 
			this.FolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FolderBox.Location = new System.Drawing.Point(87, 432);
			this.FolderBox.Name = "FolderBox";
			this.FolderBox.Size = new System.Drawing.Size(535, 20);
			this.FolderBox.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(628, 430);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Browse Folder ...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 435);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Save Files To";
			// 
			// UseFileNamesBox
			// 
			this.UseFileNamesBox.AutoSize = true;
			this.UseFileNamesBox.Checked = true;
			this.UseFileNamesBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.UseFileNamesBox.Location = new System.Drawing.Point(87, 143);
			this.UseFileNamesBox.Name = "UseFileNamesBox";
			this.UseFileNamesBox.Size = new System.Drawing.Size(145, 17);
			this.UseFileNamesBox.TabIndex = 4;
			this.UseFileNamesBox.Text = "Use File Names from URI";
			this.UseFileNamesBox.UseVisualStyleBackColor = true;
			this.UseFileNamesBox.CheckedChanged += new System.EventHandler(this.UseFileNamesBox_CheckedChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBox,
            this.StatusBox});
			this.statusStrip1.Location = new System.Drawing.Point(0, 460);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(821, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ProgressBox
			// 
			this.ProgressBox.Name = "ProgressBox";
			this.ProgressBox.Size = new System.Drawing.Size(300, 16);
			// 
			// StatusBox
			// 
			this.StatusBox.AutoSize = false;
			this.StatusBox.Name = "StatusBox";
			this.StatusBox.Size = new System.Drawing.Size(300, 17);
			// 
			// InvertBtn
			// 
			this.InvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InvertBtn.Location = new System.Drawing.Point(734, 241);
			this.InvertBtn.Name = "InvertBtn";
			this.InvertBtn.Size = new System.Drawing.Size(75, 23);
			this.InvertBtn.TabIndex = 1;
			this.InvertBtn.Text = "Invert Sel.";
			this.InvertBtn.UseVisualStyleBackColor = true;
			this.InvertBtn.Click += new System.EventHandler(this.InvertBtn_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Location = new System.Drawing.Point(734, 430);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "Open Folder";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "URL";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Reg. expression";
			// 
			// RegexBox
			// 
			this.RegexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RegexBox.Location = new System.Drawing.Point(101, 89);
			this.RegexBox.Name = "RegexBox";
			this.RegexBox.Size = new System.Drawing.Size(536, 20);
			this.RegexBox.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(442, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Use \"filetypes\" word in your regular expression to get predefined selected file t" +
    "ypes (jpg|gif|...)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(137, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Predefined lists of file types:";
			// 
			// ResetRegExBtn
			// 
			this.ResetRegExBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResetRegExBtn.Location = new System.Drawing.Point(637, 87);
			this.ResetRegExBtn.Name = "ResetRegExBtn";
			this.ResetRegExBtn.Size = new System.Drawing.Size(85, 23);
			this.ResetRegExBtn.TabIndex = 11;
			this.ResetRegExBtn.Text = "Reset RegEx";
			this.ResetRegExBtn.UseVisualStyleBackColor = true;
			this.ResetRegExBtn.Click += new System.EventHandler(this.ResetRegExBtn_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Anchor link group number";
			// 
			// LinkGroupNoBox
			// 
			this.LinkGroupNoBox.Location = new System.Drawing.Point(152, 115);
			this.LinkGroupNoBox.Name = "LinkGroupNoBox";
			this.LinkGroupNoBox.Size = new System.Drawing.Size(36, 20);
			this.LinkGroupNoBox.TabIndex = 12;
			this.LinkGroupNoBox.Text = "2";
			// 
			// InnerTextGroupNoBox
			// 
			this.InnerTextGroupNoBox.Location = new System.Drawing.Point(446, 141);
			this.InnerTextGroupNoBox.Name = "InnerTextGroupNoBox";
			this.InnerTextGroupNoBox.Size = new System.Drawing.Size(36, 20);
			this.InnerTextGroupNoBox.TabIndex = 12;
			this.InnerTextGroupNoBox.Text = "3";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(285, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(155, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Anchor inner text group number";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 144);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(277, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "If you don\'t                                                            then set";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 482);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.InnerTextGroupNoBox);
			this.Controls.Add(this.LinkGroupNoBox);
			this.Controls.Add(this.ResetRegExBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.RegexBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.UseFileNamesBox);
			this.Controls.Add(this.ImagesBox);
			this.Controls.Add(this.ArchivesBox);
			this.Controls.Add(this.OfficeBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FolderBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.InvertBtn);
			this.Controls.Add(this.UncheckAllBtn);
			this.Controls.Add(this.CheckAllBtn);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label9);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(600, 39);
			this.Name = "Form1";
			this.Text = "Download All The Links";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.CheckBox OfficeBox;
		private System.Windows.Forms.CheckBox ArchivesBox;
		private System.Windows.Forms.CheckBox ImagesBox;
		private System.Windows.Forms.Button CheckAllBtn;
		private System.Windows.Forms.Button UncheckAllBtn;
		private System.Windows.Forms.TextBox FolderBox;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox UseFileNamesBox;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar ProgressBox;
		private System.Windows.Forms.ToolStripStatusLabel StatusBox;
		private System.Windows.Forms.Button InvertBtn;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox RegexBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button ResetRegExBtn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox LinkGroupNoBox;
		private System.Windows.Forms.TextBox InnerTextGroupNoBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}

