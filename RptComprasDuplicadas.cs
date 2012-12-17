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
    public partial class RptComprasDuplicadas : Form
    {
        public RptComprasDuplicadas()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime Fechaini)
        {
            this.WindowState = FormWindowState.Maximized;
            // ordersTableAdapter.FillByCustomerID(northwindDataSet.Orders, CustomerID);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
           this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenCompras' table. You can move, or remove it, as needed.
           this.ComprasDuplicadasTableAdapter.Fill(this.Promowork_dataDataSet.ComprasDuplicadas, VariablesGlobales.nIdEmpresaActual, Fechaini);

           ReportParameter[] Parametros = new ReportParameter[1];
           //Establecemos el valor de los parámetros
           Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(Fechaini));
         
           this.reportViewer1.LocalReport.SetParameters(Parametros);
            
            
            this.reportViewer1.RefreshReport();
        }
    }
}
