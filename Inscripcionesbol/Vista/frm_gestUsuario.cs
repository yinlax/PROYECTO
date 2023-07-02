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
    public partial class frm_gestUsuario : Form
    {
        public frm_gestUsuario()
        {
            InitializeComponent();
        }
        gestionarusuariosController obus = new gestionarusuariosController();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrarusuarios_Click(object sender, EventArgs e)
        {
            TUsuario oUsuario = new TUsuario();
            oUsuario.Cuenta = txt_cuenta.Text;
            oUsuario.Nombre = txt_nombreregistro.Text;
            oUsuario.Password = txt_password.Text;
            string rol;
            {
                if (rbt_director.Checked == true)
                { rol = "DIRECTOR"; }
                else
                { rol = "SECRETARI"; }
            }
            oUsuario.Rol= rol;
            string genero;
            {
                if (RBD_MASCULINO.Checked == true)
                { genero = "MASCULINO"; }
                else
                { genero = "FEMENINO"; }
            }
            oUsuario.Genero = genero;
            obus.registrar(oUsuario);
            cargar();
            MessageBox.Show("registro exitoso");
            cargar();

        }
        void cargar()
        {
            dgv_usuarios.DataSource = obus.listar();
        }

        private void frm_gestUsuario_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbt_secretaria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            lbl_a.Text = dgv_usuarios.CurrentRow.Cells[0].Value.ToString();
            txt_cuenta.Text = dgv_usuarios.CurrentRow.Cells[1].Value.ToString();
           txt_nombreregistro.Text = dgv_usuarios.CurrentRow.Cells[3].Value.ToString();
            txt_password.Text =dgv_usuarios.CurrentRow.Cells[2].Value.ToString();
            
            string genero;
            genero = dgv_usuarios.CurrentRow.Cells[5].Value.ToString();
            if (genero == "MASCULINO")
            {
                RBD_MASCULINO.Checked = true;
                RBD_FEMENINO.Checked = false;
            }
            if (genero == "FEMENINO")
            {
                RBD_FEMENINO.Checked = true;
                RBD_MASCULINO.Checked = false;
            }

            string rol;
            rol = dgv_usuarios.CurrentRow.Cells[4].Value.ToString();
            if (rol == "DIRECTOR")
            {
                rbt_director.Checked = true;
                rbt_secretaria.Checked = false;
            }
            if (rol == "SECRETARIA")
            {
                rbt_secretaria.Checked = true;
                rbt_director.Checked = false;
            }
        }

        private void LBL_USER(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_a.Text) > 0 && (MessageBox.Show("Quieres eliminar?", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                obus.eliminar(Convert.ToInt32(lbl_a.Text));
                MessageBox.Show("Eliminacion exitosa");
                cargar();
           //     nuevo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Esta sefguro de modificar el registro?", "MODIFICA", MessageBoxButtons.YesNo);
            if (Convert.ToInt32(lbl_a.Text) > 0 && (msg == DialogResult.Yes))
            {
                TUsuario ousu = new TUsuario();
                ousu.Id_Usuario = Convert.ToInt32(lbl_a.Text);
                ousu.Nombre = txt_nombreregistro.Text;
                ousu.Cuenta = txt_cuenta.Text;
                ousu.Password = txt_password.Text;
                string genero;
                if (RBD_MASCULINO.Checked == true)
                { genero = "MASCULINO"; }
                else
                { genero = "FEMENINO"; }
                ousu.Genero = genero;
                string rol;
                if (rbt_director.Checked == true)
                { rol = "DIRECTOR"; }
                else
                { rol = "SECRETARI"; }
                ousu.Genero = rol;

                obus.modificar(Convert.ToInt32(lbl_a.Text), ousu);
                MessageBox.Show("Registo Modificado satisfactoriamente");
                cargar();
                //nuevo();
            }
        }
    }
    }

