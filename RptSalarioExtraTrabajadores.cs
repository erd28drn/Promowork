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
    public partial class RptSalarioExtraTrabajadores : Form
    {
        public RptSalarioExtraTrabajadores()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable tmpObras, DataTable tmpTRabajadores, bool IncAusencias, bool IncSinPartes)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.empresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.MarcaObras' table. You can move, or remove it, as needed.

            resumenSalarioExtraTrabajadoresTableAdapter.Fill(promowork_dataDataSet.ResumenSalarioExtraTrabajadores, VariablesGlobales.nIdEmpresaActual, fechaini, fechafin, tmpObras, tmpTRabajadores);

            if (IncAusencias == true)
            {
                if (IncSinPartes == true)
                {
                    resumenSalarioExtraTrabajadoresBindingSource.Filter = null;
                }
                else
                {
                    resumenSalarioExtraTrabajadoresBindingSource.Filter = "IdObra<>0";
                }
            }
            else
            {
                if (IncSinPartes == true)
                {
                    resumenSalarioExtraTrabajadoresBindingSource.Filter = "not (Cantidad=0 and IdObra<>0)";
                }
                else
                {
                    resumenSalarioExtraTrabajadoresBindingSource.Filter = "Cantidad<>0";
                }
            }


            //if (IncAusencias == false || IncSinPartes == false)
            //{
            //    resumenSalarioExtraTrabajadoresBindingSource.Filter = "Cantidad<>0";

            //    if (IncAusencias == true || IncSinPartes == true)
            //    {

            //        if (IncAusencias == false)
            //        {
            //            resumenSalarioExtraTrabajadoresBindingSource.Filter = resumenSalarioExtraTrabajadoresBindingSource.Filter + " and IdObra<>0";
            //        }

            //        if (IncSinPartes == false)
            //        {
            //            resumenSalarioExtraTrabajadoresBindingSource.Filter = resumenSalarioExtraTrabajadoresBindingSource.Filter + " and IdObra=0";
            //        }
            //    }
            //}
          
           
            ReportParameter[] Parametros = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
           
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);
            this.reportViewer1.RefreshReport();

        }

        private void RptSalarioExtraTrabajadores_Load(object sender, EventArgs e)
        {

        }

      
    }
}
