namespace Todozo.UI
{
    partial class UserLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.inputTextLoginPassword = new System.Windows.Forms.TextBox();
            this.inputTextLoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1136, 194);
            this.label1.TabIndex = 6;
            this.label1.Text = "Todozo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(572, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 37);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(422, 304);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(142, 37);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // inputTextLoginPassword
            // 
            this.inputTextLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTextLoginPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputTextLoginPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.inputTextLoginPassword.Location = new System.Drawing.Point(422, 252);
            this.inputTextLoginPassword.Name = "inputTextLoginPassword";
            this.inputTextLoginPassword.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginPassword.TabIndex = 10;
            this.inputTextLoginPassword.Text = "Password";
            this.inputTextLoginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextLoginPassword_KeyPress);
            this.inputTextLoginPassword.Leave += new System.EventHandler(this.inputTextLoginPassword_Leave);
            // 
            // inputTextLoginName
            // 
            this.inputTextLoginName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTextLoginName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inputTextLoginName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLoginName.ForeColor = System.Drawing.Color.Black;
            this.inputTextLoginName.Location = new System.Drawing.Point(422, 208);
            this.inputTextLoginName.Name = "inputTextLoginName";
            this.inputTextLoginName.Size = new System.Drawing.Size(292, 29);
            this.inputTextLoginName.TabIndex = 9;
            this.inputTextLoginName.Text = "Name";
            this.inputTextLoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextLoginName_KeyPress);
            this.inputTextLoginName.Leave += new System.EventHandler(this.inputTextLoginName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(418, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Log In";
            // 
            // UserLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1136, 696);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTextLoginPassword);
            this.Controls.Add(this.inputTextLoginName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1152, 735);
            this.MinimumSize = new System.Drawing.Size(1152, 735);
            this.Name = "UserLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todozo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox inputTextLoginPassword;
        private System.Windows.Forms.TextBox inputTextLoginName;
        private System.Windows.Forms.Label label2;
    }
}