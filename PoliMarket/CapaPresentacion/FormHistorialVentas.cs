using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.IO;
using System.Linq;

namespace CapaPresentacion
{
    public partial class FormHistorialVentas : Form
    {
        private NegocioVenta negocioVenta;
        private NegocioCliente negocioCliente;
        private NegocioProducto negocioProducto;
        private string rutaArchivoVenta;
        private string rutaArchivoProducto;

        public FormHistorialVentas(NegocioVenta negocioVenta, NegocioCliente negocioCliente, NegocioProducto negocioProducto, string rutaArchivoVenta, string rutaArchivoProducto)
        {
            InitializeComponent();
            this.negocioVenta = negocioVenta;
            this.negocioCliente = negocioCliente;
            this.negocioProducto = negocioProducto;
            this.rutaArchivoVenta = rutaArchivoVenta;
            this.rutaArchivoProducto = rutaArchivoProducto;
            CargarHistorialVentas();
        }

        private void CargarHistorialVentas()
        {
            listViewVentas.Clear();
            listViewVentas.View = View.Details;
            listViewVentas.Columns.Add("ID Venta", 70);
            listViewVentas.Columns.Add("Cliente", 120);
            listViewVentas.Columns.Add("Producto", 120);
            listViewVentas.Columns.Add("Cantidad", 70);
            listViewVentas.Columns.Add("Precio Unitario", 100);
            listViewVentas.Columns.Add("Total", 80);
            listViewVentas.Columns.Add("Fecha", 120);

            negocioVenta.CargarVentasDesdeTxt(rutaArchivoVenta);
            foreach (var venta in negocioVenta.ListarVentas())
            {
                string nombreCliente = venta.IdCliente.ToString();
                var cliente = negocioCliente.BuscarPorId(venta.IdCliente);
                if (cliente != null)
                    nombreCliente = $"{cliente.Nombre} {cliente.Apellido}";

                string nombreProducto = "";
                if (venta.IdProducto > 0)
                {
                    var producto = negocioProducto.BuscarPorId(venta.IdProducto);
                    nombreProducto = producto != null ? producto.Nombre : venta.IdProducto.ToString();
                }
                string precioUnitario = venta.PrecioUnitario > 0 ? venta.PrecioUnitario.ToString("F2") : "";
                string cantidad = venta.Cantidad > 0 ? venta.Cantidad.ToString() : "";
                string total = venta.Total.ToString("F2");
                string fecha = venta.Fecha.ToString("dd/MM/yyyy HH:mm");

                var item = new ListViewItem(venta.IdVenta.ToString());
                item.SubItems.Add(nombreCliente);
                item.SubItems.Add(nombreProducto);
                item.SubItems.Add(cantidad);
                item.SubItems.Add(precioUnitario);
                item.SubItems.Add(total);
                item.SubItems.Add(fecha);
                listViewVentas.Items.Add(item);
            }
            listViewVentas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (listViewVentas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var item = listViewVentas.SelectedItems[0];
            int idVenta;
            if (!int.TryParse(item.SubItems[0].Text, out idVenta))
            {
                MessageBox.Show("ID de venta inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"¿Está seguro de eliminar la venta con ID {idVenta}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                negocioVenta.CargarVentasDesdeTxt(rutaArchivoVenta);
                negocioProducto.CargarProductosDesdeTxt(rutaArchivoProducto);
                if (negocioVenta.EliminarVenta(idVenta, negocioProducto))
                {
                    negocioVenta.GuardarVentasEnTxt(rutaArchivoVenta);
                    negocioProducto.GuardarProductosEnTxt(rutaArchivoProducto);
                    CargarHistorialVentas();
                    MessageBox.Show("Venta eliminada y stock devuelto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarPorFecha();
        }

        private void FiltrarPorFecha()
        {
            DateTime desde = dateTimePickerDesde.Value.Date;
            DateTime hasta = dateTimePickerHasta.Value.Date.AddDays(1).AddSeconds(-1); // Incluir todo el día 'hasta'
            listViewVentas.Items.Clear();
            listViewVentas.View = View.Details;
            listViewVentas.Columns.Clear();
            listViewVentas.Columns.Add("ID Venta", 70);
            listViewVentas.Columns.Add("Cliente", 120);
            listViewVentas.Columns.Add("Producto", 120);
            listViewVentas.Columns.Add("Cantidad", 70);
            listViewVentas.Columns.Add("Precio Unitario", 100);
            listViewVentas.Columns.Add("Total", 80);
            listViewVentas.Columns.Add("Fecha", 120);

            negocioVenta.CargarVentasDesdeTxt(rutaArchivoVenta);
            var ventasFiltradas = negocioVenta.ListarVentas()
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .ToList();
            foreach (var venta in ventasFiltradas)
            {
                string nombreCliente = venta.IdCliente.ToString();
                var cliente = negocioCliente.BuscarPorId(venta.IdCliente);
                if (cliente != null)
                    nombreCliente = $"{cliente.Nombre} {cliente.Apellido}";

                string nombreProducto = "";
                if (venta.IdProducto > 0)
                {
                    var producto = negocioProducto.BuscarPorId(venta.IdProducto);
                    nombreProducto = producto != null ? producto.Nombre : venta.IdProducto.ToString();
                }
                string precioUnitario = venta.PrecioUnitario > 0 ? venta.PrecioUnitario.ToString("F2") : "";
                string cantidad = venta.Cantidad > 0 ? venta.Cantidad.ToString() : "";
                string total = venta.Total.ToString("F2");
                string fecha = venta.Fecha.ToString("dd/MM/yyyy HH:mm");

                var item = new ListViewItem(venta.IdVenta.ToString());
                item.SubItems.Add(nombreCliente);
                item.SubItems.Add(nombreProducto);
                item.SubItems.Add(cantidad);
                item.SubItems.Add(precioUnitario);
                item.SubItems.Add(total);
                item.SubItems.Add(fecha);
                listViewVentas.Items.Add(item);
            }
            listViewVentas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormHistorialVentas_Load(object sender, EventArgs e)
        {
            // Inicializar los DateTimePicker con el rango de fechas de las ventas
            negocioVenta.CargarVentasDesdeTxt(rutaArchivoVenta);
            var ventas = negocioVenta.ListarVentas();
            if (ventas.Count > 0)
            {
                var minFecha = ventas.Min(v => v.Fecha);
                var maxFecha = ventas.Max(v => v.Fecha);
                dateTimePickerDesde.Value = minFecha;
                dateTimePickerHasta.Value = maxFecha;
            }
            FiltrarPorFecha();
        }
    }
}
