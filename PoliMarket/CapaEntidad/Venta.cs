using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        private int idVenta;
        private int idCliente;
        private DateTime fecha;
        private double total;

        public Venta(int idVenta, int idCliente, double total, DateTime fecha)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            Total = total;
            Fecha = fecha;
        }

        public int IdVenta
        {
            get { return idVenta; }
            private set { idVenta = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del cliente debe ser mayor que cero.");
                idCliente = value;
            }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public double Total
        {
            get { return total; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El total de la venta no puede ser negativo.");
                total = value;
            }
        }

        public override string ToString()
        {
            return $"ID Venta: {IdVenta}\nID Cliente: {IdCliente}\nFecha: {Fecha:dd/MM/yyyy HH:mm}\nTotal: {Total:C}";
        }
    }
}
