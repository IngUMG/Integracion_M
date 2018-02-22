﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System.Net;
using dll_bitacora;

namespace PrototipoSeguridad
{
    public partial class Aplicaciones2 : Form
    {
        OdbcConnection conn = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ");
        Conexion con = new Conexion();
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;

        public void Bloquear()
        {
            txt_aplicacion.Enabled = false;
            txt_aplicacion_descripcion.Enabled = false;
            txt_no_reporte.Enabled = false;
            Chb_habilitar_aplicacion.Enabled = false;

        }

        public Aplicaciones2()
        {
            InitializeComponent();
            mostrar_aplicacion();
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



        public void mostrar_aplicacion()
        {


            da = new OdbcDataAdapter("select *from aplicacion", con.conexion());
            dt = new DataTable();
            da.Fill(dt);
            dgv_aplicacion.DataSource = dt;
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "1";
            try
            {
                
                if (Chb_habilitar_aplicacion.Checked)
                {
                    txt_habilitar.Text = "1";
                    
                }
                else
                {
                    txt_habilitar.Text = "0";
                }


                com = new OdbcCommand("update aplicacion set nombre_aplicacion='" + txt_aplicacion.Text + "', descripcion_aplicacion='" + txt_aplicacion_descripcion.Text + "' , habilitar_aplicacion='" + txt_habilitar.Text + "', id_reporte='" + txt_no_reporte.Text + "'where id_aplicacion=" + Convert.ToInt32(this.var_aplicacion) + " ", con.conexion());
                com.ExecuteNonQuery();
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionE + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                mostrar_aplicacion();
                txt_aplicacion.Text = "";
                txt_aplicacion_descripcion.Text = "";
                txt_no_reporte.Text = "";
                txt_habilitar.Text = "";
                MessageBox.Show("Datos actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no actualizados");
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

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "1";
            try
            {
                if (Chb_habilitar_aplicacion.Checked)
                {
                    txt_habilitar.Text = "1";

                }
                else
                {
                    txt_habilitar.Text = "0";
                }

                com = new OdbcCommand("insert into aplicacion (nombre_aplicacion, descripcion_aplicacion, habilitar_aplicacion, id_reporte) values ('" + txt_aplicacion.Text + "', '" + txt_aplicacion_descripcion.Text + "', '" + txt_habilitar.Text + "', '" + txt_no_reporte.Text + "')", con.conexion());
                com.ExecuteNonQuery();

                MessageBox.Show("Datos Ingresados");
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                mostrar_aplicacion();
                txt_aplicacion.Text = "";
                txt_aplicacion_descripcion.Text = "";
                txt_no_reporte.Text = "";

            }
            catch (Exception ex)
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
                MessageBox.Show("Se ha Ingresado Incorrectamente!");

            }
        }
        string var_aplicacion;
        private void dgv_aplicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_aplicacion.Rows[e.RowIndex];

                this.var_aplicacion = dgv.Cells[0].Value.ToString();
                txt_aplicacion.Text = dgv.Cells[1].Value.ToString();
                txt_aplicacion_descripcion.Text = dgv.Cells[2].Value.ToString();
                txt_habilitar.Text = dgv.Cells[3].Value.ToString();
                txt_no_reporte.Text = dgv.Cells[4].Value.ToString();

            }
            catch (Exception ex)

            {
                MessageBox.Show("ERROR");
            }
        }

        private void Chb_habilitar_aplicacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Bloquear();
        }

        private void txt_aplicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {

        }

        private void txt_aplicacion_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            conn.Open();
            OdbcCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM aplicacion where nombre_aplicacion like ('" + txt_aplicacion.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_aplicacion.DataSource = dt;

            conn.Close();
            */
        }

        private void txt_aplicacion_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_aplicacion_descripcion_KeyUp(object sender, KeyEventArgs e)
        {
            /*conn.Open();
            OdbcCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM aplicacion where descripcion_aplicacion like ('" + txt_aplicacion_descripcion.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_aplicacion.DataSource = dt;

            conn.Close();
            */
        }

        private void txt_no_reporte_KeyUp(object sender, KeyEventArgs e)
        {
            /*conn.Open();
            OdbcCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM aplicacion where id_reporte like ('" + txt_no_reporte.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_aplicacion.DataSource = dt;

            conn.Close();
            */
        }

        private void Pnl_botones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "1";
            try
            {


                string id_aplicacion;
                int id = 0;
                com = new OdbcCommand("select id_aplicacion from aplicacion where nombre_aplicacion='" + txt_aplicacion.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_aplicacion = dr["id_aplicacion"].ToString();
                    id = Convert.ToInt32(id_aplicacion);
                }
                dr.Close();

                com = new OdbcCommand("delete from aplicacion where id_aplicacion=" + id + " ", con.conexion());
                com.ExecuteNonQuery();
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionD + "', '" + app + "','"  + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                connection.CloseConnection();

                txt_aplicacion.Text = "";
                txt_aplicacion_descripcion.Text = "";
                txt_habilitar.Text = "";
                txt_no_reporte.Text = "";
                mostrar_aplicacion();
                MessageBox.Show("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar, dato no puede ser eliminado");
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

        private void Aplicaciones2_Load(object sender, EventArgs e)
        {

        }
    }
}
