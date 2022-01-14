
namespace WindowsApp
{
    partial class Form1
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
            this.LbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.CbChangePass = new System.Windows.Forms.CheckBox();
            this.CbUserCannotCh = new System.Windows.Forms.CheckBox();
            this.CbPassNeverEx = new System.Windows.Forms.CheckBox();
            this.CbAccIsDis = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(12, 9);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(55, 13);
            this.LbUsername.TabIndex = 0;
            this.LbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(73, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(151, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(12, 36);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(53, 13);
            this.LbPassword.TabIndex = 2;
            this.LbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(73, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(15, 62);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(209, 34);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(12, 102);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(209, 173);
            this.lstUsers.TabIndex = 5;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(12, 281);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(100, 47);
            this.btnShowUsers.TabIndex = 6;
            this.btnShowUsers.Text = "Show users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Enabled = false;
            this.btnDeleteUsers.Location = new System.Drawing.Point(124, 281);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(100, 47);
            this.btnDeleteUsers.TabIndex = 7;
            this.btnDeleteUsers.Text = "Delete users";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // CbChangePass
            // 
            this.CbChangePass.AutoSize = true;
            this.CbChangePass.Location = new System.Drawing.Point(574, 12);
            this.CbChangePass.Name = "CbChangePass";
            this.CbChangePass.Size = new System.Drawing.Size(151, 17);
            this.CbChangePass.TabIndex = 8;
            this.CbChangePass.Text = "Change pass on next login";
            this.CbChangePass.UseVisualStyleBackColor = true;
            this.CbChangePass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CbUserCannotCh
            // 
            this.CbUserCannotCh.AutoSize = true;
            this.CbUserCannotCh.Location = new System.Drawing.Point(574, 39);
            this.CbUserCannotCh.Name = "CbUserCannotCh";
            this.CbUserCannotCh.Size = new System.Drawing.Size(171, 17);
            this.CbUserCannotCh.TabIndex = 9;
            this.CbUserCannotCh.Text = "User cannot change password";
            this.CbUserCannotCh.UseVisualStyleBackColor = true;
            this.CbUserCannotCh.CheckedChanged += new System.EventHandler(this.CbUserCannotCh_CheckedChanged);
            // 
            // CbPassNeverEx
            // 
            this.CbPassNeverEx.AutoSize = true;
            this.CbPassNeverEx.Location = new System.Drawing.Point(574, 62);
            this.CbPassNeverEx.Name = "CbPassNeverEx";
            this.CbPassNeverEx.Size = new System.Drawing.Size(138, 17);
            this.CbPassNeverEx.TabIndex = 10;
            this.CbPassNeverEx.Text = "Password never expires";
            this.CbPassNeverEx.UseVisualStyleBackColor = true;
            this.CbPassNeverEx.CheckedChanged += new System.EventHandler(this.CbPassNeverEx_CheckedChanged);
            // 
            // CbAccIsDis
            // 
            this.CbAccIsDis.AutoSize = true;
            this.CbAccIsDis.Location = new System.Drawing.Point(574, 85);
            this.CbAccIsDis.Name = "CbAccIsDis";
            this.CbAccIsDis.Size = new System.Drawing.Size(117, 17);
            this.CbAccIsDis.TabIndex = 11;
            this.CbAccIsDis.Text = "Account is disables";
            this.CbAccIsDis.UseVisualStyleBackColor = true;
            this.CbAccIsDis.CheckedChanged += new System.EventHandler(this.CbAccIsDis_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbAccIsDis);
            this.Controls.Add(this.CbPassNeverEx);
            this.Controls.Add(this.CbUserCannotCh);
            this.Controls.Add(this.CbChangePass);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.LbUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.CheckBox CbChangePass;
        private System.Windows.Forms.CheckBox CbUserCannotCh;
        private System.Windows.Forms.CheckBox CbPassNeverEx;
        private System.Windows.Forms.CheckBox CbAccIsDis;
    }
}

