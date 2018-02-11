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
    public partial class RptParametrosOperacionesBancoFecha : Form
    {
        public RptParametrosOperacionesBancoFecha()
        {
            InitializeComponent();
        }

        private void RptParametrosOperacionesBanco_Load(object sender, EventArgs e)
        {
            cuentasBancosTableAdapter.FillByCtaEmpresa(promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            
            int nDiasFin = DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
            DateTime FechaIni = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, 1);
            DateTime FechaFin = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, nDiasFin);

            dateTimePicker1.Value = FechaIni;
            dateTimePicker2.Value = FechaFin;
            dateTimePicker2.MinDate = FechaIni;
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RptOperacionesBancoActual frm = new RptOperacionesBancoActual();
            frm.LoadFiltro((int)comboBox1.SelectedValue, dateTimePicker1.Value, dateTimePicker2.Value, true);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

       
      
    }
}
