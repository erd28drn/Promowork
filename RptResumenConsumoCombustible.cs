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
    public partial class RptResumenConsumoCombustible : Form
    {
        public RptResumenConsumoCombustible()
        {
            InitializeComponent();
        }

       
        internal void LoadParametros(DateTime fechaini, DateTime fechafin)
        {
            // TODO: This line of code loads data into the 'Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos' table. You can move, or remove it, as needed.
            this.ConsumosCombustibleVehiculosTableAdapter.FillByCombustible(this.Promowork_dataDataSetCombustible.ConsumosCombustibleVehiculos, VariablesGlobales.nIdEmpresaActual,fechaini,fechafin);
            // TODO: This line of code loads data into the 'Promowork_dataDataSetCombustible.Empresas' table. You can move, or remove it, as needed.
            this.EmpresasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Empresas, VariablesGlobales.nIdEmpresaActual);

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
