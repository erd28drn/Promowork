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
    public partial class HorasMateriales : Form
    {
        public HorasMateriales()
        {
            InitializeComponent();
        }

        private void horasTrabajadasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.horasTrabajadasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

        }

        private void HorasMateriales_Load(object sender, EventArgs e)
        {
            HorasMateriales_Resize(null, null);
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByListaObras(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
            this.trabajadoresTableAdapter.Fill(promowork_dataDataSet.Trabajadores, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ProductosUtilizados' table. You can move, or remove it, as needed.
          
            this.horasTrabajadasTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadas, VariablesGlobales.nIdEmpresaActual,VariablesGlobales.nAnoActual,VariablesGlobales.nMesActual);
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);

            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.Appearance.Row.BackColor = Color.Silver;
            gridView2.OptionsBehavior.ReadOnly = true;
            gridView2.Appearance.Row.BackColor = Color.Silver;
        }

        private void horasTrabajadasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
           try
           {
            this.Validate();
            this.horasTrabajadasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
          /*  if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("HorasAdmin")) == true)
            {
                queriesTableAdapter1.ActualizaHorasAdmin(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTrabajador")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView1.GetFocusedRowCellValue("DiaTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("MesTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("AnoTrab")), Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Cantidad")), Convert.ToString(gridView1.GetFocusedRowCellValue("DesTrabajo")), null);
            }
            else
            {
                queriesTableAdapter1.ActualizaHorasAdmin(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTrabajador")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView1.GetFocusedRowCellValue("DiaTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("MesTrab")), Convert.ToInt32(gridView1.GetFocusedRowCellValue("AnoTrab")), 0, null, null);
            }*/
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.horasTrabajadasTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadas, VariablesGlobales.nIdEmpresaActual,VariablesGlobales.nAnoActual,VariablesGlobales.nMesActual);
                    
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.horasTrabajadasTableAdapter.FillByEmpresaMesAno(this.promowork_dataDataSet.HorasTrabajadas, VariablesGlobales.nIdEmpresaActual,VariablesGlobales.nAnoActual,VariablesGlobales.nMesActual);

                    }

                }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.productosUtilizadosTableAdapter.FillbyHoras(this.promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int obra = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra"));
            int trabajador = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTrabajador"));
            int tipo = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTipo"));

            horasTrabajadasBindingSource.AddNew();

            gridView1.SetFocusedRowCellValue("IdObra",obra);
            gridView1.SetFocusedRowCellValue("IdTrabajador", trabajador);
            gridView1.SetFocusedRowCellValue("IdTipo", tipo);
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
            gridView1.SetFocusedRowCellValue("IdUsuario", VariablesGlobales.nIdUsuarioActual);
            gridView1.SetFocusedRowCellValue("AnoTrab", VariablesGlobales.nAnoActual);
            gridView1.SetFocusedRowCellValue("MesTrab", VariablesGlobales.nMesActual);
            gridView1.SetFocusedRowCellValue("Festivo", 0);
            gridView1.SetFocusedRowCellValue("HorasAdmin", 0);

            gridView1.FocusedColumn = gridView1.VisibleColumns[0];
            gridView1.ShowEditor();
        }

        private void HorasMateriales_Resize(object sender, EventArgs e)
        {
            horasTrabajadasGridControl.Width = this.Width - 16;
            horasTrabajadasGridControl.Height = this.Height - 235;
           // productosUtilizadosGridControl.Width = this.Width - 16;
            productosUtilizadosGridControl.Location =new Point(0, this.Height - 168);
            bindingNavigator1.Location = new Point(0, this.Height - 195);
            groupBox1.Location = new Point(680, this.Height - 168);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.productosUtilizadosBindingSource.EndEdit();
            this.productosUtilizadosTableAdapter.Update(promowork_dataDataSet.ProductosUtilizados);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.productosUtilizadosTableAdapter.FillbyHoras(this.promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
                    
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.productosUtilizadosTableAdapter.FillbyHoras(this.promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));

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

            if (gridView1.FocusedColumn.FieldName == "Salario" && Convert.ToBoolean(gridView1.GetFocusedRowCellValue("Festivo"))==false)
            {
                e.Cancel = true;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            DataRowView HoraActual = (DataRowView)horasTrabajadasBindingSource.Current;
            HoraActual["CopiaParte"] = openFileDialog1.FileName;
            copiaFacturaTextBox.Text = openFileDialog1.FileName;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRowView HoraActual = (DataRowView)horasTrabajadasBindingSource.Current;
            try
            {
                System.Diagnostics.Process.Start(Convert.ToString(HoraActual["CopiaParte"]));
            }
            catch
            {
                MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView HoraActual = (DataRowView)horasTrabajadasBindingSource.Current;
            HoraActual["CopiaParte"] = null;
            copiaFacturaTextBox.Text = "";
        }

       
    }
}
