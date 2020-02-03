using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class StockMain : Form
    {
        public StockMain()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.MdiParent = this;
            productos.StartPosition = FormStartPosition.CenterScreen;
            productos.Show();
        }
        bool close = true;
        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.MdiParent = this;
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.ProductsReport productosReporte = new ReportForm.ProductsReport();
            productosReporte.MdiParent = this;
            productosReporte.StartPosition = FormStartPosition.CenterScreen;
            productosReporte.Show();
        }

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.StockReport stockProductos = new ReportForm.StockReport();
            stockProductos.MdiParent = this;
            stockProductos.StartPosition = FormStartPosition.CenterScreen;
            stockProductos.Show();
        }       
    }
}

