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
    public partial class RptListadoFacturaEmitidas : Form
    {
        public RptListadoFacturaEmitidas()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable tmpClientes, Boolean Prevision, Boolean Facturas, Boolean Partes, Boolean CliFactura)
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

               string filtro="";

               switch (Facturas)
               {
                   case true:
                       switch (Partes)
                       {
                           case true:

                               filtro = "";
                               break;

                           case false:
                               filtro = "and Factura=1";
                               break;
                       }

                       break;
                   case false:

                       switch (Partes)
                       {
                           case true:

                               filtro = " and Factura=0";
                               break;

                           case false:
                               filtro = "and 1=2";
                               break;
                       }

                       break;

               }
                
                
                   if (this.ResumenFacturasClientesBindingSource.Filter == "" || this.ResumenFacturasClientesBindingSource.Filter==null)
                   {
                       this.ResumenFacturasClientesBindingSource.Filter = filtro;
                   }
                   else
                   {
                       this.ResumenFacturasClientesBindingSource.Filter = this.ResumenFacturasClientesBindingSource.Filter + filtro;
                   }
               
            }
            catch (SqlException ex)
            {
                ErroresSQLServer.ManipulaErrorSQL(ex, this.Text);
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
