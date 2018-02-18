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
    public partial class frmrptPendienteCobro : Form
    {
        public frmrptPendienteCobro()
        {
            InitializeComponent();
        }

        private void frmrptPendienteCobro_Load(object sender, EventArgs e)
        {
            
          marcaClientesTableAdapter.FillByDesmarca(promowork_dataDataSet.MarcaClientes, VariablesGlobales.nIdEmpresaActual);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tmpClientes = new DataTable();

            for (int i = 0; i < gridView2.Columns.Count; i++)
            {
                tmpClientes.Columns.Add(gridView2.Columns[i].FieldName);
            }


            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if ((bool)gridView2.GetRowCellValue(i, "Marca") == true)
                {
                    tmpClientes.ImportRow(gridView2.GetDataRow(i));
                }
            }


            this.facturasPendientesCobroTableAdapter.Fill(datosReportesNuevos.FacturasPendientesCobro, tmpClientes);
        }

       

    }
}
