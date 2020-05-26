using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Todozo.UI;

namespace Todozo
{ 





    public partial class CreateTaskPage : Form
    {
        int PriorityPick = 0;
        bool Status = false;

        public CreateTaskPage()
        {

        InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            PriorityPick = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            //DueDate and Priority needs to be added 
            db.InsertTask(HomePage.listButtonPressed.ListID , TaskNameTextBox.Text, DescriptionTextBox.Text, DateTimePicker.Value, PriorityPick, Status);

            PriorityPick = 0;
            TaskNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateTaskPage_Load(object sender, EventArgs e)
        {
            
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
