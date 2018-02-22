namespace PrototipoSeguridad
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.gpb_usuario = new System.Windows.Forms.GroupBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_pApellido = new System.Windows.Forms.TextBox();
            this.txt_pNombre = new System.Windows.Forms.TextBox();
            this.lbl_pApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_pNombre = new System.Windows.Forms.Label();
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirmacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.gpb_usuario.SuspendLayout();
            this.Pnl_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Location = new System.Drawing.Point(360, 145);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.Size = new System.Drawing.Size(458, 234);
            this.dgv_usuario.TabIndex = 6;
            this.dgv_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuario_CellContentClick);
            // 
            // gpb_usuario
            // 
            this.gpb_usuario.Controls.Add(this.txt_confirmacion);
            this.gpb_usuario.Controls.Add(this.label1);
            this.gpb_usuario.Controls.Add(this.txt_usuario);
            this.gpb_usuario.Controls.Add(this.lbl_usuario);
            this.gpb_usuario.Controls.Add(this.txt_telefono);
            this.gpb_usuario.Controls.Add(this.txt_correo);
            this.gpb_usuario.Controls.Add(this.txt_contraseña);
            this.gpb_usuario.Controls.Add(this.lbl_telefono);
            this.gpb_usuario.Controls.Add(this.lbl_correo);
            this.gpb_usuario.Controls.Add(this.lbl_contraseña);
            this.gpb_usuario.Controls.Add(this.txt_pApellido);
            this.gpb_usuario.Controls.Add(this.txt_pNombre);
            this.gpb_usuario.Controls.Add(this.lbl_pApellido);
            this.gpb_usuario.Controls.Add(this.label3);
            this.gpb_usuario.Controls.Add(this.lbl_pNombre);
            this.gpb_usuario.Location = new System.Drawing.Point(20, 145);
            this.gpb_usuario.Name = "gpb_usuario";
            this.gpb_usuario.Size = new System.Drawing.Size(334, 234);
            this.gpb_usuario.TabIndex = 7;
            this.gpb_usuario.TabStop = false;
            this.gpb_usuario.Text = "DATOS USUARIO";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(140, 30);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(121, 20);
            this.txt_usuario.TabIndex = 33;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            this.txt_usuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_usuario_KeyUp);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(53, 37);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 32;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(140, 189);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(121, 20);
            this.txt_telefono.TabIndex = 31;
            this.txt_telefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_telefono_KeyUp);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(140, 163);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(121, 20);
            this.txt_correo.TabIndex = 30;
            this.txt_correo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_correo_KeyUp);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(140, 108);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(121, 20);
            this.txt_contraseña.TabIndex = 29;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(53, 189);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 27;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(53, 163);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_correo.TabIndex = 26;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(53, 108);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(55, 13);
            this.lbl_contraseña.TabIndex = 25;
            this.lbl_contraseña.Text = "Contrseña";
            // 
            // txt_pApellido
            // 
            this.txt_pApellido.Location = new System.Drawing.Point(140, 82);
            this.txt_pApellido.Name = "txt_pApellido";
            this.txt_pApellido.Size = new System.Drawing.Size(121, 20);
            this.txt_pApellido.TabIndex = 23;
            this.txt_pApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pApellido_KeyUp);
            // 
            // txt_pNombre
            // 
            this.txt_pNombre.Location = new System.Drawing.Point(140, 56);
            this.txt_pNombre.Name = "txt_pNombre";
            this.txt_pNombre.Size = new System.Drawing.Size(121, 20);
            this.txt_pNombre.TabIndex = 22;
            this.txt_pNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pNombre_KeyUp);
            // 
            // lbl_pApellido
            // 
            this.lbl_pApellido.AutoSize = true;
            this.lbl_pApellido.Location = new System.Drawing.Point(53, 82);
            this.lbl_pApellido.Name = "lbl_pApellido";
            this.lbl_pApellido.Size = new System.Drawing.Size(76, 13);
            this.lbl_pApellido.TabIndex = 21;
            this.lbl_pApellido.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 20;
            // 
            // lbl_pNombre
            // 
            this.lbl_pNombre.AutoSize = true;
            this.lbl_pNombre.Location = new System.Drawing.Point(53, 59);
            this.lbl_pNombre.Name = "lbl_pNombre";
            this.lbl_pNombre.Size = new System.Drawing.Size(76, 13);
            this.lbl_pNombre.TabIndex = 19;
            this.lbl_pNombre.Text = "Primer Nombre";
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
            this.Pnl_botones.Location = new System.Drawing.Point(296, 12);
            this.Pnl_botones.Name = "Pnl_botones";
            this.Pnl_botones.Size = new System.Drawing.Size(283, 106);
            this.Pnl_botones.TabIndex = 10;
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
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Confirmación";
            // 
            // txt_confirmacion
            // 
            this.txt_confirmacion.Location = new System.Drawing.Point(140, 135);
            this.txt_confirmacion.Name = "txt_confirmacion";
            this.txt_confirmacion.PasswordChar = '*';
            this.txt_confirmacion.Size = new System.Drawing.Size(121, 20);
            this.txt_confirmacion.TabIndex = 35;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(830, 391);
            this.Controls.Add(this.Pnl_botones);
            this.Controls.Add(this.gpb_usuario);
            this.Controls.Add(this.dgv_usuario);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.gpb_usuario.ResumeLayout(false);
            this.gpb_usuario.PerformLayout();
            this.Pnl_botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.GroupBox gpb_usuario;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_pApellido;
        private System.Windows.Forms.TextBox txt_pNombre;
        private System.Windows.Forms.Label lbl_pApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_pNombre;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel Pnl_botones;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label Lbl_borrar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_confirmacion;
        private System.Windows.Forms.Label label1;
    }
}

