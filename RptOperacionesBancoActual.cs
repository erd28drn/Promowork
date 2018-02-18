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
    public partial class RptOperacionesBancoActual : Form
    {
        public RptOperacionesBancoActual()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(int Cuenta, DateTime FechaIni, DateTime FechaFin, Boolean MostrarFechaFin)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.vOperacionesBancoImp' table. You can move, or remove it, as needed.
            this.vOperacionesBancoImpTableAdapter.FillByCuentaFecha(this.Promowork_dataDataSet.vOperacionesBancoImp,Cuenta, FechaIni,FechaFin);
            this.empresasActualTableAdapter.FillByEmpresa(Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            
            ReportParameter[] Parametros = new ReportParameter[3];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(FechaIni));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(FechaFin));
            Parametros[2] = new ReportParameter("MostrarFechaFin", Convert.ToString(MostrarFechaFin));

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);
            this.reportViewer1.RefreshReport();
        }
    }
}
