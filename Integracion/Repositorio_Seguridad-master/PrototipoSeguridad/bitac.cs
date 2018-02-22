using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_bitacora;


namespace dll_bitacora
{
    public partial class bitac : UserControl
    {

        [Description("Nombre de la tabla ")]
        [Category("Datos Nuevos")]
        public String NombreTabla { get; set; }


        public static String stringpad = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ";
        dll_bitacora connection = new dll_bitacora(stringpad);


        public bitac()
        {
            InitializeComponent();
        }

        private void Dgv_bitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.OpenConnection();
            Dgv_bitacora.DataSource = connection.llenarBitacora("select * from " + NombreTabla);
            connection.CloseConnection();
        }
    }
}
