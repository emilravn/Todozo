using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todozo.UI;

namespace Todozo
{
    public partial class EditListPage : Form
    {
        public EditListPage()
        {
            InitializeComponent();
        }

        private void ListName_Click(object sender, EventArgs e)
        {

        }

        private void EditListPage_Load(object sender, EventArgs e)
        {
            ListNameBox.Text = HomePage.listButtonPressed.Name;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.UpdateList(HomePage.listButtonPressed.ListID, ListNameBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            DataAccess db = new DataAccess();

            if (MessageBox.Show("Are you sure you want to delete the list?", "message", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                 db.DeleteList(HomePage.listButtonPressed.ListID);
            }
            

        }

        private void CreateListLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
