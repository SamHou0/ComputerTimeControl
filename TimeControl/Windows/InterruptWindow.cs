using System;
using System.Windows.Forms;

namespace TimeControl.Windows
{
    public partial class InterruptWindow : Form
    {
        private int time = 0;
        public static DialogResult result = DialogResult.Cancel;

        public InterruptWindow()
        {
            InitializeComponent();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time++;
            timeLabel.Text = $"你必须再等待{60 - time}秒才能执行该修改！";
            if (time >= 60)
            {
                result = DialogResult.OK;
                Close();
            }
        }
    }
}