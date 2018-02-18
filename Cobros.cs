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
    public partial class Cobros : Form
    {
        public Cobros()
        {
            InitializeComponent();
        }

        private void cobrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          try
          {
              if (Convert.IsDBNull(impBaseTextBox.Text) || impBaseTextBox.Text == "" || Convert.ToDecimal(impBaseTextBox.Text) == 0)
              {

                  MessageBox.Show("El Importe Base tiene que ser mayor que cero (0)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
              }
              else
              {
                  DataRowView CobroActual = (DataRowView)cobrosBindingSource.Current;
                  if (idObraComboBox.Text == "")
                  {
                      CobroActual["IdObra"] = DBNull.Value;
                  }

                  if (idFactCabComboBox.Text == "")
                  {
                      CobroActual["IdFactCab"] = DBNull.Value;
                  }
                  else
                  {
                      try
                      {
                          CobroActual["IdFactCab"] = idFactCabComboBox.SelectedValue;
                      }
                      catch { }
                  }

                  if (idFactCabComboBox.Text != "")
                  {
                      int finfact=idFactCabComboBox.Text.IndexOf(" ");
                      int inifecha = idFactCabComboBox.Text.LastIndexOf(" ");
                      string factura = idFactCabComboBox.Text.Substring(0, finfact);
                      string fecha = idFactCabComboBox.Text.Substring(inifecha + 1);
                      CobroActual["Factura"] = factura;
                      CobroActual["FechaFactura"] = fecha;
                  }

                  this.Validate();
                  this.cobrosBindingSource.EndEdit();
                  cobrosTableAdapter.Update(promowork_dataDataSet.Cobros);


                  DataRowView FacturaActual = (DataRowView)facturasCabListaBindingSource.Current;
                  try
                  {
                      if ((decimal)FacturaActual["ImpBase"] <= (decimal)CobroActual["ImpBase"])
                      {
                          queriesTableAdapter1.UpdateFacturasCabCobrada(true, (int)FacturaActual["IdFactCab"]);
                      }
                      else
                      {
                          queriesTableAdapter1.UpdateFacturasCabCobrada(false, (int)FacturaActual["IdFactCab"]);
                      }
                  }
                  catch { }
              }
           }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cobrosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Cobros, VariablesGlobales.nIdEmpresaActual);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.cobrosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Cobros, VariablesGlobales.nIdEmpresaActual);
                }
                
            }

        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasCabLista' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasCab' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByListaObras(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            clientesBindingSource.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet1.CuentasBancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet1.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            // TODO: This line of code loads data into the 'promowork_dataDataSet1.FacturasCab' table. You can move, or remove it, as needed.
            this.cobrosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Cobros,VariablesGlobales.nIdEmpresaActual);
            cobrosBindingSource.MoveLast();
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRowView CobroActual = (DataRowView)cobrosBindingSource.Current;

            CobroActual["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            CobroActual["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            CobroActual["FechaExp"] = DateTime.Now;
            CobroActual["FechaRec"] = DateTime.Now;
            CobroActual["FechaAbono"] = DateTime.Now;
            CobroActual["FechaVcto"] = DateTime.Now;
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (idClienteComboBox.SelectedIndex != -1)
            {
                obrasBindingSource1.Filter = "IdCliente=" + Convert.ToString(idClienteComboBox.SelectedValue);


                try
                {
                    if (Convert.ToString(idObraComboBox.SelectedValue) == "")
                    {
                        facturasCabListaBindingSource.Filter = null;
                    }
                    else
                    {
                        facturasCabListaBindingSource.Filter = "IdObra=" + Convert.ToString(idObraComboBox.SelectedValue);
                    }
                }
                catch
                {
                    facturasCabListaBindingSource.Filter = "1=2";
                }

                try
                {
                   // facturasCabListaTableAdapter.Fill(promowork_dataDataSet.FacturasCabLista, (int)idClienteComboBox.SelectedValue);
                }
                catch { }
                try
                {
                    DataRowView CobroActual = (DataRowView)cobrosBindingSource.Current;
                    if (CobroActual["idfactcab"] == null)
                    {
                        idFactCabComboBox.Text = "";
                    }
                }
                catch { }
            }
        }

        
        private void fechaExpDateTimePicker_Validated(object sender, EventArgs e)
        {
            fechaRecDateTimePicker.Value = fechaExpDateTimePicker.Value;
            fechaVctoDateTimePicker.Value = fechaExpDateTimePicker.Value;
            fechaAbonoDateTimePicker.Value = fechaExpDateTimePicker.Value;
        }

       
        private void idFactCabComboBox_Leave(object sender, EventArgs e)
        {
            if (idFactCabComboBox.Text == "")
            {
               
                facturaTextBox.Enabled = true;
                fechaFacturaDateTimePicker.Enabled = true;

            }
            else
            {
                facturaTextBox.Enabled = false;
                fechaFacturaDateTimePicker.Enabled = false;
            }
        }

       
        private void idObraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                try
                {
                    facturasCabListaBindingSource.Filter = "IdObra=" + Convert.ToString(idObraComboBox.SelectedValue);
                      
               
                }
                catch
                {
                    facturasCabListaBindingSource.Filter = "1=2";
                }
            //try
            //{
            //    DataRowView CobroActual = (DataRowView)cobrosBindingSource.Current;
            //    if (CobroActual["idfactcab"] == null)
            //    {
            //        idFactCabComboBox.Text = "";
            //    }
            //}
            //catch{}
              
            
        }

        private void idFactCabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idFactCabComboBox.Text != "")
            {
              //  facturaTextBox.Text = "";
                facturaTextBox.Enabled = false;
               // fechaFacturaDateTimePicker.Text = "";
                fechaFacturaDateTimePicker.Enabled = false;
            }
            else
            {
                facturaTextBox.Enabled = true;
                fechaFacturaDateTimePicker.Enabled = true;
            }
            try
            {
                copiaFacturaTextBox.Text = Convert.ToString((promowork_dataDataSet.Tables["FacturasCabLista"].Rows[Convert.ToInt32(idFactCabComboBox.SelectedIndex)]["CopiaFactura"]));
            }
            catch { }
        }

       
        private void facturaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (facturaTextBox.Text != "")
            {
                DataRowView CobroActual = (DataRowView)cobrosBindingSource.Current;
                CobroActual["FechaFactura"] = DateTime.Now;
                idFactCabComboBox.Text = "";
                idFactCabComboBox.Enabled = false;
                
            }
            else
            {
                idFactCabComboBox.Enabled = true;
            }
        }

        private void cobrosDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            DataRowView CombroActual = (DataRowView)cobrosBindingSource.Current;
            CombroActual["CopiaFactura"] = openFileDialog1.FileName;
            copiaFacturaTextBox.Text = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRowView CombroActual = (DataRowView)cobrosBindingSource.Current;
            try
            {
                System.Diagnostics.Process.Start(Convert.ToString(CombroActual["CopiaFactura"]));
            }
            catch
            {
                MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView CombroActual = (DataRowView)cobrosBindingSource.Current;
            CombroActual["CopiaFactura"] = null;
            copiaFacturaTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView FacturaActual = (DataRowView)facturasCabListaBindingSource.Current;
            if (Convert.IsDBNull(FacturaActual["esPrevision"])==false)
            {
            RptFacturasManualImp frm = new RptFacturasManualImp();
            frm.LoadFiltro(Convert.ToInt32(idFactCabComboBox.SelectedValue));
            frm.MdiParent = this.MdiParent;
            frm.Show();
            }
            else
            {
                if ((Boolean)FacturaActual["EsFactura"] == true)
           {

               int Factura = Convert.ToInt32(FacturaActual["IdFactCab"]);


               RptFacturasHorasImp frm = new RptFacturasHorasImp();
               frm.LoadFiltro(Factura, false);
               frm.MdiParent = this.MdiParent;
               frm.Show();
           }
           else 
           {
               int Factura = Convert.ToInt32(FacturaActual["IdFactCab"]);


               RptFacturasHorasImpParte frm = new RptFacturasHorasImpParte();
               frm.LoadFiltro(Factura, false);
               frm.MdiParent = this.MdiParent;
               frm.Show();
           }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.cobrosBindingSource.RemoveCurrent();
            }
        }

        private void cobrosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
         //MessageBox.Show(e.Exception.Message);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRowView CobroActual = (DataRowView)cobrosBindingSource.Current;

           // MessageBox.Show(CobroActual["IdFactCab"].ToString());
           
            if (idFactCabComboBox.Text == "")
            {

                facturaTextBox.Enabled = true;
                fechaFacturaDateTimePicker.Enabled = true;

            }
            else
            {
                facturaTextBox.Enabled = false;
                fechaFacturaDateTimePicker.Enabled = false;
            }

            //if (facturaTextBox.Text != "")
            //{
            //    idFactCabComboBox.Text = "";
            //    idFactCabComboBox.Enabled = false;

            //}
            //else
            //{
            //    idFactCabComboBox.Enabled = true;
            //}
        }
    }
}
