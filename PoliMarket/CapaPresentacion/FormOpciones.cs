using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormOpciones : Form
    {
        private string rolUsuario;

        public FormOpciones(string rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolUsuario = rol;
            ConfigurarAccesoPorRol();
        }

        public FormOpciones()
        {
        }

        private void ConfigurarAccesoPorRol() // Método para configurar los botones según el rol del usuario
        {
            btnCliente.Enabled = true;
            btnVenta.Enabled = true;

            if (rolUsuario == "Administrador")
            {
                btnProducto.Enabled = true;
            }
            else // Si el rol no es Administrador, deshabilitar el botón de Producto
            {
                btnProducto.Enabled = false;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var formVenta = new FormVenta();
            this.Hide();
            formVenta.ShowDialog();
            this.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
            this.Hide();
            formProducto.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var formCliente = new FormCliente();
            this.Hide(); 
            formCliente.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormOpciones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
