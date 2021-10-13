namespace Milestone2
{
    partial class View_Modules
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblViewStudents = new System.Windows.Forms.Label();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.lblModuleDescription = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.dgvVIewStudents = new System.Windows.Forms.DataGridView();
            this.rtxtModuleDescription = new System.Windows.Forms.RichTextBox();
            this.rtxtLink = new System.Windows.Forms.RichTextBox();
            this.btnMianMenu = new System.Windows.Forms.Button();
            this.btnSerach = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVIewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(961, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(71, 555);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(145, 42);
            this.btnDisplay.TabIndex = 22;
            this.btnDisplay.Text = "Display Modules";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblViewStudents
            // 
            this.lblViewStudents.AutoSize = true;
            this.lblViewStudents.Location = new System.Drawing.Point(68, 22);
            this.lblViewStudents.Name = "lblViewStudents";
            this.lblViewStudents.Size = new System.Drawing.Size(87, 13);
            this.lblViewStudents.TabIndex = 21;
            this.lblViewStudents.Text = "View All Modules";
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.rtxtLink);
            this.gbStudentInfo.Controls.Add(this.rtxtModuleDescription);
            this.gbStudentInfo.Controls.Add(this.btnUpdate);
            this.gbStudentInfo.Controls.Add(this.btnAdd);
            this.gbStudentInfo.Controls.Add(this.txtModuleCode);
            this.gbStudentInfo.Controls.Add(this.txtModuleName);
            this.gbStudentInfo.Controls.Add(this.lblModuleCode);
            this.gbStudentInfo.Controls.Add(this.lblModuleDescription);
            this.gbStudentInfo.Controls.Add(this.lblLink);
            this.gbStudentInfo.Controls.Add(this.lblModuleName);
            this.gbStudentInfo.Location = new System.Drawing.Point(857, 52);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(280, 485);
            this.gbStudentInfo.TabIndex = 20;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Module Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 444);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(104, 38);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(170, 20);
            this.txtModuleCode.TabIndex = 15;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(104, 76);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(170, 20);
            this.txtModuleName.TabIndex = 8;
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(6, 45);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(67, 13);
            this.lblModuleCode.TabIndex = 7;
            this.lblModuleCode.Text = "ModuleCode";
            // 
            // lblModuleDescription
            // 
            this.lblModuleDescription.AutoSize = true;
            this.lblModuleDescription.Location = new System.Drawing.Point(6, 122);
            this.lblModuleDescription.Name = "lblModuleDescription";
            this.lblModuleDescription.Size = new System.Drawing.Size(95, 13);
            this.lblModuleDescription.TabIndex = 2;
            this.lblModuleDescription.Text = "ModuleDescription";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(6, 246);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(99, 13);
            this.lblLink.TabIndex = 1;
            this.lblLink.Text = "Link For Resources";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(6, 83);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(70, 13);
            this.lblModuleName.TabIndex = 0;
            this.lblModuleName.Text = "ModuleName";
            // 
            // dgvVIewStudents
            // 
            this.dgvVIewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVIewStudents.Location = new System.Drawing.Point(12, 52);
            this.dgvVIewStudents.Name = "dgvVIewStudents";
            this.dgvVIewStudents.Size = new System.Drawing.Size(811, 485);
            this.dgvVIewStudents.TabIndex = 19;
            // 
            // rtxtModuleDescription
            // 
            this.rtxtModuleDescription.Location = new System.Drawing.Point(108, 122);
            this.rtxtModuleDescription.Name = "rtxtModuleDescription";
            this.rtxtModuleDescription.Size = new System.Drawing.Size(166, 96);
            this.rtxtModuleDescription.TabIndex = 18;
            this.rtxtModuleDescription.Text = "";
            // 
            // rtxtLink
            // 
            this.rtxtLink.Location = new System.Drawing.Point(108, 246);
            this.rtxtLink.Name = "rtxtLink";
            this.rtxtLink.Size = new System.Drawing.Size(166, 178);
            this.rtxtLink.TabIndex = 19;
            this.rtxtLink.Text = "";
            // 
            // btnMianMenu
            // 
            this.btnMianMenu.Location = new System.Drawing.Point(624, 555);
            this.btnMianMenu.Name = "btnMianMenu";
            this.btnMianMenu.Size = new System.Drawing.Size(145, 42);
            this.btnMianMenu.TabIndex = 24;
            this.btnMianMenu.Text = "Back To Main Menu";
            this.btnMianMenu.UseVisualStyleBackColor = true;
            this.btnMianMenu.Click += new System.EventHandler(this.btnMianMenu_Click);
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(430, 12);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(75, 23);
            this.btnSerach.TabIndex = 29;
            this.btnSerach.Text = "Serach";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(309, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 28;
            // 
            // View_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 631);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnMianMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblViewStudents);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.dgvVIewStudents);
            this.Name = "View_Modules";
            this.Text = "View_Modules";
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVIewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblViewStudents;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.Label lblModuleDescription;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.DataGridView dgvVIewStudents;
        private System.Windows.Forms.RichTextBox rtxtModuleDescription;
        private System.Windows.Forms.RichTextBox rtxtLink;
        private System.Windows.Forms.Button btnMianMenu;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.TextBox txtSearch;
    }
}