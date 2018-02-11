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
    public partial class frmTiposProductos : Form
    {
        public frmTiposProductos()
        {
            InitializeComponent();
        }

        private void lugaresUsoMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tiposProductosBindingSource.EndEdit();
            this.tiposProductosTableAdapter.Update(promowork_dataDataSet.TiposProductos);

        }

      

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
        }

        private void frmLugaresUsoMaterial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.UMedidas' Puede moverla o quitarla según sea necesario.
            this.uMedidasTableAdapter.Fill(this.promowork_dataDataSet.UMedidas);
            this.tiposProductosTableAdapter.FillByEmpresa(this.promowork_dataDataSet.TiposProductos, VariablesGlobales.nIdEmpresaActual);
        }
    }
}
