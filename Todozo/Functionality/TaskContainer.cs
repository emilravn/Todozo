using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todozo
{
    /// <summary>
    /// This code designs and adds functionality (buttons) to the task container.
    /// </summary>
    public class TaskContainer : Panel
    {

        public int TaskID { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int Priority { get; set; }
        public bool TaskClicked { get; set; } 

        public Button viewTask = new Button();
        public Button edit = new Button();

        public static void Font(Label type, float fontsize)
        {
            type.Font = new Font(
                "Segoe UI",
                fontsize,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0);
        }

        public TaskContainer(Task task)
        {
            Name = task.Name;
            TaskID = task.TaskID;
            Description = task.Description;
            Deadline = task.Deadline;
            Priority = task.Priority;
            Status = task.Status;
            BackColor = Color.FromArgb(235, 236, 240);
            Width = 383;
            Height = 226; 

            //design code for the priority label
            Label priority = new Label();
            Controls.Add(priority);
            priority.Text = $"Priority: {Priority}";
            var priorityPoint = new Point(20, 20);
            priority.Location = priorityPoint;
            Font(priority, 12F);

            //design code for the name label
            var name = new Label();
            Controls.Add(name);
            name.Text = Name;
            var namePoint = new Point(20, 100);
            name.Location = namePoint;
            name.Height = 83;
            name.Width = 250;
            Font(name, 16F);

            //design code for the deadline label
            Label deadline = new Label();
            Controls.Add(deadline);
            deadline.Text = $"deadline {Deadline}";
            var deadlinePoint = new Point(20, 185);
            deadline.Location = deadlinePoint;
            deadline.Width = 200;
            Font(deadline, 12F);

            //design code for the edit button
            Controls.Add(edit);
            var editPoint = new Point(305, 10);
            edit.Location = editPoint;
            edit.Image = Properties.Resources.icons8_edit_45;
            edit.FlatAppearance.BorderColor = Color.FromArgb(235, 236, 240);
            edit.FlatAppearance.BorderSize = 0;
            edit.FlatStyle = 0;
            edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 236, 240);
            edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 236, 240);
            edit.Height = 45;
            edit.Cursor = Cursors.Hand;
            edit.Width = 45;

            //eventhandler for the edit button
            void edit_Click(object sender, EventArgs e)
            {
                TaskClicked = true; 
            } 

            //code that creates a new eventhandler for the edit button
            edit.Click += new EventHandler(edit_Click);

            void Task_Click(object sender, EventArgs e)
            {
                TaskClicked = true;
            }

            //code that creates a new eventhandler for the edit button
            viewTask.Click += new EventHandler(Task_Click);


            //design code for the viewTask button
            Controls.Add(viewTask);
            var viewTaskPoint = new Point(305, 100);
            viewTask.Location = viewTaskPoint;
            viewTask.Image = Properties.Resources.icons8_arrow_48;
            viewTask.FlatAppearance.BorderColor = Color.FromArgb(235, 236, 240);
            viewTask.FlatAppearance.BorderSize = 0;
            viewTask.FlatStyle = 0;
            viewTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 236, 240);
            viewTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 236, 240);
            viewTask.Height = 45;
            viewTask.Cursor = Cursors.Hand;
            viewTask.Width = 45;

            if (Status)
            {
                BackColor = Color.FromArgb(62, 191, 92);

                edit.FlatAppearance.BorderColor = Color.FromArgb(62, 191, 92);
                edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 191, 92);
                edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 191, 92);

                viewTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 191, 92);
                viewTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 191, 92);
            }
        }
    }
}
