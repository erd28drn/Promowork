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
    public partial class FacturasManuales : Form
    {
        public FacturasManuales()
        {
            InitializeComponent();
        }

        private void facturasCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

            int nIdFactura = Convert.ToInt32(FacturaAct["IdFactCab"]);

            bool ok = true;
            if (facturaCheckBox.CheckState == CheckState.Checked && esPrevisionCheckEdit.CheckState != CheckState.Checked)
            {
                facturaIncorrectaTableAdapter.Fill(promowork_dataDataSet.FacturaIncorrecta, VariablesGlobales.nIdEmpresaActual, (DateTime)fechaFacturaDateTimePicker.Value, (bool)facturaCheckBox.Checked, int.Parse(numFacturaTextBox.Text), nIdFactura, txtSerieFact.Text);

                if (facturaIncorrectaBindingSource.Count > 0)
                {
                    ok = false;
                    DataTable tmpFacturas = promowork_dataDataSet.FacturaIncorrecta.Select().CopyToDataTable();

                    FacturasIncorrectas frm = new FacturasIncorrectas();
                    frm.LoadParametros(tmpFacturas);
                    // frm.MdiParent = this.MdiParent;
                    frm.ShowDialog();



                    //   MessageBox.Show("No se puede usar ese número de factura en esa fecha. Existen facturas con fecha posterior y número menos o con fecha inferior y número mayor a la actual.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }

            if (ok == true)
            {
                try
                {
                    //MessageBox.Show(comboBox4.SelectedValue.ToString());

                    // DataRowView factura = (DataRowView)facturasCabBindingSource.Current;
                    //factura["IdClienteFact"] = comboBox4.SelectedValue;
                    this.Validate();
                    this.facturasCabBindingSource.EndEdit();
                    facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
                    if (idCuentaComboBox.Text == "" && facturasCabDataGridView.RowCount != 0)
                    {
                        facturasCabDataGridView.CurrentRow.Cells["IdCuenta"].Value = DBNull.Value;
                    }

                    this.Validate();
                    this.facturasCabBindingSource.EndEdit();
                    facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);

                    toolStripButton1.Enabled = true;
                    // toolStripButton12.Enabled = true;
                    facturasCabDataGridView.Enabled = true;
                    facturasCabDataGridView_CellEnter(null, null);
                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (cbxfacturas.Text == "Facturas")
                    {
                        this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                    }
                    else
                    {
                        this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                    }
                    facturasCabBindingSource.Filter = "FacturaPresup=0";

                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        if (cbxfacturas.Text == "Facturas")
                        {
                            this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                        }
                        else
                        {
                            this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                        }
                        facturasCabBindingSource.Filter = "FacturaPresup=0";
                    }

                }

            }
        }

        private void FacturasPresup_Load(object sender, EventArgs e)
        {
            this.empresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
           
            this.anosFacturasTableAdapter.FillByFactManuales(promowork_dataDataSet.AnosFacturas, VariablesGlobales.nIdEmpresaActual);
            cbxanos.SelectedValue = VariablesGlobales.nAnoActual;
            
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
          
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(this.promowork_dataDataSet.CuentasBancos,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes,VariablesGlobales.nIdEmpresaActual);
            clientesBindingSource.Sort = "DesCliente";
            clientesBindingSource1.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasDet' table. You can move, or remove it, as needed.
           // this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasCab' table. You can move, or remove it, as needed.
            if (cbxfacturas.Text == "Facturas")
            {
                this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
            }
            else
            {
                this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
            }
            facturasCabBindingSource.Filter = "FacturaPresup=0";
            
            this.facturasCabBindingSource.MoveLast();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            fechaFacturaDateTimePicker.Value = DateTime.Now;
            fechaVctoFactDateTimePicker.Value = DateTime.Now;
            mostrarVctoCheckBox.Checked = true;
            chkMostrarObra.Checked = true;
            DataRowView empresa = (DataRowView)empresasActualBindingSource.Current;
            int numfact = 1;
               try
               {
               numfact= (int)empresa["FactEmpresa"];
               numFacturaTextBox.Text = numfact.ToString();
               empresa["FactEmpresa"] = int.Parse(numFacturaTextBox.Text) + 1;
               }
            catch{}
            
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);

            DataRowView factura = (DataRowView)facturasCabBindingSource.Current;
            factura["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            factura["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            factura["Cobrada"] = false;
            factura["FacturaPresup"] = false;
            factura["Entregada"] = false;
            factura["EsPrevision"] = false;
            
            if (cbxfacturas.Text == "Facturas")
            {
                factura["Factura"] = true;
                factura["MostrarVcto"] = true;
            }
            else {
                factura["Factura"] = false;
                factura["MostrarVcto"] = false;
            }

          
            toolStripButton1.Enabled = false;
          //  toolStripButton12.Enabled = false;
            facturasCabDataGridView.Enabled = false;
            numFacturaTextBox.Focus();
            facturasCabDataGridView_CellEnter(null, null);
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox4.SelectedValue = comboBox4.SelectedValue == null ? idClienteComboBox.SelectedValue : comboBox4.SelectedValue;
                //this.obrasTableAdapter.FillByCliente(promowork_dataDataSet.Obras, Convert.ToInt32(idClienteComboBox.SelectedValue));

            }
            catch { }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.facturasCabBindingSource.RemoveCurrent();
                facturasCabDataGridView.Enabled = true;
            }
            
        }

      
      private void facturasCabDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           
         facturasDetTableAdapter.FillByFactura(promowork_dataDataSet.FacturasDet, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
    
          //if (facturasDetDataGridView.RowCount != 0 )
          //{
          //    idClienteComboBox.Enabled = false;
          //    idPresupComboBox.Enabled = false;
          //}
          //else
          //{
          //    idClienteComboBox.Enabled = true;
          //    idPresupComboBox.Enabled = true;
          //}
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
           try
           {
               DataRowView FacturaActual = (DataRowView)facturasCabBindingSource.Current;

               decimal ImpCobro = Convert.ToDecimal(promowork_dataDataSet.Cobros.Compute("Sum(ImpCobro)", "IdFactCab=" + Convert.ToString(FacturaActual["IdFactCab"])));
               textBox18.Text = Convert.ToString(ImpCobro);
           }
           catch
           {
               textBox18.Text = "0,00";
           }
           textBox19.Text = Convert.ToString(Math.Round( Convert.ToDecimal(textBox17.Text) - Convert.ToDecimal(textBox18.Text), 2));

          
           
       }


       private void idPresupComboBox_Enter(object sender, EventArgs e)
       {
           
       }

      
      

       private void toolStripButton12_Click(object sender, EventArgs e)
       {
         

               try
               {
                   this.Validate();
                //   cobrosBindingSource.EndEdit();
                 //  cobrosTableAdapter.Update(promowork_dataDataSet.Cobros);
                   facturasCabDataGridView_CellEnter(null, null);
                 try
               {
                   if (Convert.ToDecimal(textBox19.Text)<=0)
                   {
                       facturasCabDataGridView.CurrentRow.Cells["Cobrada"].Value = true;
                       this.Validate();
                       this.facturasCabBindingSource.EndEdit();
                       this.facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);

                   }
                   else
                   {
                       facturasCabDataGridView.CurrentRow.Cells["Cobrada"].Value = false;
                       this.Validate();
                       this.facturasCabBindingSource.EndEdit();
                       this.facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
                   }
               }
                 catch (DBConcurrencyException)
                 {

                     MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     if (cbxfacturas.Text == "Facturas")
                     {
                         this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                     }
                     else
                     {
                         this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                     }
                     facturasCabBindingSource.Filter = "FacturaPresup=0";

                 }
                 catch (SqlException ex)
                 {
                     if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                     {
                         if (cbxfacturas.Text == "Facturas")
                         {
                             this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                         }
                         else
                         {
                             this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                         }
                         facturasCabBindingSource.Filter = "FacturaPresup=0";
                     }

                 }
               }
               catch (DBConcurrencyException)
               {

                   MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //   this.cobrosTableAdapter.Fill(this.promowork_dataDataSet.Cobros);

               }
               catch (SqlException ex)
               {
                   if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                   {
                 //      this.cobrosTableAdapter.Fill(this.promowork_dataDataSet.Cobros);
                   }

               }
          // }
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

       private void importeTextBox2_TextChanged(object sender, EventArgs e)
       {
           try { importeTextBox2.Text = Convert.ToDecimal(importeTextBox2.Text).ToString("###,###,##0.00"); }
          catch { }
         //  try { importeTextBox2.Text = Convert.ToString(Math.Round(Convert.ToDecimal(importeTextBox2.Text), 2)); }
          // catch { }
          
       }

       private void impFacturadoTextBox_TextChanged(object sender, EventArgs e)
       {
           try { impFacturadoTextBox.Text = Convert.ToString(Math.Round(Convert.ToDecimal(impFacturadoTextBox.Text), 2)); }
           catch { }
       }

       private void pendienteTextBox_TextChanged(object sender, EventArgs e)
       {
            try {pendienteTextBox.Text = Convert.ToString(Math.Round(Convert.ToDecimal(pendienteTextBox.Text), 2));}
           catch { }
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

       //private void facturasCabDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
       //{
       //    if (facturasCabDataGridView.RowCount > 0)
       //    {
       //        bool facturapresupuesto=false;
       //        try
       //        {
       //            facturapresupuesto = Convert.ToBoolean(facturasCabDataGridView.Rows[e.RowIndex].Cells["FacturaPresup"].Value);
       //        }
       //        catch{}
       //        e.CellStyle.BackColor = facturapresupuesto == true ? Color.LightGray : Color.White;
       //    }
       //}

       private void toolStripButton7_Click(object sender, EventArgs e)
       {
         try
           {
               
               this.Validate();
               this.facturasDetBindingSource.EndEdit();
               facturasDetTableAdapter.Update(promowork_dataDataSet.FacturasDet);

               DataRowView facturaActual = (DataRowView)facturasCabBindingSource.Current;
               int nIdfactcab = (int)facturaActual["IdFactCab"];

               if (cbxfacturas.Text == "Facturas")
               {
                   this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               else
               {
                   this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }

               facturasCabBindingSource.Filter = "FacturaPresup=0";

               int pos= facturasCabBindingSource.Find("IdFactCab", nIdfactcab);
               facturasCabBindingSource.Position = pos;
           
               //this.facturasCabBindingSource.MoveLast();
               facturasCabDataGridView.Enabled = true;
               facturasCabDataGridView_CellEnter(null, null);
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               
               facturasDetTableAdapter.FillByFactura(promowork_dataDataSet.FacturasDet, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   facturasDetTableAdapter.FillByFactura(promowork_dataDataSet.FacturasDet, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
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

       private void printToolStripButton1_Click(object sender, EventArgs e)
       {
           if (facturaCheckBox.Checked == true)
           {
               DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

               int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


               RptFacturasManualImp2 frm = new RptFacturasManualImp2();
               frm.LoadFiltro(Factura);
               frm.MdiParent = this.MdiParent;
               frm.Show();
           }
           else
           {
               DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

               int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


               RptFacturasManualImpParte2 frm = new RptFacturasManualImpParte2();
               frm.LoadFiltro(Factura);
               frm.MdiParent = this.MdiParent;
               frm.Show();
           }

       }

       private void cbxanos_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (cbxanos.SelectedIndex != -1)
           {
               if (cbxfacturas.Text == "Facturas")
               {
                   this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               else
               {
                   this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               facturasCabBindingSource.Filter = "FacturaPresup=0";
           }
       }

       private void cbxfacturas_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (cbxanos.SelectedIndex!=-1)
           {
               if (cbxfacturas.Text == "Facturas")
               {
                   this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               else
               {
                   this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               facturasCabBindingSource.Filter = "FacturaPresup=0";
           }
       }

           
    }
}
