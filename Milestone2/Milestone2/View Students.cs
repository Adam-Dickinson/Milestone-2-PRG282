using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2
{
    public partial class View_Students : Form
    {
        public View_Students()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();

        private void View_Students_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvVIewStudents.DataSource = handler.displayStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            handler.insertStudent(int.Parse(txtStudNumber.Text), txtName.Text, txtSurname.Text, this.dtbBOD.Text, txtGender.Text, int.Parse(txtPhone.Text), txtAdress.Text, txtModuleCode.Text);
            txtAdress.Clear();
            txtGender.Clear();
            txtModuleCode.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtStudNumber.Clear();
            txtSurname.Clear();
            MessageBox.Show("Student has been added");
        }

        private void btnMianMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            var MainMenu = new Main_Menu();
            MainMenu.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            handler.updateStudent(int.Parse(txtStudNumber.Text), txtName.Text, txtSurname.Text, this.dtbBOD.Text, txtGender.Text, int.Parse(txtPhone.Text), txtAdress.Text, txtModuleCode.Text);
            txtAdress.Clear();
            txtGender.Clear();
            txtModuleCode.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtStudNumber.Clear();
            txtSurname.Clear();
            MessageBox.Show("Student has been updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.deleteStudent(int.Parse(txtStudNumber.Text));
            txtAdress.Clear();
            txtGender.Clear();
            txtModuleCode.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtStudNumber.Clear();
            txtSurname.Clear();
            MessageBox.Show("Student was deleted");
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            dgvVIewStudents.DataSource = handler.searchStudent(int.Parse(txtSearch.Text));
            txtSearch.Clear();
        }
    }
}
