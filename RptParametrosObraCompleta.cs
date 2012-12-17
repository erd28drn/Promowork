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
    public partial class RptParametrosObraCompleta : Form
    {
        public RptParametrosObraCompleta()
        {
            InitializeComponent();
            
        }

        private void RptParametrosObraCompleta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Clientes' table. You can move, or remove it, as needed.
            marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int colorRojo = chkRojo.Checked ? -65536 : 0;
            int colorAzul = chkAzul.Checked ? -16776961 : 0;
            int colorNegro = chkNegro.Checked ? -16777216 : 0;
           
            try
            {
                string numObra = textBox1.Text == "" ? "" : " and NumObra in (" + textBox1.Text + ")";
                DataTable tmpObras = promowork_dataDataSet.MarcaObras.Select("Marca= true" + numObra).CopyToDataTable();

                RptResumenObraCompleta frm = new RptResumenObraCompleta();
                frm.LoadParametros(tmpObras, checkBox2.Checked, colorRojo, colorAzul, colorNegro);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Es Obligatorio Seleccionar al menos un Registro en cada panel.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    marcaObrasTableAdapter.FillByActivoMarca(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //  checkBox1.Text = "Desmarcar Todo";
                }
                else
                {
                    marcaObrasTableAdapter.FillByActivoDesmarca(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //   checkBox1.Text = "Marcar Todo";
                }
            }
            else
            {
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //  checkBox1.Text = "Desmarcar Todo";
                }
                else
                {
                    marcaObrasTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //   checkBox1.Text = "Marcar Todo";
                }
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    marcaObrasTableAdapter.FillByActivoMarca(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //  checkBox1.Text = "Desmarcar Todo";
                }
                else
                {
                    marcaObrasTableAdapter.FillByActivoDesmarca(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //   checkBox1.Text = "Marcar Todo";
                }
            }
            else
            {
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //  checkBox1.Text = "Desmarcar Todo";
                }
                else
                {
                    marcaObrasTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
                    //   checkBox1.Text = "Marcar Todo";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string numObra = textBox1.Text == "" ? "" : " and NumObra in (" + textBox1.Text + ")";
                DataTable tmpObras = promowork_dataDataSet.MarcaObras.Select("Marca= true" + numObra).CopyToDataTable();

                ObraCompletaColores frm = new ObraCompletaColores();
                frm.LoadParametros(tmpObras, checkBox2.Checked);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Es Obligatorio Seleccionar al menos un Registro en cada panel.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
               marcaObrasBindingSource.Filter = "NumObra in (" + textBox1.Text + ")";
            
            }
            catch { }
        }


    }
}
