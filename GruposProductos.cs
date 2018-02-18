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
    public partial class GruposProductos : Form
    {
        public GruposProductos()
        {
            InitializeComponent();
        }

        private void tiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.gruposProductosBindingSource.EndEdit();
                this.gruposProductosTableAdapter.Update(promowork_dataDataSet.GruposProductos);
                // this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.gruposProductosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.GruposProductos, VariablesGlobales.nIdEmpresaActual);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.gruposProductosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.GruposProductos, VariablesGlobales.nIdEmpresaActual);

                }

            }
        }

        private void Tipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.GruposProductos' Puede moverla o quitarla según sea necesario.
            this.gruposProductosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.GruposProductos, VariablesGlobales.nIdEmpresaActual);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.gruposProductosBindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
        }
    }
}
