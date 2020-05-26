using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todozo
{
    /// <summary>
    /// This code design and adds functionality (buttons) to the list container.
    /// </summary>
    public class ListContainer : Panel
    {
        public bool ListClicked { get; set; }
        public int ListID { get; set; }
        public Button name = new Button();
        public Button edit = new Button();
        public ListContainer(List list)
        {
            ListID = list.ListID;
            Name = list.Name;

            //design code for the container itself
            BackColor = Color.FromArgb(235, 236, 240);
            Width = 300;
            Height = 82;

            //design code for the name button 
            Controls.Add(name);
            name.Height = 82;
            name.Width = 250;
            name.Text = list.Name;
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Padding = new Padding(5, 0, 0, 0);
            name.FlatAppearance.BorderColor = Color.FromArgb(235, 236, 240);
            name.FlatAppearance.BorderSize = 0;
            name.FlatStyle = 0;
            name.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0);

            //design code for the edit button

            Controls.Add(edit);
            var editPoint = new Point(250, 20);
            edit.Location = editPoint;
            edit.Image = Properties.Resources.icons8_edit_45;
            edit.FlatAppearance.BorderColor = Color.FromArgb(235, 236, 240);
            edit.FlatAppearance.BorderSize = 0;
            edit.FlatStyle = 0;
            edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 236, 240);
            edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 236, 240);
            edit.Height = 45;
            edit.Width = 45;

            //event handler that executes when the name button is clicked
            void edit_Click(object sender, EventArgs e)
            {
                ListClicked = true;
            }
            //code that adds a new eventhandler to the name button
            name.Click += new EventHandler(edit_Click);
            edit.Click += new EventHandler(edit_Click);
        }
    }
}
