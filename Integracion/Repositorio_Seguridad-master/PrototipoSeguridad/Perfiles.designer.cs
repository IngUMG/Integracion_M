namespace PrototipoSeguridad
{
    partial class Perfiles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfiles));
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_perfil = new System.Windows.Forms.DataGridView();
            this.Gpb_datos.SuspendLayout();
            this.Pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Lbl_descripcion);
            this.Gpb_datos.Controls.Add(this.Txt_descripcion);
            this.Gpb_datos.Controls.Add(this.Txt_nombre);
            this.Gpb_datos.Controls.Add(this.Lbl_nombre);
            this.Gpb_datos.Location = new System.Drawing.Point(10, 198);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(294, 202);
            this.Gpb_datos.TabIndex = 20;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "DATOS DEL PERFIL";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Location = new System.Drawing.Point(17, 87);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.Lbl_descripcion.TabIndex = 5;
            this.Lbl_descripcion.Text = "Descripción";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(101, 84);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(182, 78);
            this.Txt_descripcion.TabIndex = 4;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(101, 49);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(182, 20);
            this.Txt_nombre.TabIndex = 3;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(17, 52);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(70, 13);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Nombre Perfil";
            // 
            // Pnl_botones
            // 
            this.Pnl_botones.BackColor = System.Drawing.Color.LightBlue;
            this.Pnl_botones.Controls.Add(this.btn_borrar);
            this.Pnl_botones.Controls.Add(this.btn_editar);
            this.Pnl_botones.Controls.Add(this.Lbl_borrar);
            this.Pnl_botones.Controls.Add(this.Lbl_editar);
            this.Pnl_botones.Controls.Add(this.Lbl_guardar);
            this.Pnl_botones.Controls.Add(this.btn_guardar);
            this.Pnl_botones.Location = new System.Drawing.Point(207, 39);
            this.Pnl_botones.Name = "Pnl_botones";
            this.Pnl_botones.Size = new System.Drawing.Size(283, 106);
            this.Pnl_botones.TabIndex = 19;
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Image")));
            this.btn_borrar.Location = new System.Drawing.Point(199, 7);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(65, 65);
            this.btn_borrar.TabIndex = 16;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(111, 7);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 65);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // Lbl_borrar
            // 
            this.Lbl_borrar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_borrar.Location = new System.Drawing.Point(199, 75);
            this.Lbl_borrar.Name = "Lbl_borrar";
            this.Lbl_borrar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_borrar.TabIndex = 10;
            this.Lbl_borrar.Text = "Borrar";
            this.Lbl_borrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_editar
            // 
            this.Lbl_editar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_editar.Location = new System.Drawing.Point(111, 75);
            this.Lbl_editar.Name = "Lbl_editar";
            this.Lbl_editar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_editar.TabIndex = 7;
            this.Lbl_editar.Text = "Editar";
            this.Lbl_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.Location = new System.Drawing.Point(21, 75);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_guardar.TabIndex = 1;
            this.Lbl_guardar.Text = "Guardar";
            this.Lbl_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(21, 7);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_perfil
            // 
            this.dgv_perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_perfil.Location = new System.Drawing.Point(310, 198);
            this.dgv_perfil.Name = "dgv_perfil";
            this.dgv_perfil.Size = new System.Drawing.Size(358, 195);
            this.dgv_perfil.TabIndex = 18;
            this.dgv_perfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_perfil_CellContentClick_1);
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(679, 438);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Pnl_botones);
            this.Controls.Add(this.dgv_perfil);
            this.Name = "Perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERFILES";
            this.Load += new System.EventHandler(this.Perfiles_Load);
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.Pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Panel Pnl_botones;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label Lbl_borrar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_perfil;
    }
}

