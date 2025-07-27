using CapaEntidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private string rutaArchivoUsuario; 
        private List<Usuario> usuarios = new List<Usuario>();

        public NegocioUsuario(string rutaArchivoUsuario)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string nombreArchivo = Path.GetFileName(rutaArchivoUsuario);
            this.rutaArchivoUsuario = Path.Combine(baseDir, nombreArchivo ?? "RegistroUsuario.txt");
            CargarUsuariosDesdeArchivo();
        }

        public void CargarUsuariosDesdeArchivo()
        {
            usuarios.Clear();
            if (File.Exists(rutaArchivoUsuario))
            {
                var lineas = File.ReadAllLines(rutaArchivoUsuario);
                foreach (var linea in lineas)
                {
                    var partes = linea.Split('|');
                    if (partes.Length == 3)
                    {
                        try
                        {
                            usuarios.Add(new Usuario(partes[0], partes[1], partes[2]));
                        }
                        catch (ArgumentException)
                        {

                        }
                    }
                }
            }
        }

        public void GuardarUsuariosEnArchivo()
        {
            var lineas = usuarios.Select(u => $"{u.NombreUsuario}|{u.Contraseña}|{u.Rol}");
            File.WriteAllLines(rutaArchivoUsuario, lineas);
        }

        public Usuario Autenticar(string nombreUsuario, string contraseña, string rol)
        {
            return usuarios.FirstOrDefault(u =>
                u.NombreUsuario == nombreUsuario &&
                u.Contraseña == contraseña &&
                u.Rol == rol);
        }

        public bool RegistrarUsuario(string nombreUsuario, string contraseña, string rol, out string mensaje)
        {
            if (usuarios.Any(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase)))
            {
                mensaje = "El nombre de usuario ya existe.";
                return false;
            }
            try
            {
                var nuevoUsuario = new Usuario(nombreUsuario, contraseña, rol);
                usuarios.Add(nuevoUsuario);
                GuardarUsuariosEnArchivo();
                mensaje = "Usuario registrado exitosamente.";
                return true;
            }
            catch (ArgumentException ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}