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
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
        }
       private void trabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*if ((nomTrabajadorTextBox.Text.Trim().Length == 0 || dNITrabajadorTextBox.Text.Trim().Length == 0) && trabajadoresDataGridView.RowCount!=0)
            {
                MessageBox.Show("El Nombre y el DNI no pueden estar vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {*/
                try
                {
                    this.Validate();
                    this.trabajadoresBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

                    for (int i = 0; i < promowork_dataDataSet.CursosTrabajadores.Count; i++)
                    {
                        if (Convert.ToInt32(promowork_dataDataSet.Tables["CursosTrabajadores"].Rows[i]["IdTrabajador"]) < 0)
                        {
                            promowork_dataDataSet.Tables["CursosTrabajadores"].Rows[i]["IdTrabajador"] = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["IdTrabajador"];
                        }
                    }

                    this.cursosTrabajadoresBindingSource.EndEdit();
                    cursosTrabajadoresTableAdapter.Update(promowork_dataDataSet.CursosTrabajadores);

                    for (int i = 0; i < promowork_dataDataSet.HijosTrabajadores.Count; i++)
                    {
                        if (Convert.ToInt32(promowork_dataDataSet.Tables["HijosTrabajadores"].Rows[i]["IdTrabajador"]) < 0)
                        {
                            promowork_dataDataSet.Tables["HijosTrabajadores"].Rows[i]["IdTrabajador"] = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["IdTrabajador"];
                        }
                    }

                    this.hijosTrabajadoresBindingSource.EndEdit();
                    hijosTrabajadoresTableAdapter.Update(promowork_dataDataSet.HijosTrabajadores);

                    for (int i = 0; i < promowork_dataDataSet.SalariosTipos.Count; i++)
                    {
                        if (Convert.ToInt32(promowork_dataDataSet.Tables["SalariosTipos"].Rows[i]["IdTrabajador"]) < 0)
                        {
                            promowork_dataDataSet.Tables["SalariosTipos"].Rows[i]["IdTrabajador"] = promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["IdTrabajador"];
                        }
                    }

                    this.salariosTiposBindingSource.EndEdit();
                    salariosTiposTableAdapter.Update(promowork_dataDataSet.SalariosTipos);
                }
                    catch(NoNullAllowedException)
                    {
                        MessageBox.Show("No se pudieron Salvar los Cambios al Registro Actual. Campos Obligatorios Vacios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.trabajadoresTableAdapter.Fill(this.promowork_dataDataSet.Trabajadores, VariablesGlobales.nIdEmpresaActual);
                }
               
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.trabajadoresTableAdapter.Fill(this.promowork_dataDataSet.Trabajadores, VariablesGlobales.nIdEmpresaActual);
                    }
                }

           // }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'promowork_dataDataSet.CuentasBancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            this.cuentasBancosBindingSource.Filter = "CtaEmpresa=false";
            this.empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones' table. You can move, or remove it, as needed.
            this.poblacionesTableAdapter.Fill(this.promowork_dataDataSet.Poblaciones);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Naciones' table. You can move, or remove it, as needed.
            this.nacionesTableAdapter.Fill(this.promowork_dataDataSet.Naciones);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PuestosTrabajo' table. You can move, or remove it, as needed.
            this.puestosTrabajoTableAdapter.Fill(this.promowork_dataDataSet.PuestosTrabajo);
            
            // TODO: This line of code loads data into the 'promowork_dataDataSet.HijosTrabajadores' table. You can move, or remove it, as needed.
            this.hijosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.HijosTrabajadores);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.HijosTrabajadores' table. You can move, or remove it, as needed.
            this.hijosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.HijosTrabajadores);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Empresas,VariablesGlobales.nIdEmpresaActual);
           // this.WindowState = FormWindowState.Maximized;           
            // TODO: This line of code loads data into the 'promowork_dataDataSet.EstadoCivil' table. You can move, or remove it, as needed.
            this.estadoCivilTableAdapter.Fill(this.promowork_dataDataSet.EstadoCivil);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.HijosTrabajadores' table. You can move, or remove it, as needed.
            this.cursosTableAdapter.Fill(this.promowork_dataDataSet.Cursos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.cursosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.CursosTrabajadores);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.CrucesTrabajadores' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.SalariosTipos' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ContratosTrabajadores' table. You can move, or remove it, as needed.
            this.contratosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.ContratosTrabajadores);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Trabajadores' table. You can move, or remove it, as needed.
            this.trabajadoresTableAdapter.Fill(this.promowork_dataDataSet.Trabajadores,VariablesGlobales.nIdEmpresaActual);

            this.salariosTiposTableAdapter.Fill(this.promowork_dataDataSet.SalariosTipos);

          
            
        }

       
       
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

             DataRowView current = (DataRowView)trabajadoresBindingSource.Current;
             current["FotoTrabajador"] = openFileDialog1.FileName;
                    
           // promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["FotoTrabajador"] = openFileDialog1.FileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
         
        }

        private void trabajadoresDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

          //  MessageBox.Show(Convert.ToString(trabajadoresBindingSource.Current));
            try
            {
                if (trabajadoresDataGridView.CurrentRow.Index < promowork_dataDataSet.Trabajadores.Count)
                {
                    DataRowView current = (DataRowView)trabajadoresBindingSource.Current;
                    if (Convert.ToString(current["FotoTrabajador"]).Count() == 0)
                    {
                        this.pictureBox1.ImageLocation = "";
                    }
                    else
                    {
                        this.pictureBox1.ImageLocation =Convert.ToString(current["FotoTrabajador"]);
                    }

                    if (Convert.ToString(current["CopDNITrabajador"]).Count() == 0)
                    {
                        this.pictureBox2.ImageLocation = "";
                    }
                    else
                    {
                        this.pictureBox2.ImageLocation = Convert.ToString(current["CopDNITrabajador"]);
                    }

                    if (Convert.ToString(current["CopDNITrabajador1"]).Count()==0)
                    {
                        this.pictureBox3.ImageLocation = "";
                    }
                    else
                    {

                        this.pictureBox3.ImageLocation = Convert.ToString(current["CopDNITrabajador1"]);
                    }
                }
                else
                {
                    this.pictureBox1.ImageLocation = "";
                    this.pictureBox2.ImageLocation = "";
                    this.pictureBox3.ImageLocation = "";
                }
            }
            catch
            {
                MessageBox.Show("No se pudo actualizar la Foto y demas copias...");
            }

                   DataRowView TrabActual = (DataRowView)trabajadoresBindingSource.Current;
         
                    object nIdPoblacion = TrabActual["IdPoblacion"];
                if (!Convert.IsDBNull(nIdPoblacion))
                {
                    DataRow FilaSel = promowork_dataDataSet.Poblaciones.FindByIdPoblacion(Convert.ToInt32(nIdPoblacion));
                    int nIdProvincia = Convert.ToInt32(FilaSel["IdProvincia"]);
                    if (Convert.ToInt32(comboBox5.SelectedValue) != nIdProvincia)
                    {
                        comboBox5.SelectedValue = nIdProvincia;
                        this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, nIdProvincia);
                    }
                    comboBox4.SelectedValue = Convert.ToInt32(nIdPoblacion);
                }
                else
                {
                    textBox1.Text = "";
                    comboBox5.SelectedValue = -1;
                }
               
            

        }

        private void salariosTiposDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
            this.Validate();
            this.salariosTiposBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            
            salariosTiposTableAdapter.Update(promowork_dataDataSet.SalariosTipos);
            }
           catch (DBConcurrencyException)
           {

              // int rowpos = trabajadoresDataGridView.CurrentCell.RowIndex;
               MessageBox.Show("No se Pudo Salvar la Información. El record fue modificado por otro operador.", "Error");
               this.salariosTiposTableAdapter.Fill(this.promowork_dataDataSet.SalariosTipos);

           }
        }

        
        
        private void button3_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(comboBox3.SelectedValue);
            EstadoCivil frm = new EstadoCivil();
            frm.ShowDialog();
           
            this.estadoCivilTableAdapter.Fill(this.promowork_dataDataSet.EstadoCivil);
            comboBox3.SelectedValue = sel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sel1 = Convert.ToInt32(comboBox1.SelectedValue);
            int sel2 = Convert.ToInt32(idPuestoTrabComboBox.SelectedValue);
            Categorias frm = new Categorias();
            frm.ShowDialog();

            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            this.puestosTrabajoTableAdapter.Fill(promowork_dataDataSet.PuestosTrabajo);
            comboBox1.SelectedValue = sel1;
            idPuestoTrabComboBox.SelectedValue = sel2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(comboBox2.SelectedValue);
            ContratosTrabajadores frm = new ContratosTrabajadores();
            //frm.MdiParent = this.MdiParent;
            frm.ShowDialog();

            this.contratosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.ContratosTrabajadores);
            comboBox2.SelectedValue = sel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            DataRowView current = (DataRowView)trabajadoresBindingSource.Current;
            current["CopDNITrabajador"] = openFileDialog1.FileName;

            //promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador"] = openFileDialog1.FileName;
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            DataRowView current = (DataRowView)trabajadoresBindingSource.Current;
            current["CopDNITrabajador1"] = openFileDialog1.FileName;

           // promowork_dataDataSet.Tables["Trabajadores"].Rows[trabajadoresDataGridView.CurrentRow.Index]["CopDNITrabajador1"] = openFileDialog1.FileName;
            pictureBox3.ImageLocation = openFileDialog1.FileName;
        }

        private void cursosTrabajadoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                Cursos frm = new Cursos();
                frm.ShowDialog();
                this.cursosTableAdapter.Fill(this.promowork_dataDataSet.Cursos);
            }

        }

        private void cursosTrabajadoresDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          /*  try
            {
                this.Validate();
                this.cursosTrabajadoresBindingSource.EndEdit();
                cursosTrabajadoresTableAdapter.Update(promowork_dataDataSet.CursosTrabajadores);
            }
            catch (DBConcurrencyException)
            {

                // int rowpos = trabajadoresDataGridView.CurrentCell.RowIndex;
                MessageBox.Show("No se Pudo Salvar la Información. El record fue modificado por otro operador.", "Error");
                this.cursosTrabajadoresTableAdapter.Fill(this.promowork_dataDataSet.CursosTrabajadores);

            } */
        }

        private void salariosTiposDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Tipos frm = new Tipos();
                frm.ShowDialog();
                this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            trabajadoresBindingSource.Filter = null;
            trabajadoresBindingSource.MoveLast();

            trabajadoresDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
            activoTrabajadorCheckBox.CheckState = CheckState.Checked ;
            hipTrabajadorCheckBox.CheckState = CheckState.Unchecked;
            altaTrabajadorDateTimePicker.Text = DateTime.Now.ToShortDateString();

            if (Convert.IsDBNull(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["TrabEmpresa"]))
            {
            numTrabajadorTextBox.Text ="1";
            promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["TrabEmpresa"] = 1;
            }
            else
            {
            numTrabajadorTextBox.Text = Convert.ToString(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["TrabEmpresa"]);
            promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["TrabEmpresa"] = Convert.ToInt32(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["TrabEmpresa"]) + 1;
            }
            this.Validate();
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);
            numTrabajadorTextBox.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Poblaciones frm = new Poblaciones();
            frm.ShowDialog();
            provinciasTableAdapter.Fill(promowork_dataDataSet.Provincias);
            poblacionesTableAdapter.Fill(promowork_dataDataSet.Poblaciones);
            //provincias1TableAdapter.Fill(promowork_dataDataSet.Provincias1);
            //poblaciones1TableAdapter.Fill(promowork_dataDataSet.Poblaciones1);
            trabajadoresDataGridView_CellEnter(null, null);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, Convert.ToInt32(comboBox5.SelectedValue));
            }
            catch
            {
            }
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
                    comboBox5.SelectedValue = nIdProvincia;
                    this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, nIdProvincia);
                    comboBox4.SelectedValue = nIdPoblacion;
                    nacTrabajadorDateTimePicker.Focus();
                }
                else
                {
                    textBox1.Text = "";
                    comboBox1.SelectedValue = -1;
                    comboBox2.SelectedValue = -1;
                }
            }
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            trabajadoresBindingSource.Filter = "NomTrabajador like '%"+toolStripTextBox1.Text+"%'";
         
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            trabajadoresBindingSource.Filter = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(idPuestoTrabComboBox.SelectedValue);
            Categorias frm = new Categorias();
            frm.ShowDialog();

          //  this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            this.puestosTrabajoTableAdapter.Fill(promowork_dataDataSet.PuestosTrabajo);
            idPuestoTrabComboBox.SelectedValue= sel;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (Convert.ToUInt32(comboBox1.SelectedValue) != 0)
            {
                puestosTrabajoBindingSource.Filter = "IdCategoria=" + Convert.ToString(comboBox1.SelectedValue);
            }
            else
            {
                puestosTrabajoBindingSource.Filter = "IdCategoria=null";
            }
           

        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            contratosTrabajadoresBindingSource.Filter = "ActivoContrato=true";
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            contratosTrabajadoresBindingSource.Filter = null;
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            estadoCivilBindingSource.Filter = "ActivoEstCivil";
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            estadoCivilBindingSource.Filter = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(idNacionComboBox.SelectedValue);
            Nacionalidades frm = new Nacionalidades();
            frm.ShowDialog();
            nacionesTableAdapter.Fill(promowork_dataDataSet.Naciones);
            idNacionComboBox.SelectedValue = sel;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(idCuentaComboBox.SelectedValue);
            BancosCuentas frm = new BancosCuentas();
            frm.ShowDialog();
            cuentasBancosTableAdapter.Fill(promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            idCuentaComboBox.SelectedValue = sel;
        }

        private void trabajadoresDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView TrabActual = (DataRowView)trabajadoresBindingSource.Current;
            int nIdTrabajador =Convert.ToInt32(TrabActual["IdTrabajador"]);
            DataRowView EmpActual = (DataRowView)empresasActualBindingSource.Current;
            int AnoIni = Convert.ToInt32(EmpActual["AnoEmpresa"]);
            int AnoFin = Convert.ToInt32(EmpActual["AnoEmpresa"]);
            
            RptFichaTrabajador frm = new RptFichaTrabajador();
            frm.LoadParametros(nIdTrabajador, AnoIni, AnoFin);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

    }
}
