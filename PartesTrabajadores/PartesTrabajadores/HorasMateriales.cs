using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartesTrabajadores
{
    public partial class HorasMateriales : Form
    {
        public HorasMateriales()
        {
            InitializeComponent();
        }
        int nAno = DateTime.Today.Year;
        byte nMes = (byte) DateTime.Today.Month; 
       // int CategoriaTrabajador;
        int Tipo;

       

        private void HorasMateriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Tipos' Puede moverla o quitarla según sea necesario.
          //  this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            //nAno = VariablesGlobales.nAnoActual;
            //nMes = VariablesGlobales.nMesActual;
           
            this.WindowState = FormWindowState.Maximized;
            
            //txtMes.Properties.MaxValue = 12;
            //txtMes.Properties.MinValue = 1;
            //
            //txtAno.Properties.MaxValue = 3000;
            //txtAno.Properties.MinValue = 1000;

            
            txtMes.Value = nMes;
            
            txtAno.Value = nAno;
           // MessageBox.Show("aaaa");
            
            //this.splitContainer1.SplitterDistance =Convert.ToInt32( this.Height * 0.7);

            //marcaAnoTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.MarcaAno, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nIdTrabajadorActual);
            //marcaMesTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.MarcaMes, VariablesGlobales.nIdEmpresaActual,VariablesGlobales.nIdTrabajadorActual);

           //this.trabajadoresTableAdapter.FillByTrabajador(promowork_dataDataSet.Trabajadores, VariablesGlobales.nIdTrabajadorActual);

            //dataRowView trabajador = (DataRowView)trabajadoresBindingSource.Current;
            txtTrabajador.Text = VariablesGlobales.NombreTrabajador;
           // CategoriaTrabajador = VariablesGlobales.nIdCategoria;

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.FillByPredeterminado(this.promowork_dataDataSet.Tipos);
            DataRowView TipoPredeterminado = (DataRowView)tiposBindingSource.Current;
            Tipo = (int)TipoPredeterminado["IdTipo"];
            
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ProductosUtilizados' table. You can move, or remove it, as needed.
          
          //  this.horasTrabajadasTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadas, VariablesGlobales.nIdEmpresaActual,nAno,nMesActual);
          //  this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMesActual);
            //////DateTime fecha = new DateTime(nAno, nMes, 1);
            //////this.productosTableAdapter.FillByUtilizados(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual, fecha.AddDays(-60), fecha.AddDays(-30));
          //  this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
                       
            //gridView1.OptionsBehavior.ReadOnly = true;
            //gridView1.Appearance.Row.BackColor = Color.Silver;
            //gridView2.OptionsBehavior.ReadOnly = true;
            //gridView2.Appearance.Row.BackColor = Color.Silver;

            DateTime fecha = new DateTime(nAno, nMes, 1);
            this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual); //, fecha.AddDays(-90), fecha.AddDays(-30));

            this.horasTrabajadoresBindingSource.MoveLast();
            
            
            
          
           // this.cbxmes.SelectedValueChanged+=new EventHandler(cbxmes_SelectedValueChanged);
          /////////  this.horasTrabajadoresTableAdapter.FillByEmpTrabAnoMes(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nMes, nAno, VariablesGlobales.nIdTrabajadorActual);
           // this.promowork_dataDataSet.HorasTrabajadas.Columns.Add("TieneCopiaParte", typeof(bool), "iif(len(CopiaParte)>0, True, False)");
           // this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);

            spnDia.MaxValue = DateTime.DaysInMonth(nAno, nMes);
            spnDia.MinValue = 1;

        }

        private void horasTrabajadasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show(gridView1.GetFocusedRowCellValue("DiaTrab").ToString());
            gridView1.CloseEditor();
           
                try
                {
                    this.Validate();
                    this.horasTrabajadoresBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
                    /*  if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("HorasAdmin")) == true)
                      {
                          queriesTableAdapter1.ActualizaHorasAdmin(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTrabajador")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView1.GetFocusedRowCellValue("DiaTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("MesTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("AnoTrab")), Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Cantidad")), Convert.ToString(gridView1.GetFocusedRowCellValue("DesTrabajo")), null);
                      }
                      else
                      {
                          queriesTableAdapter1.ActualizaHorasAdmin(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTrabajador")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView1.GetFocusedRowCellValue("DiaTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("MesTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("AnoTrab")), 0, null, null);
                    //  }*/
                    //if (cbxmes.SelectedIndex == -1)
                    //{
                    //    marcaAnoTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.MarcaAno, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nIdTrabajadorActual);
                    //    marcaMesTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.MarcaMes, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nIdTrabajadorActual);

                    //    cbxano.SelectedValue = VariablesGlobales.nAnoActual;
                    //    cbxmes.SelectedValue = VariablesGlobales.nMesActual;
                    //}

                   // MessageBox.Show(gridView1.GetFocusedRowCellDisplayText(colObsHoras).Trim());

                   

                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.horasTrabajadoresTableAdapter.FillByEmpTrabAnoMes(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nMes, nAno, VariablesGlobales.nIdTrabajadorActual);
                    //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.horasTrabajadoresTableAdapter.FillByEmpTrabAnoMes(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nMes, nAno, VariablesGlobales.nIdTrabajadorActual);
                       // this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
                    }

                }
              //  this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
            

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.productosUtTrabajadoresTableAdapter.FillByHoras(this.promowork_dataDataSet.ProductosUtTrabajadores, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int? obra = (int?)gridView1.GetFocusedRowCellValue("IdObra");
            //int? trabajador = VariablesGlobales.nIdTrabajadorActual;
           // int? tipo = (int?)gridView1.GetFocusedRowCellValue("IdTipo");
            //int? categoria =(int?)gridView1.GetFocusedRowCellValue("IdCategoria");

            horasTrabajadoresBindingSource.AddNew();

            gridView1.SetFocusedRowCellValue("IdObra",obra);
            gridView1.SetFocusedRowCellValue("IdTrabajador", VariablesGlobales.nIdTrabajadorActual);
            gridView1.SetFocusedRowCellValue("IdTipo", Tipo);
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);

            gridView1.SetFocusedRowCellValue("AnoTrab", nAno);
            gridView1.SetFocusedRowCellValue("MesTrab", nMes);
            gridView1.SetFocusedRowCellValue("Festivo", 0);
            gridView1.SetFocusedRowCellValue("HorasAdmin", 0);
            gridView1.SetFocusedRowCellValue("IdCategoria", VariablesGlobales.nIdCategoria);
            
            gridView1.FocusedColumn = gridView1.VisibleColumns[0];
            gridView1.ShowEditor();
        }

      
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.productosUtTrabajadoresBindingSource.EndEdit();
            //int producto = 0;
            //decimal pvp = 0;
            //decimal descuento=0;
            //decimal porciento=0;
            
            //try { producto = (int)gridView2.GetFocusedRowCellValue("IdProducto"); }
            //catch { }
            //try { pvp=(decimal)gridView2.GetFocusedRowCellValue("PVP"); }
            //catch { }
            //try { descuento = (decimal)gridView2.GetFocusedRowCellValue("Descuento"); }
            //catch { }
            //try { porciento = (decimal)gridView2.GetFocusedRowCellValue("Porciento"); }
            //catch { }

            this.productosUtTrabajadoresTableAdapter.Update(promowork_dataDataSet.ProductosUtTrabajadores);
           // queriesTableAdapter1.ActualizaPrecioProducto(producto, pvp, descuento, porciento);
          //  this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
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

        //private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        DataRow trabajador = promowork_dataDataSet.Trabajadores.FindByIdTrabajador((int)gridView1.GetFocusedRowCellValue("IdTrabajador"));

        //        if (gridView1.FocusedColumn.FieldName == "Salario" && Convert.ToBoolean(gridView1.GetFocusedRowCellValue("Festivo")) == false && (bool)trabajador["SalMes"] == true)
        //        {
        //            e.Cancel = true;
        //        }
        //    }
        //    catch { }
        //}

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
            //this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);

            DateTime fecha = new DateTime(nAno, nMes, 1);
            this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);//, fecha.AddDays(-60), fecha.AddDays(-30));
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

      //private void HorasMateriales_FormClosing(object sender, FormClosingEventArgs e)
      //  {
      //      this.Visible = false;
      //     // promowork_dataDataSet.Clear();
      //      this.Close();
      //  }

        //private void cbxmes_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (cbxmes.SelectedIndex != -1 && cbxano.SelectedIndex!=-1 && cbxano.Text.Trim()!="" && cbxmes.Text.Trim()!="")
        //    {
        //        //MessageBox.Show(cbxmes.SelectedValue.ToString() + "     " + cbxmes.SelectedIndex.ToString());
        //            nAno = (int)cbxano.SelectedValue;
        //            nMes = (byte)cbxmes.SelectedValue;

        //           // MessageBox.Show(cbxmes.SelectedValue.ToString() + "     " + nMes.ToString());
        //            this.horasTrabajadoresTableAdapter.FillByEmpTrabAnoMes(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nMes, nAno, VariablesGlobales.nIdTrabajadorActual);
        //            //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
        //            DateTime fecha = new DateTime(nAno, nMes, 1);
        //            this.productosTableAdapter.FillByUtilizados(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual, fecha.AddDays(-60), fecha.AddDays(-30));

        //            gridView1_FocusedRowChanged(null, null);
                
        //    }
            
            
            
        //}

     

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            gridView1_FocusedRowChanged(null, null);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            if (e.Column.Name == "colDiaTrab" || e.Column.Name=="colIdObra")
            {

              //  MessageBox.Show(gridView1.GetFocusedRowCellValue("IdObra").ToString());

                try
                {
                int obra = (int)gridView1.GetFocusedRowCellValue("IdObra");
                byte dia = (byte)gridView1.GetFocusedRowCellValue("DiaTrab");

                this.festivosObrasDiaTableAdapter.Fill(promowork_dataDataSet.FestivosObrasDia, obra, dia, nMes, nAno);
                //MessageBox.Show(gridView1.GetFocusedRowCellValue("DiaTrab").ToString());
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

            }

          

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
        }

        private void txtMes_EditValueChanged(object sender, EventArgs e)
        {
            
           // nAno = (int)txtAno.Value;
            nMes = (byte)txtMes.Value;

            
            this.horasTrabajadoresTableAdapter.FillByEmpTrabAnoMes(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nMes, nAno, VariablesGlobales.nIdTrabajadorActual);
            //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
           // DateTime fecha = new DateTime(nAno, nMes, 1);
            //this.productosTableAdapter.FillByUtilizados(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual, fecha.AddDays(-60), fecha.AddDays(-30));

            gridView1_FocusedRowChanged(null, null);
        }

        private void txtAno_EditValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Mes cambia");
            nAno = (int)txtAno.Value;
           //nMes = (byte)txtMes.Value;

            // MessageBox.Show(cbxmes.SelectedValue.ToString() + "     " + nMes.ToString());
            this.horasTrabajadoresTableAdapter.FillByEmpTrabAnoMes(this.promowork_dataDataSet.HorasTrabajadores, VariablesGlobales.nIdEmpresaActual, nMes, nAno, VariablesGlobales.nIdTrabajadorActual);
            //this.horasTrabajadasTotalTrabajadorTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadasTotalTrabajador, VariablesGlobales.nIdEmpresaActual, nAno, nMes);
           // DateTime fecha = new DateTime(nAno, nMes, 1);
           //this.productosTableAdapter.FillByUtilizados(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual, fecha.AddDays(-60), fecha.AddDays(-30));

            gridView1_FocusedRowChanged(null, null);
        }

       
      

    }
}
