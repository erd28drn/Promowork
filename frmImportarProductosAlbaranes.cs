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
    public partial class frmImportarProductosAlbaranes : Form
    {

        
        
        public frmImportarProductosAlbaranes()
        {
            InitializeComponent();
        }

        int Parte;
        int Obra;
        DateTime FechaParte;

        internal void PasarParametros(int ParteActual, int ObraActual)
        {
            Parte = ParteActual;
            Obra = ObraActual;
            FechaParte = (DateTime)queriesAlbaranes1.ObtieneFechaParte(Parte);

            var FechaIni = new DateTime((FechaParte.AddMonths(-1)).Year, (FechaParte.AddMonths(-1)).Month, 1);
            var FechaFin = new DateTime((FechaParte.AddMonths(1)).Year, (FechaParte.AddMonths(1)).Month, DateTime.DaysInMonth((FechaParte.AddMonths(1)).Year, (FechaParte.AddMonths(1)).Month));

            gridView1.ActiveFilterString = "[FechaAlbaran] Between(#" + FechaIni.ToString("yyyy-MM-dd") + "#, #" + FechaFin.ToString("yyyy-MM-dd") + "#)";

            CargarDatos();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int vIdAlbaran = 0;
            if (!gridView1.IsFilterRow(e.FocusedRowHandle) && e.FocusedRowHandle >= 0)
            {
                int.TryParse(gridView1.GetFocusedRowCellValue("IdAlbaranCab").ToString(), out vIdAlbaran);
            }
            this.vImportarAlbaranesDetTableAdapter.FillByAlbaran(this.datosAlbaranes.vImportarAlbaranesDet, vIdAlbaran);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if ((bool)gridView1.GetFocusedRowCellValue("Valorado") == true)
            //{
                queriesAlbaranes1.ImportarAlbaran((int)gridView1.GetFocusedRowCellValue("IdAlbaranCab"), Parte);
                gridView1.DeleteSelectedRows();
            //}
            //else
            //{
            //    MessageBox.Show("No pueden importatrse los productos de un Albaran no valorado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void chkMostraNoValorados_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (chkMostraValorados.CheckState == CheckState.Checked)
            {
                this.vImportarAlbaranesCabTableAdapter.FillByEmpresaObra(this.datosAlbaranes.vImportarAlbaranesCab, VariablesGlobales.nIdEmpresaActual, Obra, true);
            }
            else
            {
                this.vImportarAlbaranesCabTableAdapter.FillByConNoValorados(this.datosAlbaranes.vImportarAlbaranesCab, VariablesGlobales.nIdEmpresaActual, Obra);
            }

        }

    }
}
