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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brt_login_Click(object sender, EventArgs e)
        {
            frm_ventana1 frm = new frm_ventana1();
            frm.ShowDialog();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
