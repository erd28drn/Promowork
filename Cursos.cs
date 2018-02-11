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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void cursosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           try
           {
            this.Validate();
            this.cursosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cursosTableAdapter.Fill(this.promowork_dataDataSet.Cursos);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.cursosTableAdapter.Fill(this.promowork_dataDataSet.Cursos);
                }
               

            }

        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Cursos' table. You can move, or remove it, as needed.
            this.cursosTableAdapter.Fill(this.promowork_dataDataSet.Cursos);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.cursosBindingSource.RemoveCurrent();
            }
        }
    }
}
