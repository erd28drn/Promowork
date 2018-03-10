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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void comprasCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.comprasCabBindingSource.EndEdit();
          //  this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);
            bindingNavigator1.Enabled = true;
            bindingNavigator2.Enabled = true;
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.comprasCabTableAdapter.FillByEmpresaAno(this.promowork_dataDataSet.ComprasCab, VariablesGlobales.nIdEmpresaActual, (int)cbAnos.SelectedItem);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.comprasCabTableAdapter.FillByEmpresaAno(this.promowork_dataDataSet.ComprasCab, VariablesGlobales.nIdEmpresaActual, (int)cbAnos.SelectedItem);
                }

            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {

            this.anosComprasTableAdapter.FillByEmpresa(promowork_dataDataSet.AnosCompras, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByListaObras(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.CuentasBancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            cuentasBancosBindingSource.Filter = "CtaEmpresa=true";
            //cuentasBancosBindingSource1.Filter = "CtaEmpresa=true";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ComprasDet' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ComprasCab' table. You can move, or remove it, as needed.
            
            this.proveedoresTableAdapter.FillByActivoEmpresa(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);
            this.empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            comprasCabBindingSource.Filter = "Pagada=false";
            comprasCabBindingSource.MoveLast();
            DataRowView EmpresaActual = (DataRowView)empresasActualBindingSource.Current;
            int AnoEmpresa = Convert.ToInt32(EmpresaActual["AnoEmpresa"]);
            DateTime fechaini = new DateTime(AnoEmpresa, 1, 1);
            toolStripTextBox3.Text = fechaini.ToShortDateString();
            radioButton4.Checked = !previsionRadioButton.Checked;

            foreach (DataRowView nAno in anosComprasBindingSource)
            {
                cbAnos.Items.Add(nAno["Ano"]);
            }
            cbAnos.SelectedItem = cbAnos.Items.Contains(VariablesGlobales.nAnoActual) ? VariablesGlobales.nAnoActual : int.Parse(null);

           

        }

        private void cbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.comprasCabTableAdapter.FillByEmpresaAno(this.promowork_dataDataSet.ComprasCab, VariablesGlobales.nIdEmpresaActual, (int)cbAnos.SelectedItem);
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
            CompraActual["CopiaFactura"] = openFileDialog1.FileName;
            copiaFacturaTextBox.Text = openFileDialog1.FileName;
           
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //comprasCabBindingSource.AddNew();
            DataRowView Proveedor = (DataRowView)proveedoresBindingSource.Current;
            DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
            CompraActual["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            CompraActual["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            CompraActual["Pagada"] = false;
            idProveedorComboBox.SelectedValue = Proveedor!=null?(int)Proveedor["IdProveedor"]: 0;
            CompraActual["FechaFactura"] = fechaFacturaDateTimePicker.Value;
            CompraActual["FechaRecib"] = fechaRecibDateTimePicker.Value;

            //fechaFacturaDateTimePicker.Value = DateTime.Parse(CompraActual["FechaFactura"].ToString());
           // fechaRecibDateTimePicker.Value = DateTime.Parse(CompraActual["FechaRecib"].ToString());
            bindingNavigator1.Enabled = false;
            bindingNavigator2.Enabled = false;
            idProveedorComboBox.Focus();
         
        }

        private void comprasCabDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
            this.comprasDetTableAdapter.FillbyCompra(this.promowork_dataDataSet.ComprasDet, Convert.ToInt32(CompraActual["IdCompra"]));
            this.pagosTableAdapter.FillCompra(this.promowork_dataDataSet.Pagos, Convert.ToInt32(CompraActual["IdCompra"]));

            //object ImpBase = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpBase)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
            //object ImpIVA = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpIVA)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
            //object TotalPagado = promowork_dataDataSet.Pagos.Compute("Sum(Importe)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));

            //if (Convert.IsDBNull(ImpBase))
            //{
            //    ImpBase = 0;
            //}

            //if (Convert.IsDBNull(ImpIVA))
            //{
            //    ImpIVA = 0;
            //}

            //if (Convert.IsDBNull(TotalPagado))
            //{
            //    TotalPagado = 0;
            //}

            decimal nTotalFactura = 0;
            decimal.TryParse(textBox1.Text, out nTotalFactura);
            decimal nTotalPagado = 0;
            decimal.TryParse(textBox2.Text, out nTotalPagado);

           // textBox1.Text = Convert.ToString(nTotalFactura);
           // textBox2.Text = Convert.ToString(nTotalPagado);
            textBox3.Text = Convert.ToString(nTotalFactura - nTotalPagado);


            if (nTotalFactura == nTotalPagado)
            {
                pagadaCheckEdit.CheckState = CheckState.Checked;
                toolStripButton1.Enabled = false;
            }
            else
            {
                pagadaCheckEdit.CheckState = CheckState.Unchecked;
                toolStripButton1.Enabled = true;
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
            CompraActual["CopiaFactura"] = null;
        }

       private void idProveedorComboBox_Validated(object sender, EventArgs e)
        {
            
            if (idProveedorComboBox.SelectedValue == null)
            {
                idProveedorComboBox.Text = "";
                // MessageBox.Show(Convert.ToString(idProveedorComboBox.SelectedValue));
            }
           DataRowView ProvActual = (DataRowView)proveedoresBindingSource.Current;

            if (!Convert.IsDBNull(ProvActual["CredProveedor"]))
            {
                fechaVctoDateTimePicker.Value = fechaFacturaDateTimePicker.Value.AddDays(Convert.ToInt32(ProvActual["CredProveedor"]));
                fechaPagoDateTimePicker.Value = fechaFacturaDateTimePicker.Value.AddDays(Convert.ToInt32(ProvActual["CredProveedor"]));
            }
            else
            {
                fechaVctoDateTimePicker.Value = fechaFacturaDateTimePicker.Value;
                fechaPagoDateTimePicker.Value = fechaFacturaDateTimePicker.Value;
            }
            if (!Convert.IsDBNull(ProvActual["IdFormaPago"]))
            {
                idFormaPagoComboBox.SelectedValue = Convert.ToInt32(ProvActual["IdFormaPago"]);
            }
            if (!Convert.IsDBNull(ProvActual["IdCuenta"]))
            {
                idCuentaComboBox.SelectedValue = Convert.ToInt32(ProvActual["IdCuenta"]);
            }
        }

       private void button4_Click(object sender, EventArgs e)
       {
           DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
           try
           {
               System.Diagnostics.Process.Start(Convert.ToString(CompraActual["CopiaFactura"]));
           }
           catch
           {
               MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
           
       }

       private void toolStripButton7_Click(object sender, EventArgs e)
       {
           DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
           
           try
           {
           this.Validate();
           this.pagosBindingSource.EndEdit();
           

           object ImpBase = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpBase)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object ImpIVA = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpIVA)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object ImpIRPF = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpIRPF)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object TotalPagado = promowork_dataDataSet.Pagos.Compute("Sum(Importe)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));

           if (Convert.IsDBNull(ImpBase))
           {
               ImpBase = 0;
           }

           if (Convert.IsDBNull(ImpIVA))
           {
               ImpIVA = 0;
           }

           if (Convert.IsDBNull(ImpIRPF))
           {
               ImpIRPF = 0;
           }

           if (Convert.IsDBNull(TotalPagado))
           {
               TotalPagado = 0;
           }

           decimal nTotalFactura = Convert.ToDecimal(ImpBase) + Convert.ToDecimal(ImpIVA) - Convert.ToDecimal(ImpIRPF);
           decimal nTotalPagado = Convert.ToDecimal(TotalPagado);

           textBox1.Text = Convert.ToString(nTotalFactura);
           textBox2.Text = Convert.ToString(nTotalPagado);
           textBox3.Text = Convert.ToString(nTotalFactura - nTotalPagado);


           if (nTotalFactura == nTotalPagado)
           {
               toolStripButton1.Enabled = false;
               CompraActual["Pagada"] = true;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);

           }
           else
           {
               toolStripButton1.Enabled = true;
               CompraActual["Pagada"] = false;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);
           }
/*
           if (nTotalFactura == nTotalPagado)
           {
               CompraActual["Pagada"] = true;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);

           }
           else
           {
               CompraActual["Pagada"] = false;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);
           }
           
           if (nTotalFactura >= nTotalPagado)
           {*/
          // MessageBox.Show("Antes de actualizar");
               this.Validate();
               this.pagosBindingSource.EndEdit();
               this.pagosTableAdapter.Update(promowork_dataDataSet.Pagos);
             //  MessageBox.Show("Despues de actualizar");
               if (pagosDataGridView.RowCount != 0)
               {
                   DataRowView PagoActual = (DataRowView)pagosBindingSource.Current;
                  // MessageBox.Show(Convert.ToString(PagoActual["IdOpeBanco"]));
                  queriesTableAdapter1.ActualizaSaldoAnterior(Convert.ToInt32(PagoActual["IdOpeBanco"]));
               }
          /* }
           else
           {
               MessageBox.Show("El Pago no puede ser superior a lo pendiente. No se salvaron los cambios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }*/
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               this.pagosTableAdapter.FillCompra(this.promowork_dataDataSet.Pagos, Convert.ToInt32(CompraActual["IdCompra"]));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.pagosTableAdapter.FillCompra(this.promowork_dataDataSet.Pagos, Convert.ToInt32(CompraActual["IdCompra"]));
               }

           }
          
       }

       private void toolStripButton14_Click(object sender, EventArgs e)
       {
           DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
           try
           {
           this.Validate();
           this.comprasDetBindingSource.EndEdit();

           

           object ImpBase = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpBase)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object ImpIVA = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpIVA)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object ImpIRPF = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpIRPF)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object TotalPagado = promowork_dataDataSet.Pagos.Compute("Sum(Importe)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));

           if (Convert.IsDBNull(ImpBase))
           {
               ImpBase = 0;
           }

           if (Convert.IsDBNull(ImpIVA))
           {
               ImpIVA = 0;
           }

           if (Convert.IsDBNull(ImpIRPF))
           {
               ImpIRPF = 0;
           }

           if (Convert.IsDBNull(TotalPagado))
           {
               TotalPagado = 0;
           }

           decimal nTotalFactura = Convert.ToDecimal(ImpBase) + Convert.ToDecimal(ImpIVA) - Convert.ToDecimal(ImpIRPF);
           decimal nTotalPagado = Convert.ToDecimal(TotalPagado);

           textBox1.Text = Convert.ToString(Math.Round(nTotalFactura,2));
           textBox2.Text = Convert.ToString(Math.Round(nTotalPagado,2));
           textBox3.Text = Convert.ToString(Math.Round(nTotalFactura - nTotalPagado,2));


           if (nTotalFactura == nTotalPagado)
           {
               toolStripButton1.Enabled = false;
               CompraActual["Pagada"] = true;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);
           }
           else
           {
               toolStripButton1.Enabled = true;
               CompraActual["Pagada"] = false;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);

           }
/*
           if (nTotalFactura == nTotalPagado)
           {
               CompraActual["Pagada"] = true;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);

           }
           else
           {
               CompraActual["Pagada"] = false;
               this.Validate();
               this.comprasCabBindingSource.EndEdit();
               this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);
           }*/
            
          // if (nTotalFactura >= nTotalPagado)
         //  {
               
               this.comprasDetTableAdapter.Update(promowork_dataDataSet.ComprasDet);
          /* }
           else
           {
               MessageBox.Show("El Total de la Fcatura no puedes ser Inferior a lo Cobrado. No se salvaron los cambios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }*/
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               this.comprasDetTableAdapter.FillbyCompra(this.promowork_dataDataSet.ComprasDet, Convert.ToInt32(CompraActual["IdCompra"]));
              
           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.comprasDetTableAdapter.FillbyCompra(this.promowork_dataDataSet.ComprasDet, Convert.ToInt32(CompraActual["IdCompra"]));
               }

           }
           
       }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {

           DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;

           object ImpBase = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpBase)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object ImpIVA = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpIVA)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object ImpIRPF = promowork_dataDataSet.ComprasDet.Compute("Sum(ImpIRPF)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
           object TotalPagado = promowork_dataDataSet.Pagos.Compute("Sum(Importe)", "IdCompra=" + Convert.ToString(CompraActual["IdCompra"]));
          
           if (Convert.IsDBNull(ImpBase))
           {
               ImpBase = 0;
           }

           if (Convert.IsDBNull(ImpIRPF))
           {
               ImpIRPF = 0;
           }

           if (Convert.IsDBNull(ImpIVA))
           {
               ImpIVA = 0;
           }

           if (Convert.IsDBNull(TotalPagado))
           {
               TotalPagado = 0;
           }

           decimal TotalFactura = Convert.ToDecimal(ImpBase) + Convert.ToDecimal(ImpIVA) - Convert.ToDecimal(ImpIRPF);

           
           // pagosBindingSource.AddNew();
            DataRowView opebanco = (DataRowView)pagosBindingSource.Current;
            opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            opebanco["fecha"] = DateTime.Today;
            opebanco["DesOperacion"] = idProveedorComboBox.Text + " Fra: " + facturaTextBox.Text;

           // MessageBox.Show(CompraActual["IdCuenta"].ToString());
            opebanco["IdCuenta"] = CompraActual["IdCuenta"];
            opebanco["IdCompra"] = CompraActual["IdCompra"];
            opebanco["IdFormaPago"] = CompraActual["IdFormaPago"];
            opebanco["Importe"] = TotalFactura - Convert.ToDecimal(TotalPagado);
            opebanco["EnCuenta"] = true;
            opebanco["TipoOpe"] = "Proveedores";
            opebanco["FechaOpe"] = DateTime.Now;
            opebanco["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;

            pagosDataGridView.Focus();
       }

       private void fechaVctoDateTimePicker_Validated(object sender, EventArgs e)
       {
           fechaPagoDateTimePicker.Value = fechaVctoDateTimePicker.Value;
       }

       private void radioButton1_CheckedChanged(object sender, EventArgs e)
       {
           if (radioButton1.Checked == true)
           {
               comprasCabBindingSource.Filter = null;
           }
       }

       private void radioButton2_CheckedChanged(object sender, EventArgs e)
       {
           if (radioButton2.Checked == true)
           {
               comprasCabBindingSource.Filter = "Pagada=false";
           }
       }

      
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
            DataRowView EmpresaActual = (DataRowView)empresasActualBindingSource.Current;
            byte MesEmpresa =Convert.ToByte(EmpresaActual["MesEmpresa"]);
            int AnoEmpresa = Convert.ToInt32(EmpresaActual["AnoEmpresa"]);
            DateTime fechaini = new DateTime(AnoEmpresa, MesEmpresa, 1);
            DateTime fechafin = new DateTime(AnoEmpresa, MesEmpresa, DateTime.DaysInMonth(AnoEmpresa, MesEmpresa));
            string Filtro="FechaPago>='"+ fechaini.ToShortDateString()+"' and FechaPago<='"+fechafin.ToShortDateString()+"'";
                comprasCabBindingSource.Filter = Filtro;
            }

            
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DataRowView obra = (DataRowView)obrasBindingSource.Current;
            DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
            comprasDetDataGridView.CurrentRow.Cells["IdObra"].Value = Convert.ToInt32(obra["IdObra"]);
            comprasDetDataGridView.CurrentRow.Cells["IdCompra"].Value = Convert.ToInt32(CompraActual["IdCompra"]);
            comprasDetDataGridView.Focus();

        }

       
        private void comprasDetDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            decimal ImpIVA = 0;
            decimal ImpBase = 0;
            decimal ImpIRPF = 0;
            decimal Total = 0;
            try{ImpIVA =Convert.ToDecimal(comprasDetDataGridView.CurrentRow.Cells["ImpIVA"].Value);} catch{}
            try { ImpBase = Convert.ToDecimal(comprasDetDataGridView.CurrentRow.Cells["ImpBase"].Value); } catch { }
            try{ImpIRPF =Convert.ToDecimal(comprasDetDataGridView.CurrentRow.Cells["ImpIRPF"].Value);} catch{}
             try{Total =Convert.ToDecimal(comprasDetDataGridView.CurrentRow.Cells["Total"].Value);} catch{}
            
            try
            {
                if (ImpIVA == 0 && ImpBase!= 0 && Total != 0)
                {
                    comprasDetDataGridView.CurrentRow.Cells["ImpIVA"].Value = Total - ImpBase;
                   // comprasDetDataGridView.CurrentRow.Cells["IVA"].Value =( Total - ImpBase )/ ImpBase * 100;
                }
            }
            catch { }
            CalculaTotalCompra();

        }

        private void fechaFacturaDateTimePicker_Validated(object sender, EventArgs e)
        {
            //fechaRecibDateTimePicker.Value = fechaFacturaDateTimePicker.Value;
             DataRowView ProvActual = (DataRowView)proveedoresBindingSource.Current;

                if (!Convert.IsDBNull(ProvActual["CredProveedor"]))
                {
                    fechaVctoDateTimePicker.Value = fechaFacturaDateTimePicker.Value.AddDays(Convert.ToInt32(ProvActual["CredProveedor"]));
                    fechaPagoDateTimePicker.Value = fechaFacturaDateTimePicker.Value.AddDays(Convert.ToInt32(ProvActual["CredProveedor"]));
                }
                else
                {
                    fechaVctoDateTimePicker.Value = fechaFacturaDateTimePicker.Value;
                    fechaPagoDateTimePicker.Value = fechaFacturaDateTimePicker.Value;
                }
            }

        private void comprasDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error de Formato",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.ShowDialog();
            this.proveedoresTableAdapter.FillByActivoEmpresa(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormasPago frm = new FormasPago();
            frm.ShowDialog();
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BancosCuentas frm = new BancosCuentas();
            frm.ShowDialog();
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            cuentasBancosBindingSource.Filter = "CtaEmpresa=true";
            //cuentasBancosBindingSource1.Filter = "CtaEmpresa=true";
            
        }


        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
           
                DataRow[] prov = promowork_dataDataSet.Proveedores.Select("desProveedor like '%" + textBox4.Text + "%'");
                
            string proveedores ="";
            try
            {
                proveedores = Convert.ToString(prov[0]["IdProveedor"]);
            }
            catch
            {}
                for (int i = 1; i < prov.Count(); i++)
                {
                    proveedores = proveedores + "," + Convert.ToString(prov[i]["IdProveedor"]);
                }
                string filtroImporte = "";
                try
                {
                    filtroImporte = "and importe=" + Convert.ToString(Convert.ToDecimal(textBox8.Text)).Replace(",", ".");
               }
            catch { }
                if (proveedores != "")
                {
                    comprasCabBindingSource.Filter = "IdProveedor in (" + proveedores + ") and ISNULL(factura,'') like '" + textBox5.Text + "%'" + filtroImporte;
                }
                else
                {
                    comprasCabBindingSource.Filter = "1=2";
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            comprasCabBindingSource.Filter = null;
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            
            DataRow[] prov = promowork_dataDataSet.Proveedores.Select("desProveedor like '%" + textBox4.Text + "%'");

            string proveedores = Convert.ToString(prov[0]["IdProveedor"]);
            for (int i = 1; i < prov.Count(); i++)
            {
                proveedores = proveedores + "," + Convert.ToString(prov[i]["IdProveedor"]);
            }
            string filtroImporte = "";
            try
            {
                filtroImporte = "and importe="+Convert.ToString(Convert.ToDecimal(textBox8.Text)).Replace(",", ".");
            }
            catch
            { }
            comprasCabBindingSource.Filter = "IdProveedor in (" + proveedores + ") and ISNULL(factura,'') like '%" + textBox5.Text + "%'" + filtroImporte;
            
        }

        private void textBox8_KeyUp(object sender, KeyEventArgs e)
        {
            
            DataRow[] prov = promowork_dataDataSet.Proveedores.Select("desProveedor like '%" + textBox4.Text + "%'");

            string proveedores = Convert.ToString(prov[0]["IdProveedor"]);
            for (int i = 1; i < prov.Count(); i++)
            {
                proveedores = proveedores + "," + Convert.ToString(prov[i]["IdProveedor"]);
            }
            string filtroImporte = "";
            try
            {
                filtroImporte = "and importe=" + Convert.ToString(Convert.ToDecimal(textBox8.Text)).Replace(",", ".");
           }
            catch
            { }

            comprasCabBindingSource.Filter = "IdProveedor in (" + proveedores + ") and ISNULL(factura,'') like '" + textBox5.Text + "%'" + filtroImporte; 
            
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            try
            {
                RptComprasDuplicadas frm = new RptComprasDuplicadas();
                frm.LoadParametros(Convert.ToDateTime(toolStripTextBox3.Text));
                frm.MdiParent = this.MdiParent;
                frm.Show();
            
            }
            catch
            {
                MessageBox.Show("Fecha Incorrecta.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        //private void pagosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    MessageBox.Show("Error de Formato");
        //}

        private void comprasCabDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!Convert.IsDBNull(this.comprasCabDataGridView.Rows[e.RowIndex].Cells["color"].Value))
            {
                e.CellStyle.ForeColor = Color.FromArgb(Convert.ToInt32(this.comprasCabDataGridView.Rows[e.RowIndex].Cells["color"].Value));
               // this.comprasCabDataGridView.ForeColor = Color.FromArgb(Convert.ToInt32(this.comprasCabDataGridView.CurrentRow.Cells["color"].Value));
            }
        }

       
        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            this.comprasCabDataGridView.CurrentRow.Cells["color"].Value = toolStripButton16.BackColor.ToArgb();
            this.comprasCabDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton16.BackColor;
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            this.comprasCabDataGridView.CurrentRow.Cells["color"].Value = toolStripButton17.BackColor.ToArgb();
            this.comprasCabDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton17.BackColor;
            
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            this.comprasCabDataGridView.CurrentRow.Cells["color"].Value = toolStripButton18.BackColor.ToArgb();
            this.comprasCabDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton18.BackColor;
            
        }

        private void Compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (promowork_dataDataSet.HasChanges() == true)
            {
               if(MessageBox.Show("Desea Salvar los Cambios?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
               {
                   comprasCabBindingNavigatorSaveItem_Click(null, null);
               
               }
                
            }
            promowork_dataDataSet.Clear();
           // this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comprasCabBindingSource.RemoveCurrent();
                
            }
        }

        private void previsionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = !previsionRadioButton.Checked;
        }

        private void pagosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error de Formato");
        }

        private void CalculaTotalCompra()
        {
            if (comprasCabBindingSource != null && comprasCabBindingSource.Count > 0)
            {
                var totales = ServicioComprasPoveedores.CalculaTotalesCompra(comprasDetBindingSource);

                if (totales != null)
                {
                    ((DataRowView)comprasCabBindingSource.Current)["ImpBase"] = totales.ImporteBase;
                    ((DataRowView)comprasCabBindingSource.Current)["ImpIva"] = totales.ImporteIVA;
                    ((DataRowView)comprasCabBindingSource.Current)["ImpIRPF"] = totales.ImporteIRPF;
                    ((DataRowView)comprasCabBindingSource.Current)["Importe"] = totales.ImporteTotal;
                }
            }
        }

        private void CalculaTotalPagado()
        {
            if (comprasCabBindingSource != null && comprasCabBindingSource.Count > 0)
            {
                decimal importePagado = ServicioComprasPoveedores.CalculaTotalPagado(pagosBindingSource);
                ((DataRowView)comprasCabBindingSource.Current)["ImpPagado"] = importePagado;
            }
        }

        private void comprasDetDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculaTotalCompra();
        }

        private void comprasDetDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculaTotalCompra();
        }

        private void pagosDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculaTotalPagado();
        }

        private void pagosDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculaTotalPagado();
        }

        private void pagosDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculaTotalPagado();
        }


       
    }
}
