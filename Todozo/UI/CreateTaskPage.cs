using System;
using System.Windows.Forms;
using Todozo.UI;

namespace Todozo
{
    /// <summary>
    /// Creates a task.
    /// </summary>
    public partial class CreateTaskPage : Form
    {
        int PriorityPick;
        bool Status = false;

        public CreateTaskPage()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 2;
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            db.InsertTask(HomePage.listButtonPressed.ListID, TaskNameTextBox.Text, DescriptionTextBox.Text, DateTimePicker.Value, PriorityPick, Status);

            PriorityPick = 0;
            TaskNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 4;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 5;
        }
    }
}
