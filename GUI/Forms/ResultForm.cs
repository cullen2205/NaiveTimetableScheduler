using Core.Models;
using Core.Processing;
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
    public partial class ResultForm : Form
    {
        public BlackBox blackBox = new BlackBox();

        private int currentChoiceIndex = 1;
        public int CurrentChoiceIndex
        {
            get => currentChoiceIndex;

            set
            {
                if (value < 1)
                    currentChoiceIndex = blackBox.ValidChoices.Count;
                else if (value > blackBox.ValidChoices.Count)
                    currentChoiceIndex = 1;
                else
                    currentChoiceIndex = value;

                ViewTimetable.ShowSubjects(blackBox.ValidChoices[currentChoiceIndex - 1].ToArray());
                CurrentChoiceNumericUpDown.Value = currentChoiceIndex;
            }
        }

        public ResultForm()
        {
            InitializeComponent();
        }

        public void DisplaySubjects(params Subject[] subjects)
        {
            foreach(Subject subject in subjects)
            {
                ViewTimetable.ShowSubject(subject);
            }
        }


        private void PreviousChoiceButton_Click(object sender, EventArgs e)
        {
            --CurrentChoiceIndex;
        }

        private void FirstChoiceButton_Click(object sender, EventArgs e)
        {
            CurrentChoiceIndex = 1;
        }

        private void NextChoiceButton_Click(object sender, EventArgs e)
        {
            ++CurrentChoiceIndex;
        }

        private void LastChoiceButton_Click(object sender, EventArgs e)
        {
            CurrentChoiceIndex = blackBox.ValidChoices.Count;
        }

        private void CurrentChoiceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CurrentChoiceIndex = Convert.ToInt32(CurrentChoiceNumericUpDown.Value);
        }
    }
}
