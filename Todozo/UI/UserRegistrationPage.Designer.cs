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
            this.inputTextLoginEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputTextLoginPassword = new System.Windows.Forms.TextBox();
            this.inputTextLoginRepeatPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextLoginEmail
            // 
            this.inputTextLoginEmail.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginEmail.Location = new System.Drawing.Point(412, 197);
            this.inputTextLoginEmail.Name = "inputTextLoginEmail";
            this.inputTextLoginEmail.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginEmail.TabIndex = 2;
            this.inputTextLoginEmail.Text = "Email";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputTextLoginPassword
            // 
            this.inputTextLoginPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginPassword.Location = new System.Drawing.Point(412, 241);
            this.inputTextLoginPassword.Name = "inputTextLoginPassword";
            this.inputTextLoginPassword.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginPassword.TabIndex = 2;
            this.inputTextLoginPassword.Text = "Password";
            // 
            // inputTextLoginRepeatPassword
            // 
            this.inputTextLoginRepeatPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginRepeatPassword.Location = new System.Drawing.Point(412, 286);
            this.inputTextLoginRepeatPassword.Name = "inputTextLoginRepeatPassword";
            this.inputTextLoginRepeatPassword.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginRepeatPassword.TabIndex = 2;
            this.inputTextLoginRepeatPassword.Text = "Repeat Password";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(562, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserRegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1136, 696);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputTextLoginRepeatPassword);
            this.Controls.Add(this.inputTextLoginPassword);
            this.Controls.Add(this.inputTextLoginEmail);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1152, 735);
            this.Name = "UserRegistrationPage";
            this.Text = "UserRegistrationPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextLoginEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputTextLoginPassword;
        private System.Windows.Forms.TextBox inputTextLoginRepeatPassword;
        private System.Windows.Forms.Button button2;
    }
}