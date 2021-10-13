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
    public partial class View_Modules : Form
    {
        public View_Modules()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            handler.insertModule(txtModuleCode.Text, txtModuleName.Text, rtxtModuleDescription.Text, rtxtLink.Text);

            txtModuleCode.Clear();
            txtModuleName.Clear();
            rtxtModuleDescription.Clear();
            rtxtLink.Clear();

            MessageBox.Show("Module has been added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            handler.updateModule(txtModuleCode.Text, txtModuleName.Text, rtxtModuleDescription.Text, rtxtLink.Text);

            txtModuleCode.Clear();
            txtModuleName.Clear();
            rtxtModuleDescription.Clear();
            rtxtLink.Clear();

            MessageBox.Show("Module has been updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.deleteModule(txtModuleCode.Text);

            txtModuleCode.Clear();

            MessageBox.Show("Module was deleted");
        }

        private void btnMianMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            var MainMenu = new Main_Menu();
            MainMenu.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvVIewStudents.DataSource = handler.displayModules();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {

        }
    }
}
