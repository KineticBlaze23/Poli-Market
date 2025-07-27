using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        private List<Producto> productos = new List<Producto>();
        private int ultimoId = 0;

        public Producto RegistrarProducto(string nombre, double precio, int stock)
        {
            var nuevoProducto = new Producto(++ultimoId, nombre, precio, stock);
            productos.Add(nuevoProducto);
            return nuevoProducto;
        }

        public bool ActualizarProducto(Producto productoActualizado)
        {
            if (productoActualizado == null)
                throw new ArgumentNullException(nameof(productoActualizado));

            var producto = productos.FirstOrDefault(p => p.IdProducto == productoActualizado.IdProducto);
            if (producto == null)
                return false;

            producto.ActualizarDatos(productoActualizado.Nombre, productoActualizado.Precio, productoActualizado.Stock);
            return true;
        }

        public bool EliminarProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.IdProducto == id);
            if (producto == null)
                return false;

            productos.Remove(producto);
            return true;
        }

        public Producto BuscarPorId(int id)
        {
            return productos.FirstOrDefault(p => p.IdProducto == id);
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return new List<Producto>();

            return productos
                .Where(p => p.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<Producto> ListarProductos()
        {
            return new List<Producto>(productos);
        }

        public void GuardarProductosEnTxt(string rutaArchivo)
        {
            try
            {
                using (var writer = new StreamWriter(rutaArchivo, false))
                {
                    writer.WriteLine("IdProducto,Nombre,Precio,Stock");
                    foreach (var producto in productos)
                    {
                        writer.WriteLine($"{producto.IdProducto},{producto.Nombre},{producto.Precio.ToString(CultureInfo.InvariantCulture)},{producto.Stock}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar productos en archivo: {ex.Message}", ex);
            }
        }

        public void CargarProductosDesdeTxt(string rutaArchivo)
        {
            productos.Clear();
            ultimoId = 0;

            try
            {
                if (!File.Exists(rutaArchivo))
                    return;

                var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltar cabecera
                var idsCargados = new HashSet<int>();

                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var producto = ProcesarLineaProducto(linea);
                    if (producto != null && idsCargados.Add(producto.IdProducto))
                    {
                        productos.Add(producto);
                        if (producto.IdProducto > ultimoId)
                            ultimoId = producto.IdProducto;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar productos desde archivo: {ex.Message}", ex);
            }
        }

        // Método para lógica de procesamiento de líneas
        private Producto ProcesarLineaProducto(string linea)
        {
            var partes = linea.Split(',');
            if (partes.Length == 4 &&
                int.TryParse(partes[0], out int id) &&
                double.TryParse(partes[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double precio) &&
                int.TryParse(partes[3], out int stock))
            {
                return new Producto(id, partes[1], precio, stock);
            }
            return null;
        }
    }
}
