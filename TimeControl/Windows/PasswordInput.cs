using System;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class PasswordInput : Form
    {
        private string passwordHash;

        public PasswordInput(string passwordHash)
        {
            InitializeComponent();
            this.passwordHash = passwordHash;
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (Password.ComputeHash(passwordTextBox.Text) == passwordHash)
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