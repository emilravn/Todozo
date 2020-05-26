using System.Drawing;
using System.Windows.Forms;

namespace Todozo
{
    /// <summary>
    /// Code that designs and adds functionality to the view task page.
    /// </summary>
    public class ViewTask : Panel
    {

        public Button goBack = new Button();
        public Button moveTask = new Button();
        public Button completeTask = new Button();
        public Button deleteTask = new Button();

        public static void Font(Label type, float fontsize)
        {
            type.Font = new Font(
                "Segoe UI",
                fontsize,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0);
        }


        public static void FontButton(Button type, float fontsize)
        {
            type.Font = new Font(
                "Segoe UI Light",
                fontsize,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0);
        }

        public ViewTask(TaskContainer task)
        {
            BackColor = Color.FromArgb(235, 236, 240);
            Width = 750;
            Height = 600;
            var panelMargin = new Padding(0, 25, 0, 0);
            Margin = panelMargin;

            //design code for nameLabel 
            Label nameLabel = new Label();
            Controls.Add(nameLabel);
            nameLabel.Text = task.Name;
            Point namePoint = new Point(100, 100);
            nameLabel.Location = namePoint;
            Font(nameLabel, 20F);
            nameLabel.Width = 550;
            nameLabel.Height = 100;

            //design code for descriptionLabel
            Label descriptionLabel = new Label();
            Controls.Add(descriptionLabel);
            descriptionLabel.Text = task.Description;
            Point descriptionPoint = new Point(100, 200);
            descriptionLabel.Location = descriptionPoint;
            descriptionLabel.Width = 550;
            descriptionLabel.Height = 100;
            Font(descriptionLabel, 14F);

            //design code for deadlineLabel
            var deadline = new Label();
            Controls.Add(deadline);
            deadline.Text = $"{task.Deadline}";
            Point deadlinePoint = new Point(100, 311);
            deadline.Location = deadlinePoint;
            deadline.Width = 200;
            deadline.Height = 50;
            Font(deadline, 12F);

            //design code for priorityLabel 
            Label priority = new Label();
            Controls.Add(priority);
            priority.Text = $"{task.Priority}";
            Point priorityPoint = new Point(550, 311);
            priority.Location = priorityPoint;
            priority.Width = 25;
            priority.Height = 50;
            Font(priority, 12F);

            //design code for calenderPicture
            PictureBox calender = new PictureBox();
            calender.Image = Properties.Resources.icons8_calendar_48;
            Controls.Add(calender);
            Point calenderPoint = new Point(300, 300);
            calender.Location = calenderPoint;

            //design code for priorityFlag
            PictureBox priorityFlag = new PictureBox();
            priorityFlag.Image = Properties.Resources.flag_icon;
            Controls.Add(priorityFlag);
            Point priorityFlagPoint = new Point(585, 300);
            priorityFlag.Location = priorityFlagPoint;
            priorityFlag.Width = 44;
            priorityFlag.Height = 39;
            priorityFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            //design code for goBackButton
            Controls.Add(goBack);
            goBack.FlatStyle = FlatStyle.Flat;
            goBack.Location = new Point(173, 500);
            goBack.Name = "GoBackButton";
            goBack.Size = new Size(129, 76);
            goBack.Text = "Go Back";
            FontButton(goBack, 12F);

            //design code for moveTaskButton 
            Controls.Add(moveTask);
            moveTask.FlatStyle = FlatStyle.Flat;
            moveTask.Location = new Point(173, 400);
            moveTask.Name = "MoveTaskButton";
            moveTask.Size = new Size(129, 76);
            moveTask.Text = "Move Task";
            FontButton(moveTask, 12F);

            //design code for completeTaskButton 
            Controls.Add(completeTask);
            completeTask.FlatStyle = FlatStyle.Flat;
            completeTask.Location = new Point(423, 500);
            completeTask.Name = "CompleteTaskButton";
            completeTask.Size = new Size(129, 76);
            completeTask.Text = "Complete Task";
            completeTask.BackColor = Color.FromArgb(62, 191, 92);
            FontButton(completeTask, 12F);

            //design code for deleteTaskButton 
            Controls.Add(deleteTask);
            deleteTask.FlatStyle = FlatStyle.Flat;
            deleteTask.Location = new Point(423, 400);
            deleteTask.Name = "DeleteTaskButton";
            deleteTask.Size = new Size(129, 76);
            deleteTask.Text = "Delete Task";
            deleteTask.BackColor = Color.FromArgb(221, 87, 87);
            FontButton(deleteTask, 12F);
        }
    }
}
