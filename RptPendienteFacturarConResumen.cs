using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace Promowork
{
    public partial class RptPendienteFacturarConResumen : Form
    {
        public RptPendienteFacturarConResumen()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable  tmpObras, DataTable tmpTRabajadores, int Facturado, bool Agrupardescripcion )
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            this.HorasPendientesFacturarTableAdapter.Fill(this.Promowork_dataDataSet.HorasPendientesFacturar, tmpObras, tmpTRabajadores, fechaini, fechafin, Facturado);

            if (Agrupardescripcion)
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.PendienteFacturarConResumen2.rdlc";
            }

            ReportParameter[] Parametros = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
           
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();
        }

      
       
    }
}
