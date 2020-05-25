namespace Todozo.UI
{
    partial class UserRegistrationPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextLoginName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.inputTextLoginPassword = new System.Windows.Forms.TextBox();
            this.inputTextLoginRepeatPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1136, 194);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextLoginName
            // 
            this.inputTextLoginName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTextLoginName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inputTextLoginName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginName.ForeColor = System.Drawing.Color.Silver;
            this.inputTextLoginName.Location = new System.Drawing.Point(419, 189);
            this.inputTextLoginName.MaxLength = 50;
            this.inputTextLoginName.Name = "inputTextLoginName";
            this.inputTextLoginName.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginName.TabIndex = 0;
            this.inputTextLoginName.Text = "Name";
            this.inputTextLoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextLoginEmail_KeyPressed);
            this.inputTextLoginName.Leave += new System.EventHandler(this.inputTextLoginEmail_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(419, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // inputTextLoginPassword
            // 
            this.inputTextLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTextLoginPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginPassword.ForeColor = System.Drawing.Color.Silver;
            this.inputTextLoginPassword.Location = new System.Drawing.Point(419, 233);
            this.inputTextLoginPassword.MaxLength = 30;
            this.inputTextLoginPassword.Name = "inputTextLoginPassword";
            this.inputTextLoginPassword.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginPassword.TabIndex = 1;
            this.inputTextLoginPassword.Text = "Password";
            this.inputTextLoginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextLoginPassword_KeyPressed);
            this.inputTextLoginPassword.Leave += new System.EventHandler(this.inputTextLoginPassword_Leave);
            // 
            // inputTextLoginRepeatPassword
            // 
            this.inputTextLoginRepeatPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTextLoginRepeatPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginRepeatPassword.ForeColor = System.Drawing.Color.Silver;
            this.inputTextLoginRepeatPassword.Location = new System.Drawing.Point(419, 278);
            this.inputTextLoginRepeatPassword.MaxLength = 30;
            this.inputTextLoginRepeatPassword.Name = "inputTextLoginRepeatPassword";
            this.inputTextLoginRepeatPassword.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginRepeatPassword.TabIndex = 2;
            this.inputTextLoginRepeatPassword.Text = "Repeat Password";
            this.inputTextLoginRepeatPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextLoginRepeatPassword_KeyPressed);
            this.inputTextLoginRepeatPassword.Leave += new System.EventHandler(this.inputTextLoginRepeatPassword_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(569, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 37);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UserRegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1136, 696);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.inputTextLoginRepeatPassword);
            this.Controls.Add(this.inputTextLoginPassword);
            this.Controls.Add(this.inputTextLoginName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1152, 735);
            this.MinimumSize = new System.Drawing.Size(1152, 735);
            this.Name = "UserRegistrationPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextLoginName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox inputTextLoginPassword;
        private System.Windows.Forms.TextBox inputTextLoginRepeatPassword;
        private System.Windows.Forms.Button btnSubmit;
    }
}