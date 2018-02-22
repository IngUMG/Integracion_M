namespace PrototipoSeguridad
{
    partial class AsignacionaPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionaPerfiles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(199, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre_aplicacion});
            this.dataGridView2.Location = new System.Drawing.Point(378, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(200, 479);
            this.dataGridView2.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // nombre_aplicacion
            // 
            this.nombre_aplicacion.HeaderText = "nombre_aplicacion";
            this.nombre_aplicacion.Name = "nombre_aplicacion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Lbl_editar
            // 
            this.Lbl_editar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_editar.Location = new System.Drawing.Point(281, 432);
            this.Lbl_editar.Name = "Lbl_editar";
            this.Lbl_editar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_editar.TabIndex = 19;
            this.Lbl_editar.Text = "Guardar";
            this.Lbl_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 620);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Limpiar Perfil";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quitar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Agregar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Aplicaciones Asignadas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Aplicaciones Disponibles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pefil Seleccionado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_edit
            // 
            this.Btn_edit.FlatAppearance.BorderSize = 0;
            this.Btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_edit.Image")));
            this.Btn_edit.Location = new System.Drawing.Point(281, 458);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(65, 65);
            this.Btn_edit.TabIndex = 20;
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.FlatAppearance.BorderSize = 0;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.Location = new System.Drawing.Point(284, 581);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(53, 36);
            this.Btn_borrar.TabIndex = 18;
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264596_1723360747698651_173196365_n1;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(290, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 31);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264625_1723360751031984_1344209642_n1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(290, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 41);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22236267_1723360744365318_2094413666_n1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(290, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 31);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264602_1723360754365317_1757528147_n1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(290, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 42);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(281, 364);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(65, 65);
            this.Btn_Guardar.TabIndex = 27;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Editar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(378, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 29;
            // 
            // AsignacionaPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(644, 655);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Lbl_editar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AsignacionaPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Aplicaciones a Perfiles de Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_aplicacion;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

