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
    public partial class flat : Form
    {
        public flat()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 5;
            if (rectangleShape2.Width>=518)
            {
                timer1.Stop();
                //MessageBox.Show("Felicidades!");
                LoginF form = new LoginF();
                form.Show();
                this.Hide();
            }
        }
    }
}
