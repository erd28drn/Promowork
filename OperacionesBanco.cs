using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Promowork
{
    public partial class OperacionesBanco : Form
    {
        public OperacionesBanco()
        {
            InitializeComponent();
        }

        decimal credito = 0;
        private void OperacionesBanco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ConceptosBancos' table. You can move, or remove it, as needed.
            this.conceptosBancosTableAdapter.Fill(this.promowork_dataDataSet.ConceptosBancos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);

            this.WindowState = FormWindowState.Maximized;
            dateTimePicker2.Value = DateTime.Today.AddMonths(-1);

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Bancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);

            credito = tbCredito.Text == null ? 0 : decimal.Parse(tbCredito.Text);

            Actualiza();

            

        }

        private void Actualiza()
        {
            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vOperacionesBancoAgrupadasTableAdapter.FillbyCuenta(promowork_dataDataSet.vOperacionesBancoAgrupadas, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
            DataRowView opebanco = (DataRowView)vOperacionesBancoAgrupadasBindingSource.Current;
            //saldoAnteriorTextBox.Text = vOperacionesBancoAgrupadasBindingSource.Count != 0 ? (-(decimal)opebanco["SaldoAnterior"]).ToString() : "0,00";
            vOperacionesBancoAgrupadasBindingSource.MoveLast();
            DataRowView opebanco1 = (DataRowView)vOperacionesBancoAgrupadasBindingSource.Current;
            //txtsaldofinal.Text = vOperacionesBancoAgrupadasBindingSource.Count != 0 ? (-(decimal)opebanco1["SaldoAnterior"] + (decimal)opebanco1["Importe"]).ToString() : "0,00";

            if (vOperacionesBancoAgrupadasBindingSource.Count > 0)
            {
                try
                {
                    int idope = Convert.ToInt32((promowork_dataDataSet.vOperacionesBancoAgrupadas.Compute("max(IdOpeBanco)", "IdCuenta=" + bancoCuentaComboBox.SelectedValue.ToString())));
                    int pos = gridView1.LocateByDisplayText(0, IdOpebanco, idope.ToString());
                    vOperacionesBancoAgrupadasBindingSource.Position = pos;
                }
                catch { }
                try
                {
                    int idprev = (int)(promowork_dataDataSet.vPrevisiones.Compute("max(IdOpeBanco)", "IdCuenta=" + bancoCuentaComboBox.SelectedValue.ToString()));
                    int posprev = gridView2.LocateByDisplayText(0, IdOpeBanco1, idprev.ToString());
                    vPrevisionesBindingSource.Position = posprev;
                }
                catch { }

            }
            decimal saldoPrevisto = 0;
            
            if (vOperacionesBancoAgrupadasBindingSource.Count > 0)
            {
                try
                {
                    saldoPrevisto = (decimal)opebanco1["Saldo"];
                }
                catch { }
            }
            

            if (vPrevisionesBindingSource.Count > 0)
            {
                for (int i = 0; i < vPrevisionesBindingSource.Count; i++)
                {
                    saldoPrevisto += (decimal)promowork_dataDataSet.Tables["vPrevisiones"].Rows[i]["Importe"];
                    //    MessageBox.Show(saldoPrevisto.ToString());
                    promowork_dataDataSet.Tables["vPrevisiones"].Rows[i]["Saldo"]= saldoPrevisto;
                }
            }
        }
    
        private void bancoCuentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void OperacionesBanco_Resize(object sender, EventArgs e)
        {
            //operacionesBancoGridControl.Width = this.Width - 20;
            //vPrevisionesGridControl.Width = this.Width - 20;
            //vPrevisionesGridControl.Height = this.Height - operacionesBancoGridControl.Height - 180;
            //saldoAnteriorTextBox.Location = new Point(this.Width - 120,6);
            //txtsaldofinal.Location = new Point(this.Width - 120, 301);
            //groupBox1.Location = new Point(0, this.Height - 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  operacionesBancoTableAdapter.Insert(VariablesGlobales.nIdEmpresaActual, dateTimePicker1.Value, null, null, null, Convert.ToString(gridView2.GetFocusedRowCellValue("DesProveedor")) +" Factura: "+ Convert.ToString(gridView2.GetFocusedRowCellValue("Factura")), Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdCuenta")), Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Importe")), true);
          //  MessageBox.Show(Convert.ToString(gridView2.GetFocusedRowCellValue("IdOpeBanco")));

            DateTime FechaActual = DateTime.Now;
            if (Convert.ToString(comboBox1.SelectedValue).Trim()=="" )
            {
                MessageBox.Show("Debe definir la Forma de Pago.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              //  MessageBox.Show(Convert.ToString(comboBox1.SelectedValue));
                if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    MessageBox.Show("La fecha de la operación tiene que estar contenida en el rango mostrado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   

                        if (gridView2.RowCount > 0)
                        {
                            string factura = "";
                            string obsBanco = "";
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                                // MessageBox.Show(Convert.ToString(gridView2.GetRowCellValue(i, "marca")));
                                if (Convert.ToBoolean(gridView2.GetRowCellValue(i, "marca")) == true)
                                {
                                    factura = factura + ((factura != "" && gridView2.GetRowCellValue(i, "Factura").ToString() != "") ? ", " : "") + gridView2.GetRowCellValue(i, "Factura").ToString();// + " (" + Convert.ToString(gridView2.GetRowCellValue(i, "ObsBanco"))+")  ";
                                    obsBanco = obsBanco + ((obsBanco != "" && gridView2.GetRowCellValue(i, "ObsBanco").ToString()!="") ? ", " : "") + gridView2.GetRowCellValue(i, "ObsBanco").ToString();
                                }
                            }
                            
                            
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                               // MessageBox.Show(Convert.ToString(gridView2.GetRowCellValue(i, "marca")));
                                if (Convert.ToBoolean(gridView2.GetRowCellValue(i, "marca")) == true)
                                {
                                    if (Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdOpeBanco")))
                                    {
                                        decimal debe = 0;
                                        decimal haber = 0;

                                        decimal.TryParse(gridView2.GetRowCellValue(i, "Debe").ToString(), out debe);
                                        decimal.TryParse(gridView2.GetRowCellValue(i, "Haber").ToString(), out haber);

                                        operacionesBancoBindingSource.AddNew();
                                        DataRowView opebanco = (DataRowView)operacionesBancoBindingSource.Current;
                                        opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
                                        opebanco["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
                                        opebanco["Fecha"] = dateTimePicker1.Value;
                                        opebanco["DesOperacion"] = Convert.ToString(gridView2.GetRowCellValue(i, "DesProveedor")) + " Fra: " + factura;
                                        opebanco["IdCuenta"] = gridView2.GetRowCellValue(i, "IdCuenta");
                                        opebanco["TipoOpe"] = gridView2.GetRowCellValue(i, "Tipo");
                                        opebanco["IdCompra"] = gridView2.GetRowCellValue(i, "IdCompra");
                                        opebanco["IdCobro"] = gridView2.GetRowCellValue(i, "IdCobro");
                                        opebanco["IdFormaPago"] = Convert.ToInt32(comboBox1.SelectedValue);
                                        opebanco["Importe"] = -(haber-debe);
                                        opebanco["EnCuenta"] = true;
                                        opebanco["FechaOpe"] = FechaActual;
                                        opebanco["ObsBanco"] = obsBanco;
                                    }
                                    else
                                    {
                                      queriesTableAdapter1.UpdateOperacionesBancoEnCuenta(true, dateTimePicker1.Value, (int)gridView2.GetRowCellValue(i, "IdOpeBanco"));
                                    }

                                     this.Validate();
                                     operacionesBancoBindingSource.EndEdit();
                                     operacionesBancoTableAdapter.Update(promowork_dataDataSet.OperacionesBanco);
                               
                                    
                                    DataRowView opebanco2 = (DataRowView)operacionesBancoBindingSource.Current;
                                    // MessageBox.Show(Convert.ToString(opebanco2["IdOpeBanco"]));
                                    queriesTableAdapter1.ActualizaSaldoAnterior(Convert.ToInt32(opebanco2["IdOpeBanco"]));

                                    string obs = string.Empty;
                                    try
                                    {
                                        obs = gridView2.GetRowCellValue(i, "ObsBanco").ToString();
                                    }
                                    catch { }

                                    if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCompra")))
                                    {
                                       // pagosTableAdapter.Insert(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdFormaPago")), dateTimePicker1.Value, "BANCO", Convert.ToDecimal(gridView2.GetRowCellValue(i, "Importe")), "", Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCuenta")), dateTimePicker1.Value);
                                       
                                        queriesTableAdapter1.UpdateCompraPagada(true,obs,Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")));
                                    }

                                    if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCobro")))
                                    {
                                       
                                        queriesTableAdapter1.UpdateCobroBanco(true,obs,Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCobro")));
                                    }

                                    
                                }
 
                        }
                            Actualiza();
                            txtimportesel.Text = string.Empty;
                            vOperacionesBancoAgrupadasBindingSource.Find("IdOpeBanco", 131);
                    }

                }
            }
           
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int opebanco=0;
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("Fecha"));
            }
            catch { }
            try
            {
                opebanco=(int) gridView2.GetFocusedRowCellValue("IdOpeBanco");
            }
            catch{}
            button6.Enabled = opebanco != 0 ? true : false;

            if (opebanco != 0)
            {
                gridView2.Columns["Fecha"].OptionsColumn.ReadOnly = false;
                gridView2.Columns["Fecha"].OptionsColumn.AllowEdit = true;
                //gridView2.Columns["Debe"].OptionsColumn.ReadOnly = false;
                //gridView2.Columns["Haber"].OptionsColumn.ReadOnly = false;
                button6.Enabled =  true;
            }
            else
            {
                gridView2.Columns["Fecha"].OptionsColumn.ReadOnly = true;
                gridView2.Columns["Fecha"].OptionsColumn.AllowEdit = false;
                //gridView2.Columns["Debe"].OptionsColumn.ReadOnly = true;
                //gridView2.Columns["Haber"].OptionsColumn.ReadOnly = true;
                button6.Enabled = false;
            
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.ActualizaSaldoAnteriorFecha(dateTimePicker2.Value,(int)bancoCuentaComboBox.SelectedValue);
            Actualiza();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //MessageBox.Show(gridView1.GetFocusedRowCellValue("IdConbanco").ToString());
                //if (Convert.IsDBNull(gridView1.GetFocusedRowCellValue("IdConbanco")))
                //{
                    DataRowView opebanco = (DataRowView)vOperacionesBancoAgrupadasBindingSource.Current;
                    queriesTableAdapter1.EliminaOpeBanco((DateTime)opebanco["FechaOpe"], (int)bancoCuentaComboBox.SelectedValue);
                //}
                //else
                //{
                //    queriesTableAdapter1.UpdateOperacionesBancoEnCuenta(false, (int)gridView1.GetFocusedRowCellValue("IdOpebanco"));
                //}
                Actualiza();
            }
        }

       private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //MessageBox.Show(e.Value.ToString());

            if (e.Column.Name == "marca")
            {
           gridView2.SetFocusedRowCellValue("marca", e.Value);
            decimal TotalSel = 0;

           
              //  gridView2.CloseEditor();
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    // MessageBox.Show(Convert.ToString(gridView2.GetRowCellValue(i, "marca")));
                    if (Convert.ToBoolean(gridView2.GetRowCellValue(i, "marca")) == true)
                    {
                        decimal debe = 0;
                        decimal haber = 0;

                        decimal.TryParse(gridView2.GetRowCellValue(i, "Debe").ToString(), out debe);
                        decimal.TryParse(gridView2.GetRowCellValue(i, "Haber").ToString(), out haber);


                        TotalSel = TotalSel + haber - debe;
                    }
                }
                txtimportesel.Text = TotalSel.ToString();
            }
        }

        private void saldoAnteriorTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (decimal.Parse(this.saldoAnteriorTextBox.Text) < 0)
            //{
            //    this.saldoAnteriorTextBox.ForeColor = Color.Red;
            //}
            //else
            //{
            //    this.saldoAnteriorTextBox.ForeColor = Color.Black;
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            operacionesBancoBindingSource.AddNew();
            DataRowView opebanco = (DataRowView)operacionesBancoBindingSource.Current;
            opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            opebanco["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            opebanco["Fecha"] = fechaDateTimePicker.Value;
            opebanco["DesOperacion"] = cbxconcepto.Text.Substring(0,cbxconcepto.Text.LastIndexOf("("));
            opebanco["IdCuenta"] = bancoCuentaComboBox.SelectedValue;
            opebanco["TipoOpe"] = "Otras Operaciones";
            opebanco["IdConBanco"] = Convert.ToInt32(cbxconcepto.SelectedValue);
            opebanco["IdFormaPago"] = Convert.ToInt32(idFormaPagoComboBox.SelectedValue);
            opebanco["Importe"] = chkdebito.Checked == true ? decimal.Parse(importeTextBox.Text) : -decimal.Parse(importeTextBox.Text);
            opebanco["EnCuenta"] = false;
            opebanco["FechaOpe"] = DateTime.Now;
            opebanco["ObsBanco"] = textBox1.Text;
            this.Validate();
            operacionesBancoBindingSource.EndEdit();
            operacionesBancoTableAdapter.Update(promowork_dataDataSet.OperacionesBanco);
            Actualiza();
            importeTextBox.Text = string.Empty;
            textBox1.Text = string.Empty;
           
            int idope = (int)(promowork_dataDataSet.vPrevisiones.Compute("max(IdOpeBanco)", "IdCuenta=" + bancoCuentaComboBox.SelectedValue.ToString()));
            int pos = gridView2.LocateByDisplayText(0, IdOpeBanco1, idope.ToString());
            vPrevisionesBindingSource.Position = pos;
        }

        private void importeTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal importe=0;
            try
            {
                importe = decimal.Parse(importeTextBox.Text);
            }
            catch { }

            button5.Enabled = importe == 0 ? false : true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queriesTableAdapter1.DeleteOperacionesBanco((int)gridView2.GetFocusedRowCellValue("IdOpeBanco"));
                Actualiza();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                string obs = string.Empty;
                decimal? debe = 0;
                decimal? haber = 0;
                decimal? importe = 0;
                DateTime? fecha=null;
                try
                {
                    obs = gridView2.GetRowCellValue(i, "ObsBanco").ToString();
                    fecha = (DateTime)gridView2.GetRowCellValue(i, "Fecha");

                }
                catch { }


                if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCompra")))
                {

                    queriesTableAdapter1.UpdateCompraPagada(false, obs, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")));
                }

                if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCobro")))
                {

                    queriesTableAdapter1.UpdateCobroBanco(false, obs, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCobro")));
                }
                if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdOpeBanco")))
                {
                    debe = gridView2.GetRowCellValue(i, "Debe") == DBNull.Value? 0 : (decimal)gridView2.GetRowCellValue(i, "Debe");
                    haber = gridView2.GetRowCellValue(i, "Haber") == DBNull.Value? 0 : (decimal)gridView2.GetRowCellValue(i, "Haber");
                    importe = debe - haber;

                    int id=Convert.ToInt32(gridView2.GetRowCellValue(i, "IdOpeBanco"));

                    queriesTableAdapter1.UpdateObsOperacionesBanco(obs, importe, fecha, id);

                    
                }
            }
            Actualiza();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
           
            if (Convert.ToString(comboBox1.SelectedValue).Trim() == "")
            {
                MessageBox.Show("Debe definir la Forma de Pago.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //  MessageBox.Show(Convert.ToString(comboBox1.SelectedValue));
                if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    MessageBox.Show("La fecha de la operación tiene que estar contenida en el rango mostrado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    if (gridView2.RowCount > 0)
                    {
                        
                        for (int i = 0; i < gridView2.RowCount; i++)
                        {
                            // MessageBox.Show(Convert.ToString(gridView2.GetRowCellValue(i, "marca")));
                            if (Convert.ToDateTime(gridView2.GetRowCellValue(i, "Fecha")) <= dateTimePicker1.Value)
                            {
                                if (Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdOpeBanco")))
                                {

                                    operacionesBancoBindingSource.AddNew();
                                    DataRowView opebanco = (DataRowView)operacionesBancoBindingSource.Current;
                                    opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
                                    opebanco["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
                                    opebanco["Fecha"] = dateTimePicker1.Value;
                                    opebanco["DesOperacion"] = Convert.ToString(gridView2.GetRowCellValue(i, "DesProveedor")) + " Fra: " + Convert.ToString(gridView2.GetRowCellValue(i, "Factura")) + " (" + Convert.ToString(gridView2.GetRowCellValue(i, "ObsBanco")) + ")";
                                    opebanco["IdCuenta"] = gridView2.GetRowCellValue(i, "IdCuenta");
                                    opebanco["TipoOpe"] = gridView2.GetRowCellValue(i, "Tipo");
                                    opebanco["IdCompra"] = gridView2.GetRowCellValue(i, "IdCompra");
                                    opebanco["IdCobro"] = gridView2.GetRowCellValue(i, "IdCobro");
                                    opebanco["IdFormaPago"] = Convert.ToInt32(comboBox1.SelectedValue);
                                    opebanco["Importe"] = -(decimal)gridView2.GetRowCellValue(i, "Importe");
                                    opebanco["EnCuenta"] = true;
                                    opebanco["FechaOpe"] = DateTime.Now;
                                    opebanco["ObsBanco"] = gridView2.GetRowCellValue(i, "ObsBanco");
                                }
                                else
                                {
                                    DataRowView opebanco1 = (DataRowView)operacionesBancoBindingSource.Current;
                                    opebanco1["EnCuenta"] = true;
                                }

                                this.Validate();
                                operacionesBancoBindingSource.EndEdit();
                                operacionesBancoTableAdapter.Update(promowork_dataDataSet.OperacionesBanco);


                                DataRowView opebanco2 = (DataRowView)operacionesBancoBindingSource.Current;
                                // MessageBox.Show(Convert.ToString(opebanco2["IdOpeBanco"]));
                                queriesTableAdapter1.ActualizaSaldoAnterior(Convert.ToInt32(opebanco2["IdOpeBanco"]));

                                string obs = string.Empty;
                                try
                                {
                                    obs = gridView2.GetRowCellValue(i, "ObsBanco").ToString();
                                }
                                catch { }

                                if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCompra")))
                                {
                                    // pagosTableAdapter.Insert(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdFormaPago")), dateTimePicker1.Value, "BANCO", Convert.ToDecimal(gridView2.GetRowCellValue(i, "Importe")), "", Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCuenta")), dateTimePicker1.Value);

                                    queriesTableAdapter1.UpdateCompraPagada(true, obs, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")));
                                }

                                if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCobro")))
                                {

                                    queriesTableAdapter1.UpdateCobroBanco(true, obs, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCobro")));
                                }


                            }

                        }
                        Actualiza();
                        txtimportesel.Text = string.Empty;
                    }

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RptOperacionesBancoActual frm = new RptOperacionesBancoActual();
            frm.LoadFiltro((int)bancoCuentaComboBox.SelectedValue, dateTimePicker2.Value, dateTimePicker2.MaxDate, false);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ConceptosBanco frm = new ConceptosBanco();
            frm.ShowDialog();
            conceptosBancosTableAdapter.Fill(promowork_dataDataSet.ConceptosBancos);
            
        }

      
       
    }
}
