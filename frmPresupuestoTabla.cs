using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace Promowork
{
    public partial class frmPresupuestoTabla : Form
    {
        public frmPresupuestoTabla()
        {
            InitializeComponent();
        }

        int presupCab = 0;
        DevExpress.XtraGrid.Views.Grid.GridView viewSub;
        DevExpress.XtraGrid.Views.Grid.GridView viewDet;
       
        private void frmPresupuestoTabla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosPresupuestos.PresupSub' Puede moverla o quitarla según sea necesario.
           // this.presupSubTableAdapter.Fill(this.datosPresupuestos.PresupSub);
            // TODO: esta línea de código carga datos en la tabla 'datosPresupuestos.PresupDet' Puede moverla o quitarla según sea necesario.
          //  this.presupDetTableAdapter.Fill(this.datosPresupuestos.PresupDet);
            this.WindowState = FormWindowState.Maximized;
            this.presupCabTableAdapter.FillByEmpresaAno(this.datosPresupuestos.PresupCab, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual);
            this.anosPresupuestosTableAdapter.FillByEmpresa(this.datosPresupuestos.AnosPresupuestos, VariablesGlobales.nIdEmpresaActual);
            this.clientesTableAdapter.FillByEmpresa(this.datosPresupuestos.Clientes, VariablesGlobales.nIdEmpresaActual);
            this.obrasTableAdapter.FillByEmpresa(this.datosPresupuestos.Obras, VariablesGlobales.nIdEmpresaActual);


            lookUpEdit1.EditValue = VariablesGlobales.nAnoActual;
           
        }


        private void presupCabBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.Validate();

                this.presupSubBindingSource.EndEdit();
                this.presupSubTableAdapter.Update(datosPresupuestos.PresupSub);

                this.presupDetBindingSource.EndEdit();
                this.presupDetTableAdapter.Update(datosPresupuestos.PresupDet);

                this.presupCapBindingSource.EndEdit();
                this.presupCapTableAdapter.Update(datosPresupuestos.PresupCap);

                this.presupCabBindingSource.EndEdit();
                this.presupCabTableAdapter.Update(datosPresupuestos.PresupCab);
                ActualizaIdPresupCab();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los Cambios no se Guardaron.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            ActualizaIdPresupCab();

            CargarPresupuesto();
           
        }

        private void ActualizaIdPresupCab()
        {
            try
            {
                presupCab = (int)gridView1.GetFocusedRowCellValue("IdPresupCab");
            }
            catch { presupCab = 0; }
        }

        private void CargarPresupuesto()
        {
            try
            {
                //MessageBox.Show(presupCab.ToString());
                
                this.presupSubTableAdapter.FillByPresupuesto(this.datosPresupuestos.PresupSub, presupCab);
                this.presupDetTableAdapter.FillByPresupuesto(this.datosPresupuestos.PresupDet, presupCab);
                this.presupCapTableAdapter.FillByPresupuesto(this.datosPresupuestos.PresupCap, presupCab);

                spnUltCertificacion.Value= (int) queriesPresupuestos1.ObtenerUltimaCertificacion(presupCab);
                certificacionAFacturarSpinEdit.Value = (decimal)gridView1.GetFocusedRowCellValue("aFacturar") == 0 ? spnUltCertificacion.Value + 1 : certificacionAFacturarSpinEdit.Value;
            }
            catch {
                // MessageBox.Show("Error al cargar el Presupuesto"); 
                }
        }

        

        private void gridView2_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e)
        {
            

            if ((int)gridView2.GetRowCellValue(e.RowHandle, "IdPresupCap") < 0)
            {
                MessageBox.Show("No puede crear detalles antes de guardar los cambios en el Capítulo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Allow = false;

            }
            
          
        }

        private void gridView3_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

          
                if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["IdPresupDet"]) < 0)
                {
                    MessageBox.Show("No puede crear subdetalles antes de guardar los cambios en el Detalle", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    e.Allow = false;

                }
                //else if (view.GetDetailView(e.RowHandle, e.RelationIndex).RowCount == 0)
                //    {
                //        MessageBox.Show("Si crea un subdetalles la cantidad y precio del detalle actual serán eliminados y el total se reemplazara por el total de los subdetalles creados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.presupCabTableAdapter.FillByEmpresaAno(this.datosPresupuestos.PresupCab, VariablesGlobales.nIdEmpresaActual, (int)lookUpEdit1.EditValue);
            CargarPresupuesto();
        }

        private void Obras_QueryPopUp(object sender, CancelEventArgs e)
        {
            if ((decimal)gridView1.GetFocusedRowCellValue("TotalPresupFact") != 0)
            {
                e.Cancel=true;
            }
            else
            {
                //Obras.DataSource = "obrasBindingSource1";
                if (gridView1.GetFocusedRowCellValue("IdCliente").ToString() != string.Empty)
                {
                    
                    obrasBindingSource.Filter = "IdCliente=" + gridView1.GetFocusedRowCellValue("IdCliente").ToString();
                }
                else
                {
                    obrasBindingSource.Filter = "IdCliente is NULL";
                }
            }
        }

        private void Obras_QueryCloseUp(object sender, CancelEventArgs e)
        {
            obrasBindingSource.RemoveFilter();
            //MessageBox.Show("Poner todo");
           // Obras.DataSource = "obrasBindingSource";
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idClienteComboBox.SelectedIndex != -1)
            {

                obrasBindingSource1.Filter = "IdCliente=" + idClienteComboBox.SelectedValue.ToString();
            }
            else
            {
                obrasBindingSource1.Filter = "IdCliente is NULL";
            }

            //MessageBox.Show(gridView1.GetFocusedRowCellValue("IdObra").ToString());
            try
            {
                idObraComboBox.SelectedValue = gridView1.GetFocusedRowCellValue("IdObra");
            }
            catch { }
        }

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                EliminaFila(view);
                
                //if (MessageBox.Show("¿Desea Eliminar los Capítulos Seleccionados?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                //    view.DeleteSelectedRows();
                //}
            }
        }

        private void gridView3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                EliminaFila(view);
                
                
                //if (MessageBox.Show("¿Desea Eliminar los Detalles Seleccionados?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                //    view.DeleteSelectedRows();
                //    //gridView3.DeleteSelectedRows();
                //}
            }
        }

        private void gridView4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                EliminaFila(view);
                
                //if (MessageBox.Show("¿Desea Eliminar los SubDetalles Seleccionados?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                //    view.DeleteSelectedRows();
                //}
            }
        }

      
        private void gridView4_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //////////DevExpress.XtraGrid.Views.Grid.GridView viewSub = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //////////DevExpress.XtraGrid.Views.Grid.GridView viewDet = viewSub.ParentView as DevExpress.XtraGrid.Views.Grid.GridView;

            //int masterindex = viewSub.GetRelationIndex(e.DefaultRelationIndex;

            // MessageBox.Show(masterindex.ToString());

            //////////viewDet.SetFocusedRowCellValue("Cantidad", null);
            //////////viewDet.SetFocusedRowCellValue("Precio", null);
            //////////viewDet.SetFocusedRowCellValue("CantExtra", null);
            //////////viewDet.SetFocusedRowCellValue("aFacturar", null);

            //view.SetRowCellValue(e.RowHandle, view.Columns["IdPresupCab"], presupCab);
            //MessageBox.Show(gridView3.GetFocusedRowCellValue("IdPresupCap").ToString());
            //view.SetRowCellValue(e.RowHandle, view.Columns["IdPresupCap"], gridView3.GetFocusedRowCellValue("IdPresupCap"));
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            numPresupSpinEdit.Focus();
            gridView1.AddNewRow();
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
            gridView1.SetFocusedRowCellValue("IdUsuario", VariablesGlobales.nIdUsuarioActual);
            fechaPresupDateEdit.EditValue = DateTime.Today;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("La factura creada será considerada como una previsión. Para hacerla efectiva debe acceder por la opción de Facturas de Presupuestos y asignarle el número correspondiente, rellenar los demás datos necesarios y desmarcar la casilla de Previsión. ¿Desea Crear la Factura?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                toolStripButton7_Click(null, null);
                queriesPresupuestos1.CreaFacturaPresupuesto(presupCab);
                gridView1.SetFocusedRowCellValue("ModifCab", DateTime.Now);

                this.Validate();
                this.presupCabBindingSource.EndEdit();
                this.presupCabTableAdapter.Update(datosPresupuestos.PresupCab);
                CargarPresupuesto();
            }
            
        }

        
        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView viewSub = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.Column == viewSub.Columns["Cantidad"] || e.Column == viewSub.Columns["Precio"] || e.Column == viewSub.Columns["CantExtra"] || e.Column == viewSub.Columns["aFacturar"])
            {
                DevExpress.XtraGrid.Views.Grid.GridView viewDet = viewSub.ParentView as DevExpress.XtraGrid.Views.Grid.GridView;
                DevExpress.XtraGrid.Views.Grid.GridView viewCap = viewDet.ParentView as DevExpress.XtraGrid.Views.Grid.GridView;

                viewDet.SetFocusedRowCellValue("ModifDet", DateTime.Now);
                viewCap.SetFocusedRowCellValue("ModifCap", DateTime.Now);
                gridView1.SetFocusedRowCellValue("ModifCab", DateTime.Now);

                viewDet.SetFocusedRowCellValue("Cantidad", null);
                viewDet.SetFocusedRowCellValue("Precio", null);
                viewDet.SetFocusedRowCellValue("CantExtra", null);
                viewDet.SetFocusedRowCellValue("aFacturar", null);


                try
                {
                    decimal CantidadExtra = viewSub.GetFocusedRowCellValue("CantExtra") == DBNull.Value ? 0 : (decimal)viewSub.GetFocusedRowCellValue("CantExtra");
                    decimal CntidadAFacturar = viewSub.GetFocusedRowCellValue("aFacturar") == DBNull.Value ? 0 : (decimal)viewSub.GetFocusedRowCellValue("aFacturar");
                    decimal CantidadPendiente = viewSub.GetFocusedRowCellValue("Pendiente") == DBNull.Value ? 0 : (decimal)viewSub.GetFocusedRowCellValue("Pendiente");


                    if (CntidadAFacturar > CantidadPendiente)
                    {
                        if (MessageBox.Show("Cantidad A Facturar superior a lo Pendiente. ¿Desea establecer la diferencia como Extra?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            viewSub.SetFocusedRowCellValue("CantExtra", CantidadExtra + CntidadAFacturar - CantidadPendiente);
                        }
                        else
                        {
                            viewSub.SetFocusedRowCellValue("aFacturar", CantidadPendiente);
                        }
                    }
                }
                catch { }
            }
        }

        private bool TieneSubdetalle(int detalle)
        {
            presupSubBindingSource.Filter = "IdPresupDet="+detalle.ToString();

            double cantidad=0;
            double cantidadExtra=0;
            double aFacturar=0;
            double precio=0;

            foreach (DataRowView sub in presupSubBindingSource)
            {
                double.TryParse(sub["Cantidad"].ToString(), out cantidad);
                double.TryParse(sub["Precio"].ToString(), out precio);
                double.TryParse(sub["CantExtra"].ToString(), out cantidadExtra);
                double.TryParse(sub["aFacturar"].ToString(), out aFacturar);

                if (cantidad + precio + cantidadExtra + aFacturar > 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView viewDet = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            //DevExpress.XtraGrid.Views.Grid.GridView viewSub = viewDet.GetDetailView(e.RowHandle, 0) as DevExpress.XtraGrid.Views.Grid.GridView;


            if (e.Column == viewDet.Columns["Cantidad"] || e.Column == viewDet.Columns["Precio"] || e.Column == viewDet.Columns["CantExtra"] || e.Column == viewDet.Columns["aFacturar"])
            {

                DevExpress.XtraGrid.Views.Grid.GridView viewCap = viewDet.ParentView as DevExpress.XtraGrid.Views.Grid.GridView;
                viewCap.SetFocusedRowCellValue("ModifCap", DateTime.Now);
                gridView1.SetFocusedRowCellValue("ModifCab", DateTime.Now);

                try
                {
                    decimal CantidadExtra = viewDet.GetFocusedRowCellValue("CantExtra") == DBNull.Value ? 0 : (decimal)viewDet.GetFocusedRowCellValue("CantExtra");
                    decimal CntidadAFacturar = viewDet.GetFocusedRowCellValue("aFacturar") == DBNull.Value ? 0 : (decimal)viewDet.GetFocusedRowCellValue("aFacturar");
                    decimal CntidadPendiente = viewDet.GetFocusedRowCellValue("Pendiente") == DBNull.Value ? 0 : (decimal)viewDet.GetFocusedRowCellValue("Pendiente");


                    if (CntidadAFacturar > CntidadPendiente)
                    {
                        if (MessageBox.Show("Cantidad A Facturar superior a lo Pendiente. ¿Desea establecer la diferencia como Extra?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            viewDet.SetFocusedRowCellValue("CantExtra", CantidadExtra + CntidadAFacturar - CntidadPendiente);
                        }
                        else
                        {
                            viewDet.SetFocusedRowCellValue("aFacturar", CntidadPendiente);
                        }
                    }
                }
                catch { }
                
            }

            
        }

        private void gridView3_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView viewDet = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            ////DevExpress.XtraGrid.Views.Grid.GridView viewSub = viewDet.GetDetailView(e.RowHandle, 0) as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.Column == viewDet.Columns["Cantidad"] || e.Column == viewDet.Columns["Precio"] || e.Column == viewDet.Columns["CantExtra"] || e.Column == viewDet.Columns["aFacturar"])
            {
                int idDetalle = (int)viewDet.GetFocusedRowCellValue("IdPresupDet");
                if (TieneSubdetalle(idDetalle))
                {




                    //////////     //var subValido = false;
                    //////////     //for (int i = 0; i < viewSub1.RowCount; i++)
                    //////////     //{
                    //////////     //    var aaaa = viewSub1.GetDataRow(i);
                    //////////     //    var bbb = viewSub1.GetDataRow(i).Table;



                    //////////     //    viewSub.FocusedRowHandle = i;
                    //////////     //    var cantidad = viewSub1.GetFocusedRowCellValue("Cantidad");
                    //////////     //    var cantExtra = viewSub1.GetFocusedRowCellValue("CantExtra");
                    //////////     //    var precio = viewSub1.GetFocusedRowCellValue("Precio");
                    //////////     //    var aFacturar = viewSub1.GetFocusedRowCellValue("aFacturar");


                    //////////     //    //if ((cantidad+cantExtra)*precio!=0 || aFacturar!=0)
                    //////////     //    //{
                    //////////     //    //    subValido = true;
                    //////////     //    //    break;
                    //////////     //    //}
                    //////////     //}

                    //////////     //if (subValido)
                    //////////     //{

                    MessageBox.Show("No puede haber Cantidad, Precio, Cantidad Extra o A Facturar en un Detalle que contiene Subdetalle", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //var ccc = viewDet.GetFocusedRowCellValue("Cantidad");

                    viewDet.SetFocusedRowCellValue("Cantidad", null);
                    viewDet.SetFocusedRowCellValue("Precio", null);
                    viewDet.SetFocusedRowCellValue("CantExtra", null);
                    viewDet.SetFocusedRowCellValue("aFacturar", null);
                    //////////    /// }

                }

            }
        }

        private void gridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView2.SetFocusedRowCellValue("IdPresupCab", gridView1.GetFocusedRowCellValue("IdPresupCab"));
        }


      

        private void toolStripButton6_Click(object sender, EventArgs e)
        {


            if (toolStripButton6.Text == "+")
            {
              
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                  //  RecursExpand(gridView2, i);

                    gridView2.SetMasterRowExpanded(i, true);
                   

                }
               
                toolStripButton6.Text = "-";
              //  toolStripButton6.Tag = "-";
            }
            else
            {
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    gridView2.CollapseAllDetails();
                    //gridView2.SetRowExpanded(i, false, true);
                }
                toolStripButton6.Text = "+";
                toolStripButton1.Text = "+";
                //toolStripButton6.Tag = "+";

            }
           // toolStripButton6.ForeColor = Color.Black;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (toolStripButton1.Text == "+")
            {

                gridView2.BeginUpdate();
                
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    
                        
                    gridView2.SetMasterRowExpanded(i, true);

                    try
                    {
                        GridView detalle = (GridView)gridView2.GetDetailView(i, 0);
                        detalle.OptionsDetail.AllowExpandEmptyDetails = false;

                        for (int j = 0; j < detalle.RowCount; j++)
                        {
                            
                                detalle.SetMasterRowExpanded(j, true);
                            
                        }
                        detalle.OptionsDetail.AllowExpandEmptyDetails = true;
                        
                    }
                    catch
                    { }
                }
                gridView2.EndUpdate();
                toolStripButton1.Text = "-";
                toolStripButton6.Text = "-";
               // toolStripButton1.Tag = "-";
            }
            else
            {

                gridView2.BeginUpdate();
                for (int i = 0; i < gridView2.RowCount; i++)
                {

                    //  gridView3.SetMasterRowExpanded(i, true);

                    try
                    {
                        GridView detalle = (GridView)gridView2.GetDetailView(i, 0);
                        //MessageBox.Show(detalle.RowCount.ToString());
                        for (int j = 0; j < detalle.RowCount; j++)
                        {
                            detalle.SetMasterRowExpanded(j, false);
                        }

                    }
                    catch
                    { }
                }
                gridView2.EndUpdate();
                toolStripButton1.Text = "+";
              //  toolStripButton1.Tag = "+";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GridView GridActiva = (GridView)presupCapGridControl.FocusedView;
            GridActiva.AddNewRow();
            //GridActiva.SelectCell(GridActiva.FocusedRowHandle, GridActiva.Columns[0]);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)presupCapGridControl.FocusedView;
            EliminaFila(view);
            
        }

        private void EliminaFila(GridView GridActiva)
        {
            if (MessageBox.Show("¿Desea Eliminar el elemento Seleccionado?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              //  

                // MessageBox.Show(GridActiva.DetailLevel.ToString());

                //GridView GridActiva = (GridView)presupCapGridControl.FocusedView;
                GridActiva.DeleteSelectedRows();

                if (GridActiva.DetailLevel == 0)
                {
                    gridView1.SetFocusedRowCellValue("ModifCab", DateTime.Now);
                }

                if (GridActiva.DetailLevel == 1)
                {
                    DevExpress.XtraGrid.Views.Grid.GridView viewCap = GridActiva.ParentView as DevExpress.XtraGrid.Views.Grid.GridView;
                    viewCap.SetFocusedRowCellValue("ModifCap", DateTime.Now);
                    gridView1.SetFocusedRowCellValue("ModifCab", DateTime.Now);
                }


                if (GridActiva.DetailLevel == 2)
                {

                    DevExpress.XtraGrid.Views.Grid.GridView viewDet = GridActiva.ParentView as DevExpress.XtraGrid.Views.Grid.GridView;
                    DevExpress.XtraGrid.Views.Grid.GridView viewCap = viewDet.ParentView as DevExpress.XtraGrid.Views.Grid.GridView;
                    viewDet.SetFocusedRowCellValue("ModifDet", DateTime.Now);
                    viewCap.SetFocusedRowCellValue("ModifCap", DateTime.Now);
                    gridView1.SetFocusedRowCellValue("ModifCab", DateTime.Now);

                }
            }
        
        
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();

                this.presupSubBindingSource.EndEdit();
                this.presupSubTableAdapter.Update(datosPresupuestos.PresupSub);

                this.presupDetBindingSource.EndEdit();
                this.presupDetTableAdapter.Update(datosPresupuestos.PresupDet);

                this.presupCapBindingSource.EndEdit();
                this.presupCapTableAdapter.Update(datosPresupuestos.PresupCap);

                this.presupCabBindingSource.EndEdit();
                this.presupCabTableAdapter.Update(datosPresupuestos.PresupCab);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los Cambios no se Guardaron.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el Presupuesto Seleccionado?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
            }
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
          
            int Presupuesto = (int)gridView1.GetFocusedRowCellValue("IdPresupCab");


            RptPresupuestoActual frm = new RptPresupuestoActual();
            frm.LoadFiltro(Presupuesto);
            frm.MdiParent = this.MdiParent;
            frm.Show();

            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int Presupuesto = (int)gridView1.GetFocusedRowCellValue("IdPresupCab");
            bool SoloCertificaciones = true;
            //if (MessageBox.Show("¿Mostrar Certificaciones?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //{
            //    MostarCertificaciones = true;
            //}
           

            RptPresupuestoActualFcatCob frm = new RptPresupuestoActualFcatCob();
            frm.LoadFiltro(Presupuesto, SoloCertificaciones);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            int Presupuesto = (int)gridView1.GetFocusedRowCellValue("IdPresupCab");

            RptPresupuestoaFacturar frm = new RptPresupuestoaFacturar();
            frm.LoadFiltro(Presupuesto);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // for (int i=0; i= gridView1
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            int Presupuesto = (int)gridView1.GetFocusedRowCellValue("IdPresupCab");
            queriesPresupuestos1.DuplicaPresupuesto(Presupuesto);
            frmPresupuestoTabla_Load(null, null);
        }

        private void aFacturarDet_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.Validate();
            this.presupDetBindingSource.EndEdit();
            try
            {
                decimal CantFacturado = viewDet.GetFocusedRowCellValue("CantDetFact") == DBNull.Value ? 0 : (decimal)viewDet.GetFocusedRowCellValue("CantDetFact");

                decimal CantidadAFacturar = viewDet.GetFocusedRowCellValue("aFacturar") == DBNull.Value ? 0 : (decimal)viewDet.GetFocusedRowCellValue("aFacturar");

                decimal Cantidad = viewDet.GetFocusedRowCellValue("Cantidad") == DBNull.Value ? 0 : (decimal)viewDet.GetFocusedRowCellValue("Cantidad");

                viewDet.SetFocusedRowCellValue("CantExtra", CantFacturado + CantidadAFacturar - Cantidad);
               
            }
            catch { }
        }

        private void aFacturarSub_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.Validate();
            this.presupSubBindingSource.EndEdit();
            try
            {
                decimal CantFacturado = viewSub.GetFocusedRowCellValue("CantSubFact") == DBNull.Value ? 0 : (decimal)viewSub.GetFocusedRowCellValue("CantSubFact");

                decimal CantidadAFacturar = viewSub.GetFocusedRowCellValue("aFacturar") == DBNull.Value ? 0 : (decimal)viewSub.GetFocusedRowCellValue("aFacturar");

                decimal Cantidad = viewSub.GetFocusedRowCellValue("Cantidad") == DBNull.Value ? 0 : (decimal)viewSub.GetFocusedRowCellValue("Cantidad");

                viewSub.SetFocusedRowCellValue("CantExtra", CantFacturado + CantidadAFacturar - Cantidad);
            }
            catch { }
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            viewDet = sender as DevExpress.XtraGrid.Views.Grid.GridView;
        }

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            viewSub = sender as DevExpress.XtraGrid.Views.Grid.GridView;
        }

        private void btGenerarPartidas_Click(object sender, EventArgs e)
        {
            frmAgregarPartidasPresupuesto frm = new frmAgregarPartidasPresupuesto(presupCab);
            frm.ShowDialog();
            CargarPresupuesto();
        }

    }
}
