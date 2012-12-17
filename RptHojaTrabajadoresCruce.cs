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
    public partial class RptHojaTrabajadoresCruce : Form
    {
        public RptHojaTrabajadoresCruce()
        {
            InitializeComponent();
        }

        private void RptHojaTrabajadores_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenPagos' table. You can move, or remove it, as needed.
           this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            DataRowView EmpresaActual = (DataRowView)EmpresasActualBindingSource.Current;
            byte MesEmpresa = Convert.ToByte(EmpresaActual["MesEmpresa"]);
            int AnoEmpresa = Convert.ToInt32(EmpresaActual["AnoEmpresa"]);
            HojaTrabajadoresCruceTableAdapter.Fill(Promowork_dataDataSet.HojaTrabajadoresCruce,AnoEmpresa, MesEmpresa,VariablesGlobales.nIdEmpresaActual);

            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
