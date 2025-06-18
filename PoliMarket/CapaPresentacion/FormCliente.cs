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
    public partial class FormCliente : Form
    {
        private NegocioCliente negocioCliente = new NegocioCliente();
        private string rutaArchivoCliente = @"C:\Users\marti\OneDrive\Documentos\EPN\3er Semestre - 2025A\Programacion II\Proyecto\PoliMarket\RegistroCliente.txt"; // Ruta del archivo de clientes

        public FormCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configuración recomendada para el ListView
            listCliente.FullRowSelect = true;
            listCliente.MultiSelect = false;
            listCliente.View = View.Details;
            listCliente.SelectedIndexChanged += listCliente_SelectedIndexChanged;
        }

        private void FormCliente_Load(object sender, EventArgs e) 
        {
            listCliente.Columns.Clear();
            listCliente.Columns.Add("ID", 60);
            listCliente.Columns.Add("Nombre", 100);
            listCliente.Columns.Add("Apellido", 100);
            listCliente.Columns.Add("Cédula", 100);
            listCliente.Columns.Add("Correo", 150);
            listCliente.Columns.Add("Dirección", 150);

            // Cargar clientes desde el archivo antes de mostrar la lista
            negocioCliente.CargarClientesDesdeTxt(rutaArchivoCliente);

            ActualizarListaClientes();
        }

        private void btnRgresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtBNombre.Text.Trim();
            string apellido = txtBApellido.Text.Trim();
            string cedula = txtBCedula.Text.Trim();
            string correo = tctBCorreoElectronico.Text.Trim();
            string direccion = txtBDireccion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Debe ingresar todos los campos: nombre, apellido, cédula, correo electrónico y dirección.");
                return;
            }

            if (!CedulaValida(cedula))
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos numéricos.");
                return;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido (nombredeusuario@dominio.com).");
                return;
            }

            var existe = negocioCliente.ListarClientes()
                .Any(c => c.Cedula == cedula || c.CorreoElectronico == correo);

            if (existe)
            {
                MessageBox.Show("Ya existe un cliente con la misma cédula o correo electrónico.");
                return;
            }

            var cliente = negocioCliente.RegistrarCliente(nombre, apellido, cedula, correo, direccion);

            ActualizarListaClientes();

            negocioCliente.GuardarClientesEnTxt(rutaArchivoCliente);

            MessageBox.Show("Cliente agregado correctamente.");

            txtBNombre.Clear();
            txtBApellido.Clear();
            txtBCedula.Clear();
            tctBCorreoElectronico.Clear();
            txtBDireccion.Clear();
            txtBNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "¿Está seguro que desea eliminar el cliente seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                int idCliente = int.Parse(listCliente.SelectedItems[0].SubItems[0].Text);

                bool eliminado = negocioCliente.EliminarCliente(idCliente);

                if (eliminado)
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                    ActualizarListaClientes();

                    negocioCliente.GuardarClientesEnTxt(rutaArchivoCliente);

                    txtBNombre.Clear();
                    txtBApellido.Clear();
                    txtBCedula.Clear();
                    tctBCorreoElectronico.Clear();
                    txtBDireccion.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para modificar.");
                return;
            }

            int idCliente = int.Parse(listCliente.SelectedItems[0].SubItems[0].Text);

            string nombre = txtBNombre.Text;
            string apellido = txtBApellido.Text;
            string cedula = txtBCedula.Text;
            string correo = tctBCorreoElectronico.Text.Trim();
            string direccion = txtBDireccion.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Debe ingresar todos los campos: nombre, apellido, cédula, correo electrónico y dirección.");
                return;
            }

            if (!CedulaValida(cedula))
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos numéricos.");
                return;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido (nombredeusuario@dominio.com).");
                return;
            }

            Cliente clienteOriginal = negocioCliente.BuscarPorId(idCliente);
            if (clienteOriginal != null)
            {
                clienteOriginal.Nombre = nombre;
                clienteOriginal.Apellido = apellido;
                clienteOriginal.Cedula = cedula;
                clienteOriginal.CorreoElectronico = correo;
                clienteOriginal.Direccion = direccion;

                bool actualizado = negocioCliente.ActualizarCliente(clienteOriginal);

                if (actualizado)
                {
                    MessageBox.Show("Cliente modificado correctamente.");
                    ActualizarListaClientes();

                    negocioCliente.GuardarClientesEnTxt(rutaArchivoCliente);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el cliente.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el cliente a modificar.");
            }
        }

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCliente.SelectedItems.Count == 0)
                return;

            var item = listCliente.SelectedItems[0];
            txtBNombre.Text = item.SubItems[1].Text;
            txtBApellido.Text = item.SubItems[2].Text;
            txtBCedula.Text = item.SubItems[3].Text;
            tctBCorreoElectronico.Text = item.SubItems[4].Text;
            txtBDireccion.Text = item.SubItems[5].Text;
        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBNombre.Text))  // Primer caracter debe ser mayúscula
            {
                int selStart = txtBNombre.SelectionStart;
                string texto = txtBNombre.Text;
                string capitalizado = char.ToUpper(texto[0]) + texto.Substring(1);
                if (texto != capitalizado)
                {
                    txtBNombre.Text = capitalizado;
                    txtBNombre.SelectionStart = selStart;
                }
            }
        }

        private void txtxBApellido_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBApellido.Text))  // Primer caracter debe ser mayúscula
            {
                int selStart = txtBApellido.SelectionStart;
                string texto = txtBApellido.Text;
                string capitalizado = char.ToUpper(texto[0]) + texto.Substring(1);
                if (texto != capitalizado)
                {
                    txtBApellido.Text = capitalizado;
                    txtBApellido.SelectionStart = selStart;
                }
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                ActualizarListaClientes();
                return;
            }

            var listaFiltrada = negocioCliente.BuscarPorNombre(filtro);
            ActualizarListaClientesFiltrados(listaFiltrada);
        }

        private void txtFiltrar_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            List<Cliente> clientesFiltrados;

            if (string.IsNullOrEmpty(filtro))
            {
                clientesFiltrados = negocioCliente.ListarClientes();
            }
            else
            {
                clientesFiltrados = negocioCliente.BuscarPorNombre(filtro);
            }

            listCliente.Items.Clear();
            foreach (var cliente in clientesFiltrados)
            {
                ListViewItem item = new ListViewItem(cliente.IdCliente.ToString());
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Apellido);
                item.SubItems.Add(cliente.Cedula);
                item.SubItems.Add(cliente.CorreoElectronico);
                item.SubItems.Add(cliente.Direccion);

                listCliente.Items.Add(item);
            }

            negocioCliente.GuardarClientesEnTxt(rutaArchivoCliente);
        }

        private void txtBCedula_TextChanged(object sender, EventArgs e) { }
        private void tctBCorreoElectronico_TextChanged(object sender, EventArgs e) { }
        private void txtBDireccion_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void ActualizarListaClientes()
        {
            listCliente.Items.Clear();
            foreach (var cliente in negocioCliente.ListarClientes()) 
            {
                ListViewItem item = new ListViewItem(cliente.IdCliente.ToString());
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Apellido);
                item.SubItems.Add(cliente.Cedula);
                item.SubItems.Add(cliente.CorreoElectronico);
                item.SubItems.Add(cliente.Direccion);

                listCliente.Items.Add(item);
            }
        }

        private void ActualizarListaClientesFiltrados(List<Cliente> listaFiltrada)
        {
            throw new NotImplementedException();
        }

        private bool CedulaValida(string cedula)
        {
            return cedula.Length == 10 && cedula.All(char.IsDigit);
        }

        private bool CorreoValido(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }
    }
}
