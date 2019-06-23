using Core.Models;
using GUI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class TimeLimitForm : Form
    {
        public List<TimePeriod> DeniedPeriods, PreferredPeriods;
        private bool save = false;

        public TimeLimitForm()
        {
            InitializeComponent();
            DeniedPeriods = new List<TimePeriod>();
            PreferredPeriods = new List<TimePeriod>();
        }

        private void SetLimitButton_Click(object sender, EventArgs e)
        {
            ViewTimetable.SetSelectedCellsColor(Color.Red);
        }

        private void SetPreferredButton_Click(object sender, EventArgs e)
        {
            ViewTimetable.SetSelectedCellsColor(Color.Green);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ViewTimetable.ResetAllCells();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            save = true;
            MessageUtilities.ShowInformativeMessage
            (
                TextStorage.GetMessage("MSG_004_SAVE_SUCCESS"),
                TextStorage.GetLabel("LBL_001_INFO")
            );
        }

        private void TimeLimitForm_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void TimeLimitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void TimeLimitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);

            if(save)
            {
                DeniedPeriods = ViewTimetable.GetPeriodsByColor(Color.Red);
                PreferredPeriods = ViewTimetable.GetPeriodsByColor(Color.Green);

                save = false;
            }
            else
            {
                if(MessageUtilities.ShowConfirmMessage
                    (
                        TextStorage.GetMessage("MSG_005_CONFIRM_UNSAVED_DATA"),
                        TextStorage.GetLabel("LBL_002_WARN")
                    )
                )
                {
                    ViewTimetable.ResetAllCells();

                    DeniedPeriods.Clear();
                    PreferredPeriods.Clear();
                }
                else
                {
                    return;
                }
            }

            Hide();
        }
    }
}
