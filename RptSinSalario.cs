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
    public partial class RptSinSalario : Form
    {
        public RptSinSalario()
        {
            InitializeComponent();
        }

        private void SinSalario_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.EmpresasActualTableAdapter.FillByEmpresa(Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            byte nMes = Convert.ToByte(VariablesGlobales.nMesActual);
            int nAno = Convert.ToInt32(VariablesGlobales.nAnoActual);

            this.sinSalarioTableAdapter.Fill(this.Promowork_dataDataSet.SinSalario, VariablesGlobales.nIdEmpresaActual, nMes, nAno);
            this.reportViewer1.RefreshReport();
        }
    }
}
