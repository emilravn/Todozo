using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Todozo.UI
{
    /// <summary>
    /// This class is responsible for creating the user account in compliance with the database setup.
    /// A few methods here to check if a user already exists, check what input is being typed by the user and some few additional design stuff.
    /// </summary>
    public partial class UserRegistrationPage : Form
    {
        public UserRegistrationPage()
        {
            InitializeComponent();
        }

        private void GoBackToLogin()
        {
            var LoginPage = new UserLoginPage();
            LoginPage.Show();
            Close();
        }

        public static bool CheckIfUserExist(TextBox input)
        {
            var db = new DataAccess();
            var userExist = false;
            foreach (var user in db.GetUsers().Where(user => input.Text.ToLower().Equals(user.Name.ToLower())))
            {
                userExist = true;
            }
            return userExist;
        }

        private static bool CheckInput(Control type, string text)
        {
            return type.Text == $@"{text}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            if (CheckInput(inputTextLoginName, "Name") && CheckInput(inputTextLoginPassword, "Password") && CheckInput(inputTextLoginRepeatPassword, "Repeat Password"))
            {
                MessageBox.Show(@"Please fill in the fields.");
            }
            else if (CheckIfUserExist(inputTextLoginName))
            {
                MessageBox.Show(@"This user already exist.");
            }
            else if (CheckInput(inputTextLoginName, "Name"))
            {
                MessageBox.Show(@"Please fill in a name.");
            }
            else if (CheckInput(inputTextLoginPassword, "Password"))
            {
                MessageBox.Show(@"Please fill in a password.");
            }
            else if (inputTextLoginPassword.Text != inputTextLoginRepeatPassword.Text && inputTextLoginRepeatPassword.Text != @"Repeat Password")
            {
                MessageBox.Show(@"Passwords do not match.");
            }
            else if (CheckInput(inputTextLoginRepeatPassword, "Repeat Password"))
            {
                MessageBox.Show(@"Please confirm your password.");
            }
            else
            {
                db.AddUser(inputTextLoginName.Text, inputTextLoginPassword.Text);
                MessageBox.Show(@"Account created successfully!");
                GoBackToLogin();
            }
        }

        private void inputTextLoginEmail_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginName.Text != @"Name") return;
            inputTextLoginName.Text = "";
            inputTextLoginName.ForeColor = Color.Black;
        }

        private void inputTextLoginEmail_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginName.Text != "") return;
            inputTextLoginName.Text = @"Name";
            inputTextLoginName.ForeColor = Color.Silver;
        }

        private void inputTextLoginPassword_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginPassword.Text != @"Password") return;
            inputTextLoginPassword.Text = "";
            inputTextLoginPassword.ForeColor = Color.Black;
            inputTextLoginPassword.PasswordChar = '*';
        }

        private void inputTextLoginPassword_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginPassword.Text != "") return;
            inputTextLoginPassword.Text = @"Password";
            inputTextLoginPassword.PasswordChar = '\0';
            inputTextLoginPassword.ForeColor = Color.Silver;
        }

        private void inputTextLoginRepeatPassword_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginRepeatPassword.Text != @"Repeat Password") return;
            inputTextLoginRepeatPassword.Text = "";
            inputTextLoginRepeatPassword.ForeColor = Color.Black;
            inputTextLoginRepeatPassword.PasswordChar = '*';
        }

        private void inputTextLoginRepeatPassword_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginRepeatPassword.Text != "") return;
            inputTextLoginRepeatPassword.Text = @"Repeat Password";
            inputTextLoginRepeatPassword.PasswordChar = '\0';
            inputTextLoginRepeatPassword.ForeColor = Color.Silver;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }
    }
}
