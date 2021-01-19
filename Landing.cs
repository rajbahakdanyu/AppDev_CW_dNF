using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_CW_dNF
{
    public partial class Landing : Form
    {
        Utils util = new Utils();

        public Landing()
        {
            InitializeComponent();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            util.openChildForm(panelContent, new Review_Form());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string passowrd = txtPassword.Text;

            if (username.Equals("admin") && passowrd.Equals("admin"))
            {
                mainFrame form = new mainFrame();
                form.Show();
                form.FormClosing += (obj, args) => { this.Close(); };
                this.Hide();
            } else
            {
                MessageBox.Show("Username or Password is incorrect.", "Login Unsuccessful");
            }
        }
    }
}
