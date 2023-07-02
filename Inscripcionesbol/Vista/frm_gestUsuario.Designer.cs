namespace Inscripcionesbol.Vista
{
    partial class frm_gestUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBD_FEMENINO = new System.Windows.Forms.RadioButton();
            this.RBD_MASCULINO = new System.Windows.Forms.RadioButton();
            this.ROL = new System.Windows.Forms.GroupBox();
            this.rbt_secretaria = new System.Windows.Forms.RadioButton();
            this.rbt_director = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_registrarusuarios = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombreregistro = new System.Windows.Forms.TextBox();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.lbl_a);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ROL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_registrarusuarios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nombreregistro);
            this.groupBox1.Controls.Add(this.txt_cuenta);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(116, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 287);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTIONAR USUARIOS";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_a.Location = new System.Drawing.Point(574, 187);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(16, 17);
            this.lbl_a.TabIndex = 21;
            this.lbl_a.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(450, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "N DE USUARIO";
            this.label6.Click += new System.EventHandler(this.LBL_USER);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBD_FEMENINO);
            this.groupBox2.Controls.Add(this.RBD_MASCULINO);
            this.groupBox2.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox2.Location = new System.Drawing.Point(99, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 43);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RBD_FEMENINO
            // 
            this.RBD_FEMENINO.AutoSize = true;
            this.RBD_FEMENINO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBD_FEMENINO.Location = new System.Drawing.Point(157, 16);
            this.RBD_FEMENINO.Name = "RBD_FEMENINO";
            this.RBD_FEMENINO.Size = new System.Drawing.Size(100, 21);
            this.RBD_FEMENINO.TabIndex = 17;
            this.RBD_FEMENINO.TabStop = true;
            this.RBD_FEMENINO.Text = "FEMENINO";
            this.RBD_FEMENINO.UseVisualStyleBackColor = true;
            // 
            // RBD_MASCULINO
            // 
            this.RBD_MASCULINO.AutoSize = true;
            this.RBD_MASCULINO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBD_MASCULINO.Location = new System.Drawing.Point(6, 15);
            this.RBD_MASCULINO.Name = "RBD_MASCULINO";
            this.RBD_MASCULINO.Size = new System.Drawing.Size(109, 21);
            this.RBD_MASCULINO.TabIndex = 16;
            this.RBD_MASCULINO.TabStop = true;
            this.RBD_MASCULINO.Text = "MASCULINO";
            this.RBD_MASCULINO.UseVisualStyleBackColor = true;
            // 
            // ROL
            // 
            this.ROL.Controls.Add(this.rbt_secretaria);
            this.ROL.Controls.Add(this.rbt_director);
            this.ROL.ForeColor = System.Drawing.Color.AliceBlue;
            this.ROL.Location = new System.Drawing.Point(99, 110);
            this.ROL.Name = "ROL";
            this.ROL.Size = new System.Drawing.Size(321, 43);
            this.ROL.TabIndex = 18;
            this.ROL.TabStop = false;
            // 
            // rbt_secretaria
            // 
            this.rbt_secretaria.AutoSize = true;
            this.rbt_secretaria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbt_secretaria.Location = new System.Drawing.Point(157, 16);
            this.rbt_secretaria.Name = "rbt_secretaria";
            this.rbt_secretaria.Size = new System.Drawing.Size(120, 21);
            this.rbt_secretaria.TabIndex = 5;
            this.rbt_secretaria.TabStop = true;
            this.rbt_secretaria.Text = "SECRETARI@";
            this.rbt_secretaria.UseVisualStyleBackColor = true;
            this.rbt_secretaria.CheckedChanged += new System.EventHandler(this.rbt_secretaria_CheckedChanged);
            // 
            // rbt_director
            // 
            this.rbt_director.AutoSize = true;
            this.rbt_director.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbt_director.Location = new System.Drawing.Point(6, 16);
            this.rbt_director.Name = "rbt_director";
            this.rbt_director.Size = new System.Drawing.Size(100, 21);
            this.rbt_director.TabIndex = 4;
            this.rbt_director.TabStop = true;
            this.rbt_director.Text = "DIRECTOR";
            this.rbt_director.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "GENERO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ROL";
            // 
            // btn_registrarusuarios
            // 
            this.btn_registrarusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_registrarusuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrarusuarios.Location = new System.Drawing.Point(16, 216);
            this.btn_registrarusuarios.Name = "btn_registrarusuarios";
            this.btn_registrarusuarios.Size = new System.Drawing.Size(135, 33);
            this.btn_registrarusuarios.TabIndex = 14;
            this.btn_registrarusuarios.Text = "REGISTRAR";
            this.btn_registrarusuarios.UseVisualStyleBackColor = false;
            this.btn_registrarusuarios.Click += new System.EventHandler(this.btn_registrarusuarios_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(450, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(450, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CUENTA";
            // 
            // txt_nombreregistro
            // 
            this.txt_nombreregistro.Location = new System.Drawing.Point(142, 46);
            this.txt_nombreregistro.Name = "txt_nombreregistro";
            this.txt_nombreregistro.Size = new System.Drawing.Size(161, 22);
            this.txt_nombreregistro.TabIndex = 7;
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Location = new System.Drawing.Point(610, 46);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(161, 22);
            this.txt_cuenta.TabIndex = 9;
            this.txt_cuenta.TextChanged += new System.EventHandler(this.txt_cuenta_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(610, 119);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(161, 22);
            this.txt_password.TabIndex = 10;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(99, 361);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowTemplate.Height = 24;
            this.dgv_usuarios.Size = new System.Drawing.Size(843, 165);
            this.dgv_usuarios.TabIndex = 23;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_modificar.Location = new System.Drawing.Point(677, 555);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(135, 33);
            this.btn_modificar.TabIndex = 16;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(847, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 24;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(241, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 33);
            this.button3.TabIndex = 22;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_gestUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1028, 617);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_gestUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestUsuario";
            this.Load += new System.EventHandler(this.frm_gestUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ROL.ResumeLayout(false);
            this.ROL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_registrarusuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbt_director;
        private System.Windows.Forms.RadioButton rbt_secretaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombreregistro;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBD_FEMENINO;
        private System.Windows.Forms.RadioButton RBD_MASCULINO;
        private System.Windows.Forms.GroupBox ROL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Button button3;
    }
}