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
    public partial class RptPresupuestoActualFcatCob : Form
    {
        public RptPresupuestoActualFcatCob()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(int nIdPresupuesto, bool SoloCertificaciones)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.PresupuestoActual' table. You can move, or remove it, as needed.
            this.PresupuestoActualFactCobTableAdapter.Fill(this.Promowork_dataDataSet.PresupuestoActualFactCob, nIdPresupuesto);
            if (SoloCertificaciones == true)
            {
                PresupuestoActualFactCobBindingSource.Filter = "IdFactCab=0 or EsCertificacion=1";
            }
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            this.reportViewer1.RefreshReport();
        }

       

       
    }
}
