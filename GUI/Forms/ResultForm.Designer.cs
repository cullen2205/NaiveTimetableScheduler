namespace GUI.Forms
{
    partial class ResultForm
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
            this.ViewTimetable = new GUI.Forms.CustomTimetable();
            this.CurrentChoiceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FirstChoiceButton = new System.Windows.Forms.Button();
            this.PreviousChoiceButton = new System.Windows.Forms.Button();
            this.NextChoiceButton = new System.Windows.Forms.Button();
            this.LastChoiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChoiceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewTimetable
            // 
            this.ViewTimetable.AutoSize = true;
            this.ViewTimetable.Location = new System.Drawing.Point(37, 32);
            this.ViewTimetable.Name = "ViewTimetable";
            this.ViewTimetable.Size = new System.Drawing.Size(513, 344);
            this.ViewTimetable.TabIndex = 0;
            // 
            // CurrentChoiceNumericUpDown
            // 
            this.CurrentChoiceNumericUpDown.Location = new System.Drawing.Point(341, 418);
            this.CurrentChoiceNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.CurrentChoiceNumericUpDown.Name = "CurrentChoiceNumericUpDown";
            this.CurrentChoiceNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.CurrentChoiceNumericUpDown.TabIndex = 5;
            this.CurrentChoiceNumericUpDown.ThousandsSeparator = true;
            this.CurrentChoiceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CurrentChoiceNumericUpDown.ValueChanged += new System.EventHandler(this.CurrentChoiceNumericUpDown_ValueChanged);
            // 
            // FirstChoiceButton
            // 
            this.FirstChoiceButton.Image = global::GUI.Properties.Resources.icons8_first_32;
            this.FirstChoiceButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FirstChoiceButton.Location = new System.Drawing.Point(183, 404);
            this.FirstChoiceButton.Name = "FirstChoiceButton";
            this.FirstChoiceButton.Size = new System.Drawing.Size(65, 50);
            this.FirstChoiceButton.TabIndex = 10;
            this.FirstChoiceButton.Text = "Đầu";
            this.FirstChoiceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FirstChoiceButton.UseVisualStyleBackColor = true;
            this.FirstChoiceButton.Click += new System.EventHandler(this.FirstChoiceButton_Click);
            // 
            // PreviousChoiceButton
            // 
            this.PreviousChoiceButton.Image = global::GUI.Properties.Resources.icons8_previous_32;
            this.PreviousChoiceButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PreviousChoiceButton.Location = new System.Drawing.Point(254, 404);
            this.PreviousChoiceButton.Name = "PreviousChoiceButton";
            this.PreviousChoiceButton.Size = new System.Drawing.Size(65, 50);
            this.PreviousChoiceButton.TabIndex = 11;
            this.PreviousChoiceButton.Text = "Trước";
            this.PreviousChoiceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PreviousChoiceButton.UseVisualStyleBackColor = true;
            this.PreviousChoiceButton.Click += new System.EventHandler(this.PreviousChoiceButton_Click);
            // 
            // NextChoiceButton
            // 
            this.NextChoiceButton.Image = global::GUI.Properties.Resources.icons8_next_32;
            this.NextChoiceButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextChoiceButton.Location = new System.Drawing.Point(414, 404);
            this.NextChoiceButton.Name = "NextChoiceButton";
            this.NextChoiceButton.Size = new System.Drawing.Size(65, 50);
            this.NextChoiceButton.TabIndex = 12;
            this.NextChoiceButton.Text = "Tiếp";
            this.NextChoiceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NextChoiceButton.UseVisualStyleBackColor = true;
            this.NextChoiceButton.Click += new System.EventHandler(this.NextChoiceButton_Click);
            // 
            // LastChoiceButton
            // 
            this.LastChoiceButton.Image = global::GUI.Properties.Resources.icons8_last_32;
            this.LastChoiceButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LastChoiceButton.Location = new System.Drawing.Point(485, 404);
            this.LastChoiceButton.Name = "LastChoiceButton";
            this.LastChoiceButton.Size = new System.Drawing.Size(65, 50);
            this.LastChoiceButton.TabIndex = 13;
            this.LastChoiceButton.Text = "Cuối";
            this.LastChoiceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LastChoiceButton.UseVisualStyleBackColor = true;
            this.LastChoiceButton.Click += new System.EventHandler(this.LastChoiceButton_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 481);
            this.Controls.Add(this.LastChoiceButton);
            this.Controls.Add(this.NextChoiceButton);
            this.Controls.Add(this.PreviousChoiceButton);
            this.Controls.Add(this.FirstChoiceButton);
            this.Controls.Add(this.CurrentChoiceNumericUpDown);
            this.Controls.Add(this.ViewTimetable);
            this.Name = "ResultForm";
            this.Text = "Kết quả tính toán";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChoiceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTimetable ViewTimetable;
        private System.Windows.Forms.NumericUpDown CurrentChoiceNumericUpDown;
        private System.Windows.Forms.Button FirstChoiceButton;
        private System.Windows.Forms.Button PreviousChoiceButton;
        private System.Windows.Forms.Button NextChoiceButton;
        private System.Windows.Forms.Button LastChoiceButton;
    }
}