using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Promowork
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }



        private void Prueba_Load(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaa");
            this.anosFacturasTableAdapter.FillByFactPresup(promowork_dataDataSet.AnosFacturas, VariablesGlobales.nIdEmpresaActual);
            cbxanos.SelectedValue = VariablesGlobales.nAnoActual;

            this.presupDetTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupDet);
            this.presupSubTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupSub);

            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupDet' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCap' table. You can move, or remove it, as needed.
            this.presupCapTableAdapter.FillByNumDes(this.promowork_dataDataSet.PresupCap);
            ////////////////presupSubBindingSource1.Filter = "Pendiente<>0";
            ////////////////presupDetBindingSource1.Filter = "Pendiente<>0";
            //MessageBox.Show(presupCabBindingSource1.Count.ToString()); ;
            // presupCapBindingSource1.Filter = "Pendiente<>0 and IdPresupCab=" + Convert.ToString(idPresupComboBox.SelectedValue);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.CuentasBancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.Fill(this.promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.presupCabTableAdapter.FillByEmpresaTodo(this.promowork_dataDataSet.PresupCab, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            clientesBindingSource.Sort = "DesCliente";
            //////////////////clientesBindingSource1.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasDet' table. You can move, or remove it, as needed.
            // this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasCab' table. You can move, or remove it, as needed.
            if (cbxfacturas.Text == "Facturas")
            {
                this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
            }
            else
            {
                this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
            }
            facturasCabBindingSource.Filter = "FacturaPresup=1";
            // MessageBox.Show(facturasCabBindingSource.Count.ToString());
            this.empresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            this.facturasCabBindingSource.MoveLast();
        }

        private void cbxanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxanos.SelectedIndex != -1)
            {
                if (cbxfacturas.Text == "Facturas")
                {
                    this.facturasCabTableAdapter.FillByFactHorasFacturas(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                }
                else
                {
                    this.facturasCabTableAdapter.FillByFactHorasParte(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual, (int)cbxanos.SelectedValue);
                }
                facturasCabBindingSource.Filter = "FacturaPresup=1";
            }
        }


    }
}
