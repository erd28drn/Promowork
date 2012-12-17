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
            this.EmpresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);
          /*  resultadoCruceTrabajadoresDataGridView.Left = 5;
            resultadoCruceTrabajadoresDataGridView.Width = Convert.ToInt32((this.Width - 25)/1.8);
            dataGridView1.Left = resultadoCruceTrabajadoresDataGridView.Width;
            dataGridView1.Width = (this.Width -resultadoCruceTrabajadoresDataGridView.Width- 25);
            label2.Left = dataGridView1.Left + 12;*/
            
            resultadoCruceTrabajadoresTableAdapter.FillByEmpresa(promowork_dataDataSet.ResultadoCruceTrabajadores, VariablesGlobales.nIdEmpresaActual);
            this.reportViewer1.RefreshReport();
        }

    }
}
