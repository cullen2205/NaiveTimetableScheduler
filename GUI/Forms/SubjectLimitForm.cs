using Core.Models;
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
    public partial class SubjectLimitForm : Form
    {
        public SubjectLimitForm()
        {
            InitializeComponent();
        }

        public void FillSubjects(List<Subject> subjects)
        {
            SubjectsCheckedListBox.DataSource = subjects.Select(s => s.Name).Distinct().ToList();
            SetAllItemsState(true);
            /*SubjectsCheckedListBox.DisplayMember = "Name";
            SubjectsCheckedListBox.ValueMember = "Name";*/
        }

        private void SetAllItemsState(bool state)
        {
            for (int index = 0; index < SubjectsCheckedListBox.Items.Count; ++index)
            {
                SubjectsCheckedListBox.SetItemChecked(index, state);
            }
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            SetAllItemsState(true);
        }

        private void DeselectAllButton_Click(object sender, EventArgs e)
        {
            SetAllItemsState(false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        public List<string> GetSelectedSubjects()
        {
            return SubjectsCheckedListBox.CheckedItems.Cast<string>().ToList();
        }
    }
}
