using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = Connection.GetConnection();
                // Insert Logic
                con.Open();
                bool status = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var sqlQuery = "";
                if (IfProductsExists(con, textBox1.Text))
                {
                    sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + textBox2.Text + "' ,[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + textBox1.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [Stock].[dbo].[Products] ([ProductCode],[ProductName],[ProductStatus]) VALUES
                            ('" + textBox1.Text + "','" + textBox2.Text + "','" + status + "')";
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                //Reading Data
                LoadData();
                ResetRecords();
            }
        }

        private bool IfProductsExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Products] WHERE [ProductCode]='" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void LoadData()
        {
            SqlConnection connection = Connection.GetConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From [Stock].[dbo].[Products]", connection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Activado";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Desactivado";
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button2.Text = "Actualizar";
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
			  DialogResult dialogResult = MessageBox.Show("esta seguro que desea eliminar", "Message", MessageBoxButtons.YesNo);
              if (dialogResult == DialogResult.Yes)
              {
                  if (Validation())
                  {
                      SqlConnection connection = Connection.GetConnection();
                      var sqlQuery = "";
                      if (IfProductsExists(connection, textBox1.Text))
                      {
                          connection.Open();
                          sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + textBox1.Text + "'";
                          SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                          cmd.ExecuteNonQuery();
                          connection.Close();
                      }
                      else
                      {
                          MessageBox.Show("No existe...!");
                      }
                      //Reading Data
                      LoadData();
                      ResetRecords();
                  }
              }
        }

        private void ResetRecords()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            button2.Text = "Agregar";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Codigo del producto requerido");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Nombre del producto requerido");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBox1, "Estado");
            }
            else
            {
                result = true;
            }
            return result;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
