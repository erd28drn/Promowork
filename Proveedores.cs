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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        string AparienciaGridProveedores = "";
        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((dNINIFProveedorTextBox.Text.Trim().Length == 0 || desProveedorTextBox.Text.Trim().Length == 0) && gridView1.RowCount != 0)
            {
                MessageBox.Show("El DNI/NIF y la Descripción no pueden estar vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.proveedoresBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", "Error");
                    this.proveedoresTableAdapter.Fill(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);


                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                    this.proveedoresTableAdapter.Fill(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);

                    }
                }
            }
        }

       

        private void Proveedores_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            // TODO: This line of code loads data into the 'promowork_dataDataSet.CuentasBancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            cuentasBancosBindingSource.Filter = "CtaEmpresa=true";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Provincias1' table. You can move, or remove it, as needed.
            this.provincias1TableAdapter.Fill(this.promowork_dataDataSet.Provincias1);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones1' table. You can move, or remove it, as needed.
            this.poblaciones1TableAdapter.Fill(this.promowork_dataDataSet.Poblaciones1);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones' table. You can move, or remove it, as needed.
            this.poblacionesTableAdapter.Fill(this.promowork_dataDataSet.Poblaciones);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Participantes' table. You can move, or remove it, as needed.
            this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ComprasCab' table. You can move, or remove it, as needed.
            this.empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            this.tiposProveedoresTableAdapter.FillByEmpresa(promowork_dataDataSet.TiposProveedores, VariablesGlobales.nIdEmpresaActual);
            this.gruposProductosTableAdapter.FillByEmpresa(promowork_dataDataSet.GruposProductos, VariablesGlobales.nIdEmpresaActual);

            this.proveedoresTableAdapter.Fill(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);

            AparienciaGridProveedores = this.Name + gridView1.Name + VariablesGlobales.nIdEmpresaActual.ToString() + VariablesGlobales.nIdUsuarioActual.ToString() + ".xml";

            try
            {
                gridView1.RestoreLayoutFromXml(AparienciaGridProveedores);

            }
            catch { }
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            proveedoresBindingSource.Filter = null;
            proveedoresBindingSource.MoveLast();

           // proveedoresDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
            activoProveedorCheckBox.CheckState = CheckState.Checked;
            if (Convert.IsDBNull(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ProvEmpresa"]))
           {
                numProveedorTextBox.Text = "1";
                promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ProvEmpresa"] = 1;
           }
           else
           {
            numProveedorTextBox.Text = Convert.ToString(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ProvEmpresa"]);
            promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ProvEmpresa"] = Convert.ToInt32(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ProvEmpresa"]) + 1;
           }
            this.Validate();
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);
            numProveedorTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiposProveedores frm = new TiposProveedores();
            frm.ShowDialog();
            this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormasPago frm = new FormasPago();
            frm.ShowDialog();
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Poblaciones frm = new Poblaciones();
            frm.ShowDialog();
            provinciasTableAdapter.Fill(promowork_dataDataSet.Provincias);
            poblacionesTableAdapter.Fill(promowork_dataDataSet.Poblaciones);
            gridView1_FocusedRowChanged(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Poblaciones frm = new Poblaciones();
            frm.ShowDialog();
            provincias1TableAdapter.Fill(promowork_dataDataSet.Provincias1);
            poblaciones1TableAdapter.Fill(promowork_dataDataSet.Poblaciones1);
            gridView1_FocusedRowChanged(null, null);
        }

             
       
        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                DataRow[] FilaSel;
                FilaSel = promowork_dataDataSet.Tables["Poblaciones"].Select("postal= " + textBox1.Text);
                if (FilaSel.Count() != 0)
                {
                    int nIdProvincia = Convert.ToInt32(FilaSel[0]["IdProvincia"]);
                    int nIdPoblacion = Convert.ToInt32(FilaSel[0]["IdPoblacion"]);
                    comboBox1.SelectedValue = nIdProvincia;
                    this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, nIdProvincia);
                    comboBox2.SelectedValue = nIdPoblacion;
                    dirFiscalClienteTextBox.Focus();
                }
                else
                {
                    textBox1.Text = "";
                    comboBox1.SelectedValue = -1;
                    comboBox2.SelectedValue = -1;
                }
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                DataRow[] FilaSel;
                FilaSel = promowork_dataDataSet.Tables["Poblaciones1"].Select("postal= " + textBox2.Text);
                if (FilaSel.Count() != 0)
                {
                    int nIdProvincia = Convert.ToInt32(FilaSel[0]["IdProvincia"]);
                    int nIdPoblacion = Convert.ToInt32(FilaSel[0]["IdPoblacion"]);
                    comboBox4.SelectedValue = nIdProvincia;
                    this.poblacionesProvincias1TableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias1, nIdProvincia);
                    comboBox3.SelectedValue = nIdPoblacion;
                    telProveedorTextBox.Focus();
                }
                else
                {
                    textBox2.Text = "";
                    comboBox4.SelectedValue = -1;
                    comboBox3.SelectedValue = -1;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, Convert.ToInt32(comboBox1.SelectedValue));
            }
            catch
            {
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.poblacionesProvincias1TableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias1, Convert.ToInt32(comboBox4.SelectedValue));
            }
            catch
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BancosCuentas frm = new BancosCuentas();
            frm.ShowDialog();
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            proveedoresBindingSource.Filter = null;
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
           proveedoresBindingSource.Filter = "DesProveedor like '%" + toolStripTextBox1.Text + "%'";
        }

        internal void LoadFiltro(int nIdProveedor)
        {
            proveedoresBindingSource.Filter = "IdProveedor="+Convert.ToString(nIdProveedor);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.proveedoresBindingSource.RemoveCurrent();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRowView RowActual = (DataRowView)proveedoresBindingSource.Current;

            object nIdPoblacion = RowActual["IdPoblacion"];
            if (!Convert.IsDBNull(nIdPoblacion))
            {
                DataRow FilaSel = promowork_dataDataSet.Poblaciones.FindByIdPoblacion(Convert.ToInt32(nIdPoblacion));
                int nIdProvincia = Convert.ToInt32(FilaSel["IdProvincia"]);
                if (Convert.ToInt32(comboBox1.SelectedValue) != nIdProvincia)
                {
                    comboBox1.SelectedValue = nIdProvincia;
                    this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, nIdProvincia);
                }
                comboBox2.SelectedValue = Convert.ToInt32(nIdPoblacion);
            }
            else
            {
                textBox1.Text = "";
                comboBox1.SelectedValue = -1;
            }

            // ///////////////////////////
            object nIdPobFiscal = RowActual["IdPobFiscal"];
            if (!Convert.IsDBNull(nIdPobFiscal))
            {
                DataRow FilaSel = promowork_dataDataSet.Poblaciones1.FindByIdPoblacion(Convert.ToInt32(nIdPobFiscal));
                int nIdProvincia = Convert.ToInt32(FilaSel["IdProvincia"]);
                if (Convert.ToInt32(comboBox4.SelectedValue) != nIdProvincia)
                {
                    comboBox4.SelectedValue = nIdProvincia;
                    this.poblacionesProvincias1TableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias1, nIdProvincia);
                }
                comboBox3.SelectedValue = Convert.ToInt32(nIdPobFiscal);
            }
            else
            {
                textBox2.Text = "";
                comboBox4.SelectedValue = -1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GruposProveedores frm = new GruposProveedores();
            frm.ShowDialog();
            this.tiposProveedoresTableAdapter.FillByEmpresa(promowork_dataDataSet.TiposProveedores, VariablesGlobales.nIdEmpresaActual);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GruposProductos frm = new GruposProductos();
            frm.ShowDialog();
            this.gruposProductosTableAdapter.FillByEmpresa(promowork_dataDataSet.GruposProductos, VariablesGlobales.nIdEmpresaActual);
        }

        private void Proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.SaveLayoutToXml(AparienciaGridProveedores);
        }
    }
}
