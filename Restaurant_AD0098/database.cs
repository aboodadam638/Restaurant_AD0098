using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Restaurant_AD0098
{
    public partial class frmdatabase : Form
    {
        public frmdatabase()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection restaurant = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " 
                + "Data Source =C:\\Users\\SCHOOL\\Desktop\\abdulrahman\\Restaurant_AD0098.accdb");
            restaurant.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Restauranttable values(@ID, @Name, @price)", restaurant);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(txtNumber.Text));

            cmd.ExecuteNonQuery();
            restaurant.Close();
            MessageBox.Show("Saved is successfully");
            GetRestaurant();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From Restauranttable Where ID=@ID";
            OleDbConnection restaurant = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source =C:\\Users\\SCHOOL\\Desktop\\abdulrahman\\Restaurant_AD0098.accdb");

            OleDbCommand cmd = new OleDbCommand(delete, restaurant);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            restaurant.Open();

            cmd.ExecuteNonQuery();
            restaurant.Close();
            MessageBox.Show("Delete is successfully");
            GetRestaurant();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        void GetRestaurant()
        {
            OleDbConnection restaurant = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source =C:\\Users\\SCHOOL\\Desktop\\abdulrahman\\Restaurant_AD0098.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Restauranttable", restaurant);
            restaurant.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            restaurant.Close();
        }
    }
}
