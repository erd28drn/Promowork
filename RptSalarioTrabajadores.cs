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
    public partial class RptSalarioTrabajadores : Form
    {
        public RptSalarioTrabajadores()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable  tmpObras, DataTable tmpTRabajadores)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.empresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.MarcaObras' table. You can move, or remove it, as needed.

            resumenSalarioTrabajadoresTableAdapter.Fill(promowork_dataDataSet.ResumenSalarioTrabajadores, VariablesGlobales.nIdEmpresaActual,fechaini, fechafin, tmpObras, tmpTRabajadores);

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
