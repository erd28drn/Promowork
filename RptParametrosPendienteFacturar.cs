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
    public partial class RptParametrosPendienteFacturar : Form
    {
        public RptParametrosPendienteFacturar()
        {
            InitializeComponent();
        }

        int nMes;
        int nAno;
        int nDiasFin;
        DateTime FechaIni;
        DateTime FechaFin;

        private void RptParametros_Load(object sender, EventArgs e)
        {

            nMes = VariablesGlobales.nMesActual;
            nAno = VariablesGlobales.nAnoActual;
            nDiasFin = DateTime.DaysInMonth(nAno, nMes);
            FechaIni = new DateTime(nAno, nMes, 1);
            FechaFin = new DateTime(nAno, nMes, nDiasFin);

            dateTimePicker1.Value = FechaIni;
            dateTimePicker2.Value = FechaFin;
            dateTimePicker2.MinDate = FechaIni;


            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'promowork_dataDataSet.DataTable1' table. You can move, or remove it, as needed.
            marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
            marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
            //empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }

            FechaIni = dateTimePicker1.Value;

            if (checkBox2.CheckState == CheckState.Checked)
            {
                marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
                // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaTrabajadoresTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
                //  checkBox2.Text = "Marcar Todo";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable tmpObras = new DataTable();
                DataTable tmpTrabajadores = new DataTable();

                for (int i = 0; i < gridView1.Columns.Count; i++)
                {
                    tmpObras.Columns.Add(gridView1.Columns[i].FieldName);
                }

                for (int i = 0; i < gridView2.Columns.Count; i++)
                {
                    tmpTrabajadores.Columns.Add(gridView2.Columns[i].FieldName);
                }

               
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        if ((bool)gridView1.GetRowCellValue(i, "Marca") == true)
                        {
                            tmpObras.ImportRow(gridView1.GetDataRow(i));
                        }
                    }

                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        if ((bool)gridView2.GetRowCellValue(i, "Marca") == true)
                        {
                            tmpTrabajadores.ImportRow(gridView2.GetDataRow(i));
                        }
                    }



                    if (chkResumen.CheckState == CheckState.Checked)
                    {
                        RptPendienteFacturarConResumen frm = new RptPendienteFacturarConResumen();
                        frm.LoadParametros(dateTimePicker1.Value, dateTimePicker2.Value, tmpObras, tmpTrabajadores, rdgFacturado.SelectedIndex, chkAgruparDescripcion.Checked);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        RptPendienteFacturar frm = new RptPendienteFacturar();
                        frm.LoadParametros(dateTimePicker1.Value, dateTimePicker2.Value, tmpObras, tmpTrabajadores, rdgFacturado.SelectedIndex);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }


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
                //checkBox1.Text = "Desmarcar Todo";
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
                marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
                // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaTrabajadoresTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
                //  checkBox2.Text = "Marcar Todo";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FechaFin = dateTimePicker2.Value;

            if (checkBox2.CheckState == CheckState.Checked)
            {
                marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
                // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaTrabajadoresTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
                //  checkBox2.Text = "Marcar Todo";
            }
        }

      
    }
}
