using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ChuwiGoHome
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            AbrirFormInPanel(new Productos());
        }
        /*
        protected override void WndProc1(ref Message m)
        {
            const int CoordenadaWFP = 0x84;
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (m.Msg== CoordenadaWFP)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000)>>16);
                Point CoordenarioArea = PointToClient(new Point(x, y));
                Size tamanioAreaHome = ClientSize;
                if (CoordenarioArea.X >=tamanioAreaHome.Width-16 && CoordenarioArea.Y >= tamanioAreaHome.Height)
                {
                    m.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref m);
        }*/
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xFFFF, m.LParam.ToInt32() >>16));
                    if (sizeGripRectangle.Contains(hitPoint))
                    {
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0,0,ClientRectangle.Width,ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(ClientRectangle.Width-tolerance, ClientRectangle.Height-tolerance,tolerance,HTBOTTOMRIGHT);
            region.Exclude(sizeGripRectangle);
            this.panelPrincipal.Region = region;
            this.Invalidate();          

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255,128,0));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics,Color.Transparent,sizeGripRectangle);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_p_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar_p.Visible = false;
            restaurar_p.Visible = true;
        }

        private void minimizar_p_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void restaurar_p_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar_p.Visible = false;
            maximizar_p.Visible = true;
        }

        

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);          

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void actualizar_sidebar()
        {
            int y = 227;
            int rango = 38;
            if (btn1_panel11.Visible == true)
            {
                btn1_panel11.Visible = false;
                panel4.Location = new Point(2, y);
                btn_lateral_1.Location = new Point(5, y);
                panel5.Location = new Point(2, y + rango);
                btn_lateral_2.Location = new Point(5, y + rango);
                rango += 38;
                panel6.Location = new Point(2, y + rango);
                btn_lateral_3.Location = new Point(5, y + rango);
                rango += 38;
                panel7.Location = new Point(2, y + rango);
                btn_lateral_4.Location = new Point(5, y + rango);
                rango += 38;
                panel8.Location = new Point(2, y + rango);
                btn_lateral_5.Location = new Point(5, y + rango);
                rango += 38;
                panel9.Location = new Point(2, y + rango);
                btn_lateral_6.Location = new Point(5, y + rango);
                rango += 38;
                panel10.Location = new Point(2, y + rango);
                btn_lateral_7.Location = new Point(5, y + rango);
            }
        }
        private void aceptar_Click(object sender, EventArgs e)
        {
            int y = 227;
            int rango = 38;
            if (btn1_panel11.Visible==true)
            {
                btn1_panel11.Visible = false;
                panel4.Location = new Point(2, y);
                btn_lateral_1.Location = new Point(5, y);
                panel5.Location = new Point(2, y + rango);
                btn_lateral_2.Location = new Point(5, y + rango);
                rango += 38;
                panel6.Location = new Point(2, y + rango);
                btn_lateral_3.Location = new Point(5, y + rango);
                rango += 38;
                panel7.Location = new Point(2, y + rango);
                btn_lateral_4.Location = new Point(5, y + rango);
                rango += 38;
                panel8.Location = new Point(2, y + rango);
                btn_lateral_5.Location = new Point(5, y + rango);
                rango += 38;
                panel9.Location = new Point(2, y + rango);
                btn_lateral_6.Location = new Point(5, y + rango);
                rango += 38;
                panel10.Location = new Point(2, y + rango);
                btn_lateral_7.Location = new Point(5, y + rango);
            }
            else
            {
                btn1_panel11.Visible = true;
                panel4.Location = new Point(2, y);
                btn_lateral_1.Location = new Point(5, y);
                btn1_panel11.Location = new Point(5, y + rango);
                rango += 76;
                panel5.Location = new Point(2, y + rango);
                btn_lateral_2.Location = new Point(5, y + rango);
                rango += 38;
                panel6.Location = new Point(2, y + rango);
                btn_lateral_3.Location = new Point(5, y + rango);
                rango += 38;
                panel7.Location = new Point(2, y + rango);
                btn_lateral_4.Location = new Point(5, y + rango);
                rango += 38;
                panel8.Location = new Point(2, y + rango);
                btn_lateral_5.Location = new Point(5, y + rango);
                rango += 38;
                panel9.Location = new Point(2, y + rango);
                btn_lateral_6.Location = new Point(5, y + rango);
                rango += 38;
                panel10.Location = new Point(2, y + rango);
                btn_lateral_7.Location = new Point(5, y + rango);
            }
        }

        private void btn_slide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width==250)
            {
                menuVertical.Width = 60;
            }else
            {
                menuVertical.Width = 250;
            }
        }
        private void AbrirFormInPanel(Object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void subItem_producto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos());
            actualizar_sidebar();
        }

        private void btn_lateral_2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Categoria());
            actualizar_sidebar();
        }

        private void btn_lateral_3_Click(object sender, EventArgs e)
        {
            //pedido
            AbrirFormInPanel(new Pedidos());
            actualizar_sidebar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Categoria());
            actualizar_sidebar();
        }
    }
}
