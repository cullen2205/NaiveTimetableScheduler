namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuStrip_ = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTimeLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ResetSubjectsButton = new System.Windows.Forms.Button();
            this.MarkCompulsoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CompulsorySubjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.ExportFileButton = new System.Windows.Forms.Button();
            this.ImportFileButton = new System.Windows.Forms.Button();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenuStrip_.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip_
            // 
            this.MainMenuStrip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip_.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip_.Name = "MainMenuStrip_";
            this.MainMenuStrip_.Size = new System.Drawing.Size(542, 24);
            this.MainMenuStrip_.TabIndex = 0;
            this.MainMenuStrip_.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fileToolStripMenuItem.Text = "Thao tác tệp";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Nhập từ tệp";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Xuất ra tệp";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setTimeLimitToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.functionToolStripMenuItem.Text = "Chức năng";
            // 
            // setTimeLimitToolStripMenuItem
            // 
            this.setTimeLimitToolStripMenuItem.Name = "setTimeLimitToolStripMenuItem";
            this.setTimeLimitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setTimeLimitToolStripMenuItem.Text = "Giới hạn thời gian";
            this.setTimeLimitToolStripMenuItem.Click += new System.EventHandler(this.setTimeLimitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.helpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howToUseToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "Về chương trình";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.ResetSubjectsButton);
            this.groupBox1.Controls.Add(this.MarkCompulsoryButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CompulsorySubjectsCheckedListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SubjectsCheckedListBox);
            this.groupBox1.Location = new System.Drawing.Point(199, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(28, 192);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ResetSubjectsButton
            // 
            this.ResetSubjectsButton.Location = new System.Drawing.Point(110, 192);
            this.ResetSubjectsButton.Name = "ResetSubjectsButton";
            this.ResetSubjectsButton.Size = new System.Drawing.Size(75, 23);
            this.ResetSubjectsButton.TabIndex = 6;
            this.ResetSubjectsButton.Text = "Khôi phục";
            this.ResetSubjectsButton.UseVisualStyleBackColor = true;
            this.ResetSubjectsButton.Click += new System.EventHandler(this.ResetSubjectsButton_Click);
            // 
            // MarkCompulsoryButton
            // 
            this.MarkCompulsoryButton.Location = new System.Drawing.Point(191, 192);
            this.MarkCompulsoryButton.Name = "MarkCompulsoryButton";
            this.MarkCompulsoryButton.Size = new System.Drawing.Size(75, 23);
            this.MarkCompulsoryButton.TabIndex = 5;
            this.MarkCompulsoryButton.Text = "Bắt buộc";
            this.MarkCompulsoryButton.UseVisualStyleBackColor = true;
            this.MarkCompulsoryButton.Click += new System.EventHandler(this.MarkCompulsoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Các môn bắt buộc";
            // 
            // CompulsorySubjectsCheckedListBox
            // 
            this.CompulsorySubjectsCheckedListBox.FormattingEnabled = true;
            this.CompulsorySubjectsCheckedListBox.Location = new System.Drawing.Point(28, 259);
            this.CompulsorySubjectsCheckedListBox.Name = "CompulsorySubjectsCheckedListBox";
            this.CompulsorySubjectsCheckedListBox.Size = new System.Drawing.Size(238, 64);
            this.CompulsorySubjectsCheckedListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tất cả các môn";
            // 
            // SubjectsCheckedListBox
            // 
            this.SubjectsCheckedListBox.FormattingEnabled = true;
            this.SubjectsCheckedListBox.Location = new System.Drawing.Point(28, 47);
            this.SubjectsCheckedListBox.Name = "SubjectsCheckedListBox";
            this.SubjectsCheckedListBox.Size = new System.Drawing.Size(238, 139);
            this.SubjectsCheckedListBox.TabIndex = 1;
            this.SubjectsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SubjectsCheckedListBox_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProcessButton);
            this.groupBox2.Controls.Add(this.ExportFileButton);
            this.groupBox2.Controls.Add(this.ImportFileButton);
            this.groupBox2.Location = new System.Drawing.Point(26, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 352);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Làm việc";
            // 
            // ProcessButton
            // 
            this.ProcessButton.Image = global::GUI.Properties.Resources.icons8_process_32;
            this.ProcessButton.Location = new System.Drawing.Point(30, 139);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 75);
            this.ProcessButton.TabIndex = 2;
            this.ProcessButton.Text = "Xử lý";
            this.ProcessButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ExportFileButton
            // 
            this.ExportFileButton.Image = global::GUI.Properties.Resources.icons8_save_as_32;
            this.ExportFileButton.Location = new System.Drawing.Point(30, 249);
            this.ExportFileButton.Name = "ExportFileButton";
            this.ExportFileButton.Size = new System.Drawing.Size(75, 75);
            this.ExportFileButton.TabIndex = 1;
            this.ExportFileButton.Text = "Xuất ra tệp";
            this.ExportFileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExportFileButton.UseVisualStyleBackColor = true;
            this.ExportFileButton.Click += new System.EventHandler(this.ExportFileButton_Click);
            // 
            // ImportFileButton
            // 
            this.ImportFileButton.Image = global::GUI.Properties.Resources.icons8_add_file_32;
            this.ImportFileButton.Location = new System.Drawing.Point(30, 31);
            this.ImportFileButton.Name = "ImportFileButton";
            this.ImportFileButton.Size = new System.Drawing.Size(75, 75);
            this.ImportFileButton.TabIndex = 0;
            this.ImportFileButton.Text = "Nhập từ tệp";
            this.ImportFileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImportFileButton.UseVisualStyleBackColor = true;
            this.ImportFileButton.Click += new System.EventHandler(this.ImportFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenuStrip_);
            this.Name = "MainForm";
            this.Text = "Chương trình sắp xếp lịch học 1.0";
            this.MainMenuStrip_.ResumeLayout(false);
            this.MainMenuStrip_.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip_;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTimeLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ExportFileButton;
        private System.Windows.Forms.Button ImportFileButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CompulsorySubjectsCheckedListBox;
        private System.Windows.Forms.CheckedListBox SubjectsCheckedListBox;
        private System.Windows.Forms.Button MarkCompulsoryButton;
        private System.Windows.Forms.Button ResetSubjectsButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

