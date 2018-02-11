using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Promowork
{
    class VariablesGlobales
    {
       public static int nIdUsuarioActual = 0;
       public static bool bEsAdmin = false;
       public static int nIdEmpresaActual = 0;
       public static int nAnoActual = 0;
       public static byte nMesActual = 0;
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
           
            Thread.CurrentThread.CurrentUICulture = new  CultureInfo("es-ES");
            
            //try
            //{
                Application.Run(new EntradaSistema ());
                if (VariablesGlobales.nIdEmpresaActual != 0 && VariablesGlobales.nIdUsuarioActual != 0 && VariablesGlobales.nAnoActual != 0 && VariablesGlobales.nMesActual != 0)
                {
                    Application.Run(new HorasMateriales ());
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Errores sin Gestionar");

            //}
        }
    }
}
