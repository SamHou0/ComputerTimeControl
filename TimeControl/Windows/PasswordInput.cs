using System;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class PasswordInput : Form
    {
        public PasswordInput()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (Password.ComputeHash(passwordTextBox.Text) == Password.unlockPasswordHash)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}