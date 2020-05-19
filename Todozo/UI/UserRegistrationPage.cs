using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todozo.UI
{
    public partial class UserRegistrationPage : Form
    {

        private bool typedInto;

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
                Clear();
            }
        }

        public void Clear()
        {
            inputTextLoginEmail.Text = inputTextLoginPassword.Text = inputTextLoginRepeatPassword.Text = "";
        }

        private void inputTextLoginEmail_Enter(object sender, EventArgs e)
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
    }
}
