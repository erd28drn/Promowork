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
    public partial class RptParametrosFichaTrabajador : Form
    {
        public RptParametrosFichaTrabajador()
        {
            InitializeComponent();
        }

        private void RptParametrosFichaTrabajador_Load(object sender, EventArgs e)
        {
            trabajadoresListaTableAdapter.FillByTodosEmpresa(promowork_dataDataSet.TrabajadoresLista, VariablesGlobales.nIdEmpresaActual);
            comboBox1.SelectedIndex = 0;
            textBox1.Text = Convert.ToString(DateTime.Now.Year);
            textBox2.Text = Convert.ToString(DateTime.Now.Year);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nIdTrabajador = Convert.ToInt32(comboBox1.SelectedValue);
                int AnoIni = Convert.ToInt32(textBox1.Text);
                int AnoFin = Convert.ToInt32(textBox2.Text);
           
            RptFichaTrabajador frm = new RptFichaTrabajador();
            frm.LoadParametros(nIdTrabajador,AnoIni, AnoFin);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de Año de Inicio o Fin Incorrecto.", this.Text);
            }
        }
    }
}
