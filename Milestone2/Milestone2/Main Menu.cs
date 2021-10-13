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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            var Login = new LoginFrm();
            Login.Show();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ViewStudnets = new View_Students();
            ViewStudnets.Show();
        }

        private void btnViewModules_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ViewModules = new View_Modules();
            ViewModules.Show();
        }
    }
}
