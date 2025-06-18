using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FormProducto : Form
    {
        private NegocioProducto negocioProducto = new NegocioProducto();
        private string rutaArchivo = @"C:\Users\marti\OneDrive\Documentos\EPN\3er Semestre - 2025A\Programacion II\Proyecto\PoliMarket\RegistroProducto.txt"; // Ruta del archivo de productos

        public FormProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario al abrir  

            listProducto.FullRowSelect = true;
            listProducto.MultiSelect = false;
            listProducto.View = View.Details;
            listProducto.SelectedIndexChanged += listProducto_SelectedIndexChanged;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            negocioProducto.CargarProductosDesdeTxt(rutaArchivo);
            listProducto.Columns.Clear();
            listProducto.Columns.Add("ID", 60);
            listProducto.Columns.Add("Nombre", 120);
            listProducto.Columns.Add("Precio", 80);
            listProducto.Columns.Add("Stock", 80);

            ActualizarListaProductos();
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

        private void txtBStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e) 
        {
            string nombre = txtBNombre.Text.Trim();
            string precioStr = txtBPrecio.Text.Trim();
            string stockStr = txtBStock.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(precioStr) || string.IsNullOrEmpty(stockStr)) 
            {
                MessageBox.Show("Debe ingresar todos los campos: nombre, precio y stock.");
                return;
            }

            if (!double.TryParse(precioStr, out double precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.");
                return;
            }

            if (!int.TryParse(stockStr, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero positivo.");
                return;
            }

            // Verificar duplicados por nombre
            var existe = negocioProducto.ListarProductos()
                .Any(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (existe)
            {
                MessageBox.Show("Ya existe un producto con el mismo nombre.");
                return;
            }

            var producto = negocioProducto.RegistrarProducto(nombre, precio, stock);
            negocioProducto.GuardarProductosEnTxt(rutaArchivo);
            ActualizarListaProductos();

            MessageBox.Show("Producto agregado y guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBNombre.Clear();
            txtBPrecio.Clear();
            txtBStock.Clear();
            txtBNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listProducto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }

            int idProducto = int.Parse(listProducto.SelectedItems[0].SubItems[0].Text);

            string nombre = txtBNombre.Text.Trim();
            string precioStr = txtBPrecio.Text.Trim();
            string stockStr = txtBStock.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(precioStr) || string.IsNullOrEmpty(stockStr))
            {
                MessageBox.Show("Debe ingresar todos los campos: nombre, precio y stock.");
                return;
            }

            if (!double.TryParse(precioStr, out double precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.");
                return;
            }

            if (!int.TryParse(stockStr, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero positivo.");
                return;
            }

            Producto productoOriginal = negocioProducto.BuscarPorId(idProducto);
            if (productoOriginal != null)
            {
                productoOriginal.Nombre = nombre;
                productoOriginal.Precio = precio;
                productoOriginal.Stock = stock;

                bool actualizado = negocioProducto.ActualizarProducto(productoOriginal);

                if (actualizado)
                {
                    MessageBox.Show("Producto modificado correctamente.");
                    negocioProducto.GuardarProductosEnTxt(rutaArchivo);
                    ActualizarListaProductos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el producto a modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listProducto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "¿Está seguro que desea eliminar el producto seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                int idProducto = int.Parse(listProducto.SelectedItems[0].SubItems[0].Text);

                bool eliminado = negocioProducto.EliminarProducto(idProducto);

                if (eliminado)
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                    negocioProducto.GuardarProductosEnTxt(rutaArchivo);
                    ActualizarListaProductos();

                    txtBNombre.Clear();
                    txtBPrecio.Clear();
                    txtBStock.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.");
                }
            }
        }

        private void btnRgresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                ActualizarListaProductos();
                return;
            }

            var listaFiltrada = negocioProducto.BuscarPorNombre(filtro);
            ActualizarListaProductosFiltrados(listaFiltrada);
        }

        private void listProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProducto.SelectedItems.Count == 0)
                return;

            var item = listProducto.SelectedItems[0];
            txtBNombre.Text = item.SubItems[1].Text;
            // Si el precio viene como "$12.00", lo convertimos a número, facilita la modificación de precio y no presenta errores
            string precioTexto = item.SubItems[2].Text.Replace("$", "").Replace(",", "").Trim();
            txtBPrecio.Text = precioTexto;
            txtBStock.Text = item.SubItems[3].Text;
        }

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void ActualizarListaProductos()
        {
            listProducto.Items.Clear();
            foreach (var producto in negocioProducto.ListarProductos())
            {
                ListViewItem item = new ListViewItem(producto.IdProducto.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                item.SubItems.Add(producto.Stock.ToString());

                listProducto.Items.Add(item);
            }
        }

        private void ActualizarListaProductosFiltrados(List<Producto> listaFiltrada)
        {
            listProducto.Items.Clear();
            foreach (var producto in listaFiltrada)
            {
                ListViewItem item = new ListViewItem(producto.IdProducto.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                item.SubItems.Add(producto.Stock.ToString());

                listProducto.Items.Add(item);
            }
        }
    }
}
