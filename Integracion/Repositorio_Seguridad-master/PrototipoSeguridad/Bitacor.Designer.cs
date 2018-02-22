namespace PrototipoSeguridad
{
    partial class Bitacora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cachedCrystalReportBitacora1 = new PrototipoSeguridad.CachedCrystalReportBitacora();
            this.cachedCrystalReportBitacora2 = new PrototipoSeguridad.CachedCrystalReportBitacora();
            this.cachedCrystalReportBitacora3 = new PrototipoSeguridad.CachedCrystalReportBitacora();
            this.bitac1 = new dll_bitacora.bitac();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bitac1
            // 
            this.bitac1.BackColor = System.Drawing.Color.LightBlue;
            this.bitac1.Location = new System.Drawing.Point(12, 12);
            this.bitac1.Name = "bitac1";
            this.bitac1.NombreTabla = "vista_bitacora";
            this.bitac1.Size = new System.Drawing.Size(1138, 728);
            this.bitac1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 Aplicaciones",
            "2 Perfiles",
            "3 Asignacion Perfiles",
            "4 Asignacion Aplicaciones",
            "5 Asignacion Perfiles a usuarios"});
            this.comboBox1.Location = new System.Drawing.Point(862, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "Aplicaciones";
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1178, 779);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bitac1);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CachedCrystalReportBitacora cachedCrystalReportBitacora1;
        private CachedCrystalReportBitacora cachedCrystalReportBitacora2;
        private CachedCrystalReportBitacora cachedCrystalReportBitacora3;
        private dll_bitacora.bitac bitac1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}