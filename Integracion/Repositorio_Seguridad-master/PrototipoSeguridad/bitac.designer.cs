namespace dll_bitacora
{
    partial class bitac
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bitac));
            this.Gpb_acciones = new System.Windows.Forms.GroupBox();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.Gpb_acciones.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_acciones
            // 
            this.Gpb_acciones.Controls.Add(this.Lbl_guardar);
            this.Gpb_acciones.Controls.Add(this.button1);
            this.Gpb_acciones.Location = new System.Drawing.Point(3, 19);
            this.Gpb_acciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_acciones.Name = "Gpb_acciones";
            this.Gpb_acciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_acciones.Size = new System.Drawing.Size(1124, 147);
            this.Gpb_acciones.TabIndex = 8;
            this.Gpb_acciones.TabStop = false;
            this.Gpb_acciones.Text = "Acciones";
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.Location = new System.Drawing.Point(473, 120);
            this.Lbl_guardar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.Size = new System.Drawing.Size(146, 27);
            this.Lbl_guardar.TabIndex = 2;
            this.Lbl_guardar.Text = "Actualizar";
            this.Lbl_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(487, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 106);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Dgv_bitacora);
            this.Gpb_datos.Location = new System.Drawing.Point(3, 170);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_datos.Size = new System.Drawing.Size(1124, 535);
            this.Gpb_datos.TabIndex = 9;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Dgv_bitacora
            // 
            this.Dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_bitacora.Location = new System.Drawing.Point(15, 36);
            this.Dgv_bitacora.Name = "Dgv_bitacora";
            this.Dgv_bitacora.RowTemplate.Height = 24;
            this.Dgv_bitacora.Size = new System.Drawing.Size(1079, 464);
            this.Dgv_bitacora.TabIndex = 0;
            this.Dgv_bitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_bitacora_CellContentClick);
            // 
            // bitac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gpb_acciones);
            this.Controls.Add(this.Gpb_datos);
            this.Name = "bitac";
            this.Size = new System.Drawing.Size(1138, 728);
            this.Gpb_acciones.ResumeLayout(false);
            this.Gpb_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_acciones;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.DataGridView Dgv_bitacora;
    }
}
