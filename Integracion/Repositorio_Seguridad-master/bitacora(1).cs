using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using security_dll;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.NetworkInformation;

namespace PrototipoSeguridad
{
    public partial class Bitacora: Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Bitacora_Load(object sender, EventArgs e)
        {

        }

        private void bitacora_dll1_Load(object sender, EventArgs e)
        {

        }

        public static String sExitoso = "Exitoso";
        public static String sExitoso_n = "No exitoso";
        public static String sError = "no";
        public static String s_error;
        public static String localIP = "";

        public void obtenerIP()
        {
            IPHostEntry host;

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            MessageBox.Show(localIP);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            obtenerIP();

            String sAccion = "Guardar";
            String sTabla = "Detalle aplicacion derecho";
            String stringpad = "server=localhost;user id=root;database=BD_seguridad";
            security_dll.security_dll connection = new security_dll.security_dll(stringpad);

            //connection.OpenConnection();
            //connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,tabla,resultado_bitacora,error_bitacora,ip_pc) values(500, sysdate(), now(), '" + sAccion + "', '" + sTabla + "', '" + sExitoso + "', '" + sError + "','"+localIP+"')");
            //connection.CloseConnection();

          
            try
            {
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,tabla,resultado_bitacora,error_bitacora,ip_pc) values(500, sysdate(), now(), '" + sAccion + "', '" + sTabla + "', '" + sExitoso + "', '" + sError + "','" + localIP + "')");
                connection.CloseConnection();
                MessageBox.Show("Se ha Ingresado Correctamente!");
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
                s_error = "." + ex.Message + ".";
                MessageBox.Show(s_error);
            }
            }


       public void funGuardar()
        {
            String sAccion = "Guardar";
            String sTabla = "Bitacora";
            String stringpad = "server=localhost;user id=root;database=BD_seguridad";
            security_dll.security_dll connection = new security_dll.security_dll(stringpad);

            try
            {
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,tabla,resultado_bitacora,error_bitacora,ip_pc) values(500, sysdate(), now(), '" + sAccion + "', '" + sTabla + "', '" + sExitoso + "', '" + sError + "','" + localIP + "')");
                connection.CloseConnection();
                MessageBox.Show("Se ha Ingresado Correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                s_error = "." + ex.Message + ".";
                MessageBox.Show(s_error);
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,tabla,resultado_bitacora,error_bitacora,ip_pc) values(500, sysdate(), now(), '" + sAccion + "', '" + sTabla + "', '" + sExitoso_n + "', '" + s_error + "','" + localIP + "')");
                connection.CloseConnection();
                MessageBox.Show("Se ha Ingresado Correctamente!");
            }

        }
        
        private void bitacora_dll1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
