using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todozo
{ 
    
    public partial class EditTaskPage : Form
    {
        int PriorityPick = 0;
         TaskContainer task = HomePage.taskButtonPressed;
        public EditTaskPage()
        { 
           
            InitializeComponent();
        }

        private void TaskNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EditTaskPage_Load(object sender, EventArgs e)
        {
            
            TaskNameTextBox.Text = task.Name;
            DescriptionTextBox.Text = task.Description;
            DateTimePicker.Value = task.Deadline;
            switch (task.Priority)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radioButton4.Checked = true;
                    break;
                case 5:
                    radioButton5.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.UpdateTask(task.TaskID, TaskNameTextBox.Text, DescriptionTextBox.Text, DateTimePicker.Value, PriorityPick);
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 4; 
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 5; 
        }
    }
}
