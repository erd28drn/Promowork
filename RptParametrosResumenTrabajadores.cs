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
    public partial class RptParametrosResumenTrabajadoress : Form
    {
        public RptParametrosResumenTrabajadoress()
        {
            InitializeComponent();
        }

        private void RptParametros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.DataTable1' table. You can move, or remove it, as needed.
            marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
            marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual);
            empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

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
                DataTable tmpObras = promowork_dataDataSet.MarcaObras.Select("Marca= true").CopyToDataTable();
                DataTable tmpTRabajadores = promowork_dataDataSet.MarcaTrabajadores.Select("Marca= true").CopyToDataTable();

                RptResumenTrabajadores frm = new RptResumenTrabajadores();
                frm.LoadParametros(dateTimePicker1.Value, dateTimePicker2.Value, tmpObras, tmpTRabajadores);
                frm.MdiParent = this.MdiParent;
                frm.Show();


               // resumenObrasTableAdapter.Fill(promowork_dataDataSet.ResumenObras, VariablesGlobales.nIdEmpresaActual, dateTimePicker1.Value, dateTimePicker2.Value, tmpObras, tmpTRabajadores);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Es Obligatorio Seleccionar al menos un Registro en cada panel.", this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
               // checkBox1.Text = "Desmarcar Todo";
            }
            else
            {
                marcaObrasTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
              //  checkBox1.Text = "Marcar Todo";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual);
               // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaTrabajadoresTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual);
               // checkBox2.Text = "Marcar Todo";
            }
        }

      
    }
}
