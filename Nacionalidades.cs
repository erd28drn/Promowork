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
    public partial class Nacionalidades : Form
    {
        public Nacionalidades()
        {
            InitializeComponent();
        }

        private void nacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.nacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.nacionesTableAdapter.Fill(this.promowork_dataDataSet.Naciones);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                this.nacionesTableAdapter.Fill(this.promowork_dataDataSet.Naciones);
                }


            }
        }

        private void Nacionalidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Naciones' table. You can move, or remove it, as needed.
            this.nacionesTableAdapter.Fill(this.promowork_dataDataSet.Naciones);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.nacionesBindingSource.RemoveCurrent();
            }
        }
    }
}
