using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscripcionesbol.Vista
{
    public partial class frm_ventana1 : Form
    {
        public frm_ventana1()
        {
            InitializeComponent();
        }

        private void btn_regEstudiante_Click(object sender, EventArgs e)
        {
            frm_estudiante frm = new frm_estudiante();
            frm.ShowDialog();
        }

        private void btn_gestUsuario_Click(object sender, EventArgs e)
        {
            frm_gestUsuario frm = new frm_gestUsuario();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion?", "sdgasdg", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
