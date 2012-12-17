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
    public partial class RptResumenPagos : Form
    {
        public RptResumenPagos()
        {
            InitializeComponent();
        }

        private void RptResumenPagos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenPagos' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);
            
            DataRowView EmpresaActual = (DataRowView)EmpresasActualBindingSource.Current;
            byte MesEmpresa = Convert.ToByte(EmpresaActual["MesEmpresa"]);
            int AnoEmpresa = Convert.ToInt32(EmpresaActual["AnoEmpresa"]);
            
            this.ResumenPagosTableAdapter.Fill(this.Promowork_dataDataSet.ResumenPagos,VariablesGlobales.nIdEmpresaActual,MesEmpresa,AnoEmpresa);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }
    }
}
