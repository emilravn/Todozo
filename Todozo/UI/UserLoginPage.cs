using System;
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
            DataAccess db = new DataAccess();
            db.CheckLogin(inputTextLoginName.Text, inputTextLoginPassword.Text);
        }
    }
}
