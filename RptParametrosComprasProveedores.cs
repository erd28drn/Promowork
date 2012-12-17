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
    public partial class RptParametrosComprasProveedores : Form
    {
        public RptParametrosComprasProveedores()
        {
            InitializeComponent();
        }

        private void RptParametros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.DataTable1' table. You can move, or remove it, as needed.
            marcaObrasTableAdapter.FillByMarcaCompras(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
            marcaCuentasTableAdapter.FillByMarcaFactura(promowork_dataDataSet.MarcaCuentas, VariablesGlobales.nIdEmpresaActual);
            marcaProveedoresTableAdapter.FillByMarca(promowork_dataDataSet.MarcaProveedores, VariablesGlobales.nIdEmpresaActual);
            empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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
                DataTable tmpCuentas = promowork_dataDataSet.MarcaCuentas.Select("Marca= true").CopyToDataTable();
                DataTable tmpProveedores = promowork_dataDataSet.MarcaProveedores.Select("Marca= true and DesProveedor like '%" + textBox1.Text + "%'").CopyToDataTable();
                DataTable tmpObras = promowork_dataDataSet.MarcaObras.Select("Marca= true and DesObra like '%" + textBox2.Text + "%'").CopyToDataTable();



                DataRow ObraCero = tmpObras.NewRow(); 

                ObraCero["IdObra"] = 0;
                ObraCero["Marca"] = true;
                tmpObras.Rows.Add(ObraCero);

                RptResumenComprasProveedores frm = new RptResumenComprasProveedores();
                frm.LoadParametros(dateTimePicker1.Value, dateTimePicker2.Value, tmpCuentas, tmpProveedores,tmpObras, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox1.Text, comboBox2.Text);
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
                marcaCuentasTableAdapter.FillByMarcaFactura(promowork_dataDataSet.MarcaCuentas, VariablesGlobales.nIdEmpresaActual);
               // checkBox1.Text = "Desmarcar Todo";
            }
            else
            {
                marcaCuentasTableAdapter.FillByDesmarcaFactura(promowork_dataDataSet.MarcaCuentas, VariablesGlobales.nIdEmpresaActual); 
                //checkBox1.Text = "Marcar Todo";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                
                marcaProveedoresTableAdapter.FillByMarca(promowork_dataDataSet.MarcaProveedores, VariablesGlobales.nIdEmpresaActual);
                //checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaProveedoresTableAdapter.FillByDesmarca(promowork_dataDataSet.MarcaProveedores, VariablesGlobales.nIdEmpresaActual);
               // checkBox2.Text = "Marcar Todo";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.CheckState == CheckState.Checked)
            {
                marcaObrasTableAdapter.FillByMarcaCompras(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
               // checkBox5.Text = "Desmarcar Todo";
            }
            else
            {
                marcaObrasTableAdapter.FillByDesmarcaCompras(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
              //  checkBox5.Text = "Marcar Todo";
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                marcaProveedoresTableAdapter.FillByMarca(promowork_dataDataSet.MarcaProveedores, VariablesGlobales.nIdEmpresaActual);
              // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaProveedoresTableAdapter.FillByDesmarca(promowork_dataDataSet.MarcaProveedores, VariablesGlobales.nIdEmpresaActual);
              //  checkBox2.Text = "Marcar Todo";
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            marcaProveedoresBindingSource.Filter = "DesProveedor like '%" + textBox1.Text + "%'";
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            marcaObrasBindingSource.Filter = "DesObra like '%" + textBox2.Text + "%'";
        }

     
    }
}
