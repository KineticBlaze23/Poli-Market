using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Usar siempre la ruta en la carpeta bin/Debug o bin/Release
            string rutaArchivoUsuario = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistroUsuario.txt");
            Application.Run(new FormLogin(rutaArchivoUsuario)); // Cambiado para mostrar primero el login
        }
    }
}
