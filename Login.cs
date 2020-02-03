using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TO-DO: Check login username & Password
            SqlConnection connection = Connection.GetConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT *
                FROM [Stock].[dbo].[Login] Where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Insertar un usuario o constraseña valida..!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1_Click(sender, e);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
