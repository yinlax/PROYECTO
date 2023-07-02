namespace Inscripcionesbol.Vista
{
    partial class frm_estudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbt_masculino = new System.Windows.Forms.RadioButton();
            this.rbt_femenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_estudiantes = new System.Windows.Forms.DataGridView();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_montocacelado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_N = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_TIPO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_BUSCAR = new System.Windows.Forms.TextBox();
            this.TXT_EDAD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENERO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbt_masculino
            // 
            this.rbt_masculino.AutoSize = true;
            this.rbt_masculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbt_masculino.Location = new System.Drawing.Point(0, 8);
            this.rbt_masculino.Name = "rbt_masculino";
            this.rbt_masculino.Size = new System.Drawing.Size(109, 21);
            this.rbt_masculino.TabIndex = 4;
            this.rbt_masculino.TabStop = true;
            this.rbt_masculino.Text = "MASCULINO";
            this.rbt_masculino.UseVisualStyleBackColor = true;
            this.rbt_masculino.CheckedChanged += new System.EventHandler(this.rbt_masculino_CheckedChanged);
            // 
            // rbt_femenino
            // 
            this.rbt_femenino.AutoSize = true;
            this.rbt_femenino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbt_femenino.Location = new System.Drawing.Point(164, 8);
            this.rbt_femenino.Name = "rbt_femenino";
            this.rbt_femenino.Size = new System.Drawing.Size(100, 21);
            this.rbt_femenino.TabIndex = 5;
            this.rbt_femenino.TabStop = true;
            this.rbt_femenino.Text = "FEMENINO";
            this.rbt_femenino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(324, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "TELEFONO";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(142, 76);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(161, 22);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(142, 117);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(161, 22);
            this.txt_apellidos.TabIndex = 8;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(493, 29);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(161, 22);
            this.txt_celular.TabIndex = 9;
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(142, 27);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(161, 22);
            this.txt_ci.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "CI";
            // 
            // dgv_estudiantes
            // 
            this.dgv_estudiantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estudiantes.Location = new System.Drawing.Point(51, 342);
            this.dgv_estudiantes.Name = "dgv_estudiantes";
            this.dgv_estudiantes.RowTemplate.Height = 24;
            this.dgv_estudiantes.Size = new System.Drawing.Size(1263, 165);
            this.dgv_estudiantes.TabIndex = 13;
            this.dgv_estudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estudiantes_CellClick);
            this.dgv_estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estudiantes_CellContentClick);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrar.Location = new System.Drawing.Point(17, 218);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(135, 33);
            this.btn_registrar.TabIndex = 14;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminar.Location = new System.Drawing.Point(750, 192);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 33);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_buscar.Location = new System.Drawing.Point(876, 122);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(135, 33);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_modificar.Location = new System.Drawing.Point(51, 543);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(135, 33);
            this.btn_modificar.TabIndex = 17;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_salir.Location = new System.Drawing.Point(1179, 543);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(135, 33);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(324, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "MONTO CANCELADO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_montocacelado
            // 
            this.txt_montocacelado.Location = new System.Drawing.Point(493, 73);
            this.txt_montocacelado.Name = "txt_montocacelado";
            this.txt_montocacelado.Size = new System.Drawing.Size(161, 22);
            this.txt_montocacelado.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LBL_N);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TXT_TIPO);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TXT_BUSCAR);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.TXT_EDAD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_montocacelado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_registrar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.txt_ci);
            this.groupBox1.Controls.Add(this.txt_celular);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(51, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 269);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE ALUMNOS NUEVOS";
            // 
            // LBL_N
            // 
            this.LBL_N.AutoSize = true;
            this.LBL_N.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_N.Location = new System.Drawing.Point(660, 200);
            this.LBL_N.Name = "LBL_N";
            this.LBL_N.Size = new System.Drawing.Size(16, 17);
            this.LBL_N.TabIndex = 30;
            this.LBL_N.Text = "0";
            this.LBL_N.Click += new System.EventHandler(this.LBL_N_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(526, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "N_ESTUDIANTE:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TXT_TIPO
            // 
            this.TXT_TIPO.Location = new System.Drawing.Point(876, 27);
            this.TXT_TIPO.Name = "TXT_TIPO";
            this.TXT_TIPO.Size = new System.Drawing.Size(161, 22);
            this.TXT_TIPO.TabIndex = 28;
            this.TXT_TIPO.TextChanged += new System.EventHandler(this.TXT_TIPO_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(810, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "TIPO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TXT_BUSCAR
            // 
            this.TXT_BUSCAR.Location = new System.Drawing.Point(876, 73);
            this.TXT_BUSCAR.Name = "TXT_BUSCAR";
            this.TXT_BUSCAR.Size = new System.Drawing.Size(161, 22);
            this.TXT_BUSCAR.TabIndex = 26;
            this.TXT_BUSCAR.TextChanged += new System.EventHandler(this.TXT_BUSCAR_TextChanged);
            // 
            // TXT_EDAD
            // 
            this.TXT_EDAD.Location = new System.Drawing.Point(493, 122);
            this.TXT_EDAD.Name = "TXT_EDAD";
            this.TXT_EDAD.Size = new System.Drawing.Size(161, 22);
            this.TXT_EDAD.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(324, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "EDAD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(695, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "BUSCAR ESTUDAINTE";
            // 
            // btn_cargar
            // 
            this.btn_cargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cargar.ForeColor = System.Drawing.Color.Black;
            this.btn_cargar.Location = new System.Drawing.Point(252, 543);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(135, 33);
            this.btn_cargar.TabIndex = 22;
            this.btn_cargar.Text = "MATRICULAR";
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_masculino);
            this.groupBox2.Controls.Add(this.rbt_femenino);
            this.groupBox2.Location = new System.Drawing.Point(143, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 33);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // frm_estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1354, 628);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_estudiantes);
            this.Name = "frm_estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_estudiante";
            this.Load += new System.EventHandler(this.frm_estudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbt_masculino;
        private System.Windows.Forms.RadioButton rbt_femenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_estudiantes;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_montocacelado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.TextBox TXT_EDAD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_BUSCAR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_TIPO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LBL_N;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}