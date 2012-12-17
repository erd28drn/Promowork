using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace Promowork
{
    public partial class RptHorasTrabajadasDias : Form
    {
        public RptHorasTrabajadasDias()
        {
            InitializeComponent();
        }

        internal void LoadParametros(int nAno, int nMes, DataTable  tmpObras, DataTable tmpTRabajadores)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ObrasSalarioVentaDias' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);

            //this.ObrasSalarioVentaDiasTableAdapter.Fill(this.Promowork_dataDataSet.ObrasSalarioVentaDias, VariablesGlobales.nIdEmpresaActual);

            ObrasSalarioVentaDiasTableAdapter.Fill(Promowork_dataDataSet.ObrasSalarioVentaDias, VariablesGlobales.nIdEmpresaActual, nAno, nMes, tmpObras, tmpTRabajadores);
            
            ReportParameter[] Parametros = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("Mes", Convert.ToString(nMes));
            Parametros[1] = new ReportParameter("Ano", Convert.ToString(nAno));

            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
