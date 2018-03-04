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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using System.Net.Mail;
using System.Net;


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

        #region RECUENTO, SUMA Y PROMEDIO DE CELDAS
        public static resultadoCeldasSeleccionadas SumarCeldas(DevExpress.XtraGrid.Views.Grid.GridView gridView, GridCell[] celdasSeleccionadas)
        {
            
            resultadoCeldasSeleccionadas resultado= new resultadoCeldasSeleccionadas();
            
            double importeTotal = 0;

            for (int i = 0; i < celdasSeleccionadas.Count(); i++)
            {
                double importeCel = 0;
                double.TryParse(gridView.GetRowCellDisplayText(celdasSeleccionadas[i].RowHandle, celdasSeleccionadas[i].Column).Replace("€",""), out importeCel);
                importeTotal = importeTotal + importeCel;
            }

            resultado.Recuento = celdasSeleccionadas.Count();
            resultado.Suma =  importeTotal;
            resultado.Promedio = importeTotal / celdasSeleccionadas.Count();


            return resultado;

        }
        public class resultadoCeldasSeleccionadas
        {
            public int Recuento { get; set; }
            public double Suma { get; set; }
            public double Promedio { get; set; }

        }
        #endregion RECUENTO, SUMA Y PROMEDIO DE CELDAS

        #region EXPORTA REPORTES EN PDF Y XLS
        public static string ExportarReporte(ReportViewer reporte, string nombreReporte, string extension, string tipo)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;


                byte[] bytes = reporte.LocalReport.Render
                  (tipo, null, out mimeType, out encoding, out tipo, out 
              streamids, out warnings);

                FileStream fs = new FileStream(nombreReporte + extension, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite, 8);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();

                MemoryStream memoryStream = new MemoryStream(bytes);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Error al crear el fichero. "+ ex.Message;
            }
        }

        #endregion EXPORTA REPORTES EN PDF Y XLS

        #region VALIDAR EMAIL

        public static bool ValidarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion VALIDAR EMAIL

        #region ENVIAR REPORTES POR CORREO ELECTRONICO
        public static string EnviaCorreo(List<string> destinatarios, string asunto, List<string> adjuntos, string cuerpo)
        {
            string mensaje="";

            DatosReportesNuevos DatosReportesNuevos = new Promowork.DatosReportesNuevos();
           DatosReportesNuevosTableAdapters.ServidorSMTPTableAdapter ServidorSMTPTableAdapter= new DatosReportesNuevosTableAdapters.ServidorSMTPTableAdapter();
           ServidorSMTPTableAdapter.Fill(DatosReportesNuevos.ServidorSMTP, VariablesGlobales.nIdEmpresaActual);
           var servidorSMTP = ServidorSMTPTableAdapter.GetData(VariablesGlobales.nIdEmpresaActual).First();

            //servidorSMTP = contextoParametrizacion.tblServidorSMTP.First();

            SmtpClient smtp = new SmtpClient();
            smtp.Host = servidorSMTP.NombreServidorSMTP;
            smtp.Port = servidorSMTP.PuertoSMTP;
            smtp.EnableSsl = servidorSMTP.HabilitarSSL;
            smtp.UseDefaultCredentials = servidorSMTP.UsarCredencialesPorDefecto;
            smtp.Credentials = new NetworkCredential(servidorSMTP.Usuario, servidorSMTP.Clave);

            

            MailMessage msg = new MailMessage();
            msg.IsBodyHtml = true;
            msg.From = new MailAddress("compras@promowork.es");//servidorSMTP.Usuario);
            msg.Subject = asunto;
            msg.Body = cuerpo;

            foreach (string destinatario in destinatarios)
            {
                msg.To.Add(new MailAddress(destinatario));
            }

            foreach (string adjunto in adjuntos)
            {
                Attachment attachment = new Attachment(adjunto);
                msg.Attachments.Add(attachment);
            }

            try
            {
                smtp.Send(msg);
                msg.Dispose();
                mensaje = "OK";
            }
            catch (Exception ex)
            {
                mensaje = "Error al enviar correo electrónico: " + ex.Message;
            }

            return mensaje;
        }
        #endregion ENVIAR REPORTES POR CORREO ELECTRONICO


        
    }
}
