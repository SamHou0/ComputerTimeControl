using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeControl
{
    public partial class PasswordInput : Form
    {
        private int passwordHash;
        public PasswordInput(int passwordHash)
        {
            InitializeComponent();
            this.passwordHash = passwordHash;
            DialogResult = DialogResult.No;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.GetHashCode()==passwordHash)
            {
                File.Delete(TimeControlFile.PassLocation);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("密码错误！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
