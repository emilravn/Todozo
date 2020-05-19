using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todozo.UI
{
    public partial class UserRegistrationPage : Form
    {
        public UserRegistrationPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (inputTextLoginEmail.Text == "" && inputTextLoginPassword.Text == "")
            {
                MessageBox.Show("Please fill in both a name and a password.");
            }

            else if (inputTextLoginEmail.Text == "")
            {
                MessageBox.Show("Please fill in a name.");
            }
            else if (inputTextLoginPassword.Text == "")
            {
                MessageBox.Show("Please fill in a password.");
            }
            else if (inputTextLoginPassword.Text != inputTextLoginRepeatPassword.Text && inputTextLoginRepeatPassword.Text != "")
            {
                MessageBox.Show("Passwords do not match.");
            }
            else if (inputTextLoginRepeatPassword.Text == "")
            {
                MessageBox.Show("Please confirm your password.");
            }
            else
            {
                DataAccess db = new DataAccess();
                db.AddUser(0, inputTextLoginEmail.Text, inputTextLoginPassword.Text);
                MessageBox.Show("Account created successfully!");
            }
        }

        private void inputTextLoginEmail_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginEmail.Text == "Name")
            {
                inputTextLoginEmail.Text = "";
                inputTextLoginEmail.ForeColor = Color.Black;
            }
        }

        private void inputTextLoginEmail_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginEmail.Text == "")
            {
                inputTextLoginEmail.Text = "Name";
                inputTextLoginEmail.ForeColor = Color.Silver;
            }
        }

        private void inputTextLoginPassword_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginPassword.Text == "Password")
            {
                inputTextLoginPassword.Text = "";
                inputTextLoginPassword.ForeColor = Color.Black;
                // The password character is an asterisk.
                inputTextLoginPassword.PasswordChar = '*';
                // The control will allow no more than 30 characters.
                inputTextLoginPassword.MaxLength = 30;
            }
        }

        private void inputTextLoginPassword_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginPassword.Text == "")
            {
                inputTextLoginPassword.Text = "Password";
                inputTextLoginPassword.ForeColor = Color.Silver;
            }
        }

        private void inputTextLoginRepeatPassword_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (inputTextLoginRepeatPassword.Text == "Repeat Password")
            {
                inputTextLoginRepeatPassword.Text = "";
                inputTextLoginRepeatPassword.ForeColor = Color.Black;
                inputTextLoginRepeatPassword.PasswordChar = '*';
                inputTextLoginRepeatPassword.MaxLength = 30;
            }
        }

        private void inputTextLoginRepeatPassword_Leave(object sender, EventArgs e)
        {
            if (inputTextLoginRepeatPassword.Text == "")
            {
                inputTextLoginRepeatPassword.Text = "Repeat Password";
                inputTextLoginRepeatPassword.ForeColor = Color.Silver;
            }
        }
    }
}
