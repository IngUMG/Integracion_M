namespace Navegador
{
    partial class Navegador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_adelante = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(53, 3);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(40, 40);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_modificar, "Modificar");
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(99, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(40, 40);
            this.btn_eliminar.TabIndex = 1;
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_eliminar, "Eliminar");
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(191, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(40, 40);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(237, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(40, 40);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(283, 3);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(40, 40);
            this.btn_imprimir.TabIndex = 1;
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_imprimir, "Imprimir");
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_atras
            // 
            this.btn_atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_atras.Image")));
            this.btn_atras.Location = new System.Drawing.Point(329, 3);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(40, 40);
            this.btn_atras.TabIndex = 1;
            this.btn_atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_atras, "Atras");
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.Image = ((System.Drawing.Image)(resources.GetObject("btn_primero.Image")));
            this.btn_primero.Location = new System.Drawing.Point(421, 3);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(40, 40);
            this.btn_primero.TabIndex = 1;
            this.btn_primero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_primero, "Ultimo");
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.Image")));
            this.btn_ultimo.Location = new System.Drawing.Point(467, 3);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(40, 40);
            this.btn_ultimo.TabIndex = 1;
            this.btn_ultimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_ultimo, "Primero");
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_adelante
            // 
            this.btn_adelante.Image = ((System.Drawing.Image)(resources.GetObject("btn_adelante.Image")));
            this.btn_adelante.Location = new System.Drawing.Point(375, 3);
            this.btn_adelante.Name = "btn_adelante";
            this.btn_adelante.Size = new System.Drawing.Size(40, 40);
            this.btn_adelante.TabIndex = 1;
            this.btn_adelante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_adelante, "Adelante");
            this.btn_adelante.UseVisualStyleBackColor = true;
            this.btn_adelante.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_insertar.Image = ((System.Drawing.Image)(resources.GetObject("btn_insertar.Image")));
            this.btn_insertar.Location = new System.Drawing.Point(7, 3);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(40, 40);
            this.btn_insertar.TabIndex = 1;
            this.btn_insertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_insertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_insertar, "Insertar");
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.button1_Click);
            this.btn_insertar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(145, 3);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(40, 40);
            this.btn_actualizar.TabIndex = 1;
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_actualizar, "Actualizar");
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_ayuda.Image")));
            this.btn_ayuda.Location = new System.Drawing.Point(513, 3);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(40, 40);
            this.btn_ayuda.TabIndex = 2;
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_ayuda, "Ayuda");
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_adelante);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_insertar);
            this.Name = "Navegador";
            this.Size = new System.Drawing.Size(559, 47);
            this.Load += new System.EventHandler(this.Navegador_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_adelante;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_ayuda;
    }
}
