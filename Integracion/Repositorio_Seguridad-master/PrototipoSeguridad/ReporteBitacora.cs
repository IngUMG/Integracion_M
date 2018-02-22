using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace PrototipoSeguridad
{
    public partial class ReporteBitacora : Form
    {
        public ReporteBitacora()
        {
            InitializeComponent();

        }

        private void ReporteBitacora_Load(object sender, EventArgs e)
        {
            CrystalReportBitacora crp = new CrystalReportBitacora();

            crystalReportViewer1.ReportSource = crp;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
