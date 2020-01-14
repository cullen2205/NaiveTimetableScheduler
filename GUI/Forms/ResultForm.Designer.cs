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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChoiceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewTimetable
            // 
            this.ViewTimetable.AutoSize = true;
            this.ViewTimetable.Location = new System.Drawing.Point(66, 34);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "07:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "07:50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "09:35";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "08:40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "13:20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "12:30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "11:15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "10:25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "16:45";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "15:55";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "15:05";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "14:10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "20:05";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "19:15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "18:25";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "17:35";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 481);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}