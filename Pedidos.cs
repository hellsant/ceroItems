using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuwiGoHome
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            actualizar();
        }

        private void close_ped_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView2_prod_MouseClick(object sender, MouseEventArgs e)
        {
            String select = listView2_prod.SelectedItems[0].SubItems[0].Text;
            DetalleProducto detProd = new DetalleProducto();
            detProd.Show();
        }

        private void listView1_ped_MouseClick(object sender, MouseEventArgs e)
        {
            String select = listView1_ped.SelectedItems[0].SubItems[0].Text;
            DetalleProducto detProd = new DetalleProducto();
            detProd.Show();
        }
        private void actualizar()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(50, 50);
            String[] paths = { };
            paths = Directory.GetFiles("C:/Users/asus2018/Desktop/c#/imagenes");
            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            listView2_prod.SmallImageList = imgs;
            for (int i = 0; i <= 6; i++)
            {
                listView2_prod.Items.Add("img" + (i + 1), i);
            }

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            listView1_ped.View = View.Details;
            listView1_ped.Columns.Add("Pedidos", 250);
            listView1_ped.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2_prod.View = View.Details;
            listView2_prod.Columns.Add("Productos", 250);
            listView2_prod.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void actualizar_ped_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void det_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
