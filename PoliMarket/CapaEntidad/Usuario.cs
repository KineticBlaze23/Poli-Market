using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
            public string NombreUsuario { get; set; }
            public string Contraseña { get; set; }
            public string Rol { get; set; } // "Administrador" o "Empleado"

            public Usuario(string nombreUsuario, string contraseña, string rol)
            {
                NombreUsuario = nombreUsuario;
                Contraseña = contraseña;
                Rol = rol;
            }
        
    }
}
