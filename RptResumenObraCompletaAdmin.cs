using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Promowork
{
    public partial class RptResumenObraCompletaAdmin : Form
    {
        public RptResumenObraCompletaAdmin()
        {
            InitializeComponent();
        }

        internal void LoadParametros(int nIdObra, decimal Porciento, DateTime FechainiHoras, DateTime FechafinHoras, DateTime FechainiCompras, DateTime FechafinCompras, int colorRojo, int colorAzul, int colorNegro)
        {
            this.WindowState = FormWindowState.Maximized;
            this.ResumenObraCompletaAdminTableAdapter.Fill(this.Promowork_dataDataSet.ResumenObraCompletaAdmin, nIdObra, FechainiHoras, FechafinHoras, colorRojo, colorAzul, colorNegro, FechainiCompras, FechafinCompras);
            this.ResumenObraCompletaTotalAdminTableAdapter.Fill(this.Promowork_dataDataSet.ResumenObraCompletaTotalAdmin, nIdObra, FechainiHoras, FechafinHoras, FechainiCompras, FechafinCompras);
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);

            ReportParameter[] Parametros = new ReportParameter[1];
            Parametros[0] = new ReportParameter("Porciento", Convert.ToString(Porciento));
            this.reportViewer1.LocalReport.SetParameters(Parametros);
            this.reportViewer1.RefreshReport();
        }

        
    }
}
