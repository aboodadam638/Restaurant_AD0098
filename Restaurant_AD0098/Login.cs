using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_AD0098
{
    public partial class frmLogin : Form
    {
        public frmLogin(string user)
        {
            InitializeComponent();
        }
        private void btnForm1_Click_1(object sender, EventArgs e)
        {
            frmBreakfast frm1 = new frmBreakfast();
            frm1.TopLevel = false;
            this.panel3.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnForm2_Click_1(object sender, EventArgs e)
        {
            frmLunch frm2 = new frmLunch();
            frm2.TopLevel = false;
            this.panel3.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnForm3_Click_1(object sender, EventArgs e)
        {
            frmsweets frm3 = new frmsweets();
            frm3.TopLevel = false;
            this.panel3.Controls.Add(frm3);
            frm3.Show();
        }

        private void btnForm4_Click_1(object sender, EventArgs e)
        {
            frmjuices frm4 = new frmjuices();
            frm4.TopLevel = false;
            this.panel3.Controls.Add(frm4);
            frm4.Show();
        }

        private void btndatabase_Click(object sender, EventArgs e)
        {
            frmdatabase frmd = new frmdatabase();
            frmd.TopLevel = false;
            this.panel3.Controls.Add(frmd);
            frmd.Show();
        }
    }
}
