using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Promowork
{
    public partial class ObraCompletaColores : Form
    {
        public ObraCompletaColores()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DataTable Obras, Boolean IncCobros)
        {
            
            this.WindowState = FormWindowState.Maximized;

            try
            {
                    this.ResumenObraCompletaTableAdapter.Fill(this.Promowork_dataDataSet.ResumenObraCompleta, Obras, -65536, -16776961, -16777216);
                    // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
                    this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
                    this.Promowork_dataDataSet.ResumenObraCompleta.Columns.Add("TotalSalario", typeof(decimal), "Cantidad*Salario");
                    this.Promowork_dataDataSet.ResumenObraCompleta.Columns.Add("Total", typeof(decimal), "Cantidad*Salario+isnull(SS,0)+isnull(IRPF,0)");
                    this.Promowork_dataDataSet.ResumenObraCompleta.Columns.Add("ColorH", typeof(string), "iif(ColorHoras=-65536,'Rojo',iif(ColorHoras=-16776961,'Azul','Negro'))");
                    // this.Promowork_dataDataSet.ResumenObraCompleta.Columns.Add("Obra", typeof(string), "convert(chart(6),NumObra)+DesObra");

                this.Promowork_dataDataSet.ResumenObraCompleta.Columns.Add("ImpTotal", typeof(decimal), "ImpBase+ImpIVA");
                this.Promowork_dataDataSet.ResumenObraCompleta.Columns.Add("ColorC", typeof(string), "iif(ColorCompra=-65536,'Rojo',iif(ColorCompra=-16776961,'Azul','Negro'))");

            }
            catch { }
  
        }

       
        private void ObraCompletaColores_Resize(object sender, EventArgs e)
        {
       
           gridControl1.Height = (this.Height / 2) - 36;
           gridControl2.Height = (this.Height / 2) - 10;
           gridControl1.Width = this.Width - 16;
           gridControl2.Width = this.Width - 16;
           gridControl1.Top = this.Height / 2;
           toolStrip1.Top = gridControl1.Top + 12;
           button1.Top = gridControl1.Top + 12;
           button2.Top = gridControl1.Top + 12;
           button4.Top = gridControl1.Top + 12;
           textBox2.Top = gridControl1.Top + 12;
           label1.Left = this.Width - 120;
           label2.Left = this.Width - 120;
           label2.Top = gridControl1.Top + 12;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            gridView1.SelectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gridView1.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridControl2.ShowPrintPreview();
        }

        private void toolStripButton16_Click_1(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
            ArrayList rows = new ArrayList();
            DataTable SelRows = new DataTable();
            SelRows.Columns.Add("IdCompra", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("IdDetCompra", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["ColorCompra"] = toolStripButton16.BackColor.ToArgb();
                    SelRows.Rows.Add(row["IdCompra"], row["IdDetCompra"], row["Observ"]);
                }
            }
            finally
            {
                gridView1.EndUpdate();
            }

         //   queriesTableAdapter1.ColorCompras(SelRows, toolStripButton16.BackColor.ToArgb());
        }

        private void toolStripButton17_Click_1(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
            ArrayList rows = new ArrayList();
            DataTable SelRows = new DataTable();
            SelRows.Columns.Add("IdCompra", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("IdDetCompra", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["ColorCompra"] = toolStripButton17.BackColor.ToArgb();
                    SelRows.Rows.Add(row["IdCompra"], row["IdDetCompra"], row["Observ"]);
                }
            }
            finally
            {
                gridView1.EndUpdate();
            }

        //   queriesTableAdapter1.ColorCompras(SelRows, toolStripButton17.BackColor.ToArgb());
        }

        private void toolStripButton18_Click_1(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
            ArrayList rows = new ArrayList();
            DataTable SelRows = new DataTable();
            SelRows.Columns.Add("IdCompra", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("IdDetCompra", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["ColorCompra"] = toolStripButton18.BackColor.ToArgb();
                    SelRows.Rows.Add(row["IdCompra"], row["IdDetCompra"], row["Observ"]);
                }
            }
            finally
            {
                gridView1.EndUpdate();
            }

         //   queriesTableAdapter1.ColorCompras(SelRows, toolStripButton18.BackColor.ToArgb());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                 
            gridView2.CloseEditor();
            ArrayList rows = new ArrayList();
            DataTable SelRows = new DataTable();
            SelRows.Columns.Add("IdHoras", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView2.SelectedRowsCount; i++)
            {
                if (gridView2.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));

            }
            try
            {
                gridView2.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["ColorHoras"] = toolStripButton1.BackColor.ToArgb();
                    SelRows.Rows.Add(row["IdHoras"], row["Observ"]);
                }
            }
            finally
            {
                gridView2.EndUpdate();
            }

          //  queriesTableAdapter1.ColorHoras(SelRows, toolStripButton1.BackColor.ToArgb());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            gridView2.CloseEditor();
            ArrayList rows = new ArrayList();
            DataTable SelRows = new DataTable();
            SelRows.Columns.Add("IdHoras", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView2.SelectedRowsCount; i++)
            {
                if (gridView2.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));

            }
            try
            {
                gridView2.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["ColorHoras"] = toolStripButton2.BackColor.ToArgb();
                    SelRows.Rows.Add(row["IdHoras"], row["Observ"]);
                }
            }
            finally
            {
                gridView2.EndUpdate();
            }

         //   queriesTableAdapter1.ColorHoras(SelRows, toolStripButton2.BackColor.ToArgb());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            gridView2.CloseEditor();
            ArrayList rows = new ArrayList();
            DataTable SelRows = new DataTable();
            SelRows.Columns.Add("IdHoras", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView2.SelectedRowsCount; i++)
            {
                if (gridView2.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));

            }
            try
            {
                gridView2.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["ColorHoras"] = toolStripButton3.BackColor.ToArgb();
                    SelRows.Rows.Add(row["IdHoras"], row["Observ"]);
                }
            }
            finally
            {
                gridView2.EndUpdate();
            }

          //  queriesTableAdapter1.ColorHoras(SelRows, toolStripButton3.BackColor.ToArgb());
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            this.gridControl2.Visible = checkBox4.Checked;
            toolStrip2.Visible = checkBox4.Checked;
            button3.Visible = checkBox4.Checked;
            button6.Visible = checkBox4.Checked;
            button7.Visible = checkBox4.Checked;
            label1.Visible = checkBox4.Checked;
            textBox1.Visible = checkBox4.Checked;

            this.gridControl1.Dock = checkBox4.Checked && checkBox5.Checked ? DockStyle.None : DockStyle.Fill;
            this.gridControl2.Dock = checkBox4.Checked && checkBox5.Checked ? DockStyle.None : DockStyle.Fill;
            button1.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            button2.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            button4.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            textBox2.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            toolStrip1.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            label2.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.gridControl1.Visible = checkBox5.Checked;
            toolStrip1.Visible = checkBox5.Checked;
            button1.Visible = checkBox5.Checked;
            button2.Visible = checkBox5.Checked;
            button4.Visible = checkBox5.Checked;
            label2.Visible = checkBox5.Checked;
            textBox2.Visible = checkBox5.Checked;

            this.gridControl1.Dock = checkBox4.Checked && checkBox5.Checked ? DockStyle.None : DockStyle.Fill;
            this.gridControl2.Dock = checkBox4.Checked && checkBox5.Checked ? DockStyle.None : DockStyle.Fill;

            button1.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            button2.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            button4.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            textBox2.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            toolStrip1.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;
            label2.Top = checkBox4.Checked ? (this.Height / 2) + 12 : 12;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            gridView2.SelectAll();

            gridView2.CloseEditor();
            ArrayList rows = new ArrayList();
            DataTable SelRows = new DataTable();
            SelRows.Columns.Add("Color", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("IdHoras", System.Type.GetType("System.Int32"));
            SelRows.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView2.SelectedRowsCount; i++)
            {
                if (gridView2.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));

            }
            try
            {
                gridView2.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    // row["ColorHoras"] = toolStripButton1.BackColor.ToArgb();
                    SelRows.Rows.Add(row["ColorHoras"], row["IdHoras"], row["Observ"]);
                }
            }
            finally
            {
                gridView2.EndUpdate();
            }

            queriesTableAdapter1.ColorHoras(SelRows);
            gridView2.ClearSelection();

            ////////////////////////////////////////////////
            gridView1.SelectAll();

            gridView1.CloseEditor();
            ArrayList rows1 = new ArrayList();
            DataTable SelRows1 = new DataTable();
            SelRows1.Columns.Add("Color", System.Type.GetType("System.Int32"));
            SelRows1.Columns.Add("IdDetCompra", System.Type.GetType("System.Int32"));
            SelRows1.Columns.Add("Observ", System.Type.GetType("System.String"));
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows1.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows1.Count; i++)
                {
                    DataRow row1 = rows1[i] as DataRow;
                    // Change the field value.
                    // row["ColorHoras"] = toolStripButton1.BackColor.ToArgb();
                    SelRows1.Rows.Add(row1["ColorCompra"], row1["IdDetCompra"], row1["Observ"]);
                }
            }
            finally
            {
                gridView1.EndUpdate();
            }

            queriesTableAdapter1.ColorCompras(SelRows1);
            gridView1.ClearSelection();
        }

        private void ObraCompletaColores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Promowork_dataDataSet.HasChanges() == true)
            {
                if (MessageBox.Show("Desea Salvar los Cambios?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button5_Click(null, null);

                }

            }
        }
 
        private void button6_Click_1(object sender, EventArgs e)
        {
            gridView2.CloseEditor();
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView2.SelectedRowsCount; i++)
            {
                if (gridView2.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));

            }
            try
            {
                gridView2.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["Observ"] = textBox1.Text;
                }
            }
            finally
            {
                gridView2.EndUpdate();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            gridView2.CloseEditor();
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView2.SelectedRowsCount; i++)
            {
                if (gridView2.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));

            }
            try
            {
                gridView2.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["Observ"] = Convert.ToString(row["Observ"]).Trim() == "" ? textBox1.Text : row["Observ"];
                }
            }
            finally
            {
                gridView2.EndUpdate();
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["Observ"] = textBox2.Text;
                }
            }
            finally
            {
                gridView1.EndUpdate();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    row["Observ"] = Convert.ToString(row["Observ"]).Trim() == "" ? textBox2.Text : row["Observ"];
                }
            }
            finally
            {
                gridView1.EndUpdate();
            }
        }


       
    }
}
