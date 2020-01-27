using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuwiGoHome
{
    public partial class Categoria : Form
    {
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public Categoria()
        {
            InitializeComponent();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(ClientRectangle.Width - tolerance, ClientRectangle.Height - tolerance, tolerance, HTBOTTOMRIGHT);
            region.Exclude(sizeGripRectangle);
            this.Region = region;
            this.Invalidate();
            if (this.Width >= 245 && this.Width <= 500)
            {
                panel1_categoria.Visible = true;
                panel1_categoria.Location = new Point(48, 68);
                panel2_categoria.Visible = false;
                panel2_categoria.Location = new Point(312, 68);
                panel3_categoria.Visible = false;
                panel3_categoria.Location = new Point(576, 68);
                panel4_categoria.Visible = false;
                panel4_categoria.Location = new Point(840, 68);
                panel5_categoria.Visible = true;
                panel5_categoria.Location = new Point(48, 350);
                panel6_categoria.Visible = false;
                panel6_categoria.Location = new Point(312, 350);
                panel7_categoria.Visible = false;
                panel7_categoria.Location = new Point(576, 350);
                panel8_categoria.Visible = false;
                panel8_categoria.Location = new Point(840, 350);
            }
            else if (this.Width > 500 && this.Width <= 735)
            {
                panel1_categoria.Visible = true;
                panel1_categoria.Location = new Point(48, 68);
                panel2_categoria.Visible = true;
                panel2_categoria.Location = new Point(312, 68);
                panel3_categoria.Visible = false;
                panel3_categoria.Location = new Point(576, 68);
                panel4_categoria.Visible = false;
                panel4_categoria.Location = new Point(840, 68);
                panel5_categoria.Visible = true;
                panel5_categoria.Location = new Point(48, 350);
                panel6_categoria.Visible = true;
                panel6_categoria.Location = new Point(312, 350);
                panel7_categoria.Visible = false;
                panel7_categoria.Location = new Point(576, 350);
                panel8_categoria.Visible = false;
                panel8_categoria.Location = new Point(840, 350);
            }
            else if (this.Width > 735 && this.Width <= 980)
            {
                panel1_categoria.Visible = true;
                panel1_categoria.Location = new Point(48, 68);
                panel2_categoria.Visible = true;
                panel2_categoria.Location = new Point(312, 68);
                panel3_categoria.Visible = true;
                panel3_categoria.Location = new Point(576, 68);
                panel4_categoria.Visible = false;
                panel4_categoria.Location = new Point(840, 68);
                panel5_categoria.Visible = true;
                panel5_categoria.Location = new Point(48, 350);
                panel6_categoria.Visible = true;
                panel6_categoria.Location = new Point(312, 350);
                panel7_categoria.Visible = true;
                panel7_categoria.Location = new Point(576, 350);
                panel8_categoria.Visible = false;
                panel8_categoria.Location = new Point(840, 350);
            }
            else if (this.Width > 980)
            {
                panel1_categoria.Visible = true;
                panel1_categoria.Location = new Point(48, 68);
                panel2_categoria.Visible = true;
                panel2_categoria.Location = new Point(312, 68);
                panel3_categoria.Visible = true;
                panel3_categoria.Location = new Point(576, 68);
                panel4_categoria.Visible = true;
                panel4_categoria.Location = new Point(840, 68);
                panel5_categoria.Visible = true;
                panel5_categoria.Location = new Point(48, 350);
                panel6_categoria.Visible = true;
                panel6_categoria.Location = new Point(312, 350);
                panel7_categoria.Visible = true;
                panel7_categoria.Location = new Point(576, 350);
                panel8_categoria.Visible = true;
                panel8_categoria.Location = new Point(840, 350);
            }

        }

        private void cerrar_cat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void panel1_categoria_MouseClick_1(object sender, MouseEventArgs e)
        {
            DetalleCategoria detalle = new DetalleCategoria();
            detalle.Show();
        }
        private void panel4_categoria_MouseClick(object sender, MouseEventArgs e)
        {
            DetalleCategoria detalle = new DetalleCategoria();
            detalle.Show();
        }

        private void panel5_categoria_MouseClick(object sender, MouseEventArgs e)
        {
            DetalleCategoria detalle = new DetalleCategoria();
            detalle.Show();
        }

        private void panel6_categoria_MouseClick(object sender, MouseEventArgs e)
        {
            DetalleCategoria detalle = new DetalleCategoria();
            detalle.Show();
        }

        private void panel2_categoria_MouseClick_1(object sender, MouseEventArgs e)
        {
            DetalleCategoria detalle = new DetalleCategoria();
            detalle.Show();
        }

        private void panel3_categoria_MouseClick_1(object sender, MouseEventArgs e)
        {
            DetalleCategoria detalle = new DetalleCategoria();
            detalle.Show();
        }

        private void siguiente_cat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siguiente");
        }

        private void anterior_cat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anterior");
        }

        private void agregar_cat_Click(object sender, EventArgs e)
        {
            CategoriaControl catControl = new CategoriaControl();
            catControl.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscar");
        }
    }
}
