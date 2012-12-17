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
    public partial class FacturasPresup : Form
    {
        public FacturasPresup()
        {
            InitializeComponent();
        }

        private void facturasCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(facturasCabDataGridView.CurrentRow.Cells["FacturaPresup"].Value) == true)
                {
                    DataRow PresupActual = promowork_dataDataSet.PresupCab.FindByIdPresupCab(Convert.ToInt32(idPresupComboBox.SelectedValue));
                    DataRowView FacturaActual = (DataRowView)facturasCabBindingSource.Current;
                    FacturaActual["IdObra"] = PresupActual["IdObra"];
                }

            this.Validate();
            this.facturasCabBindingSource.EndEdit();
            facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
          //  this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
         //   int posFactcab = facturasCabBindingSource.Position;
            int poscab = presupCabBindingSource.Position;
            int poscap = presupCapBindingSource1.Position;
            int posdet = presupDetBindingSource1.Position;
            int possub = presupSubBindingSource1.Position;
            
         //   this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual);
            this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
            this.presupSubTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupSub);
            this.presupDetTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupDet);
            this.presupCapTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupCap);

           // facturasCabBindingSource.Position = posFactcab;
            presupCabBindingSource.Position = poscab;
            presupCapBindingSource1.Position = poscap;
            presupDetBindingSource1.Position = posdet;
            presupSubBindingSource1.Position = possub;
            presupSubBindingSource1.Filter = "Pendiente>0";
            presupDetBindingSource1.Filter = "Pendiente>0";
                
                string sIdPresup=Convert.ToString(idPresupComboBox.SelectedValue==null?"0":Convert.ToString(idPresupComboBox.SelectedValue));
                
               // MessageBox.Show(sIdPresup);
                presupCapBindingSource1.Filter = "Pendiente>0 and IdPresupCab=" + sIdPresup;

            button1.Enabled = true;
            //toolStripButton1.Enabled = true;
           // toolStripButton12.Enabled = true;
            facturasCabDataGridView.Enabled = true;
            facturasCabDataGridView_CellEnter(null,null);
            }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,true);
              
           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,true);
               }

           }

        }

        private void FacturasPresup_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
           // this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Cobros' table. You can move, or remove it, as needed.
           // this.cobrosTableAdapter.Fill(this.promowork_dataDataSet.Cobros);
            
            this.presupSubTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupSub);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupDet' table. You can move, or remove it, as needed.
            this.presupDetTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupDet);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCap' table. You can move, or remove it, as needed.
            this.presupCapTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupCap);
            presupSubBindingSource1.Filter = "Pendiente>0";
            presupDetBindingSource1.Filter = "Pendiente>0";
           // presupCapBindingSource1.Filter = "Pendiente>0 and IdPresupCab=" + Convert.ToString(idPresupComboBox.SelectedValue);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.CuentasBancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.promowork_dataDataSet.Clientes);
            clientesBindingSource.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasDet' table. You can move, or remove it, as needed.
           // this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasCab' table. You can move, or remove it, as needed.
            this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab,VariablesGlobales.nIdEmpresaActual,true);
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
            factura["FacturaPresup"] = true;

            button1.Enabled = false;
           // toolStripButton1.Enabled = false;
          //  toolStripButton12.Enabled = false;
            facturasCabDataGridView.Enabled = false;
            numFacturaTextBox.Focus();
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                presupCabBindingSource.Filter = "IdCliente=" + Convert.ToString(idClienteComboBox.SelectedValue);
                DataRowView cliente = (DataRowView)clientesBindingSource.Current;
                fechaVctoFactDateTimePicker.Value = fechaFacturaDateTimePicker.Value.AddDays(Convert.ToInt32(cliente["CredCliente"]));
            }
            catch { }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            facturasCabDataGridView.Enabled = true;
        }

      
      private void facturasCabDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
       {

           try
           {

               if (Convert.ToBoolean(facturasCabDataGridView.CurrentRow.Cells["FacturaPresup"].Value) == true)
               {
                   facturasDetTableAdapter.FillByFactura(promowork_dataDataSet.FacturasDet, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
                 //  facturasCabBindingNavigatorSaveItem.Enabled = true;
               }
               else
               {
                   //this.facturasCabDataGridView.CurrentRow.Cells["Obras"].Value = null;
                   //this.facturasCabDataGridView.CurrentRow.Cells["Obras"] = null;
                  // facturasCabBindingNavigatorSaveItem.Enabled = false;
                   idPresupComboBox.Text = null;
                   idPresupComboBox.SelectedValue = null;
                   facturasDetTableAdapter.FillByFactura(promowork_dataDataSet.FacturasDet, 0);
               }
           }
           catch
           {
               facturasDetTableAdapter.FillByFactura(promowork_dataDataSet.FacturasDet, 0);
             //  facturasCabBindingNavigatorSaveItem.Enabled = true;
           }

           Boolean EsPresup = true;
           try
           { 
           EsPresup= Convert.ToBoolean(facturasCabDataGridView.CurrentRow.Cells["FacturaPresup"].Value);
           }
          catch
           {}

           if (facturasDetDataGridView.RowCount != 0 || !EsPresup)
           {
               idClienteComboBox.Enabled = false;
               idPresupComboBox.Enabled = false;
           }
           else
           {
               idClienteComboBox.Enabled = true;
               idPresupComboBox.Enabled = true;
           }

          
           try
           {
               presupCapBindingSource1.Filter = "Pendiente>0 and IdPresupCab=" + Convert.ToString(idPresupComboBox.SelectedValue);
           }
           catch {
               presupCapBindingSource1.Filter = "1<>1";
           }
           
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

           if (groupBox2.Visible == true)
           {
               DataRowView detActual = (DataRowView)presupDetBindingSource1.Current;
               decimal cantidad = 0;
               decimal precio = 0;
               try { cantidad = Convert.ToDecimal(detActual["Pendiente"]); }
               catch { }
               try { precio = Convert.ToDecimal(detActual["Precio"]); }
               catch { }
               try { textBox7.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
               catch { textBox7.Text = ""; }
               precioTextBox.Text = Convert.ToString(precio);
               umTextBox.Text = "";
               try { umTextBox.Text = Convert.ToString(detActual["UM"]); }
               catch { }

           }
           else
           {
               DataRowView subActual = (DataRowView)presupSubBindingSource1.Current;
               decimal cantidad = 0;
               decimal precio = 0;
               try { cantidad = Convert.ToDecimal(subActual["Pendiente"]); }
               catch { }
               try { precio = Convert.ToDecimal(subActual["Precio"]); }
               catch { }
               try { textBox8.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
               catch { textBox8.Text = ""; }
               precioTextBox.Text = Convert.ToString(precio);
               umTextBox.Text = "";
               try { umTextBox.Text = Convert.ToString(subActual["UM"]); }
               catch { }
           }
           
       }

       private void presupSubBindingSource1_ListChanged(object sender, ListChangedEventArgs e)
       {
           if (comboBox3.Items.Count != 0)
           {
            /*   precioTextBox.Text = textBox13.Text;
               umTextBox.Text = textBox9.Text;

               try
               {
                   textBox8.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox10.Text) / Convert.ToDecimal(textBox13.Text), 2));

               }
               catch { textBox8.Text = ""; }*/

               groupBox1.Visible = true;
               groupBox2.Visible = false;
           }
           else
           {
              /* precioTextBox.Text = textBox2.Text;
               umTextBox.Text = textBox6.Text;*/
               groupBox1.Visible = false;
               groupBox2.Visible = true;
           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
          
           decimal PreCantidad;
           decimal CantReal;
           try { CantReal = Convert.ToDecimal(cantidadTextBox.Text); }
           catch { CantReal = 0; }

           if (groupBox2.Visible == true)
           {
               try { PreCantidad = Convert.ToDecimal(textBox7.Text); }
               catch { PreCantidad = 0; }
           }
           else
           {
               try { PreCantidad = Convert.ToDecimal(textBox8.Text); }
               catch { PreCantidad = 0; }

           }
               if (CantReal > PreCantidad || CantReal<=0)
           {
               MessageBox.Show("La Cantidad tiene que ser Superior que cero e Inferior a lo Pendiente (" + Convert.ToString(PreCantidad) + ")", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               cantidadTextBox.Text = Convert.ToString(PreCantidad);
               decimal cantidad;
               decimal precio;
               try { cantidad = Convert.ToDecimal(cantidadTextBox.Text); }
               catch { cantidad = 0; }
               try { precio = Convert.ToDecimal(precioTextBox.Text); }
               catch { precio = 0; }
               importeTextBox.Text = Convert.ToString(Math.Round(cantidad * precio, 2));
              

           }
           else
           {
                   try
                   {
               facturasDetBindingSource.AddNew();
               DataRowView DetNuevo = (DataRowView)facturasDetBindingSource.Current;
               DetNuevo["IdPresupCap"] = comboBox1.SelectedValue;
               DetNuevo["IdPresupDet"] = comboBox2.SelectedValue;
               try { DetNuevo["IdPresupSub"] = comboBox3.SelectedValue; }
               catch { }
               DetNuevo["UM"] = umTextBox.Text;
               DetNuevo["Cantidad"] = Convert.ToDecimal(cantidadTextBox.Text);
               DetNuevo["Precio"] = Convert.ToDecimal(precioTextBox.Text);
               //DetNuevo["Importe"] = Convert.ToDecimal(precioTextBox.Text) * Convert.ToDecimal(cantidadTextBox.Text);

               int posFactcab = facturasCabBindingSource.Position;
               int poscab = presupCabBindingSource.Position;
               int poscap = presupCapBindingSource1.Position;
               int posdet = presupDetBindingSource1.Position;
               int possub = presupSubBindingSource1.Position;

               this.Validate();
               facturasDetBindingSource.EndEdit();
               facturasDetTableAdapter.Update(promowork_dataDataSet.FacturasDet);

               this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,true);
               this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
               this.presupSubTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupSub);
               this.presupDetTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupDet);
               this.presupCapTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupCap);

                    
               facturasCabBindingSource.Position = posFactcab;
               presupCabBindingSource.Position = poscab;
               presupCapBindingSource1.Position = poscap;
               presupDetBindingSource1.Position = posdet;
               presupSubBindingSource1.Position = possub;
               presupSubBindingSource1.Filter = "Pendiente>0";
               presupDetBindingSource1.Filter = "Pendiente>0";
               presupCapBindingSource1.Filter = "Pendiente>0 and IdPresupCab=" + Convert.ToString(idPresupComboBox.SelectedValue);

               cantidadTextBox.Text = "";
               importeTextBox.Text = "";
               
               idClienteComboBox.Enabled = false;
               idPresupComboBox.Enabled = false;
               
                       DataRow PresupActual = promowork_dataDataSet.PresupCab.FindByIdPresupCab(Convert.ToInt32(idPresupComboBox.SelectedValue));
               if (Convert.ToDecimal(PresupActual["Pendiente"]) == 0)
               {
                   PresupActual["Facturado"] = true;

               }
               this.Validate();
               this.presupCabBindingSource.EndEdit();
               this.presupCabTableAdapter.Update(PresupActual);
               if (Convert.ToDecimal(textBox19.Text) == 0)
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
               this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
              
           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
               }

           }
             
           }
               if (groupBox2.Visible == true)
               {
                   DataRowView detActual = (DataRowView)presupDetBindingSource1.Current;
                   decimal cantidad = 0;
                   decimal precio = 0;
                   try { cantidad = Convert.ToDecimal(detActual["Pendiente"]); }
                   catch { }
                   try { precio = Convert.ToDecimal(detActual["Precio"]); }
                   catch { }
                   try { textBox7.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
                   catch { textBox7.Text = ""; }
                   precioTextBox.Text = Convert.ToString(precio);
                   umTextBox.Text = "";
                   try { umTextBox.Text = Convert.ToString(detActual["UM"]); }
                   catch { }

               }
               else
               {
                   DataRowView subActual = (DataRowView)presupSubBindingSource1.Current;
                   decimal cantidad = 0;
                   decimal precio = 0;
                   try { cantidad = Convert.ToDecimal(subActual["Pendiente"]); }
                   catch { }
                   try { precio = Convert.ToDecimal(subActual["Precio"]); }
                   catch { }
                   try { textBox8.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
                   catch { textBox8.Text = ""; }
                   precioTextBox.Text = Convert.ToString(precio);
                   umTextBox.Text = "";
                   try { umTextBox.Text = Convert.ToString(subActual["UM"]); }
                   catch { }
               }
               facturasDetBindingSource.MoveLast();

       }

       private void cantidadTextBox_KeyUp(object sender, KeyEventArgs e)
       {
           decimal cantidad;
           decimal precio;
           try { cantidad = Convert.ToDecimal(cantidadTextBox.Text); }
           catch { cantidad = 0; }
           try { precio = Convert.ToDecimal(precioTextBox.Text); }
           catch { precio = 0; }
           importeTextBox.Text =Convert.ToString(Math.Round(cantidad * precio,2));
       }

       private void toolStripButton2_Click(object sender, EventArgs e)
       {
           try
           {
           int posFactcab = facturasCabBindingSource.Position;
           int poscab = presupCabBindingSource.Position;
           int poscap = presupCapBindingSource1.Position;
           int posdet = presupDetBindingSource1.Position;
           int possub = presupSubBindingSource1.Position;

           this.Validate();
           facturasDetBindingSource.EndEdit();
           facturasDetTableAdapter.Update(promowork_dataDataSet.FacturasDet);

           this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,true);
           this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
           this.presupSubTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupSub);
           this.presupDetTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupDet);
           this.presupCapTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupCap);

               
           facturasCabBindingSource.Position = posFactcab;
           presupCabBindingSource.Position = poscab;
           presupCapBindingSource1.Position = poscap;
           presupDetBindingSource1.Position = posdet;
           presupSubBindingSource1.Position = possub;
           presupSubBindingSource1.Filter = "Pendiente>0";
           presupDetBindingSource1.Filter = "Pendiente>0";
           presupCapBindingSource1.Filter = "Pendiente>0 and IdPresupCab=" + Convert.ToString(idPresupComboBox.SelectedValue);

           if (facturasDetDataGridView.RowCount != 0)
           {
               idClienteComboBox.Enabled = false;
               idPresupComboBox.Enabled = false;
           }
           else
           {
               idClienteComboBox.Enabled = true;
               idPresupComboBox.Enabled = true;
           }
           DataRow PresupActual = promowork_dataDataSet.PresupCab.FindByIdPresupCab(Convert.ToInt32(idPresupComboBox.SelectedValue));
           if (Convert.ToDecimal(PresupActual["Pendiente"]) != 0)
           {
               PresupActual["Facturado"] = false;

           }
           this.Validate();
           this.presupCabBindingSource.EndEdit();
           this.presupCabTableAdapter.Update(PresupActual);

           if (Convert.ToDecimal(textBox19.Text) == 0)
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
               this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
               }

           }
       }


       private void idPresupComboBox_Enter(object sender, EventArgs e)
       {
           try
           {
               presupCabBindingSource.Filter = "Pendiente>0 and IdCliente=" + Convert.ToString(idClienteComboBox.SelectedValue);
           }
           catch { }
       }

       private void idPresupComboBox_Leave(object sender, EventArgs e)
       {
           try
           {
           presupCabBindingSource.Filter ="IdCliente=" + Convert.ToString(idClienteComboBox.SelectedValue);
           }
           catch { }
       }
      

       private void presupDetBindingSource1_PositionChanged(object sender, EventArgs e)
       {
           if (groupBox2.Visible == true)
           {
               DataRowView detActual = (DataRowView)presupDetBindingSource1.Current;
               decimal cantidad = 0;
               decimal precio = 0;
               try { cantidad = Convert.ToDecimal(detActual["Pendiente"]); }
               catch { }
               try { precio = Convert.ToDecimal(detActual["Precio"]); }
               catch { }
               try { textBox7.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
               catch { textBox7.Text = ""; }
               precioTextBox.Text = Convert.ToString(precio);
               umTextBox.Text = "";
               try { umTextBox.Text = Convert.ToString(detActual["UM"]); }
               catch { }

           }
           else
           {
               DataRowView subActual = (DataRowView)presupSubBindingSource1.Current;
               decimal cantidad = 0;
               decimal precio = 0;
               try { cantidad = Convert.ToDecimal(subActual["Pendiente"]); }
               catch { }
               try { precio = Convert.ToDecimal(subActual["Precio"]); }
               catch { }
               try { textBox8.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
               catch { textBox8.Text = ""; }
               precioTextBox.Text = Convert.ToString(precio);
               umTextBox.Text = "";
               try { umTextBox.Text = Convert.ToString(subActual["UM"]); }
               catch { }
           }
           facturasCabDataGridView_CellEnter(null, null);
       }

       private void presupSubBindingSource1_PositionChanged(object sender, EventArgs e)
       {

           if (groupBox2.Visible == true)
           {
               DataRowView detActual = (DataRowView)presupDetBindingSource1.Current;
               decimal cantidad = 0;
               decimal precio = 0;
               try { cantidad = Convert.ToDecimal(detActual["Pendiente"]); }
               catch { }
               try { precio = Convert.ToDecimal(detActual["Precio"]); }
               catch { }
               try { textBox7.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
               catch { textBox7.Text = ""; }
               precioTextBox.Text = Convert.ToString(precio);
               umTextBox.Text = "";
               try { umTextBox.Text = Convert.ToString(detActual["UM"]); }
               catch { }

           }
           else
           {
               DataRowView subActual = (DataRowView)presupSubBindingSource1.Current;
               decimal cantidad = 0;
               decimal precio = 0;
               try { cantidad = Convert.ToDecimal(subActual["Pendiente"]); }
               catch { }
               try { precio = Convert.ToDecimal(subActual["Precio"]); }
               catch { }
               try { textBox8.Text = Convert.ToString(Math.Round(cantidad / precio, 2)); }
               catch { textBox8.Text = ""; }
               precioTextBox.Text = Convert.ToString(precio);
               umTextBox.Text = "";
               try { umTextBox.Text = Convert.ToString(subActual["UM"]); }
               catch { }
           }
           facturasCabDataGridView_CellEnter(null, null);
         
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
                     this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,true);

                 }
                 catch (SqlException ex)
                 {
                     if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                     {
                         this.facturasCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual,true);
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

       private void cobrosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
       }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {
        //   cobrosDataGridView.CurrentRow.Cells["Cuenta"].Value=idCuentaComboBox.SelectedValue;
        //   cobrosDataGridView.CurrentRow.Cells["Fecha"].Value=DateTime.Now;
       //    cobrosDataGridView.CurrentRow.Cells["ImpBase"].Value=textBox19.Text;
       //    cobrosDataGridView.CurrentRow.Cells["IdUsuario"].Value = VariablesGlobales.nIdUsuarioActual;
       //    cobrosDataGridView.Focus();

        
       }

       private void printToolStripButton_Click(object sender, EventArgs e)
       {
           DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

           int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


           RptFacturasPresupImp frm = new RptFacturasPresupImp();
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

       private void textBox4_TextChanged(object sender, EventArgs e)
       {
            try {textBox4.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox4.Text), 2));}
           catch { }
       }

       private void textBox3_TextChanged(object sender, EventArgs e)
       {
            try {textBox3.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox3.Text), 2));}
           catch { }
       }

       private void textBox5_TextChanged(object sender, EventArgs e)
       {
           try { textBox5.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox5.Text), 2)); }
           catch { }
       }

       private void textBox11_TextChanged(object sender, EventArgs e)
       {
           try { textBox11.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox11.Text), 2)); }
           catch { }
       }

       private void textBox12_TextChanged(object sender, EventArgs e)
       {
           try { textBox12.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox12.Text), 2)); }
           catch { }
       }

       private void textBox10_TextChanged(object sender, EventArgs e)
       {
           try { textBox10.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox10.Text), 2)); }
           catch { }
       }

       private void facturasDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
       }

       private void presupCapBindingSource1_PositionChanged(object sender, EventArgs e)
       {
           facturasCabDataGridView_CellEnter(null, null);
       }

       private void facturasCabDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
       {
           e.CellStyle.BackColor = Convert.ToBoolean(facturasCabDataGridView.Rows[e.RowIndex].Cells["FacturaPresup"].Value) == false ? Color.LightGray : Color.White;
        }

      
    }
}
