using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
        }
       private void trabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trabajadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.SalariosTipos' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ContratosTrabajadores' table. You can move, or remove it, as needed.
            this.contratosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.ContratosTrabajadores);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Trabajadores' table. You can move, or remove it, as needed.
            this.trabajadoresTableAdapter.Fill(this.promowork_dataDataSet.Trabajadores,VariablesGlobales.nIdEmpresaActual);

            this.salariosTiposTableAdapter.FillByTrabajador(this.promowork_dataDataSet.SalariosTipos, Convert.ToInt32(promowork_dataDataSet.Tables["Trabajadores"].Rows[0]["IdTrabajador"]));

            trabajadoresDataGridView.Width = this.Width - 25;
            if (trabajadoresDataGridView.CurrentRow.Index < promowork_dataDataSet.Trabajadores.Count)
            {
                if (promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["FotoTrabajador"].ToString() == "")
                {
                    this.pictureBox1.ImageLocation = "";
                }
                else
                {
                    this.pictureBox1.ImageLocation = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["FotoTrabajador"].ToString();
                }
                if (promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador"].ToString() == "")
                {
                    this.pictureBox2.ImageLocation = "";
                }
                else
                {
                    this.pictureBox2.ImageLocation = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador"].ToString();
                }
                if (promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador1"].ToString() == "")
                {
                    this.pictureBox3.ImageLocation = "";
                }
                else
                {
                    this.pictureBox3.ImageLocation = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador1"].ToString();
                }
            }
        }

       
        private void Form1_Resize(object sender, EventArgs e)
        {
            trabajadoresDataGridView.Width = this.Width - 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            this.textBox1.Text = openFileDialog1.FileName;
                //promowork_dataDataSet.Tables["Trabajadores"].Rows[0]["FotoTrabajador"].ToString();
        }

        private void trabajadoresDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            if (trabajadoresDataGridView.CurrentRow.Index < promowork_dataDataSet.Trabajadores.Count)
            {
                this.salariosTiposTableAdapter.FillByTrabajador(this.promowork_dataDataSet.SalariosTipos, Convert.ToInt32(promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["IdTrabajador"]));
                if (promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["FotoTrabajador"].ToString() == "")
                {
                    this.pictureBox1.ImageLocation = "";
                }
                else
                {
                    this.pictureBox1.ImageLocation = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["FotoTrabajador"].ToString();
                }
                if (promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador"].ToString() == "")
                {
                    this.pictureBox2.ImageLocation = "";
                }
                else
                {
                    this.pictureBox2.ImageLocation = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador"].ToString();
                }
                if (promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador1"].ToString() == "")
                {
                    this.pictureBox3.ImageLocation = "";
                }
                else
                {
                    this.pictureBox3.ImageLocation = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador1"].ToString();
                }
            }
            else
            {
                this.salariosTiposTableAdapter.FillByTrabajador(this.promowork_dataDataSet.SalariosTipos, 0);
            }

        }

        private void salariosTiposDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.salariosTiposBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            
            salariosTiposTableAdapter.Update(promowork_dataDataSet.SalariosTipos);
        }

        private void salariosTiposDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            salariosTiposDataGridView.CurrentRow.Cells["IdTrabajador"].Value = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["IdTrabajador"];
        }

        private void trabajadoresDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            trabajadoresDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
        }

        private void trabajadoresDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                this.salariosTiposBindingSource.EndEdit();
                // this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

                trabajadoresTableAdapter.Update(promowork_dataDataSet.Trabajadores);
            }
            catch (DBConcurrencyException)
            {

                int rowpos = trabajadoresDataGridView.CurrentCell.RowIndex;
                MessageBox.Show("No se Pudo Salvar la Información. El record fue modificado por otro operador.","Error");
                this.trabajadoresTableAdapter.Fill(this.promowork_dataDataSet.Trabajadores, VariablesGlobales.nIdEmpresaActual);
                
            }
        }

       
    }
}
