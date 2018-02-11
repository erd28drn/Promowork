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
    public partial class AnticiposTrabajadores : Form
    {
        
        public AnticiposTrabajadores()
        {
            InitializeComponent();
        }

        private void anticiposTrabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.anticiposTrabajadoresBindingSource.EndEdit();

            DataRowView AnticipoActual = (DataRowView)anticiposTrabajadoresBindingSource.Current;
            try
            {
                DateTime FechaAnticipo = new DateTime(Convert.ToInt32(AnticipoActual["AnoAnticipo"]), Convert.ToInt32(AnticipoActual["MesAnticipo"]), Convert.ToInt32(AnticipoActual["DiaAnticipo"]));

                try
                {
                    this.Validate();
                    this.anticiposTrabajadoresBindingSource.EndEdit();
                    this.anticiposTrabajadoresTableAdapter.Update(promowork_dataDataSet.AnticiposTrabajadores);
                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.anticiposTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.AnticiposTrabajadores, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, VariablesGlobales.nIdEmpresaActual);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.anticiposTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.AnticiposTrabajadores, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, VariablesGlobales.nIdEmpresaActual);
                    }

                }
            
            }
            catch
            {
                 MessageBox.Show("Día Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void AnticiposTrabajadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Anticipos' table. You can move, or remove it, as needed.
            this.anticiposTableAdapter.Fill(this.promowork_dataDataSet.Anticipos);
            this.trabajadoresListaTableAdapter.FillByEmpresa(promowork_dataDataSet.TrabajadoresLista, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.AnticiposTrabajadores' table. You can move, or remove it, as needed.
            this.anticiposTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.AnticiposTrabajadores,VariablesGlobales.nMesActual,VariablesGlobales.nAnoActual,VariablesGlobales.nIdEmpresaActual);
        
        }

        private void anticiposTrabajadoresDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Formato Incorrecto.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRowView AnticipoActual = (DataRowView)anticiposTrabajadoresBindingSource.Current;

          // MessageBox.Show(Convert.ToString(EmprersaActual["MesEmpresa"]));

            AnticipoActual["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            AnticipoActual["MesAnticipo"] = VariablesGlobales.nMesActual;
            AnticipoActual["AnoAnticipo"] = VariablesGlobales.nAnoActual;
          //  MessageBox.Show(Convert.ToString(AnticipoActual["MesAnticipo"]));
            gridView1.FocusedColumn = gridView1.VisibleColumns[0];
            gridView1.ShowEditor();
        }

      
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RptAnticiposTrabajadores frm = new RptAnticiposTrabajadores();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.anticiposTrabajadoresBindingSource.RemoveCurrent();
            }
        }

    }
}
