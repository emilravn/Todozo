using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todozo.UI
{
    public partial class UserLoginPage : Form
    {
        public UserLoginPage()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            UserRegistrationPage CreateAccount = new UserRegistrationPage();
            CreateAccount.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (inputTextLoginName.Text == "Name" && inputTextLoginPassword.Text == "Password")
            {
                MessageBox.Show("Please type your account name and password.");
            }

            else if (inputTextLoginName.Text == "Name")
            {
                MessageBox.Show("Please type in your account name.");
            }
            else if (inputTextLoginPassword.Text == "Password")
            {
                MessageBox.Show("Please type in your account password.");
            }
            else
            {
                //DataAccess db = new DataAccess();
                //db.CheckLogin(inputTextLoginName.Text, inputTextLoginPassword.Text);
                MessageBox.Show("Functionality not yet implemented. Account checks needed.");
            }
        }

        private void inputTextLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginName.Text == "Name")
            {
                inputTextLoginName.Text = "";
            }
        }

        private void inputTextLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginPassword.Text == "Password")
            {
                inputTextLoginPassword.Text = "";
            }
        }

        private void inputTextLoginName_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginName.Text == "")
            {
                inputTextLoginName.Text = "Name";
            }
        }

        private void inputTextLoginPassword_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginPassword.Text == "")
            {
                inputTextLoginPassword.Text = "Password";
            }
        }
    }
}
