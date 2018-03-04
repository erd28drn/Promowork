using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Promowork
{
    public partial class frmRevisionAlbaranes : Form
    {
        public frmRevisionAlbaranes()
        {
            InitializeComponent();
        }

        string AparienciaGridrevisionAlabaranes = "";

        DateTime FechaIni;
        DateTime FechaFin;
        bool dirConversion=true;

        private void frmRevisionAlbaranes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosAlbaranes.UMedidas' Puede moverla o quitarla según sea necesario.
            this.vProductosConversionesTableAdapter.FillByEmpresa(this.datosAlbaranes.vProductosConversiones, VariablesGlobales.nIdEmpresaActual);
            this.WindowState = FormWindowState.Maximized;

            this.anosTableAdapter.FillByEmpresa(this.datosAlbaranes.Anos, VariablesGlobales.nIdEmpresaActual);

            //cbxAno.EditValue = VariablesGlobales.nAnoActual;

            //this.mesesAlbaranesTableAdapter.FillByEmpresaAno(this.datosAlbaranes.MesesAlbaranes, (int)cbxAno.EditValue, VariablesGlobales.nIdEmpresaActual);
            //cbxMes.EditValue = VariablesGlobales.nMesActual;

            //checkEdit1.CheckState = CheckState.Checked;

            FechaIni = new DateTime(VariablesGlobales.nAnoActual, 1, 1);
            FechaFin = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual));


            deFechaIni.EditValue = FechaIni;
            deFechaFin.EditValue = FechaFin;


            this.vRevisionAlbaranesTableAdapter.FillByFechaIniFechaFin(this.datosAlbaranes.vRevisionAlbaranes, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);

            DataColumn col = new DataColumn("Filtro", typeof(bool));
            col.DefaultValue = false;
            this.datosAlbaranes.vRevisionAlbaranes.Columns.Add(col);


            AparienciaGridrevisionAlabaranes = this.Name + gridView1.Name + VariablesGlobales.nIdEmpresaActual.ToString() + VariablesGlobales.nIdUsuarioActual.ToString() + ".xml";
            try
            {
                gridView1.RestoreLayoutFromXml(AparienciaGridrevisionAlabaranes);

            }
            catch { }
        }

        private void frmRevisionAlbaranes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(AparienciaGridrevisionAlabaranes);
            
            gridView1.SaveLayoutToXml(AparienciaGridrevisionAlabaranes);

         //   this.Visible = false;
            // promowork_dataDataSet.Clear();
          //  this.Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxAno.ItemIndex != -1)
            {
                this.mesesAlbaranesTableAdapter.FillByEmpresaAno(this.datosAlbaranes.MesesAlbaranes, (int)cbxAno.EditValue, VariablesGlobales.nIdEmpresaActual);
                
              //  this.vRevisionAlbaranesTableAdapter.FillByEmpresaAno(this.datosAlbaranes.vRevisionAlbaranes, VariablesGlobales.nIdEmpresaActual, (int)cbxAno.EditValue);
            }
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxMes.ItemIndex != -1)
            {
                this.vRevisionAlbaranesTableAdapter.FillByEmpresaAnoMes(this.datosAlbaranes.vRevisionAlbaranes, VariablesGlobales.nIdEmpresaActual, (int)cbxAno.EditValue, (int)cbxMes.EditValue);
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.CheckState == CheckState.Checked)
            {
                cbxMes.Enabled = false;
                this.vRevisionAlbaranesTableAdapter.FillByEmpresaAno(this.datosAlbaranes.vRevisionAlbaranes, VariablesGlobales.nIdEmpresaActual, (int)cbxAno.EditValue);
            }
            else
            {
                cbxMes.Enabled = true;
                if (cbxMes.ItemIndex != -1)
                {
                    this.vRevisionAlbaranesTableAdapter.FillByEmpresaAnoMes(this.datosAlbaranes.vRevisionAlbaranes, VariablesGlobales.nIdEmpresaActual, (int)cbxAno.EditValue, (int)cbxMes.EditValue);
                }
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ShowRibbonPrintPreview();
        }


        private void deFechaIni_EditValueChanged(object sender, EventArgs e)
        {
            FechaIni = (DateTime)deFechaIni.EditValue;
            
        }

        private void deFechaFin_EditValueChanged(object sender, EventArgs e)
        {
            FechaFin = (DateTime)deFechaFin.EditValue;
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.vRevisionAlbaranesTableAdapter.FillByFechaIniFechaFin(this.datosAlbaranes.vRevisionAlbaranes, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
        }


        private void CalculaConversionUM(bool Orgdest)
        {
            try
            {
                dirConversion = Orgdest;
                if (dirConversion)
                {
                    if (tbCantidadOrigen.EditValue != null && tbMultiplicador.EditValue != null && tbMultiplicador.EditValue != string.Empty)
                    {
                        lbFlecha1.Text = "→";
                        lbFlecha2.Text = "→";
                        tbCantidadOrigen.ForeColor = Color.Black;
                        tbCantidadDestino.ForeColor = Color.Blue;
                        tbCantidadDestino.EditValue = Math.Round((decimal.Parse(tbCantidadOrigen.EditValue.ToString()) * decimal.Parse(tbMultiplicador.EditValue.ToString())), 6);
                    }
                }
                else
                {
                    if (tbCantidadDestino.EditValue != null && tbMultiplicador.EditValue != null && tbMultiplicador.EditValue != string.Empty)
                    {
                        lbFlecha1.Text = "←";
                        lbFlecha2.Text = "←";
                        tbCantidadOrigen.ForeColor = Color.Blue;
                        tbCantidadDestino.ForeColor = Color.Black;
                        tbCantidadOrigen.EditValue = Math.Round((decimal.Parse(tbCantidadDestino.EditValue.ToString()) / decimal.Parse(tbMultiplicador.EditValue.ToString())), 6);
                    }
                }
            }
            catch
            {
                //tbCantidadOrigen.EditValue = 0;
                //tbCantidadDestino.EditValue = 0;
            }
        }

      
        private void tbCantidadOrigen_KeyUp(object sender, KeyEventArgs e)
        {
            CalculaConversionUM(true);
        }

        private void tbCantidadDestino_KeyUp(object sender, KeyEventArgs e)
        {
            CalculaConversionUM(false);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxProducto.SelectedIndex != -1)
            {
                
                    tbCantidadOrigen.EditValue = 0;
                    tbCantidadDestino.EditValue = 0;
                
              //  CalculaConversionUM(true);
                this.vUMOrigenTableAdapter.FillByEmpresaProducto(this.datosAlbaranes.vUMOrigen, VariablesGlobales.nIdEmpresaActual, (int)cbxProducto.SelectedValue);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConversionesUM frm = new frmConversionesUM();
            frm.ShowDialog();
            this.vProductosConversionesTableAdapter.FillByEmpresa(this.datosAlbaranes.vProductosConversiones, VariablesGlobales.nIdEmpresaActual);
            this.vUMOrigenTableAdapter.FillByEmpresaProducto(this.datosAlbaranes.vUMOrigen, VariablesGlobales.nIdEmpresaActual, (int)cbxProducto.SelectedValue);
        }

        private void cbxUMOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxProducto.SelectedIndex != -1 && cbxUMOrigen.SelectedIndex != -1)
            {
                this.vUMDestinoTableAdapter.FillByEmpresaProducto(this.datosAlbaranes.vUMDestino, VariablesGlobales.nIdEmpresaActual, (int)cbxProducto.SelectedValue, (int)cbxUMOrigen.SelectedValue);
            }
            else
            {
                this.vUMDestinoTableAdapter.FillByEmpresaProducto(this.datosAlbaranes.vUMDestino, VariablesGlobales.nIdEmpresaActual, 0, 0);
            }
        }

        private void tbMultiplicador_EditValueChanged(object sender, EventArgs e)
        {
            CalculaConversionUM(dirConversion);
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            GridCell[] celdasSeleccionadas = gridView1.GetSelectedCells();
            GridView gridView = (GridView)sender;

            var resultado = Utilidades.SumarCeldas(gridView, celdasSeleccionadas);

            tbRecuentoSeleccion.Text = resultado.Recuento.ToString();
            tbSumaSeleccion.Text = resultado.Suma.ToString("N2");
            tbPromedioSeleccion.Text = resultado.Promedio.ToString("N2");
        }
    }
}
