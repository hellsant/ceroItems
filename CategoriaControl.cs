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
    public partial class CategoriaControl : Form
    {
        public CategoriaControl()
        {
            InitializeComponent();
            actualizar();
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
            listView1_prod.SmallImageList = imgs;
            for (int i = 0; i <= 6; i++)
            {
                listView1_prod.Items.Add("img" + (i + 1), i);
            }

        }

        private void CategoriaControl_Load(object sender, EventArgs e)
        {
            listView1_prod.View = View.Details;
            listView1_prod.Columns.Add("Productos de categoria X", 250);
            listView1_prod.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_prod_MouseClick(object sender, MouseEventArgs e)
        {
            String select = listView1_prod.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(select);
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
