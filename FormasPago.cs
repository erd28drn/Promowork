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
    public partial class FormasPago : Form
    {
        public FormasPago()
        {
            InitializeComponent();
        }

        private void formasPagoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.formasPagoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);

                }
            }

        }

        private void FormasPago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.formasPagoBindingSource.RemoveCurrent();
            }
        }
    }
}
