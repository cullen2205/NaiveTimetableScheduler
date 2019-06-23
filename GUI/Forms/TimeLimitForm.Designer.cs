namespace GUI.Forms
{
    partial class TimeLimitForm
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SetLimitButton = new System.Windows.Forms.Button();
            this.SetPreferredButton = new System.Windows.Forms.Button();
            this.ViewTimetable = new GUI.Forms.CustomTimetable();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Image = global::GUI.Properties.Resources.icons8_reset_32;
            this.ResetButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResetButton.Location = new System.Drawing.Point(285, 403);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 56);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Phục hồi";
            this.ResetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = global::GUI.Properties.Resources.icons8_save_32;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(475, 403);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 56);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SetLimitButton
            // 
            this.SetLimitButton.Image = global::GUI.Properties.Resources.icons8_subtract_32;
            this.SetLimitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetLimitButton.Location = new System.Drawing.Point(204, 403);
            this.SetLimitButton.Name = "SetLimitButton";
            this.SetLimitButton.Size = new System.Drawing.Size(75, 56);
            this.SetLimitButton.TabIndex = 3;
            this.SetLimitButton.Text = "Giới hạn";
            this.SetLimitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SetLimitButton.UseVisualStyleBackColor = true;
            this.SetLimitButton.Click += new System.EventHandler(this.SetLimitButton_Click);
            // 
            // SetPreferredButton
            // 
            this.SetPreferredButton.Image = global::GUI.Properties.Resources.icons8_plus_math_32;
            this.SetPreferredButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetPreferredButton.Location = new System.Drawing.Point(366, 403);
            this.SetPreferredButton.Name = "SetPreferredButton";
            this.SetPreferredButton.Size = new System.Drawing.Size(75, 56);
            this.SetPreferredButton.TabIndex = 2;
            this.SetPreferredButton.Text = "Ưu tiên";
            this.SetPreferredButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SetPreferredButton.UseVisualStyleBackColor = true;
            this.SetPreferredButton.Click += new System.EventHandler(this.SetPreferredButton_Click);
            // 
            // ViewTimetable
            // 
            this.ViewTimetable.AutoSize = true;
            this.ViewTimetable.Location = new System.Drawing.Point(37, 32);
            this.ViewTimetable.Name = "ViewTimetable";
            this.ViewTimetable.Size = new System.Drawing.Size(513, 344);
            this.ViewTimetable.TabIndex = 1;
            // 
            // TimeLimitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 481);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SetLimitButton);
            this.Controls.Add(this.SetPreferredButton);
            this.Controls.Add(this.ViewTimetable);
            this.Name = "TimeLimitForm";
            this.Text = "Đặt giới hạn thời gian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeLimitForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeLimitForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.TimeLimitForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTimetable ViewTimetable;
        private System.Windows.Forms.Button SetLimitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SetPreferredButton;
        private System.Windows.Forms.Button ResetButton;
    }
}