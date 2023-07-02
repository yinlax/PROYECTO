namespace Inscripcionesbol.Vista
{
    partial class frm_login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_usernamelogin = new System.Windows.Forms.TextBox();
            this.txt_passwordlogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(82, 338);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(175, 29);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.brt_login_Click);
            // 
            // txt_usernamelogin
            // 
            this.txt_usernamelogin.Location = new System.Drawing.Point(82, 206);
            this.txt_usernamelogin.Name = "txt_usernamelogin";
            this.txt_usernamelogin.Size = new System.Drawing.Size(175, 22);
            this.txt_usernamelogin.TabIndex = 3;
            this.txt_usernamelogin.Text = "Username";
            // 
            // txt_passwordlogin
            // 
            this.txt_passwordlogin.Location = new System.Drawing.Point(82, 253);
            this.txt_passwordlogin.Name = "txt_passwordlogin";
            this.txt_passwordlogin.Size = new System.Drawing.Size(175, 22);
            this.txt_passwordlogin.TabIndex = 4;
            this.txt_passwordlogin.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_passwordlogin);
            this.panel1.Controls.Add(this.txt_usernamelogin);
            this.panel1.Location = new System.Drawing.Point(225, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 446);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(97, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "INSTITUTO BOLIVIA";
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
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(825, 508);
            this.Controls.Add(this.panel1);
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_usernamelogin;
        private System.Windows.Forms.TextBox txt_passwordlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}