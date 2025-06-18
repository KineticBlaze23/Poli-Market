using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private double precio;
        private int stock;

        public Producto(int idProducto, string nombre, double precio, int stock)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public int IdProducto
        {
            get { return idProducto; }
            private set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del producto no puede estar vacío.");
                nombre = value;
            }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio del producto no puede ser negativo.");
                precio = value;
            }
        }

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El stock del producto no puede ser negativo.");
                stock = value;
            }
        }

        public void ActualizarDatos(string nombre, double precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"ID: {IdProducto} \nNombre: {Nombre} \nPrecio: {Precio:C} \nStock: {Stock}";
        }
    }
}
