using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Todozo.UI
{
    public partial class HomePage : Form
    {

        //lists used to store information from database 
       readonly List<ListContainer> containerLists = new List<ListContainer>();
        readonly List<TaskContainer> containerTasks = new List<TaskContainer>();

        //variable that stores information about the list which is selected 
        public static ListContainer listButtonPressed;
        public static TaskContainer taskButtonPressed; 

        taskFlowLayoutPanel flowLayoutPanelTask = new taskFlowLayoutPanel();
        ViewTaskPanel panelViewTask = new ViewTaskPanel(); 


        public HomePage()
        {
            InitializeComponent();
        }

        public void PopUp(Form popup)
        {
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose(); 
        } 

        public void InsertViewPanel(Panel viewTask)
        {
            flowLayoutPanelTask.Controls.Clear();
            this.Controls.Remove (flowLayoutPanelTask);
            this.Controls.Add(panelViewTask); 
            panelViewTask.Controls.Add(viewTask);
            panelViewTask.Size = flowLayoutPanelTask.Size;
        } 

        public void RemoveViewPanel()
        {
            panelViewTask.Controls.Clear();
            this.Controls.Remove(panelViewTask);
            this.Controls.Add(flowLayoutPanelTask);
            flowLayoutPanelTask.Size = panelViewTask.Size;
        }

        #region SystemFunctionsEmptyMethods

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

        #endregion

        private void HomePage_Load(object sender, EventArgs e)
        {
            UserName.Text = $"Logged in as {UserLoginPage.activeUser.Name}";
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation. 
            // Executed if the program is run on a 1920x1080 resolution.
            var resolution = Screen.PrimaryScreen.Bounds;

            if (resolution.Width == 1920 && resolution.Height == 1080)
            {
                var ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
                var ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
                var scaleFactorWidth = ourScreenWidth / 1440f;
                var scaleFactorHeight = ourScreenHeight / 900f;
                var scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeight);
                Scale(scaleFactor);
            }
            UpdateLists();
            this.Controls.Add(flowLayoutPanelTask);
        }

        #region Buttons

        // Create list button
        private void CreateListButton_Click(object sender, EventArgs e)
        {
            var popup = new CreateListPage();
            PopUp(popup);

            listButtonPressed = null;
            UpdateLists();
            flowLayoutPanelTask.Controls.Clear();
        }

        //create task button 
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            if (listButtonPressed == null)
            {
                MessageBox.Show("You need to pick a list first");
            }
            else
            {

                var popup = new CreateTaskPage();
                PopUp(popup);

                UpdateTasks(listButtonPressed);
            }

        }

        //eventhandler that executes if a list i clicked on  
        void List_Click(object sender, EventArgs e)
        {
            panelViewTask.Controls.Clear();
            this.Controls.Remove(panelViewTask);
            this.Controls.Add(flowLayoutPanelTask);
            //RemoveViewPanel();
            foreach (ListContainer i in containerLists)
            {
                i.name.BackColor = Color.FromArgb(235, 236, 240);
                if (i.ListClicked)
                {
                    UpdateTasks(i);
                    listButtonPressed = i;
                    i.ListClicked = false;
                    listButtonPressed.name.BackColor = Color.LightSlateGray;
                }
            }
        }

        //eventhandler that executes when the viewTask button is pressed 
        void viewTask_Click(object sender, EventArgs e)
        {
            foreach (TaskContainer i in containerTasks)
            {
                if (i.TaskClicked)
                {
                    ViewTask viewTask = new ViewTask(i);
                    viewTask.goBack.Click += new EventHandler(viewTask_Click_goBack);
                    viewTask.moveTask.Click += new EventHandler(viewTask_Click_moveTask);
                    viewTask.completeTask.Click += new EventHandler(viewTask_Click_completeTask);
                    viewTask.deleteTask.Click += new EventHandler(viewTask_Click_deleteTask);
                    InsertViewPanel(viewTask);
                    taskButtonPressed = i;
                }
            }
        }



        void editTask_Click(object sender, EventArgs e)
        {
            foreach (TaskContainer i in containerTasks)
            {
                if (i.TaskClicked)
                {
                    taskButtonPressed = i;
                }
            }
            var popup = new EditTaskPage();
            PopUp(popup);

            flowLayoutPanelTask.Controls.Clear();
            UpdateTasks(listButtonPressed);
        }
        void viewTask_Click_goBack(object sender, EventArgs e)
        {
            RemoveViewPanel();
            UpdateTasks(listButtonPressed); 
        }

        void viewTask_Click_moveTask(object sender, EventArgs e)
        {
            var popup = new Todozo();
            PopUp(popup);
            RemoveViewPanel();
            UpdateTasks(listButtonPressed);

        }

        // When button is pressed, save bool to database, and retreive it again 
        void viewTask_Click_completeTask(object sender, EventArgs e)
        {
            var db = new DataAccess();


            RemoveViewPanel();
            db.InsertStatus(taskButtonPressed.TaskID);
            UpdateTasks(listButtonPressed);

        }
        void viewTask_Click_deleteTask(object sender, EventArgs e)
        {
            var db = new DataAccess();

            if (MessageBox.Show("Are you sure you want to delete the task?", "message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                flowLayoutPanelTask.Controls.Clear();
                db.DeleteTask(taskButtonPressed.TaskID);
            }

            RemoveViewPanel();
            UpdateTasks(listButtonPressed);
        }

        void List_Click_editList(object sender, EventArgs e)
        {
            foreach (ListContainer i in containerLists)
            {
                if (i.ListClicked)
                {
                    listButtonPressed = i;
                    EditListPage popup = new EditListPage();
                    PopUp(popup);

                    i.ListClicked = false;
                }
            }
            UpdateLists();
            flowLayoutPanelTask.Controls.Clear(); 
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

            var userLoginPage = new UserLoginPage();
            userLoginPage.Show();
            Close();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            var profileButton = new ProfilePage();
            profileButton.Show();
        }

        #endregion

        #region Update functions 

        //Function that clears the Container list and Flowlayoutpanel, and updates it accordingly to the data in the database 
        private void UpdateLists()
        {
            var db = new DataAccess();
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
                i.name.Click += new EventHandler(List_Click);
                i.edit.Click += new EventHandler(List_Click_editList);
            }
        }



        // Function that clears the ContainerTasks list and updates it accordingly to the data in the database
        private void UpdateTasks(ListContainer list)
        {
            var db = new DataAccess();
            containerTasks.Clear();
            flowLayoutPanelTask.Controls.Clear();

            foreach (Task i in db.GetTasks(list.ListID))
            {
                containerTasks.Add(new TaskContainer(i));
            }

            foreach (TaskContainer i in containerTasks)
            {
                flowLayoutPanelTask.Controls.Add(i);
                i.viewTask.Click += new System.EventHandler(viewTask_Click);
                i.edit.Click += new System.EventHandler(editTask_Click);
            }
            //code that creates a new eventhandler for the edit button
        }

        #endregion


    }
}
