using System;
using System.Windows.Forms;
using System.IO;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormRegistrarUsuario : Form
    {
        // Usar la misma ubicación que los otros archivos txt
        private static readonly string RutaDefaultUsuario = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistroUsuario.txt");
        private string rutaArchivoUsuario;

        private void VerificarYCrearArchivoUsuario()
        {
            try
            {
                if (!File.Exists(rutaArchivoUsuario))
                    File.WriteAllText(rutaArchivoUsuario, ""); // Sin cabecera, formato: usuario|contraseña|rol
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creando archivo de usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormRegistrarUsuario(string rutaArchivoUsuario = null)
        {
            InitializeComponent();
            this.rutaArchivoUsuario = rutaArchivoUsuario ?? RutaDefaultUsuario;
            VerificarYCrearArchivoUsuario();
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Empleado");
            cmbRol.SelectedIndex = -1; // No seleccionar nada por defecto
            btnRegistrar.Click += btnRegistrar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnVerContraseña.Tag = false;
            btnVerConfirmarContraseña.Tag = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string confirmar = txtConfirmarContraseña.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(confirmar) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (contraseña != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Si el rol es Administrador, pedir autorización
            if (rol == "Administrador")
            {
                using (var formAdmin = new FormAutorizacionAdmin(rutaArchivoUsuario))
                {
                    if (formAdmin.ShowDialog() != DialogResult.OK || !formAdmin.Autorizado)
                    {
                        MessageBox.Show("No se autorizó el registro de administrador.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            NegocioUsuario negocio = new NegocioUsuario(rutaArchivoUsuario);
            string mensaje;
            if (negocio.RegistrarUsuario(usuario, contraseña, rol, out mensaje))
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnVerConfirmarContraseña_Click(object sender, EventArgs e)
        {
            bool visible = (bool)btnVerConfirmarContraseña.Tag;
            if (visible)
            {
                txtConfirmarContraseña.PasswordChar = '*';
                btnVerConfirmarContraseña.Tag = false;
            }
            else
            {
                txtConfirmarContraseña.PasswordChar = '\0';
                btnVerConfirmarContraseña.Tag = true;
            }
        }
      
    }
}
