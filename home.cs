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
    public partial class mainFrame : Form
    {
        public mainFrame()
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

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new Edit_Form());
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            openChildForm(new Review());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Landing form = new Landing();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            openChildForm(new See_Reviews());
        }
    }
}
