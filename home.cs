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
        Utils util = new Utils();

        public mainFrame()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            util.openChildForm(panelMain, new Edit_Form());
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            util.openChildForm(panelMain, new Review());
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
            util.openChildForm(panelMain, new See_Reviews());
        }
    }
}
