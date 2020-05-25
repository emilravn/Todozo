namespace Todozo
{
    partial class EditListPage
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
            this.SaveListButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListNameBox = new System.Windows.Forms.TextBox();
            this.CreateListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveListButton
            // 
            this.SaveListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(92)))));
            this.SaveListButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(92)))));
            this.SaveListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveListButton.Location = new System.Drawing.Point(610, 319);
            this.SaveListButton.Name = "SaveListButton";
            this.SaveListButton.Size = new System.Drawing.Size(129, 76);
            this.SaveListButton.TabIndex = 21;
            this.SaveListButton.Text = "Save";
            this.SaveListButton.UseVisualStyleBackColor = false;
            this.SaveListButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.GoBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Location = new System.Drawing.Point(94, 319);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(129, 76);
            this.GoBackButton.TabIndex = 20;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(443, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 76);
            this.button1.TabIndex = 22;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListNameBox
            // 
            this.ListNameBox.Location = new System.Drawing.Point(221, 149);
            this.ListNameBox.Name = "ListNameBox";
            this.ListNameBox.Size = new System.Drawing.Size(351, 22);
            this.ListNameBox.TabIndex = 24;
            this.ListNameBox.TextChanged += new System.EventHandler(this.ListNameBox_TextChanged);
            // 
            // CreateListLabel
            // 
            this.CreateListLabel.AutoSize = true;
            this.CreateListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.CreateListLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateListLabel.Location = new System.Drawing.Point(325, 55);
            this.CreateListLabel.Name = "CreateListLabel";
            this.CreateListLabel.Size = new System.Drawing.Size(178, 52);
            this.CreateListLabel.TabIndex = 25;
            this.CreateListLabel.Text = "Edit List";
            this.CreateListLabel.Click += new System.EventHandler(this.CreateListLabel_Click);
            // 
            // EditListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateListLabel);
            this.Controls.Add(this.ListNameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveListButton);
            this.Controls.Add(this.GoBackButton);
            this.Name = "EditListPage";
            this.Text = "EditList";
            this.Load += new System.EventHandler(this.EditListPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveListButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ListNameBox;
        private System.Windows.Forms.Label CreateListLabel;
    }
}