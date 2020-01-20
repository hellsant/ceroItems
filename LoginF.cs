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
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
           
        }

        private void cerrar_Lo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void iniciar_sesion_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Hide();
        }

        private void registrar_log_Click(object sender, EventArgs e)
        {
            Registrar form = new Registrar();
            form.Show();
            this.Hide();
        }
    }
}
