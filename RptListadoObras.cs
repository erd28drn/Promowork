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
    public partial class RptListadoObras : Form
    {
        public RptListadoObras()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(bool activa)
        {
           
            this.WindowState = FormWindowState.Maximized;

            if (activa == true)
            {
               ObrasTableAdapter.FillByFechaObra(Promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            }
            else {
                ObrasTableAdapter.FillByEmpresa(Promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            }

            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            ReportParameter[] Parametros = new ReportParameter[1];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("Activas", Convert.ToString(activa));
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.LocalReport.EnableExternalImages=true;
            this.reportViewer1.RefreshReport();
        }

      
    }
}
