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

namespace PartesTrabajadores
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            gridView1.CloseEditor();
            gridView1.BeginUpdate();
            gridView1.EndUpdate();
            try
            {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
                    
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);

                    }

                }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
           // this.proveedoresTableAdapter.Fill(this.promowork_dataDataSet.Proveedores);
            
            this.WindowState = FormWindowState.Maximized;
            this.proveedoresTableAdapter.FillByEmpresa(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);
            
            this.uMedidasTableAdapter.Fill(this.promowork_dataDataSet.UMedidas);
           // MessageBox.Show("aefgdf");
            this.productosTableAdapter.FillByEmpresa(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
            this.promowork_dataDataSet.Productos.Columns.Add("PC", typeof(decimal), "PVP-PVP*Descuento/100");
            this.promowork_dataDataSet.Productos.Columns.Add("PV", typeof(decimal), "(PVP-PVP*Descuento/100)+(PVP*Porciento/100)");
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
        }

     
    }
}
