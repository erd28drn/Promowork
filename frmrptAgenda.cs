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
    public partial class frmrptAgenda : Form
    {
        public frmrptAgenda()
        {
            InitializeComponent();
        }

        private void frmrpdAgenda_Load(object sender, EventArgs e)
        {
            
           
            // TODO: esta línea de código carga datos en la tabla 'datosReportesNuevos.vAgenda' Puede moverla o quitarla según sea necesario.
            //this.vAgendaTableAdapter.Fill(this.datosReportesNuevos.vAgenda);
            this.WindowState = FormWindowState.Maximized;
            spnAno.Value = VariablesGlobales.nAnoActual;
            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.vAgendaTableAdapter.Fill(datosReportesNuevos.vAgenda, VariablesGlobales.nIdEmpresaActual, (int)spnAno.Value);
            this.vAgendaGastosGeneralesTableAdapter.FillByEmpresaAno(this.datosReportesNuevos.vAgendaGastosGenerales, VariablesGlobales.nIdEmpresaActual, (int)spnAno.Value);
            this.reportViewer1.RefreshReport();
        }

       
    }
}
