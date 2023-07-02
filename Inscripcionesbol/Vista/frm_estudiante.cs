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
using Inscripcionesbol.modelo;
namespace Inscripcionesbol.Vista
{
    public partial class frm_estudiante : Form
    {
        public frm_estudiante()
        {
            InitializeComponent();
        }
        EstudianteController obesContr =  new EstudianteController();
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar ()
        {
            dgv_estudiantes.DataSource = obesContr.listar();
        }

        private void dgv_estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_estudiante_Load(object sender, EventArgs e)
        {
            cargar ();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            TEstudiante oEstudiante = new TEstudiante();
            oEstudiante.Ci_Estudiante = txt_ci.Text;
            oEstudiante.Nombre = txt_nombre.Text;
            oEstudiante.Apellido = txt_apellidos.Text;
            oEstudiante.Edad = TXT_EDAD.Text;
            oEstudiante.Celular = txt_celular.Text;
            oEstudiante.Monto = txt_montocacelado.Text;
            oEstudiante.Tipo = TXT_TIPO.Text;
            string genero;
            {
                if (rbt_masculino.Checked == true)
                { genero = "MASCULINO"; }
                else
                { genero = "FEMENINO"; }
            }
            oEstudiante.Genero = genero;
            obesContr.registrar(oEstudiante);
            MessageBox.Show("registro exitoso");

            cargar();
            nuevo();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbt_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TXT_TIPO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_estudiantes.DataSource= obesContr.buscar (TXT_BUSCAR.Text);

        }

        private void dgv_estudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LBL_N.Text = dgv_estudiantes.CurrentRow.Cells[0].Value.ToString();
            txt_ci.Text= dgv_estudiantes.CurrentRow.Cells[7].Value.ToString();
            txt_nombre.Text = dgv_estudiantes.CurrentRow.Cells[1].Value.ToString();
            txt_apellidos.Text = dgv_estudiantes.CurrentRow.Cells[2].Value.ToString();
            TXT_EDAD.Text = dgv_estudiantes.CurrentRow.Cells[3].Value.ToString();
            txt_celular .Text = dgv_estudiantes.CurrentRow.Cells[5].Value.ToString();
            TXT_TIPO.Text = dgv_estudiantes.CurrentRow.Cells[6].Value.ToString();
            txt_montocacelado.Text = dgv_estudiantes.CurrentRow.Cells[8].Value.ToString();
            string genero;
            genero = dgv_estudiantes.CurrentRow.Cells[4].Value.ToString();
            if (genero == "MASCULINO")
            {
                rbt_masculino.Checked = true;
                rbt_femenino.Checked = false;
            }
            if (genero == "FEMENINO")
            {
                rbt_femenino.Checked = true;
                rbt_masculino.Checked = false;
            }
        }
        void nuevo()
        {
            LBL_N.Text = "0";
            txt_ci.Clear();
            txt_apellidos.Clear();
            txt_nombre.Clear();
            txt_celular.Clear();
            rbt_masculino.Checked = true;
            rbt_femenino.Checked = false;
            txt_montocacelado.Clear();
            TXT_EDAD.Clear();
            TXT_TIPO.Clear();
            txt_ci.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(LBL_N.Text) > 0 && (MessageBox.Show("Quieres eliminar?","ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                obesContr.eliminar(Convert.ToInt32(LBL_N.Text));
                MessageBox.Show("Eliminacion exitosa");
                cargar();
                nuevo();
            }
        }
     

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void LBL_N_Click(object sender, EventArgs e)
        {

        }

        private void TXT_BUSCAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Esta sefguro de modificar el registro?", "MODIFICA", MessageBoxButtons.YesNo);

            if (Convert.ToInt32(LBL_N.Text) > 0 && (msg == DialogResult.Yes))
            {
                TEstudiante oestudiante = new TEstudiante();
                oestudiante.Id_Estudiante = Convert.ToInt32(LBL_N.Text);
                oestudiante.Ci_Estudiante = txt_ci.Text;
                oestudiante.Apellido = txt_apellidos.Text;
                oestudiante.Nombre = txt_nombre.Text;
                string genero;
                if (rbt_masculino.Checked == true)
                { genero = "MASCULINO"; }
                else
                { genero = "FEMENINO"; }
                oestudiante.Genero = genero;
                oestudiante.Celular = txt_celular.Text;
                obesContr.modificar(Convert.ToInt32(LBL_N.Text), oestudiante);
                MessageBox.Show("Registo Modificado satisfactoriamente");
                cargar();
                nuevo();
            }
        }
    }
}
