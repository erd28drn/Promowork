using System;
using System.Windows.Forms;

namespace Promowork
{
    public partial class Obras : Form
    {
        public Obras()
        {
            InitializeComponent();
        }

        private void obrasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.obrasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

            queriesTableAdapter1.AgregaFestivosUnaObra(Convert.ToInt32(promowork_dataDataSet.Tables["Obras"].Rows[obrasDataGridView.CurrentRow.Index]["IdObra"]));
            this.festivosObrasDiasTableAdapter.FillByObra(promowork_dataDataSet.FestivosObrasDias, Convert.ToInt32(promowork_dataDataSet.Tables["Obras"].Rows[obrasDataGridView.CurrentRow.Index]["IdObra"]));

        }

        private void Obras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PartObras' table. You can move, or remove it, as needed.
            this.partObrasTableAdapter.Fill(this.promowork_dataDataSet.PartObras);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Participantes' table. You can move, or remove it, as needed.
            this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FestivosObras' table. You can move, or remove it, as needed.
             this.clientesTableAdapter.Fill(this.promowork_dataDataSet.Clientes);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.Fill(this.promowork_dataDataSet.Obras);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.promowork_dataDataSet.Proveedores,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.HorasTrabajadas' table. You can move, or remove it, as needed.
            this.partObrasTableAdapter.Fill(this.promowork_dataDataSet.PartObras);
            // TODO: This line of code loads data into the 'promowork_dataDataSet1.Tipos' table. You can move, or remove it, as needed.
            
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByFechaObra(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);

             /*   if (promowork_dataDataSet.Tables["Obras"].Rows.Count != 0) 
            {
                int IdObraActual = Convert.ToInt32(promowork_dataDataSet.Tables["Obras"].Rows[obrasDataGridView.CurrentRow.Index]["IdObra"]);

                this.festivosObrasDiasTableAdapter.FillByObra(promowork_dataDataSet.FestivosObrasDias, IdObraActual);
            }*/
        }

       
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
              //  this.obrasTableAdapter.FillByFechaObra(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            }
            else
            {
               // this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            }
       
        }

        private void obrasDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        /*    if (obrasDataGridView.CurrentRow.Index < promowork_dataDataSet.Obras.Count)
            {
                int IdObraActual = Convert.ToInt32(promowork_dataDataSet.Tables["Obras"].Rows[obrasDataGridView.CurrentRow.Index]["IdObra"]);

                this.festivosObrasDiasTableAdapter.FillByObra(promowork_dataDataSet.FestivosObrasDias, IdObraActual);
            }*/


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
         //   obrasDataGridView_CellEnter(null,null);
        }

        private void obrasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.obrasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

        }

       
       

        

      
       

    }
}
