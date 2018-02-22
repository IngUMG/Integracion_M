using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace PrototipoSeguridad
{
    public partial class Frm_MantenimientoApp : Form
    {

        public Frm_MantenimientoApp()
        {
            InitializeComponent();
        }

        MySqlConnection cn = new MySqlConnection("datasource = localhost; database=bd_seguridad;username=root;password=");
        int auxG = 1;
        int num, act, first, last;
        int I, M, Im, C, E, us;
        int edit, store;
        int id_user;
        int totalUser;
        int id_app;
        int firstu, lastu;
        string user;
        int uid, totalApp, aid;
        int auxx = 0;
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        

        private void Frm_MantenimientoApp_Load(object sender, EventArgs e)
        {
            bloqueados();
            //comboBox_app();
            comboBox_User();
            string sql = "select count(U.id_usuario) as total from Usuario U ";
            MySqlCommand com = new MySqlCommand(sql, cn);

            cn.Open();
            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {

                Txt_user.Text = Reader["total"].ToString();
                num = Convert.ToInt32(Txt_user.Text);
            }
            cn.Close();
           // primer();

        }

      

        public void primer() {

            string sql = "select  U.nombre_usuario, ap.nombre_aplicacion, D.ingresar, D.modificar, D.eliminar, D.imprimir,D.consultar from Usuario U, Aplicacion ap, Detalle_aplicacion_derecho D where D.id_usuario = " + auxG + " and D.id_usuario = U.id_usuario and D.id_aplicacion = ap.id_aplicacion; ";
            MySqlCommand com = new MySqlCommand(sql, cn);


            cn.Open();
            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {
                Txt_user.Text = Reader["nombre_usuario"].ToString();
                Txt_aplicacion.Text = Reader["nombre_aplicacion"].ToString();
                I = Convert.ToInt32(Reader["ingresar"]);
                M = Convert.ToInt32(Reader["modificar"]);
                Im = Convert.ToInt32(Reader["imprimir"]);
                C = Convert.ToInt32(Reader["consultar"]);
                E = Convert.ToInt32(Reader["eliminar"]);
            }

            if (I == 1) { Chb_insertar.Checked = true; } else { Chb_insertar.Checked = false; }
            if (M == 1) { Chb_editar.Checked = true; } else { Chb_editar.Checked = false; }
            if (Im == 1) { Chb_imprimir.Checked = true; } else { Chb_imprimir.Checked = false; }
            if (C == 1) { Chb_consultar.Checked = true; } else { Chb_consultar.Checked = false; }
            if (E == 1) { Chb_eliminar.Checked = true; } else { Chb_eliminar.Checked = false; }

            cn.Close();

        }

        
        private void Btn_refrescar_Click(object sender, EventArgs e)
        {

            primer();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "4";

            edit = 1;
            desbloqueados();
            connection.OpenConnection();
            connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
            connection.CloseConnection();



        }


        //Ingresa los nuevos privilegios a un usuario
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            if (Chb_editar.Checked == true) { M = 1; } else { M = 0; }
            if (Chb_insertar.Checked == true) { I = 1; } else { I = 0; }
            if (Chb_eliminar.Checked == true) { E = 1; } else { E = 0; }
            if (Chb_consultar.Checked == true) { C = 1; } else { C = 0; }
            if (Chb_imprimir.Checked == true) { Im = 1; } else { Im = 0; }
            String error_nuevo = ""; obtenerIP();
            String app = "4";
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into Detalle_aplicacion_derecho(id_usuario,id_aplicacion,ingresar, modificar,eliminar, imprimir,consultar) values(" + uid + ", " + aid + " , " + I + ", " + M + ", " + E + ", " + Im + ", " + C + ")", cn);
                int g;
                g = cmd.ExecuteNonQuery();
                MessageBox.Show("Se han Agregados los privilegios a " + Txt_user.Text);
                bloqueados();
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha Ingresado el Dato!");
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
            finally
            {
                cn.Close();
                comboBox_app();
            }
            

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            bloqueados();
            edit = 0;
            store = 0;
            Picb_aceptar.Visible = false;
            Cmb_aplicacion.Visible = false;
            primer();
        }

        public void bloqueados() {
            Chb_consultar.Enabled = false;
            Chb_editar.Enabled = false;
            Chb_eliminar.Enabled = false;
            Chb_imprimir.Enabled = false;
            Chb_insertar.Enabled = false;
            Cmb_aplicacion.Enabled = true;
            Cmb_user.Enabled = true;
        }

        public void desbloqueados() {
            Chb_consultar.Enabled = true;
            Chb_editar.Enabled = true;
            Chb_eliminar.Enabled = true;
            Chb_imprimir.Enabled = true;
            Chb_insertar.Enabled = true;
            Cmb_aplicacion.Enabled = false;
            Cmb_user.Enabled = false;
        }

        public void desbloquearD() {
            Chb_consultar.Enabled = true;
            Chb_editar.Enabled = true;
            Chb_eliminar.Enabled = true;
            Chb_imprimir.Enabled = true;
            Chb_insertar.Enabled = true;
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


        //Guarda los cambios que se han hecho en los derechos de un usuario
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Chb_editar.Checked == true) { M = 1; } else { M = 0; }
            if (Chb_insertar.Checked == true) { I = 1; } else { I = 0; }
            if (Chb_eliminar.Checked == true) { E = 1; } else { E = 0; }
            if (Chb_consultar.Checked == true) { C = 1; } else { C = 0; }
            if (Chb_imprimir.Checked == true) { Im = 1; } else { Im = 0; }


            int o, p, q, r, s, t;
            String error_nuevo = ""; obtenerIP();
            String app = "4";
            try
            {
                cn.Open();
                MySqlCommand cmd1 = new MySqlCommand("update Detalle_aplicacion_derecho set ingresar = " + I + " where id_usuario = " + uid + " and id_aplicacion = " + aid + ";", cn);
                MySqlCommand cmd2 = new MySqlCommand("update Detalle_aplicacion_derecho set modificar = " + M + " where id_usuario = " + uid + " and id_aplicacion = " + aid + ";", cn);
                MySqlCommand cmd3 = new MySqlCommand("update Detalle_aplicacion_derecho set eliminar = " + E + " where id_usuario = " + uid + " and id_aplicacion = " + aid + ";", cn);
                MySqlCommand cmd4 = new MySqlCommand("update Detalle_aplicacion_derecho set imprimir = " + Im + " where id_usuario = " + uid + " and id_aplicacion = " + aid + ";", cn);
                MySqlCommand cmd5 = new MySqlCommand("update Detalle_aplicacion_derecho set consultar = " + C + " where id_usuario = " + uid + " and id_aplicacion = " + aid + ";", cn);

                o = cmd1.ExecuteNonQuery();
                p = cmd2.ExecuteNonQuery();
                q = cmd3.ExecuteNonQuery();
                r = cmd4.ExecuteNonQuery();
                s = cmd5.ExecuteNonQuery();
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex);
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
            finally
            {
                cn.Close();
            }

            bloqueados();
        }




        // LLena el comboBox de aplicacion con los nombres de las aplicaciones que estan
        // asignadas al ususario; si el usuario no tiene aplicaciones asignadas
        // se llama a la funcion comboAppSimple
        public void comboBox_app() {
            cn.Open();
            try
            {
                countApp();
                if (totalApp == 0)
                {
     
                    Picb_aceptar.Visible = false;
                    comboAppSimple();
                    limpiarD();
                    desbloquearD();
                    Btn_ingresar.Enabled = true;
                    Btn_borrar.Enabled = false;
                }
                else {

                    bloqueados();
                    Btn_borrar.Enabled = true;
                    Btn_ingresar.Enabled = false;
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.Connection = cn;
                    sentencia.CommandText = "select A.nombre_aplicacion from Detalle_aplicacion_derecho D, Aplicacion A where D.id_usuario = " + uid + " and A.id_aplicacion = D.id_aplicacion;";

                    MySqlDataAdapter da1 = new MySqlDataAdapter(sentencia);
                    DataTable dt = new DataTable();
                    da1.Fill(dt);

                    //Cmb_aplicacion.ValueMember = "id_aplicacion";
                    Cmb_aplicacion.DisplayMember = "nombre_aplicacion";

                    Cmb_aplicacion.DataSource = dt;
                    Picb_aceptar.Visible = true;
                 
                    eventApp();
                }
            }
            catch (MySqlException ex)
            {
                comboAppSimple();
                Picb_aceptar.Visible = false;
            }
            finally
            {
                cn.Close();
            }
        }


        //Cuanta cuantas aplicaciones tiene un usuario
        public void countApp() {

           string sql = "select count(A.nombre_aplicacion) as totala from Detalle_aplicacion_derecho D, Aplicacion A where D.id_usuario = "+ uid+ " and A.id_aplicacion = D.id_aplicacion;";
            MySqlCommand cmd = new MySqlCommand(sql, cn);

            //cn.Open(); 
            MySqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
                totalApp = Convert.ToInt32(Reader["totala"]);
            }

            cn.Close();

        }

        // LLena el Combo box de aplicacion con todos los datos de la tabla aplicacion
        public void comboAppSimple() {
            MySqlCommand sentencia = new MySqlCommand();
            sentencia.Connection = cn;
            sentencia.CommandText = "SELECT * from Aplicacion";

            MySqlDataAdapter da1 = new MySqlDataAdapter(sentencia);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            //Cmb_aplicacion.ValueMember = "id_aplicacion";
            Cmb_aplicacion.DisplayMember = "nombre_aplicacion";

            Cmb_aplicacion.DataSource = dt;

        } 

        private void Cmb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            user = Cmb_user.Text;
            getUser();
            comboBox_app();

        }



        // Toma el Id del usuario escogido del Combo Box
        public void getUser() {


            
            string sql = "select id_usuario from usuario where nombre_usuario = '" + user + "'";
            MySqlCommand cmd2 = new MySqlCommand(sql, cn);


            if (auxx > 0) { cn.Open(); }
            MySqlDataReader Reader = cmd2.ExecuteReader();

            if (Reader.Read())
            {
                uid = Convert.ToInt32(Reader["id_usuario"]);
            }

            cn.Close();
            auxx = auxx + 1;
    }


        //Obtiene el id de la aplicacion
        public void getApp() {
            string sql = "select id_aplicacion from aplicacion where nombre_aplicacion = '" + Cmb_aplicacion.Text + "'";
            MySqlCommand cmd2 = new MySqlCommand(sql, cn);


            cn.Open(); 
            MySqlDataReader Reader = cmd2.ExecuteReader();

            if (Reader.Read())
            {
                aid = Convert.ToInt32(Reader["id_aplicacion"]);
            }

            cn.Close();
            auxx = auxx + 1;


        }


        public void comboBox_User()
        {
            cn.Open();
            try
            {

                MySqlCommand sentencia = new MySqlCommand();
                sentencia.Connection = cn;
                sentencia.CommandText = "SELECT * from usuario";

                MySqlDataAdapter da1 = new MySqlDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                Cmb_user.ValueMember = "id_usuario";
                Cmb_user.DisplayMember = "nombre_usuario";

                Cmb_user.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("no encontrado. " + ex);
            }
            finally
            {
                cn.Close();
            }
        }


        //Cambio de aplicacion en el comboBox
        private void Cmb_aplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            getApp();
            string sql = "select D.ingresar, D.modificar, D.eliminar, D.imprimir, D.consultar from Detalle_aplicacion_derecho D where id_usuario = "+ uid +" and id_aplicacion = " + aid + "; ";
            MySqlCommand com = new MySqlCommand(sql, cn);


            cn.Open();
            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {
                I = Convert.ToInt32(Reader["ingresar"]);
                M = Convert.ToInt32(Reader["modificar"]);
                Im = Convert.ToInt32(Reader["imprimir"]);
                C = Convert.ToInt32(Reader["consultar"]);
                E = Convert.ToInt32(Reader["eliminar"]);
            }

            if (I == 1) { Chb_insertar.Checked = true; } else { Chb_insertar.Checked = false; }
            if (M == 1) { Chb_editar.Checked = true; } else { Chb_editar.Checked = false; }
            if (Im == 1) { Chb_imprimir.Checked = true; } else { Chb_imprimir.Checked = false; }
            if (C == 1) { Chb_consultar.Checked = true; } else { Chb_consultar.Checked = false; }
            if (E == 1) { Chb_eliminar.Checked = true; } else { Chb_eliminar.Checked = false; }

            cn.Close();


        }

        private void Pnl_botones_Paint(object sender, PaintEventArgs e)
        {

        }

        public void limpiarD() {
            Chb_insertar.Checked = false;
            Chb_consultar.Checked = false;
            Chb_editar.Checked = false;
            Chb_eliminar.Checked = false;
            Chb_imprimir.Checked = false;
        }

        public void eventApp() {
            getApp();
            string sql = "select D.ingresar, D.modificar, D.eliminar, D.imprimir, D.consultar from Detalle_aplicacion_derecho D where id_usuario = " + uid + " and id_aplicacion = " + aid + "; ";
            MySqlCommand com = new MySqlCommand(sql, cn);


            cn.Open();
            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {
                I = Convert.ToInt32(Reader["ingresar"]);
                M = Convert.ToInt32(Reader["modificar"]);
                Im = Convert.ToInt32(Reader["imprimir"]);
                C = Convert.ToInt32(Reader["consultar"]);
                E = Convert.ToInt32(Reader["eliminar"]);
            }

            if (I == 1) { Chb_insertar.Checked = true; } else { Chb_insertar.Checked = false; }
            if (M == 1) { Chb_editar.Checked = true; } else { Chb_editar.Checked = false; }
            if (Im == 1) { Chb_imprimir.Checked = true; } else { Chb_imprimir.Checked = false; }
            if (C == 1) { Chb_consultar.Checked = true; } else { Chb_consultar.Checked = false; }
            if (E == 1) { Chb_eliminar.Checked = true; } else { Chb_eliminar.Checked = false; }

            cn.Close();

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            cn.Open();
            String error_nuevo = ""; obtenerIP();
            String app = "4";

            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from Detalle_aplicacion_derecho where id_usuario = " + uid + " and id_aplicacion = " + aid + ";", cn);

                int r;

                r = cmd.ExecuteNonQuery();
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionD + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                MessageBox.Show("Se ha Eliminado los privilegios en este Usuario!");
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se puede borrar este dato!");
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
            finally {
                cn.Close();
                comboBox_app();
            }
        }



        //####################################################################################################
        //####################################################################################################
        //####################################################################################################
        //####################################################################################################
        //####################################################################################################


        private void Chb_imprimir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chb_eliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chb_editar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chb_insertar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {

            if (store == 1)
            {
                auxG = auxG + 1;

                if (auxG >= first && auxG <= last)
                {

                }
                else
                {
                    auxG = first;

                }


            }
            else
            {
                auxG = auxG + 1;

                if (auxG >= first && auxG <= last)
                {
                    primer();
                }
                else
                {
                    auxG = first;
                    primer();
                }

            }
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {

            if (store == 1)
            {
                auxG = auxG + 1;

                if (auxG >= first && auxG <= last)
                {

                }
                else
                {
                    auxG = first;

                }


            }
            else
            {


                auxG = auxG - 1;

                if (auxG >= first && auxG <= last)
                {
                    primer();

                }
                else
                {
                    auxG = last;
                    primer();
                }
            }
        }

        private void Btn_primerElemento_Click(object sender, EventArgs e)
        {

            if (store == 1)
            {
                auxG = first;
            }
            else
            {
                auxG = first;
                primer();
            }
        }

        private void Btn_ultimoElemento_Click(object sender, EventArgs e)
        {
            if (store == 1)
            {
                auxG = last;
            }
            else
            {
                auxG = last;
                primer();
            }
        }


        private void Cmb_user_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

    }
}
