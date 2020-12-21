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
        public Landing()
        {
            InitializeComponent();
        }

        private Form activeForm = null; // Setting current form
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            openChildForm(new Review_Form());
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
