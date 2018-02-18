using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public partial class RptPresupuestoActual : Form
    {
        public RptPresupuestoActual()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(int nIdPresupuesto)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.PresupuestoActual' table. You can move, or remove it, as needed.
            this.PresupuestoActualTableAdapter.Fill(this.Promowork_dataDataSet.PresupuestoActual, nIdPresupuesto);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasPoblacion.FillByEmpresa(this.Promowork_dataDataSet.EmpresasPoblacion, VariablesGlobales.nIdEmpresaActual);

            DataRowView presupuesto = (DataRowView)PresupuestoActualBindingSource.Current;
            string nombre = ((DateTime)presupuesto["FechaPresup"]).ToString("yyyyMMdd") + " - PRESUPUESTO - " + presupuesto["DesPresup"].ToString();
            this.Text = nombre;
            this.reportViewer1.LocalReport.DisplayName = nombre;
            this.reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.RefreshReport();
        }

       
    }
}
