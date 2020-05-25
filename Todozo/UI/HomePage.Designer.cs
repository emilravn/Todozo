namespace Todozo
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.CreateListButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelTask = new System.Windows.Forms.FlowLayoutPanel();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.TopPanel.Controls.Add(this.UserName);
            this.TopPanel.Controls.Add(this.LogoutButton);
            this.TopPanel.Controls.Add(this.ProfileButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1136, 81);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserName.Location = new System.Drawing.Point(1050, 0);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Padding = new System.Windows.Forms.Padding(0, 24, 7, 0);
            this.UserName.Size = new System.Drawing.Size(86, 45);
            this.UserName.TabIndex = 6;
            this.UserName.Text = "UserName";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoutButton.Location = new System.Drawing.Point(0, 46);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(89, 31);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Log-out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProfileButton.Location = new System.Drawing.Point(11, 11);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(66, 31);
            this.ProfileButton.TabIndex = 2;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BottomPanel.Controls.Add(this.CreateTaskButton);
            this.BottomPanel.Controls.Add(this.CreateListButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 620);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1136, 76);
            this.BottomPanel.TabIndex = 1;
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateTaskButton.FlatAppearance.BorderSize = 0;
            this.CreateTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTaskButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateTaskButton.Image")));
            this.CreateTaskButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateTaskButton.Location = new System.Drawing.Point(655, 0);
            this.CreateTaskButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(82, 67);
            this.CreateTaskButton.TabIndex = 2;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // CreateListButton
            // 
            this.CreateListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateListButton.FlatAppearance.BorderSize = 0;
            this.CreateListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateListButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateListButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateListButton.Image")));
            this.CreateListButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateListButton.Location = new System.Drawing.Point(82, 0);
            this.CreateListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateListButton.Name = "CreateListButton";
            this.CreateListButton.Size = new System.Drawing.Size(81, 67);
            this.CreateListButton.TabIndex = 1;
            this.CreateListButton.Text = "Create List";
            this.CreateListButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateListButton.UseVisualStyleBackColor = false;
            this.CreateListButton.Click += new System.EventHandler(this.CreateListButton_Click);
            // 
            // flowLayoutPanelList
            // 
            this.flowLayoutPanelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelList.AutoScroll = true;
            this.flowLayoutPanelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.flowLayoutPanelList.Location = new System.Drawing.Point(0, 81);
            this.flowLayoutPanelList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelList.Name = "flowLayoutPanelList";
            this.flowLayoutPanelList.Size = new System.Drawing.Size(247, 527);
            this.flowLayoutPanelList.TabIndex = 2;
            this.flowLayoutPanelList.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanelTask
            // 
            this.flowLayoutPanelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTask.AutoScroll = true;
            this.flowLayoutPanelTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.flowLayoutPanelTask.Location = new System.Drawing.Point(268, 81);
            this.flowLayoutPanelTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelTask.Name = "flowLayoutPanelTask";
            this.flowLayoutPanelTask.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.flowLayoutPanelTask.Size = new System.Drawing.Size(858, 527);
            this.flowLayoutPanelTask.TabIndex = 3;
            this.flowLayoutPanelTask.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelTask_Paint);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1136, 696);
            this.Controls.Add(this.flowLayoutPanelList);
            this.Controls.Add(this.flowLayoutPanelTask);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1152, 657);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTask;
        private System.Windows.Forms.Button CreateListButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Label UserName;
    }
}