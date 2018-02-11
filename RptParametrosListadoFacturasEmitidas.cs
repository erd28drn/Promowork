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
    public partial class RptParametrosListadoFacturasEmitidas : Form
    {
        public RptParametrosListadoFacturasEmitidas()
        {
            InitializeComponent();
        }

        private void RptParametros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.DataTable1' table. You can move, or remove it, as needed.
           
            empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            marcaClientesTableAdapter.FillByMarca(promowork_dataDataSet.MarcaClientes, VariablesGlobales.nIdEmpresaActual);


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
            try
            {
                DataTable tmpClientes = promowork_dataDataSet.MarcaClientes.Select("Marca= true").CopyToDataTable();

                RptListadoFacturaEmitidas frm = new RptListadoFacturaEmitidas();
                frm.LoadParametros(dateTimePicker1.Value, dateTimePicker2.Value, tmpClientes, checkBox3.Checked, chkFacturas.Checked, chkPartes.Checked, chkCliFactura.Checked);
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
                marcaClientesTableAdapter.FillByMarca(promowork_dataDataSet.MarcaClientes, VariablesGlobales.nIdEmpresaActual);
              // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaClientesTableAdapter.FillByDesmarca(promowork_dataDataSet.MarcaClientes, VariablesGlobales.nIdEmpresaActual);
              //  checkBox2.Text = "Marcar Todo";
            }
        }

    }
}
