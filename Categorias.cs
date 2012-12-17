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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.categoriasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
                bindingNavigator1.Enabled = true;
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
                }
                
            }
            
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.SalariosVenta' table. You can move, or remove it, as needed.
            this.salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PuestosTrabajo' table. You can move, or remove it, as needed.
            this.puestosTrabajoTableAdapter.Fill(this.promowork_dataDataSet.PuestosTrabajo);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)categoriasBindingSource.Current;
            current["ActivoCategoria"] = 1;
            categoriasDataGridView.Focus();
            bindingNavigator1.Enabled = false;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           try
           {
            this.Validate();
            this.puestosTrabajoBindingSource.EndEdit();
            puestosTrabajoTableAdapter.Update(promowork_dataDataSet.PuestosTrabajo);
             }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.puestosTrabajoTableAdapter.Fill(this.promowork_dataDataSet.PuestosTrabajo);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.puestosTrabajoTableAdapter.Fill(this.promowork_dataDataSet.PuestosTrabajo);
                }
                
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            puestosTrabajoDataGridView.Focus();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.salariosVentaBindingSource.EndEdit();
               salariosVentaTableAdapter.Update(promowork_dataDataSet.SalariosVenta);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
                }

            }
           
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            salariosVentaDataGridView.Focus();
        }
    }
}
