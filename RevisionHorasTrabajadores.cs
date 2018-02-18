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
    public partial class RevisionHorasTrabajadores : Form
    {
        public RevisionHorasTrabajadores()
        {
            InitializeComponent();
        }
        int nAno = VariablesGlobales.nAnoActual;
        byte nMes = VariablesGlobales.nMesActual;

        private void horasTrabajadasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.horasTrabajadoresBindingSource.EndEdit();
            this.horasTrabajadoresTableAdapter.Update(this.promowork_dataDataSet.HorasTrabajadores);

          //  MessageBox.Show(gridView1.RowCount.ToString());
            if (gridView1.RowCount==1)
            {
                marcaAnoTableAdapter.Fill(promowork_dataDataSet.MarcaAno, VariablesGlobales.nIdEmpresaActual);
                marcaMesTableAdapter.Fill(promowork_dataDataSet.MarcaMes, VariablesGlobales.nIdEmpresaActual);

                cbxano.SelectedValue = VariablesGlobales.nAnoActual;
                cbxmes.SelectedValue = VariablesGlobales.nMesActual;
            }
           

        }

        private void HorasMateriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.HorasTrabajadas' Puede moverla o quitarla según sea necesario.
           // this.horasTrabajadasTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadas);
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);

          //  HorasMateriales_Resize(null, null);
            this.WindowState = FormWindowState.Maximized;
            //this.splitContainer1.SplitterDistance =Convert.ToInt32( this.Height * 0.7);

            marcaAnoTableAdapter.Fill(promowork_dataDataSet.MarcaAno, VariablesGlobales.nIdEmpresaActual);
            marcaMesTableAdapter.Fill(promowork_dataDataSet.MarcaMes, VariablesGlobales.nIdEmpresaActual);

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
            this.trabajadoresTableAdapter.Fill(promowork_dataDataSet.Trabajadores, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ProductosUtilizados' table. You can move, or remove it, as needed.
          
            this.horasTrabajadoresTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual,nAno,nMes);
          //  this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMesActual);
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
                       
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.Appearance.Row.BackColor = Color.Silver;
            gridView2.OptionsBehavior.ReadOnly = true;
            gridView2.Appearance.Row.BackColor = Color.Silver;

            this.horasTrabajadoresBindingSource.MoveLast();
            cbxano.SelectedValue = VariablesGlobales.nAnoActual;
            cbxmes.SelectedValue = VariablesGlobales.nMesActual;
          
            this.cbxmes.SelectedValueChanged+=new EventHandler(cbxmes_SelectedValueChanged);
            this.horasTrabajadoresTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
           // this.promowork_dataDataSet.HorasTrabajadas.Columns.Add("TieneCopiaParte", typeof(bool), "iif(len(CopiaParte)>0, True, False)");
            //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
            this.promowork_dataDataSet.HorasTrabajadas.Columns.Add("Duplicado", typeof(bool));

        }

        private void horasTrabajadasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show(gridView1.GetFocusedRowCellValue("DiaTrab").ToString());
            gridView1.CloseEditor();
            int dia=0;
            try
                {
                    dia = int.Parse(gridView1.GetFocusedRowCellValue("DiaTrab").ToString());
                }
            catch { }
           // MessageBox.Show(dia.ToString());

            if (DateTime.DaysInMonth(nAno, nMes) < dia || dia<=0)
            {
                MessageBox.Show("Día Incorrecto.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    this.Validate();
                    this.horasTrabajadoresBindingSource.EndEdit();
                    this.horasTrabajadoresTableAdapter.Update(promowork_dataDataSet.HorasTrabajadores);

                    bool actualizar = false;

                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        bool Conf = false;
                         try
                         {
                             Conf = (bool)gridView1.GetRowCellValue(i, "Confirmado");
                         }
                        catch{}

                        // MessageBox.Show(gridView1.GetRowCellValue(i, "Confirmado").ToString());

                        if (Conf == true)
                        {
                            queriesTableAdapter1.ConfirmaPartesTrabajadores((int)gridView1.GetRowCellValue(i, "IdHoras"));
                            actualizar = true;

                        }

                    }

                    if (actualizar == true)
                    {
                        this.horasTrabajadoresTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
                    }
                    
                    //this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
                    /*  if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("HorasAdmin")) == true)
                      {
                          queriesTableAdapter1.ActualizaHorasAdmin(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTrabajador")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView1.GetFocusedRowCellValue("DiaTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("MesTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("AnoTrab")), Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Cantidad")), Convert.ToString(gridView1.GetFocusedRowCellValue("DesTrabajo")), null);
                      }
                      else
                      {
                          queriesTableAdapter1.ActualizaHorasAdmin(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTrabajador")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView1.GetFocusedRowCellValue("DiaTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("MesTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("AnoTrab")), 0, null, null);
                      }*/
                    if (cbxmes.SelectedIndex == -1)
                    {
                        marcaAnoTableAdapter.Fill(promowork_dataDataSet.MarcaAno, VariablesGlobales.nIdEmpresaActual);
                        marcaMesTableAdapter.Fill(promowork_dataDataSet.MarcaMes, VariablesGlobales.nIdEmpresaActual);

                        cbxano.SelectedValue = VariablesGlobales.nAnoActual;
                        cbxmes.SelectedValue = VariablesGlobales.nMesActual;
                    }


                    
                    

                   // MessageBox.Show(gridView1.GetFocusedRowCellDisplayText(colObsHoras).Trim());

                    //if (gridView1.GetFocusedRowCellDisplayText(colObsHoras).Trim() == "")
                    //{
                    //    queriesTableAdapter1.AgregaHorasExtraDia((int)gridView1.GetFocusedRowCellValue("IdHoras"));
                    //}

                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.horasTrabajadoresTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
                   // this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.horasTrabajadoresTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
                        //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
                    }

                }
                //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
             this.productosUtTrabajadoresTableAdapter.FillByHoras(this.promowork_dataDataSet.ProductosUtTrabajadores, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int? obra = (int?)gridView1.GetFocusedRowCellValue("IdObra");
            int? trabajador = (int?)gridView1.GetFocusedRowCellValue("IdTrabajador");
            int? tipo = (int?)gridView1.GetFocusedRowCellValue("IdTipo");
            int? categoria =(int?)gridView1.GetFocusedRowCellValue("IdCategoria");

            horasTrabajadoresBindingSource.AddNew();

            gridView1.SetFocusedRowCellValue("IdObra",obra);
            gridView1.SetFocusedRowCellValue("IdTrabajador", trabajador);
            gridView1.SetFocusedRowCellValue("IdTipo", tipo);
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
            gridView1.SetFocusedRowCellValue("IdUsuario", VariablesGlobales.nIdUsuarioActual);
            gridView1.SetFocusedRowCellValue("AnoTrab", nAno);
            gridView1.SetFocusedRowCellValue("MesTrab", nMes);
            gridView1.SetFocusedRowCellValue("Festivo", 0);
            gridView1.SetFocusedRowCellValue("HorasAdmin", 0);
            gridView1.SetFocusedRowCellValue("IdCategoria", categoria);
            
            gridView1.FocusedColumn = gridView1.VisibleColumns[0];
            gridView1.ShowEditor();
        }

        private void HorasMateriales_Resize(object sender, EventArgs e)
        {
           // horasTrabajadasGridControl.Width = this.Width - 16;
           // horasTrabajadasGridControl.Height = this.Height - 280;
           //// productosUtilizadosGridControl.Width = this.Width - 16;
           // productosUtilizadosGridControl.Location = new Point(0, this.Height-220);
           // horasTrabajadasTotalTrabajadorGridControl.Location = new Point(680, this.Height - 220);
           // horasTrabajadasTotalTrabajadorGridControl.Width = horasTrabajadasGridControl.Width - 680;
           // bindingNavigator1.Location = new Point(0, this.Height - 245);
           // groupBox1.Location = new Point(0, this.Height - 90);
           //// chkcobrado.Location = new Point(600, this.Height - 90);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.productosUtTrabajadoresBindingSource.EndEdit();
            int producto = 0;
            decimal pvp = 0;
            decimal descuento=0;
            decimal porciento=0;
            
            try { producto = (int)gridView2.GetFocusedRowCellValue("IdProducto"); }
            catch { }
            try { pvp=(decimal)gridView2.GetFocusedRowCellValue("PVP"); }
            catch { }
            try { descuento = (decimal)gridView2.GetFocusedRowCellValue("Descuento"); }
            catch { }
            try { porciento = (decimal)gridView2.GetFocusedRowCellValue("Porciento"); }
            catch { }

            this.productosUtTrabajadoresTableAdapter.Update(promowork_dataDataSet.ProductosUtTrabajadores);
            queriesTableAdapter1.ActualizaPrecioProducto(producto, pvp, descuento, porciento);
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.productosUtTrabajadoresTableAdapter.FillByHoras(this.promowork_dataDataSet.ProductosUtTrabajadores, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
                    
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.productosUtTrabajadoresTableAdapter.FillByHoras(this.promowork_dataDataSet.ProductosUtTrabajadores, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));

                    }

                }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gridView2.SetFocusedRowCellValue("IdHoras", gridView1.GetFocusedRowCellValue("IdHoras"));
            gridView2.FocusedColumn = gridView2.VisibleColumns[0];
            gridView2.ShowEditor();
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                DataRow trabajador = promowork_dataDataSet.Trabajadores.FindByIdTrabajador((int)gridView1.GetFocusedRowCellValue("IdTrabajador"));

                if (gridView1.FocusedColumn.FieldName == "Salario" && Convert.ToBoolean(gridView1.GetFocusedRowCellValue("Festivo")) == false && (bool)trabajador["SalMes"] == true)
                {
                    e.Cancel = true;
                }
            }
            catch { }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsBehavior.ReadOnly == true)
            {
                gridView1.OptionsBehavior.ReadOnly = false;
                gridView1.Appearance.Row.BackColor = Color.Empty;
                gridView2.OptionsBehavior.ReadOnly = false;
                gridView2.Appearance.Row.BackColor = Color.Empty;
                toolStripButton8.Text = "Bloquear";
            }
            else
            {
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView1.Appearance.Row.BackColor = Color.Silver;
                gridView2.OptionsBehavior.ReadOnly = true;
                gridView2.Appearance.Row.BackColor = Color.Silver;
                toolStripButton8.Text = "Editar";
            }

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.ShowDialog();
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
        }

       

      

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
         
            if (e.Column.Name == "codigo" || e.Column.Name == "descripcion")
            {
               try
               {

                DataRow Producto = promowork_dataDataSet.Productos.FindByIdProducto(int.Parse(gridView2.GetFocusedRowCellValue("IdProducto").ToString()));
              //  DataRowView Producto = (DataRowView)productosBindingSource.Current;
              //  MessageBox.Show(Producto["Descuento"].ToString());
                gridView2.SetFocusedRowCellValue("PVP", Producto["PVP"]);
                gridView2.SetFocusedRowCellValue("Descuento", Producto["Descuento"]);
                gridView2.SetFocusedRowCellValue("Porciento", Producto["Porciento"]);
               }
                catch{}
                
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.horasTrabajadoresBindingSource.RemoveCurrent();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.productosUtTrabajadoresBindingSource.RemoveCurrent();
            }
        }

      private void HorasMateriales_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
           // promowork_dataDataSet.Clear();
            this.Close();
        }

        private void cbxmes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxmes.SelectedIndex != -1)
            {
                try
                {
                    nAno = (int)cbxano.SelectedValue;
                    nMes = (byte)cbxmes.SelectedValue;
                }
                catch { }
            }
            else
            {
                nAno = VariablesGlobales.nAnoActual;
                nMes = VariablesGlobales.nMesActual;
            }
            
            this.horasTrabajadoresTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
           // MessageBox.Show(nAno.ToString() + "     " + nMes.ToString());
            //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);

            gridView1_FocusedRowChanged(null, null);
            
        }

     

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            gridView1_FocusedRowChanged(null, null);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            if (e.Column.Name == "colDiaTrab" || e.Column.Name=="colIdObra")
            {

                //MessageBox.Show(gridView1.GetFocusedRowCellValue("DiaTrab").ToString());

                try
                {

                this.festivosObrasDiaTableAdapter.Fill(promowork_dataDataSet.FestivosObrasDia, (int)gridView1.GetFocusedRowCellValue("IdObra"), (byte)gridView1.GetFocusedRowCellValue("DiaTrab"), nMes, nAno);

                    if (festivosObrasDiaBindingSource.Count>0)
                    {
                        gridView1.SetFocusedRowCellValue("Festivo", true);
                    }
                    else
                    {
                        gridView1.SetFocusedRowCellValue("Festivo", false);
                    }

                }
                catch
                { }

            //   // MessageBox.Show(e.Column.Name);
                
            //    DataRow trabajador = promowork_dataDataSet.Trabajadores.FindByIdTrabajador((int)gridView1.GetFocusedRowCellValue("IdTrabajador"));

            //    if ((bool)trabajador["SalMes"]==false)
            //    {
            //       // MessageBox.Show(trabajador["NomTrabajador"].ToString());
            //   //     gridView1.SetFocusedRowCellValue("Salario", 15);
            //        colSalario.OptionsColumn.AllowEdit = true;
            //        colSalario.OptionsColumn.ReadOnly = false;
            //    }
            }

            if (e.Column.Name == "colIdTrabajador")
            {

                DataRow trabajador = promowork_dataDataSet.Trabajadores.FindByIdTrabajador((int)e.Value);
               // gridView1.SetFocusedRowCellValue("IdTrabajador", trabajador["IdTrabajador"]);
                gridView1.SetFocusedRowCellValue("IdCategoria", trabajador["IdCategoria"]);
            }

          

        }

      
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
              

                    gridView1.SetFocusedRowCellValue("CopiaParte", openFileDialog1.FileName);
                    

                    //DataRowView HoraActual = (DataRowView)horasTrabajadoresBindingSource.Current;
                    //HoraActual["CopiaParte"] = openFileDialog1.FileName;
                    //copiaFacturaTextBox.Text = openFileDialog1.FileName;
                }
            }

            if (e.Button.Index == 1)
            {
              //  DataRowView HoraActual = (DataRowView)horasTrabajadoresBindingSource.Current;
                
                try 
                {
                    System.Diagnostics.Process.Start(gridView1.GetFocusedRowCellValue("CopiaParte").ToString());
                }
                catch
                {
                    MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void repositoryItemButtonEdit1_Enter(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("CopiaParte").ToString().Trim() == "")
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gridView1.SetFocusedRowCellValue("CopiaParte", openFileDialog1.FileName);

                }
            }
        }

        private void gridView1_ColumnFilterChanged_1(object sender, EventArgs e)
        {
            this.productosUtTrabajadoresTableAdapter.FillByHoras(this.promowork_dataDataSet.ProductosUtTrabajadores, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
        }



        //private void toolStripButton10_Click(object sender, EventArgs e)
        //{
        //    this.vPosiblesHorasDuplicadasTableAdapter.Fill(this.promowork_dataDataSet.vPosiblesHorasDuplicadas, VariablesGlobales.nIdEmpresaActual, nMes, nAno);
        //    if (vPosiblesHorasDuplicadasBindingSource.Count != 0)
        //    {
        //        if (gridView1.RowCount > 0)
        //        {

        //            for (int i = 0; i < gridView1.RowCount; i++)
        //            {

        //                int nIdHora = (int)gridView1.GetRowCellValue(i, "IdHoras");

        //                if (vPosiblesHorasDuplicadasBindingSource.Find("IdHoras", nIdHora.ToString()) != -1)
        //                {
        //                    gridView1.SetRowCellValue(i, "Duplicado", true);
        //                }

        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se han encontrado posibles duplicados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //}

       
       
       
        //private void toolStripButton11_Click(object sender, EventArgs e)
        //{
        //        queriesTableAdapter1.AgregaHorasExtra(VariablesGlobales.nIdEmpresaActual, nAno, nMes, 1);
        //        horasTrabajadoresTableAdapter.FillByEmpresaMesAno(promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
        // }

        //private void toolStripButton12_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        byte? dia = (byte?)gridView1.GetFocusedRowCellValue("DiaTrab");
        //        int? obra = (int?)gridView1.GetFocusedRowCellValue("IdObra");
        //        int? trabajador = (int?)gridView1.GetFocusedRowCellValue("IdTrabajador");
        //        int? tipo = (int?)gridView1.GetFocusedRowCellValue("IdTipo");
        //        int? categoria = (int?)gridView1.GetFocusedRowCellValue("IdCategoria");
        //        string albaran = gridView1.GetFocusedRowCellValue("Albaran").ToString();

        //        decimal? cantidad = null;
        //        try
        //        {
        //            cantidad = (decimal?)gridView1.GetFocusedRowCellValue("Cantidad");
        //        }
        //        catch { }

        //        decimal? cantadmin = null;
        //        try
        //        {
        //            cantadmin = (decimal?)gridView1.GetFocusedRowCellValue("CantAdmin");
        //        }
        //        catch { }
        //        string destrabajo = gridView1.GetFocusedRowCellValue("DesTrabajo").ToString();
        //        string dirtrabajo = gridView1.GetFocusedRowCellValue("DirTrabajo").ToString();
        //        string copiaparte = gridView1.GetFocusedRowCellValue("CopiaParte").ToString();
        //        bool? festivo = (bool?)gridView1.GetFocusedRowCellValue("Festivo");
        //        string ObsHoras = gridView1.GetFocusedRowCellValue("ObsHoras").ToString();  


        //        horasTrabajadoresBindingSource.AddNew();

        //        gridView1.SetFocusedRowCellValue("DiaTrab", dia);
        //        gridView1.SetFocusedRowCellValue("IdObra", obra);
        //        gridView1.SetFocusedRowCellValue("IdTrabajador", trabajador);
        //        gridView1.SetFocusedRowCellValue("IdTipo", tipo);
        //        gridView1.SetFocusedRowCellValue("Albaran", albaran);
        //        gridView1.SetFocusedRowCellValue("Cantidad", cantidad);
        //        gridView1.SetFocusedRowCellValue("CantAdmin", cantadmin);
        //        gridView1.SetFocusedRowCellValue("DesTrabajo", destrabajo);
        //        gridView1.SetFocusedRowCellValue("DirTrabajo", dirtrabajo);
        //        gridView1.SetFocusedRowCellValue("CopiaParte", copiaparte);
        //        gridView1.SetFocusedRowCellValue("Festivo", festivo);
        //        gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
        //        gridView1.SetFocusedRowCellValue("IdUsuario", VariablesGlobales.nIdUsuarioActual);
        //        gridView1.SetFocusedRowCellValue("AnoTrab", nAno);
        //        gridView1.SetFocusedRowCellValue("MesTrab", nMes);
        //        gridView1.SetFocusedRowCellValue("Festivo", festivo);
        //        gridView1.SetFocusedRowCellValue("HorasAdmin", cantadmin);
        //        gridView1.SetFocusedRowCellValue("IdCategoria", categoria);
        //        gridView1.SetFocusedRowCellValue("ObsHoras", ObsHoras);

        //        gridView1.FocusedColumn = gridView1.VisibleColumns[0];
        //        gridView1.ShowEditor();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No se pudo duplicar el parte seleccionado. Revise los datos del parte a duplicar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

       
       
      

    }
}
