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
    public partial class RptParametrosObraCompletaAdmin : Form
    {
        public RptParametrosObraCompletaAdmin()
        {
            InitializeComponent();
        }

        private void RptParametrosObraCompleta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.SalariosVentaAdmin' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            comboBox1.SelectedIndex = 0;
            this.salariosVentaAdminTableAdapter.Fill(promowork_dataDataSet.SalariosVentaAdmin, Convert.ToInt32(comboBox1.SelectedValue));
            dateTimePicker1.Value = new DateTime(1753, 1, 1);
            dateTimePicker2.Value = new DateTime(9998, 12, 31);
            dateTimePicker4.Value = new DateTime(1753, 1, 1);
            dateTimePicker3.Value = new DateTime(9998, 12, 31);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int colorRojo = chkRojo.Checked ? -65536 : 0;
            int colorAzul = chkAzul.Checked ? -16776961 : 0;
            int colorNegro = chkNegro.Checked ? -16777216 : 0;

            try
            {
                this.Validate();
                salariosVentaAdminBindingSource.EndEdit();
                salariosVentaAdminTableAdapter.Update(promowork_dataDataSet.SalariosVentaAdmin);

                obrasBindingSource.EndEdit();
                obrasTableAdapter.Update(promowork_dataDataSet.Obras);
            }
            catch
            {
                MessageBox.Show("No se pudo salvar la información de Salario por fechas o el % Aplicado a las Compras.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
            int IdObraActual = Convert.ToInt32(comboBox1.SelectedValue);
            decimal Porciento = 0;
            try
            {
                Porciento = Convert.ToDecimal(textBox1.Text);
            }
            catch { }

            RptResumenObraCompletaAdmin frm = new RptResumenObraCompletaAdmin();
            frm.LoadParametros(IdObraActual, Porciento, dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker4.Value, dateTimePicker3.Value, colorRojo, colorAzul, colorNegro);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                this.salariosVentaAdminTableAdapter.Fill(promowork_dataDataSet.SalariosVentaAdmin, Convert.ToInt32(comboBox1.SelectedValue)); 
            }
            catch { }
            
        }

        private void salariosVentaAdminDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataRowView salactual = (DataRowView)salariosVentaAdminBindingSource.Current;

            salactual["IdObra"] = comboBox1.SelectedValue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                obrasTableAdapter.FillByFechaObra(promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual,VariablesGlobales.nAnoActual,VariablesGlobales.nMesActual);
            }
            else
            {
                this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Value=new DateTime(1753, 1, 1);
                dateTimePicker2.Value = new DateTime(9998, 12, 31);

            
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                dateTimePicker1.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, 1);
                dateTimePicker2.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual));
                dateTimePicker2.MinDate = dateTimePicker1.Value;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker4.Value = new DateTime(1753, 1, 1);
                dateTimePicker3.Value = new DateTime(9998, 12, 31);
            }
            else
            {
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
                dateTimePicker4.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, 1);
                dateTimePicker3.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual));
                dateTimePicker3.MinDate = dateTimePicker4.Value;
            }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.MinDate = dateTimePicker4.Value;
            if (dateTimePicker3.Value < dateTimePicker4.Value)
            {
                dateTimePicker3.Value = dateTimePicker4.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                salariosVentaAdminBindingSource.EndEdit();
                salariosVentaAdminTableAdapter.Update(promowork_dataDataSet.SalariosVentaAdmin);

                obrasBindingSource.EndEdit();
                obrasTableAdapter.Update(promowork_dataDataSet.Obras);
            }
            catch
            {
                MessageBox.Show("No se pudo salvar la información de Salario por fechas o el % Aplicado a las Compras.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            int IdObraActual = Convert.ToInt32(comboBox1.SelectedValue);
            decimal Porciento = 0;
            try
            {
                Porciento = Convert.ToDecimal(textBox1.Text);
            }
            catch { }

            ObraCompletaAdminColores frm = new ObraCompletaAdminColores();
            frm.LoadParametros(IdObraActual, Porciento, dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker4.Value, dateTimePicker3.Value);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

       
    }
}
