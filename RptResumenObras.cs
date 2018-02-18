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
    public partial class RptResumenObras : Form
    {
        public RptResumenObras()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable  tmpObras, DataTable tmpTRabajadores, Boolean SSIRPF, Boolean Compras, Boolean Detalle)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
           
            ResumenObrasTableAdapter.Fill(Promowork_dataDataSet.ResumenObras, VariablesGlobales.nIdEmpresaActual, fechaini, fechafin, tmpObras, tmpTRabajadores,SSIRPF,Compras);

            ReportParameter[] Parametros = new ReportParameter[5];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
            Parametros[2] = new ReportParameter("Compras", Convert.ToString(Compras));
            Parametros[3] = new ReportParameter("SSIRPF", Convert.ToString(SSIRPF));
            Parametros[4] = new ReportParameter("Detalle", Convert.ToString(Detalle));

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();
        }
    }
}
