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
    public partial class frmrptSinAlbaran : Form
    {
        public frmrptSinAlbaran()
        {
            InitializeComponent();
        }

        private void frmrptSinAlbaran_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosReportesNuevos.vAlbaranes' Puede moverla o quitarla según sea necesario.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            // TODO: esta línea de código carga datos en la tabla 'DatosReportesNuevos.vAlbaranes' Puede moverla o quitarla según sea necesario.
            this.vAlbaranesTableAdapter.FillBySinAlbaran(this.DatosReportesNuevos.vAlbaranes, VariablesGlobales.nIdEmpresaActual);

            this.reportViewer1.RefreshReport();
        }
    }
}
