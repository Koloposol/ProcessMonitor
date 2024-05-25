using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMonitor
{
    internal class ListViewItemComparer : IComparer
    {
        public int ColumnIndex { get; set; }

        public SortOrder SortDirection { get; set; }

        public ListViewItemComparer()
        {
            SortDirection = SortOrder.None;
        }

        public int Compare(object x, object y)
        {
            ListViewItem listViewItemX = x as ListViewItem;
            ListViewItem listViewItemY = y as ListViewItem;

            int result = string.Compare(listViewItemX.SubItems[ColumnIndex].Text,
                        listViewItemY.SubItems[ColumnIndex].Text, false);

            if (SortDirection == SortOrder.Descending) 
                return -result;
            else 
                return result;
        }
    }
}
