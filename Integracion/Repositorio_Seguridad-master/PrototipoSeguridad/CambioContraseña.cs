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

namespace PrototipoSeguridad
{
    public partial class CambioContraseña : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();

        public CambioContraseña()
        {
            InitializeComponent();
            llenado_cmb_usuario();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
           
        }
        public void llenado_cmb_usuario()
        {
            try
            {
                com = new OdbcCommand("select usuario from usuario", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_usuario.Items.Add(dr["usuario"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id_usuario;              
                int id = 0;
                com = new OdbcCommand("select id_usuario from usuario where usuario='" + cmb_usuario.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_usuario = dr["id_usuario"].ToString();
                    id = Convert.ToInt32(id_usuario);
                }
                dr.Close();

                string contraseña = null; 
                com = new OdbcCommand("select id_usuario from usuario where id_usuario =" + id + " and  AES_DECRYPT(contrasena,'password')='"+ txt_contraseñaA.Text +"' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    contraseña = dr["id_usuario"].ToString();
                }
                dr.Close();

                if (contraseña != null && txt_confirmacion.Text == txt_contraseñaN.Text)
                {
                    com = new OdbcCommand("update usuario set contrasena = AES_ENCRYPT('" + txt_contraseñaN.Text + "', 'password') where id_usuario = " + id + "", con.conexion());
                    com.ExecuteNonQuery();
                    MessageBox.Show("Contraseña actualizada.");
                }
                else if (txt_confirmacion.Text != txt_contraseñaN.Text)
                {
                    MessageBox.Show("Nueva Contraseña no coincide con la Confirmación, Verificar.");
                }
                else
                {
                    MessageBox.Show("Contraseña actual no corresponde "+contraseña);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex );
            }
            txt_contraseñaA.Text = "";
            txt_contraseñaN.Text = "";
            txt_confirmacion.Text = "";
    }
    }
    }

