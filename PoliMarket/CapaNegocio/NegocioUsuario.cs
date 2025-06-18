using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private List<Usuario> usuarios = new List<Usuario>
    {
        new Usuario("admin", "admin123", "Administrador"), // Usuario administrador para pruebas
        new Usuario("empleado", "empleado123", "Empleado") // Usuario empleado para pruebas
    };

        public Usuario Autenticar(string nombreUsuario, string contraseña, string rol)
        {
            return usuarios.FirstOrDefault(u =>
                u.NombreUsuario == nombreUsuario &&
                u.Contraseña == contraseña &&
                u.Rol == rol);
        }
    }
}
