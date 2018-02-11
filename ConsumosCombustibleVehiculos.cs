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
    public partial class ConsumosCombustibleVehiculos : Form
    {
        public ConsumosCombustibleVehiculos()
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
                this.consumosVehiculosTableAdapter.FillByCombustible(this.promowork_dataDataSetCombustible.ConsumosVehiculos, VariablesGlobales.nIdEmpresaActual);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.consumosVehiculosTableAdapter.FillByCombustible(this.promowork_dataDataSetCombustible.ConsumosVehiculos, VariablesGlobales.nIdEmpresaActual);
                }

            }
        }

        private void ConsumosVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.Trabajadores' table. You can move, or remove it, as needed.
            this.trabajadoresTableAdapter.Fill(this.promowork_dataDataSetCombustible.Trabajadores,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.TiposServicios' table. You can move, or remove it, as needed.
            this.tiposServiciosTableAdapter.FillByCombustibles(this.promowork_dataDataSetCombustible.TiposServicios);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.ServiciosVehiculos' table. You can move, or remove it, as needed.
            this.consumosVehiculosTableAdapter.FillByCombustible(this.promowork_dataDataSetCombustible.ConsumosVehiculos, VariablesGlobales.nIdEmpresaActual);
            this.vehiculosTableAdapter.Fill(promowork_dataDataSetCombustible.Vehiculos, VariablesGlobales.nIdEmpresaActual);
            consumosVehiculosBindingSource.MoveLast();
        }

        private void consumosVehiculosDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            bindingNavigatorAddNewItem_Click(null,null);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // consumosVehiculosBindingSource.Sort = "CantIni";
            
            int LTFin=0;
            DateTime Fecha= DateTime.Today;
            int? TipCombustible= null;
            int? Trabajador=null;


            
                consumosVehiculosBindingSource.MoveLast();
                consumosVehiculosBindingSource.MovePrevious();
                DataRowView Consumo = (DataRowView)consumosVehiculosBindingSource.Current;
                if (Consumo["CantFin"] != DBNull.Value)
                {
                    LTFin = Convert.ToInt32(Consumo["CantFin"]);
                    Fecha = Convert.ToDateTime(Consumo["FechaServicio"]);
                    TipCombustible = int.Parse(Consumo["IdServico"].ToString());
                    Trabajador = int.Parse(Consumo["IdTrabajador"].ToString());
                }


                //MessageBox.Show(Convert.ToString(Consumo["CantIni"]));
                consumosVehiculosBindingSource.MoveNext();
                consumosVehiculosDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
                consumosVehiculosDataGridView.CurrentRow.Cells["Combustible"].Value = true;
                consumosVehiculosDataGridView.CurrentRow.Cells["Fecha"].Value = Fecha;
                consumosVehiculosDataGridView.CurrentRow.Cells["CantIni"].Value = LTFin;
                consumosVehiculosDataGridView.CurrentRow.Cells["IdServico"].Value = TipCombustible;
                consumosVehiculosDataGridView.CurrentRow.Cells["IdTrabajador"].Value = Trabajador;
            
            consumosVehiculosDataGridView.Focus();
        }

        private void consumosVehiculosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
           // MessageBox.Show("Formato Incorrecto");
        }

        private void ConsumosCombustibleVehiculos_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void ConsumosCombustibleVehiculos_Resize(object sender, EventArgs e)
        {
            consumosVehiculosDataGridView.Height = this.Height - 70;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (consumosVehiculosBindingSource.Count != 0)
            {
                if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.consumosVehiculosBindingSource.RemoveCurrent();
                }
            }
        }

       
    }
}
