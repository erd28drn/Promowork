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
    public partial class frmConversionesUM : Form
    {
        public frmConversionesUM()
        {
            InitializeComponent();
        }

        private void conversionesUMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conversionesUMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosAlbaranes);

        }

        
        private void frmConversionesUM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosAlbaranes.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.FillByEmpresa(this.datosAlbaranes.Productos, VariablesGlobales.nIdEmpresaActual);
            // TODO: esta línea de código carga datos en la tabla 'datosAlbaranes.UMedidas' Puede moverla o quitarla según sea necesario.
            this.uMedidasTableAdapter.Fill(this.datosAlbaranes.UMedidas);
            this.conversionesUMTableAdapter.FillByEmpresa(this.datosAlbaranes.ConversionesUM, VariablesGlobales.nIdEmpresaActual);
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
        }
    }
}
