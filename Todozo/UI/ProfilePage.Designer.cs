namespace Todozo.UI
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.UserName = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserName.Location = new System.Drawing.Point(0, 0);
            this.UserName.Margin = new System.Windows.Forms.Padding(0);
            this.UserName.Name = "UserName";
            this.UserName.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.UserName.Size = new System.Drawing.Size(484, 82);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Hello @UserName";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(169, 126);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(142, 37);
            this.btnDeleteUser.TabIndex = 8;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "ProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todozo";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}