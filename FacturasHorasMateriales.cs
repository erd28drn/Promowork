using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
            bool ok = true;

            if (gridView6.RowCount > 0)
            {
                DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

                int nIdFactura = Convert.ToInt32(FacturaAct["IdFactCab"]);


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
            }

            if (ok==true)
            {

                try
                {
                    this.Validate();
                    this.facturasCabBindingSource.EndEdit();
                    facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);

                    decimal importe = 0;
                    try
                    {
                        importe = decimal.Parse(importeTextBox1.Text);
                    }
                    catch { }

                    decimal impBase = 0;
                    try
                    {
                        impBase = decimal.Parse(impBaseTextBox.Text);
                    }
                    catch { }

                    decimal impIVA = 0;
                    try
                    {
                        impIVA = decimal.Parse(impIVATextBox.Text);
                    }
                    catch { }

                    if (gridView6.RowCount > 0)
                    {
                        DataRowView facturaActual = (DataRowView)facturasCabBindingSource.Current;
                      //  facturaActual["Cobrada"] = importe <= impBase && impBase != 0 ? true : false;
                        facturaActual["Entregada"] = entregadaCheckBox.CheckState;



                        // this.facturasCabDataGridView.CurrentRow.Cells["Entregada"].Value = entregadaCheckBox.CheckState;

                        if (idCuentaComboBox.Text == "")
                        {
                            facturaActual["IdCuenta"] = DBNull.Value;
                        }
                        this.Validate();
                        this.facturasCabBindingSource.EndEdit();
                        facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
                        //  toolStripButton1.Enabled = true;
                        // toolStripButton12.Enabled = true;
                        facturasCabGridControl.Enabled = true;

                        //DataRowView empresa = (DataRowView)empresasActualBindingSource.Current;
                        //empresa["FactEmpresa"] = Convert.ToInt32(numFacturaTextBox.Text) + 1;
                        //this.Validate();
                        //this.empresasActualBindingSource.EndEdit();
                        //empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);

                        this.Validate();
                        this.cobrosBindingSource.EndEdit();


                        if (impBase != 0)
                        {

                            if (cobrosBindingSource.Count == 0)
                            {
                                int? nidobra;
                                nidobra = (int?)idPresupComboBox.SelectedValue;
                                cobrosTableAdapter.Insert(VariablesGlobales.nIdUsuarioActual, VariablesGlobales.nIdEmpresaActual, (int)idClienteComboBox.SelectedValue,
                                                            nidobra, fechaExpDateTimePicker.Value, fechaExpDateTimePicker.Value, fechaExpDateTimePicker.Value,
                                                            fechaExpDateTimePicker.Value, (int)gridView6.GetFocusedRowCellValue("IdFactCab"), numFacturaTextBox.Text + "/" + fechaFacturaDateTimePicker.Value.Year.ToString(), (int)desFormaPagoComboBox.SelectedValue,
                                                            (int)comboBox2.SelectedValue, impBase, impIVA, null, null, fechaFacturaDateTimePicker.Value, null, false, false,null);

                            }
                        }
                        else
                        {
                            if (cobrosBindingSource.Count != 0)
                            {
                                cobrosBindingSource.RemoveCurrent();
                            }
                        }


                        this.cobrosTableAdapter.Update(promowork_dataDataSet.Cobros);
                        this.cobrosTableAdapter.FillByFactura(this.promowork_dataDataSet.Cobros, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
                    }


                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Debe completar los datos del Cobro.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    }

                }
                //    this.facturasCabTableAdapter.FillByFactHoras(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual);
                gridView6_FocusedRowChanged(null, null);

                if (gridView6.RowCount > 0)
                {
                    this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
                }
            }
        }

        private void FacturasPresup_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Tipos' Puede moverla o quitarla según sea necesario.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Cobros' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.anosFacturasTableAdapter.FillByFactHoras(promowork_dataDataSet.AnosFacturas, VariablesGlobales.nIdEmpresaActual);
            cbxanos.SelectedValue = VariablesGlobales.nAnoActual;

            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
       
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            
          
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(this.promowork_dataDataSet.CuentasBancos,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet1.Clientes, VariablesGlobales.nIdEmpresaActual);
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
           // this.facturasCabTableAdapter.Fill(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual);
            this.empresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
            this.obrasTableAdapter.FillByEmpresa(promowork_dataDataSet1.Obras, VariablesGlobales.nIdEmpresaActual);
            //this.obrasTableAdapter.FillByListaObras(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            this.facturasCabBindingSource.MoveLast();
            toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
            toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            facturasCabBindingSource.Filter = "EsPrevision=0";
            facturasCabBindingSource.MoveLast();
            int nuevaFactura = 0;
            try
            {
                nuevaFactura = (int)(gridView6.GetFocusedRowCellValue("NumFactura")) + 1;
            }
            catch { }
            facturasCabBindingSource.Filter = null;
           
            facturasCabBindingSource.AddNew();
            numFacturaTextBox.Text = nuevaFactura.ToString();
            DataRowView factura = (DataRowView)facturasCabBindingSource.Current;
            factura["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            factura["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            factura["FechaFactura"] = DateTime.Today;
            factura["FechaVctoFact"] = DateTime.Today;
           // factura["Factura"] = true;
            factura["Cobrada"] = false;
            factura["Entregada"] = false;
           // factura["MostrarVcto"] = true;
            factura["EsPrevision"] = false;

            if (cbxfacturas.Text == "Facturas")
            {
                factura["Factura"] = true;
                factura["MostrarVcto"] = true;
                factura["MostrarObra"] = true;
            }
            else
            {
                factura["Factura"] = false;
                factura["MostrarVcto"] = false;
                factura["MostrarObra"] = false;
            }

          //  factura["FacturaPresup"] = null;

          
          //  toolStripButton1.Enabled = false;
          //  toolStripButton12.Enabled = false;
             facturasCabGridControl.Enabled = false;
            numFacturaTextBox.Focus();
            gridView6_FocusedRowChanged(null, null);
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedValue = comboBox1.SelectedValue == null ? idClienteComboBox.SelectedValue : comboBox1.SelectedValue;
                this.obrasTableAdapter.FillByCliente(promowork_dataDataSet.Obras, Convert.ToInt32(idClienteComboBox.SelectedValue));
                
            }
            catch { }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gridView6.RowCount > 0)
                {
                    this.facturasCabBindingSource.RemoveCurrent();
                    facturasCabGridControl.Enabled = true;
                }
            }
            
        }


        private void gridView6_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {

            if (entregadaCheckBox.CheckState == CheckState.Checked)
           {
               idClienteComboBox.Enabled = false;
               idPresupComboBox.Enabled = false;
               comboBox1.Enabled = false;
               idCuentaComboBox.Enabled = false;
               fechaFacturaDateTimePicker.Enabled = false;
               fechaVctoFactDateTimePicker.Enabled = false;
               numFacturaTextBox.Enabled = false;
               txtSerieFact.Enabled = false;
               descFacuraTextBox.Enabled = false;
               descProntoTextBox.Enabled = false;
               certificacionTextBox.Enabled = false;
               mostrarVctoCheckBox.Enabled = false;
               iVAFacturaTextBox.Enabled = false;
               retencionTextBox.Enabled = false;
               anticipoTextBox.Enabled = false;
               facturaCheckBox.Enabled = false;
               noDetalleCheckEdit.Enabled = false;
               esPrevisionCheckEdit.Enabled = false;
               chkMostrarObra.Enabled = false;
               chkSubTot.Enabled = false;
           }
            else
            {
                decimal importe = 0;
                try
                {
                    importe = (decimal)gridView6.GetFocusedRowCellValue("Importe");
                }
                catch { }
 
                if (importe != 0)
                {
                    idClienteComboBox.Enabled = false;
                    idPresupComboBox.Enabled = false;
                    
                }
                else
                {
                    idClienteComboBox.Enabled = true;
                    idPresupComboBox.Enabled = true;
                   
                }

                comboBox1.Enabled = true;
                idCuentaComboBox.Enabled = true;
                fechaFacturaDateTimePicker.Enabled = true;
                fechaVctoFactDateTimePicker.Enabled = true;
                numFacturaTextBox.Enabled = true;
                txtSerieFact.Enabled = true;
                descFacuraTextBox.Enabled = true;
                descProntoTextBox.Enabled = true;
                certificacionTextBox.Enabled = true;
                mostrarVctoCheckBox.Enabled = true;
                iVAFacturaTextBox.Enabled = true;
                retencionTextBox.Enabled = true;
                anticipoTextBox.Enabled = true;
                facturaCheckBox.Enabled = true;
                noDetalleCheckEdit.Enabled = true;
                esPrevisionCheckEdit.Enabled = true;
                chkMostrarObra.Enabled = true;
                chkSubTot.Enabled = true;
            }


            try
            {
               //MessageBox.Show(gridView6.GetFocusedRowCellValue("Importe").ToString());
            decimal nIVA;
            if (iVAFacturaTextBox.Text == "")
            {
                nIVA = 0;
            }
            else
            {
                nIVA = (decimal.Parse(iVAFacturaTextBox.Text) / 100);
            }

            try
            {
                importeTextBox1.Text = Math.Round((decimal)gridView6.GetFocusedRowCellValue("Importe") / (1+nIVA), 2).ToString("0.00");
            }
            catch
            {
                importeTextBox1.Text = "0.00";
            }

               //foreach (Control cnt in groupBox3.Controls)
               //{
               //    cnt.Enabled = true;
               //}

               //foreach (Control cnt in this.Controls)
               //{
               //    cnt.Enabled = true;
               //}
               this.cobrosTableAdapter.FillByFactura(this.promowork_dataDataSet.Cobros, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
               this.vHorasTrabajadasTableAdapter.Fill(promowork_dataDataSet.vHorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
               this.descuentosFacturasTableAdapter.FillByFactura(promowork_dataDataSet.DescuentosFacturas, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));


               if (gridView4.RowCount == 0)
               {
                   this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, 0);
               }
               else
               {
                   this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
               }

               toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
               toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
               fechaExpDateTimePicker.Value = cobrosBindingSource.Count == 0 ? fechaFacturaDateTimePicker.Value : fechaExpDateTimePicker.Value;
               try
               {
                   comboBox2.SelectedValue = cobrosBindingSource.Count == 0 ? idCuentaComboBox.SelectedValue : comboBox2.SelectedValue;
               }
               catch { }
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
                   textBox15.Text = (Convert.ToDecimal(textBox22.Text) * nIVA).ToString("n2");
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
                   textBox17.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox23.Text) - Convert.ToDecimal(textBox21.Text), 2));
               }
               catch
               {
                   textBox17.Text = "0,00";
               }

                int nIdObra=0;
                try
                {
                    nIdObra = (int)gridView6.GetFocusedRowCellValue("IdObra");
                }
                catch{}
               this.vPrecioHorasFacturasTableAdapter.FillbyObraAno(promowork_dataDataSet.vPrecioHorasFacturas, nIdObra, (int)cbxanos.SelectedValue);

           }
           catch { }
       }

   
       private void importeTextBox1_TextChanged(object sender, EventArgs e)
       {
           try { importeTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDecimal(importeTextBox1.Text), 2)); }
           catch { }
       }

       
       private void facturasDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
       }

      private void toolStripButton7_Click(object sender, EventArgs e)
       {
         try
           { 
               this.Validate();
            //   this.facturasDetHorasBindingSource.EndEdit();
            //   facturasDetHorasTableAdapter.Update(promowork_dataDataSet.FacturasDetHoras);

               if (cbxfacturas.Text == "Facturas")
               {
                   this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               else
               {
                   this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               this.facturasCabBindingSource.MoveLast();
               facturasCabGridControl.Enabled = true;
               gridView6_FocusedRowChanged(null, null);
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
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

              if (cbxfacturas.Text == "Facturas")
              {
                  this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
              }
              else
              {
                  this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
              }
               this.facturasCabBindingSource.MoveLast();
               facturasCabGridControl.Enabled = true;
               gridView6_FocusedRowChanged(null, null);
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
               }

           }
       }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {
           gridView1.SetFocusedRowCellValue("IdFactCab", (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
           this.horasTrabajadasTableAdapter.FillByFacturado(this.promowork_dataDataSet.HorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
       }

      
      
       private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {
           try
           {
               this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
           }
           catch { }
           toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
       }

      
       private void toolStripButton2_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
           
           //MessageBox.Show(Convert.ToString(gridView1.GetFocusedRowCellValue("IdFactDetHoras")));
           queriesTableAdapter1.BorraDetalleFactura(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdFactDetHoras")));
           this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
           this.vHorasTrabajadasTableAdapter.Fill(promowork_dataDataSet.vHorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
           this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
           toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
           toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
           //this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
           //gridView6_FocusedRowChanged(null, null);

           facturasCabBindingNavigatorSaveItem_Click(null, null);
           decimal importe = 0;
           try
           {
               importe = decimal.Parse(importeTextBox.Text);
           }
           catch { }

           decimal impBase = 0;
           try
           {
               impBase = decimal.Parse(impBaseTextBox.Text);
           }
           catch { }
         
           //    gridView6.SetFocusedRowCellValue("Cobrada", importe <= impBase && impBase != 0 ? true : false);

           //this.Validate();
           //this.facturasCabBindingSource.EndEdit();
           //facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
       }
       }

       private void toolStripButton8_Click(object sender, EventArgs e)
       {
           
           gridView4.CloseEditor();
           gridView5.CloseEditor();
           decimal nCantAdmin = 0;
           decimal nSalarioVenta = 0;
           try
           {
               nCantAdmin=Convert.ToDecimal(gridView4.GetFocusedRowCellValue("CantAdmin"));
           }
           catch{}
           try
           {
               nSalarioVenta=Convert.ToDecimal(gridView4.GetFocusedRowCellValue("SalarioVenta"));
           }
           catch{}

           int nidhoras = Convert.ToInt32(gridView4.GetFocusedRowCellValue("IdHoras"));

           queriesTableAdapter1.ActualizaCantHorasAdmin(nidhoras, nCantAdmin, nSalarioVenta);
           this.Validate();
           productosUtilizadosBindingSource1.EndEdit();
           productosUtilizadosTableAdapter.Update(promowork_dataDataSet1.ProductosUtilizados);
           queriesTableAdapter1.InsertaDetalleFactura((int)gridView6.GetFocusedRowCellValue("IdFactCab"), nidhoras);

           this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
           this.vHorasTrabajadasTableAdapter.Fill(promowork_dataDataSet.vHorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
           this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet.ProductosUtilizados, nidhoras);
           toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
           toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
           //this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
           //gridView6_FocusedRowChanged(null, null);

           facturasCabBindingNavigatorSaveItem_Click(null, null);
          
           decimal importe = 0;
           try
           {
               importe = decimal.Parse(importeTextBox.Text);
           }
           catch { }

           decimal impBase = 0;
           try
           {
               impBase = decimal.Parse(impBaseTextBox.Text);
           }
           catch { }

           
           
           //gridView6.SetFocusedRowCellValue("Cobrada", importe <= impBase && impBase != 0 ? true : false);
           //this.Validate();
           //this.facturasCabBindingSource.EndEdit();
           //facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
       }

       private void toolStripButton7_Click_2(object sender, EventArgs e)
       {
           gridView1.SelectAll();

           gridView1.CloseEditor();
           gridView3.CloseEditor();
           ArrayList rows = new ArrayList();
           DataTable SelRows = new DataTable();
           SelRows.Columns.Add("IdHoras", System.Type.GetType("System.Int32"));
           SelRows.Columns.Add("CantAdmin", System.Type.GetType("System.Decimal"));
           SelRows.Columns.Add("SalarioVenta", System.Type.GetType("System.Decimal"));
           SelRows.Columns.Add("DescuentoHoras", System.Type.GetType("System.Decimal"));
           // Add the selected rows to the list.
           for (int i = 0; i < gridView1.SelectedRowsCount; i++)
           {
               if (gridView1.GetSelectedRows()[i] >= 0)
                   rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

           }
           try
           {
               gridView1.BeginUpdate();
               for (int i = 0; i < rows.Count; i++)
               {
                   DataRow row = rows[i] as DataRow;
                   // Change the field value.
                   // row["ColorHoras"] = toolStripButton1.BackColor.ToArgb();
                   SelRows.Rows.Add(row["IdHoras"], row["CantAdmin"], row["SalarioVenta"], row["DescuentoHoras"]);
               }
           }
           finally
           {
               gridView1.EndUpdate();
           }

          queriesTableAdapter1.CantHorasAdmin(SelRows);
          this.Validate();
          productosUtilizadosBindingSource1.EndEdit();
          productosUtilizadosTableAdapter.Update(promowork_dataDataSet.ProductosUtilizados);
           gridView1.ClearSelection();

           //this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));

           facturasCabBindingNavigatorSaveItem_Click(null, null);
           
          // gridView6_FocusedRowChanged(null, null);
           toolStripButton7.Enabled = false;
           decimal importe = 0;
           try
           {
               importe = decimal.Parse(importeTextBox.Text);
           }
           catch { }

           decimal impBase = 0;
           try
           {
               impBase = decimal.Parse(impBaseTextBox.Text);
           }
           catch { }
         //  gridView6.SetFocusedRowCellValue("Cobrada",importe <= impBase && impBase != 0 ? true : false);
           //////////this.Validate();
           //////////this.facturasCabBindingSource.EndEdit();
           //////////facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);

          // importeTextBox1.Text = gridView6.GetFocusedRowCellValue("Importe").ToString();
          // gridView6_FocusedRowChanged(null, null);
       }

       private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {
           try
           {
               this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet1.ProductosUtilizados, Convert.ToInt32(gridView4.GetFocusedRowCellValue("IdHoras")));
           }
           catch { }
       }

       private void importeTextBox_TextChanged(object sender, EventArgs e)
       {
           //importeTextBox1.Text = importeTextBox.Text;
           //try
           //{
           //    gridView6.SetFocusedRowCellValue("Importe", Convert.ToDecimal(importeTextBox.Text));
           //}
           //catch { }
       }

       private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
       {
           toolStripButton7.Enabled = true;
       }

       private void gridView3_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
       {
           toolStripButton7.Enabled = true;
       }

       private void gridView1_GotFocus(object sender, EventArgs e)
       {
           toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
       }

       private void toolStripButton1_Click_1(object sender, EventArgs e)
       {

           if (facturaCheckBox.Checked == true)
           {
               DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

               int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


               RptFacturasHorasDescImp frm = new RptFacturasHorasDescImp();
               frm.LoadFiltro(Factura);
               frm.MdiParent = this.MdiParent;
               frm.Show();
           }
           else 
           {
               DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

               int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


               RptFacturasHorasDescImpParte frm = new RptFacturasHorasDescImpParte();
               frm.LoadFiltro(Factura);
               frm.MdiParent = this.MdiParent;
               frm.Show();
               
               
               
               //MessageBox.Show("Esta Opción no esta disponible sino es una Factura.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               //DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

               //int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


               //RptFacturasHorasImpParte frm = new RptFacturasHorasImpParte();
               //frm.LoadFiltro(Factura);
               //frm.MdiParent = this.MdiParent;
               //frm.Show();
           }
       }

       private void toolStripButton13_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               this.descuentosFacturasBindingSource.RemoveCurrent();
           }
       }

       private void toolStripButton14_Click(object sender, EventArgs e)
       {
           gridView5.SetFocusedRowCellValue(colIdFactCab1, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
       }

       private void toolStripButton15_Click(object sender, EventArgs e)
       {
       try
       {
           this.Validate();
           this.descuentosFacturasBindingSource.EndEdit();
           this.descuentosFacturasTableAdapter.Update(promowork_dataDataSet.DescuentosFacturas);

       }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, (int)gridView6.GetFocusedRowCellValue("IdFactCab"));
               }

           }
       }

       private void cbxanos_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (cbxanos.SelectedValue != null)
           {
               if (cbxfacturas.Text == "Facturas")
               {
                   this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               else
               {
                   this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
           }
       }

       private void cbxfacturas_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (cbxanos.SelectedValue != null)
           {
               if (cbxfacturas.Text == "Facturas")
               {
                   this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
               else
               {
                   this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
               }
           }
       }

       private void FacturasHorasMateriales_FormClosing(object sender, FormClosingEventArgs e)
       {
           this.Visible = false;
           //promowork_dataDataSet.Clear();
           this.Close();
           
       }

       private void gridView1_DoubleClick(object sender, EventArgs e)
       {
         
           try
           {
               System.Diagnostics.Process.Start(gridView1.GetFocusedRowCellValue("CopiaParte").ToString());
           }
           catch
           {
               MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
       }

       private void gridView4_DoubleClick(object sender, EventArgs e)
       {
           try
           {
               System.Diagnostics.Process.Start(gridView4.GetFocusedRowCellValue("CopiaParte").ToString());
           }
           catch
           {
               MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
       }

       //////////////private void facturasCabDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
       //////////////{
        
       //////////////  //  e.CellStyle.BackColor = (bool)facturasCabDataGridView.Rows[e.RowIndex].Cells["Entregada"].Value == false ? Color.White : Color.Yellow;
       //////////////    e.CellStyle.BackColor = (bool)facturasCabDataGridView.Rows[e.RowIndex].Cells["Cobrada"].Value == true ? Color.LightGray : (bool)facturasCabDataGridView.Rows[e.RowIndex].Cells["Entregada"].Value == true ? Color.Yellow : Color.White;
       //////////////    e.CellStyle.Font = facturasCabDataGridView.Rows[e.RowIndex].Cells["FacturaPresup"].Value == DBNull.Value ? new Font("Arial", 8, FontStyle.Regular) : new Font("Arial", 8, FontStyle.Italic);
       //////////////  //  e.CellStyle.SelectionBackColor = (bool)facturasCabDataGridView.Rows[e.RowIndex].Cells["Entregada"].Value == false ? Color.Blue : Color.MediumAquamarine;
       //////////////}

       private void button2_Click(object sender, EventArgs e)
       {
           object valor = comboBox1.SelectedValue;
           Clientes frm = new Clientes();
           frm.ShowDialog();
           clientesTableAdapter.FillByEmpresa(promowork_dataDataSet1.Clientes, VariablesGlobales.nIdEmpresaActual);
           comboBox1.SelectedValue = valor;
       }

       private void button5_Click(object sender, EventArgs e)
       {
           object valor = idClienteComboBox.SelectedValue;
           Clientes frm = new Clientes();
           frm.ShowDialog();
           clientesTableAdapter.FillByEmpresa(promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
           idClienteComboBox.SelectedValue = valor;
       }

       private void toolStripButton16_Click(object sender, EventArgs e)
       {
           if (facturaCheckBox.Checked == true)
           {
               DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

               int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


               RptFacturasHorasImp frm = new RptFacturasHorasImp();
               frm.LoadFiltro(Factura, unificarMaterialCheckEdit.Checked);
               frm.MdiParent = this.MdiParent;
               frm.Show();
           }
           else
           {
               DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

               int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


               RptFacturasHorasImpParte frm = new RptFacturasHorasImpParte();
               frm.LoadFiltro(Factura, unificarMaterialCheckEdit.Checked);
               frm.MdiParent = this.MdiParent;
               frm.Show();
           }
       }

       private void gridView6_ColumnFilterChanged(object sender, EventArgs e)
       {
           if (gridView6.RowCount > 0)
           {
               facturasCabBindingSource.Position = 0;
           }
           
       }

                 
    }
}
