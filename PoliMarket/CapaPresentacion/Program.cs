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

            // Ruta al archivo de usuarios
            string rutaArchivoUsuario = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistroUsuario.txt");
            
            // Mostrar el formulario de login como diálogo
            using (FormLogin loginForm = new FormLogin(rutaArchivoUsuario))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, iniciar el formulario principal
                    Application.Run(new FormOpciones());
                }
                // Si fue cancelado o incorrecto, la aplicación termina aquí automáticamente
            }
        }
    }
}
