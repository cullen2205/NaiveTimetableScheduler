namespace GUI.Forms
{
    partial class CustomTimetable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableGridView
            // 
            this.TableGridView.AllowUserToAddRows = false;
            this.TableGridView.AllowUserToDeleteRows = false;
            this.TableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.MondayColumn,
            this.TuesdayColumn,
            this.WednesdayColumn,
            this.ThursdayColumn,
            this.FridayColumn,
            this.SaturdayColumn,
            this.SundayColumn});
            this.TableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableGridView.Location = new System.Drawing.Point(0, 0);
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableGridView.RowHeadersVisible = false;
            this.TableGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableGridView.Size = new System.Drawing.Size(524, 393);
            this.TableGridView.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.Frozen = true;
            this.Index.HeaderText = "";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 19;
            // 
            // MondayColumn
            // 
            this.MondayColumn.Frozen = true;
            this.MondayColumn.HeaderText = "Thứ hai";
            this.MondayColumn.Name = "MondayColumn";
            this.MondayColumn.ReadOnly = true;
            this.MondayColumn.Width = 68;
            // 
            // TuesdayColumn
            // 
            this.TuesdayColumn.Frozen = true;
            this.TuesdayColumn.HeaderText = "Thứ ba";
            this.TuesdayColumn.Name = "TuesdayColumn";
            this.TuesdayColumn.ReadOnly = true;
            this.TuesdayColumn.Width = 66;
            // 
            // WednesdayColumn
            // 
            this.WednesdayColumn.Frozen = true;
            this.WednesdayColumn.HeaderText = "Thứ tư";
            this.WednesdayColumn.Name = "WednesdayColumn";
            this.WednesdayColumn.ReadOnly = true;
            this.WednesdayColumn.Width = 63;
            // 
            // ThursdayColumn
            // 
            this.ThursdayColumn.Frozen = true;
            this.ThursdayColumn.HeaderText = "Thứ năm";
            this.ThursdayColumn.Name = "ThursdayColumn";
            this.ThursdayColumn.ReadOnly = true;
            this.ThursdayColumn.Width = 74;
            // 
            // FridayColumn
            // 
            this.FridayColumn.Frozen = true;
            this.FridayColumn.HeaderText = "Thứ sáu";
            this.FridayColumn.Name = "FridayColumn";
            this.FridayColumn.ReadOnly = true;
            this.FridayColumn.Width = 71;
            // 
            // SaturdayColumn
            // 
            this.SaturdayColumn.Frozen = true;
            this.SaturdayColumn.HeaderText = "Thứ bảy";
            this.SaturdayColumn.Name = "SaturdayColumn";
            this.SaturdayColumn.ReadOnly = true;
            this.SaturdayColumn.Width = 71;
            // 
            // SundayColumn
            // 
            this.SundayColumn.Frozen = true;
            this.SundayColumn.HeaderText = "Chủ nhật";
            this.SundayColumn.Name = "SundayColumn";
            this.SundayColumn.ReadOnly = true;
            this.SundayColumn.Width = 75;
            // 
            // CustomTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TableGridView);
            this.Name = "CustomTimetable";
            this.Size = new System.Drawing.Size(524, 393);
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView TableGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayColumn;
    }
}
