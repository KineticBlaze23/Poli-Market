using System;
using System.Collections.Generic;
using System.Linq;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioVenta
    {
        private List<Venta> ventas = new List<Venta>();
        private int ultimoId = 0;

        // Registrar venta (genera ID único)
        public Venta RegistrarVenta(int idCliente, double total, DateTime? fecha = null)
        {
            var nuevaVenta = new Venta(++ultimoId, idCliente, total, fecha ?? DateTime.Now);
            ventas.Add(nuevaVenta);
            return nuevaVenta;
        }

        // Eliminar venta
        public bool EliminarVenta(int id)
        {
            var venta = ventas.FirstOrDefault(v => v.IdVenta == id);
            if (venta == null)
                return false;

            ventas.Remove(venta);
            return true;
        }

        // Buscar venta por ID
        public Venta BuscarPorId(int id)
        {
            return ventas.FirstOrDefault(v => v.IdVenta == id);
        }

        // Listar todas las ventas
        public List<Venta> ListarVentas()
        {
            return new List<Venta>(ventas);
        }
    }
}
