using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoSeguridad
{
    static class Globales
    {
        public static string nom_usuario;
        public static string sAccionG = "Guardar";
        public static string sAccionD = "Eliminar";
        public static string sAccionE = "Editar";
        public static String sExitoso = "Exitoso";
        public static String sExitoso_n = "No exitoso";
        public static String sError = "no";


    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
