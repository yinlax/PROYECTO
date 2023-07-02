namespace Inscripcionesbol.Vista
{
    partial class frm_ventana1
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
            this.btn_regEstudiante = new System.Windows.Forms.Button();
            this.btn_gestUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_regEstudiante
            // 
            this.btn_regEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_regEstudiante.Location = new System.Drawing.Point(123, 80);
            this.btn_regEstudiante.Name = "btn_regEstudiante";
            this.btn_regEstudiante.Size = new System.Drawing.Size(332, 154);
            this.btn_regEstudiante.TabIndex = 0;
            this.btn_regEstudiante.Text = "RESGITRO DE DATOS DELESTUDAINTE";
            this.btn_regEstudiante.UseVisualStyleBackColor = false;
            this.btn_regEstudiante.Click += new System.EventHandler(this.btn_regEstudiante_Click);
            // 
            // btn_gestUsuario
            // 
            this.btn_gestUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_gestUsuario.Location = new System.Drawing.Point(612, 80);
            this.btn_gestUsuario.Name = "btn_gestUsuario";
            this.btn_gestUsuario.Size = new System.Drawing.Size(332, 154);
            this.btn_gestUsuario.TabIndex = 1;
            this.btn_gestUsuario.Text = "GESTIONAR USUARIO";
            this.btn_gestUsuario.UseVisualStyleBackColor = false;
            this.btn_gestUsuario.Click += new System.EventHandler(this.btn_gestUsuario_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1104, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1316, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_gestUsuario);
            this.Controls.Add(this.btn_regEstudiante);
            this.Name = "frm_ventana1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventana1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regEstudiante;
        private System.Windows.Forms.Button btn_gestUsuario;
        private System.Windows.Forms.Button button1;
    }
}