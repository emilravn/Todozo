namespace Todozo
{
    partial class CreateListPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateListPage));
            this.CreateListButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ListNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateListButton
            // 
            this.CreateListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(92)))));
            this.CreateListButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(92)))));
            this.CreateListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateListButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateListButton.Location = new System.Drawing.Point(280, 150);
            this.CreateListButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateListButton.Name = "CreateListButton";
            this.CreateListButton.Size = new System.Drawing.Size(97, 62);
            this.CreateListButton.TabIndex = 17;
            this.CreateListButton.Text = "Create List";
            this.CreateListButton.UseVisualStyleBackColor = false;
            this.CreateListButton.Click += new System.EventHandler(this.CreateListButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.GoBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(129, 150);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(97, 62);
            this.GoBackButton.TabIndex = 16;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            // 
            // ListNameTextBox
            // 
            this.ListNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ListNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameTextBox.Location = new System.Drawing.Point(129, 96);
            this.ListNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ListNameTextBox.MaxLength = 50;
            this.ListNameTextBox.Name = "ListNameTextBox";
            this.ListNameTextBox.Size = new System.Drawing.Size(248, 22);
            this.ListNameTextBox.TabIndex = 12;
            // 
            // CreateListLabel
            // 
            this.CreateListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateListLabel.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateListLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateListLabel.Location = new System.Drawing.Point(0, 0);
            this.CreateListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateListLabel.Name = "CreateListLabel";
            this.CreateListLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CreateListLabel.Size = new System.Drawing.Size(518, 64);
            this.CreateListLabel.TabIndex = 11;
            this.CreateListLabel.Text = "Create List";
            this.CreateListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(518, 267);
            this.Controls.Add(this.CreateListButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ListNameTextBox);
            this.Controls.Add(this.CreateListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(534, 306);
            this.MinimumSize = new System.Drawing.Size(534, 306);
            this.Name = "CreateListPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todozo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateListButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox ListNameTextBox;
        private System.Windows.Forms.Label CreateListLabel;
    }
}