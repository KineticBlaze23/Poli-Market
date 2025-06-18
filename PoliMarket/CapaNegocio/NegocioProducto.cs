using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        private List<Producto> productos = new List<Producto>();
        private int ultimoId = 0;

        // Registrar producto, genera ID único
        public Producto RegistrarProducto(string nombre, double precio, int stock)
        {
            var nuevoProducto = new Producto(++ultimoId, nombre, precio, stock);
            productos.Add(nuevoProducto);
            return nuevoProducto;
        }

        // Actualizar producto 
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

        // Eliminar producto
        public bool EliminarProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.IdProducto == id);
            if (producto == null)
                return false;

            productos.Remove(producto);
            return true;
        }

        // Buscar producto por ID, para modificar o eliminar en el form
        public Producto BuscarPorId(int id)
        {
            return productos.FirstOrDefault(p => p.IdProducto == id);
        }

        // Buscar productos por nombre, para buscar en el form
        public List<Producto> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return new List<Producto>();

            return productos
                .Where(p => p.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        // Listar todos los productos
        public List<Producto> ListarProductos()
        {
            return new List<Producto>(productos);
        }

        // Guardar productos en un archivo txt 
        public void GuardarProductosEnTxt(string rutaArchivo)
        {
            using (var writer = new StreamWriter(rutaArchivo, false)) // Sobreescribe el archivo
            {
                writer.WriteLine("IdProducto,Nombre,Precio,Stock");
                foreach (var producto in productos)
                {
                    writer.WriteLine($"{producto.IdProducto},{producto.Nombre},{producto.Precio},{producto.Stock}");
                }
            }
        }

        // Cargar productos desde un archivo txt 
        public void CargarProductosDesdeTxt(string rutaArchivo) 
        {
            productos.Clear();
            ultimoId = 0;

            if (!File.Exists(rutaArchivo))
                return;

            using (var reader = new StreamReader(rutaArchivo))
            {
                string linea;
                bool primeraLinea = true;
                while ((linea = reader.ReadLine()) != null)
                {
                    if (primeraLinea) { primeraLinea = false; continue; }
                    var partes = linea.Split(',');
                    if (partes.Length == 4 &&
                        int.TryParse(partes[0], out int id) &&
                        double.TryParse(partes[2], out double precio) &&
                        int.TryParse(partes[3], out int stock))
                    {
                        var producto = new Producto(id, partes[1], precio, stock);
                        productos.Add(producto);
                        if (id > ultimoId) ultimoId = id;
                    }
                }
            }
        }
    }
}
