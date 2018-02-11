using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Promowork
{
    public partial class frmCobros : Form
    {
        public frmCobros()
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
                        CobroActual["Factura"] = DBNull.Value;
                        CobroActual["FechaFactura"] = DBNull.Value;
                    }
                    else
                    {
                        //    //try
                        //    //{
                        //    //    CobroActual["IdFactCab"] = idFactCabComboBox.SelectedValue;
                        //    //}
                        //    //catch { }
                        //}

                        if (idFactCabComboBox.SelectedIndex != -1)
                        {
                            try
                            {
                                //int finfact = idFactCabComboBox.Text.IndexOf(" ");
                                //int inifecha = idFactCabComboBox.Text.LastIndexOf(" ");
                                //string factura = idFactCabComboBox.Text.Substring(0, finfact);
                                string todo = idFactCabComboBox.Text;
                                CobroActual["Factura"] = idFactCabComboBox.Text.Substring(0, idFactCabComboBox.Text.IndexOf(" ") + 1);
                                CobroActual["FechaFactura"] = idFactCabComboBox.Text.Substring(idFactCabComboBox.Text.IndexOf("-") - 4, 10);
                            }
                            catch 
                            {
                                MessageBox.Show("El cobro no pudo vincularse a la Factura. Intentelo otra vez", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }

                    ////facturasConCobrosBindingSource.AddNew();
                    ////DataRowView fcc = (DataRowView)facturasConCobrosBindingSource.Current;
                    ////fcc["IdFactCab"] = idFactCabComboBox.SelectedValue;
                    ////fcc["Factura"] = idFactCabComboBox.Text.Substring(0, idFactCabComboBox.Text.IndexOf(" ") + 1);
                    ////fcc["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
                    ////fcc["FechaFactura"] = idFactCabComboBox.Text.Substring(idFactCabComboBox.Text.IndexOf("-") - 4, 10);

                   
                    
                    ////gridView1.SetFocusedRowCellValue("IdFactCab", idFactCabComboBox.Text.Substring(0, idFactCabComboBox.Text.IndexOf(" ") + 1));

                    this.Validate();
                    this.cobrosBindingSource.EndEdit();
                    cobrosTableAdapter.Update(promowork_dataDataSet.Cobros);

                  //  facturasConCobrosTableAdapter.FillByAnoCobro(promowork_dataDataSet.FacturasConCobros, int.Parse(cbxAnosCobros.Text), VariablesGlobales.nIdEmpresaActual);

                    //DataRowView FacturaActual = (DataRowView)facturasCabListaBindingSource.Current;
                    //try
                    //{
                    //    if ((decimal)FacturaActual["ImpBase"] <= (decimal)CobroActual["ImpBase"])
                    //    {
                    //        queriesTableAdapter1.UpdateFacturasCabCobrada(true, (int)FacturaActual["IdFactCab"]);
                    //    }
                    //    else
                    //    {
                    //        queriesTableAdapter1.UpdateFacturasCabCobrada(false, (int)FacturaActual["IdFactCab"]);
                    //    }
                    //}
                    //catch { }
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

        private void frmCobros_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.facturasCabListaTableAdapter.Fill(promowork_dataDataSet.FacturasCabLista, 
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.FormasPago' Puede moverla o quitarla según sea necesario.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Obras' Puede moverla o quitarla según sea necesario.
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Cobros' Puede moverla o quitarla según sea necesario.

           // MessageBox.Show(VariablesGlobales.nAnoActual.ToString());
            this.cobrosTableAdapter.FillByAno(this.promowork_dataDataSet.Cobros, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual);

           // cobrosBindingSource.MoveLast();

            this.anosCobrosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.AnosCobros, VariablesGlobales.nIdEmpresaActual);

            foreach (DataRowView row in anosCobrosBindingSource)
            {
                cbxAnosCobros.Items.Add(row["AnoCobro"]);
            }
            cbxAnosCobros.SelectedItem = VariablesGlobales.nAnoActual;

            
            


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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           // MessageBox.Show(idObraComboBox.SelectedIndex.ToString());

            try
            {

            int nFactActual = 0;
            try
            {
                nFactActual = (int)gridView1.GetFocusedRowCellValue("IdFactCab");
            }
            catch { }


            if (idClienteComboBox.SelectedIndex != -1)
            {
                if (idObraComboBox.SelectedIndex != -1)
                {

                    this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, (int)idObraComboBox.SelectedValue, (int)idClienteComboBox.SelectedValue, nFactActual);
                    this.idFactCabComboBox.SelectedValue = nFactActual;

                }
                else
                {
                    this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, 0, (int)idClienteComboBox.SelectedValue, nFactActual);
                    this.idFactCabComboBox.SelectedValue = nFactActual;
                }
            }
            else
            {
                this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, 0, 0, 0);
            }
            }
            catch
            {}
            //    this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, 0, 0, 0);
            //}
        }


        private void idObraComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
            int nFactActual = 0;
            try
            {
                nFactActual = (int)gridView1.GetFocusedRowCellValue("IdFactCab");
            }
            catch { }


            if (idClienteComboBox.SelectedIndex != -1)
            {
                if (idObraComboBox.SelectedIndex != -1)
                {

                    this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, (int)idObraComboBox.SelectedValue, (int)idClienteComboBox.SelectedValue, nFactActual);
                    this.idFactCabComboBox.SelectedValue = nFactActual;

                }
                else
                {
                    this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, 0, (int)idClienteComboBox.SelectedValue, nFactActual);
                    this.idFactCabComboBox.SelectedValue = nFactActual;
                }
            }
            else
            {
               this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, 0, 0, 0);
            }
            }
            catch
            {}
            //    this.facturasCabListaTableAdapter.FillByObra(promowork_dataDataSet.FacturasCabLista, 0, 0, 0);
            //}
        }

       
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.cobrosBindingSource.RemoveCurrent();
            }
        }

        private void cbxAnosCobros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAnosCobros.SelectedIndex != -1)
            {
               // facturasConCobrosTableAdapter.FillByAnoCobro(promowork_dataDataSet.FacturasConCobros, int.Parse(cbxAnosCobros.Text), VariablesGlobales.nIdEmpresaActual);
                this.cobrosTableAdapter.FillByAno(this.promowork_dataDataSet.Cobros, VariablesGlobales.nIdEmpresaActual, int.Parse(cbxAnosCobros.Text));
                //promowork_dataDataSet.FacturasCab.Columns.Add("NomFact", typeof(string), "convert(varchar,NumeroFactura");
                //cobrosBindingSource.MoveLast();
            }
        }

        private void fechaExpDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fechaRecDateTimePicker.Value = fechaExpDateTimePicker.Value;
            fechaVctoDateTimePicker.Value = fechaExpDateTimePicker.Value;
            fechaAbonoDateTimePicker.Value = fechaExpDateTimePicker.Value;
        }

       
       
    }
}
