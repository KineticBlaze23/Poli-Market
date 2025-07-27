using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;  

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        // Ruta relativa para el archivo de usuario, ubicada en la carpeta bin del ejecutable
        private static readonly string RutaDefaultUsuario = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistroUsuario.txt");
        private string rutaArchivoUsuario = RutaDefaultUsuario;

        public FormLogin(string rutaArchivoUsuario = null)
        {
            InitializeComponent();
            this.rutaArchivoUsuario = rutaArchivoUsuario ?? RutaDefaultUsuario;
            // Agrega las opciones al ComboBox
            cmbTiposDeIngreso.Items.Add("Administrador");
            cmbTiposDeIngreso.Items.Add("Empleado");
            this.StartPosition = FormStartPosition.CenterScreen;  // Centra el formulario en la pantalla    

            // Oculta el texto de la contraseña
            txtContraseña.PasswordChar = '*';

            // Permitir que Enter en txtUsuario o txtContraseña dispare btnIngresar
            this.AcceptButton = btnIngresar;

            // Inicializa el botón de ver contraseña
            btnVerContraseña.Tag = false; // false = oculto
        }

        public FormLogin() : this(RutaDefaultUsuario)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try

            {
                // Simula un error para probar el manejo de excepciones
                throw new Exception("Error de prueba generado manualmente.");
                string usuario = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();

                if (cmbTiposDeIngreso.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de ingreso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rol = cmbTiposDeIngreso.SelectedItem.ToString().Contains("Administrador") ? "Administrador" : "Empleado";

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Debe ingresar usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NegocioUsuario negocioUsuario = new NegocioUsuario(rutaArchivoUsuario);
                Usuario usuarioAutenticado = negocioUsuario.Autenticar(usuario, contraseña, rol);

                if (usuarioAutenticado != null)
                {

                    this.DialogResult = DialogResult.OK;
                    this.Tag = new { Rol = rol, Usuario = usuario };
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario, contraseña o tipo de ingreso incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                string logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login_errores.log");
                string mensajeLog = $"{DateTime.Now}: Error al intentar iniciar sesión - {ex.Message}{Environment.NewLine}";
                System.IO.File.AppendAllText(logPath, mensajeLog);

                MessageBox.Show("Ocurrió un error inesperado al intentar iniciar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre el formulario de registro de usuario
            FormRegistrarUsuario formRegistrar = new FormRegistrarUsuario(rutaArchivoUsuario);
            formRegistrar.ShowDialog();
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            bool visible = (bool)btnVerContraseña.Tag;
            if (visible)
            {
                txtContraseña.PasswordChar = '*';
                btnVerContraseña.Tag = false;
            }
            else
            {
                txtContraseña.PasswordChar = '\0';
                btnVerContraseña.Tag = true;
            }
        }
    }
}
