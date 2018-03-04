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
    public partial class rptParametrosSinAlbaran : Form
    {
        public rptParametrosSinAlbaran()
        {
            InitializeComponent();
        }

        int nMes;
        int nAno;
        int nDiasFin;
        DateTime FechaIni;
        DateTime FechaFin;
        IEnumerable<ResumenEnvioCorreos> proveedores;

        private void rptParametrosSinAlbaran_Load(object sender, EventArgs e)
        {
             nMes = VariablesGlobales.nMesActual;
            nAno = VariablesGlobales.nAnoActual;
            nDiasFin = DateTime.DaysInMonth(nAno, nMes);
            FechaIni = new DateTime(nAno, nMes, 1);
            FechaFin = new DateTime(nAno, nMes, nDiasFin);

            dateTimePicker1.Value = FechaIni;
            dateTimePicker2.Value = FechaFin;
            dateTimePicker2.MinDate = FechaIni;
            
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            this.vAlbaranesTableAdapter.FillBySinAlbaran(this.DatosReportesNuevos.vAlbaranes, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaIni = dateTimePicker1.Value;
            dateTimePicker2.MinDate = FechaIni;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FechaFin = dateTimePicker2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];

            proveedores = proveedoresSinAlbaranTableAdapter.GetData(VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin)
                .Select(p => new ResumenEnvioCorreos { Marca= Utilidades.ValidarEmail(p.EmailProveedor),
                                                       Proveedor = p.DesProveedor, 
                                                       Email = p.EmailProveedor, 
                                                       Valido = Utilidades.ValidarEmail(p.EmailProveedor)});
            gridControl1.DataSource = proveedores;
       
        }

        private class ResumenEnvioCorreos
        {
            public bool Marca { get; set; }
            public string Proveedor {get; set;}
            public string Email {get; set;}
            public bool Valido {get; set;}
            public bool Enviado {get; set;}
        }

        private void fillbySinAlbaranToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillbySinAlbaranToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void fillbySinAlbaranToolStripButton_Click_2(object sender, EventArgs e)
        {

        }

        private void fillbySinAlbaranToolStripButton_Click_3(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            proveedores = (IEnumerable<ResumenEnvioCorreos>)gridControl1.DataSource;

            foreach (var proveedor in proveedores.Where(P => P.Valido))
            {
                Utilidades.EnviaCorreo();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this.Validate();
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
        }

    }
}
