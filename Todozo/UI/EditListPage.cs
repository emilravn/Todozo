using System;
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

        private void EditListPage_Load(object sender, EventArgs e)
        {
            ListNameBox.Text = HomePage.listButtonPressed.Name;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            db.UpdateList(HomePage.listButtonPressed.ListID, ListNameBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            if (MessageBox.Show("Are you sure you want to delete the list?", "message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.DeleteList(HomePage.listButtonPressed.ListID);
            }
        }
    }
}
