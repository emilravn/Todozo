using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todozo.UI;

namespace Todozo
{
    public partial class CreateListPage : Form
    {
        public CreateListPage()
        {
            InitializeComponent();
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            
            db.InsertList(ListNameTextBox.Text, UserLoginPage.activeUser.UserID);

            ListNameTextBox.Text = "";

           
        }

        private void CreateListPage_Load(object sender, EventArgs e)
        {

        }
    }
}
