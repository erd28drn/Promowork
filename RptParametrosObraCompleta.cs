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

            dtFechaInicio.Value = new DateTime(1753, 1, 1);
            dtFechaFin.Value = new DateTime(9998, 12, 31);
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int colorRojo = chkRojo.Checked ? -65536 : 0;
            int colorAzul = chkAzul.Checked ? -16776961 : 0;
            int colorNegro = chkNegro.Checked ? -16777216 : 0;

            DataTable tmpObras = new DataTable();
          
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                tmpObras.Columns.Add(gridView1.Columns[i].FieldName);
            }
      
            try
            {
                for (int i=0; i<gridView1.RowCount; i++)
                {
                    if ((bool)gridView1.GetRowCellValue(i, "Marca") == true)
                    {
                        tmpObras.ImportRow(gridView1.GetDataRow(i));
                    }
                }





               // string numObra = textBox1.Text == "" ? "" : " and NumObraInt in (" + textBox1.Text + ")";
               // promowork_dataDataSet.MarcaObras.Select("Marca= true" + numObra).CopyToDataTable();

                RptResumenObraCompleta frm = new RptResumenObraCompleta();
                frm.LoadParametros(tmpObras, checkBox2.Checked, dtFechaInicio.Value, dtFechaFin.Value, colorRojo, colorAzul, colorNegro, checkBox4.Checked);
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

      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string numObra = textBox1.Text == "" ? "" : " and NumObraInt in (" + textBox1.Text + ")";
                DataTable tmpObras = promowork_dataDataSet.MarcaObras.Select("Marca= true" + numObra).CopyToDataTable();

                ObraCompletaColores frm = new ObraCompletaColores();
                frm.LoadParametros(tmpObras, checkBox2.Checked, dtFechaInicio.Value, dtFechaFin.Value);
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
               marcaObrasBindingSource.Filter = "NumObraInt in (" + textBox1.Text + ")";
            
            }
            catch {
                marcaObrasBindingSource.Filter = null;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.CheckState == CheckState.Checked)
            {
                dtFechaInicio.Enabled = false;
                dtFechaFin.Enabled = false;
                dtFechaInicio.Value = new DateTime(1753, 1, 1);
                dtFechaFin.Value = new DateTime(9998, 12, 31);


            }
            else
            {
                dtFechaInicio.Enabled = true;
                dtFechaFin.Enabled = true;
                dtFechaFin.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, 1);
                dtFechaInicio.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual));
                dtFechaFin.MinDate = dtFechaInicio.Value;
            }
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFechaFin.MinDate = dtFechaInicio.Value;
            if (dtFechaFin.Value < dtFechaInicio.Value)
            {
                dtFechaFin.Value = dtFechaInicio.Value;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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


    }
}
