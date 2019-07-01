using Core.Models;
using Core.Processing;
using GUI.Forms;
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

namespace GUI
{
    public partial class MainForm : Form
    {
        string inputPath = "";
        ResultForm resultForm = new ResultForm();
        TimeLimitForm timeLimitForm = new TimeLimitForm();
        SubjectLimitForm subjectLimitForm = new SubjectLimitForm();

        public MainForm()
        {
            InitializeComponent();
            resultForm.FormClosing += FormUtilities.HideInsteadOfClose;
            //limitForm.FormClosing += FormUtilities.HideInsteadOfClose;
            subjectLimitForm.FormClosing += FormUtilities.HideInsteadOfClose;
        }

        private void FillWithAllSubjects()
        {
            if(string.IsNullOrEmpty(inputPath))
            {
                MessageUtilities.ShowWarningMessage
                (
                    TextStorage.GetMessage("MSG_002_WARN_NO_DATA"),
                    TextStorage.GetLabel("LBL_002_WARN")
                );

                return;
            }

            try
            {
                FormUtilities<Subject>.SetCheckedListBoxItems
                (
                    SubjectsCheckedListBox,
                    Core.IO.Input.GetSubjectsFromFile(inputPath)
                );

                subjectLimitForm
                    .FillSubjects
                    (
                        SubjectsCheckedListBox.Items.Cast<Subject>().ToList()
                    );
            }
            catch(Exception e)
            {
                MessageUtilities.ShowErrorMessage
                (
                    TextStorage.GetMessage(e.Message),
                    TextStorage.GetLabel("LBL_003_ERROR")
                );
            }
        }

        private void ImportFileButton_Click(object sender, EventArgs e)
        {
            if(ImportFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputPath = ImportFileDialog.FileName;
                FillWithAllSubjects();
            }
        }

        private void SubjectsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void MarkCompulsoryButton_Click(object sender, EventArgs e)
        {
            List<Subject> compulsorySubjects = SubjectsCheckedListBox
                .CheckedItems.OfType<Subject>().ToList();
            var intersectPairs = BlackBox.IntersectPairs(compulsorySubjects);
            
            if (intersectPairs.Count > 0)
            {
                string message = "Các lớp sau bị trùng: " + Environment.NewLine;
                foreach(Tuple<Subject, Subject> pair in intersectPairs)
                {
                    message += string.Format("[{0}] và [{1}]", pair.Item1, pair.Item2) 
                        + Environment.NewLine;
                }

                MessageBox.Show(message);
            }
            else
            {
                FormUtilities<Subject>.AddItemsToCheckedListBox
                (
                    CompulsorySubjectsCheckedListBox,
                    SubjectsCheckedListBox.CheckedItems.Cast<Subject>()
                );

                foreach(Subject subject in CompulsorySubjectsCheckedListBox.Items)
                {
                    //remove all the subjects from the full list that has the same name
                    SubjectsCheckedListBox.Items
                        .Cast<Subject>()
                        .Where(s => s.Name == subject.Name)
                        .ToList()
                        .ForEach
                        (
                            SubjectsCheckedListBox.Items.Remove
                        );
                    
                }
            }
        }

        private void ResetSubjectsButton_Click(object sender, EventArgs e)
        {
            CompulsorySubjectsCheckedListBox.Items.Clear();
            FillWithAllSubjects();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if(SubjectsCheckedListBox.Items.Count == 0 
                && CompulsorySubjectsCheckedListBox.Items.Count == 0)
            {
                MessageUtilities.ShowWarningMessage
                (
                    TextStorage.GetMessage("MSG_002_WARN_NO_DATA"),
                    TextStorage.GetLabel("LBL_002_WARN")
                );

                return;
            }

            resultForm.blackBox.ValidChoices.Clear();
            resultForm.blackBox.Attempt
            (
                CompulsorySubjectsCheckedListBox
                    .Items
                    .Cast<Subject>()
                    .ToList(),
                BlackBox.GroupSubjectsByName
                (
                    BlackBox.SubjectsNotIntersectConditions
                    (
                        SubjectsCheckedListBox.Items.Cast<Subject>().ToList(),
                        timeLimitForm.DeniedPeriods
                    ).Where(s => subjectLimitForm.GetSelectedSubjects().Contains(s.Name))
                    .ToList()
                )
            );

            if(resultForm.blackBox.ValidChoices.Count == 0)
            {
                MessageUtilities.ShowInformativeMessage
                (
                    TextStorage.GetMessage("MSG_001_INFO"),
                    TextStorage.GetLabel("LBL_001_INFO")
                );
            }
            else
            {
                //resultForm.DisplaySubjects(resultForm.blackBox.ValidChoices[0].ToArray());
                resultForm.CurrentChoiceIndex = 1;
                resultForm.Show();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CompulsorySubjectsCheckedListBox.Items.Clear();
            SubjectsCheckedListBox.Items.Clear();
        }

        private void setTimeLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeLimitForm.Show();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportFileButton_Click(sender, e);

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportFileButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportFileButton_Click(object sender, EventArgs e)
        {
            MessageUtilities.ShowWarningMessage
            (
                TextStorage.GetMessage("MSG_008_NOT_UPDATED"),
                TextStorage.GetLabel("LBL_002_WARN")
            );
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageUtilities.ShowWarningMessage
            (
                TextStorage.GetMessage("MSG_008_NOT_UPDATED"),
                TextStorage.GetLabel("LBL_002_WARN")
            );
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageUtilities.ShowWarningMessage
            (
                TextStorage.GetMessage("MSG_008_NOT_UPDATED"),
                TextStorage.GetLabel("LBL_002_WARN")
            );
        }

        private void limitSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjectLimitForm.Show();
        }
    }
}
