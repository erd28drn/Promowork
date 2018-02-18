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
    public partial class BajasMedica : Form
    {
        
        public BajasMedica()
        {
            InitializeComponent();
        }

        private void bajasMedicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bajasMedicaBindingSource.EndEdit();

            DataRowView BajaActual = (DataRowView)bajasMedicaBindingSource.Current;
            try
            {
                if (bajasMedicaDataGridView.RowCount != 0)
                {
                    DateTime FechaBaja = new DateTime(Convert.ToInt32(BajaActual["AnoBaja"]), Convert.ToInt32(BajaActual["MesBaja"]), Convert.ToInt32(BajaActual["DiasBaja"]));
                }
                try
                {
                    this.Validate();
                    this.bajasMedicaBindingSource.EndEdit();
                    this.bajasMedicaTableAdapter.Update(promowork_dataDataSet.BajasMedica);
                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.bajasMedicaTableAdapter.Fill(this.promowork_dataDataSet.BajasMedica,VariablesGlobales.nIdEmpresaActual,VariablesGlobales.nMesActual,VariablesGlobales.nAnoActual);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.bajasMedicaTableAdapter.Fill(this.promowork_dataDataSet.BajasMedica, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual);
                    }

                }
            
            }
            catch
            {
                 MessageBox.Show("Cantidad de Días Incorrecta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void bajasMedica_Load(object sender, EventArgs e)
        {
            this.trabajadoresListaTableAdapter.FillByEmpresa(promowork_dataDataSet.TrabajadoresLista, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.bajasMedica' table. You can move, or remove it, as needed.
            this.bajasMedicaTableAdapter.Fill(this.promowork_dataDataSet.BajasMedica,VariablesGlobales.nIdEmpresaActual,VariablesGlobales.nMesActual,VariablesGlobales.nAnoActual);
         //   empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
         //   DataRowView EmprersaActual = (DataRowView)empresasActualBindingSource.Current;
          //  bajasMedicaBindingSource.Filter = "MesBaja=" + EmprersaActual["MesEmpresa"] + " and AnoBaja=" + EmprersaActual["AnoEmpresa"];

        }

        private void bajasMedicaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Formato Incorrecto.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        
       private void toolStripButton1_Click(object sender, EventArgs e)
        {
        /*    RptbajasMedica frm = new RptbajasMedica();
            frm.MdiParent = this.MdiParent;
            frm.Show();*/
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
          //  DataRowView EmprersaActual = (DataRowView)empresasActualBindingSource.Current;
            DataRowView BajaActual = (DataRowView)bajasMedicaBindingSource.Current;

            // MessageBox.Show(Convert.ToString(EmprersaActual["MesEmpresa"]));

            BajaActual["MesBaja"] =VariablesGlobales.nMesActual;
            BajaActual["AnoBaja"] = VariablesGlobales.nAnoActual;
            BajaActual["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            //  MessageBox.Show(Convert.ToString(AnticipoActual["MesAnticipo"]));
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.bajasMedicaBindingSource.RemoveCurrent();
            }
        }

     
    }
}
