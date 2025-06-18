using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string cedula;
        private string correoElectronico;
        private string direccion;

        public Cliente(int idCliente, string nombre, string apellido)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
        }

        public int IdCliente
        {
            get { return idCliente; }
            private set { idCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                nombre = value;
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío.");
                apellido = value;
            }
        }

        public string Cedula
        {
            get { return cedula; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La cédula no puede estar vacía.");
                cedula = value;
            }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El correo electrónico no puede estar vacío.");
                correoElectronico = value;
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La dirección no puede estar vacía.");
                direccion = value;
            }
        }

        public void ActualizarDatos(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"ID Cliente: {IdCliente} - \nNombre: {Nombre} \nApellido: {Apellido}\nCédula: {Cedula}\nCorreo: {CorreoElectronico}\nDirección: {Direccion}";
        }
    }
}
