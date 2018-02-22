using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perfiles_usuario;
using System.Net;

namespace PrototipoSeguridad
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
          
            us.MdiParent = this;
            us.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles per = new Perfiles();
            per.MdiParent = this;
            per.Show(); 
        }

        private void asignacionPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfilesUsuario perU = new PerfilesUsuario();
            perU.MdiParent = this;
            perU.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bt = new Bitacora();
            bt.MdiParent = this;
            bt.Show();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicaciones2 ap = new Aplicaciones2();
            ap.MdiParent = this;
            ap.Show();
        }

        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioContraseña camb = new CambioContraseña();
            camb.MdiParent = this;
            camb.Show();
        }

        private void asignacionAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoApp maplicaciones = new Frm_MantenimientoApp();
            maplicaciones.MdiParent = this;
            maplicaciones.Show();
        }

        private void asignaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionaPerfiles ap = new AsignacionaPerfiles();
            ap.MdiParent = this; ap.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection formulariosApp = Application.OpenForms;
            foreach (Form f in formulariosApp)
            {
                if (f.Name != "frmLogin")
                {
                    f.Hide();
                }
            }
            Login login = new Login();
            login.Show();
        }

        private void reportesDeBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReporteBitacora repb = new ReporteBitacora();
            //repb.Show();
        }
        

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GenerarReporte repb = new GenerarReporte();
            repb.Show();
        }

        private void reportesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarReporteUsuario repb = new GenerarReporteUsuario();
            repb.Show();

        }

        private void pruebaIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracion integracion = new Integracion();
            integracion.Show();
        }
    }
}
