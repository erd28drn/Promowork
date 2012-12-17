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
    public partial class SeguridadSocial : Form
    {
        public SeguridadSocial()
        {
            InitializeComponent();
        }

        private void seguridadSocialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            byte nMes = VariablesGlobales.nMesActual;
            int nAno = VariablesGlobales.nAnoActual;
            try
           {
            this.Validate();
            this.seguridadSocialBindingSource.EndEdit();
            seguridadSocialTableAdapter.Update(promowork_dataDataSet.SeguridadSocial);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
                this.seguridadSocialTableAdapter.Fill(this.promowork_dataDataSet.SeguridadSocial,VariablesGlobales.nIdEmpresaActual,nMes,nAno);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                this.seguridadSocialTableAdapter.Fill(this.promowork_dataDataSet.SeguridadSocial, VariablesGlobales.nIdEmpresaActual, nMes, nAno);

                }
            }
        }

        private void SeguridadSocial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.SeguridadSocial' table. You can move, or remove it, as needed.
           // empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            byte nMes=VariablesGlobales.nMesActual;
            int nAno=VariablesGlobales.nAnoActual;
            trabajadoresSSTableAdapter.Fill(promowork_dataDataSet.TrabajadoresSS, VariablesGlobales.nIdEmpresaActual);
            queriesTableAdapter1.AgregaSeguridadSocial(VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
           // trabajadoresSSTableAdapter.Fill(promowork_dataDataSet.TrabajadoresSS, VariablesGlobales.nIdEmpresaActual);
            this.seguridadSocialTableAdapter.Fill(this.promowork_dataDataSet.SeguridadSocial,VariablesGlobales.nIdEmpresaActual,nMes,nAno);

           // seguridadSocialDataGridView.Sort(seguridadSocialDataGridView.Columns["Trabajador"], ListSortDirection.Ascending);

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            RptSeguridadSocial frm = new RptSeguridadSocial();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

    
    }
}
