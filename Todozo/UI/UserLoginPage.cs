using System;
using System.Drawing;
using System.Windows.Forms;
using Todozo.Models;

namespace Todozo.UI
{
    public partial class UserLoginPage : Form
    {
        public static User activeUser;
        public UserLoginPage()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            UserRegistrationPage CreateAccount = new UserRegistrationPage();
            CreateAccount.Show(); 
            Close();
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
                DataAccess db = new DataAccess();
                UserRegistrationPage.CheckIfUserExist(inputTextLoginName);
                if (!UserRegistrationPage.CheckIfUserExist(inputTextLoginName))
                {
                    MessageBox.Show("account does not exist");
                }

                foreach (var user in db.CheckLogin(inputTextLoginName.Text))
                {
                    string dbPassword = Convert.ToString(user.Password);
                    string dbUserGuid = Convert.ToString(user.UserGuid);

                    // Now we hash the UserGuid from the database with the password we wan't to check
                    // In the same way as when we saved it to the database in the first place. (see AddUser() function)
                    string hashedPassword = DataAccess.HashSHA1(inputTextLoginPassword.Text + dbUserGuid);

                    if (dbPassword == hashedPassword)
                    {
                        activeUser = user;
                        HomePage homePage = new HomePage();
                        homePage.Show(); 
                        Close();
                    } 
                    else
                    {
                        MessageBox.Show("Password does not match account name");
                    }
                }
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
                // The password character is an asterisk.
                inputTextLoginPassword.PasswordChar = '*';
                // The control will allow no more than 30 characters.
                inputTextLoginPassword.MaxLength = 30;
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
                inputTextLoginPassword.PasswordChar = '\0';
            }
        }
    }
}
