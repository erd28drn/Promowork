using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Promowork
{
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }

        private void empresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((nIFEmpresaTextBox.Text.Trim().Length == 0 || desEmpresaTextBox.Text.Trim().Length == 0) && empresasDataGridView.RowCount!=0)
            {
                MessageBox.Show("El NIF y El nombre de la Empresa no pueden estar vacios.",this.Text,MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {

                    int cantEmp = promowork_dataDataSet.Empresas.Count;

                this.Validate();
                this.empresasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
                
                    
                int IdEmpresaActual = Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["IdEmpresa"]);
                byte MesEmpresaActual = Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"]);
                int AnoEmpresaActual = Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"]);

                if (cantEmp == promowork_dataDataSet.Empresas.Count)
                {
                    //this.festivosEmpresasDiasTableAdapter.FillByDias(this.promowork_dataDataSet.FestivosEmpresasDias, IdEmpresaActual, MesEmpresaActual, AnoEmpresaActual);

                    for (int i = 0; i < festivosEmpresasDiasDataGridView.ColumnCount; i++)
                    {
                        
                        queriesTableAdapter1.ActualizaFestivosEmpresas(Convert.ToBoolean(festivosEmpresasDiasDataGridView.Rows[0].Cells[i].Value), IdEmpresaActual, (i + 1), MesEmpresaActual, AnoEmpresaActual);
                    }
                }


                empresasDataGridView_CellEnter(null, null);
                 }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);
            }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);
                    }
                    
                }
            
            }
            
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones' table. You can move, or remove it, as needed.
            this.poblacionesTableAdapter.Fill(this.promowork_dataDataSet.Poblaciones);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.promowork_dataDataSet1.Clientes);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Presupuestos' table. You can move, or remove it, as needed.
            
            this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);

            //Compruebo que el final del Dataset y que esten definidos el mes y el año de trabajo de la empresa
            if ((empresasDataGridView.CurrentRow.Index < promowork_dataDataSet.Empresas.Count) &&
                (!Convert.IsDBNull(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["IntEmpresa"])
                    && !Convert.IsDBNull(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"])
                    && !Convert.IsDBNull(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"])))
            {
                //Almaceno en Variables la Id de la Empresa el mes ey el año de trabajo
                int IdEmpresaActual = Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["IdEmpresa"]);
                byte MesEmpresaActual = Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"]);
                int AnoEmpresaActual = Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"]);
                //Cargo los datos al Dataset
                this.festivosEmpresasDiasTableAdapter.FillByDias(this.promowork_dataDataSet.FestivosEmpresasDias, IdEmpresaActual, MesEmpresaActual, AnoEmpresaActual);

                //Determino la cantidad de Dias del Mes de trabajo
                int NumDiasMes = DateTime.DaysInMonth(Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"]), Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"]));

                for (int i = 0; i < festivosEmpresasDiasDataGridView.ColumnCount; i++)
                {
                    if (i < NumDiasMes)
                    {
                        festivosEmpresasDiasDataGridView.Columns[i].Visible = true;

                        DateTime dateValue = new DateTime(Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"]), Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"]), (i + 1));


                        this.festivosEmpresasDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                        this.festivosEmpresasDiasDataGridView.Columns[i].Width = (this.festivosEmpresasDiasDataGridView.Width - 40) / NumDiasMes;
                        if (Convert.ToBoolean(festivosEmpresasDiasDataGridView.Rows[0].Cells[i].Value) == true)
                        {
                            this.festivosEmpresasDiasDataGridView.Columns[i].DefaultCellStyle.BackColor = Color.AntiqueWhite;
                        }
                        else
                        {
                            this.festivosEmpresasDiasDataGridView.Columns[i].DefaultCellStyle.BackColor = Color.White;
                        }
                    }

                    else
                    {
                        festivosEmpresasDiasDataGridView.Columns[i].Visible = false;
                    }
                }

            }

            else
            {
                this.festivosEmpresasDiasTableAdapter.FillByDias(this.promowork_dataDataSet.FestivosEmpresasDias, 0, 0, 0);
                //festivosEmpresasDiasDataGridView.Visible = false;
            }

            if (empresasDataGridView.RowCount > 1)
            {

                this.pictureBox2.ImageLocation = promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["LogoEmpresa"].ToString();
            }


        }
        private void empresasDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           /* if (obrasDataGridView.RowCount == 0)
            {
                obraEmpresaTextBox.ReadOnly = false;
            }
            else
            {
                obraEmpresaTextBox.ReadOnly = true;
            }
            if (presupuestosDataGridView.RowCount == 0)
            {
                presupEmpresaTextBox.ReadOnly = false;
            }
            else
            {
                presupEmpresaTextBox.ReadOnly = true;
            }
            */
            //Compruebo que el final del Dataset y que esten definidos el mes y el año de trabajo de la empresa
            if ((empresasDataGridView.CurrentRow.Index < promowork_dataDataSet.Empresas.Count) &&
                (!Convert.IsDBNull(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["IntEmpresa"])
                    && !Convert.IsDBNull(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"])
                    && !Convert.IsDBNull(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"])))
                {
                    //Almaceno en Variables la Id de la Empresa el mes ey el año de trabajo
                    int IdEmpresaActual = Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["IdEmpresa"]);
                    byte MesEmpresaActual = Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"]);
                    int AnoEmpresaActual = Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"]);
                   //Cargo los datos al Dataset
                    this.festivosEmpresasDiasTableAdapter.FillByDias(this.promowork_dataDataSet.FestivosEmpresasDias, IdEmpresaActual, MesEmpresaActual, AnoEmpresaActual);
                                       
                   //Determino la cantidad de Dias del Mes de trabajo
                    int NumDiasMes= DateTime.DaysInMonth(Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"]), Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"]));
                
                    for (int i = 0; i < festivosEmpresasDiasDataGridView.ColumnCount; i++)
                    {
                        if (i < NumDiasMes)
                        {
                            festivosEmpresasDiasDataGridView.Columns[i].Visible = true;

                            DateTime dateValue = new DateTime(Convert.ToInt32(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["AnoEmpresa"]), Convert.ToByte(promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["MesEmpresa"]), (i + 1));


                            this.festivosEmpresasDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                            this.festivosEmpresasDiasDataGridView.Columns[i].Width = (this.festivosEmpresasDiasDataGridView.Width - 40) / NumDiasMes;
                            if (Convert.ToBoolean(festivosEmpresasDiasDataGridView.Rows[0].Cells[i].Value) == true)
                                {
                                    this.festivosEmpresasDiasDataGridView.Columns[i].DefaultCellStyle.BackColor = Color.AntiqueWhite;
                                }
                                else
                                {
                                    this.festivosEmpresasDiasDataGridView.Columns[i].DefaultCellStyle.BackColor = Color.White;
                                }
                           
                        }

                        else
                        {
                            festivosEmpresasDiasDataGridView.Columns[i].Visible = false;
                        }
                    }
                    
                    }
                 
                    else
                    {
                        this.festivosEmpresasDiasTableAdapter.FillByDias(this.promowork_dataDataSet.FestivosEmpresasDias, 0, 0, 0);
                        //festivosEmpresasDiasDataGridView.Visible = false;
                    }
            if (empresasDataGridView.CurrentRow.Index < promowork_dataDataSet.Empresas.Count)
            {
                this.pictureBox2.ImageLocation = promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["LogoEmpresa"].ToString();
            }
            else
            {
                this.pictureBox2.ImageLocation = "";
            }
           
            // ///////////////////////////////////////////////////////////////////////////////////
           DataRowView RowActual = (DataRowView)empresasBindingSource.Current;

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
                
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente Desea Establecer Los Días Festivos a Todas las Obras de Esta Empresa?",this.Name.ToString(),MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
            queriesTableAdapter1.AgregaFestivosObras(Convert.ToInt32(empresasDataGridView.CurrentRow.Cells["IdEmpresa"].Value),VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual);
            }
        }

               
        private void button4_Click(object sender, EventArgs e)
        {
            if (promowork_dataDataSet.Empresas.Count != empresasDataGridView.RowCount)
            {
                empresasBindingNavigatorSaveItem_Click(null, null);
            }
            if (nIFEmpresaTextBox.Text.Trim().Length != 0 && desEmpresaTextBox.Text.Trim().Length != 0)
               {

                openFileDialog1.ShowDialog();

                promowork_dataDataSet.Tables["Empresas"].Rows[empresasDataGridView.CurrentRow.Index]["LogoEmpresa"] = openFileDialog1.FileName;
                pictureBox2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            intEmpresaCheckBox.CheckState = CheckState.Checked;
            activoEmpresaCheckBox.CheckState = CheckState.Checked;
            mesEmpresaTextBox.Text = DateTime.Now.Month.ToString();
            anoEmpresaTextBox.Text = DateTime.Now.Year.ToString();
            obraEmpresaTextBox.Text = Convert.ToString(0);
            presupEmpresaTextBox.Text=Convert.ToString(0);
            nIFEmpresaTextBox.Focus();
        }

        private void intEmpresaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (intEmpresaCheckBox.Checked)
            {
                mesEmpresaTextBox.Enabled = true;
                anoEmpresaTextBox.Enabled = true;
                mesEmpresaTextBox.Text = DateTime.Now.Month.ToString();
                anoEmpresaTextBox.Text = DateTime.Now.Year.ToString();
                obraEmpresaTextBox.Enabled = true;
                presupEmpresaTextBox.Enabled = true;
                
            }
            else
            {
                mesEmpresaTextBox.Enabled = false;
                anoEmpresaTextBox.Enabled = false;
                mesEmpresaTextBox.Text = null;
                anoEmpresaTextBox.Text = null;
                obraEmpresaTextBox.Enabled = false;
                presupEmpresaTextBox.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int posActual = empresasDataGridView.CurrentRow.Index;
            this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);
            empresasDataGridView.CurrentCell = empresasDataGridView[0,posActual];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poblaciones frm = new Poblaciones();
            frm.ShowDialog();
            provinciasTableAdapter.Fill(promowork_dataDataSet.Provincias);
            poblacionesTableAdapter.Fill(promowork_dataDataSet.Poblaciones);
            empresasDataGridView_CellEnter(null, null);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                DataRow[] FilaSel = promowork_dataDataSet.Tables["Poblaciones"].Select("postal= " + textBox1.Text);
                if (FilaSel.Count() != 0)
                {
                    int nIdProvincia = Convert.ToInt32(FilaSel[0]["IdProvincia"]);
                    int nIdPoblacion = Convert.ToInt32(FilaSel[0]["IdPoblacion"]);
                    comboBox1.SelectedValue = nIdProvincia;
                    this.poblacionesProvinciasTableAdapter.FillByProvincia(promowork_dataDataSet.PoblacionesProvincias, nIdProvincia);
                    comboBox2.SelectedValue = nIdPoblacion;
                    mesEmpresaTextBox.Focus();
                }
                else
                {
                    textBox1.Text = "";
                    comboBox1.SelectedValue = -1;
                    comboBox2.SelectedValue = -1;
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

      
    }
}
