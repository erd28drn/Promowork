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
    public partial class HorasAdmin : Form
    {
       // Boolean TerminaCargaHorasTrabajadas = false;
        public HorasAdmin()
        {
            InitializeComponent();
            
            
        }

        Byte nMesActual = Convert.ToByte(VariablesGlobales.nMesActual);
        int nAnoActual = Convert.ToInt32(VariablesGlobales.nAnoActual);

       
        // //////////////////////////////////////////////////////
        //CUANDO SE CAMBIA EL VALOR DE LAS HORAS TRABAJADAS
        // //////////////////////////////////////////////////
        private void horasTrabajadasDiasDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
           // MessageBox.Show("asddad");
            decimal nCantHoras = 0;
            if (!Convert.IsDBNull(horasTrabajadasDiasDataGridView.CurrentCell.Value))
            {
            nCantHoras =  Convert.ToDecimal(horasTrabajadasDiasDataGridView.CurrentCell.Value) ;
            }
                int nIdObra = Convert.ToInt32(comboBox1.SelectedValue);
                int nIdTrabajador = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTrabajador"].Value);
                byte nMesEmpresa = Convert.ToByte(nMesActual);
                int nAnoEmpresa = Convert.ToInt32(nAnoActual);
                

                //Actualizo las Horas Trabajadas y crea el cruce con él mismo
                queriesTableAdapter1.ActualizaHorasAdmin(nIdObra, nIdTrabajador, VariablesGlobales.nIdUsuarioActual, (horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1), nMesEmpresa, nAnoEmpresa, nCantHoras, obsHorasAdminTextBox.Text, Convert.ToInt32(nomPresupComboBox.SelectedValue));

                if (Convert.ToInt32(nomPresupComboBox.SelectedValue)==0)
                    {
                        this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
                    }
                totalHorasAdminTableAdapter.FillbyObra(promowork_dataDataSet.TotalHorasAdmin, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);

        }


        // /////////////////////////////////////////////////////////////////////////////////
      
      
       
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
                label1.Text = "Trabajador: " + Convert.ToString(promowork_dataDataSet.Tables["HorasAdminDias"].Rows[e.RowIndex]["Trabajador"]);
                label2.Text = "Obra: " + comboBox1.Text;
                label3.Text = "Día: " + Convert.ToString(horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1);

                DataRowView ObraActual = (DataRowView)horasAdminDiasBindingSource.Current;
                string sIdObra = Convert.ToString(comboBox1.SelectedValue);
                string sMesEmpresa = Convert.ToString(ObraActual["MesEmpresa"]);
                string sAnoEmpresa = Convert.ToString(ObraActual["AnoEmpresa"]);
                string sDia = Convert.ToString(horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1);
                horasAdminTableAdapter.FillByObra(promowork_dataDataSet.HorasAdmin, Convert.ToInt32(comboBox1.SelectedValue));
                string filtro = "IdTrabajador= " + Convert.ToString(promowork_dataDataSet.Tables["HorasAdminDias"].Rows[e.RowIndex]["IdTrabajador"]) + " and IdObra=" + sIdObra + " and DiaTrab=" + sDia + " and MesTrab=" + sMesEmpresa + " and AnoTrab=" + sAnoEmpresa;
                // MessageBox.Show(filtro);
                DataRow[] FilaSel = promowork_dataDataSet.Tables["HorasAdmin"].Select(filtro);
                if (FilaSel.Count() != 0)
                {
                    // MessageBox.Show(Convert.ToString(FilaSel[0]["Salario"]));
                    cantidadTextBox.Text = Convert.ToString(FilaSel[0]["Cantidad"]);
                    idTipoComboBox.SelectedValue = Convert.ToInt32(FilaSel[0]["IdTipo"]);
                    // textBox2.Text = Convert.ToString(FilaSel[0]["SalarioVenta"]);

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
                    string filtroSalVenta = "IdCategoria=" + Convert.ToString(promowork_dataDataSet.Tables["HorasAdminDias"].Rows[e.RowIndex]["IdCategoria"]) + " and IdTipo=" + Convert.ToString(promowork_dataDataSet.Tables["Obras"].Rows[comboBox1.SelectedIndex]["IdTipo"]) + " and IdObra=" + Convert.ToString(comboBox1.SelectedValue);
                    DataRow[] SalVenta = promowork_dataDataSet.Tables["SalariosVenta"].Select(filtroSalVenta);

                    cantidadTextBox.Text = Convert.ToString(horasTrabajadasDiasDataGridView.CurrentCell.Value);
                    idTipoComboBox.SelectedValue = promowork_dataDataSet.Tables["Obras"].Rows[comboBox1.SelectedIndex]["IdTipo"];
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


                }

                groupBox1.Visible = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

       
        //SE SALVA LA INFORMACION MODIFICADA /////
        // //////////////////////////////////////////////////////////
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               decimal Cantidad;
                decimal SalarioVenta;
                try {Cantidad=Convert.ToDecimal(cantidadTextBox.Text);}
                catch {Cantidad=0;}
                try {SalarioVenta=Convert.ToDecimal(textBox2.Text);}
                catch {SalarioVenta=0;}

                int nIdObra = Convert.ToInt32(comboBox1.SelectedValue);
                int nIdTrabajador = Convert.ToInt32(promowork_dataDataSet.Tables["HorasAdminDias"].Rows[horasTrabajadasDiasDataGridView.CurrentCell.RowIndex]["IdTrabajador"]);
                    byte nMesEmpresa = Convert.ToByte(promowork_dataDataSet.Tables["HorasAdminDias"].Rows[0]["MesEmpresa"]);
                    int nAnoEmpresa = Convert.ToInt32(promowork_dataDataSet.Tables["HorasAdminDias"].Rows[0]["AnoEmpresa"]);

                    queriesTableAdapter1.CambiaActualizaHorasAdmin(nIdObra, nIdTrabajador, VariablesGlobales.nIdUsuarioActual, (horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1), nMesEmpresa, nAnoEmpresa, Cantidad, obsHorasAdminTextBox.Text, Convert.ToInt32(nomPresupComboBox.SelectedValue),SalarioVenta);
                    horasTrabajadasDiasDataGridView.CurrentCell.Value = Cantidad;
                
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
      
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            horasTrabajadasDiasDataGridView.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
        }

        private void horasTrabajadasDiasDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = horasTrabajadasDiasDataGridView.FirstDisplayedScrollingRowIndex;
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
                int nIdObra = Convert.ToInt32(comboBox1.SelectedValue);
            
/*

                    //Se calcula la fecha del dia (i+1)
                    DateTime dateValue = new DateTime(nAnoActual, nMesActual, (e.ColumnIndex + 1));


                    if (dateValue >= Convert.ToDateTime(fechaIniObraTextBox.Text) && dateValue <= Convert.ToDateTime(fechaFinObraTextBox.Text))
                    {

                     */   
                        this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;

                        string Filtro = "IdObra= " + Convert.ToString(nIdObra) + " and DiaFestivo= " + Convert.ToString(e.ColumnIndex + 1) + " and MesFestivo= " + Convert.ToString(nMesActual) + " and AnoFestivo= " + Convert.ToString(nAnoActual);
                        
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

                /*

                    }
                    else
                    {
                        this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                        this.horasTrabajadasDiasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGray;
                    }
                
                */
            }
        }

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            horasTrabajadasDiasDataGridView.Focus();
        }

        
     
        private void horasTrabajadasDiasDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

          
            this.horasAdminTableAdapter.FillByObs(this.promowork_dataDataSet.HorasAdmin, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTrabajador"].Value), Convert.ToByte(horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex + 1), nMesActual, nAnoActual);
           
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            DataRowView CopiaParte = (DataRowView)horasAdminBindingSource.Current;
            if (openFileDialog1.FileName.Trim().Length != 0)
            {
                copiaHorasTextBox.Text = openFileDialog1.FileName;
                this.Validate();
                horasAdminBindingSource.EndEdit();
                horasAdminTableAdapter.Update(promowork_dataDataSet.HorasAdmin);
              
            }
   

      }

        private void button4_Click(object sender, EventArgs e)
        {
           
            try
            {
                System.Diagnostics.Process.Start(copiaHorasTextBox.Text);
            }
            catch
            {
                MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            copiaHorasTextBox.Text = null;
            this.Validate();
            horasAdminBindingSource.EndEdit();
            horasAdminTableAdapter.Update(promowork_dataDataSet.HorasAdmin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.LightGray;
            horasTrabajadasDiasDataGridView.ReadOnly = false;
            obsHorasAdminTextBox.ReadOnly = false;
          //  cruceTrabajadoresDiasDataGridView.DefaultCellStyle.BackColor = Color.LightGray;
            horasTrabajadasDiasDataGridView.Invalidate();
            horasTrabajadasDiasDataGridView.Focus();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.festivosObrasTableAdapter.FillByObra(this.promowork_dataDataSet.FestivosObras,nAnoActual,nMesActual);
            //festivosObrasDiasTableAdapter.FillByObra(promowork_dataDataSet.FestivosObrasDias,Convert.ToInt32(horasTrabajadasDiasDataGridView.CurrentRow.Cells["IdObra"]));
        }

        private void obsHorasAdminTextBox_Leave(object sender, EventArgs e)
        {
            this.Validate();
            horasAdminBindingSource.EndEdit();
            horasAdminTableAdapter.Update(promowork_dataDataSet.HorasAdmin);
        }

        private void horasTrabajadasDiasDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Solo se permiten caracteres Numéricos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void HorasAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            horasAdminBindingSource.EndEdit();
            horasAdminTableAdapter.Update(promowork_dataDataSet.HorasAdmin);
            
            try
            {
            salariosVentaBindingSource.EndEdit();
            salariosVentaTableAdapter.Update(promowork_dataDataSet.SalariosVenta);
             }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
                }
                
            }
        }

        private void salariosVentaDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           try
           {
            this.Validate();
            salariosVentaBindingSource.EndEdit();
            salariosVentaTableAdapter.Update(promowork_dataDataSet.SalariosVenta);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
                }
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Realmente desea Ejecutar esta opción? Se perderán todas los cambios hechos a las horas en la obra actual. Los detalles de los trabajos realizados no se eliminarán.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                int nIdObra = Convert.ToInt32(comboBox1.SelectedValue);

                queriesTableAdapter1.AgregaHorasAdminDesdeHorasTrab(nIdObra, VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(nomPresupComboBox.SelectedValue),nAnoActual,nMesActual);

                if (Convert.ToInt32(nomPresupComboBox.SelectedValue) == 0)
                {
                    this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
                }

                horasAdminDiasTableAdapter.FillByHorasTrabObra(promowork_dataDataSet.HorasAdminDias, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);
                totalHorasAdminTableAdapter.FillbyObra(promowork_dataDataSet.TotalHorasAdmin, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);

                horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke ;
                horasTrabajadasDiasDataGridView.ReadOnly = true;
                obsHorasAdminTextBox.ReadOnly = true;
            }

        }

        private void HorasAdmin_Resize(object sender, EventArgs e)
        {
            horasTrabajadasDiasDataGridView.Width = this.Width - dataGridView1.Width - 35;
        }

        private void HorasAdmin_Load(object sender, EventArgs e)
        {

            this.categoriasTableAdapter.Fill(this.promowork_dataDataSet.Categorias);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.SalariosVenta' table. You can move, or remove it, as needed.
            this.salariosVentaTableAdapter.Fill(this.promowork_dataDataSet.SalariosVenta);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'promowork_dataDataSet1.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByHorasTrab(this.promowork_dataDataSet.Obras, nMesActual, nAnoActual, VariablesGlobales.nIdEmpresaActual);
            ///  this.obrasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ObservAdmin' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'promowork_dataDataSet2.Categorias' table. You can move, or remove it, as needed.

            // MessageBox.Show("Load");
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'promowork_dataDataSet.HorasTrabajadas' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FestivosObras' table. You can move, or remove it, as needed.
            this.festivosObrasTableAdapter.Fill(this.promowork_dataDataSet.FestivosObras);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FestivosObras' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Empresas, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Tipos' table. You can move, or remove it, as needed.

            this.tiposTableAdapter.Fill(this.promowork_dataDataSet.Tipos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Categorias' table. You can move, or remove it, as needed.
            // comboBox1.DisplayMember = Convert.ToString(promowork_dataDataSet.Tables["Trabajdores"].Rows[comboBox1.SelectedIndex]["NomTRabajador"]);
            //---  this.horasAdminDiasTableAdapter.FillByHorasTrabObra(promowork_dataDataSet.HorasAdminDias,Convert.ToInt32(comboBox1.SelectedValue),nAnoActual,nMesActual);

            horasTrabajadasDiasDataGridView.Width = this.Width - dataGridView1.Width - 35;


            //Mes y año actual
           

            //this.horasAdminTableAdapter.FillByObs(this.promowork_dataDataSet.HorasAdmin,Convert.ToInt32(comboBox1.SelectedValue),Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTrabajador"].Value),Convert.ToByte(horasTrabajadasDiasDataGridView.CurrentCell.ColumnIndex+1),nMesActual,nAnoActual);

            //Determino cantidad de dias que tiene el mes actual
            int NumDiasMes = DateTime.DaysInMonth(nAnoActual, nMesActual);

            //Fecha del Primer dia del mes de tarbajo
            DateTime FechaPrimero = new DateTime(nAnoActual, nMesActual, NumDiasMes);
            //Fecha del Ultimo dia del mes de tarbajo
            DateTime FechaUltimo = new DateTime(nAnoActual, nMesActual, 1);


            for (int i = 0; i < horasTrabajadasDiasDataGridView.ColumnCount; i++)
            {

                if (i < NumDiasMes)
                {

                    horasTrabajadasDiasDataGridView.Columns[i].Visible = true;



                    //Se calcula la fecha del dia (i+1)
                    DateTime dateValue = new DateTime(nAnoActual, nMesActual, (i + 1));


                    this.horasTrabajadasDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                    if ((this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes < 35)
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = 35;
                    }
                    else
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = (this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes;
                    }
                }
                else
                {
                    horasTrabajadasDiasDataGridView.Columns[i].Visible = false;
                }
            }
        }

        private void anoTrabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            nAnoActual = Convert.ToInt32(anoTrabComboBox.SelectedValue) == 0 ? VariablesGlobales.nAnoActual : Convert.ToInt32(anoTrabComboBox.SelectedValue);
            horasAdminDiasTableAdapter.FillByHorasTrabObra(promowork_dataDataSet.HorasAdminDias, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);
            totalHorasAdminTableAdapter.FillbyObra(promowork_dataDataSet.TotalHorasAdmin, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);
            
            int NumDiasMes = DateTime.DaysInMonth(nAnoActual, nMesActual);

            //Fecha del Primer dia del mes de tarbajo
            DateTime FechaPrimero = new DateTime(nAnoActual, nMesActual, NumDiasMes);
            //Fecha del Ultimo dia del mes de tarbajo
            DateTime FechaUltimo = new DateTime(nAnoActual, nMesActual, 1);


            for (int i = 0; i < horasTrabajadasDiasDataGridView.ColumnCount; i++)
            {

                if (i < NumDiasMes)
                {

                    horasTrabajadasDiasDataGridView.Columns[i].Visible = true;



                    //Se calcula la fecha del dia (i+1)
                    DateTime dateValue = new DateTime(nAnoActual, nMesActual, (i + 1));


                    this.horasTrabajadasDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                    if ((this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes < 35)
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = 35;
                    }
                    else
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = (this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes;
                    }
                }
                else
                {
                    horasTrabajadasDiasDataGridView.Columns[i].Visible = false;
                }
            }

            horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            horasTrabajadasDiasDataGridView.ReadOnly = true;
            obsHorasAdminTextBox.ReadOnly = true;
        }

        private void nomMesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nMesActual = Convert.ToByte(nomMesComboBox.SelectedValue) == 0 ? VariablesGlobales.nMesActual : Convert.ToByte(nomMesComboBox.SelectedValue);
            horasAdminDiasTableAdapter.FillByHorasTrabObra(promowork_dataDataSet.HorasAdminDias, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);
            totalHorasAdminTableAdapter.FillbyObra(promowork_dataDataSet.TotalHorasAdmin, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);

            int NumDiasMes = DateTime.DaysInMonth(nAnoActual, nMesActual);

            //Fecha del Primer dia del mes de tarbajo
            DateTime FechaPrimero = new DateTime(nAnoActual, nMesActual, NumDiasMes);
            //Fecha del Ultimo dia del mes de tarbajo
            DateTime FechaUltimo = new DateTime(nAnoActual, nMesActual, 1);


            for (int i = 0; i < horasTrabajadasDiasDataGridView.ColumnCount; i++)
            {

                if (i < NumDiasMes)
                {

                    horasTrabajadasDiasDataGridView.Columns[i].Visible = true;



                    //Se calcula la fecha del dia (i+1)
                    DateTime dateValue = new DateTime(nAnoActual, nMesActual, (i + 1));


                    this.horasTrabajadasDiasDataGridView.Columns[i].HeaderText = dateValue.ToString("ddd", new CultureInfo("es-ES")).ToUpper().Substring(0, 2) + "\r\n" + (i + 1).ToString();
                    if ((this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes < 35)
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = 35;
                    }
                    else
                    {
                        this.horasTrabajadasDiasDataGridView.Columns[i].Width = (this.horasTrabajadasDiasDataGridView.Width - 40) / NumDiasMes;
                    }
                }
                else
                {
                    horasTrabajadasDiasDataGridView.Columns[i].Visible = false;
                }
            }

            horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            horasTrabajadasDiasDataGridView.ReadOnly = true;
            obsHorasAdminTextBox.ReadOnly = true;

        }

      
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
               //     DataRowView ObraActual = (DataRowView)obrasBindingSource.Current;
              //     fechaFinObraTextBox.Text = Convert.ToString(ObraActual["FechaIniObra"]);
               //     fechaIniObraTextBox.Text = Convert.ToString(ObraActual["FechaFinObra"]);
            }
            catch { }

            marcaAnoTableAdapter.FillByObra(promowork_dataDataSet.MarcaAno, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(comboBox1.SelectedValue));
            marcaMesTableAdapter.FillByObra(promowork_dataDataSet.MarcaMes, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(comboBox1.SelectedValue));
            anoTrabComboBox.SelectedValue = VariablesGlobales.nAnoActual;
            nomMesComboBox.SelectedValue = VariablesGlobales.nMesActual;
            nAnoActual = VariablesGlobales.nAnoActual;
            nMesActual = VariablesGlobales.nMesActual;
            horasAdminDiasTableAdapter.FillByHorasTrabObra(promowork_dataDataSet.HorasAdminDias, Convert.ToInt32(comboBox1.SelectedValue), VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);
            totalHorasAdminTableAdapter.FillbyObra(promowork_dataDataSet.TotalHorasAdmin, Convert.ToInt32(comboBox1.SelectedValue), VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual);

            horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            horasTrabajadasDiasDataGridView.ReadOnly = true;
            obsHorasAdminTextBox.ReadOnly = true;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(nAnoActual));
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea Eliminar Todas las Horas de Administración de la Obra actual en el Mes Actual?. Los detalles de los trabajos realizados no se eliminarán.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                int nIdObra = Convert.ToInt32(comboBox1.SelectedValue);

                queriesTableAdapter1.EliminaHorasAdmin(nIdObra,nMesActual,nAnoActual,Convert.ToInt32(nomPresupComboBox.SelectedValue));

              //  this.presupCabTableAdapter.Fill(this.promowork_dataDataSet.PresupCab);
               
                horasAdminDiasTableAdapter.FillByHorasTrabObra(promowork_dataDataSet.HorasAdminDias, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);
                totalHorasAdminTableAdapter.FillbyObra(promowork_dataDataSet.TotalHorasAdmin, Convert.ToInt32(comboBox1.SelectedValue), nAnoActual, nMesActual);

                horasTrabajadasDiasDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                horasTrabajadasDiasDataGridView.ReadOnly = true;
                obsHorasAdminTextBox.ReadOnly = true;
            }
        }

               
    }
}

