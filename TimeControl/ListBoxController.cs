using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl
{
    static internal class ListBoxController
    {
        public static void Refresh(ListBox listBox,List<App> apps)
        {
            listBox.Items.Clear();
            foreach (App app in apps)
            {
                listBox.Items.Add(app.ReportApp());
            }
        }
    }
}
