using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Promowork
{
    public partial class frmCompras: Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        int vCompra=0;
        int vProveedor=0;
        int? vObra=0;
        int vDiasCredito=0;
        int vAlbaran = 0;
        int? vMesFactura = null;
        int? vAnoFactura = null;

        private void frmCompras_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            this.vObrasTableAdapter.FillByEmpresa(promowork_dataDataSet.vObras, VariablesGlobales.nIdEmpresaActual);
            this.vProveedoresTableAdapter.FillByEmpresa(promowork_dataDataSet.vProveedores, VariablesGlobales.nIdEmpresaActual);
            this.vCuentasBancosTableAdapter.FillByEmpresaCtaEmpresa(promowork_dataDataSet.vCuentasBancos, VariablesGlobales.nIdEmpresaActual, true);
            this.anosComprasTableAdapter.FillByEmpresa(promowork_dataDataSet.AnosCompras, VariablesGlobales.nIdEmpresaActual);
            foreach (DataRowView nAno in anosComprasBindingSource)
            {
                tbcbAnos.Items.Add(nAno["Ano"]);
            }
            tbcbAnos.SelectedItem = VariablesGlobales.nAnoActual;


            foreach (var item in Enum.GetValues(typeof(EnumCargaFacturas)))
            {

                ComboBoxItem cbitem= new ComboBoxItem();
                cbitem.Name=((EnumCargaFacturas)item).GetDescription();;
                cbitem.Value=(int)item;;

                tbcbCargarCompras.Items.Add(cbitem);
            }
            tbcbCargarCompras.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(EnumCargaAlbaranes)))
            {

                ComboBoxItem cbitem = new ComboBoxItem();
                cbitem.Name = ((EnumCargaAlbaranes)item).GetDescription(); 
                cbitem.Value = (int)item; 

               tbcbCargaAlbaranes.Items.Add(cbitem);
            }
            tbcbCargaAlbaranes.SelectedIndex = 0;

            foreach (DataRowView obra in vObrasBindingSource)
            { 
                ComboBoxItem cbitem = new ComboBoxItem();


                cbitem.Name = obra["NumeroSerieDesObraSM"].ToString();
                cbitem.Value = obra["IdObra"].ToString(); 

               tbcbObras.Items.Add(cbitem);

            }

        }


        private void tbcbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaComprasCab();
        }

        private void tbcbCargarCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaComprasCab();
        }

        private void CargaComprasCab()
        {

            if (tbcbAnos.SelectedIndex != -1 && tbcbCargarCompras.SelectedIndex != -1)
            {
                Cursor.Current = Cursors.WaitCursor;
                switch ((int)((ComboBoxItem)tbcbCargarCompras.SelectedItem).Value)
                {
                    case 1: //Pendientes de Pago
                        this.comprasCabTableAdapter.FillByPendientePago(this.promowork_dataDataSet.ComprasCab, VariablesGlobales.nIdEmpresaActual, (int)tbcbAnos.SelectedItem);
                        break;
                    case 2: //Pagadas
                        this.comprasCabTableAdapter.FillByPagado(this.promowork_dataDataSet.ComprasCab, VariablesGlobales.nIdEmpresaActual, (int)tbcbAnos.SelectedItem);
                        break;
                    case 3: //Todas
                        this.comprasCabTableAdapter.FillByEmpresaAno(this.promowork_dataDataSet.ComprasCab, VariablesGlobales.nIdEmpresaActual, (int)tbcbAnos.SelectedItem);
                        break;

                }
                tbcbObras.SelectedIndex = -1;
                Cursor.Current = Cursors.Default;
            }
            
        }


        private void gvComprasCab_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ActualizaIdCompra(e.FocusedRowHandle);
        }

        private void ActualizaIdCompra(int rowIndex )
        {
            if (!gvComprasCab.IsFilterRow(rowIndex) && rowIndex >= 0)
            {
                int.TryParse(gvComprasCab.GetFocusedRowCellValue(colIdCompra).ToString(), out vCompra);
                int.TryParse(gvComprasCab.GetFocusedRowCellValue(colidProveedor).ToString(), out vProveedor);
            }
            else
            {
                vCompra = 0;
                vProveedor = 0;
            }

            CargaComprasDet();
            CargaAlbaranesCompra();
            CargaAlbaranesProveedores();

            HabilitaDeshabilitaBotones(vCompra <= 0 ? false : true);
        }

        private void gvComprasDet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ////////ESTA COMENTADO, PORQUE SE CARGARAN LOS ALBARANES DE TODAS LAS OBRAS
            //try
            //{
            //    vObra = gvComprasDet.IsFilterRow(e.FocusedRowHandle) || e.FocusedRowHandle < 0 ? null : (int?)gvComprasDet.GetFocusedRowCellValue(colIdObraCompraDet);
            //   // HabilitaDeshabilitaBotones(vCompra <= 0 ? false : true);
               
            //}
            //catch
            //{
            //    vObra = null;
            //}
            //CargaAlbaranesProveedores();
        }


        private void CargaComprasDet()
        {
            try
            {
                this.comprasDetTableAdapter.FillbyCompra(promowork_dataDataSet.ComprasDet, vCompra);
                this.pagosTableAdapter.FillCompra(promowork_dataDataSet.Pagos, vCompra);
            }
            catch { }

        
        }

        private void tbbtSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.comprasCabBindingSource.EndEdit();
                this.comprasDetBindingSource.EndEdit();
                this.pagosBindingSource.EndEdit();

                this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);
                this.comprasDetTableAdapter.Update(promowork_dataDataSet.ComprasDet);
                this.pagosTableAdapter.Update(promowork_dataDataSet.Pagos);

                gvComprasCab.SetFocusedRowCellValue(colImpBase, colImpBaseCompraDet.SummaryItem.SummaryValue);
                gvComprasCab.SetFocusedRowCellValue(colImpPagado, colImportePagado.SummaryItem.SummaryValue);

                this.Validate();
                this.comprasCabBindingSource.EndEdit();
                this.comprasDetBindingSource.EndEdit();

                this.comprasCabTableAdapter.Update(promowork_dataDataSet.ComprasCab);
                this.comprasDetTableAdapter.Update(promowork_dataDataSet.ComprasDet);

                ActualizaIdCompra(gvComprasCab.FocusedRowHandle);

            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                CargaComprasCab();
               
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    CargaComprasCab();
                }

            }
        }

        private void tbbtAdd_Click(object sender, EventArgs e)
        {
            object proveedor = DBNull.Value;
            object fechaFactura = DBNull.Value;
            object fechaRecib = DBNull.Value;
            object formaPago = DBNull.Value;
            object cuenta = DBNull.Value;


            if (comprasCabBindingSource.Count > 0)
            {
                DataRowView compra = (DataRowView)comprasCabBindingSource.Current;
                proveedor = compra["IdProveedor"];
                fechaFactura = compra["FechaFactura"];
                fechaRecib = compra["FechaRecib"];
                //var fechaVcto = compra["FechaVcto"];
                formaPago = compra["IdFormaPago"];
                cuenta = compra["IdCuenta"];
            }

            comprasCabBindingSource.AddNew();
            DataRowView compraNueva = (DataRowView)comprasCabBindingSource.Current;
            compraNueva["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            compraNueva["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            compraNueva["IdProveedor"] = proveedor;
            compraNueva["FechaFactura"] = fechaFactura;
            compraNueva["FechaRecib"] = fechaRecib;
            //compraNueva["FechaVcto"] = fechaVcto;
            compraNueva["IdFormaPago"] = formaPago;
            compraNueva["IdCuenta"] = cuenta;

            compraNueva["Pagada"] = false;
            compraNueva["FacturaPendiente"] = false;
            compraNueva["FacturaDirecta"] = false;


           // comprasCabBindingSource.MoveLast();
            //gvComprasCab.MoveLast();
            gvComprasCab.Focus();
            cbProveedores.Focus();
            //gvComprasCab.OptionsBehavior.Editable = false;
            ActualizaFechaVencimiento();
        }

        private void ActualizaFechaVencimiento()
        {
            if (!string.IsNullOrWhiteSpace(fechaFacturaDateEdit.Text))
            {
                fechaRecibDateEdit.EditValue = fechaFacturaDateEdit.EditValue;
                fechaVctoDateEdit.EditValue = ((DateTime)fechaFacturaDateEdit.EditValue).AddDays(vDiasCredito);
                fechaPagoDateEdit.EditValue = ((DateTime)fechaFacturaDateEdit.EditValue).AddDays(vDiasCredito);
            }
        }

        private void tbbtDelete_Click(object sender, EventArgs e)
        {
            if (gvAlbaranesCompra.RowCount > 0 || gvPagos.RowCount > 0)
            {
                MessageBox.Show("Debe eliminar los Albaranes y Pagos vinculados a esta factura, para poder eliminarla", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (gvPagos.RowCount > 0)
            //{
            //    MessageBox.Show("Debe eliminar los Pagos vinculados a esta factura, para poder eliminarla", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comprasCabBindingSource.RemoveCurrent();

            }
        }

        private void CargaAlbaranesCompra()
        {
            this.albaranesCabTableAdapter.FillByCompra(this.datosAlbaranes.AlbaranesCab, vCompra);
        }

        private void CargaAlbaranesProveedores()
        {
            if (tbcbCargaAlbaranes.SelectedIndex != -1)
            {
                switch ((int)((ComboBoxItem)tbcbCargaAlbaranes.SelectedItem).Value)
                {
                    case 1: //Solo Alabaranes del período de la factura
                        this.albaranesCabProveedoresTableAdapter.FillByProveedorObraMes(this.datosAlbaranesProveedor.AlbaranesCab, vProveedor, null, vMesFactura, vAnoFactura);
                        break;
                    case 2: //Todos los Albaranes pendientes
                        this.albaranesCabProveedoresTableAdapter.FillByProveedorObra(this.datosAlbaranesProveedor.AlbaranesCab, vProveedor, null);
                        break;
                }
            }
        }

        private void cbProveedores_EditValueChanged(object sender, EventArgs e)
        {
            if (cbProveedores.ItemIndex!=-1)
            {
                vProveedor = (int)cbProveedores.EditValue;
                
                CargaAlbaranesProveedores();
            }
        }

        private void Obras_EditValueChanged(object sender, EventArgs e)
        {
            ////////ESTA COMENTADO, PORQUE SE CARGARAN LOS ALBARANES DE TODAS LAS OBRAS
            //LookUpEdit cbObras = (LookUpEdit)sender;
            //if (cbObras.ItemIndex != -1)
            //{
            //    vObra = (int)cbObras.EditValue;
            //    CargaAlbaranesProveedores();
            //}
        }

        private void tbbtAddDet_Click(object sender, EventArgs e)
        {
            DataRowView compraDet = (DataRowView)comprasDetBindingSource.Current;
            compraDet["IdCompra"] = vCompra;
        }

        private void tbbtDeleteDet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comprasDetBindingSource.RemoveCurrent();

            }
        }

        private void cbProveedores_Validated(object sender, EventArgs e)
        {
            var proveedor = (DataRowView)cbProveedores.GetSelectedDataRow();
            int.TryParse(proveedor["CredProveedor"].ToString(), out vDiasCredito);

            int vFormaPago = 0;
            int vCuenta = 0;

            int.TryParse(proveedor["IdFormaPago"].ToString(), out vFormaPago);
            int.TryParse(proveedor["IdCuenta"].ToString(), out vCuenta);

            ActualizaFechaVencimiento();

            cbFormaPago.EditValue = vFormaPago;
            cbCuenta.EditValue = vCuenta;
        }

        private void fechaFacturaDateEdit_Validated(object sender, EventArgs e)
        {
            ActualizaFechaVencimiento();

            if ((int)((ComboBoxItem)tbcbCargaAlbaranes.SelectedItem).Value ==  1)   //Si se cargan solo los albaranes del mismo período
            {
                CargaAlbaranesProveedores();
            }
        }

        private void gvAlbaranesProveedorObra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void CargaDetalleAlbaran()
        {
            this.vImportarAlbaranesDetTableAdapter.FillByAlbaran(this.datosAlbaranes.vImportarAlbaranesDet, vAlbaran);
        }

        private void fechaFacturaDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fechaFacturaDateEdit.Text))
            {
                vMesFactura = ((DateTime)fechaFacturaDateEdit.EditValue).Month;
                vAnoFactura = ((DateTime)fechaFacturaDateEdit.EditValue).Year;
            }
            else
            {
                vMesFactura = null;
                vAnoFactura = null;
            }
        }

        private void tbcbCargaAlbaranes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaAlbaranesProveedores();
        }

        private void AsociarAFactura_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gvAlbaranesProveedorObra.SetFocusedRowCellValue(colIdCompra, vCompra);
            gvAlbaranesProveedorObra.SetFocusedRowCellValue(colModificaImporteCompra, chkAutocalcular.Checked);

            this.Validate();
            this.albaranesCabProveedoresBindingSource.EndEdit();

            int obra= (int) gvAlbaranesProveedorObra.GetFocusedRowCellValue(colIdObraAlbaranProveedor);
            decimal importe=(decimal)gvAlbaranesProveedorObra.GetFocusedRowCellValue(colImporteAlbaranProveedor);
            
            this.albaranesCabProveedoresTableAdapter.Update(datosAlbaranesProveedor.AlbaranesCab);
            
            AgregarImporteAlbaranCompra(obra, importe);

            CargaAlbaranesCompra();
            CargaAlbaranesProveedores();
            gvComprasDet.UpdateTotalSummary();
            

        }

        private void QuitarAsociacion_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int obra = (int)gvAlbaranesCompra.GetFocusedRowCellValue(colIdObraAlbaranCompra);
            decimal importe = (decimal)gvAlbaranesCompra.GetFocusedRowCellValue(colImporteAlbaranCompra);

            QuitarAlbaranCompra(obra, importe);
           
            gvAlbaranesCompra.SetFocusedRowCellValue(colIdCompra, null);
            gvAlbaranesCompra.SetFocusedRowCellValue(colModificaImporteCompraAlbProv, null);

            this.Validate();
            this.albaranesCabBindingSource.EndEdit();
            this.albaranesCabTableAdapter.Update(datosAlbaranes.AlbaranesCab);

            
            CargaAlbaranesCompra();
            CargaAlbaranesProveedores();
            gvComprasDet.UpdateTotalSummary();
        }

        private void AgregarImporteAlbaranCompra(int pObra, decimal pImporte)
        {
            if (chkAutocalcular.CheckState == CheckState.Checked)
            {
                bool actualizado = false;
                decimal ivaAplicar = 0;
                decimal.TryParse(tbIVA.Text, out ivaAplicar);
                for (int i = 0; i < gvComprasDet.RowCount; i++)
                {
                    var obra = gvComprasDet.GetRowCellValue(i, colIdObraCompraDet);
                    if ((int)obra == pObra)
                    {

                        decimal impBase = gvComprasDet.GetRowCellValue(i, colImpBaseCompraDet) == DBNull.Value ? 0 : (decimal)gvComprasDet.GetRowCellValue(i, colImpBaseCompraDet);
                        decimal iva = gvComprasDet.GetRowCellValue(i, colIVACompraDet) == DBNull.Value ? ivaAplicar : (decimal)gvComprasDet.GetRowCellValue(i, colIVACompraDet);

                        gvComprasDet.SetRowCellValue(i, colImpBaseCompraDet, impBase + pImporte);
                        gvComprasDet.SetRowCellValue(i, colImpIvaCompraDet, Math.Round(((impBase + pImporte) * iva / 100), 2));

                        actualizado = true;
                    }
                }

                if (actualizado == false)
                {
                    gvComprasDet.AddNewRow();
                    gvComprasDet.SetFocusedRowCellValue(colIdCompraCompraDet, vCompra);
                    gvComprasDet.SetFocusedRowCellValue(colIdObraCompraDet, pObra);
                    gvComprasDet.SetFocusedRowCellValue(colImpBaseCompraDet, pImporte);
                    gvComprasDet.SetFocusedRowCellValue(colIVACompraDet, ivaAplicar);
                    gvComprasDet.SetFocusedRowCellValue(colImpIvaCompraDet, pImporte*ivaAplicar/100); 
                }
                this.Validate();
                this.comprasDetBindingSource.EndEdit();
            }
        
        }

        private void QuitarAlbaranCompra(int pObra, decimal pImporte)
        {
            bool modificaImporte = (bool)gvAlbaranesCompra.GetFocusedRowCellValue(colModificaImporteCompra);
            //modificaImporte = bool.TryParse(gvAlbaranesCompra.GetFocusedRowCellValue(colModificaImporteCompra).ToString(), out modificaImporte);
            if (modificaImporte==true)
            {
                for (int i = 0; i < gvComprasDet.RowCount; i++)
                {
                    var obra = gvComprasDet.GetRowCellValue(i, colIdObraCompraDet);
                    if ((int)obra == pObra)
                    {

                        decimal impBase = gvComprasDet.GetRowCellValue(i, colImpBaseCompraDet) == DBNull.Value ? 0 : (decimal)gvComprasDet.GetRowCellValue(i, colImpBaseCompraDet);
                        decimal iva = gvComprasDet.GetRowCellValue(i, colIVACompraDet) == DBNull.Value ? 0 : (decimal)gvComprasDet.GetRowCellValue(i, colIVACompraDet);
                        if (impBase == pImporte)
                        {
                            gvComprasDet.DeleteRow(i);
                        }
                        else
                        {
                            gvComprasDet.SetRowCellValue(i, colImpBaseCompraDet, impBase - pImporte);
                            gvComprasDet.SetRowCellValue(i, colImpIvaCompraDet, Math.Round(((impBase - pImporte) * iva / 100), 2));
                        }
                    }
                }

               
                this.Validate();
                this.comprasDetBindingSource.EndEdit();
            }

        }


        private void HabilitaDeshabilitaBotones(bool estado)
        {
            tbbtDeleteDet.Enabled = estado;
            tbbtAddDet.Enabled = estado;
            tbbtSaveDet.Enabled = estado;

            tbbtDeletePago.Enabled = estado;
            tbbtAddPago.Enabled = estado;
            tbbtSavePago.Enabled = estado;

            colAsociar.OptionsColumn.AllowEdit= estado;
        }

        private void cbProveedores_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (albaranesCabBindingSource.Count > 0)
            {
                if (MessageBox.Show("Si modifica el Proveedor se eliminarán los albaranes Relacionadas de esta compra. ¿Desea Continuar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < albaranesCabBindingSource.Count; i++)
                    {
                        gvAlbaranesCompra.SetRowCellValue(i, colIdCompra, null);
                    }

                    this.Validate();
                    this.albaranesCabBindingSource.EndEdit();
                    this.albaranesCabTableAdapter.Update(datosAlbaranes.AlbaranesCab);

                    CargaAlbaranesCompra();
                    CargaAlbaranesProveedores();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void gvComprasCab_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            GridCell[] celdasSeleccionadas = gvComprasCab.GetSelectedCells();
            GridView gridView = (GridView)sender;

            var resultado= Utilidades.SumarCeldas(gridView, celdasSeleccionadas);

            tbCantidadSeleccion.Text = resultado.Recuento.ToString();
            tbImporteSeleccion.Text = resultado.Suma.ToString("C2");

        }

        private void tbCopiaFactura_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    openFileDialog1.ShowDialog();
                    DataRowView CompraActual = (DataRowView)comprasCabBindingSource.Current;
                    CompraActual["CopiaFactura"] = openFileDialog1.FileName;
                    tbCopiaFactura.Text = openFileDialog1.FileName;
                    break;
                case 1:
                       try
                       {
                           System.Diagnostics.Process.Start(tbCopiaFactura.Text);
                       }
                       catch
                       {
                           MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                       }
                    break;
                case 2:
                    tbCopiaFactura.Text = null;
                    break;
            }
        }

        private void gvAlbaranesCompra_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (!gvAlbaranesCompra.IsFilterRow(e.FocusedRowHandle) && e.FocusedRowHandle >= 0)
            {
                int.TryParse(gvAlbaranesCompra.GetFocusedRowCellValue(colIdAlbaranCab).ToString(), out vAlbaran);
            }
            else
            {
                vAlbaran = 0;
            }
            CargaDetalleAlbaran();
        }

      
        private void fechaVctoDateEdit_Validated(object sender, EventArgs e)
        {
            fechaPagoDateEdit.EditValue = fechaVctoDateEdit.EditValue;
        }

        private void tbcbObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcbObras.SelectedIndex != -1)
            {
                string obraSeleccionada = "("+((ComboBoxItem)tbcbObras.SelectedItem).Value.ToString()+")";
                //gvComprasCab.ActiveFilterString = "Contains([Obras], '"+obraSeleccionada+"')";

                comprasCabBindingSource.Filter = "Obras LIKE '*"+obraSeleccionada+"*'";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tbcbObras.SelectedIndex = -1;
            //gvComprasCab.ActiveFilterString = "";
            comprasCabBindingSource.Filter = "";
        }

        private void tbbtAddPago_Click(object sender, EventArgs e)
        {
            decimal totalFactura = 0;
            decimal totalPagado=0;

            decimal.TryParse(colTotal.SummaryItem.SummaryValue.ToString(), out totalFactura);
            decimal.TryParse(colImportePagado.SummaryItem.SummaryValue.ToString(), out totalPagado);

            // pagosBindingSource.AddNew();
            DataRowView opebanco = (DataRowView)pagosBindingSource.Current;
            opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            opebanco["fecha"] = DateTime.Today;
            opebanco["DesOperacion"] = cbProveedores.Text + " Fra: " + facturaTextEdit.Text;

            // MessageBox.Show(CompraActual["IdCuenta"].ToString());
            opebanco["IdCuenta"] = cbCuenta.EditValue;
            opebanco["IdCompra"] = vCompra;
            opebanco["IdFormaPago"] = cbFormaPago.EditValue;
            opebanco["Importe"] = totalFactura - totalPagado;
            opebanco["EnCuenta"] = true;
            opebanco["TipoOpe"] = "Proveedores";
            opebanco["FechaOpe"] = DateTime.Now;
            opebanco["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;

            gvPagos.Focus();

            gvPagos.UpdateTotalSummary();
        }

        private void previsionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           rbVcto.Checked = !rbPrevision.Checked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.ShowDialog();
            this.vProveedoresTableAdapter.FillByEmpresa(promowork_dataDataSet.vProveedores, VariablesGlobales.nIdEmpresaActual);
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
            this.vCuentasBancosTableAdapter.FillByEmpresaCtaEmpresa(this.promowork_dataDataSet.vCuentasBancos, VariablesGlobales.nIdEmpresaActual, true);
        }

        private void gvComprasDet_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gvComprasDet.UpdateTotalSummary();

            CalculaTotalCompra();
        }

        private void gvPagos_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gvPagos.UpdateTotalSummary();
            
            CalculaTotalPagado();
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

        private void gvComprasDet_RowCountChanged(object sender, EventArgs e)
        {
            CalculaTotalCompra();
        }

        private void gvPagos_RowCountChanged(object sender, EventArgs e)
        {
            CalculaTotalPagado();
        }

       
    }
}