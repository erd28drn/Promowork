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
    public partial class RptParametrosCobrosClientes : Form
    {
        public RptParametrosCobrosClientes()
        {
            InitializeComponent();
        }

        private void RptParametros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.DataTable1' table. You can move, or remove it, as needed.
           
            empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            marcaClientesTableAdapter.FillByCobrosMarca(promowork_dataDataSet.MarcaClientes, VariablesGlobales.nIdEmpresaActual);
            
            DataRowView Empresa = (DataRowView)empresasActualBindingSource.Current;
           
            int nMes= Convert.ToInt32(Empresa["MesEmpresa"]);
            int nAno= Convert.ToInt32(Empresa["AnoEmpresa"]);
            int nDiasFin = DateTime.DaysInMonth(nAno, nMes);
            DateTime FechaIni = new DateTime(nAno, nMes, 1);
            DateTime FechaFin = new DateTime(nAno, nMes, nDiasFin);

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
            try
            {
                DataTable tmpClientes = promowork_dataDataSet.MarcaClientes.Select("Marca= true").CopyToDataTable();

                RptResumenCobrosClientes frm = new RptResumenCobrosClientes();
                frm.LoadParametros(dateTimePicker1.Value, dateTimePicker2.Value, tmpClientes, Convert.ToBoolean(checkBox1.CheckState));
                frm.MdiParent = this.MdiParent;
                frm.Show();


               // resumenObrasTableAdapter.Fill(promowork_dataDataSet.ResumenObras, VariablesGlobales.nIdEmpresaActual, dateTimePicker1.Value, dateTimePicker2.Value, tmpObras, tmpTRabajadores);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Es Obligatorio Seleccionar al menos un Registro en cada panel.", this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

       
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                marcaClientesTableAdapter.FillByCobrosMarca(promowork_dataDataSet.MarcaClientes, VariablesGlobales.nIdEmpresaActual);
              // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaClientesTableAdapter.FillByCobrosDesmarca(promowork_dataDataSet.MarcaClientes, VariablesGlobales.nIdEmpresaActual);
              //  checkBox2.Text = "Marcar Todo";
            }
        }

    }
}
