using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Promowork
{
    public partial class RptResumenConsumoCombustible : Form
    {
        public RptResumenConsumoCombustible()
        {
            InitializeComponent();
        }

       
        internal void LoadParametros(DateTime fechaini, DateTime fechafin)
        {
            // TODO: This line of code loads data into the 'Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos' table. You can move, or remove it, as needed.
            this.ConsumosCombustibleVehiculosTableAdapter.FillByCombustible(this.Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos, VariablesGlobales.nIdEmpresaActual,fechaini,fechafin);
            // TODO: This line of code loads data into the 'Promowork_dataDataSetCombustible.Empresas' table. You can move, or remove it, as needed.
            this.EmpresasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Empresas, VariablesGlobales.nIdEmpresaActual);

            ReportParameter[] Parametros = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
           
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);
            //ReportViewer1.LocalReport.ListRenderingExtensions();
            //MessageBox.Show(reportViewer1.LocalReport.ListRenderingExtensions().GetValue(2).ToString());
            this.reportViewer1.RefreshReport();

            this.reportViewer1.LocalReport.SetParameters(Parametros);
            this.reportViewer1.RefreshReport();
        }

        private void RptResumenConsumoCombustible_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos' Puede moverla o quitarla según sea necesario.
            //this.ConsumosCombustibleVehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos);
            //// TODO: esta línea de código carga datos en la tabla 'Promowork_dataDataSetCombustible.Empresas' Puede moverla o quitarla según sea necesario.
            //this.EmpresasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Empresas);
            ////// TODO: esta línea de código carga datos en la tabla 'Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos' Puede moverla o quitarla según sea necesario.
            //this.ConsumosCombustibleVehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos);
            //// TODO: esta línea de código carga datos en la tabla 'Promowork_dataDataSetCombustible.Empresas' Puede moverla o quitarla según sea necesario.
            //this.EmpresasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Empresas);
            //// TODO: esta línea de código carga datos en la tabla 'Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos' Puede moverla o quitarla según sea necesario.
            //this.ConsumosCombustibleVehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos);
            //// TODO: esta línea de código carga datos en la tabla 'Promowork_dataDataSetCombustible.Empresas' Puede moverla o quitarla según sea necesario.
            //this.EmpresasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Empresas);

           
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Warning[] warnings;
        //    string[] streamids;
        //    string mimeType;
        //    string encoding;
        //    string extension;

        //    byte[] bytes = reportViewer1.LocalReport.Render(
        //       "Excel", null, out mimeType, out encoding,
        //        out extension,
        //       out streamids, out warnings);

        //    FileStream fs = new FileStream(@"C:\Users\USUARIO2\Documents\output.xls",
        //       FileMode.Create);
        //    fs.Write(bytes, 0, bytes.Length);
        //    fs.Close();
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    Warning[] warnings;
        //    string[] streamids;
        //    string mimeType;
        //    string encoding;
        //    string extension;

        //    byte[] bytes = reportViewer1.LocalReport.Render(
        //       "Pdf", null, out mimeType, out encoding,
        //        out extension,
        //       out streamids, out warnings);

        //    FileStream fs = new FileStream(@"C:\Users\USUARIO2\Documents\output.pdf",
        //       FileMode.Create);
        //    fs.Write(bytes, 0, bytes.Length);
        //    fs.Close();
        //}

     
        
    }
}
