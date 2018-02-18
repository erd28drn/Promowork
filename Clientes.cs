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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((desClienteTextBox.Text.Trim().Length == 0) && clientesDataGridView.RowCount != 0) //|| dNINIFClienteTextBox.Text.Trim().Length == 0
            {
                MessageBox.Show("La Descripción no pueden estar Vacia.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.clientesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

                    promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ClieEmpresa"] = Convert.ToInt32(numClienteTextBox.Text)+1;

                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
                    clientesBindingSource.Sort = "NumCliente";
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
                        clientesBindingSource.Sort = "NumCliente";
                    }
                    
                }
            
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.SalariosVenta' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones1' table. You can move, or remove it, as needed.
           
            this.poblacionesTableAdapter.Fill(promowork_dataDataSet.Poblaciones);
            this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);
            this.poblaciones1TableAdapter.Fill(promowork_dataDataSet.Poblaciones1);
            this.provincias1TableAdapter.Fill(this.promowork_dataDataSet.Provincias1);
           // this.poblacionesProvinciasTableAdapter.Fill(promowork_dataDataSet.PoblacionesProvincias);

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Presupuestos' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            this.empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            
           // clientesBindingSource.Sort = "NumCliente";

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            clientesBindingSource.Filter = null;
          //  clientesBindingSource.MoveLast();
            
            clientesDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
            activoClienteCheckBox.CheckState = CheckState.Checked;

            if (Convert.IsDBNull(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ClieEmpresa"]))
            {
             numClienteTextBox.Text = "1";
             promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ClieEmpresa"] = 1;
            }
            else
            {
            numClienteTextBox.Text = Convert.ToString(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ClieEmpresa"]);
            promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ClieEmpresa"] = Convert.ToInt32(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ClieEmpresa"]) + 1;
            }
                this.Validate();
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);

            numClienteTextBox.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormasPago frm = new FormasPago();
            frm.ShowDialog();
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Combo1 change");
            try
            {
                this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, Convert.ToInt32(comboBox1.SelectedValue));
            }
            catch
            { 
            }
          
        }

        
        private void clientesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
             DataRowView RowActual = (DataRowView)clientesBindingSource.Current;
         
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
                this.salariosVentaTableAdapter.FillByCliente(this.promowork_dataDataSet.SalariosVenta, (int)clientesDataGridView.CurrentRow.Cells["IdCliente1"].Value);
            
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
                    telClienteTextBox.Focus();
                }
                else
                {
                    textBox2.Text = "";
                    comboBox4.SelectedValue = -1;
                    comboBox3.SelectedValue = -1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BancosCuentas frm = new BancosCuentas();
            frm.ShowDialog();
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poblaciones frm = new Poblaciones();
            frm.ShowDialog();
            provinciasTableAdapter.Fill(promowork_dataDataSet.Provincias);
            poblacionesTableAdapter.Fill(promowork_dataDataSet.Poblaciones);
            //provincias1TableAdapter.Fill(promowork_dataDataSet.Provincias1);
            //poblaciones1TableAdapter.Fill(promowork_dataDataSet.Poblaciones1);
            clientesDataGridView_CellEnter(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Poblaciones frm = new Poblaciones();
            frm.ShowDialog();
           // provinciasTableAdapter.Fill(promowork_dataDataSet.Provincias);
            //poblacionesTableAdapter.Fill(promowork_dataDataSet.Poblaciones);
            provincias1TableAdapter.Fill(promowork_dataDataSet.Provincias1);
            poblaciones1TableAdapter.Fill(promowork_dataDataSet.Poblaciones1);
            clientesDataGridView_CellEnter(null, null);
            
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
           clientesBindingSource.Filter = "DesCliente like '%" + toolStripTextBox1.Text + "%'";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            clientesBindingSource.Filter = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            DataRowView clienteActual = (DataRowView)clientesBindingSource.Current;
            clienteActual["AdjCliente"] = openFileDialog1.FileName;
            copiaFacturaTextBox.Text = openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRowView clienteActual = (DataRowView)clientesBindingSource.Current;
            try
            {
                System.Diagnostics.Process.Start(Convert.ToString(clienteActual["AdjCliente"]));
            }
            catch
            {
                MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataRowView clienteActual = (DataRowView)clientesBindingSource.Current;
            clienteActual["AdjCliente"] = null;
            copiaFacturaTextBox.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.clientesBindingSource.RemoveCurrent();
            }
        }

       
       
    }
}
