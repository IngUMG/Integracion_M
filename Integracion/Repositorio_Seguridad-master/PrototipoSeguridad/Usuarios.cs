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
    public partial class Usuarios : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();

        public Usuarios()
        {
            InitializeComponent();
            mostrar_usuario();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
        }

        public void mostrar_usuario()
        {
            try
            {
                da = new OdbcDataAdapter("select u.id_usuario as Num,u.usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, u.correo_usuario as Correo, u.telefono_usuario as Telefono from Usuario u", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_usuario.DataSource = dt;
                dgv_usuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        string var_id;
        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_usuario.Rows[e.RowIndex];
                this.var_id = dgv.Cells[0].Value.ToString();
                txt_usuario.Text = dgv.Cells[1].Value.ToString();
                txt_pNombre.Text = dgv.Cells[2].Value.ToString();
                txt_pApellido.Text = dgv.Cells[3].Value.ToString();
                txt_contraseña.Enabled = false;
                txt_confirmacion.Enabled = false;
                txt_correo.Text = dgv.Cells[4].Value.ToString();
                txt_telefono.Text = dgv.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "6";

            try
            {
                string id_usuario; int id = 0;
                com = new OdbcCommand("select id_usuario from usuario where usuario ='" + txt_usuario.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_usuario = dr["id_usuario"].ToString();
                    id = Convert.ToInt32(id_usuario);
                }
                dr.Close();

                if (id == 0 && txt_confirmacion.Text == txt_contraseña.Text)
                {
                    //ingreso del nuevo usuario
                    com = new OdbcCommand("insert into usuario (usuario,nombre_usuario, apellido_usuario, contrasena, correo_usuario, telefono_usuario) values ('" + txt_usuario.Text + "','" + txt_pNombre.Text + "', '" + txt_pApellido.Text + "', AES_ENCRYPT( '" + txt_contraseña.Text + "','password'), '" + txt_correo.Text + "', " + Convert.ToInt32(txt_telefono.Text) + ")", con.conexion());
                    com.ExecuteNonQuery();
                    mostrar_usuario();
                    txt_usuario.Text = ""; txt_contraseña.Text = ""; txt_pNombre.Text = ""; txt_pApellido.Text = ""; txt_correo.Text = ""; txt_telefono.Text = "";
                    MessageBox.Show("Datos Ingresados");

                    //ingreso a la bitacora
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                    connection.CloseConnection();

                }
                else if (txt_confirmacion.Text != txt_contraseña.Text)
                {
                    MessageBox.Show("Contraseña no coincide con la Confirmación, Verificar.");
                }
                else
                {
                    MessageBox.Show("Nombre de Usuario ya existe, ingrese uno distinto.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información. ");

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "6";

            int i = 0;
            try
            {
                try
                {
                    com = new OdbcCommand("update usuario set usuario='" + txt_usuario.Text + "' where id_usuario=" + Convert.ToInt32(this.var_id), con.conexion());
                    com.ExecuteNonQuery();
                    //ingreso bitacora
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                    connection.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Usuario EXISTENTE, ingrese uno nuevo");
                    i = 1;
                    s_error = "." + ex.Message + ".";
                    String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string p in A)
                    {
                        error_nuevo += p;
                    }

                }

                com = new OdbcCommand("update usuario set usuario='" + txt_usuario.Text + "', nombre_usuario='" + txt_pNombre.Text + "', apellido_usuario='" + txt_pApellido.Text + "',correo_usuario ='" + txt_correo.Text + "',telefono_usuario =" + txt_telefono.Text + " where id_usuario=" + Convert.ToInt32(this.var_id), con.conexion());
                com.ExecuteNonQuery();
                mostrar_usuario();
                txt_usuario.Text = ""; txt_pNombre.Text = ""; txt_pApellido.Text = ""; txt_contraseña.Text = ""; txt_correo.Text = ""; txt_telefono.Text = ""; txt_contraseña.Enabled = true;
                MessageBox.Show("Datos actualizados.");
                //ingreso bitacora
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                s_error = "." + ex.Message + ".";
                String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string o in A)
                {
                    error_nuevo += o;
                }
                //error
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
            String app = "6";
            try
            {
                int id = Convert.ToInt32(this.var_id);
                string eliminar = "delete from usuario where id_usuario = " + id + " ";
                com = new OdbcCommand(eliminar, con.conexion());
                com.ExecuteNonQuery();
                //ingreso a la bitacora
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionD + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                mostrar_usuario();
                txt_usuario.Text = ""; txt_contraseña.Text = ""; txt_pNombre.Text = ""; txt_pApellido.Text = ""; txt_correo.Text = "";
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

                //ingreso a la bitacora
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionD + "', '" + app + "','" + Globales.sExitoso_n + "', '" + error_nuevo + "','" + localIP + "')");
                connection.CloseConnection();

            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

        }

        public void txt_usuario_KeyUp(object sender, KeyEventArgs e)
        {
            /*OdbcCommand cmd = con.conexion().CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select u.id_usuario as Num,u.usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, u.correo_usuario as Correo, u.telefono_usuario as Telefono from Usuario u where usuario like ('" + txt_usuario.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_usuario.DataSource = dt;
            dgv_usuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            con.conexion().Close();
      */

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void txt_pNombre_KeyUp(object sender, KeyEventArgs e)
        {
            /* OdbcCommand cmd = con.conexion().CreateCommand();

             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "select u.id_usuario as Num,u.usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, u.correo_usuario as Correo, u.telefono_usuario as Telefono from Usuario u where nombre_usuario like ('" + txt_pNombre.Text + "%')";
             cmd.ExecuteNonQuery();

             DataTable dt = new DataTable();
             OdbcDataAdapter da = new OdbcDataAdapter(cmd);

             da.Fill(dt);
             dgv_usuario.DataSource = dt;

             con.conexion().Close();*/
        }

        private void txt_pApellido_KeyUp(object sender, KeyEventArgs e)
        {
            /*OdbcCommand cmd = con.conexion().CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select u.id_usuario as Num,u.usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, u.correo_usuario as Correo, u.telefono_usuario as Telefono from Usuario u where apellido_usuario like ('" + txt_pApellido.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_usuario.DataSource = dt;

            con.conexion().Close();
            */
        }

        private void txt_correo_KeyUp(object sender, KeyEventArgs e)
        {
            /*OdbcCommand cmd = con.conexion().CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select u.id_usuario as Num,u.usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, u.correo_usuario as Correo, u.telefono_usuario as Telefono from Usuario u where correo_usuario like ('" + txt_correo.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_usuario.DataSource = dt;

            con.conexion().Close();
            */
        }

        private void txt_telefono_KeyUp(object sender, KeyEventArgs e)
        {
            /*OdbcCommand cmd = con.conexion().CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select u.id_usuario as Num,u.usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, u.correo_usuario as Correo, u.telefono_usuario as Telefono from Usuario u where telefono_usuario like ('" + txt_telefono.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_usuario.DataSource = dt;

            con.conexion().Close();
            */
        }
    }
}

