namespace Todozo
{
    partial class CreateTaskPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTaskPage));
            this.CreateTaskLabel = new System.Windows.Forms.Label();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TaskDescriptionLabel = new System.Windows.Forms.Label();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateTaskLabel
            // 
            this.CreateTaskLabel.AutoSize = true;
            this.CreateTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.CreateTaskLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateTaskLabel.Location = new System.Drawing.Point(158, 23);
            this.CreateTaskLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateTaskLabel.Name = "CreateTaskLabel";
            this.CreateTaskLabel.Size = new System.Drawing.Size(195, 39);
            this.CreateTaskLabel.TabIndex = 0;
            this.CreateTaskLabel.Text = "Create task";
            this.CreateTaskLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.TaskNameTextBox.Location = new System.Drawing.Point(123, 110);
            this.TaskNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaskNameTextBox.MaxLength = 50;
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(248, 20);
            this.TaskNameTextBox.TabIndex = 1;
            this.TaskNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.DescriptionTextBox.Location = new System.Drawing.Point(123, 167);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionTextBox.MaxLength = 500;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(248, 148);
            this.DescriptionTextBox.TabIndex = 2;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.DateTimePicker.Location = new System.Drawing.Point(123, 370);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(248, 20);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(123, 448);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 42);
            this.panel1.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(218, 15);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "5";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(165, 15);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "4";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(104, 15);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "3";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(50, 15);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "2";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(2, 15);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.GoBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Location = new System.Drawing.Point(123, 553);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(97, 62);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(92)))));
            this.CreateTaskButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(92)))));
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Location = new System.Drawing.Point(272, 553);
            this.CreateTaskButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(97, 62);
            this.CreateTaskButton.TabIndex = 6;
            this.CreateTaskButton.Text = "Create task";
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(224, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Priority";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DueDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DueDateLabel.Location = new System.Drawing.Point(224, 337);
            this.DueDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(67, 18);
            this.DueDateLabel.TabIndex = 9;
            this.DueDateLabel.Text = "Due date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 448);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TaskDescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(210, 137);
            this.TaskDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskDescriptionLabel.Name = "TaskDescriptionLabel";
            this.TaskDescriptionLabel.Size = new System.Drawing.Size(83, 18);
            this.TaskDescriptionLabel.TabIndex = 11;
            this.TaskDescriptionLabel.Text = "Description";
            this.TaskDescriptionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TaskNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaskNameLabel.Location = new System.Drawing.Point(227, 77);
            this.TaskNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(48, 18);
            this.TaskNameLabel.TabIndex = 12;
            this.TaskNameLabel.Text = "Name";
            // 
            // CreateTaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(518, 674);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.TaskDescriptionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TaskNameTextBox);
            this.Controls.Add(this.CreateTaskLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(534, 713);
            this.Name = "CreateTaskPage";
            this.Text = "CreateTaskPage";
            this.Load += new System.EventHandler(this.CreateTaskPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTaskLabel;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TaskDescriptionLabel;
        private System.Windows.Forms.Label TaskNameLabel;
    }
}