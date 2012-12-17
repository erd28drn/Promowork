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

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.UMedidas' table. You can move, or remove it, as needed.
            this.uMedidasTableAdapter.Fill(this.promowork_dataDataSet.UMedidas);
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
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

      
    }
}
