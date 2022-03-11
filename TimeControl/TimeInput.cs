using System;
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
    public partial class TimeInput : Form
    {
        private ListController listController;
        private string appName;
        public TimeInput(ListController listController,string appName)
        {
            InitializeComponent();
            this.listController = listController;
            this.appName = appName;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (timeBox.Value==0)
            {
                listController.AddByName(appName);
            }
            else
            {
                listController.AddByName(appName,Convert.ToInt32( timeBox.Value));
            }
            Close();
        }
    }
}
