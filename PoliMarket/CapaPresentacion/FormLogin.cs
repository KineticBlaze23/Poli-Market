using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            // Agrega las opciones al ComboBox
            cmbTiposDeIngreso.Items.Add("Entrar como Administrador");
            cmbTiposDeIngreso.Items.Add("Entrar como Empleado");
            cmbTiposDeIngreso.SelectedIndex = 0; // Selecciona la primera opción por defecto 
            this.StartPosition = FormStartPosition.CenterScreen;  // Centra el formulario en la pantalla    

            // Oculta el texto de la contraseña
            txtContraseña.PasswordChar = '*';
        }

        private void cmbTiposDeIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            // Extrae sel rol basado en la selección del ComboBox
            string rol = cmbTiposDeIngreso.SelectedItem.ToString().Contains("Administrador") ? "Administrador" : "Empleado";

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            Usuario usuarioAutenticado = negocioUsuario.Autenticar(usuario, contraseña, rol);

            if (usuarioAutenticado != null)
            {
                FormOpciones formOpciones = new FormOpciones(rol);
                formOpciones.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario, contraseña o tipo de ingreso incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
