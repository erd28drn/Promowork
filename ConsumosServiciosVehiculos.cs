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
    public partial class ConsumosServiciosVehiculos : Form
    {
        public ConsumosServiciosVehiculos()
        {
            InitializeComponent();
        }

        private void consumosVehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.consumosVehiculosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSetCombustible);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.consumosVehiculosTableAdapter.FillByServicios(this.promowork_dataDataSetCombustible.ConsumosVehiculos, VariablesGlobales.nIdEmpresaActual);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.consumosVehiculosTableAdapter.FillByServicios(this.promowork_dataDataSetCombustible.ConsumosVehiculos, VariablesGlobales.nIdEmpresaActual);
                }

            }
        }

        private void ConsumosVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.Trabajadores' table. You can move, or remove it, as needed.
            this.trabajadoresTableAdapter.Fill(this.promowork_dataDataSetCombustible.Trabajadores,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.TiposServicios' table. You can move, or remove it, as needed.
            this.tiposServiciosTableAdapter.FillByServicios(this.promowork_dataDataSetCombustible.TiposServicios);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.ServiciosVehiculos' table. You can move, or remove it, as needed.
            this.consumosVehiculosTableAdapter.FillByServicios(this.promowork_dataDataSetCombustible.ConsumosVehiculos, VariablesGlobales.nIdEmpresaActual);
            this.vehiculosTableAdapter.Fill(promowork_dataDataSetCombustible.Vehiculos, VariablesGlobales.nIdEmpresaActual);
        }

        private void consumosVehiculosDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            bindingNavigatorAddNewItem_Click(null,null);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            consumosVehiculosDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
            consumosVehiculosDataGridView.CurrentRow.Cells["Combustible"].Value = false;
            consumosVehiculosDataGridView.CurrentRow.Cells["Fecha"].Value = DateTime.Today.ToShortDateString();
        }

        private void consumosVehiculosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Formato Incorrecto");
         //   consumosVehiculosDataGridView.
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.consumosVehiculosBindingSource.RemoveCurrent();
            }
        }
    }
}
