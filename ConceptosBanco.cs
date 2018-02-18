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
    public partial class ConceptosBanco : Form
    {
        public ConceptosBanco()
        {
            InitializeComponent();
        }

       

        private void ConceptosBanco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ConceptosBancos' table. You can move, or remove it, as needed.
            this.conceptosBancosTableAdapter.Fill(this.promowork_dataDataSet.ConceptosBancos);
         
        }

        private void conceptosBancosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.conceptosBancosBindingSource.EndEdit();
                this.conceptosBancosTableAdapter.Update(this.promowork_dataDataSet.ConceptosBancos);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.conceptosBancosTableAdapter.Fill(promowork_dataDataSet.ConceptosBancos);

            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.conceptosBancosTableAdapter.Fill(promowork_dataDataSet.ConceptosBancos);

                }

            }
            
            

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conceptosBancosBindingSource.RemoveCurrent();

            }
        }
    }
}
