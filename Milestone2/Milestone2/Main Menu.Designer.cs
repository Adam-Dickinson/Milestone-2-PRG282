namespace Milestone2
{
    partial class Main_Menu
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
            this.lblStudents = new System.Windows.Forms.Label();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.lblViewModule = new System.Windows.Forms.Label();
            this.lblReturnToLogin = new System.Windows.Forms.Label();
            this.btnViewModules = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(54, 19);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(143, 24);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "View Students";
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(78, 71);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(92, 42);
            this.btnViewStudents.TabIndex = 1;
            this.btnViewStudents.Text = "View";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // lblViewModule
            // 
            this.lblViewModule.AutoSize = true;
            this.lblViewModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewModule.Location = new System.Drawing.Point(54, 158);
            this.lblViewModule.Name = "lblViewModule";
            this.lblViewModule.Size = new System.Drawing.Size(142, 24);
            this.lblViewModule.TabIndex = 2;
            this.lblViewModule.Text = "View Modules";
            // 
            // lblReturnToLogin
            // 
            this.lblReturnToLogin.AutoSize = true;
            this.lblReturnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnToLogin.Location = new System.Drawing.Point(49, 314);
            this.lblReturnToLogin.Name = "lblReturnToLogin";
            this.lblReturnToLogin.Size = new System.Drawing.Size(161, 24);
            this.lblReturnToLogin.TabIndex = 3;
            this.lblReturnToLogin.Text = "Return To Login";
            // 
            // btnViewModules
            // 
            this.btnViewModules.Location = new System.Drawing.Point(73, 224);
            this.btnViewModules.Name = "btnViewModules";
            this.btnViewModules.Size = new System.Drawing.Size(92, 42);
            this.btnViewModules.TabIndex = 4;
            this.btnViewModules.Text = "View";
            this.btnViewModules.UseVisualStyleBackColor = true;
            this.btnViewModules.Click += new System.EventHandler(this.btnViewModules_Click);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(73, 375);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(92, 42);
            this.btnReturnToMenu.TabIndex = 5;
            this.btnReturnToMenu.Text = "Return";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 450);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.btnViewModules);
            this.Controls.Add(this.lblReturnToLogin);
            this.Controls.Add(this.lblViewModule);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.lblStudents);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Label lblViewModule;
        private System.Windows.Forms.Label lblReturnToLogin;
        private System.Windows.Forms.Button btnViewModules;
        private System.Windows.Forms.Button btnReturnToMenu;
    }
}