using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Promowork
{
    public partial class HorasCruces : Form
    {
       // Boolean TerminaCargaHorasTrabajadas = false;
        public HorasCruces()
        {
            InitializeComponent();
            
        }

        private void HorasCruces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet2.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet2.Categorias);
            
            // MessageBox.Show("Load");
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'promowork_dataDataSet.HorasTrabajadas' table. You can move, or remove it, as needed.
           /////// this.horasTrabajadasTableAdapter.Fill(this.promowork_dataDataSet.HorasTrabajadas);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FestivosObras' table. You can move, or remove it, as needed.
          //////  this.festivosObrasTableAdapter.Fill(this.promowork_dataDataSet.FestivosObras);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FestivosObras' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Empresas, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.

            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Categorias' table. You can move, or remove it, as needed.
            this.trabajadoresListaTableAdapter.FillByEmpresa(promowork_dataDataSet.TrabajadoresLista, VariablesGlobales.nIdEmpresaActual);
           // comboBox1.DisplayMember = Convert.ToString(promowork_dataDataSet.Tables["Trabajdores"].Rows[comboBox1.SelectedIndex]["NomTRabajador"]);
          ///////  this.horasTrabajadasDiasTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.HorasTrabajadasDias, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(comboBox1.SelectedValue));

           ////// this.cruceTrabajadoresDiasTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.CruceTrabajadoresDias, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(comboBox1.SelectedValue));

            this.salariosTiposTableAdapter.Fill(promowork_dataDataSet.SalariosTipos);
            horasTrabajadasDiasDataGridView.Width = this.Width - dataGridView1.Width - 35;

            cruceTrabajadoresDiasDataGridView.Width = this.Width - dataGridView2.Width - 35;

            //Mes y año actual
           
            //Determino cantidad de dias que tiene el mes actual
            int NumDiasMes = DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);

            //Fecha del Primer dia del mes de tarbajo
            DateTime FechaPrimero = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, NumDiasMes);
            //Fecha del Ultimo dia del mes de tarbajo
            DateTime FechaUltimo = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, 1);

            copiasHorasTableAdapter.Fill(promowork_dataDataSet.CopiasHoras, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual);



            for (int i = 0; i < horasTrabajadasDiasDataGridView.ColumnCount; i++)
            {

                if (i < NumDiasMes)
                {

                    horasTrabajadasDiasDataGridView.Columns[i].Visible = true;
                    cruceTrabajadoresDiasDataGridView.Columns[i].Visible = true;



                    //Se calcula la fecha del dia (i+1)
                    DateTime dateValue = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, (i + 1));


                    this.horasTrabajadasDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                    this.cruceTrabajadoresDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                    if ((this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes < 35)
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = 35;
                        this.cruceTrabajadoresDiasDataGridView.Columns[i].Width = 35;
                    }
                    else
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = (this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes;
                        this.cruceTrabajadoresDiasDataGridView.Columns[i].Width = (this.cruceTrabajadoresDiasDataGridView.Width - 40) / NumDiasMes;
                    }
                }
                else
                {
                    horasTrabajadasDiasDataGridView.Columns[i].Visible = false;
                    cruceTrabajadoresDiasDataGridView.Columns[i].Visible = false;
                }
            }
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form ResultadosCruce = new Form();
            ResultadoCruce frm = new ResultadoCruce();
            frm.ShowDialog();

            //MessageBox.Show(Convert.ToString(IdTrabCruceActual) + " " + Convert.ToString(IdTrabajadorActual) + " " + Convert.ToString(nDiaActual));
        }


        // ///////////////////////////////////////////////////////////////////////////////
        //  CUANDO SE CAMBIA DE TRABAJADOR //////////////////
        // ///////////////////////////////////////

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedValue)!=0)
            {
                this.horasTrabajadasDiasTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.HorasTrabajadasDias,VariablesGlobales.nMesActual,VariablesGlobales.nAnoActual, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(comboBox1.SelectedValue));
                this.cruceTrabajadoresDiasTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.CruceTrabajadoresDias, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual,VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(comboBox1.SelectedValue));
                byte nMesEmpresa = Convert.ToByte(promowork_dataDataSet.Tables["HorasTrabajadasDias"].Rows[0]["MesEmpresa"]);
                int nAnoEmpresa = Convert.ToInt32(promowork_dataDataSet.Tables["HorasTrabajadasDias"].Rows[0]["AnoEmpresa"]);
                salarioTrabajadorActualTableAdapter.Fill(promowork_dataDataSet.SalarioTrabajadorActual, VariablesGlobales.nIdEmpresaActual, nMesEmpresa, nAnoEmpresa, Convert.ToInt32(comboBox1.SelectedValue));

                horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                horasTrabajadasDiasDataGridView.ReadOnly = true;
                cruceTrabajadoresDiasDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                cruceTrabajadoresDiasDataGridView.ReadOnly = true;
            }
          //  PropertyDescriptorCollection pdc = cruceTrabajadoresDiasBindingSource.CurrencyManager.GetItemProperties();

            //MessageBox.Show(Convert.ToString( pdc["IdTrabajador"]));
          //  int npos= cruceTrabajadoresDiasBindingSource.Find("IdTrabajador", 10);
            
           // cruceTrabajadoresDiasBindingSource.Position = npos;           
        }
        // //////////////////////////////////////////////////////
        //CUANDO SE CAMBIA EL VALOR DE LAS HORAS TRABAJADAS
        // //////////////////////////////////////////////////
        private void horasTrabajadasDiasDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            //MessageBox.Show("asddad");
            decimal nCantHoras = 0;
            if (!Convert.IsDBNull(horasTrabajadasDiasDataGridView.CurrentCell.Value))
            {
                nCantHoras = Convert.ToDecimal(horasTrabajadasDiasDataGridView.CurrentCell.Value);;
            }
            DataRowView Obra = (DataRowView)horasTrabajadasDiasBindingSource.Current;


                int nIdObra = Convert.ToInt32(Obra["IdObra"]);
                int nITrabajador = Convert.ToInt32(comboBox1.SelectedValue);
                byte nMesEmpresa = Convert.ToByte(Obra["MesEmpresa"]);
                int nAnoEmpresa = Convert.ToInt32(Obra["AnoEmpresa"]);

                //Actualizo las Horas Trabajadas y crea el cruce con él mismo
                queriesTableAdapter1.ActualizaHorasTrabajadas(nIdObra, nITrabajador, VariablesGlobales.nIdUsuarioActual, (horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1), nMesEmpresa, nAnoEmpresa, nCantHoras);

                //Cargo el cuce con él mismo
                this.cruceTrabajadoresDiasTableAdapter.FillByEmpresaTrabajador(promowork_dataDataSet.CruceTrabajadoresDias, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(comboBox1.SelectedValue));
                salarioTrabajadorActualTableAdapter.Fill(promowork_dataDataSet.SalarioTrabajadorActual, VariablesGlobales.nIdEmpresaActual, nMesEmpresa, nAnoEmpresa, Convert.ToInt32(comboBox1.SelectedValue));
            
        }


        // /////////////////////////////////////////////////////////////////////////////////
      
        private void cruceTrabajadoresDiasDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
                int IdTrabajadorActual = Convert.ToInt32(comboBox1.SelectedValue);
                int IdTrabCruceActual ;
                try { IdTrabCruceActual = Convert.ToByte(promowork_dataDataSet.Tables["CruceTrabajadoresDias"].Rows[cruceTrabajadoresDiasDataGridView.CurrentRow.Index]["IdTrabajador"]); }
                catch { IdTrabCruceActual = 0; };
               byte nDiaActual = Convert.ToByte(cruceTrabajadoresDiasDataGridView.CurrentCell.ColumnIndex + 1);
                bool? Acepta = false;

                if (Convert.IsDBNull(cruceTrabajadoresDiasDataGridView.CurrentCell.Value) || Convert.ToBoolean(cruceTrabajadoresDiasDataGridView.CurrentCell.Value) == false)
                {

                    queriesTableAdapter1.ActualizaCrucesTrabajadores(false, IdTrabajadorActual, IdTrabCruceActual, (cruceTrabajadoresDiasDataGridView.CurrentCell.ColumnIndex + 1), VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, VariablesGlobales.nIdUsuarioActual, ref Acepta);

                }
                else
                {

                    // MessageBox.Show(Convert.ToString(IdTrabCruceActual) + " " + Convert.ToString(IdTrabajadorActual) + " " + Convert.ToString(nDiaActual));
                    queriesTableAdapter1.ActualizaCrucesTrabajadores(true, IdTrabajadorActual, IdTrabCruceActual, nDiaActual, VariablesGlobales.nMesActual, VariablesGlobales.nAnoActual, VariablesGlobales.nIdUsuarioActual, ref Acepta);

                    if (Acepta == false)
                    {
                        cruceTrabajadoresDiasDataGridView.CurrentCell.Value = false;
                    }

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///// OBLIGO A REPINTAR EL DATAGRID PARA QUE ACTUALICE EL ESTILO DE LAS CELDAS AN CAMBIAR DE OBRA /////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void horasTrabajadasDiasDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

           
            cruceTrabajadoresDiasDataGridView.Invalidate();

        }

   
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //// MUESTRO LA INFORMACION DEL DIA DE TRABAJO Y LA POSIBILIDA DE CAMBIARLA  ///////////////
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void horasTrabajadasDiasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (horasTrabajadasDiasDataGridView.ReadOnly == false)
            {
                if (horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex < 15)
                {
                    groupBox1.Left = horasTrabajadasDiasDataGridView.Left + horasTrabajadasDiasDataGridView.CurrentCell.Size.Width * (horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 2);
                }
                else
                {
                    groupBox1.Left = horasTrabajadasDiasDataGridView.Left + horasTrabajadasDiasDataGridView.CurrentCell.Size.Width * (horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex - horasTrabajadasDiasDataGridView.FirstDisplayedScrollingColumnIndex) - groupBox1.Width;
                }

                groupBox1.Top = horasTrabajadasDiasDataGridView.Top + 20;
                label1.Text = "Trabajador: " + Convert.ToString(promowork_dataDataSet.Tables["TrabajadoresLista"].Rows[comboBox1.SelectedIndex]["NomTrabajador"]);
                label2.Text = "Obra: " + Convert.ToString(dataGridView1.CurrentRow.Cells["Obra"].Value);
                label3.Text = "Día: " + Convert.ToString(horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1);

                DataRowView ObraActual = (DataRowView)horasTrabajadasDiasBindingSource.Current;
                string sIdObra = Convert.ToString(ObraActual["IdObra"]);
                string sMesEmpresa = Convert.ToString(ObraActual["MesEmpresa"]);
                string sAnoEmpresa = Convert.ToString(ObraActual["AnoEmpresa"]);
                string sDia = Convert.ToString(horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1);
                horasTrabajadasTableAdapter.Fill(promowork_dataDataSet.HorasTrabajadas);
                string filtro = "IdTrabajador= " + Convert.ToString(comboBox1.SelectedValue) + " and IdObra=" + sIdObra + " and DiaTrab=" + sDia + " and MesTrab=" + sMesEmpresa + " and AnoTrab=" + sAnoEmpresa;
                // MessageBox.Show(filtro);
                DataRow[] FilaSel = promowork_dataDataSet.Tables["HorasTrabajadas"].Select(filtro);
                if (FilaSel.Count() != 0)
                {
                    // MessageBox.Show(Convert.ToString(FilaSel[0]["Salario"]));
                    cantidadTextBox.Text = Convert.ToString(FilaSel[0]["Cantidad"]);
                    idTipoComboBox.SelectedValue = Convert.ToInt32(FilaSel[0]["IdTipo"]);
                    salNormalTextBox.Text = Convert.ToString(FilaSel[0]["Salario"]);

                    festivoCheckBox.Checked = Convert.ToBoolean(FilaSel[0]["Festivo"]);
                    if (Convert.IsDBNull(FilaSel[0]["SalarioVenta"]))
                    {
                        textBox2.Text = "0,00";
                    }
                    else
                    {
                        textBox2.Text = Convert.ToString(FilaSel[0]["SalarioVenta"]);
                    }

                }
                else
                {
                    string filtroSalVenta = "IdCategoria=" + Convert.ToString(promowork_dataDataSet.Tables["TrabajadoresLista"].Rows[comboBox1.SelectedIndex]["IdCategoria"]) + " and IdTipo=" + Convert.ToString(dataGridView1.CurrentRow.Cells["IdTipo"].Value);
                    DataRow[] SalVenta = promowork_dataDataSet.Tables["SalariosVenta"].Select(filtroSalVenta);

                    cantidadTextBox.Text = Convert.ToString(horasTrabajadasDiasDataGridView.CurrentCell.Value);
                    idTipoComboBox.SelectedValue = dataGridView1.CurrentRow.Cells["IdTipo"].Value;
                    if (SalVenta.Count() == 0)
                    {
                        textBox2.Text = "0,00";
                    }
                    else
                    {
                        textBox2.Text = Convert.ToString(SalVenta[0]["SalVenta"]);
                    }


                    if (horasTrabajadasDiasDataGridView.CurrentCell.Style.BackColor == Color.AntiqueWhite)
                    {
                        festivoCheckBox.Checked = true;
                    }
                    else
                    {
                        festivoCheckBox.Checked = false;
                    }

                    if (!Convert.IsDBNull(dataGridView1.CurrentRow.Cells["IdTipo"].Value))
                    {
                        salariosTiposTableAdapter.FillByTrabajadorTipo(promowork_dataDataSet.SalariosTipos, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTipo"].Value));
                        if (promowork_dataDataSet.SalariosTipos.Count > 0)
                        {
                            if (festivoCheckBox.Checked == false)
                            {
                                salNormalTextBox.Text = Convert.ToString(promowork_dataDataSet.Tables["SalariosTipos"].Rows[0]["SalNormal"]);

                            }
                            else
                            {
                                salNormalTextBox.Text = Convert.ToString(promowork_dataDataSet.Tables["SalariosTipos"].Rows[0]["SalExtra"]);
                            }
                        }
                    }
                }

                groupBox1.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void festivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DataRow[] salActual = promowork_dataDataSet.SalariosTipos.Select("IdTrabajador=" + Convert.ToString(comboBox1.SelectedValue) + " and IdTipo=" + Convert.ToString(idTipoComboBox.SelectedValue));

            string SalNormal = "0,00";
            string SalFest = "0,00";

            try
            {
                SalNormal = Convert.ToString(salActual[0]["SalNormal"]);
            }
            catch { }
            try
            {
                SalFest = Convert.ToString(salActual[0]["SalExtra"]);
            }
            catch { }


            if (festivoCheckBox.Checked == false)
            {
                salNormalTextBox.Text = SalNormal;
            }
            else
            {
                salNormalTextBox.Text = SalFest;
            }
        }

        //SE SALVA LA INFORMACION MODIFICADA /////
        // //////////////////////////////////////////////////////////
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               decimal Cantidad;
                decimal Salario;
                decimal SalarioVenta;
                try {Cantidad=Convert.ToDecimal(cantidadTextBox.Text);}
                catch {Cantidad=0;}
                try {Salario=Convert.ToDecimal(salNormalTextBox.Text);}
                catch {Salario=0;}
                try {SalarioVenta=Convert.ToDecimal(textBox2.Text);}
                catch {SalarioVenta=0;}
                    
                    int nIdObra = Convert.ToInt32(promowork_dataDataSet.Tables["HorasTrabajadasDias"].Rows[horasTrabajadasDiasDataGridView.CurrentCell.RowIndex]["IdObra"]);
                    int nITrabajador = Convert.ToInt32(comboBox1.SelectedValue);
                    byte nMesEmpresa = Convert.ToByte(promowork_dataDataSet.Tables["HorasTrabajadasDias"].Rows[0]["MesEmpresa"]);
                    int nAnoEmpresa = Convert.ToInt32(promowork_dataDataSet.Tables["HorasTrabajadasDias"].Rows[0]["AnoEmpresa"]);

                    queriesTableAdapter1.CambiaActualizaHorasTrabajadas(nIdObra, nITrabajador, VariablesGlobales.nIdUsuarioActual, (horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1), nMesEmpresa, nAnoEmpresa, Cantidad, Convert.ToInt32(idTipoComboBox.SelectedValue), Convert.ToBoolean(festivoCheckBox.CheckState), Salario, SalarioVenta);
                    horasTrabajadasDiasDataGridView.CurrentCell.Value = Cantidad;
                    salarioTrabajadorActualTableAdapter.Fill(promowork_dataDataSet.SalarioTrabajadorActual, VariablesGlobales.nIdEmpresaActual, nMesEmpresa, nAnoEmpresa, Convert.ToInt32(comboBox1.SelectedValue));
                
                groupBox1.Visible = false;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", "Error");
            }
            catch (SqlException ex)
            {
                SqlError err = ex.Errors[0];
                string mensaje = string.Empty;
                switch (err.Number)
                {
                    case 547:
                        mensaje = "Es Obligatirio Definir un tipo de Pago Válido."; break;
                    default:
                        mensaje = Convert.ToString(err.Number) + "   " + err.ToString(); break;
                }
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // ////////////////////////////////////////////////////////////
        //PARA QUE SE MUEVAN JUNTAS LOS DATAGRIDVIEW/////////////////////
        // ////////////////////////////////////////////////
        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {

            cruceTrabajadoresDiasDataGridView.FirstDisplayedScrollingRowIndex = dataGridView2.FirstDisplayedScrollingRowIndex;

        }

        private void cruceTrabajadoresDiasDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView2.FirstDisplayedScrollingRowIndex = cruceTrabajadoresDiasDataGridView.FirstDisplayedScrollingRowIndex;
            horasTrabajadasDiasDataGridView.FirstDisplayedScrollingColumnIndex = cruceTrabajadoresDiasDataGridView.FirstDisplayedScrollingColumnIndex;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            horasTrabajadasDiasDataGridView.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
        }

        private void horasTrabajadasDiasDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = horasTrabajadasDiasDataGridView.FirstDisplayedScrollingRowIndex;
            cruceTrabajadoresDiasDataGridView.FirstDisplayedScrollingColumnIndex = horasTrabajadasDiasDataGridView.FirstDisplayedScrollingColumnIndex;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            RptSalarioObras frm = new RptSalarioObras();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RptSalarioObras frm = new RptSalarioObras();
            frm.ShowDialog();
        }


        // ESTABLEZCO EL ESTILO A LAS CELDAS DE LAS HORAS TRABAJADAS
        private void horasTrabajadasDiasDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (horasTrabajadasDiasDataGridView.ReadOnly == false) //Solo aplica el formato si es editable el datagrid
            {
              
                int nIdObra = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdObra"].Value);


                //Se calcula la fecha del dia (i+1)
                DateTime dateValue = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, (e.ColumnIndex + 1));


                if (dateValue >= Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["FechaIniObra"].Value) && dateValue <= Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["FechaFinObra"].Value))
                {

                    this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;

                    string Filtro = "IdObra= " + Convert.ToString(nIdObra) + " and DiaFestivo= " + Convert.ToString(e.ColumnIndex + 1) + " and MesFestivo= " + Convert.ToString(VariablesGlobales.nMesActual) + " and AnoFestivo= " + Convert.ToString(VariablesGlobales.nAnoActual);
                    DataRow[] Festivos = promowork_dataDataSet.Tables["FestivosObras"].Select(Filtro);
                   // MessageBox.Show(Filtro);
                  //  this.festivosObrasTableAdapter.FillByObra(this.promowork_dataDataSet.FestivosObras, nIdObra, nAnoActual, nMesActual, Convert.ToByte(e.ColumnIndex + 1));
                    // if (promowork_dataDataSet.FestivosObras.Count == 0)
                    if (Festivos.Count() == 0)
                    {
                        this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    }
                    else
                    {
                        this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.AntiqueWhite;
                    }


                     
                }
                else
                {
                    this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGray;
                }
            }
        }

        //  ESTABLEZCO EL FORMATO A LAS CELDAS DEL CRUCE
        private void cruceTrabajadoresDiasDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (cruceTrabajadoresDiasDataGridView.ReadOnly == false) //Solo aplica el formato si es editable el datagrid
            {
                if (Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["IdTrabajador"].Value) == Convert.ToInt32(comboBox1.SelectedValue))
                {
                    this.cruceTrabajadoresDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    e.CellStyle.BackColor = Color.LightGray;
                    // this.cruceTrabajadoresDiasDataGridView.Rows[j].Cells[i].InheritedStyle.BackColor = Color.LightGray;

                }
                else
                {

                    e.CellStyle.BackColor = horasTrabajadasDiasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.BackColor;
                    this.cruceTrabajadoresDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = horasTrabajadasDiasDataGridView.Rows[horasTrabajadasDiasDataGridView.CurrentRow.Index].Cells[e.ColumnIndex].ReadOnly;
                }
            }
        }

        private void horasTrabajadasDiasDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Solo se permiten caracteres Numéricos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           RptSalarioTrabajadores frm = new RptSalarioTrabajadores();
           frm.MdiParent = this.MdiParent;
           frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ResultadoCruce frm = new ResultadoCruce();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RptSalarioObras frm = new RptSalarioObras();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RptSinSalario frm = new RptSinSalario();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            horasTrabajadasDiasDataGridView.Focus();
        }

        
      /*  private void salarioTrabajadorActualDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            object SalarioTotal = promowork_dataDataSet.SalarioTrabajadorActual.Compute("Sum(Importe)", "1=1");
            textBox1.Text = Convert.ToString(SalarioTotal);  //Convert.ToString(Math.Round(Convert.ToDecimal(SalarioTotal)));
        }

        private void salarioTrabajadorActualDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            object SalarioTotal = promowork_dataDataSet.SalarioTrabajadorActual.Compute("Sum(Importe)", "1=1");
            textBox1.Text = Convert.ToString(SalarioTotal);
        }
        */
        private void salarioTrabajadorActualDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            object SalarioTotal = promowork_dataDataSet.SalarioTrabajadorActual.Compute("Sum(Importe)", "1=1");
            if (!Convert.IsDBNull(SalarioTotal))
            {
                textBox1.Text = Convert.ToString(Math.Round(Convert.ToDecimal(SalarioTotal), 2));
            }
            else
            {
                textBox1.Text = "";
            }
        
        }

        private void horasTrabajadasDiasDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.IsDBNull(dataGridView1.CurrentRow.Cells["IdTipo"].Value))
            {
                MessageBox.Show("La Obra no tiene definido el tipo de Pago. Debe definirlo antes de introducir las Horas Trabajadas.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            RptResumenObrasSalarioVentaDias frm = new RptResumenObrasSalarioVentaDias();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            DataRowView CopiaHoras = (DataRowView)copiasHorasBindingSource.Current;
            if (openFileDialog1.FileName.Trim().Length != 0)
            {
                try
                {
                    CopiaHoras["CopiaHoras"] = openFileDialog1.FileName;
                }
               catch (NullReferenceException)
                {
                  
                    DataRow NuevaCopia = promowork_dataDataSet.Tables["CopiasHoras"].NewRow();

                
                    NuevaCopia["IdTrabajador"] = comboBox1.SelectedValue;
                    NuevaCopia["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
                    NuevaCopia["MesCopia"] = VariablesGlobales.nMesActual;
                    NuevaCopia["AnoCopia"] = VariablesGlobales.nAnoActual;
                    NuevaCopia["CopiaHoras"] = openFileDialog1.FileName;

                    promowork_dataDataSet.Tables["CopiasHoras"].Rows.Add(NuevaCopia);
                }
                finally
                {
                DataRowView CopiaHoras1 = (DataRowView)copiasHorasBindingSource.Current;
                CopiaHoras1["CopiaHoras"] = openFileDialog1.FileName;
                copiaHorasTextBox.Text = openFileDialog1.FileName;
                this.Validate();
                copiasHorasBindingSource.EndEdit();
                copiasHorasTableAdapter.Update(promowork_dataDataSet.CopiasHoras);
                }
            }
   

      }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRowView CopiaHoras = (DataRowView)copiasHorasBindingSource.Current;
            try
            {
                System.Diagnostics.Process.Start(Convert.ToString(CopiaHoras["CopiaHoras"]));
            }
            catch
            {
                MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataRowView CopiaHoras = (DataRowView)copiasHorasBindingSource.Current;
            CopiaHoras["CopiaHoras"] = null;
            copiaHorasTextBox.Text = null;
            this.Validate();
            copiasHorasBindingSource.EndEdit();
            copiasHorasTableAdapter.Update(promowork_dataDataSet.CopiasHoras);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.LightGray;
            horasTrabajadasDiasDataGridView.ReadOnly = false;
          //  cruceTrabajadoresDiasDataGridView.DefaultCellStyle.BackColor = Color.LightGray;
            cruceTrabajadoresDiasDataGridView.ReadOnly = false;
            horasTrabajadasDiasDataGridView.Invalidate();
            cruceTrabajadoresDiasDataGridView.Invalidate();
            horasTrabajadasDiasDataGridView.Focus();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.festivosObrasTableAdapter.FillByObra(this.promowork_dataDataSet.FestivosObras,VariablesGlobales.nAnoActual,VariablesGlobales.nMesActual);
            //festivosObrasDiasTableAdapter.FillByObra(promowork_dataDataSet.FestivosObrasDias,Convert.ToInt32(horasTrabajadasDiasDataGridView.CurrentRow.Cells["IdObra"]));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            horasTrabajadasDiasBindingSource.Filter = null;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            textBox4.Text = "";
            try
           {
               horasTrabajadasDiasBindingSource.Filter = "DesObra like '%" + textBox3.Text + "%'";
           }
            catch
           {}

        }

        private void idTipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SalNormal = "0,00";
            string SalFest = "0,00";

            try
            {
            DataRow[] salActual = promowork_dataDataSet.SalariosTipos.Select("IdTrabajador=" + Convert.ToString(comboBox1.SelectedValue) + " and IdTipo=" + Convert.ToString(idTipoComboBox.SelectedValue));

                SalNormal = Convert.ToString(salActual[0]["SalNormal"]);
           
                SalFest = Convert.ToString(salActual[0]["SalExtra"]);
            }
            catch { }


            if (festivoCheckBox.Checked == false)
            {
                salNormalTextBox.Text = SalNormal;
            }
            else
            {
                salNormalTextBox.Text = SalFest;
            }
        }

       

        private void salariosTiposDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            this.Validate();
            this.fKSalariosTiposTrabajadoresBindingSource.EndEdit();
            salariosTiposTableAdapter.Update(promowork_dataDataSet.SalariosTipos);
             }

                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.salariosTiposTableAdapter.Fill(this.promowork_dataDataSet.SalariosTipos);
                }
               
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.salariosTiposTableAdapter.Fill(this.promowork_dataDataSet.SalariosTipos);
                    }
                }
        }

        private void HorasCruces_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                
              //  promowork_dataDataSet.Clear();
              //  promowork_dataDataSet1.Clear();
               // promowork_dataDataSet2.Clear();
                //MessageBox.Show("aaaaaaaa");
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            textBox3.Text = "";
            try
            {
                if (textBox4.Text == "")
                {
                    horasTrabajadasDiasBindingSource.Filter = null;
                }
                else
                {
                    horasTrabajadasDiasBindingSource.Filter = "NumObra in (" + textBox4.Text+")";
                }
            }
            catch { }
        }

       
    }
}

