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
    public partial class frmFacturasPresupuestos : Form
    {
        public frmFacturasPresupuestos()
        {
            InitializeComponent();
        }

        int nIdFactura = 0;
        int FacturaEliminada;
        int nIdPresup = 0;
        int nIdObra = 0;
        Boolean esFactura = true;

        private void facturasCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (gridView1.RowCount > 0 && esPrevisionCheckEdit.CheckState!= CheckState.Checked)
            {
                int nIdFactura = (int)gridView1.GetFocusedRowCellValue("IdFactCab");
                facturaIncorrectaTableAdapter.Fill(datosPresupuestos.FacturaIncorrecta, VariablesGlobales.nIdEmpresaActual, (DateTime)fechaFacturaDateTimePicker.Value, (bool)facturaCheckBox.Checked, int.Parse(numFacturaTextBox.Text), nIdFactura, txtSerieFact.Text);

                if (facturaIncorrectaBindingSource.Count > 0)
                {
                    ok = false;
                    DataTable tmpFacturas = datosPresupuestos.FacturaIncorrecta.Select().CopyToDataTable();

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
                    //try
                    //{
                        queriesPresupuestos1.PoneAFacturarPresupuesto(FacturaEliminada);

                    //}
                    //catch (Exception ex)
                    //{
                    //    if (MessageBox.Show("No se pudieron poner las cantidades de la factura en -A Facturar- en el presupuesto. ¿Desea cancelar la eliminación de la Factura?\n Mensaje de Error: " + ex.Message, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //    {
                    //        return;
                    //    }
                    //}
                    
                    
                    DataRowView Presupuesto = (DataRowView) presupCabBindingSource.Current;

                    gridView1.SetFocusedRowCellValue("IdObra", Presupuesto["IdObra"]);

                    this.Validate();
                    this.facturasCabBindingSource.EndEdit();
                    facturasCabTableAdapter.Update(datosPresupuestos.FacturasCab);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los Cambios no se Guardaron.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void frmFacturasPresupuestos_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //MessageBox.Show("hjhu");
            anosFacturasTableAdapter.Fill(datosPresupuestos.AnosFacturas, VariablesGlobales.nIdEmpresaActual);
            clientesTableAdapter.FillByEmpresa(datosPresupuestos.Clientes, VariablesGlobales.nIdEmpresaActual);

            cuentasBancosTableAdapter.FillByEmpresa(datosPresupuestos.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            obrasTableAdapter.FillByEmpresa(datosPresupuestos.Obras, VariablesGlobales.nIdEmpresaActual);
            // TODO: esta línea de código carga datos en la tabla 'datosPresupuestos.FacturasDet' Puede moverla o quitarla según sea necesario.
            //    this.facturasDetTableAdapter.Fill(this.datosPresupuestos.FacturasDet);
            // TODO: esta línea de código carga datos en la tabla 'datosPresupuestos.FacturasCab' Puede moverla o quitarla según sea necesario.

            comboBox1.SelectedValue = VariablesGlobales.nAnoActual;
            cbxfacturas.SelectedIndex = 0;
            //MessageBox.Show("hjhu");
            this.facturasCabTableAdapter.FillByAno(this.datosPresupuestos.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)comboBox1.SelectedValue, esFactura);
        }



        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                // MessageBox.Show("hjhu");
                this.facturasCabTableAdapter.FillByAno(this.datosPresupuestos.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)comboBox1.SelectedValue, esFactura);
                facturaPresupCheckEdit_CheckedChanged(null, null);
            }
        }

        private void CargarPresupuesto(int Presupuesto)
        {
            // MessageBox.Show("Presupuesto: " + Presupuesto.ToString());

            capitulosTableAdapter.FillByPresupuesto(datosPresupuestos.Capitulos, Presupuesto);
            detallesTableAdapter.FillByPresupuesto(datosPresupuestos.Detalles, Presupuesto);
            subdetallesTableAdapter.FillByPresupuesto(datosPresupuestos.Subdetalles, Presupuesto);


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (entregadaCheckBox.CheckState == CheckState.Checked)
            {
                idClienteComboBox.Enabled = false;
                idPresupComboBox.Enabled = false;
                cbObra.Enabled = false;
                comboBox2.Enabled = false;
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
                    importe = (decimal)gridView1.GetFocusedRowCellValue("Total");
                }
                catch { }

                if (importe != 0)
                {
                    idClienteComboBox.Enabled = false;
                    idPresupComboBox.Enabled = false;
                    cbObra.Enabled = false;

                }
                else
                {
                    idClienteComboBox.Enabled = true;
                    idPresupComboBox.Enabled = true;
                    cbObra.Enabled = true;

                }

                comboBox2.Enabled = true;
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

            ActualizaDetalleFactura();

            CalculaPendienteDet();
            CalculaPendienteSub();
        }

        private void ActualizaDetalleFactura()
        {
            try
            {
                nIdFactura = 0;
                nIdPresup = 0;
                nIdObra = 0;

                int.TryParse(gridView1.GetFocusedRowCellValue("IdFactCab").ToString(), out nIdFactura);// == null ? 0 : (int)gridView1.GetFocusedRowCellValue("IdFactCab");
                int.TryParse(gridView1.GetFocusedRowCellValue("IdPresup").ToString(), out nIdPresup);// == null ? 0 : (int)gridView1.GetFocusedRowCellValue("IdPresup");
                int.TryParse(gridView1.GetFocusedRowCellValue("IdObra").ToString(), out nIdObra);// == null ? 0 : (int)gridView1.GetFocusedRowCellValue("IdObra");

                this.vDetallesFacturasPresupuestosTableAdapter.FillByFactura(this.datosPresupuestos.vDetallesFacturasPresupuestos, nIdFactura);
                this.facturasDetTableAdapter.FillByFactura(this.datosPresupuestos.FacturasDet, nIdFactura);
                this.vComprasDirectasTableAdapter.FillByObraPendientes(this.datosPresupuestos.vComprasDirectas, nIdObra);
                this.vComprasDirectasTableAdapterFactura.FillByFactura(this.datosPresupuestos1.vComprasDirectas, nIdFactura);
                this.vDetallesHorasMaterialesTableAdapter.FillByFactura(this.datosPresupuestos.vDetallesHorasMateriales, nIdFactura);
                //this.facturasDetDirectaTableAdapter.FillByFactura(this.datosPresupuestos.FacturasDetDirecta, nIdFactura);
                //vComprasDirectasBindingSource.Filter = "IdFactCab is null";
                facturasDetBindingSource.Filter = "IdPresupCap is null";
                gridView2.ExpandAllGroups();
                gridView6.ExpandAllGroups();
                CargarPresupuesto(nIdPresup);

            }
            catch
            {
                this.facturasDetTableAdapter.FillByFactura(this.datosPresupuestos.FacturasDet, 0);
                this.vDetallesFacturasPresupuestosTableAdapter.FillByFactura(this.datosPresupuestos.vDetallesFacturasPresupuestos, 0);
                this.vComprasDirectasTableAdapter.FillByObraPendientes(this.datosPresupuestos.vComprasDirectas, 0);
                this.vComprasDirectasTableAdapterFactura.FillByFactura(this.datosPresupuestos1.vComprasDirectas, 0);
                this.vDetallesHorasMaterialesTableAdapter.FillByFactura(this.datosPresupuestos.vDetallesHorasMateriales, 0);
            }
        
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {

            if (facturaCheckBox.Checked == true)
            {

                RptFacturasPresupImp2 frm = new RptFacturasPresupImp2();
                frm.LoadFiltro(nIdFactura);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {

                RptFacturasPresupParteImp2 frm = new RptFacturasPresupParteImp2();
                frm.LoadFiltro(nIdFactura);
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

        private void cbxfacturas_SelectedValueChanged(object sender, EventArgs e)
        {


            if (cbxfacturas.SelectedIndex != -1)
            {
                if (cbxfacturas.Text == "Facturas")
                {
                    esFactura = true;
                }
                else
                {
                    esFactura = false;
                }
            }
            this.facturasCabTableAdapter.FillByAno(this.datosPresupuestos.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)comboBox1.SelectedValue, esFactura);
            facturaPresupCheckEdit_CheckedChanged(null, null);
        }

        private void facturaPresupCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (facturaPresupCheckEdit.CheckState == CheckState.Checked)
            {
                if (chkSoloPrevisiones.CheckState == CheckState.Checked)
                {
                    facturasCabBindingSource.Filter = "FacturaPresup=true and esPrevision=true";
                }
                else
                {
                    facturasCabBindingSource.Filter = "FacturaPresup=true";
                }
            }
            else
            {
                if (chkSoloPrevisiones.CheckState == CheckState.Checked)
                {
                    facturasCabBindingSource.Filter = "esPrevision=true";
                }
                else
                {
                    facturasCabBindingSource.Filter = null;
                }
            }

        }

        private void idClienteComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (idClienteComboBox.SelectedIndex != -1)
            {
                presupCabTableAdapter.FillByCliente(datosPresupuestos.PresupCab, (int)idClienteComboBox.SelectedValue);
                obrasBindingSource1.Filter = "IdCliente=" + idClienteComboBox.SelectedValue.ToString();
            }
            else
            {
                presupCabTableAdapter.FillByCliente(datosPresupuestos.PresupCab, 0);
                obrasBindingSource1.Filter = "IdCliente=0";
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

        private void button5_Click(object sender, EventArgs e)
        {
            object valor = idClienteComboBox.SelectedValue;
            Clientes frm = new Clientes();
            frm.ShowDialog();
            clientesTableAdapter.FillByEmpresa(datosPresupuestos.Clientes, VariablesGlobales.nIdEmpresaActual);
            idClienteComboBox.SelectedValue = valor;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            numFacturaTextBox.Focus();

            gridView1.AddNewRow();
            gridView1.SetFocusedRowCellValue("FacturaPresup", true);
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
            gridView1.SetFocusedRowCellValue("IdUsuario", VariablesGlobales.nIdUsuarioActual);
            fechaFacturaDateTimePicker.Value = DateTime.Today;
            fechaVctoFactDateTimePicker.Value = DateTime.Today;

            gridView1.SetFocusedRowCellValue("Entregada", false);
            gridView1.SetFocusedRowCellValue("EsPrevision", false);
            facturaCheckBox.CheckState = CheckState.Checked;

            if (cbxfacturas.Text == "Facturas")
            {
                gridView1.SetFocusedRowCellValue("Factura", true);
                gridView1.SetFocusedRowCellValue("MostrarVcto", true);
                gridView1.SetFocusedRowCellValue("MostrarObra", true);
            }
            else
            {
                gridView1.SetFocusedRowCellValue("Factura", false);
                gridView1.SetFocusedRowCellValue("MostrarVcto", false);
                gridView1.SetFocusedRowCellValue("MostrarObra", false);
            }



            gridView1_FocusedRowChanged(null, null);
        }


        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            // El codigo esta en el evento "PositionChanged" del detallesBindingSource

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            // El codigo esta en el evento "PositionChanged" del subdetallesBindingSource
        }

        private void CalculaPendienteDet()
        {
            spnCantidad.Value = 0;
            spnPorciento.Value = 0;
            spnDescuento.Value = 0;
            spnPendienteDet.Value = cantidadSpinEdit.Value + cantExtraSpinEdit.Value - cantDetFactSpinEdit.Value;
            if (spnPendienteDet.Value > 0)
            {
                spnPendienteDet.ForeColor = Color.Blue;
                spnPendienteDet.Font = new Font(spnPendienteDet.Font, FontStyle.Bold);

                lblPendienteDet.ForeColor = Color.Blue;
                lblPendienteDet.Font = new Font(spnPendienteDet.Font, FontStyle.Bold);

                spnCantidad.Properties.MaxValue = spnPendienteDet.Value;
                spnPorciento.Properties.MaxValue = spnPendienteDet.Value / (cantidadSpinEdit.Value + cantExtraSpinEdit.Value) * 100;
                spnPorciento.Properties.MinValue = 0;
                spnPrecio.Value = precioSpinEdit.Value;
                txtUM.EditValue = uMTextEdit.EditValue;
            }
            else
            {
                spnPendienteDet.ForeColor = Color.Black;
                spnPendienteDet.Font = new Font(spnPendienteDet.Font, FontStyle.Regular);

                lblPendienteDet.ForeColor = Color.Black;
                lblPendienteDet.Font = new Font(spnPendienteDet.Font, FontStyle.Regular);
            }
        }

        private void CalculaPendienteSub()
        {
            if (cantidadSpinEdit1.Value > 0)
            {
                groupBox1.Visible = true;
                spnCantidad.Value = 0;
                spnPorciento.Value = 0;
                spnDescuento.Value = 0;
                spnPendienteSub.Value = cantidadSpinEdit1.Value + cantExtraSpinEdit1.Value - cantSubFactSpinEdit.Value;
                if (spnPendienteSub.Value > 0)
                {
                    spnPendienteSub.ForeColor = Color.Blue;
                    spnPendienteSub.Font = new Font(spnPendienteDet.Font, FontStyle.Bold);

                    lblPendienteSub.ForeColor = Color.Blue;
                    lblPendienteSub.Font = new Font(spnPendienteDet.Font, FontStyle.Bold);

                    spnCantidad.Properties.MaxValue = spnPendienteSub.Value;
                    spnPorciento.Properties.MaxValue = spnPendienteSub.Value / (cantidadSpinEdit1.Value + cantExtraSpinEdit1.Value) * 100;
                    spnPorciento.Properties.MinValue = 0;
                    spnPrecio.Value = precioSpinEdit1.Value;
                    txtUM.EditValue = uMTextEdit1.EditValue;

                }
                else
                {
                    spnPendienteSub.ForeColor = Color.Black;
                    spnPendienteSub.Font = new Font(spnPendienteDet.Font, FontStyle.Regular);

                    lblPendienteSub.ForeColor = Color.Black;
                    lblPendienteSub.Font = new Font(spnPendienteDet.Font, FontStyle.Regular);
                }
            }
            else
                groupBox1.Visible = false;
        }

        private void detallesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cantidadSpinEdit.Value.ToString()+"+"+ cantExtraSpinEdit.Value.ToString() +"-" +cantDetFactSpinEdit.Value.ToString());

            CalculaPendienteDet();
        }

        private void subdetallesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            CalculaPendienteSub();
        }

        private void capitulosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            CalculaPendienteDet();
            CalculaPendienteSub();
        }

       

        private void spnPorciento_Validated(object sender, EventArgs e)
        {
            spnCantidad.Value = (spnPorciento.Value / 100) * (cantidadSpinEdit.Value + cantExtraSpinEdit.Value + cantidadSpinEdit1.Value + cantExtraSpinEdit1.Value);

            spnImporte.Value = spnCantidad.Value * spnPrecio.Value * (100 - spnDescuento.Value) / 100;
        }

        private void spnCantidad_Validated(object sender, EventArgs e)
        {
            spnImporte.Value = spnCantidad.Value * spnPrecio.Value * (100 - spnDescuento.Value) / 100;
            spnPorciento.Value = spnCantidad.Value / (cantidadSpinEdit.Value + cantExtraSpinEdit.Value + cantidadSpinEdit1.Value + cantExtraSpinEdit1.Value)*100;
        }



       
        private void button6_Click(object sender, EventArgs e)
        {

            int posCap = comboBox5.SelectedIndex;
            int posDet = comboBox4.SelectedIndex;
            int posSub = comboBox3.SelectedIndex;
            
            facturasDetBindingSource.AddNew();
            DataRowView Detalle = (DataRowView)facturasDetBindingSource.Current;

            Detalle["IdFactCab"] = gridView1.GetFocusedRowCellValue("IdFactCab");
            Detalle["IdPresupCap"] = comboBox5.SelectedValue;
            Detalle["IdPresupDet"] = comboBox4.SelectedValue;
            Detalle["IdPresupSub"] = comboBox3.SelectedValue == null ? DBNull.Value : comboBox3.SelectedValue;
            Detalle["Um"] = txtUM.EditValue;
            Detalle["Cantidad"] = spnCantidad.Value;
            Detalle["Precio"] = spnPrecio.Value * (100 - spnDescuento.Value) / 100;
            Detalle["DescPrecio"] = spnDescuento.Value;

            this.Validate();
            facturasDetBindingSource.EndEdit();
            facturasDetTableAdapter.Update(datosPresupuestos.FacturasDet);

            ActualizaDetalleFactura();

            if (posCap < comboBox5.Items.Count - 1)
            {
                comboBox5.SelectedIndex = posCap;
            }
            else
            {
                comboBox5.SelectedIndex = comboBox5.Items.Count - 1;
            }

            if (posDet < comboBox4.Items.Count - 1)
            {
                comboBox4.SelectedIndex = posDet;
            }
            else
            {
                comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
            }

            if (posSub < comboBox3.Items.Count - 1)
            {
                comboBox3.SelectedIndex = posSub;
            }
            else
            {
                comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
            }

            facturasCabBindingNavigatorSaveItem_Click(null, null);
            CalculaPendienteDet();
            CalculaPendienteSub();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?. \nSe eliminarán las cantidades -A Facturar- del presupuesto correspondiente y se sustituirán por las cantidades de la factura actual.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gridView1.RowCount > 0)
                {

                    FacturaEliminada = (int)gridView1.GetFocusedRowCellValue("IdFactCab");

                    this.facturasCabBindingSource.RemoveCurrent();
                    
                    


                }
            }
        }

       

        private void btnEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Index == 0)
                {
                    if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // facturasDetBindingSource.RemoveCurrent();
                        
                        //MessageBox.Show(gridView2.GetFocusedRowCellValue("IdFactDet").ToString());
                        queriesPresupuestos1.EliminaDetalleFactura((int)gridView2.GetFocusedRowCellValue("IdFactDet"));
                        gridView2.DeleteSelectedRows();
                        //int posCap = comboBox5.SelectedIndex;
                        //int posDet = comboBox4.SelectedIndex;
                        //int posSub = comboBox3.SelectedIndex;

                        this.Validate();
                        facturasDetBindingSource.EndEdit();
                        facturasDetTableAdapter.Update(datosPresupuestos.FacturasDet);

                        ////////ActualizaDetalleFactura();

                        //if (posCap < comboBox5.Items.Count - 1)
                        //{
                        //    comboBox5.SelectedIndex = posCap;
                        //}
                        //else
                        //{
                        //    comboBox5.SelectedIndex = comboBox5.Items.Count - 1;
                        //}

                        //if (posDet < comboBox4.Items.Count - 1)
                        //{
                        //    comboBox4.SelectedIndex = posDet;
                        //}
                        //else
                        //{
                        //    comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
                        //}

                        //if (posSub < comboBox3.Items.Count - 1)
                        //{
                        //    comboBox3.SelectedIndex = posSub;
                        //}
                        //else
                        //{
                        //    comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
                        //}

                        facturasCabBindingNavigatorSaveItem_Click(null, null);
                        
                         nIdPresup = gridView1.GetFocusedRowCellValue("IdPresup") == null ? 0 : (int)gridView1.GetFocusedRowCellValue("IdPresup");
                        CargarPresupuesto(nIdPresup);

                        CalculaPendienteDet();
                        CalculaPendienteSub();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los Cambios no se Guardaron.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spinEdit1_Validated(object sender, EventArgs e)
        {
            spnImporte.Value = spnCantidad.Value * spnPrecio.Value*(100-spnDescuento.Value)/100;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (facturaPresupCheckEdit.CheckState == CheckState.Checked)
            {
                if (chkSoloPrevisiones.CheckState == CheckState.Checked)
                {
                    facturasCabBindingSource.Filter = "FacturaPresup=true and esPrevision=true";
                }
                else
                {
                    facturasCabBindingSource.Filter = "FacturaPresup=true";
                }
            }
            else
            {
                if (chkSoloPrevisiones.CheckState == CheckState.Checked)
                {
                    facturasCabBindingSource.Filter = "esPrevision=true";
                }
                else
                {
                    facturasCabBindingSource.Filter = null;
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.facturasDetBindingSource.EndEdit();
                facturasDetTableAdapter.Update(datosPresupuestos.FacturasDet);
                facturasCabBindingNavigatorSaveItem_Click(null, null);

            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                this.facturasDetTableAdapter.FillByFactura(this.datosPresupuestos.FacturasDet, nIdFactura);

            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.facturasDetTableAdapter.FillByFactura(this.datosPresupuestos.FacturasDet, nIdFactura);
                }

            }
        }

        private void AgregarCompraDirecta_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                int nIdCompra = (int)gridView5.GetFocusedRowCellValue(colIdCompraDirecta);


                queriesPresupuestos1.InsertaDetalleFacturaDirecta(nIdFactura, nIdCompra, "");
                //gridView4.AddNewRow();
                //gridView4.SetFocusedRowCellValue(colIdFactCabDirecta, nIdFactura);
                //gridView4.SetFocusedRowCellValue(colIdCompraDirecta, nIdCompra);

                //this.Validate();
                //this.facturasDetDirectaBindingSource.EndEdit();
                //this.facturasDetDirectaTableAdapter.Update(datosPresupuestos.FacturasDetDirecta);
                //this.facturasCabBindingSource.EndEdit();
                //this.facturasCabTableAdapter.Update(datosPresupuestos.FacturasCab);
                facturasCabBindingNavigatorSaveItem_Click(null, null);

                //this.facturasDetDirectaTableAdapter.FillByFactura(this.datosPresupuestos.FacturasDetDirecta, nIdFactura);
                this.vComprasDirectasTableAdapterFactura.FillByFactura(this.datosPresupuestos1.vComprasDirectas, nIdFactura);
                this.vComprasDirectasTableAdapter.FillByObraPendientes(this.datosPresupuestos.vComprasDirectas, nIdObra);
                //vComprasDirectasBindingSource.Filter = "IdFactCab is null";

            }
        }

        private void btQuitarCompraDirecta_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                int nIdCompra = (int)gridView4.GetFocusedRowCellValue(colIdCompra);
                queriesPresupuestos1.EliminaDetalleFacturaDirecta(nIdCompra);
                //gridView4.DeleteSelectedRows();

                //this.Validate();
                //this.facturasDetDirectaBindingSource.EndEdit();
                //this.facturasDetDirectaTableAdapter.Update(datosPresupuestos.FacturasDetDirecta);
                //this.facturasCabBindingSource.EndEdit();
                //this.facturasCabTableAdapter.Update(datosPresupuestos.FacturasCab);
                facturasCabBindingNavigatorSaveItem_Click(null, null);

                //this.facturasDetDirectaTableAdapter.FillByFactura(this.datosPresupuestos.FacturasDetDirecta, nIdFactura);
                this.vComprasDirectasTableAdapterFactura.FillByFactura(this.datosPresupuestos1.vComprasDirectas, nIdFactura);
                this.vComprasDirectasTableAdapter.FillByObraPendientes(this.datosPresupuestos.vComprasDirectas, nIdObra);
                //vComprasDirectasBindingSource.Filter = "IdFactCab is null";

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            queriesPresupuestos1.DuplicaFactura(nIdFactura);
            cbxfacturas_SelectedValueChanged(null, null);
        }

    }
}
