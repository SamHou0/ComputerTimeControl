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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            Lock @lock = new Lock(Convert.ToInt32( timeChooser.Value*60),true);
            @lock.ShowDialog();
        }
    }
}
