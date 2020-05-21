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
        public EditTaskPage()
        {
            InitializeComponent();
        }

        private void TaskNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditTaskPage_Load(object sender, EventArgs e)
        {
            var task = HomePage.taskButtonPressed;
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
    }
}
