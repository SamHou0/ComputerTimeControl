using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class Planner : Form
    {
        private List<Data.Task> tasks;

        public Planner(List<Data.Task> tasks)
        {
            InitializeComponent();
            this.tasks=tasks; 
            foreach(Data.Task task in this.tasks)
            {
                taskListBox.Items.Add(task);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                tasks.Add(new Data.Task(taskNameTextBox.Text,
                    new TimeSpan(0, (int)timeBox.Value, 0),
                    focusBox.Checked, deepFocusBox.Checked));
            }
            RefreshForm();
        }

        private bool CheckInfo()
        {
            return !string.IsNullOrEmpty(taskNameTextBox.Text);
        }

        private void RefreshForm()
        {
            taskListBox.Items.Clear();
            foreach (Data.Task task in tasks)
            {
                taskListBox.Items.Add(task);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                tasks.RemoveAt(taskListBox.SelectedIndex);
            }
            RefreshForm();
        }

        private void Planner_FormClosed(object sender, FormClosedEventArgs e)
        {
            TCFile.SaveTasks(tasks);
        }
    }
}