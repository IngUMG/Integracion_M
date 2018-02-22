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
    public partial class GenerarReporteUsuario : Form
    {
        public GenerarReporteUsuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporteusuario_idusuario rep = new Reporteusuario_idusuario();
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporteusuario_idnusuario rep = new Reporteusuario_idnusuario();
            rep.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporteusuario_idnombre rep = new Reporteusuario_idnombre();
            rep.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporteusuario_idapellido rep = new Reporteusuario_idapellido();
            rep.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporteusuario_idcorreo rep = new Reporteusuario_idcorreo();
            rep.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reporteusuario_idtel rep = new Reporteusuario_idtel();
            rep.Show();

        }
    }
}
