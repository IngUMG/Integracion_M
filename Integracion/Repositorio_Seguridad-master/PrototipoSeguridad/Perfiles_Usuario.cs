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

using MySql.Data.MySqlClient;
using System.Net;
using PrototipoSeguridad;

namespace Perfiles_usuario
{
    

    public partial class Perfiles_Usuario : Form
    {
        string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD=; Database=bd_seguridad; ";

        public Perfiles_Usuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               
                //Display query  
                string Query = "select id_usuario, nombre_usuario from usuario;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Cmb_id.DataSource = dTable;
                Cmb_id.ValueMember = "id_usuario";// here i have assign dTable object to the dataGridView1 object to display data.               
                Cmb_usuario.DataSource = dTable;
                Cmb_usuario.ValueMember = "nombre_usuario";// MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                
                string Query = "select * from perfil;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_perfil.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        

        private void Cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        private void aplicacion(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void llenar(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void llenarusuario(object sender, EventArgs e)
        {
            try
            {
                
                string Query = "select nombre_usuario from usuario where id_usuario = '" + Cmb_id.SelectedValue + "';";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Cmb_usuario.DataSource = dTable;
                Cmb_usuario.ValueMember = "nombre_usuario";// here i have assign dTable object to the dataGridView1 object to display data.               
                                                           // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenarid(object sender, EventArgs e)
        {
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
           
                Dgv_asignacion.Rows.Add(new string[]{
                Convert.ToString(Dgv_perfil[0,Dgv_perfil.CurrentRow.Index].Value),
                Convert.ToString(Dgv_perfil[1,Dgv_perfil.CurrentRow.Index].Value)

            });
           
            
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            Dgv_asignacion.Rows.RemoveAt(Dgv_asignacion.CurrentRow.Index);
        }

        private void Btn_removerTodo_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            dTable.Clear();
            Dgv_asignacion.DataSource = dTable;
        }

        private void Btn_agregarTodo_Click(object sender, EventArgs e)
        {
            for (int counter = 0; counter < (Dgv_perfil.Rows.Count) - 1;
            counter++)
            {
                Dgv_asignacion.Rows.Add(new string[]{
                     Convert.ToString(Dgv_perfil[0,counter].Value),
                Convert.ToString(Dgv_perfil[1,counter].Value)

            });
            }
        }

        private void Dgv_aplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
         
        }

        private void Dgv_soloapp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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


        private void Btn_edit_Click(object sender, EventArgs e)
        {
            int selectedIndex = Cmb_id.SelectedIndex+1;
            String error_nuevo = ""; obtenerIP();
            String app = "3";
            for (int counter = 0; counter < (Dgv_asignacion.Rows.Count) - 1;
         counter++)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  

                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into bd_seguridad.detalle_usuario_perfil(id_usuario,id_perfil) values('" + selectedIndex.ToString() + "','" + Convert.ToString(Dgv_asignacion[0, counter].Value) + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                    OdbcDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Save Data");
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                    connection.CloseConnection();

                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    s_error = "." + ex.Message + ".";
                    String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string i in A)
                    {
                        error_nuevo += i;
                    }
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso_n + "', '" + error_nuevo + "','" + localIP + "')");
                    connection.CloseConnection();
                }
            }
    }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            int selectedIndex = Cmb_id.SelectedIndex+1;
            String error_nuevo = ""; obtenerIP();
            String app = "3";

            try
            {
                string Query = "delete from  bd_seguridad.detalle_usuario_perfil where id_usuario='" + selectedIndex.ToString() + "';";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionD + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void Dgv_perfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                string Query ="select A.id_aplicacion, A.nombre_aplicacion from aplicacion A, detalle_perfil_aplicacion D where D.id_perfil='"+Dgv_perfil.CurrentCell.Value+"'and A.id_aplicacion = D.id_aplicacion; ";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_asignacion.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                      // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}