using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormAutorizacionAdmin : Form
    {
        public string UsuarioAdmin { get; private set; }
        public string ContrasenaAdmin { get; private set; }
        public bool Autorizado { get; private set; } = false;
        private string rutaArchivoUsuario;

        public FormAutorizacionAdmin(string rutaArchivoUsuario)
        {
            InitializeComponent();
            this.rutaArchivoUsuario = rutaArchivoUsuario;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioAdmin.Text.Trim();  
            string contrasena = txtContrasenaAdmin.Text.Trim();
            NegocioUsuario negocio = new NegocioUsuario(rutaArchivoUsuario); 
            var admin = negocio.Autenticar(usuario, contrasena, "Administrador");  
            if (admin != null)
            {
                Autorizado = true;
                UsuarioAdmin = usuario; 
                ContrasenaAdmin = contrasena; 
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales de administrador incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
