using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security_dll
{
    public partial class Bitacora_dll : UserControl
    {

        [Description("Nombre de la tabla ")]
        [Category("Datos Nuevos")]
        public String NombreTabla { get; set; }


        public static String stringpad = "server=localhost;user id=root;database=BD_seguridad";
        security_dll connection = new security_dll(stringpad);

        public Bitacora_dll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.OpenConnection();
            Dgv_bitacora.DataSource = connection.llenarBitacora("select * from " + NombreTabla );
            connection.CloseConnection();
        }
    }
}
