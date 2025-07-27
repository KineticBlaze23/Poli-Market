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
        private int idProducto;
        private int cantidad;
        private double precioUnitario;
        private DateTime fecha;
        private double total;

        public Venta(int idVenta, int idCliente, double total, DateTime fecha)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            Total = total;
            Fecha = fecha;
        }

        public Venta(int idVenta, int idCliente, int idProducto, int cantidad, double precioUnitario, double total, DateTime fecha)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            IdProducto = idProducto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
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
            set { idCliente = value; }
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                cantidad = value;
            }
        }

        public double PrecioUnitario
        {
            get { return precioUnitario; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio unitario no puede ser negativo.");
                precioUnitario = value;
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
                    throw new ArgumentException("El total no puede ser negativo.");
                total = value;
            }
        }
         
        public override string ToString()
        {
            return $"ID Venta: {IdVenta}\nID Cliente: {IdCliente}\nID Producto: {IdProducto}\nCantidad: {Cantidad}\nPrecio Unitario: {PrecioUnitario:C}\nFecha: {Fecha:dd/MM/yyyy HH:mm}\nTotal: {Total:C}";
        }
    }
}