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
    public partial class RptOperacionesBancoConceptos : Form
    {
        public RptOperacionesBancoConceptos()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(DataTable MarcaConceptos, DataTable MarcaCuentas, DateTime FechaIni, DateTime FechaFin, Boolean MostrarFechaFin)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.vOperacionesBancoImp' table. You can move, or remove it, as needed.
            this.OperacionesBancoConceptosTableAdapter.Fill(this.Promowork_dataDataSet.OperacionesBancoConceptos,MarcaConceptos, MarcaCuentas, FechaIni,FechaFin);
            this.empresasActualTableAdapter.FillByEmpresa(Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            
            ReportParameter[] Parametros = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(FechaIni));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(FechaFin));

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);
            this.reportViewer1.RefreshReport();
        }

      
      
    }
}
