namespace PrototipoSeguridad
{
    partial class CambioContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioContraseña));
            this.gpb_cambio = new System.Windows.Forms.GroupBox();
            this.txt_contraseñaN = new System.Windows.Forms.TextBox();
            this.txt_contraseñaA = new System.Windows.Forms.TextBox();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_contraseñaN = new System.Windows.Forms.Label();
            this.lbl_contraseñaA = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_accion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirmacion = new System.Windows.Forms.TextBox();
            this.gpb_cambio.SuspendLayout();
            this.pnl_accion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cambio
            // 
            this.gpb_cambio.Controls.Add(this.txt_confirmacion);
            this.gpb_cambio.Controls.Add(this.label1);
            this.gpb_cambio.Controls.Add(this.txt_contraseñaN);
            this.gpb_cambio.Controls.Add(this.txt_contraseñaA);
            this.gpb_cambio.Controls.Add(this.cmb_usuario);
            this.gpb_cambio.Controls.Add(this.lbl_contraseñaN);
            this.gpb_cambio.Controls.Add(this.lbl_contraseñaA);
            this.gpb_cambio.Controls.Add(this.lbl_usuario);
            this.gpb_cambio.Location = new System.Drawing.Point(42, 74);
            this.gpb_cambio.Name = "gpb_cambio";
            this.gpb_cambio.Size = new System.Drawing.Size(391, 158);
            this.gpb_cambio.TabIndex = 10;
            this.gpb_cambio.TabStop = false;
            this.gpb_cambio.Text = "DATOS";
            // 
            // txt_contraseñaN
            // 
            this.txt_contraseñaN.Location = new System.Drawing.Point(150, 95);
            this.txt_contraseñaN.Name = "txt_contraseñaN";
            this.txt_contraseñaN.PasswordChar = '*';
            this.txt_contraseñaN.Size = new System.Drawing.Size(158, 20);
            this.txt_contraseñaN.TabIndex = 6;
            // 
            // txt_contraseñaA
            // 
            this.txt_contraseñaA.Location = new System.Drawing.Point(150, 68);
            this.txt_contraseñaA.Name = "txt_contraseñaA";
            this.txt_contraseñaA.PasswordChar = '*';
            this.txt_contraseñaA.Size = new System.Drawing.Size(158, 20);
            this.txt_contraseñaA.TabIndex = 5;
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(150, 41);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(158, 21);
            this.cmb_usuario.TabIndex = 4;
            // 
            // lbl_contraseñaN
            // 
            this.lbl_contraseñaN.AutoSize = true;
            this.lbl_contraseñaN.Location = new System.Drawing.Point(43, 95);
            this.lbl_contraseñaN.Name = "lbl_contraseñaN";
            this.lbl_contraseñaN.Size = new System.Drawing.Size(96, 13);
            this.lbl_contraseñaN.TabIndex = 2;
            this.lbl_contraseñaN.Text = "Nueva Contraseña";
            // 
            // lbl_contraseñaA
            // 
            this.lbl_contraseñaA.AutoSize = true;
            this.lbl_contraseñaA.Location = new System.Drawing.Point(45, 68);
            this.lbl_contraseñaA.Name = "lbl_contraseñaA";
            this.lbl_contraseñaA.Size = new System.Drawing.Size(94, 13);
            this.lbl_contraseñaA.TabIndex = 1;
            this.lbl_contraseñaA.Text = "Contraseña Actual";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(45, 41);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.Location = new System.Drawing.Point(88, 101);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_guardar.TabIndex = 12;
            this.Lbl_guardar.Text = "Guardar";
            this.Lbl_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(88, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_accion
            // 
            this.pnl_accion.Controls.Add(this.Lbl_guardar);
            this.pnl_accion.Controls.Add(this.button1);
            this.pnl_accion.Location = new System.Drawing.Point(439, 82);
            this.pnl_accion.Name = "pnl_accion";
            this.pnl_accion.Size = new System.Drawing.Size(235, 150);
            this.pnl_accion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirmación";
            // 
            // txt_confirmacion
            // 
            this.txt_confirmacion.Location = new System.Drawing.Point(150, 121);
            this.txt_confirmacion.Name = "txt_confirmacion";
            this.txt_confirmacion.PasswordChar = '*';
            this.txt_confirmacion.Size = new System.Drawing.Size(158, 20);
            this.txt_confirmacion.TabIndex = 8;
            // 
            // CambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(734, 319);
            this.Controls.Add(this.pnl_accion);
            this.Controls.Add(this.gpb_cambio);
            this.Name = "CambioContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambioContraseña";
            this.gpb_cambio.ResumeLayout(false);
            this.gpb_cambio.PerformLayout();
            this.pnl_accion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpb_cambio;
        private System.Windows.Forms.TextBox txt_contraseñaN;
        private System.Windows.Forms.TextBox txt_contraseñaA;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.Label lbl_contraseñaN;
        private System.Windows.Forms.Label lbl_contraseñaA;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_accion;
        private System.Windows.Forms.TextBox txt_confirmacion;
        private System.Windows.Forms.Label label1;
    }
}