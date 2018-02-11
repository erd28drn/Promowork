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
    public partial class RptSeguridadSocial : Form
    {
        public RptSeguridadSocial()
        {
            InitializeComponent();
        }

        private void RptSeguridadSocial_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenSeguridadSocial' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            byte nMes = Convert.ToByte(VariablesGlobales.nMesActual);
            int nAno = Convert.ToInt32(VariablesGlobales.nAnoActual);
            
            
            this.ResumenSeguridadSocialTableAdapter.Fill(this.Promowork_dataDataSet.ResumenSeguridadSocial,VariablesGlobales.nIdEmpresaActual, nMes, nAno);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
