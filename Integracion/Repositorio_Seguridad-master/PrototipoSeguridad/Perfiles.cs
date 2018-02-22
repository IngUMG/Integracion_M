using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;

namespace PrototipoSeguridad
{
    public partial class Perfiles : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();

        public Perfiles()
        {
            InitializeComponent();
            mostrar_perfil();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


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
            //MessageBox.Show(localIP);
        }

        public static String s_error;
        private string localIP;
        private string error_nuevo;

        public static String stringpad = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ";
        bitacora_dll.bitacora_dll connection = new bitacora_dll.bitacora_dll(stringpad);





        public void mostrar_perfil()
        {
            try
            {
                da = new OdbcDataAdapter("select p.id_perfil as Num,p.nombre_perfil as nombre, descripcion_perfil as descripcion from perfil p", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_perfil.DataSource = dt;
                dgv_perfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {

        }
        string var_id;
        private void dgv_perfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "2";
            try
            {
                string id_perfil; int id = 0;
                com = new OdbcCommand("select id_perfil from perfil where nombre_perfil ='" + Txt_nombre.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_perfil = dr["id_perfil"].ToString();
                    id = Convert.ToInt32(id_perfil);
                }
                dr.Close();

                if (id == 0)
                {

                    com = new OdbcCommand("insert into Perfil ( nombre_perfil, descripcion_perfil) values ('" + Txt_nombre.Text + "','" + Txt_descripcion.Text + "')", con.conexion());
                    com.ExecuteNonQuery();
                    mostrar_perfil();
                    Txt_nombre.Text = ""; Txt_nombre.Text = ""; Txt_descripcion.Text = "";
                    MessageBox.Show("Datos Ingresados");
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                    connection.CloseConnection();

                }
                else
                {
                    MessageBox.Show("Nombre de perfil ya existe, ingrese uno distinto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información. "+ex.ToString());
                s_error = "." + ex.Message + ".";
                String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string i in A)
                {
                    error_nuevo += i;
                }
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso_n + "', '" + error_nuevo + "','" + localIP + "')");
                connection.CloseConnection();

            }
        }

   
      private void btn_editar_Click(object sender, EventArgs e)
        {
            int i = 0;
            String error_nuevo = ""; obtenerIP();
            String app = "2";

            try
            {
                try
                {
                    com = new OdbcCommand("update perfil set nombre_perfil='" + Txt_nombre.Text + "' where id_perfil=" + Convert.ToInt32(this.var_id), con.conexion());
                    com.ExecuteNonQuery();
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                    connection.CloseConnection();

                }
                catch (Exception exe)
                {
                    MessageBox.Show("Perfil existente, ingrese uno nuevo");
                    i = 1;
                }

                com = new OdbcCommand("update perfil set nombre_perfil='" + Txt_nombre.Text + "', descripcion_perfil='" + Txt_descripcion.Text + "' where id_perfil=" + Convert.ToInt32(this.var_id), con.conexion());
                com.ExecuteNonQuery();
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                mostrar_perfil();
                Txt_nombre.Text = ""; Txt_descripcion.Text = "";
                MessageBox.Show("Datos actualizados.");
            }
            catch (Exception ex)
            {
                s_error = "." + ex.Message + ".";
                String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string o in A)
                {
                    error_nuevo += o;
                }
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso_n + "', '" + error_nuevo + "','" + localIP + "')");
                connection.CloseConnection();
                if (i == 1)
                {
                }
                else
                {
                    MessageBox.Show("Datos NO actualizados, verifique información.");
                }
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "2";

            try
            {
                int id = Convert.ToInt32(this.var_id);
                string eliminar = "delete from perfil where id_perfil = " + id + " ";
                com = new OdbcCommand(eliminar, con.conexion());
                com.ExecuteNonQuery();
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionD + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                mostrar_perfil();
                Txt_nombre.Text = ""; Txt_descripcion.Text = "";
                MessageBox.Show("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados.");
                s_error = "." + ex.Message + ".";
                String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string i in A)
                {
                    error_nuevo += i;
                }
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionD + "', '" + app + "','" + Globales.sExitoso_n + "', '" + error_nuevo + "','" + localIP + "')");
                connection.CloseConnection();

            }
        }

        private void dgv_perfil_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow dgv = dgv_perfil.Rows[e.RowIndex];
                this.var_id = dgv.Cells[0].Value.ToString();
                Txt_nombre.Text = dgv.Cells[1].Value.ToString();
                Txt_descripcion.Text = dgv.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Perfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
