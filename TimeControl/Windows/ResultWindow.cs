using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl.Windows
{
    public partial class ResultWindow : Form
    {
        public ResultWindow(TimeSpan timeSpan)
        {
            InitializeComponent();
            resultLabel.Text= "本次时长："+timeSpan.ToString();
        }
    }
}
