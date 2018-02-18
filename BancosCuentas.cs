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
    public partial class BancosCuentas : Form
    {
        public BancosCuentas()
        {
            InitializeComponent();
        }

        private void bancosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.bancosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            bindingNavigator1.Enabled = true;
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.bancosTableAdapter.Fill(this.promowork_dataDataSet.Bancos);
                }
               
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                    this.bancosTableAdapter.Fill(this.promowork_dataDataSet.Bancos);

                    }
                }

        }

        private void BancosCuentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Cuentas' table. You can move, or remove it, as needed.
            this.cuentasTableAdapter.Fill(this.promowork_dataDataSet.Cuentas,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.CuentasBancos' table. You can move, or remove it, as needed.
            this.bancosTableAdapter.Fill(this.promowork_dataDataSet.Bancos);

        }

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cuentasDataGridView.CurrentRow.Cells["CtaEmpresa"].Value = false;
            cuentasDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
            cuentasDataGridView.Focus();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = false;
            bancosDataGridView.Focus();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           try
           {
            this.Validate();
            this.cuentasBindingSource.EndEdit();
            cuentasTableAdapter.Update(promowork_dataDataSet.Cuentas);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.cuentasTableAdapter.Fill(this.promowork_dataDataSet.Cuentas, VariablesGlobales.nIdEmpresaActual);
                }
               
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.cuentasTableAdapter.Fill(this.promowork_dataDataSet.Cuentas, VariablesGlobales.nIdEmpresaActual);

                    }
                }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.bancosBindingSource.RemoveCurrent();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.cuentasBindingSource.RemoveCurrent();
            }
        }

       
    }
}
