using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
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
           
             try
                {
                    
                    this.Validate();
                    this.obrasBindingSource.EndEdit();
                    obrasTableAdapter.Update(promowork_dataDataSet.Obras);
 
                    //Calculo la Id de la obra actual, el mes y el año
                    DataRowView ObraActual = (DataRowView)obrasBindingSource.Current;  
                 
                 int IdObraActual = Convert.ToInt32(ObraActual["IdObra"]);
                    byte MesEmpresaActual = Convert.ToByte(VariablesGlobales.nMesActual);
                    int AnoEmpresaActual = Convert.ToInt32(VariablesGlobales.nAnoActual);


                    for (int i=0; i<promowork_dataDataSet.PartObras.Count; i++)
                     {
                      if (Convert.ToInt32(promowork_dataDataSet.Tables["PartObras"].Rows[i]["IdObra"])<0)
                      {
                       promowork_dataDataSet.Tables["PartObras"].Rows[i]["IdObra"]=IdObraActual;
                      }
                     }
                    partObrasTableAdapter.Update(promowork_dataDataSet.PartObras);


                    if (festivosObrasDiasDataGridView.RowCount != 0)
                    {
                        for (int i = 0; i < festivosObrasDiasDataGridView.ColumnCount; i++)
                            {
                                try
                                {
                                    queriesTableAdapter1.ActualizaFestivosObras(Convert.ToBoolean(festivosObrasDiasDataGridView.Rows[0].Cells[i].Value), IdObraActual, (i + 1), MesEmpresaActual, AnoEmpresaActual);
                                }
                                catch
                                { }
                          }

                        
                    }
                    else
                    {
                        //Agrego festivos de la obra.
                        queriesTableAdapter1.AgregaFestivosUnaObra(IdObraActual,VariablesGlobales.nAnoActual,VariablesGlobales.nMesActual);
                    }
                    empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
                    if (Convert.ToInt32(numObraTextBox.Text) < 0)
                    {
                        promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"] = Convert.ToInt32(numObraTextBox.Text) - 1;
                    }
                    else
                    {

                        promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"] = Convert.ToInt32(numObraTextBox.Text) + 1;
                    }
                 
            
            this.Validate();
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);

                    //Ejecuto el evento en el datagrid, para actualizar
            gridView1_FocusedRowChanged(null, null);
                    toolStripButton8.Enabled = true;
                    toolStripButton2.Enabled = true;
                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.obrasTableAdapter.FillByFechaObra(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.obrasTableAdapter.FillByFechaObra(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
                    }
                    
                }


        }

        private void Obras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PartObras' table. You can move, or remove it, as needed.
            this.partObrasTableAdapter.Fill(this.promowork_dataDataSet.PartObras);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.promowork_dataDataSet.Provincias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Poblaciones' table. You can move, or remove it, as needed.
            this.poblacionesTableAdapter.Fill(this.promowork_dataDataSet.Poblaciones);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PartObras' table. You can move, or remove it, as needed.
            this.participantesTableAdapter.Fill(this.promowork_dataDataSet.Participantes);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.FillByConstructores(this.promowork_dataDataSet.Empresas, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Clientes' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(promowork_dataDataSet.Proveedores, VariablesGlobales.nIdEmpresaActual);
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByFechaObra(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.
           
          //  clientesBindingSource.Sort = "DesCliente";
           // clientesBindingSource1.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PartObras' table. You can move, or remove it, as needed.
            this.marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
           // this.obrasTableAdapter.Fill(this.promowork_dataDataSet.Obras);

            if (promowork_dataDataSet.Obras.Count != 0)
            {
                DataRowView ObraActual = (DataRowView)obrasBindingSource.Current;
                this.festivosObrasDiasTableAdapter.FillByObra(this.promowork_dataDataSet.FestivosObrasDias, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, Convert.ToInt32(ObraActual["IdObra"]));
            }

        }

       
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            obrasBindingSource.Filter = null;
            obrasBindingSource.MoveLast();

            int NumDiasMes = DateTime.DaysInMonth(Convert.ToInt32(VariablesGlobales.nAnoActual), Convert.ToByte(VariablesGlobales.nMesActual));
            DateTime fechaIni = new DateTime(Convert.ToInt32(VariablesGlobales.nAnoActual), Convert.ToByte(VariablesGlobales.nMesActual), 1);
            DateTime fechaFin = new DateTime(Convert.ToInt32(VariablesGlobales.nAnoActual), Convert.ToByte(VariablesGlobales.nMesActual), NumDiasMes);

              gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
              empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            if (Convert.IsDBNull(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"]))
            {
            numObraTextBox.Text = "1";
            promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"] = 1;
            }
            else
            {
           
                numObraTextBox.Text = Convert.ToString(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"]);
            if (Convert.ToInt32(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"]) < 0)
            {
                promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"] = Convert.ToInt32(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"]) - 1;
            }
            else
            {

                promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"] = Convert.ToInt32(promowork_dataDataSet.Tables["EmpresasActual"].Rows[0]["ObraEmpresa"]) + 1;
            }
            }
            this.Validate();
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);
            
           fechaIniObraDateTimePicker.Value = fechaIni;
           fechaFinObraDateTimePicker.Value = fechaFin;
           fechaFinObraDateTimePicker.MinDate = fechaIniObraDateTimePicker.Value;
          // desObraTextBox.Focus();
            toolStripButton8.Enabled=false;
            toolStripButton2.Enabled = false;
           numObraTextBox.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                obrasTableAdapter.FillByFechaObra(promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
            }
            else
            {
             this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras,VariablesGlobales.nIdEmpresaActual);
            }
        }

        private void fechaIniObraDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fechaFinObraDateTimePicker.MinDate = fechaIniObraDateTimePicker.Value;
            if (fechaFinObraDateTimePicker.Value < fechaIniObraDateTimePicker.Value)
            {
                fechaFinObraDateTimePicker.Value = fechaIniObraDateTimePicker.Value;
            }
        }

        private void fechaIniObraDateTimePicker_Validated(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente Desea Establecer los Días Festivos de Empresa a la Obra Actual?", this.Name.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRowView ObraActual = (DataRowView)obrasBindingSource.Current; 
                int IdObraActual = Convert.ToInt32(ObraActual["IdObra"]);
                queriesTableAdapter1.AgregaFestivosUnaObra(IdObraActual,VariablesGlobales.nAnoActual,VariablesGlobales.nMesActual);
                gridView1_FocusedRowChanged(null, null);
            }
        }

        private void festivosObrasDiasDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.festivosObrasDiasDataGridView.Rows[0].Cells[e.ColumnIndex].ReadOnly == true)
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
            else
            {
                if (Convert.ToBoolean(e.Value) == true)
                {
                    e.CellStyle.BackColor = Color.AntiqueWhite;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                }
            }
        }

        private void Obras_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Close();
            /*  if (promowork_dataDataSet.HasChanges())
            {
                if (MessageBox.Show("Desea Guardar los Cambios Realizdos a la Obra Actual ?", this.Name.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obrasBindingNavigatorSaveItem_Click(null, null);
                }
            }*/
          
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

        private void button3_Click(object sender, EventArgs e)
        {
            Poblaciones frm = new Poblaciones();
            frm.ShowDialog();
            provinciasTableAdapter.Fill(promowork_dataDataSet.Provincias);
            poblacionesTableAdapter.Fill(promowork_dataDataSet.Poblaciones);
            //provincias1TableAdapter.Fill(promowork_dataDataSet.Provincias1);
            //poblaciones1TableAdapter.Fill(promowork_dataDataSet.Poblaciones1);
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
                    fechaIniObraDateTimePicker.Focus();
                }
                else
                {
                    textBox1.Text = "";
                    comboBox1.SelectedValue = -1;
                    comboBox2.SelectedValue = -1;
                }
            }
        }

        private void numObraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            obrasBindingSource.Filter = null;
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            obrasBindingSource.Filter = "DesObra like '%" + toolStripTextBox1.Text + "%'";
        }

        private void obrasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.obrasPartObrasBindingSource.EndEdit();
            partObrasTableAdapter.Update(promowork_dataDataSet.PartObras);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.partObrasTableAdapter.Fill(this.promowork_dataDataSet.PartObras);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.partObrasTableAdapter.Fill(this.promowork_dataDataSet.PartObras);
                    }
                    
                }
        }

     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                openFileDialog1.ShowDialog();
                dataGridView1.CurrentRow.Cells["PathAdjunto"].Value = openFileDialog1.FileName;
            }
            if (e.ColumnIndex == 3)
            {
               try
                {
                    System.Diagnostics.Process.Start(Convert.ToString(dataGridView1.CurrentRow.Cells["PathAdjunto"].Value));
                }
                catch
                {
                    MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            DataRowView ObraActual = (DataRowView)obrasBindingSource.Current; 
            int IdObraActual = Convert.ToInt32(ObraActual["IdObra"]);
            try
            {
                this.Validate();
                this.adjuntosObrasBindingSource.EndEdit();
                adjuntosObrasTableAdapter.Update(promowork_dataDataSet.AdjuntosObras);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usu;ario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.adjuntosObrasTableAdapter.Fill(this.promowork_dataDataSet.AdjuntosObras, IdObraActual);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.adjuntosObrasTableAdapter.Fill(this.promowork_dataDataSet.AdjuntosObras, IdObraActual);
                }

            }
        }

        private void partObrasDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (Application.OpenForms["Proveedores"] != null)
            {
                Application.OpenForms["Proveedores"].Activate();
            }
            else
            {
                Proveedores frm = new Proveedores();
                frm.MdiParent = this.MdiParent;
                frm.LoadFiltro(Convert.ToInt32(partObrasDataGridView.CurrentRow.Cells["IdProveedor"].Value));
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
            clientesTableAdapter.FillByEmpresa(promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
        }

       private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRowView ObraActual = (DataRowView)obrasBindingSource.Current;
            string IdObraActual = Convert.ToString(ObraActual["IdObra"]);


            DataTable tmpObras = promowork_dataDataSet.MarcaObras.Select("IdObra= " + IdObraActual).CopyToDataTable();

            RptResumenObraCompleta frm = new RptResumenObraCompleta();
            frm.LoadParametros(tmpObras, true, -65536, -16776961, -16777216);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            DataRowView ObraActual = (DataRowView)obrasBindingSource.Current;
            fechaFinObraDateTimePicker.MinDate = fechaIniObraDateTimePicker.Value;
            //empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            try
            {
                this.festivosObrasDiasTableAdapter.FillByObra(this.promowork_dataDataSet.FestivosObrasDias,VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra")));
            }
            catch { }

            int IdEmpresaActual = VariablesGlobales.nIdEmpresaActual;
            byte MesEmpresaActual = Convert.ToByte(VariablesGlobales.nMesActual);
            int AnoEmpresaActual = Convert.ToInt32(VariablesGlobales.nAnoActual);
            //Cargo los datos al Dataset
            //  this.festivosObrasDiasTableAdapter.FillByObra(this.promowork_dataDataSet.FestivosObrasDias, Convert.ToInt32(promowork_dataDataSet.Tables["Obras"].Rows[obrasDataGridView.CurrentRow.Index]["IdObra"]));

            //Determino la cantidad de Dias del Mes de trabajo
            int NumDiasMes = DateTime.DaysInMonth(Convert.ToInt32(VariablesGlobales.nAnoActual), Convert.ToByte(VariablesGlobales.nMesActual));
            int IdObraActual = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdObra"));

            this.adjuntosObrasTableAdapter.Fill(this.promowork_dataDataSet.AdjuntosObras, IdObraActual);


            if (festivosObrasDiasDataGridView.RowCount != 0)
            // && !Convert.IsDBNull(promowork_dataDataSet.Tables["Obras"].Rows[obrasDataGridView.CurrentRow.Index]["FechaIniObra"])
            //   && !Convert.IsDBNull(promowork_dataDataSet.Tables["Obras"].Rows[obrasDataGridView.CurrentRow.Index]["FechaFinObra"]))
            {
                festivosObrasDiasDataGridView.ReadOnly = false;
                for (int i = 0; i < festivosObrasDiasDataGridView.ColumnCount; i++)
                {

                    if (i < NumDiasMes)
                    {
                        festivosObrasDiasDataGridView.Columns[i].Visible = true;

                        DateTime dateValue = new DateTime(Convert.ToInt32(VariablesGlobales.nAnoActual), Convert.ToByte(VariablesGlobales.nMesActual), (i + 1));


                        this.festivosObrasDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                        this.festivosObrasDiasDataGridView.Columns[i].Width = (this.festivosObrasDiasDataGridView.Width - 40) / NumDiasMes;

                        if (dateValue < fechaIniObraDateTimePicker.Value
                            || dateValue > fechaFinObraDateTimePicker.Value)
                        {
                            // this.festivosObrasDiasDataGridView.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
                            this.festivosObrasDiasDataGridView.Rows[0].Cells[i].Value = false;
                            this.festivosObrasDiasDataGridView.Rows[0].Cells[i].ReadOnly = true;
                        }
                        else
                        {
                            this.festivosObrasDiasDataGridView.Rows[0].Cells[i].ReadOnly = false;
                        }
                    }

                    else
                    {
                        festivosObrasDiasDataGridView.Columns[i].Visible = false;
                    }
                }
            }
            else
            {
                //   festivosObrasDiasDataGridView.DefaultCellStyle.BackColor = Color.LightGray;
                festivosObrasDiasDataGridView.ReadOnly = true;
            }

            // //////////////////////////////////////////////////////////////////

            object nIdPoblacion = gridView1.GetFocusedRowCellValue("IdPoblacion");
            if (!Convert.IsDBNull(nIdPoblacion))
            {
                try
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
                catch { }
            }
            else
            {
                textBox1.Text = "";
                comboBox1.SelectedValue = -1;
            }
        }

            
    }
}
