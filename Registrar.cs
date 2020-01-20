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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }
               
        private void registrar_reg_Click_1(object sender, EventArgs e)
        {
            LoginF form = new LoginF();
            form.Show();
            this.Hide();
        }

        private void cerrar_Lo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
