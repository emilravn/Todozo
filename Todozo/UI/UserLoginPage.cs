using System;
using System.Windows.Forms;
using Todozo.Models;

namespace Todozo.UI
{
    /// <summary>
    /// This class is responsible for handling user login. A variable activeUser is declared to check which user is logged into the system.
    /// From here, upon login we convert the password into hashed password stored in the DB made upon registration, check AddUser() method in DataAccess.CS.
    /// Finally, a few design stuff is done here.
    /// </summary>
    public partial class UserLoginPage : Form
    {
        public static User activeUser;
        public UserLoginPage()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var CreateAccount = new UserRegistrationPage();
            CreateAccount.Show();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch (inputTextLoginName.Text)
            {
                case @"Name" when inputTextLoginPassword.Text == @"Password":
                    MessageBox.Show(@"Please type your account name and password.");
                    break;
                case @"Name":
                    MessageBox.Show(@"Please type in your account name.");
                    break;
                default:
                    {
                        if (inputTextLoginPassword.Text == @"Password")
                        {
                            MessageBox.Show(@"Please type in your account password.");
                        }
                        else
                        {
                            var db = new DataAccess();
                            UserRegistrationPage.CheckIfUserExist(inputTextLoginName);
                            if (!UserRegistrationPage.CheckIfUserExist(inputTextLoginName))
                            {
                                MessageBox.Show(@"Account does not exist.");
                            }
                            foreach (var user in db.CheckLogin(inputTextLoginName.Text))
                            {
                                var dbPassword = Convert.ToString(user.Password);
                                var dbUserGuid = Convert.ToString(user.UserGuid);
                                var hashedPassword = DataAccess.HashSHA1(inputTextLoginPassword.Text + dbUserGuid);

                                if (dbPassword == hashedPassword)
                                {
                                    activeUser = user;
                                    var homePage = new HomePage();
                                    homePage.Show();
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show(@"Password does not match account name");
                                }
                            }
                        }
                        break;
                    }
            }
        }

        private void inputTextLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginName.Text == @"Name")
            {
                inputTextLoginName.Text = "";
            }
        }

        private void inputTextLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginPassword.Text != @"Password") return;
            inputTextLoginPassword.Text = "";
            inputTextLoginPassword.PasswordChar = '*';
            inputTextLoginPassword.MaxLength = 30;
        }

        private void inputTextLoginName_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginName.Text == "")
            {
                inputTextLoginName.Text = @"Name";
            }
        }

        private void inputTextLoginPassword_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginPassword.Text != "") return;
            inputTextLoginPassword.Text = @"Password";
            inputTextLoginPassword.PasswordChar = '\0';
        }
    }
}
