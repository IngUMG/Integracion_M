namespace PrototipoSeguridad
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.pb_logoUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(193, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 22);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(193, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(232, 258);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(77, 28);
            this.btn_Entrar.TabIndex = 21;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(73, 217);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(100, 20);
            this.lbl_contraseña.TabIndex = 20;
            this.lbl_contraseña.Text = "Constraseña";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(73, 182);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(64, 20);
            this.lbl_usuario.TabIndex = 19;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(215, 217);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(130, 22);
            this.txt_contraseña.TabIndex = 18;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(215, 182);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(130, 22);
            this.txt_usuario.TabIndex = 17;
            // 
            // pb_logoUsuario
            // 
            this.pb_logoUsuario.BackColor = System.Drawing.Color.White;
            this.pb_logoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pb_logoUsuario.Image")));
            this.pb_logoUsuario.Location = new System.Drawing.Point(208, 26);
            this.pb_logoUsuario.Name = "pb_logoUsuario";
            this.pb_logoUsuario.Size = new System.Drawing.Size(128, 131);
            this.pb_logoUsuario.TabIndex = 16;
            this.pb_logoUsuario.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 334);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pb_logoUsuario);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.PictureBox pb_logoUsuario;
    }
}