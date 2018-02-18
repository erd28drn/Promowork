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
    public partial class RptSalarioObras : Form
    {
        public RptSalarioObras()
        {
            InitializeComponent();
        }

        private void RptResumenHorasObras_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);
            byte nMes = Convert.ToByte(VariablesGlobales.nMesActual);
            int nAno = Convert.ToInt32(VariablesGlobales.nAnoActual);
            this.ResumenHorasObrasTableAdapter.FillByMes(this.Promowork_dataDataSet.ResumenHorasObras, nMes, nAno, VariablesGlobales.nIdEmpresaActual);
           
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
           

            this.reportViewer1.RefreshReport();
        }
    }
}
