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

        internal void LoadParametros(DataTable Obras, bool IncCobros, int colorRojo, int colorAzul, int colorNegro)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenObraCompleta' table. You can move, or remove it, as needed.
            this.ResumenObraCompletaTableAdapter.Fill(this.Promowork_dataDataSet.ResumenObraCompleta, Obras, colorRojo, colorAzul, colorNegro);
            this.resumenObraCompletaTotalTableAdapter.Fill(this.Promowork_dataDataSet.ResumenObraCompletaTotal, Obras);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);

            ReportParameter[] Parametros = new ReportParameter[1];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("IncCobros", Convert.ToString(IncCobros));
          
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();
        }
    }
}
