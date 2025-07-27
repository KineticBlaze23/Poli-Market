using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioCliente
    {
        private List<Cliente> clientes = new List<Cliente>(); 
        private int ultimoId = 0;

        public Cliente RegistrarCliente(string nombre, string apellido, string cedula, string correoElectronico, string direccion)
        {
            var nuevoCliente = new Cliente(++ultimoId, nombre, apellido)
            {
                Cedula = cedula,
                CorreoElectronico = correoElectronico,
                Direccion = direccion
            };
            clientes.Add(nuevoCliente);
            return nuevoCliente;
        }

        public bool ActualizarCliente(Cliente clienteActualizado) 
        {
            if (clienteActualizado == null)
                throw new ArgumentNullException(nameof(clienteActualizado));

            var cliente = clientes.FirstOrDefault(c => c.IdCliente == clienteActualizado.IdCliente);
            if (cliente == null)
                return false;

            cliente.ActualizarDatos(clienteActualizado.Nombre, clienteActualizado.Apellido);
            return true;
        }

        public bool EliminarCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if (cliente == null)
                return false;

            clientes.Remove(cliente);
            return true;
        }

        public List<Cliente> BuscarPorNombre(string nombre) 
        {
            return clientes
                .Where(c => c.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            return clientes.FirstOrDefault(c => c.IdCliente == id);
        }

        public List<Cliente> ListarClientes()
        {
            return new List<Cliente>(clientes);
        }

        public void GuardarClientesEnTxt(string rutaArchivoCliente)
        {
            try
            {
                using (var writer = new StreamWriter(rutaArchivoCliente, false))
                {
                    writer.WriteLine("IdCliente,Nombre,Apellido,Cedula,CorreoElectronico,Direccion");
                    foreach (var cliente in clientes)
                    {
                        writer.WriteLine($"{cliente.IdCliente},{cliente.Nombre},{cliente.Apellido},{cliente.Cedula},{cliente.CorreoElectronico},{cliente.Direccion}");
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al guardar clientes en archivo: {ex.Message}", ex);
            }
        }

        public void GuardarVentasEnTxt(string rutaArchivoVenta, Venta venta, Cliente cliente, List<(Producto producto, int cantidad)> productosVendidos)
        {
            try
            {
                using (var writer = new StreamWriter(rutaArchivoVenta, true))
                {
                    if (new FileInfo(rutaArchivoVenta).Length == 0)
                        writer.WriteLine("ID Venta,Cliente,Producto,Cantidad,Precio Unitario,Total,Fecha");

                    foreach (var (producto, cantidad) in productosVendidos)
                    {
                        writer.WriteLine($"{venta.IdVenta},{cliente.Nombre},{producto.Nombre},{cantidad},{producto.Precio},{cantidad * producto.Precio},{venta.Fecha:dd/MM/yyyy HH:mm}");
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al guardar ventas en archivo: {ex.Message}", ex);
            }
        }

        public void CargarClientesDesdeTxt(string rutaArchivoCliente)
        {
            clientes.Clear();
            ultimoId = 0;

            try
            {
                if (!File.Exists(rutaArchivoCliente))
                    return;

                var lineas = File.ReadAllLines(rutaArchivoCliente).Skip(1); // Saltar cabecera

                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var cliente = ProcesarLineaCliente(linea);
                    if (cliente != null)
                    {
                        clientes.Add(cliente);
                        if (cliente.IdCliente > ultimoId)
                            ultimoId = cliente.IdCliente;
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al cargar clientes desde archivo: {ex.Message}", ex);
            }
        }

        // Método para validar y procesar cada línea
        private Cliente ProcesarLineaCliente(string linea)
        {
            var partes = linea.Split(',');

            if (partes.Length == 6 &&
                int.TryParse(partes[0], out int id))
            {
                try
                {
                    return new Cliente(id, partes[1], partes[2])
                    {
                        Cedula = partes[3],
                        CorreoElectronico = partes[4],
                        Direccion = partes[5]
                    };
                }
                catch (ArgumentException)
                {

                }
            }
            return null;
        }
    }
}
