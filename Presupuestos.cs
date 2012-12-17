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
    public partial class Presupuestos : Form
    {
        public Presupuestos()
        {
            InitializeComponent();
        }

        private void presupCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.presupCabBindingSource.EndEdit();
            presupCabTableAdapter.Update(promowork_dataDataSet.PresupCab);
            toolStripButton1.Enabled = true;
            toolStripButton7.Enabled = true;
            toolStripButton8.Enabled = true;
            toolStripButton14.Enabled = true;
            toolStripButton15.Enabled = true;
            toolStripButton21.Enabled = true;


            this.empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            DataRowView empresa = (DataRowView)empresasActualBindingSource.Current;
            if (Convert.ToInt32(numPresupTextBox.Text) >= Convert.ToInt32(empresa["PresupEmpresa"]))
            {
            empresa["PresupEmpresa"] = Convert.ToInt32(numPresupTextBox.Text)+1;
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);
            }

            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("No se pudieron Salvar los Cambios al Registro Actual. Campos Obligatorios Vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.presupCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.PresupCab, VariablesGlobales.nIdEmpresaActual);
                }
                catch (SqlException ex)
                {

                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.presupCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.PresupCab, VariablesGlobales.nIdEmpresaActual);
                    }

                }
        }

        private void Presupuestos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupSub' table. You can move, or remove it, as needed.
            this.presupSubTableAdapter.Fill(this.promowork_dataDataSet.PresupSub);
          
            this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.UMedidas' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            clientesBindingSource.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupDet' table. You can move, or remove it, as needed.
            this.presupDetTableAdapter.Fill(this.promowork_dataDataSet.PresupDet);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCap' table. You can move, or remove it, as needed.
            this.presupCapTableAdapter.Fill(this.promowork_dataDataSet.PresupCap);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PartPresup' table. You can move, or remove it, as needed.
            this.partPresupTableAdapter.Fill(this.promowork_dataDataSet.PartPresup);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.presupCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.PresupCab,VariablesGlobales.nIdEmpresaActual);
           
            this.proveedoresTableAdapter.Fill(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);
            this.empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

           

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            fechaPresupDateTimePicker.Value = DateTime.Now;
             DataRowView empresa=(DataRowView)empresasActualBindingSource.Current;
            numPresupTextBox.Text=Convert.ToString(empresa["PresupEmpresa"]);
            empresa["PresupEmpresa"] = Convert.ToInt32(empresa["PresupEmpresa"]) + 1;
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);

            DataRowView presup = (DataRowView)presupCabBindingSource.Current;
            presup["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            presup["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            presup["Facturado"] = false;

            toolStripButton1.Enabled = false;
            toolStripButton7.Enabled = false;
            toolStripButton8.Enabled = false;
            toolStripButton14.Enabled = false;
            toolStripButton15.Enabled = false;
            toolStripButton21.Enabled = false;
            numPresupTextBox.Focus();
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                obrasBindingSource.Filter = "IdCliente=" + Convert.ToString(idClienteComboBox.SelectedValue);
            }
            catch
            {}
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.presupCapBindingSource.EndEdit();
                presupCapTableAdapter.Update(promowork_dataDataSet.PresupCap);

                toolStripButton8.Enabled = true;
                toolStripButton14.Enabled = true;
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("No se pudieron Salvar los Cambios al Registro Actual. Campos Obligatorios Vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.presupCapTableAdapter.Fill(this.promowork_dataDataSet.PresupCap);
            }
            catch (SqlException ex)
            {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.presupCapTableAdapter.Fill(this.promowork_dataDataSet.PresupCap);
                    }
                      
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.presupDetBindingSource.EndEdit();
                presupDetTableAdapter.Update(promowork_dataDataSet.PresupDet);

                int pos = presupCabBindingSource.Position;
                int pos1 = presupCapBindingSource.Position;
                int pos2 = presupDetBindingSource.Position;
                presupCabTableAdapter.FillByEmpresa(promowork_dataDataSet.PresupCab, VariablesGlobales.nIdEmpresaActual);
                presupCabBindingSource.Position = pos;
                presupCapTableAdapter.Fill(promowork_dataDataSet.PresupCap);
                presupCapBindingSource.Position = pos1;
                presupDetTableAdapter.Fill(promowork_dataDataSet.PresupDet);
                presupDetTableAdapter.Update(promowork_dataDataSet.PresupDet);
                presupDetBindingSource.Position = pos2;
                toolStripButton23.Enabled = true;
                toolStripButton29.Enabled = true;
                
            }
            catch(NoNullAllowedException)
            {
                MessageBox.Show("No se pudieron Salvar los Cambios al Registro Actual. Campos Obligatorios Vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.presupDetTableAdapter.Fill(this.promowork_dataDataSet.PresupDet);
            }
            catch (SqlException ex)
            {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.presupDetTableAdapter.Fill(this.promowork_dataDataSet.PresupDet);
                    }
                      
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton8.Enabled = false;
            toolStripButton14.Enabled = false;
            presupCapDataGridView.Focus();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripButton23.Enabled = false;
            toolStripButton29.Enabled = false;
            presupDetDataGridView.Focus();
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.partPresupBindingSource.EndEdit();
                partPresupTableAdapter.Update(promowork_dataDataSet.PartPresup);
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("No se pudieron Salvar los Cambios al Registro Actual. Campos Obligatorios Vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.partPresupTableAdapter.Fill(this.promowork_dataDataSet.PartPresup);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.partPresupTableAdapter.Fill(this.promowork_dataDataSet.PartPresup);
                    }
                       
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton2.Checked==true)
           {
            presupCabBindingSource.Filter = "Facturado=false";
           }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                presupCabBindingSource.Filter = null;
            }
        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            DataRowView presup = (DataRowView)presupCabBindingSource.Current;

            int Presupuesto = Convert.ToInt32(presup["IdPresupCab"]);


            RptPresupuestoActual frm = new RptPresupuestoActual();
            frm.LoadFiltro(Presupuesto);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.presupSubBindingSource.EndEdit();
                presupSubTableAdapter.Update(promowork_dataDataSet.PresupSub);

                int pos = presupCabBindingSource.Position;
                int pos1 = presupCapBindingSource.Position;
                int pos2 = presupDetBindingSource.Position;
                int pos3 = presupSubBindingSource.Position;
               
                if (presupSubDataGridView.RowCount!= 0)
                {
                    DataRowView presupDet = (DataRowView)presupDetBindingSource.Current;
                    presupDet["Cantidad"] = 0;
                    presupDet["Precio"] = 0;
                    this.presupDetBindingSource.EndEdit();
                    presupDetTableAdapter.Update(promowork_dataDataSet.PresupDet);
                }
                presupCabTableAdapter.FillByEmpresa(promowork_dataDataSet.PresupCab, VariablesGlobales.nIdEmpresaActual);
                presupCabBindingSource.Position = pos;
                presupCapTableAdapter.Fill(promowork_dataDataSet.PresupCap);
                presupCapBindingSource.Position = pos1;
                presupDetTableAdapter.Fill(promowork_dataDataSet.PresupDet);
                presupDetBindingSource.Position = pos2;
                presupSubBindingSource.Position = pos3;

            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("No se pudieron Salvar los Cambios al Registro Actual. Campos Obligatorios Vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.presupSubTableAdapter.Fill(this.promowork_dataDataSet.PresupSub);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.presupSubTableAdapter.Fill(this.promowork_dataDataSet.PresupSub);
                }

            }
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
           presupSubDataGridView.Focus();
        }

        private void presupDetDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (presupSubDataGridView.RowCount != 0)
            {
                presupDetDataGridView.Columns["Cantidad"].ReadOnly = true;
                presupDetDataGridView.Columns["Precio"].ReadOnly = true;
            }
            else
            {
                presupDetDataGridView.Columns["Cantidad"].ReadOnly = false;
                presupDetDataGridView.Columns["Precio"].ReadOnly = false;
            }
        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            DataRowView presup = (DataRowView)presupCabBindingSource.Current;

            int Presupuesto = Convert.ToInt32(presup["IdPresupCab"]);


            RptPresupuestoActualFcatCob frm = new RptPresupuestoActualFcatCob();
            frm.LoadFiltro(Presupuesto);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void presupDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void presupSubDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void presupCapDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void presupCabDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!Convert.IsDBNull(this.presupCabDataGridView.Rows[e.RowIndex].Cells["ColorCab"].Value))
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(this.presupCabDataGridView.Rows[e.RowIndex].Cells["ColorCab"].Value));
            }
        }

        private void presupCapDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!Convert.IsDBNull(this.presupCapDataGridView.Rows[e.RowIndex].Cells["ColorCap"].Value))
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(this.presupCapDataGridView.Rows[e.RowIndex].Cells["ColorCap"].Value));
                
            }
        }

        private void presupDetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!Convert.IsDBNull(this.presupDetDataGridView.Rows[e.RowIndex].Cells["ColorDet"].Value))
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(this.presupDetDataGridView.Rows[e.RowIndex].Cells["ColorDet"].Value));
            }
        }

        private void presupSubDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!Convert.IsDBNull(this.presupSubDataGridView.Rows[e.RowIndex].Cells["ColorSub"].Value))
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(this.presupSubDataGridView.Rows[e.RowIndex].Cells["ColorSub"].Value));
            }
        }

        private void toolStripButton31_Click(object sender, EventArgs e)
        {
            this.presupCabDataGridView.CurrentRow.Cells["ColorCab"].Value = toolStripButton31.BackColor.ToArgb();
            this.presupCabDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton31.BackColor;
        }

        private void toolStripButton32_Click(object sender, EventArgs e)
        {
            this.presupCabDataGridView.CurrentRow.Cells["ColorCab"].Value = toolStripButton32.BackColor.ToArgb();
            this.presupCabDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton32.BackColor;
        }

        private void toolStripButton33_Click(object sender, EventArgs e)
        {
            this.presupCabDataGridView.CurrentRow.Cells["ColorCab"].Value = toolStripButton33.BackColor.ToArgb();
            this.presupCabDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton33.BackColor;
        }

        private void toolStripButton34_Click(object sender, EventArgs e)
        {
            this.presupCapDataGridView.CurrentRow.Cells["ColorCap"].Value = toolStripButton34.BackColor.ToArgb();
            this.presupCapDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton34.BackColor;
        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            this.presupCapDataGridView.CurrentRow.Cells["ColorCap"].Value = toolStripButton35.BackColor.ToArgb();
            this.presupCapDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton35.BackColor;
        }

        private void toolStripButton36_Click(object sender, EventArgs e)
        {
            this.presupCapDataGridView.CurrentRow.Cells["ColorCap"].Value = toolStripButton36.BackColor.ToArgb();
            this.presupCapDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton36.BackColor;
        }

        private void toolStripButton37_Click(object sender, EventArgs e)
        {
            this.presupDetDataGridView.CurrentRow.Cells["ColorDet"].Value = toolStripButton37.BackColor.ToArgb();
            this.presupDetDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton37.BackColor;
        }

        private void toolStripButton38_Click(object sender, EventArgs e)
        {
            this.presupDetDataGridView.CurrentRow.Cells["ColorDet"].Value = toolStripButton38.BackColor.ToArgb();
            this.presupDetDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton38.BackColor;
        }

        private void toolStripButton39_Click(object sender, EventArgs e)
        {
            this.presupDetDataGridView.CurrentRow.Cells["ColorDet"].Value = toolStripButton39.BackColor.ToArgb();
            this.presupDetDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton39.BackColor;
        }

        private void toolStripButton40_Click(object sender, EventArgs e)
        {
            this.presupSubDataGridView.CurrentRow.Cells["ColorSub"].Value = toolStripButton40.BackColor.ToArgb();
            this.presupSubDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton40.BackColor;
        }

        private void toolStripButton41_Click(object sender, EventArgs e)
        {
            this.presupSubDataGridView.CurrentRow.Cells["ColorSub"].Value = toolStripButton41.BackColor.ToArgb();
            this.presupSubDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton41.BackColor;
        }

        private void toolStripButton42_Click(object sender, EventArgs e)
        {
            this.presupSubDataGridView.CurrentRow.Cells["ColorSub"].Value = toolStripButton42.BackColor.ToArgb();
            this.presupSubDataGridView.CurrentRow.DefaultCellStyle.ForeColor = toolStripButton42.BackColor;
        }

              
    }
}
