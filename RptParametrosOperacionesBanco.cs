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
    public partial class RptParametrosOperacionesBanco : Form
    {
        public RptParametrosOperacionesBanco()
        {
            InitializeComponent();
        }

        private void RptParametrosOperacionesBanco_Load(object sender, EventArgs e)
        {
            this.marcaTipoOpeBancoTableAdapter.FillByMarca(promowork_dataDataSet.MarcaTipoOpeBanco, VariablesGlobales.nIdEmpresaActual);
            this.marcaConceptosBancoTableAdapter.FillByMarca(promowork_dataDataSet.MarcaConceptosBanco, VariablesGlobales.nIdEmpresaActual);
            this.marcaCuentasTableAdapter.FillByEmpresa(promowork_dataDataSet.MarcaCuentas, VariablesGlobales.nIdEmpresaActual);
           
            int nDiasFin = DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
            DateTime FechaIni = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, 1);
            DateTime FechaFin = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, nDiasFin);

            dateTimePicker1.Value = FechaIni;
            dateTimePicker2.Value = FechaFin;
            dateTimePicker2.MinDate = FechaIni;
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "Marca1")
            {
                if (marcaConceptosBancoBindingSource.Filter == null || marcaConceptosBancoBindingSource.Filter ==string.Empty )
                {
                    
                    marcaConceptosBancoBindingSource.Filter = (Boolean)e.Value == false ? "TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'" : "";
                }
                else
                {
                    marcaConceptosBancoBindingSource.Filter = marcaConceptosBancoBindingSource.Filter.Replace(" and TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'", "");
                    marcaConceptosBancoBindingSource.Filter = marcaConceptosBancoBindingSource.Filter.Replace("TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe")+ "' and ", "");
                    marcaConceptosBancoBindingSource.Filter = marcaConceptosBancoBindingSource.Filter.Replace("TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'", "");

                    marcaConceptosBancoBindingSource.Filter += (Boolean)e.Value == false ? " and TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'":"";
                }
              //  MessageBox.Show(marcaConceptosBancoBindingSource.Filter);
            }
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
                string filtro=string.Empty;
                if (marcaConceptosBancoBindingSource.Filter != string.Empty && marcaConceptosBancoBindingSource.Filter != null)
                {
                    filtro = "and " + marcaConceptosBancoBindingSource.Filter;
                }
                DataTable tmpConceptos = promowork_dataDataSet.MarcaConceptosBanco.Select("Marca= true " + filtro).CopyToDataTable();
                DataTable tmpCuentas = promowork_dataDataSet.MarcaCuentas.Select("Marca= true").CopyToDataTable();

                RptOperacionesBancoConceptos frm = new RptOperacionesBancoConceptos();
                frm.LoadFiltro(tmpConceptos, tmpCuentas, dateTimePicker1.Value, dateTimePicker2.Value, true);
                frm.MdiParent = this.MdiParent;
                frm.Show();


                // resumenObrasTableAdapter.Fill(promowork_dataDataSet.ResumenObras, VariablesGlobales.nIdEmpresaActual, dateTimePicker1.Value, dateTimePicker2.Value, tmpObras, tmpTRabajadores);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Es Obligatorio Seleccionar al menos un Registro en cada panel.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
       
       
        }

        private void RptParametrosOperacionesBanco_Resize(object sender, EventArgs e)
        {
            marcaCuentasGridControl.Height = ((this.Height - marcaCuentasGridControl.Top) / 2)-40;
            marcaTipoOpeBancoGridControl.Top = marcaCuentasGridControl.Top + marcaCuentasGridControl.Height+10;
            marcaTipoOpeBancoGridControl.Height = this.Height - marcaTipoOpeBancoGridControl.Top - 40;
            marcaConceptosBancoGridControl.Height = this.Height - marcaConceptosBancoGridControl.Top -40;
            checkBox3.Top = marcaTipoOpeBancoGridControl.Top + 4;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                gridView3.SetRowCellValue(i, "Marca", checkBox1.CheckState);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, "Marca", checkBox2.CheckState);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, "Marca", checkBox3.CheckState);
            }
        }

      
    }
}
