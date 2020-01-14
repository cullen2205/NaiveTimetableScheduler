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
using System.Text.RegularExpressions;
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

        private List<string> ConvertString(string input)
        {
            string[] splitString = Regex.Split(input, "\n");
            splitString = splitString.Where(m => !string.IsNullOrWhiteSpace(m)).ToArray();
            var result = new List<string[]>();
            var finalresult = new List<string>();
            int i = 0;
            foreach (var item in splitString)
            {
                result.Add(Regex.Split(item, "[\r\t]"));
                string[] t7Thu = result[i][7].Split(new char[] { ',', ' ', 'T', 't' });
                t7Thu = t7Thu.Where(m => !string.IsNullOrWhiteSpace(m)).ToArray();
                for (int iii = 0; iii < t7Thu.Count(); iii++)
                {
                    t7Thu[iii] = t7Thu[iii].Replace("CN", "8");
                    t7Thu[iii] = t7Thu[iii].Replace("cn", "8");
                }
                string[] t8Tiet = result[i][8].Split(new char[] { ',' });
                t8Tiet = t8Tiet.Where(m => !string.IsNullOrWhiteSpace(m)).ToArray();
                bool first = true;
                string contin = null;
                for (int j = 0; j < t7Thu.Count() && !string.IsNullOrWhiteSpace(t7Thu[j]); j++)
                {
                    if (first)
                    {
                        first = false;
                        contin = t7Thu[j] + ":" + t8Tiet[j];
                        continue;
                    }
                    contin += "," + t7Thu[j] + ":" + t8Tiet[j];
                }
                //contin += ";";

                finalresult.Add(result[i][2] /*ten mon*/ + ";" + contin);
                ++i;
            }
            return finalresult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                try
                {
                    var itemm = ConvertString(richTextBox1.Text);
                    FormUtilities<Subject>.SetCheckedListBoxItems
                    (
                        SubjectsCheckedListBox,
                        Core.IO.Input.GetSubjectsFromText(itemm)
                    );

                    subjectLimitForm
                        .FillSubjects
                        (
                            SubjectsCheckedListBox.Items.Cast<Subject>().ToList()
                        );
                }
                catch (Exception ex)
                {
                    MessageUtilities.ShowErrorMessage
                    (
                        TextStorage.GetMessage(ex.Message),
                        TextStorage.GetLabel("LBL_003_ERROR")
                    );
                }
            }
            else
            {
                MessageUtilities.ShowWarningMessage
                (
                    TextStorage.GetMessage("MSG_002_WARN_NO_DATA"),
                    TextStorage.GetLabel("LBL_002_WARN")
                );
            }
        }
    }
}
