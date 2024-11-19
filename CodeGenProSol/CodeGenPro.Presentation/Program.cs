using CodeGenPro.Presentation.Forms;
using System;
using System.Windows.Forms;

namespace CodeGenPro.Presentation
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

            // Mostrar el Splash Screen
            using (SplashScreen splash = new SplashScreen())
            {
                splash.ShowDialog(); // Mostrar el SplashScreen como modal
            }

            // Iniciar el formulario principal después del SplashScreen
            Application.Run(new Form_Barras());
        }
    }
}
