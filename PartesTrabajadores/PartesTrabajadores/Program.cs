using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PartesTrabajadores
{
    class VariablesGlobales
    {
        public static int nIdTrabajadorActual = 0;
        public static string NombreTrabajador = "";
        public static int nIdCategoria = 0;
        public static int nIdEmpresaActual = 0;
        public static int nAnoActual = 2015;
        public static byte nMesActual = 5;
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
            //try
            //{
            Application.Run(new Entrada());
            if (VariablesGlobales.nIdEmpresaActual != 0 && VariablesGlobales.nIdTrabajadorActual != 0 && VariablesGlobales.nAnoActual != 0 && VariablesGlobales.nMesActual != 0)
            {
                Application.Run(new HorasMateriales());
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Errores sin Gestionar");

            //}
        }
    }
}
