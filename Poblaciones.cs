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
    public partial class Poblaciones : Form
    {
        public Poblaciones()
        {
            InitializeComponent();
        }

        private void provinciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.provinciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                    this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);

                    }

                }
        }

        private void Poblaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones' table. You can move, or remove it, as needed.
            this.poblacionesTableAdapter.Fill(this.promowork_dataDataSet.Poblaciones);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);

        }

        private void provinciasDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.provinciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.poblacionesBindingSource.EndEdit();
            poblacionesTableAdapter.Update(promowork_dataDataSet.Poblaciones);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.poblacionesTableAdapter.Fill(this.promowork_dataDataSet.Poblaciones);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                    this.poblacionesTableAdapter.Fill(this.promowork_dataDataSet.Poblaciones);

                    }

                }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            poblacionesDataGridView.Focus();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            provinciasDataGridView.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.provinciasBindingSource.RemoveCurrent();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.poblacionesBindingSource.RemoveCurrent();
            }
        }

       
    }
}
