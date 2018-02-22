using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoSeguridad
{
    public partial class ReporteDUP_idusuario : Form
    {
        private rptDUP_idusuario rptDUP_idusuario1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public ReporteDUP_idusuario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptDUP_idusuario1 = new PrototipoSeguridad.rptDUP_idusuario();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptDUP_idusuario1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(284, 261);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // ReporteDUP_idusuario
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReporteDUP_idusuario";
            this.ResumeLayout(false);

        }
    }
}
