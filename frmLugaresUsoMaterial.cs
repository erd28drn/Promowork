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
    public partial class frmLugaresUsoMaterial : Form
    {
        public frmLugaresUsoMaterial()
        {
            InitializeComponent();
        }

        private void lugaresUsoMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lugaresUsoMaterialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosAlbaranes);

        }

      

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("IdEmpresa", VariablesGlobales.nIdEmpresaActual);
        }

        private void frmLugaresUsoMaterial_Load(object sender, EventArgs e)
        {
            this.lugaresUsoMaterialTableAdapter.FillByEmpresa(this.datosAlbaranes.LugaresUsoMaterial, VariablesGlobales.nIdEmpresaActual);
        }
    }
}
