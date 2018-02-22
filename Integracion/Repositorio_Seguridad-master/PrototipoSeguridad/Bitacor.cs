using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bitacora_dll;

namespace PrototipoSeguridad
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BitacoraForm appss = new BitacoraForm();
            appss.Show();
            this.Hide();
        }
    }
}
