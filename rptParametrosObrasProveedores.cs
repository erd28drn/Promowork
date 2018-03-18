using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Promowork
{
    public partial class rptParametrosObrasProveedores : Form
    {
        public rptParametrosObrasProveedores()
        {
            InitializeComponent();
        }

        int nMes;
        int nAno;
        int nDiasFin;
        DateTime FechaIni;
        DateTime FechaFin;
        IEnumerable<ResumenEnvioCorreos> proveedores;
        IEnumerable<ObrasEnviar> obras;

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
            Cursor.Current = Cursors.WaitCursor;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            this.listadoObrasTableAdapter.FillByEmpresa(this.DatosReportesNuevos.ListadoObras, VariablesGlobales.nIdEmpresaActual);
            this.reportViewer1.RefreshReport();
            Cursor.Current = Cursors.Default;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaIni = dateTimePicker1.Value;
            dateTimePicker2.MinDate = FechaIni;
            button3.Enabled = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FechaFin = dateTimePicker2.Value;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tabControl1.SelectedTab = tabControl1.TabPages[1];

            try
            {
                this.listadoObrasTableAdapter.FillByEmpresa(this.DatosReportesNuevos.ListadoObras, VariablesGlobales.nIdEmpresaActual);
                proveedores = proveedoresSinAlbaranTableAdapter.GetData(VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin)
                    .Select(p => new ResumenEnvioCorreos
                    {
                        IdProveedor = p.IdProveedor,
                        Marca = Utilidades.ValidarEmail(p.EmailProveedor),
                        Proveedor = p.DesProveedor,
                        Email = p.EmailProveedor,
                        Valido = Utilidades.ValidarEmail(p.EmailProveedor),
                        Enviado = null
                    }).ToList();
                gridControl1.DataSource = proveedores;
                button3.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                button3.Enabled = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error al validar los proveedores. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MostrarObras();
       
        }

        private class ResumenEnvioCorreos
        {
            public int IdProveedor { get; set; }
            public bool Marca { get; set; }
            public string Proveedor {get; set;}
            public string Email {get; set;}
            public bool Valido {get; set;}
            public bool? Enviado {get; set;}
            public string Respuesta { get; set; }
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
            Cursor.Current = Cursors.WaitCursor;
            var cuerpoCorreo = "<p>Con el fin de poder verificar sus facturas, rogamos nos envien copia de los siguientes albaranes a compras@promowork.es " +
                                "Ya que NO disponemos de ellos. Para ello, será necesario que conste la firma y el DNI de la persona autorizada que realizó " +
                                "la retirada del material o autorizó la escarga.</p>" +
                                "<p>Sin otro particular,<br>" +
                                "Le saludo muy cordialmente,</p>" +
                                "<p>Oscar Urpi<br>" +
                                "Dpto.Compras.</p>";

            foreach (var proveedor in proveedores.Where(p => p.Marca))
            {
                if (!Directory.Exists("ENVIADOS/SIN ALBARAN"))
                {
                    Directory.CreateDirectory("ENVIADOS/SIN ALBARAN");
                }
                //vAlbaranesBindingSource.Filter = "IdProveedor=" + proveedor.IdProveedor.ToString();
                this.reportViewer1.RefreshReport();
                string nombreFichero= "ENVIADOS/SIN ALBARAN/"+/*DateTime.Today.ToString("yyyyMMdd")+*/"ALBARANES PENDIENTES " + proveedor.Proveedor;
                var RespuestaCrearFichero= Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
                if (RespuestaCrearFichero == string.Empty)
                {
                    List<string> destinatarios = new List<string>();
                    destinatarios.Add("compras@promowork.es");
                    
                    
                    //List<string> destinatarios= proveedor.Email.Split(';').ToList();
                    string asunto= "Albaranes Pendientes";
                    List<string> adjuntos= new List<string>();
                    adjuntos.Add(nombreFichero+ ".PDF");
                    string respuestaEnviarCorreo= Utilidades.EnviaCorreo(destinatarios, asunto, adjuntos, cuerpoCorreo);
                    proveedor.Enviado = true;
                    proveedor.Respuesta = respuestaEnviarCorreo;
                }
                else
                {
                    proveedor.Enviado = false;
                    proveedor.Respuesta = RespuestaCrearFichero;
                }
            }
            gridControl1.RefreshDataSource();

            //vAlbaranesBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();

            Cursor.Current = Cursors.Default;

        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var valido = (bool)gridView1.GetFocusedRowCellValue(colValido);
            if (!valido)
            {
                e.Cancel = true;
            }
        }

        private void GenerarReporteProveedor(int idProvedor)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private class ObrasEnviar
        {
            public int IdObra { get; set; }
            public bool Marca { get; set; }
            public string Matriz { get; set; }
            public int Numero { get; set; }
            public string Descripcion { get; set; }
            public string NumeroDescripcion { get; set; }
            public string MatrizNumeroDescripcion { get; set; }
        }

        private void MostrarObras()
        {
            Cursor.Current = Cursors.WaitCursor;
            //tabControl1.SelectedTab = tabControl1.TabPages[0];

            try
            {
                obras = listadoObrasTableAdapter.GetData(VariablesGlobales.nIdEmpresaActual).Where(o=> o.ActivaObra)
                    .Select(o => new ObrasEnviar
                    {
                        IdObra = o.IdObra,
                        Marca = !o.GastosGenereales,
                        //Matriz = o.NumMatriz.ToString(),
                        Numero = o.NumObra,
                        Descripcion = o.DesObra,
                        //NumeroDescripcion= o.ObraSM,
                        //MatrizNumeroDescripcion=o.Obra
                    }).ToList();
                obrasGridControl.DataSource = obras.OrderBy(o=> o.Numero);
                button3.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                button3.Enabled = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error al cargar las obras. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
