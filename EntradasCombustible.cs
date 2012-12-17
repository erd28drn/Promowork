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
    public partial class EntradasCombustible : Form
    {
        public EntradasCombustible()
        {
            InitializeComponent();
        }

        private void entradasCombustibleCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           try
           {
            this.Validate();
            this.entradasCombustibleDetBindingSource.EndEdit();
            this.entradasCombustibleDetTableAdapter.Update(this.promowork_dataDataSetCombustible.EntradasCombustibleDet);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     this.entradasCombustibleDetTableAdapter.Fill(this.promowork_dataDataSetCombustible.EntradasCombustibleDet);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                         this.entradasCombustibleDetTableAdapter.Fill(this.promowork_dataDataSetCombustible.EntradasCombustibleDet);
                    }
                    
                }
        }

       private void EntradasCombustible_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible1.UMedidas' table. You can move, or remove it, as needed.
            this.uMedidasTableAdapter.Fill(this.promowork_dataDataSetCombustible1.UMedidas);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible1.TiposServicios' table. You can move, or remove it, as needed.
            this.tiposServiciosTableAdapter.FillByCombustibles(this.promowork_dataDataSetCombustible1.TiposServicios);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.Cuentas' table. You can move, or remove it, as needed.
            this.cuentasTableAdapter.Fill(this.promowork_dataDataSetCombustible.Cuentas);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSetCombustible.FormasPago);
            this.proveedoresTableAdapter.Fill(promowork_dataDataSetCombustible.Proveedores, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSetCombustible.EntradasCombustibleDet' table. You can move, or remove it, as needed.
            this.entradasCombustibleCabTableAdapter.Fill(promowork_dataDataSetCombustible.EntradasCombustibleCab, VariablesGlobales.nIdEmpresaActual);
           this.entradasCombustibleDetTableAdapter.Fill(this.promowork_dataDataSetCombustible.EntradasCombustibleDet);

           entradasCombustibleCabBindingSource.MoveLast();

        }

       private void entradasCombustibleDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           MessageBox.Show("Error de Formato", this.Text);
       }
    }
}
