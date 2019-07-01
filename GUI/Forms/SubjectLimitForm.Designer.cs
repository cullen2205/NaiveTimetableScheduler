namespace GUI.Forms
{
    partial class SubjectLimitForm
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
            this.SubjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeselectAllButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectsCheckedListBox
            // 
            this.SubjectsCheckedListBox.FormattingEnabled = true;
            this.SubjectsCheckedListBox.Location = new System.Drawing.Point(26, 35);
            this.SubjectsCheckedListBox.Name = "SubjectsCheckedListBox";
            this.SubjectsCheckedListBox.Size = new System.Drawing.Size(305, 199);
            this.SubjectsCheckedListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.DeselectAllButton);
            this.groupBox1.Controls.Add(this.SelectAllButton);
            this.groupBox1.Controls.Add(this.SubjectsCheckedListBox);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các môn học";
            // 
            // DeselectAllButton
            // 
            this.DeselectAllButton.Image = global::GUI.Properties.Resources.icons8_select_none_32;
            this.DeselectAllButton.Location = new System.Drawing.Point(143, 254);
            this.DeselectAllButton.Name = "DeselectAllButton";
            this.DeselectAllButton.Size = new System.Drawing.Size(75, 75);
            this.DeselectAllButton.TabIndex = 2;
            this.DeselectAllButton.Text = "Bỏ tất cả";
            this.DeselectAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeselectAllButton.UseVisualStyleBackColor = true;
            this.DeselectAllButton.Click += new System.EventHandler(this.DeselectAllButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = global::GUI.Properties.Resources.icons8_save_32;
            this.SaveButton.Location = new System.Drawing.Point(256, 254);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 75);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Image = global::GUI.Properties.Resources.icons8_select_all_32;
            this.SelectAllButton.Location = new System.Drawing.Point(26, 254);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(75, 75);
            this.SelectAllButton.TabIndex = 1;
            this.SelectAllButton.Text = "Chọn tất cả";
            this.SelectAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // SubjectLimitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 407);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectLimitForm";
            this.Text = "SubjectLimitForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SubjectsCheckedListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeselectAllButton;
        private System.Windows.Forms.Button SelectAllButton;
    }
}