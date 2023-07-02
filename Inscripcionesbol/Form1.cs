using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inscripcionesbol.controlador;
using Inscripcionesbol.Vista;
namespace Inscripcionesbol
{
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
        
            string cuenta = txt_usernamelogin.Text;
            string clave = txt_passwordlogin.Text;

            if (cuenta == "admin" && clave == "12345")
            {
                this.Visible = true;
                this.ShowInTaskbar = false;
                PRINCIPAL FMenu = new PRINCIPAL();
                FMenu.Show();
                this.Hide();
                frm_ventana1 frm = new frm_ventana1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("La cuenta o clave son incorrectos.",
                    "INGLESBOLIVIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_usernamelogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
