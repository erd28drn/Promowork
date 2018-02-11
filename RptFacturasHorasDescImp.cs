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
    public partial class RptFacturasHorasDescImp : Form
    {
        public RptFacturasHorasDescImp()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(int nIdFactCab)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.PresupuestoActual' table. You can move, or remove it, as needed.
            this.FacturasDetHorasImpTableAdapter.FillbyFactura(this.Promowork_dataDataSet.FacturasDetHorasImp, nIdFactCab);
            this.FacturasCabImpTableAdapter.FillByFactura(this.Promowork_dataDataSet.FacturasCabImp, nIdFactCab);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.empresasPoblacion.FillByEmpresa(this.Promowork_dataDataSet.EmpresasPoblacion, VariablesGlobales.nIdEmpresaActual);
            DataRowView factura = (DataRowView)FacturasCabImpBindingSource.Current;
            DateTime Fecha = (DateTime)factura["FechaFactura"];
            string nombre = factura["NumFactura"].ToString() + "-" + Fecha.Year.ToString() + " " + factura["DesCliente"].ToString();
            this.Text = nombre;
            this.reportViewer1.LocalReport.DisplayName = nombre;
            this.reportViewer1.LocalReport.EnableExternalImages=true;
            this.reportViewer1.LocalReport.EnableHyperlinks = true;
           // this.reportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            this.reportViewer1.RefreshReport();
        }

              
    }
}
