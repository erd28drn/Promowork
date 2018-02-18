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
    public partial class ResultadoCruce : Form
    {
        public ResultadoCruce()
        {
            InitializeComponent();
        }

        private void ResultadoCruce_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            btVer_Click(null, null);
           
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            this.EmpresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            resultadoCruceTrabajadoresTableAdapter.FillByEmpresa(promowork_dataDataSet.ResultadoCruceTrabajadores, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, VariablesGlobales.nIdEmpresaActual);

            if (rbPrimeraQuincena.Checked == true)
            {
                resultadoCruceTrabajadoresBindingSource.Filter = "DiaTrab<=15";
            }
            if (rbSegundaQuincena.Checked == true)
            {
                resultadoCruceTrabajadoresBindingSource.Filter = "DiaTrab>15";
            }

            this.reportViewer1.RefreshReport();
        }

    }
}
