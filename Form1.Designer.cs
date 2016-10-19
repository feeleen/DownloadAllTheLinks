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
			this.listView1.Location = new System.Drawing.Point(12, 86);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(710, 318);
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
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 286;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(728, 9);
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
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(710, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "List Of Found Items";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(728, 86);
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
			this.OfficeBox.Location = new System.Drawing.Point(15, 41);
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
			this.ArchivesBox.Location = new System.Drawing.Point(101, 41);
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
			this.ImagesBox.Location = new System.Drawing.Point(187, 41);
			this.ImagesBox.Name = "ImagesBox";
			this.ImagesBox.Size = new System.Drawing.Size(60, 17);
			this.ImagesBox.TabIndex = 4;
			this.ImagesBox.Text = "Images";
			this.ImagesBox.UseVisualStyleBackColor = true;
			// 
			// CheckAllBtn
			// 
			this.CheckAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CheckAllBtn.Location = new System.Drawing.Point(728, 148);
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
			this.UncheckAllBtn.Location = new System.Drawing.Point(728, 177);
			this.UncheckAllBtn.Name = "UncheckAllBtn";
			this.UncheckAllBtn.Size = new System.Drawing.Size(75, 23);
			this.UncheckAllBtn.TabIndex = 1;
			this.UncheckAllBtn.Text = "Uncheck All";
			this.UncheckAllBtn.UseVisualStyleBackColor = true;
			this.UncheckAllBtn.Click += new System.EventHandler(this.UncheckAllBtn_Click);
			// 
			// FolderBox
			// 
			this.FolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FolderBox.Location = new System.Drawing.Point(87, 410);
			this.FolderBox.Name = "FolderBox";
			this.FolderBox.Size = new System.Drawing.Size(529, 20);
			this.FolderBox.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(622, 408);
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
			this.label2.Location = new System.Drawing.Point(9, 413);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Save Files To";
			// 
			// UseFileNamesBox
			// 
			this.UseFileNamesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UseFileNamesBox.AutoSize = true;
			this.UseFileNamesBox.Checked = true;
			this.UseFileNamesBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.UseFileNamesBox.Location = new System.Drawing.Point(622, 66);
			this.UseFileNamesBox.Name = "UseFileNamesBox";
			this.UseFileNamesBox.Size = new System.Drawing.Size(100, 17);
			this.UseFileNamesBox.TabIndex = 4;
			this.UseFileNamesBox.Text = "Use File Names";
			this.UseFileNamesBox.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 440);
			this.Controls.Add(this.UseFileNamesBox);
			this.Controls.Add(this.ImagesBox);
			this.Controls.Add(this.ArchivesBox);
			this.Controls.Add(this.OfficeBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FolderBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.UncheckAllBtn);
			this.Controls.Add(this.CheckAllBtn);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Download All The Links";
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
	}
}

