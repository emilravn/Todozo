using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            db.InsertList(ListNameTextBox.Text);

            ListNameTextBox.Text = "";

           
        }

        private void CreateListPage_Load(object sender, EventArgs e)
        {

        }
    }
}
