using System.Drawing;
using System.Windows.Forms;

namespace Todozo
{
    public class ViewTask : Panel
    {




        public ViewTask(TaskContainer task)
        {
            BackColor = System.Drawing.Color.FromArgb(235, 236, 240);
            Width = 750;
            Height = 600;
            var panelMargin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            Margin = panelMargin;

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

            Label nameLabe = new Label();
            this.Controls.Add(nameLabe);
            nameLabe.Text = task.Description;
            Point namePoin = new Point(100, 200);
            nameLabe.Location = namePoin;
            nameLabe.Width = 550;
            nameLabe.Height = 100;
            //nameLabe.BackColor = Color.Aqua;

            Label deadline = new Label();
            this.Controls.Add(deadline);
            deadline.Text = $"{task.Deadline}";

            Point deadlinePoint = new Point(100, 300);
            deadline.Location = deadlinePoint;
            deadline.Width = 200;
            deadline.Height = 100;
            //deadline.BackColor = Color.Gold;

            Label priority = new Label();
            this.Controls.Add(priority);
            priority.Text = $"{task.Priority}";
            Point priorityPoint = new Point(375, 300);
            priority.Location = priorityPoint;
            priority.Width = 200;
            priority.Height = 100;
            //priority.BackColor = Color.DarkOrange;

            PictureBox calender = new PictureBox();
            calender.Image = Properties.Resources.icons8_calendar_48;
            this.Controls.Add(calender);
            Point calenderPoint = new Point(300, 300);
            calender.Location = calenderPoint;

            PictureBox priorityFlag = new PictureBox();
            priorityFlag.Image = Properties.Resources.flag_icon;
            this.Controls.Add(priorityFlag);
            Point priorityFlagPoint = new Point(585, 300);
            priorityFlag.Location = priorityFlagPoint;
            priorityFlag.Width = 44;
            priorityFlag.Height = 39;
            priorityFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            Button goBack = new Button();
            this.Controls.Add(goBack);
           // this.goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            //this.GoBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //his.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            goBack.Location = new Point(173, 500);
            goBack.Name = "GoBackButton";
            goBack.Size = new System.Drawing.Size(129, 76);
           // goBack.TabIndex = 5;
            goBack.Text = "Go back";
            //goBack.UseVisualStyleBackColor = false; 

            Button moveTask = new Button();
            this.Controls.Add(moveTask);
            // this.goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            //this.GoBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //his.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            moveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            moveTask.Location = new Point(173, 400);
            moveTask.Name = "GoBackButton";
            moveTask.Size = new System.Drawing.Size(129, 76);
            // goBack.TabIndex = 5;
            moveTask.Text = "Move task";
            //goBack.UseVisualStyleBackColor = false; 

            Button completeTask = new Button();
            this.Controls.Add(completeTask);
            // this.goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            //this.GoBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //his.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            completeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            completeTask.Location = new Point(423, 500);
            completeTask.Name = "GoBackButton";
            completeTask.Size = new System.Drawing.Size(129, 76);
          //  completeTask.TabIndex = 5;
            completeTask.Text = "Complete task";
            //goBack.UseVisualStyleBackColor = false; 

            Button deleteTask = new Button();
            this.Controls.Add(deleteTask);
            // this.goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            //this.GoBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //his.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            deleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteTask.Location = new Point(423, 400);
            deleteTask.Name = "GoBackButton";
            deleteTask.Size = new System.Drawing.Size(129, 76);
            //  completeTask.TabIndex = 5;
            deleteTask.Text = "Delete task";
            //goBack.UseVisualStyleBackColor = false;
        }


    }
}
