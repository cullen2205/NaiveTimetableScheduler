using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;

namespace GUI.Forms
{
    public partial class CustomTimetable : UserControl
    {
        public CustomTimetable()
        {
            InitializeComponent();

            for (int i = 0; i < 16; ++i)
            {
                TableGridView.Rows.Add();
                TableGridView.Rows[i].Cells["index"].Value = i + 1;
            }
        }

        public void ShowSubject(Subject subject)
        {
            foreach(TimePeriod period in subject.Periods)
            {
                int columnIndex = period.DayInWeek - 1;
                for(int rowIndex = period.Begin; rowIndex <= period.End; ++rowIndex)
                {
                    TableGridView[columnIndex, rowIndex - 1].Value = subject.Abbreviation;
                }
            }
        }

        public void ResetAllCells()
        {
            for(int columnIndex = 1; columnIndex < TableGridView.Columns.Count; ++columnIndex)
                //skip the index column
            {
                for(int rowIndex = 0; rowIndex < TableGridView.Rows.Count; ++rowIndex)
                {
                    TableGridView[columnIndex, rowIndex].Value = "";
                    TableGridView[columnIndex, rowIndex].Style.BackColor = TableGridView.DefaultCellStyle.BackColor;
                }
            }
        }

        public void ShowSubjects(params Subject[] subjects)
        {
            ResetAllCells();
            foreach (Subject subject in subjects)
                ShowSubject(subject);
        }

        public void SetSelectedCellsColor(Color color)
        {
            foreach(DataGridViewCell cell in TableGridView.SelectedCells)
            {
                if (cell.ColumnIndex != 0)
                    cell.Style.BackColor = color;
            }
        }

        public List<TimePeriod> GetPeriodsByColor(Color color)
        {
            List<TimePeriod> periods = new List<TimePeriod>();
            for (int columnIndex = 1; columnIndex < TableGridView.Columns.Count; ++columnIndex)
            {
                for (int rowIndex = 0; rowIndex < TableGridView.Rows.Count; ++rowIndex)
                {
                    if (TableGridView[columnIndex, rowIndex].Style.BackColor == color)
                    {
                        int begin = rowIndex, 
                            end = rowIndex - 1;

                        while (++end < TableGridView.Rows.Count 
                            && TableGridView[columnIndex, end].Style.BackColor == color);

                        periods.Add(new TimePeriod()
                        {
                            DayInWeek = columnIndex + 1,
                            Begin = begin + 1,
                            End = end
                        });

                        rowIndex = end + 1;
                    }
                }
            }
            return periods;
        }
    }
}
