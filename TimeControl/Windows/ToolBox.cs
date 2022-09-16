using System;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class ToolBox : Form
    {
        public ToolBox(string[] whiteList)
        {
            InitializeComponent();
            whiteListBox.Items.Clear();
            foreach (string whiteProcess in whiteList)
            {
                whiteListBox.Items.Add(whiteProcess);
            }
        }

        private void whiteListBox_DoubleClick(object sender, EventArgs e)
        {
            if (whiteListBox.SelectedItems.Count > 0)
            {
                Dllimport.STARTUPINFO sTARTUPINFO = new();
                sTARTUPINFO.lpDesktop = "Lock";
                Dllimport.PROCESS_INFORMATION pROCESS_INFORMATION = new();
                Dllimport.CreateProcess(whiteListBox.SelectedItem.ToString(), null, IntPtr.Zero, IntPtr.Zero, true, 0, IntPtr.Zero, null, ref sTARTUPINFO,
                    ref pROCESS_INFORMATION);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "当前时间：" + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}