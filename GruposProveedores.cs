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
    public partial class GruposProveedores : Form
    {
        public GruposProveedores()
        {
            InitializeComponent();
        }

        private void tiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tiposProveedoresBindingSource.EndEdit();
                this.tiposProveedoresTableAdapter.Update(promowork_dataDataSet.TiposProveedores);
                // this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.tiposProveedoresTableAdapter.FillByEmpresa(this.promowork_dataDataSet.TiposProveedores, VariablesGlobales.nIdEmpresaActual);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.tiposProveedoresTableAdapter.FillByEmpresa(this.promowork_dataDataSet.TiposProveedores, VariablesGlobales.nIdEmpresaActual);

                }

            }
        }

        private void Tipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.GruposProductos' Puede moverla o quitarla según sea necesario.
            this.tiposProveedoresTableAdapter.FillByEmpresa(this.promowork_dataDataSet.TiposProveedores, VariablesGlobales.nIdEmpresaActual);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.tiposProveedoresBindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
        }

       
    }
}
