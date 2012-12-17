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
    public partial class RptParametrosObrasVenta : Form
    {
        public RptParametrosObrasVenta()
        {
            InitializeComponent();
        }

        private void RptParametros_Load(object sender, EventArgs e)
        {

            marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
            marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual);
            empresasActualTableAdapter.FillByEmpresa(promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            marcaAnoTableAdapter.Fill(promowork_dataDataSet.MarcaAno, VariablesGlobales.nIdEmpresaActual);
            marcaMesTableAdapter.Fill(promowork_dataDataSet.MarcaMes, VariablesGlobales.nIdEmpresaActual);

            DataRowView Empresa = (DataRowView)empresasActualBindingSource.Current;
           
            int nMes= Convert.ToInt32(Empresa["MesEmpresa"]);
            int nAno= Convert.ToInt32(Empresa["AnoEmpresa"]);
          // int nDiasFin = DateTime.DaysInMonth(nAno, nMes);

            anoTrabComboBox.SelectedValue = nAno;
            nomMesComboBox.SelectedValue = nMes;
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                DataTable tmpObras = promowork_dataDataSet.MarcaObras.Select("Marca= true").CopyToDataTable();
                DataTable tmpTRabajadores = promowork_dataDataSet.MarcaTrabajadores.Select("Marca= true").CopyToDataTable();

                RptResumenObrasSalarioVentaDias frm = new RptResumenObrasSalarioVentaDias();
                frm.LoadParametros(Convert.ToInt32(anoTrabComboBox.SelectedValue), Convert.ToInt32(nomMesComboBox.SelectedValue), tmpObras, tmpTRabajadores);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Es Obligatorio Seleccionar al menos un Registro en cada panel.", this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                marcaObrasTableAdapter.Fill(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
              //  checkBox1.Text = "Desmarcar Todo";
            }
            else
            {
                marcaObrasTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaObras, VariablesGlobales.nIdEmpresaActual);
             //   checkBox1.Text = "Marcar Todo";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                marcaTrabajadoresTableAdapter.Fill(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual);
               // checkBox2.Text = "Desmarcar Todo";
            }
            else
            {
                marcaTrabajadoresTableAdapter.FillByDesmarcado(promowork_dataDataSet.MarcaTrabajadores, VariablesGlobales.nIdEmpresaActual);
              //  checkBox2.Text = "Marcar Todo";
            }
        }

        
    }
}
