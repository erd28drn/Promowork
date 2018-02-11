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
    public partial class Accesos : Form
    {
        public Accesos()
        {
            InitializeComponent();
        }

        private void Accesos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);
          
            this.accesosEmpresasTableAdapter.Fill(this.promowork_dataDataSet.AccesosEmpresas);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.promowork_dataDataSet.Usuarios);
          
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.accesosEmpresasBindingSource.EndEdit();
            this.accesosEmpresasTableAdapter.Update(promowork_dataDataSet.AccesosEmpresas);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                this.accesosEmpresasTableAdapter.Fill(this.promowork_dataDataSet.AccesosEmpresas);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.accesosEmpresasTableAdapter.Fill(this.promowork_dataDataSet.AccesosEmpresas);

                }
            }
        }

      
    }
}
