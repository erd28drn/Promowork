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
    public partial class RptResumenTrabajadores : Form
    {
        public RptResumenTrabajadores()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable tmpObras, DataTable tmpTRabajadores)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.empresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

           ResumenTrabajadoresTableAdapter.Fill(Promowork_dataDataSet.ResumenTrabajadores, VariablesGlobales.nIdEmpresaActual, fechaini, fechafin, tmpObras, tmpTRabajadores);

            ReportParameter[] Parametros = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
          

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();
        }
       
    }
}
