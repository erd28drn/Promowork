using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Drawing;
using WIA;
using System.IO;
using System.Windows.Media.Imaging;
using AcroPDFLib;
using AxAcroPDFLib;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using DevExpress.XtraGrid.Views.Base;


namespace Promowork
{
    public static class Utilidades
    {
        public static Boolean Escanear(string texto)
        {

            return true;
        }

        //public static Boolean ConvertirPDF()
        //{
        //    string pdfpath = "C:\\Salva Documentos\\Promowork";
        //    string imagepath = "C:\\Salva Documentos\\Promowork";
        //    Document doc = new Document();
        //    try
        //    {
                
        //        PdfWriter.GetInstance(doc, new FileStream(pdfpath + "\\Images.pdf", FileMode.Create));
        //        doc.Open();

        //        doc.Add(new Paragraph("GIF"));
        //        Image gif = Image.GetInstance(imagepath + "\\Prueba.gif");
        //        doc.Add(gif);
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log error;
        //    }
        //    finally
        //    {
        //        doc.Close();
        //    }

        //    return true;
        //}
        public static resultadoCeldasSeleccionadas SumarCeldas(DevExpress.XtraGrid.Views.Grid.GridView gridView, GridCell[] celdasSeleccionadas)
        {
            
            resultadoCeldasSeleccionadas resultado= new resultadoCeldasSeleccionadas();
            
            double importeTotal = 0;

            for (int i = 0; i < celdasSeleccionadas.Count(); i++)
            {
                double importeCel = 0;
                double.TryParse(gridView.GetRowCellDisplayText(celdasSeleccionadas[i].RowHandle, celdasSeleccionadas[i].Column), out importeCel);
                importeTotal = importeTotal + importeCel;
            }

            resultado.Cantidad = celdasSeleccionadas.Count().ToString();
            resultado.Importe = importeTotal.ToString("C2");

            return resultado;

        }
        public class resultadoCeldasSeleccionadas
        {
            public string Cantidad { get; set; }
            public string Importe { get; set; }
        }


        
    }
}
