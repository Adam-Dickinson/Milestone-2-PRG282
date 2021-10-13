using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Milestone2
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();

            
        }

        DataHandler handler = new DataHandler();

        

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            handler.register(txtRegUsername.Text, txtRegPassword.Text);
            txtRegUsername.Clear();
            txtRegPassword.Clear();
            MessageBox.Show("You are now registered");

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            handler.login(txtLogUsername.Text, txtLogPassword.Text);

            this.Hide();
            var MainMenu = new Main_Menu();
            MainMenu.Show();
        }
    }
}
