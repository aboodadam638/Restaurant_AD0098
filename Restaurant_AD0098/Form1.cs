using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_AD0098
{
    public partial class frmBreakfast : Form
    {
        public frmBreakfast()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order : " + listBox1.SelectedItem + "\n Quantity : " + comboBox1.Text);
        }
    }
}
