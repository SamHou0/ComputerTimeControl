using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeControl.AppControl;

namespace TimeControl.Windows
{
    public partial class LimitWarningWindow : Form
    {
        LimitedApp warningApp;
        public LimitWarningWindow(LimitedApp warningApp)
        {
            InitializeComponent();
            displayLabel.Text = $"应用{warningApp.appInformation.name}即将达到时间限制，请保存所有工作，然后提前关闭进程";
            this.warningApp = warningApp;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            warningApp.Ban();//禁用掉app
            Close();
        }
    }
}
