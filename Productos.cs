using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace Promowork
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        string AparienciaGridProductos = "";
        string FiltroProductos = "";

        //int nIdTipoProducto = 0;
        //int nIdGrupo = 0;

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(gridView1.GetFocusedRowCellValue("IdTipoProveedor").ToString());
            string Codigo="";

            

            gridView1.CloseEditor();
            gridView1.BeginUpdate();
            gridView1.EndUpdate();
            try
            {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

            try
            {
                string CodigoActual = gridView1.GetFocusedRowCellDisplayText("CodProductoInterno").ToString().PadRight(10,'0');

                if (gridView1.GetFocusedRowCellDisplayText("IdTipoProveedor").ToString().Substring(0, 2) != CodigoActual.Substring(0, 2) || gridView1.GetFocusedRowCellDisplayText("IdGrupo").ToString().Substring(0, 3) != CodigoActual.Substring(2, 3))
                {
                    int Consecutivo = (int)queriesTableAdapter1.UltimoCodigoProducto((int)gridView1.GetFocusedRowCellValue("IdTipoProveedor"), (int)gridView1.GetFocusedRowCellValue("IdGrupo")) + 1;
                    string TipoProducto = gridView1.GetFocusedRowCellDisplayText("IdTipoProveedor").ToString().Substring(0, 2);
                    string GrupoProducto = gridView1.GetFocusedRowCellDisplayText("IdGrupo").ToString().Substring(0, 3);
                   // char Relleno = '0';
                    string ConsecutivoSTR = Consecutivo.ToString().PadLeft(4, '0');
                    Codigo = TipoProducto + GrupoProducto + ConsecutivoSTR;
                    gridView1.SetFocusedRowCellValue("CodProductoInterno", Codigo);
                }
                //else
                //{
                //    Codigo = gridView1.GetFocusedRowCellDisplayText("CodProductoInterno").ToString();
                //}
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("No se pudo generar el código del producto. Revise no existan códigos con formato incorrecto. \n Mensaje de Error: " + ex.Message);
            }

            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
                    
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);

                    }

                }
        }

        internal void Filtrar(string Filtro)
        {
            FiltroProductos = Filtro;
              // MessageBox.Show("Filtro");
           
        
        }


        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.GruposProductos' Puede moverla o quitarla según sea necesario.
            this.gruposProductosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.GruposProductos, VariablesGlobales.nIdEmpresaActual);
            this.tiposProductosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.TiposProductos, VariablesGlobales.nIdEmpresaActual);
            this.tiposProveedoresTableAdapter.FillByEmpresa(this.promowork_dataDataSet.TiposProveedores, VariablesGlobales.nIdEmpresaActual);

            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Fabricantes' Puede moverla o quitarla según sea necesario.
            this.fabricantesTableAdapter.Fill(this.promowork_dataDataSet.Fabricantes);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.UMedidas' table. You can move, or remove it, as needed.
            this.WindowState = FormWindowState.Maximized;
            this.proveedoresTableAdapter.Fill(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);
            this.uMedidasTableAdapter.Fill(this.promowork_dataDataSet.UMedidas);
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
            this.promowork_dataDataSet.Productos.Columns.Add("PC", typeof(decimal), "PVP*(1-Descuento/100)");
            this.promowork_dataDataSet.Productos.Columns.Add("PV", typeof(decimal), "(PVP*(1-Descuento/100)*(1+Porciento/100))");

            AparienciaGridProductos = this.Name + gridView1.Name + VariablesGlobales.nIdEmpresaActual.ToString() + VariablesGlobales.nIdUsuarioActual.ToString() + ".xml";

          // MessageBox.Show(AparienciaGridProductos);

            try
            {
                gridView1.RestoreLayoutFromXml(AparienciaGridProductos);

            }
            catch { }

            gridView1.ActiveFilterString = FiltroProductos;
            gridView1.ApplyColumnsFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(VariablesGlobales.nIdEmpresaActual));
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
            gridView1.FocusedColumn = gridView1.VisibleColumns[0];
            gridView1.ShowEditor();

           
            /*
                       GridCell gcStart = new GridCell(gridView1.FocusedRowHandle, gridView1.VisibleColumns[0]);
                       GridCell gcEnd = new GridCell(gridView1.FocusedRowHandle, gridView1.VisibleColumns[0]);
                       gridView1.SelectCells(gcStart, gcEnd);*/
          
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.productosBindingSource.RemoveCurrent();
            }
        }

       
        private void Fabricantes_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Fabricantes frm = new Fabricantes();
                frm.ShowDialog();
                this.fabricantesTableAdapter.Fill(promowork_dataDataSet.Fabricantes);
            }

            if (e.Button.Index == 2)
            {
                gridView1.SetFocusedRowCellValue("IdFabricante", null);
            }
        }

        private void Grupos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                GruposProductos frm = new GruposProductos();
                frm.ShowDialog();
                this.gruposProductosTableAdapter.FillByEmpresa(promowork_dataDataSet.GruposProductos, VariablesGlobales.nIdEmpresaActual);
            }

            if (e.Button.Index == 2)
            {
                //MessageBox.Show("borrar");
                gridView1.SetFocusedRowCellValue("IdGrupo", null);
            }
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colCodProducto")
            {
                productosBindingSource1.Filter = "CodProducto='" + e.Value.ToString() + "'";

                if (productosBindingSource1.Count > 0)
                {
                    gridView1.MoveLast();
                    gridView1.ActiveFilterString = "[CodProducto]= '" + e.Value.ToString() + "'";
                    gridView1.MoveLast();


                }

            }


            if (e.Column.Name == "colDesProducto")
            {
                productosBindingSource1.Filter = "DesProducto='" + e.Value.ToString() + "'";

                if (productosBindingSource1.Count > 0)
                {
                    gridView1.MoveLast();
                    gridView1.ActiveFilterString = "[DesProducto]= '" + e.Value.ToString() + "'";
                    gridView1.MoveLast();


                }

            }

            if (e.Column.Name == "colIdProveedor")
            {
                try
                {
                    DataRow Proveedor = (DataRow)promowork_dataDataSet.Proveedores.FindByIdProveedor((int)gridView1.GetFocusedRowCellValue("IdProveedor"));
                    gridView1.SetFocusedRowCellValue("IdTipoProveedor", Proveedor["IdTipoProveedor"]);
                    gridView1.SetFocusedRowCellValue("IdGrupo", Proveedor["IdGrupo"]);
                }
                catch { }
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            try
            {
                int? Empresa = gridView1.GetFocusedRowCellValue("IdEmpresa") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdEmpresa");
                int? Proveedor = gridView1.GetFocusedRowCellValue("IdProveedor") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdProveedor");
                int? UM = gridView1.GetFocusedRowCellValue("IdUMedida") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdUMedida");
                int? Grupo = gridView1.GetFocusedRowCellValue("IdGrupo") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdGrupo");
                int? GrupoProveedor = gridView1.GetFocusedRowCellValue("IdTipoProveedor") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdTipoProveedor");
                int? TipoProducto = gridView1.GetFocusedRowCellValue("IdTipoProducto") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdTipoProducto");
                int? Fabricante = gridView1.GetFocusedRowCellValue("IdFabricante") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdFabricante");
                string Descripcion = gridView1.GetFocusedRowCellValue("DesProducto").ToString();
                decimal? PVP = gridView1.GetFocusedRowCellValue("PVP") == DBNull.Value ? null : (decimal?)gridView1.GetFocusedRowCellValue("PVP");
                decimal? Descuento = gridView1.GetFocusedRowCellValue("Descuento") == DBNull.Value ? null : (decimal?)gridView1.GetFocusedRowCellValue("Descuento");
                decimal? Porciento = gridView1.GetFocusedRowCellValue("Porciento") == DBNull.Value ? null : (decimal?)gridView1.GetFocusedRowCellValue("Porciento");
                bool? Generico = gridView1.GetFocusedRowCellValue("ProductoGenerico") == DBNull.Value ? null : (bool?)gridView1.GetFocusedRowCellValue("ProductoGenerico");
                int? UMProv = gridView1.GetFocusedRowCellValue("IdUMedidaProv") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdUMedidaProv");
                int? UMVenta = gridView1.GetFocusedRowCellValue("IdUMedidaVenta") == DBNull.Value ? null : (int?)gridView1.GetFocusedRowCellValue("IdUMedidaVenta");
                decimal? ConvUMProv = gridView1.GetFocusedRowCellValue("ConvUMProv") == DBNull.Value ? null : (decimal?)gridView1.GetFocusedRowCellValue("ConvUMProv");
                decimal? ConvUMVenta = gridView1.GetFocusedRowCellValue("ConvUMVenta") == DBNull.Value ? null : (decimal?)gridView1.GetFocusedRowCellValue("ConvUMVenta");

                




                gridView1.AddNewRow();

                gridView1.SetFocusedRowCellValue("IdEmpresa", Empresa);
                gridView1.SetFocusedRowCellValue("IdProveedor", Proveedor);
                gridView1.SetFocusedRowCellValue("IdUMedida", UM);
                gridView1.SetFocusedRowCellValue("IdGrupo", Grupo);
                gridView1.SetFocusedRowCellValue("IdTipoProveedor", GrupoProveedor);
                gridView1.SetFocusedRowCellValue("IdTipoProducto", TipoProducto);
                gridView1.SetFocusedRowCellValue("IdFabricante", Fabricante);
                gridView1.SetFocusedRowCellValue("DesProducto", Descripcion);
                gridView1.SetFocusedRowCellValue("PVP", PVP);
                gridView1.SetFocusedRowCellValue("Descuento", Descuento);
                gridView1.SetFocusedRowCellValue("Porciento", Porciento);
                gridView1.SetFocusedRowCellValue("ProductoGenerico", Generico);
                gridView1.SetFocusedRowCellValue("IdUMedidaProv", UMProv);
                gridView1.SetFocusedRowCellValue("IdUMedidaVenta", UMVenta);
                gridView1.SetFocusedRowCellValue("ConvUMProv", ConvUMProv);
                gridView1.SetFocusedRowCellValue("ConvUMVenta", ConvUMVenta);
               

                gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                gridView1.ShowEditor();
            }
            catch
            {
                MessageBox.Show("No se pudo duplicar el Producto seleccionado. Revise los datos del Producto a duplicar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            gridView1.SaveLayoutToXml(AparienciaGridProductos);
            //MessageBox.Show("Despues");

           // this.Visible = false;
            //promowork_dataDataSet.Clear();
          //  this.Close();
        }

        private void proveedores_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
               gridView1.SetFocusedRowCellValue("IdProveedor", null);
              
            }
        }

        private void TipoProducto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmTiposProductos frm = new frmTiposProductos();
                frm.ShowDialog();
                this.tiposProductosTableAdapter.FillByEmpresa(promowork_dataDataSet.TiposProductos, VariablesGlobales.nIdEmpresaActual);
            }

            if (e.Button.Index == 2)
            {
                gridView1.SetFocusedRowCellValue("IdTipoProducto", null);
            }
        }

        private void GrupoProveedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                GruposProveedores frm = new GruposProveedores();
                frm.ShowDialog();
                this.tiposProveedoresTableAdapter.FillByEmpresa(promowork_dataDataSet.TiposProveedores, VariablesGlobales.nIdEmpresaActual);
            }

            if (e.Button.Index == 2)
            {
                gridView1.SetFocusedRowCellValue("IdTipoProveedor", null);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            //if (!gridView1.IsFilterRow(e.FocusedRowHandle))
            //{
            //    nIdTipoProducto = gridView1.GetFocusedRowCellValue("IdTipoProveedor") == DBNull.Value ? 0 : (int)gridView1.GetFocusedRowCellValue("IdTipoProveedor");
            //    nIdGrupo = gridView1.GetFocusedRowCellValue("IdGrupo") == DBNull.Value ? 0 : (int)gridView1.GetFocusedRowCellValue("IdGrupo");
            //}
            //else
            //{
            //    nIdTipoProducto = 0;
            //    nIdGrupo = 0;
            //}
        }

        private void PrecioMinimo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("PrecioMinimo", null);
            gridView1.SetFocusedRowCellValue("DescuentoPrecioMinimo", null);
            gridView1.SetFocusedRowCellValue("FechaPrecioMinimo", null);
            gridView1.SetFocusedRowCellValue("IdAlbaranCab", null);
        }

        
    }
}
