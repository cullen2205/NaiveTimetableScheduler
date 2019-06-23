using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Utilities
{
    public static class FormUtilities
    {
        public static void HideInsteadOfClose(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                (sender as Form).Hide();
            }
        }

        
    }

    public static class FormUtilities<T>
    {
        public static void AddItemsToCheckedListBox(CheckedListBox checkedListBox, IEnumerable<T> items)
        {
            foreach (var item in items)
                checkedListBox.Items.Add(item);
        }

        public static void SetCheckedListBoxItems(CheckedListBox checkedListBox, IEnumerable<T> items)
        {
            checkedListBox.Items.Clear();
            AddItemsToCheckedListBox(checkedListBox, items);
        }
    }
}
