﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl
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
    }
}
