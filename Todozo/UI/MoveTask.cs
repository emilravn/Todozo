using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todozo.UI
{ 
    /// <summary>
    /// Code for the move task page
    /// </summary>
    public partial class Todozo : Form
    { 

        readonly List<ListContainer> selectList = new List<ListContainer>();
        ListContainer selectedList;
        public Todozo()
        {
            InitializeComponent();
        }

        private void MoveTask_Load(object sender, EventArgs e)
        {
            var db = new DataAccess();

            foreach (List i in db.GetLists(UserLoginPage.activeUser.UserID))
            {
                selectList.Add(new ListContainer(i));
            }

            foreach (ListContainer i in selectList)
            {
                selectListFlowLayoutPanel.Controls.Add(i);
                i.name.Click += new EventHandler(List_Move_Click);
            }

          
        }



        void List_Move_Click(object sender, EventArgs e)
        {
            foreach (ListContainer i in selectList)
            {
                if (i.ListClicked)
                {
                    selectedList = i;
                }
            }

            if (MessageBox.Show("Are you sure you want to move the task?", "message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var db = new DataAccess(); 
                db.MoveTask(HomePage.taskButtonPressed.TaskID, selectedList.ListID);
            }

            Close(); 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
