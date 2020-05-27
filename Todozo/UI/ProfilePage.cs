using System;
using System.Windows.Forms;

namespace Todozo.UI
{
    /// <summary>
    /// Shows who is logged in and able to delete the user along all of its contents.
    /// </summary>
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            UserName.Text = $@"Hello {UserLoginPage.activeUser.Name}!";
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show(@"Are you sure you want to delete this user along with all of its data?",
                @"Confirm",
                MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                // Deletes the user and all of its content.
                var db = new DataAccess();
                db.DeleteUser(UserLoginPage.activeUser.UserID);
                Application.Restart();

            }
            else
            {
                MessageBox.Show(@"User NOT deleted.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
