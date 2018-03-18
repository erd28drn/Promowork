using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Promowork
{
    public static class ErroresSQLServer
    {
        public static Boolean ManipulaErrorSQL(SqlException ex, string texto)
        {
            
           SqlError err = ex.Errors[0];
            string mensaje = string.Empty;
            Boolean fill = false;
            switch (err.Number)
            {
                case 547:
                    mensaje = "No se pudo Eliminar o Insertar el Registro. Integridad de Datos. "+ err.Message ;
                    fill = true;
                    break;
                case 2601:
                    mensaje = "No se pudo Crear o Modificar el Registro. Valor Duplicado. "+ err.Message ; break;
                case 515:
                    mensaje = "No se pudieron Salvar los Cambios al Registro Actual. Campos Obligatorios Vacios. "+ err.Message ; break;
                default:
                    mensaje = Convert.ToString(err.Number) + ". " + err.Message; break;
            }
            MessageBox.Show(mensaje, texto, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return fill;
                   
        }

        
    }
}
