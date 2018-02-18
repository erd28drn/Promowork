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
    public partial class RptFichaTrabajador : Form
    {
        public RptFichaTrabajador()
        {
            InitializeComponent();
        }

        internal void LoadParametros(int nIdTrabajador, int AnoIni, int AnoFin)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenTrabajador' table. You can move, or remove it, as needed.
            this.ResumenTrabajadorTableAdapter.Fill(this.Promowork_dataDataSet.ResumenTrabajador, nIdTrabajador, AnoIni, AnoFin);
            this.resumenTrabajadorTotalMesesTableAdapter.Fill(this.Promowork_dataDataSet.ResumenTrabajadorTotalMeses, nIdTrabajador, AnoIni, AnoFin);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.FichaTrabajador' table. You can move, or remove it, as needed.
            this.FichaTrabajadorTableAdapter.FillByTrabajador(this.Promowork_dataDataSet.FichaTrabajador, nIdTrabajador);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual,VariablesGlobales.nIdEmpresaActual);

            reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();
        }
    }
}
