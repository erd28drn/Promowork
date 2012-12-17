using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public partial class FacturasHorasMateriales : Form
    {
        public FacturasHorasMateriales()
        {
            InitializeComponent();
        }

        private void facturasCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.facturasCabBindingSource.EndEdit();
            facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
        
          //  toolStripButton1.Enabled = true;
           // toolStripButton12.Enabled = true;
            facturasCabDataGridView.Enabled = true;
            facturasCabDataGridView_CellEnter(null,null);
            }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,false);
              
           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,false);
               }

           }

        }

        private void FacturasPresup_Load(object sender, EventArgs e)
        {
       
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
          
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(this.promowork_dataDataSet.CuentasBancos,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            clientesBindingSource.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasDet' table. You can move, or remove it, as needed.
           // this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasCab' table. You can move, or remove it, as needed.
            this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab,VariablesGlobales.nIdEmpresaActual,false);
            this.empresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            this.facturasCabBindingSource.MoveLast();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            fechaFacturaDateTimePicker.Value = DateTime.Now;
            fechaVctoFactDateTimePicker.Value = DateTime.Now;
            mostrarVctoCheckBox.Checked = true;
            DataRowView empresa = (DataRowView)empresasActualBindingSource.Current;
            numFacturaTextBox.Text = Convert.ToString(empresa["FactEmpresa"]);
            empresa["FactEmpresa"] = Convert.ToInt32(empresa["FactEmpresa"]) + 1;
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);

            DataRowView factura = (DataRowView)facturasCabBindingSource.Current;
            factura["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            factura["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            factura["Cobrada"] = false;
            factura["FacturaPresup"] = false;

          
          //  toolStripButton1.Enabled = false;
          //  toolStripButton12.Enabled = false;
            facturasCabDataGridView.Enabled = false;
            numFacturaTextBox.Focus();
            facturasCabDataGridView_CellEnter(null, null);
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedValue = idClienteComboBox.SelectedValue;
            }
            catch { }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            facturasCabDataGridView.Enabled = true;
        }

      
      private void facturasCabDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
       {

           this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
            this.vHorasTrabajadasTableAdapter.Fill(promowork_dataDataSet.vHorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
         
           try
           {
               textBox16.Text = Convert.ToString(Math.Round(Convert.ToDecimal(importeTextBox1.Text) * Convert.ToDecimal(descFacuraTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox16.Text = "0,00";
           }

           try
           {
               textBox20.Text = Convert.ToString(Math.Round((Convert.ToDecimal(importeTextBox1.Text) - Convert.ToDecimal(textBox16.Text)) * Convert.ToDecimal(descProntoTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox20.Text = "0,00";
           }

           try
           {
               textBox22.Text = Convert.ToString(Convert.ToDecimal(importeTextBox1.Text) - Convert.ToDecimal(textBox20.Text) - Convert.ToDecimal(textBox16.Text)); 
           }
           catch
           {
               textBox22.Text = "0,00";
           }

           try
           {
               textBox15.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox22.Text) * Convert.ToDecimal(iVAFacturaTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox15.Text = "0,00";
           }

           try
           {
               textBox23.Text = Convert.ToString(Convert.ToDecimal(textBox22.Text) + Convert.ToDecimal(textBox15.Text));
           }
           catch
           {
               textBox23.Text = "0,00";
           }

           try
           {
               textBox21.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox23.Text) * Convert.ToDecimal(retencionTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox21.Text = "0,00";
           }

           try
           {
               textBox17.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox23.Text)- Convert.ToDecimal(textBox21.Text), 2));
           }
           catch
           {
               textBox17.Text = "0,00";
           }
          
       }

      
       private void printToolStripButton_Click(object sender, EventArgs e)
       {
           DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

           int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


           RptFacturasManualImp frm = new RptFacturasManualImp();
           frm.LoadFiltro(Factura);
           frm.MdiParent = this.MdiParent;
           frm.Show();
       }


       private void importeTextBox1_TextChanged(object sender, EventArgs e)
       {
            try {importeTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDecimal(importeTextBox1.Text), 2));}
           catch { }
       }

       
       private void facturasDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
       }

       private void facturasCabDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
       {
           e.CellStyle.BackColor = Convert.ToBoolean(facturasCabDataGridView.Rows[e.RowIndex].Cells["FacturaPresup"].Value)==true?Color.LightGray:Color.White;
       }

       private void toolStripButton7_Click(object sender, EventArgs e)
       {
         try
           { 
               this.Validate();
            //   this.facturasDetHorasBindingSource.EndEdit();
            //   facturasDetHorasTableAdapter.Update(promowork_dataDataSet.FacturasDetHoras);
 
               this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,false);
               this.facturasCabBindingSource.MoveLast();
               facturasCabDataGridView.Enabled = true;
               facturasCabDataGridView_CellEnter(null, null);
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
               }

           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
           openFileDialog1.ShowDialog();
           DataRowView facturaActual = (DataRowView)facturasCabBindingSource.Current;
           facturaActual["CopiaFactura"] = openFileDialog1.FileName;
           copiaFacturaTextBox.Text = openFileDialog1.FileName;
       }

       private void button4_Click(object sender, EventArgs e)
       {
           DataRowView FacturaActual = (DataRowView)facturasCabBindingSource.Current;
           try
           {
               System.Diagnostics.Process.Start(Convert.ToString(FacturaActual["CopiaFactura"]));
           }
           catch
           {
               MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
       }

       private void button3_Click(object sender, EventArgs e)
       {
           DataRowView FcaturaActual = (DataRowView)facturasCabBindingSource.Current;
           FcaturaActual["CopiaFactura"] = null;
           copiaFacturaTextBox.Text = "";
       }

       private void toolStripButton7_Click_1(object sender, EventArgs e)
       {
           try
           {
               this.Validate();
              vFacturaDetHorasBindingSource.EndEdit();
             // vFacturaDetHorasTableAdapter.  // facturasDetHorasTableAdapter.Update(promowork_dataDataSet.FacturasDetHoras);

               this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, false);
               this.facturasCabBindingSource.MoveLast();
               facturasCabDataGridView.Enabled = true;
               facturasCabDataGridView_CellEnter(null, null);
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
               }

           }
       }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {
           gridView1.SetFocusedRowCellValue("IdFactCab", facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value);
           this.horasTrabajadasTableAdapter.FillByFacturado(this.promowork_dataDataSet.HorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
       }

    }
}
