using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
