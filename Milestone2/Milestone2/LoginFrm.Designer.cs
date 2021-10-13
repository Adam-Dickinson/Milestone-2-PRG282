namespace Milestone2
{
    partial class LoginFrm
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogUsername = new System.Windows.Forms.TextBox();
            this.txtLogPassword = new System.Windows.Forms.TextBox();
            this.lblLogUsername = new System.Windows.Forms.Label();
            this.lblLogPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(115, 56);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.Location = new System.Drawing.Point(12, 133);
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.Size = new System.Drawing.Size(122, 20);
            this.txtLogUsername.TabIndex = 1;
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.Location = new System.Drawing.Point(177, 134);
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.Size = new System.Drawing.Size(128, 20);
            this.txtLogPassword.TabIndex = 2;
            // 
            // lblLogUsername
            // 
            this.lblLogUsername.AutoSize = true;
            this.lblLogUsername.Location = new System.Drawing.Point(46, 114);
            this.lblLogUsername.Name = "lblLogUsername";
            this.lblLogUsername.Size = new System.Drawing.Size(55, 13);
            this.lblLogUsername.TabIndex = 3;
            this.lblLogUsername.Text = "Username";
            // 
            // lblLogPassword
            // 
            this.lblLogPassword.AutoSize = true;
            this.lblLogPassword.Location = new System.Drawing.Point(211, 114);
            this.lblLogPassword.Name = "lblLogPassword";
            this.lblLogPassword.Size = new System.Drawing.Size(53, 13);
            this.lblLogPassword.TabIndex = 4;
            this.lblLogPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(78, 193);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(27, 344);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(262, 25);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "Do not have an account";
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(211, 414);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(53, 13);
            this.lblRegPassword.TabIndex = 10;
            this.lblRegPassword.Text = "Password";
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Location = new System.Drawing.Point(46, 414);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(55, 13);
            this.lblRegUsername.TabIndex = 9;
            this.lblRegUsername.Text = "Username";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(177, 434);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(128, 20);
            this.txtRegPassword.TabIndex = 8;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(12, 433);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(122, 20);
            this.txtRegUsername.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(78, 517);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(144, 52);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 624);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.lblRegUsername);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogPassword);
            this.Controls.Add(this.lblLogUsername);
            this.Controls.Add(this.txtLogPassword);
            this.Controls.Add(this.txtLogUsername);
            this.Controls.Add(this.lblLogin);
            this.Name = "LoginFrm";
            this.Text = "Login or Register";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogUsername;
        private System.Windows.Forms.TextBox txtLogPassword;
        private System.Windows.Forms.Label lblLogUsername;
        private System.Windows.Forms.Label lblLogPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Button btnRegister;
    }
}

