using System;
using System.Windows.Forms;
using Todozo.UI;

namespace Todozo
{
    /// <summary>
    /// Creates a list.
    /// </summary>
    public partial class CreateListPage : Form
    {
        public CreateListPage()
        {
            InitializeComponent();
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            db.InsertList(ListNameTextBox.Text, UserLoginPage.activeUser.UserID);
            ListNameTextBox.Text = "";
        }
    }
}
