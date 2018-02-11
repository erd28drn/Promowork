using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Promowork
{
    public partial class RptResumenObraCompleta : Form
    {
        public RptResumenObraCompleta()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DataTable Obras, bool IncCobros, DateTime FechaInicio, DateTime FechaFin, int colorRojo, int colorAzul, int colorNegro, bool MostrarFactPrevision)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenObraCompleta' table. You can move, or remove it, as needed.
            this.ResumenObraCompletaTableAdapter.Fill(this.Promowork_dataDataSet.ResumenObraCompleta, Obras, FechaInicio, FechaFin, colorRojo, colorAzul, colorNegro, MostrarFactPrevision);
            this.resumenObraCompletaTotalTableAdapter.Fill(this.Promowork_dataDataSet.ResumenObraCompletaTotal, Obras);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);

            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.EnableHyperlinks = true;

            ReportParameter[] Parametros = new ReportParameter[1];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("IncCobros", Convert.ToString(IncCobros));
          
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.LocalReport.EnableHyperlinks=true;
            this.reportViewer1.LocalReport.EnableExternalImages = true;


            this.reportViewer1.RefreshReport();
        }

        private void RptResumenObraCompleta_Load(object sender, EventArgs e)
        {

        }
    }
}
