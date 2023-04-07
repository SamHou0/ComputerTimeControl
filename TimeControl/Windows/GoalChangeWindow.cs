using System;
using System.IO;
using System.Windows.Forms;
using TimeControl.Data;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class GoalChangeWindow : Form
    {
        public GoalChangeWindow()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            goalLabel.Text = "当前：" + TCFile.ReadTimeData().GoalName;
            goalListBox.Items.Clear();
            string[] strs = TCFile.SavedDataFiles;
            foreach (string str in strs)
            {
                goalListBox.Items.Add(Path.GetFileNameWithoutExtension(str));
            }
        }

        private void GoalChangeWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            SystemControl.ProgramRestart();
        }

        private void GoalChangeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("需要重启应用来应用更改，确认继续？",
                "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (TCFile.ReadTimeData().GoalName == goalTextBox.Text)
            {
                MessageBox.Show("无法添加重复目标！", "错误"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (string str in goalListBox.Items)
            {
                if (goalTextBox.Text == str)
                {
                    MessageBox.Show("无法添加重复目标！", "错误"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(goalTextBox.Text))
            {
                TimeData timeData = new() { GoalName = goalTextBox.Text };
                TCFile.AddGoal(timeData);
                goalListBox.Items.Add(goalTextBox.Text);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (goalListBox.SelectedIndex >= 0)
            {
                TCFile.ChangeGoal(goalListBox.Items[goalListBox.SelectedIndex].ToString());
                RefreshForm();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (goalListBox.SelectedIndex >= 0)
            {
                TCFile.RemoveGoal(goalListBox.Items[goalListBox.SelectedIndex].ToString());
                RefreshForm();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            TimeData timeData = TCFile.ReadTimeData();
            timeData.GoalName = goalTextBox.Text;
            TCFile.SaveTimeData(timeData);
            RefreshForm();
        }
    }
}