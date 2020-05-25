using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Todozo.UI;

namespace Todozo
{
    public partial class HomePage : Form
    {

        //lists used to store information from database 
        List<ListContainer> containerLists = new List<ListContainer>();
        List<TaskContainer> contaionerTasks = new List<TaskContainer>(); 

        //variable that stores information about the list which is selected 
        public static ListContainer listButtonPressed;
        public static TaskContainer taskButtonPressed;
        


        public HomePage()
        {
            InitializeComponent();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelTask_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListButton_Click(object sender, System.EventArgs e)
        {

        }

        //code that runs when the application starts 
        private void HomePage_Load(object sender, EventArgs e)
        {
            UserName.Text = $"Logged in as {UserLoginPage.activeUser.Name}";
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation. 
            Rectangle resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            
            if (resolution.Width == 1920 && resolution.Height == 1080)
            {
                int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
                int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
                float scaleFactorWidth = (float)ourScreenWidth / 1440f;
                float scaleFactorHeigth = (float)ourScreenHeight / 900f;
                SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
                Scale(scaleFactor); 

            }




            UpdateLists();
            //ViewTask testTask = new ViewTask();
           // flowLayoutPanelTask.Controls.Add(testTask);
        }


        


        private void button1_Click(object sender, EventArgs e)
        {


        }


        #region Buttons

        //create list button
        private void CreateListButton_Click(object sender, EventArgs e)
        {
            CreateListPage popup = new CreateListPage();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();

            UpdateLists();
        }

        //create task button 
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            CreateTaskPage popup = new CreateTaskPage();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();

            UpdateTasks(listButtonPressed);
        } 

        //eventhandler that executes if a list i clicked on  
        //maybe make eventhandler public and move to homePage like the rest, and then delete listClicked bool 
        void List_Click(object sender, EventArgs e)
        {
            foreach (ListContainer i in containerLists)
            {
                if (i.ListClicked == true)
                {
                    UpdateTasks(i);
                    listButtonPressed = i;
                    i.ListClicked = false;
                }
            }
        } 

            //eventhandler that executes when the viewTask button is pressed 
            void viewTask_Click(object sender, EventArgs e)
            {
                
                

                foreach (TaskContainer i in contaionerTasks)
                {
                    if (i.TaskClicked == true)
                    { 
                        flowLayoutPanelTask.Controls.Clear();
                        ViewTask viewTask = new ViewTask(i);
                    viewTask.goBack.Click += new System.EventHandler(viewTask_Click_goBack);
                    viewTask.moveTask.Click += new System.EventHandler(viewTask_Click_moveTask);
                    viewTask.completeTask.Click += new System.EventHandler(viewTask_Click_completeTask);
                    viewTask.deleteTask.Click += new System.EventHandler(viewTask_Click_deleteTask);
                    flowLayoutPanelTask.Controls.Add(viewTask);
                    taskButtonPressed = i;   
                        
                    }
                }


            }

        void editTask_Click(object sender, EventArgs e)
        { 



            foreach (TaskContainer i in contaionerTasks)
            {
                if (i.TaskClicked == true)
                {
                    taskButtonPressed = i;
                }



                
            }




            EditTaskPage popup = new EditTaskPage();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();


            flowLayoutPanelTask.Controls.Clear();
            UpdateTasks(listButtonPressed); 
        }
        void viewTask_Click_goBack(object sender, EventArgs e)
        {
            flowLayoutPanelTask.Controls.Clear();
            UpdateTasks(listButtonPressed);
        }

        void viewTask_Click_moveTask(object sender, EventArgs e)
        {

        } 

        //when button is pressed, save bool to database, and retreive it again 
        void viewTask_Click_completeTask(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            
            flowLayoutPanelTask.Controls.Clear();

            db.InsertStatus(taskButtonPressed.TaskID);
            UpdateTasks(listButtonPressed);
            
        } 
        void viewTask_Click_deleteTask(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            flowLayoutPanelTask.Controls.Clear();
            db.DeleteTask(taskButtonPressed.TaskID);
            UpdateTasks(listButtonPressed);
        }

        void List_Click_editList(object sender, EventArgs e)
        {
            foreach (ListContainer i in containerLists)
            {
                if (i.ListClicked == true)
                {

                    listButtonPressed = i; 
                    EditListPage popup = new EditListPage();
                    DialogResult dialogresult = popup.ShowDialog();
                    popup.Dispose();
                    
                    i.ListClicked = false; 
                    
                }
            }

            UpdateLists();

        }



        #endregion

        #region Update functions 

        //Function that clears the Container list and Flowlayoutpanel, and updates it accordingly to the data in the database 
        public void UpdateLists()
        {


            DataAccess db = new DataAccess();
            containerLists.Clear();
            flowLayoutPanelList.Controls.Clear();

            foreach (List i in db.GetLists(UserLoginPage.activeUser.UserID))
            {
                containerLists.Add(new ListContainer(i));
            }

            foreach (ListContainer i in containerLists)
            {
                flowLayoutPanelList.Controls.Add(i);
            }

            foreach (ListContainer i in containerLists)
            {

                i.name.Click += new System.EventHandler(List_Click);
                i.edit.Click += new System.EventHandler(List_Click_editList);

            }
            //Potentionally instead make a function that checks if the container class is already there, then dont add it again 


        }

       
        
        //function that clears the ContaionerTasks list and updates it accordingly to the data in the database
        public void UpdateTasks(ListContainer list)
        {
            DataAccess db = new DataAccess();
            contaionerTasks.Clear();
            flowLayoutPanelTask.Controls.Clear();

            foreach (Task i in db.GetTasks(list.ListID))
            {
                contaionerTasks.Add(new TaskContainer(i));
            }

            foreach (TaskContainer i in contaionerTasks)
            {
                flowLayoutPanelTask.Controls.Add(i); 
                i.viewTask.Click += new System.EventHandler(viewTask_Click);
                i.edit.Click += new System.EventHandler(editTask_Click);
            }




            //code that creates a new eventhandler for the edit button
            
        }








        #endregion

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            
            UserLoginPage userLoginPage = new UserLoginPage();
            userLoginPage.Show(); 
            Close();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfilePage profileButton = new ProfilePage();
            profileButton.Show();
        }
    }
}
