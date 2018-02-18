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
    public partial class RptResumenFacturasClientes : Form
    {
        public RptResumenFacturasClientes()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable tmpClientes, Boolean Agrupado, Boolean Prevision, Boolean Factura, Boolean CliFactura)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            try
           {
               this.ResumenFacturasClientesTableAdapter.FillbyCliente(this.Promowork_dataDataSet.ResumenFacturasClientes, tmpClientes, fechaini, fechafin, CliFactura);
               if (Prevision == false)
               {
                   this.ResumenFacturasClientesBindingSource.Filter = "Prevision=0 and esPrevision=0";
               }

               if (Factura == true)
               {
                   if (this.ResumenFacturasClientesBindingSource.Filter == "" || this.ResumenFacturasClientesBindingSource.Filter==null)
                   {
                       this.ResumenFacturasClientesBindingSource.Filter = "Factura=1";
                   }
                   else
                   {
                       this.ResumenFacturasClientesBindingSource.Filter = this.ResumenFacturasClientesBindingSource.Filter + " and Factura=1";
                   }
               }
            }
            catch (SqlException ex)
            {
                ErroresSQLServer.ManipulaErrorSQL(ex, this.Text);
            }


            ReportParameter[] Parametros = new ReportParameter[3];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
            Parametros[2] = new ReportParameter("Agrupado", Convert.ToString(Agrupado));
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();
        }

    }
}
