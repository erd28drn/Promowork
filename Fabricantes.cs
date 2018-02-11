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
    public partial class Fabricantes : Form
    {
        public Fabricantes()
        {
            InitializeComponent();
        }

        private void tiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.fabricantesBindingSource.EndEdit();
            this.fabricantesTableAdapter.Update(promowork_dataDataSet.Fabricantes);
           // this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.fabricantesTableAdapter.Fill(this.promowork_dataDataSet.Fabricantes);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.fabricantesTableAdapter.Fill(this.promowork_dataDataSet.Fabricantes);

                    }

                }
        }

        private void Tipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Fabricantes' Puede moverla o quitarla según sea necesario.
            this.fabricantesTableAdapter.Fill(this.promowork_dataDataSet.Fabricantes);
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.fabricantesBindingSource.RemoveCurrent();
            }
        }
    }
}
