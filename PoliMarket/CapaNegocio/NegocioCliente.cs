using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioCliente
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int ultimoId = 0;

        // Registrar cliente, genera ID único
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

        // Actualizar cliente 
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

        // Eliminar cliente
        public bool EliminarCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if (cliente == null)
                return false;

            clientes.Remove(cliente);
            return true;
        }

        // Buscar clientes por nombre, para buscar en el form
        public List<Cliente> BuscarPorNombre(string nombre)
        {
            return clientes
                .Where(c => c.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        // Buscar cliente por ID, para modificar o eliminar en el form
        public Cliente BuscarPorId(int id)
        {
            return clientes.FirstOrDefault(c => c.IdCliente == id);
        }

        // Listar todos los clientes
        public List<Cliente> ListarClientes()
        {
            return new List<Cliente>(clientes);
        }

        // Guardar clientes en archivo TXT
        public void GuardarClientesEnTxt(string rutaArchivo)
        {
            using (var writer = new StreamWriter(rutaArchivo, false)) // false para sobrescribir el archivo
            {
                writer.WriteLine("IdCliente,Nombre,Apellido,Cedula,CorreoElectronico,Direccion"); 
                foreach (var cliente in clientes)
                {
                    writer.WriteLine($"{cliente.IdCliente},{cliente.Nombre},{cliente.Apellido},{cliente.Cedula},{cliente.CorreoElectronico},{cliente.Direccion}"); 
                }
            }
        }

        // Cargar clientes desde archivo TXT
        public void CargarClientesDesdeTxt(string rutaArchivo) 
        {
            clientes.Clear();
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
                    if (partes.Length == 6)
                    {
                        int.TryParse(partes[0], out int id);
                        var cliente = new Cliente(id, partes[1], partes[2])
                        {
                            Cedula = partes[3],
                            CorreoElectronico = partes[4],
                            Direccion = partes[5]
                        };
                        clientes.Add(cliente);
                        if (id > ultimoId) ultimoId = id;
                    }
                }
            }
        }
    }
}
