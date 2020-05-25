using System.Drawing;
using System.Windows.Forms;

namespace Todozo
{
    public class ViewTask : Panel
    {

        public Button goBack = new Button();
        public Button moveTask = new Button(); 
        public Button completeTask = new Button(); 
        public Button deleteTask = new Button(); 

        public ViewTask(TaskContainer task)
        {
            BackColor = System.Drawing.Color.FromArgb(235, 236, 240);
            Width = 750;
            Height = 600;
            var panelMargin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            Margin = panelMargin; 

            //design code for nameLabel 
            Label nameLabel = new Label();
            this.Controls.Add(nameLabel);
            nameLabel.Text = task.Name;
            Point namePoint = new Point(100, 100);
            nameLabel.Location = namePoint;
            nameLabel.Font = new System.Drawing.Font(
            "Microsoft Sans Serif",
            16F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            nameLabel.Width = 550;
            nameLabel.Height = 100;
            //nameLabel.BackColor = Color.Beige;

            //design code for descriptionLabel
            Label descriptionLabel = new Label();
            this.Controls.Add(descriptionLabel);
            descriptionLabel.Text = task.Description;
            Point namePoin = new Point(100, 200);
            descriptionLabel.Location = namePoin;
            descriptionLabel.Width = 550;
            descriptionLabel.Height = 100;
            descriptionLabel.Font = new System.Drawing.Font(
            "Microsoft Sans Serif",
            12F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            //nameLabe.BackColor = Color.Aqua;

            //design code for deadlineLabel
            Label deadline = new Label();
            this.Controls.Add(deadline);
            deadline.Text = $"{task.Deadline}";
            Point deadlinePoint = new Point(100, 311);
            deadline.Location = deadlinePoint;
            deadline.Width = 200;
            deadline.Height = 50;
            deadline.Font = new System.Drawing.Font(
            "Microsoft Sans Serif",
            12F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            //deadline.BackColor = Color.Gold;

            //design code for priorityLabel 
            Label priority = new Label();
            this.Controls.Add(priority);
            priority.Text = $"{task.Priority}";
            Point priorityPoint = new Point(550, 311);
            priority.Location = priorityPoint;
            priority.Width = 25;
            priority.Height = 50;
            priority.Font = new System.Drawing.Font(
            "Microsoft Sans Serif",
            12F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            //priority.BackColor = Color.DarkOrange;

            //design code for calenderPicture
            PictureBox calender = new PictureBox();
            calender.Image = Properties.Resources.icons8_calendar_48;
            this.Controls.Add(calender);
            Point calenderPoint = new Point(300, 300);
            calender.Location = calenderPoint;

            //design code for priorityFlag
            PictureBox priorityFlag = new PictureBox();
            priorityFlag.Image = Properties.Resources.flag_icon;
            this.Controls.Add(priorityFlag);
            Point priorityFlagPoint = new Point(585, 300);
            priorityFlag.Location = priorityFlagPoint;
            priorityFlag.Width = 44;
            priorityFlag.Height = 39;
            priorityFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            //design code for goBackButton
            this.Controls.Add(goBack);
            goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            goBack.Location = new Point(173, 500);
            goBack.Name = "GoBackButton";
            goBack.Size = new System.Drawing.Size(129, 76);
            goBack.Text = "Go back";


            //design code for moveTaskButton 
            this.Controls.Add(moveTask);
            moveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            moveTask.Location = new Point(173, 400);
            moveTask.Name = "MoveTaskButton";
            moveTask.Size = new System.Drawing.Size(129, 76);
            moveTask.Text = "Move task";


            //design code for completeTaskButton 
            this.Controls.Add(completeTask);
            completeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            completeTask.Location = new Point(423, 500);
            completeTask.Name = "CompleteTaskButton";
            completeTask.Size = new System.Drawing.Size(129, 76);
            completeTask.Text = "Complete task"; 
            completeTask.BackColor = System.Drawing.Color.FromArgb(62, 191, 92);

            //design code for deleteTaskButton 
            this.Controls.Add(deleteTask);
            deleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteTask.Location = new Point(423, 400);
            deleteTask.Name = "DeleteTaskButton";
            deleteTask.Size = new System.Drawing.Size(129, 76);
            deleteTask.Text = "Delete task";
            deleteTask.BackColor = System.Drawing.Color.FromArgb(221, 87, 87);
        }

  
    }
}
