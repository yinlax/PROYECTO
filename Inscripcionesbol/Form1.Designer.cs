namespace Inscripcionesbol
{
    partial class PRINCIPAL
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
            this.txt_usernamelogin = new System.Windows.Forms.TextBox();
            this.txt_passwordlogin = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_usernamelogin
            // 
            this.txt_usernamelogin.Location = new System.Drawing.Point(224, 209);
            this.txt_usernamelogin.Name = "txt_usernamelogin";
            this.txt_usernamelogin.Size = new System.Drawing.Size(175, 22);
            this.txt_usernamelogin.TabIndex = 3;
            this.txt_usernamelogin.TextChanged += new System.EventHandler(this.txt_usernamelogin_TextChanged);
            // 
            // txt_passwordlogin
            // 
            this.txt_passwordlogin.Location = new System.Drawing.Point(224, 285);
            this.txt_passwordlogin.Name = "txt_passwordlogin";
            this.txt_passwordlogin.Size = new System.Drawing.Size(175, 22);
            this.txt_passwordlogin.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(208, 355);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(175, 29);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(79, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "SISTEMA DE INSCRIPCION ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(73, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "INSTITUTO BOLIVIA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(59, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "USERNAME:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(53, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "PASSWORD:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_passwordlogin);
            this.panel1.Controls.Add(this.txt_usernamelogin);
            this.panel1.Location = new System.Drawing.Point(-6, -45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 513);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(561, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "SISTEMA DE INSCRIPCIONES";
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 423);
            this.Controls.Add(this.panel1);
            this.Name = "PRINCIPAL";
            this.Text = "PRINCIPAL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usernamelogin;
        private System.Windows.Forms.TextBox txt_passwordlogin;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}