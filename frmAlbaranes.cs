using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Promowork
{
    public partial class frmAlbaranes : Form
    {
        public frmAlbaranes()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
        }
        //int anoActual = VariablesGlobales.nAnoActual;

        string AparienciaGridEncabezado="";
        string AparienciaGridDetalles = "";
        Dictionary<int, string> cbitem = new Dictionary<int, string>();
        

        private void albaranesCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string msgError = string.Empty;

            if (txtNumeroAlbaran.Text.Trim() == "" && chkSinAlbaran.CheckState != CheckState.Checked)
            {
                msgError = msgError + "Número de Albaran." + Environment.NewLine;
            }
            if (deFechaAlbaran.EditValue== null)
            {
                msgError = msgError + "Fecha de Albaran." + Environment.NewLine;
            }
            if (!cbxProveedores.IsDisplayTextValid)
            {
                msgError = msgError + "Proveedor." + Environment.NewLine;
            }
            if (!cbxObra.IsDisplayTextValid)
            {
                msgError = msgError + "Obra." + Environment.NewLine;
            }

            if (msgError != string.Empty)
            {
                MessageBox.Show("Hay campos obligatorios sin rellenar:" + Environment.NewLine + msgError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (cbxObra.ItemIndex != -1)
                {
                    if (txtConsecutivo.EditValue == DBNull.Value)
                    {
                        txtConsecutivo.EditValue = (int)this.queriesAlbaranes1.UltimoConsecutivoAlbaran((int)cbxObra.EditValue, (int)cbxProveedores.EditValue) + 1;
                    }
                }
                else
                {
                    txtConsecutivo.EditValue = DBNull.Value;
                }

                this.Validate();
                this.albaranesCabBindingSource.EndEdit();
                this.albaranesCabTableAdapter.Update(datosAlbaranes.AlbaranesCab);

                this.observacionesProveedoresBindingSource.EndEdit();
                this.observacionesProveedoresTableAdapter.Update(datosAlbaranes.ObservacionesProveedores);

            }

           // this.tableAdapterManager.UpdateAll(this.datosAlbaranes);

        }

        private void frmAlbaranes_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;

            this.anosTableAdapter.FillByEmpresa(datosAlbaranes.Anos, VariablesGlobales.nIdEmpresaActual);
            this.proveedoresTableAdapter.FillByEmpresa(this.datosAlbaranes.Proveedores, VariablesGlobales.nIdEmpresaActual);
            this.obrasTableAdapter.FillByEmpresa(this.datosAlbaranes.Obras, VariablesGlobales.nIdEmpresaActual);
            this.lugaresUsoMaterialTableAdapter.FillByEmpresa(this.datosAlbaranes.LugaresUsoMaterial, VariablesGlobales.nIdEmpresaActual);
            this.trabajadoresTableAdapter.FillByEmpresa(this.datosAlbaranes.Trabajadores, VariablesGlobales.nIdEmpresaActual);

           // cbxAnos.EditValue = VariablesGlobales.nAnoActual;
           foreach (DataRowView nAno in anosBindingSource)
           {
               cbAnos.Items.Add(nAno["Ano"]);
           }
            cbAnos.SelectedItem=cbAnos.Items.Contains(VariablesGlobales.nAnoActual)?VariablesGlobales.nAnoActual:int.Parse(null);
            

            this.observacionesProveedoresTableAdapter.FillByEmpresa(datosAlbaranes.ObservacionesProveedores, VariablesGlobales.nIdEmpresaActual);
            this.observacionesProveedoresBindingSource.Filter = "1=2";

            AparienciaGridEncabezado = this.Name + gridView1.Name + VariablesGlobales.nIdEmpresaActual.ToString() + VariablesGlobales.nIdUsuarioActual.ToString() + ".xml";
            AparienciaGridDetalles = this.Name + gridView2.Name + VariablesGlobales.nIdEmpresaActual.ToString() + VariablesGlobales.nIdUsuarioActual.ToString() + ".xml";

            try
            {
                gridView1.RestoreLayoutFromXml(AparienciaGridEncabezado);
                gridView2.RestoreLayoutFromXml(AparienciaGridDetalles);

            }
            catch { }

            
            foreach (var item in Enum.GetValues(typeof(EnumUtilizadoAlbaran)))
            {
                cbitem.Add((int)item, ((EnumUtilizadoAlbaran)item).GetDescription());
            }

            cbxUtilizadoEn.Properties.DataSource = cbitem;
            cbxUtilizadoEn.Properties.DisplayMember = "Value";
            cbxUtilizadoEn.Properties.ValueMember = "Key";

            gvcbxUtilizadoEn.DataSource = cbitem;
            gvcbxUtilizadoEn.DisplayMember = "Value";
            gvcbxUtilizadoEn.ValueMember = "Key";


            Cursor.Current = Cursors.Default;
        }
        private void CargaEncabezadoAlbaran()
        {
            
           
            if (cbAnos.SelectedIndex != -1)
            {
                this.albaranesCabTableAdapter.FillByAnoEmpresa(this.datosAlbaranes.AlbaranesCab, VariablesGlobales.nIdEmpresaActual, (int)cbAnos.SelectedItem);
            }
            Cursor.Current = Cursors.Default; 
        }
            

        private void CargaDetallesAlbaran()
        {
            Cursor.Current = Cursors.WaitCursor;
            //MessageBox.Show("Filtro");
            // this.productosTableAdapter.FillByEmpresaProveedor(this.datosAlbaranes.Productos, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue);
           // int albaran = spnIdAlbaran.Value == null ? 0 : (int)spnIdAlbaran.Value;
           
                //try
                //{
                //    int vIdCompra = (int)gridView1.GetFocusedRowCellValue(colIdCompra);

                //    tbFacturaCompra.EditValue = queriesAlbaranes1.ObtieneNumeroFacturaCompras(vIdCompra);
                //}
                //catch
                //{
                //    tbFacturaCompra.EditValue = "";
                //}
                try
                {
                    this.albaranesDetTableAdapter.FillByAlbaran(this.datosAlbaranes.AlbaranesDet, spnIdAlbaran.Value);

                }
                catch
                {

                    this.albaranesDetTableAdapter.FillByAlbaran(this.datosAlbaranes.AlbaranesDet, 0);
                }

            Cursor.Current = Cursors.Default; 
        }

      
        //private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
            
        //    CargaDetallesAlbaran();
        //}

        
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.albaranesDetBindingSource.EndEdit();
            this.albaranesDetTableAdapter.Update(datosAlbaranes.AlbaranesDet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int? ProveedorAnterior = (int?)cbxProveedores.EditValue;
            int? ObraAnterior = (int?)cbxObra.EditValue;
            DateTime? FechaAnterior = (DateTime?) deFechaAlbaran.EditValue;
            gridView1.AddNewRow();
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
            cbxProveedores.EditValue = ProveedorAnterior;
            cbxObra.EditValue = ObraAnterior;
            deFechaAlbaran.EditValue = FechaAnterior;
            txtNumeroAlbaran.Focus();
            chkFacturaRecibida.CheckState = CheckState.Unchecked;
            chkValorado.CheckState = CheckState.Unchecked;
            chkUtilizado.CheckState = CheckState.Unchecked;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int? ObraAnterior = (int?)gridView2.GetFocusedRowCellValue("IdObra");
            gridView2.AddNewRow();
            gridView2.SetFocusedRowCellValue("IdObra", ObraAnterior);
            gridView2.SetFocusedRowCellValue("IdAlbaranCab", gridView1.GetFocusedRowCellValue("IdAlbaranCab"));
            gridView2.FocusedColumn = gridView2.VisibleColumns[0];
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "Codigo" || e.Column.Name == "Descripcion")
            {
                try
                {

                    DataRow Producto = datosAlbaranes.Productos.FindByIdProducto(int.Parse(gridView2.GetFocusedRowCellValue("IdProducto").ToString()));
                    //  DataRowView Producto = (DataRowView)productosBindingSource.Current;
                    //  MessageBox.Show(Producto["Descuento"].ToString());
                    gridView2.SetFocusedRowCellValue("Precio", Producto["PVP"]);
                    gridView2.SetFocusedRowCellValue("Descuento", Producto["Descuento"]);
                }
                catch { }

            }
        }

        private void Lugares_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
            switch (e.Button.Index)
            {
                case 1:
            
                    frmLugaresUsoMaterial frm = new frmLugaresUsoMaterial();
                    // frm.MdiParent = this.MdiParent;
                    frm.ShowDialog();

                    this.lugaresUsoMaterialTableAdapter.FillByEmpresa(this.datosAlbaranes.LugaresUsoMaterial, VariablesGlobales.nIdEmpresaActual);
                    break;
                case 2:
                    gridView2.SetFocusedRowCellValue("IdLugarUso", null);

                    break;

            }



        }

        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {
            if (albaranesDetBindingSource.Count != 0)
            {
                cbxProveedores.Enabled = false;
            }
            else
            {
                cbxProveedores.Enabled = true;
            }
        }

        private void cbxProveedores_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxProveedores.ItemIndex != -1)
            {
                this.productosTableAdapter.FillByEmpresaProveedor(this.datosAlbaranes.Productos, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue);
                if (cbxObra.ItemIndex != -1)
                {
                   // this.observacionesProveedoresTableAdapter.FillByEmpresaObraProveedor(datosAlbaranes.ObservacionesProveedores, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue, (int)cbxObra.EditValue);
                    this.observacionesProveedoresBindingSource.Filter = "IdObra=" + cbxObra.EditValue.ToString() + " and IdProveedor=" + cbxProveedores.EditValue.ToString();
                }
            

            }
        }

        private void spnIdAlbaran_EditValueChanged(object sender, EventArgs e)
        {
            CargaDetallesAlbaran();
        }

        private void copiaAlbaranTextEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            //DataRowView facturaActual = (DataRowView)facturasCabBindingSource.Current;
            //facturaActual["CopiaFactura"] = openFileDialog1.FileName;
            copiaAlbaranTextEdit.EditValue = openFileDialog1.FileName;
        }

        private void CodigosProductos_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Productos frm = new Productos();
                string Filtro = "IdProveedor=" + cbxProveedores.EditValue.ToString();
                frm.Filtrar(Filtro);
                frm.ShowDialog();

                if (cbxProveedores.ItemIndex != -1)
                {
                    this.productosTableAdapter.FillByEmpresaProveedor(this.datosAlbaranes.Productos, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue);

                }
            }
        }

        private void DescripcionProductos_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Productos frm = new Productos();
                string Filtro = "IdProveedor=" + cbxProveedores.EditValue.ToString();
                frm.Filtrar(Filtro);
                frm.ShowDialog();

                

                if (cbxProveedores.ItemIndex != -1)
                {
                    this.productosTableAdapter.FillByEmpresaProveedor(this.datosAlbaranes.Productos, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue);

                }
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (cbxProveedores.ItemIndex != -1)
            {
                this.productosTableAdapter.FillByEmpresaProveedor(this.datosAlbaranes.Productos, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.albaranesCabBindingSource.RemoveCurrent();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.albaranesDetBindingSource.RemoveCurrent();
            }
        }

        private void gridView3_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (cbxObra.ItemIndex != -1 && cbxProveedores.ItemIndex != -1)
            {
                gridView3.SetRowCellValue(e.RowHandle, "IdEmpresa", VariablesGlobales.nIdEmpresaActual);
                gridView3.SetRowCellValue(e.RowHandle, "idObra", cbxObra.EditValue);
                gridView3.SetRowCellValue(e.RowHandle, "IdProveedor", cbxProveedores.EditValue);
            }
            else
            {
                MessageBox.Show("No pueden agregarse aobservaciones antes de seleccionar la Obra y el proveedor.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridView3.DeleteRow(e.RowHandle);
            }
        }

        private void cbxObra_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxProveedores.ItemIndex != -1)
            {
              //  this.productosTableAdapter.FillByEmpresaProveedor(this.datosAlbaranes.Productos, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue);
                if (cbxObra.ItemIndex != -1)
                {
                    this.observacionesProveedoresBindingSource.Filter = "IdObra=" + cbxObra.EditValue.ToString() + " and IdProveedor=" + cbxProveedores.EditValue.ToString();
                    //this.observacionesProveedoresTableAdapter.FillByEmpresaObraProveedor(datosAlbaranes.ObservacionesProveedores, VariablesGlobales.nIdEmpresaActual, (int)cbxProveedores.EditValue, (int)cbxObra.EditValue);
                }
            

            }
        }

        private void btnEliminar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView3.DeleteRow(gridView3.FocusedRowHandle);
        }

        private void chkValorado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValorado.CheckState == CheckState.Checked)
            {
                chkFacturaRecibida.CheckState = CheckState.Checked;
            }
        }

        private void frmAlbaranes_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.SaveLayoutToXml(AparienciaGridEncabezado);
            gridView2.SaveLayoutToXml(AparienciaGridDetalles);
        }

        //private void cbAnos_Validating(object sender, CancelEventArgs e)
        //{
        //    CargaEncabezadoAlbaran();
        //    CargaDetallesAlbaran();
        //}

        private void cbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CargaEncabezadoAlbaran();
            CargaDetallesAlbaran();
            Cursor.Current = Cursors.Default;
        }

        private void btRevisionAlbaranes_Click(object sender, EventArgs e)
        {
            frmRevisionAlbaranes frm = new frmRevisionAlbaranes();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btSinAlbaran_Click(object sender, EventArgs e)
        {
            rptParametrosSinAlbaran frm = new rptParametrosSinAlbaran();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
            
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            var frm = new frmCompras();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cbxUtilizadoEn_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                cbxUtilizadoEn.EditValue = null;
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            GridCell[] celdasSeleccionadas = gridView1.GetSelectedCells();
            GridView gridView = (GridView)sender;

            var resultado = Utilidades.SumarCeldas(gridView, celdasSeleccionadas);

            tbRecuentoSeleccion.Text = resultado.Recuento.ToString();
            tbSumaSeleccion.Text = resultado.Suma.ToString("N2");
            tbPromedioSeleccion.Text = resultado.Promedio.ToString("N2");
        }

      

    }
}
