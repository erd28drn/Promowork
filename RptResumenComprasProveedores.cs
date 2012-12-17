using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Promowork
{
    public partial class RptResumenComprasProveedores : Form
    {
        public RptResumenComprasProveedores()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable tmpCuentas, DataTable tmpProveedores, DataTable tmpObras, int TipoFecha, int SelFact, string NomTipoFecha, string NomSelFact)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            try
           {
                this.ResumenComprasBancoTableAdapter.Fill(this.Promowork_dataDataSet.ResumenComprasBanco, VariablesGlobales.nIdEmpresaActual, fechaini, fechafin, tmpCuentas, tmpProveedores, tmpObras, TipoFecha, SelFact);
            }
            catch (SqlException ex)
            {
                ErroresSQLServer.ManipulaErrorSQL(ex, this.Text);
            }


            ReportParameter[] Parametros = new ReportParameter[4];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
            Parametros[2] = new ReportParameter("NomTipoFecha", Convert.ToString(NomTipoFecha));
            Parametros[3] = new ReportParameter("NomSelFact", Convert.ToString(NomSelFact));

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();
        }

        
    }
}
