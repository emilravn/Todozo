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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.inputTextLoginPassword = new System.Windows.Forms.TextBox();
            this.inputTextLoginRepeatPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.inputTextLoginEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1136, 194);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(419, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // inputTextLoginPassword
            // 
            this.inputTextLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTextLoginPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginPassword.ForeColor = System.Drawing.Color.Silver;
            this.inputTextLoginPassword.Location = new System.Drawing.Point(419, 233);
            this.inputTextLoginPassword.MaxLength = 50;
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
            this.inputTextLoginRepeatPassword.MaxLength = 50;
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
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(569, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 37);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // inputTextLoginEmail
            // 
            this.inputTextLoginEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inputTextLoginEmail.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginEmail.ForeColor = System.Drawing.Color.Silver;
            this.inputTextLoginEmail.Location = new System.Drawing.Point(419, 189);
            this.inputTextLoginEmail.MaxLength = 50;
            this.inputTextLoginEmail.Name = "inputTextLoginEmail";
            this.inputTextLoginEmail.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginEmail.TabIndex = 0;
            this.inputTextLoginEmail.Text = "Name";
            this.inputTextLoginEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextLoginEmail_KeyPressed);
            this.inputTextLoginEmail.Leave += new System.EventHandler(this.inputTextLoginEmail_Leave);
            // 
            // UserRegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1136, 696);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.inputTextLoginRepeatPassword);
            this.Controls.Add(this.inputTextLoginPassword);
            this.Controls.Add(this.inputTextLoginEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1152, 735);
            this.MinimumSize = new System.Drawing.Size(1152, 735);
            this.Name = "UserRegistrationPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todozo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox inputTextLoginPassword;
        private System.Windows.Forms.TextBox inputTextLoginRepeatPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox inputTextLoginEmail;
    }
}