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
    public partial class TiposProveedores : Form
    {
        public TiposProveedores()
        {
            InitializeComponent();
        }

        private void participantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.participantesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                    this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);

                    }

                }
        }

        private void TiposProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Participantes' table. You can move, or remove it, as needed.
            this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.participantesBindingSource.RemoveCurrent();
            }
        }
    }
}
