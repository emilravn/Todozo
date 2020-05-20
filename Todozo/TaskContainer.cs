using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todozo
{
    public class TaskContainer : Panel
    {

        public int TaskID { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int Priority { get; set; }
        public bool TaskClicked { get; set; } 

        //might delete this one 
        public bool taskCompleted { get; set; }
        public Button viewTask = new Button();
        

        public TaskContainer(Task task)
        {
            Name = task.Name;
            Description = task.Description;
            Deadline = task.Deadline;
            Priority = task.Priority;
            
            

            BackColor = System.Drawing.Color.FromArgb(235, 236, 240);
            
            Width = 383;
            Height = 226; 

            //design code for the priority label
            Label priority = new Label();
            this.Controls.Add(priority);
            priority.Text = $"Priority: {Priority}";
            var priorityPoint = new Point(20, 20);
            priority.Location = priorityPoint;


            //design code for the name label
            Label name = new Label();
            this.Controls.Add(name);
            name.Text = Name;
            var namePoint = new Point(20, 100);
            name.Location = namePoint;
            name.Height = 83;
            name.Width = 250;
            name.Font = new System.Drawing.Font(
           "Microsoft Sans Serif",
           16F,
           System.Drawing.FontStyle.Regular,
           System.Drawing.GraphicsUnit.Point,
           ((byte)(0)));

            //design code for the deadline label
            Label deadline = new Label();
            this.Controls.Add(deadline);
            deadline.Text = $"deadline {Deadline}";
            var deadlinePoint = new Point(20, 185);
            deadline.Location = deadlinePoint;
            deadline.Width = 200;

            //design code for the edit button
            Button edit = new Button();
            this.Controls.Add(edit);
            var editPoint = new Point(305, 10);
            edit.Location = editPoint;
            edit.Image = Properties.Resources.icons8_edit_45;
            edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(235, 236, 240);
            edit.FlatAppearance.BorderSize = 0;
            edit.FlatStyle = 0;
            edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 236, 240);
            edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 236, 240);
            edit.Height = 45;
            edit.Width = 45;

            //eventhandler for the edit button
            void edit_Click(object sender, EventArgs e)
            {

                CreateTaskPage popup = new CreateTaskPage();
                DialogResult dialogresult = popup.ShowDialog();

            }

            //code that creates a new eventhandler for the edit button
            edit.Click += new System.EventHandler(edit_Click);

            void Task_Click(object sender, EventArgs e)
            {
                TaskClicked = true;


            }

            //code that creates a new eventhandler for the edit button
            viewTask.Click += new System.EventHandler(Task_Click);


            //design code for the viewTask button
            this.Controls.Add(viewTask);
            var viewTaskPoint = new Point(305, 100);
            viewTask.Location = viewTaskPoint;
            viewTask.Image = Properties.Resources.icons8_arrow_48;
            viewTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(235, 236, 240);
            viewTask.FlatAppearance.BorderSize = 0;
            viewTask.FlatStyle = 0;
            viewTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 236, 240);
            viewTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 236, 240);
            viewTask.Height = 45;
            viewTask.Width = 45;

            if (Status == true)
            {
                BackColor = System.Drawing.Color.FromArgb(62, 191, 92);
            }

        }




    }
}
