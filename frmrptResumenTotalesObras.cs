using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public partial class frmrptResumenTotalesObras : Form
    {
        public frmrptResumenTotalesObras()
        {
            InitializeComponent();
        }

        private void frmrptResumenTotalesObras_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cbxTipoReporte.SelectedIndex = 0;


            // TODO: esta línea de código carga datos en la tabla 'DatosReportesNuevos.vTotalPorObrasConCalculos' Puede moverla o quitarla según sea necesario.
           
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vTotalPorObrasConCalculosBindingSource.RemoveFilter();
            
            if (vTotalPorObrasConCalculosBindingSource.Count == 0)
            {
                this.vTotalPorObrasConCalculosTableAdapter.FillByEmpresa(this.DatosReportesNuevos.vTotalPorObrasConCalculos, VariablesGlobales.nIdEmpresaActual);
            }

            switch (cbxTipoReporte.SelectedIndex)
            
            {
                case 0:
                    vTotalPorObrasConCalculosBindingSource.Filter = "PorcBeneficioFact<=" + spnPorciento.Value.ToString().Replace(",", ".");
                    //this.vTotalPorObrasConCalculosTableAdapter.FillByBeneficioFactMenor(DatosReportesNuevos.vTotalPorObrasConCalculos, spnPorciento.Value, VariablesGlobales.nIdEmpresaActual);
                    break;

                case 1:
                    vTotalPorObrasConCalculosBindingSource.Filter = "PorcBeneficioFact>=" + spnPorciento.Value.ToString().Replace(",", ".");
                    //this.vTotalPorObrasConCalculosTableAdapter.FillByBeneficioFactMayor(DatosReportesNuevos.vTotalPorObrasConCalculos, spnPorciento.Value, VariablesGlobales.nIdEmpresaActual);
                    break;

                case 2:
                    vTotalPorObrasConCalculosBindingSource.Filter = "PorcBeneficioCob<=" + spnPorciento.Value.ToString().Replace(",", ".");    
                //this.vTotalPorObrasConCalculosTableAdapter.FillByBeneficioCobMenor(DatosReportesNuevos.vTotalPorObrasConCalculos, spnPorciento.Value, VariablesGlobales.nIdEmpresaActual);
                    break;

                case 3:
                    vTotalPorObrasConCalculosBindingSource.Filter = "PorcBeneficioCob>=" + spnPorciento.Value.ToString().Replace(",", ".");    
                //this.vTotalPorObrasConCalculosTableAdapter.FillByBeneficioCobMayor(DatosReportesNuevos.vTotalPorObrasConCalculos, spnPorciento.Value, VariablesGlobales.nIdEmpresaActual);
                    break;

                //case 4:
                //    this.vTotalPorObrasConCalculosTableAdapter.FillByEmpresa(DatosReportesNuevos.vTotalPorObrasConCalculos, VariablesGlobales.nIdEmpresaActual);
                //    break;
            }


           

            this.reportViewer1.RefreshReport();
        }
    }
}
