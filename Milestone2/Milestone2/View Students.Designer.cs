namespace Milestone2
{
    partial class View_Students
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
            this.dgvVIewStudents = new System.Windows.Forms.DataGridView();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblViewStudents = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblStudNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.txtStudNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtbBOD = new System.Windows.Forms.DateTimePicker();
            this.btnMianMenu = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSerach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVIewStudents)).BeginInit();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVIewStudents
            // 
            this.dgvVIewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVIewStudents.Location = new System.Drawing.Point(12, 56);
            this.dgvVIewStudents.Name = "dgvVIewStudents";
            this.dgvVIewStudents.Size = new System.Drawing.Size(811, 485);
            this.dgvVIewStudents.TabIndex = 0;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.dtbBOD);
            this.gbStudentInfo.Controls.Add(this.btnUpdate);
            this.gbStudentInfo.Controls.Add(this.btnAdd);
            this.gbStudentInfo.Controls.Add(this.txtModuleCode);
            this.gbStudentInfo.Controls.Add(this.txtAdress);
            this.gbStudentInfo.Controls.Add(this.txtPhone);
            this.gbStudentInfo.Controls.Add(this.txtGender);
            this.gbStudentInfo.Controls.Add(this.txtSurname);
            this.gbStudentInfo.Controls.Add(this.txtName);
            this.gbStudentInfo.Controls.Add(this.txtStudNumber);
            this.gbStudentInfo.Controls.Add(this.lblModuleCode);
            this.gbStudentInfo.Controls.Add(this.lblAddress);
            this.gbStudentInfo.Controls.Add(this.lblPhone);
            this.gbStudentInfo.Controls.Add(this.lblGender);
            this.gbStudentInfo.Controls.Add(this.lblDOB);
            this.gbStudentInfo.Controls.Add(this.lblName);
            this.gbStudentInfo.Controls.Add(this.lblSurname);
            this.gbStudentInfo.Controls.Add(this.lblStudNumber);
            this.gbStudentInfo.Location = new System.Drawing.Point(857, 56);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(280, 485);
            this.gbStudentInfo.TabIndex = 1;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Information";
            // 
            // lblViewStudents
            // 
            this.lblViewStudents.AutoSize = true;
            this.lblViewStudents.Location = new System.Drawing.Point(94, 25);
            this.lblViewStudents.Name = "lblViewStudents";
            this.lblViewStudents.Size = new System.Drawing.Size(89, 13);
            this.lblViewStudents.TabIndex = 2;
            this.lblViewStudents.Text = "View All Students";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(66, 559);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(145, 42);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display Students";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblStudNumber
            // 
            this.lblStudNumber.AutoSize = true;
            this.lblStudNumber.Location = new System.Drawing.Point(16, 76);
            this.lblStudNumber.Name = "lblStudNumber";
            this.lblStudNumber.Size = new System.Drawing.Size(81, 13);
            this.lblStudNumber.TabIndex = 0;
            this.lblStudNumber.Text = "StudentNumber";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(16, 166);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "FirstName";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(16, 212);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "DOB";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(16, 263);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 312);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 363);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(16, 408);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(67, 13);
            this.lblModuleCode.TabIndex = 7;
            this.lblModuleCode.Text = "ModuleCode";
            // 
            // txtStudNumber
            // 
            this.txtStudNumber.Location = new System.Drawing.Point(104, 76);
            this.txtStudNumber.Name = "txtStudNumber";
            this.txtStudNumber.Size = new System.Drawing.Size(170, 20);
            this.txtStudNumber.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(104, 166);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(170, 20);
            this.txtSurname.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(104, 256);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(22, 20);
            this.txtGender.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 305);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(170, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(104, 356);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(170, 20);
            this.txtAdress.TabIndex = 14;
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(104, 401);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(170, 20);
            this.txtModuleCode.TabIndex = 15;
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(961, 569);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtbBOD
            // 
            this.dtbBOD.CustomFormat = "yyyy-MM-dd";
            this.dtbBOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbBOD.Location = new System.Drawing.Point(104, 212);
            this.dtbBOD.Name = "dtbBOD";
            this.dtbBOD.Size = new System.Drawing.Size(75, 20);
            this.dtbBOD.TabIndex = 18;
            // 
            // btnMianMenu
            // 
            this.btnMianMenu.Location = new System.Drawing.Point(627, 559);
            this.btnMianMenu.Name = "btnMianMenu";
            this.btnMianMenu.Size = new System.Drawing.Size(145, 42);
            this.btnMianMenu.TabIndex = 25;
            this.btnMianMenu.Text = "Back To Main Menu";
            this.btnMianMenu.UseVisualStyleBackColor = true;
            this.btnMianMenu.Click += new System.EventHandler(this.btnMianMenu_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(315, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 26;
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(436, 14);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(75, 23);
            this.btnSerach.TabIndex = 27;
            this.btnSerach.Text = "Serach";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // View_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 659);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnMianMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblViewStudents);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.dgvVIewStudents);
            this.Name = "View_Students";
            this.Text = "View Students";
            this.Load += new System.EventHandler(this.View_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVIewStudents)).EndInit();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVIewStudents;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lblViewStudents;
        private System.Windows.Forms.DateTimePicker dtbBOD;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudNumber;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblStudNumber;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMianMenu;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSerach;
    }
}