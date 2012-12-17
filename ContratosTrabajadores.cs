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
    public partial class ContratosTrabajadores : Form
    {
        public ContratosTrabajadores()
        {
            InitializeComponent();
        }

        private void contratosTrabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.contratosTrabajadoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.contratosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.ContratosTrabajadores);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.contratosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.ContratosTrabajadores);
                }
                
            }

        }

        private void ContratosTrabajadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ContratosTrabajadores' table. You can move, or remove it, as needed.
            this.contratosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.ContratosTrabajadores);

        }
    }
}
