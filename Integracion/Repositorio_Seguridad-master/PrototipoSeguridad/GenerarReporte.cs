using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoSeguridad
{
    public partial class GenerarReporte : Form
    {
        public GenerarReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporteidbitacora rep = new Reporteidbitacora();
            rep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporteidusuario rep = new Reporteidusuario();
            rep.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reporteidfecha rep = new Reporteidfecha();
            rep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporteidaccion rep = new Reporteidaccion();
            rep.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporteidaplicacion rep = new Reporteidaplicacion();
            rep.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reporteidresultado rep = new Reporteidresultado();
            rep.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reporteiderror rep = new Reporteiderror();
            rep.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reporteidip rep = new Reporteidip();
            rep.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reporteidrangos rep = new Reporteidrangos();
            rep.Show();
        }
    }
}
