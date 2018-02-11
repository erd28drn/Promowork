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
    public partial class RptResumenCompras : Form
    {
        public RptResumenCompras()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(int  Filtro)
        {
            this.WindowState = FormWindowState.Maximized;
            // ordersTableAdapter.FillByCustomerID(northwindDataSet.Orders, CustomerID);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.ResumenCompras' table. You can move, or remove it, as needed.
            this.ResumenComprasTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.ResumenCompras,VariablesGlobales.nIdEmpresaActual);
         
            if (Filtro == 1)
            {
                ResumenComprasBindingSource.Filter = null;
            }
            if (Filtro == 2)
            {
                ResumenComprasBindingSource.Filter = "Pagada=false";
            }
            if (Filtro == 3)
            {
                DataRowView EmpresaActual = (DataRowView)EmpresasActualBindingSource.Current;
                byte MesEmpresa = Convert.ToByte(EmpresaActual["MesEmpresa"]);
                int AnoEmpresa = Convert.ToInt32(EmpresaActual["AnoEmpresa"]);
                DateTime fechaini = new DateTime(AnoEmpresa, MesEmpresa, 1);
                DateTime fechafin = new DateTime(AnoEmpresa, MesEmpresa, DateTime.DaysInMonth(AnoEmpresa, MesEmpresa));
                string Filtro1 = "FechaPago>='" + fechaini.ToShortDateString() + "' and FechaPago<='" + fechafin.ToShortDateString() + "'";
                ResumenComprasBindingSource.Filter = Filtro1;
            }
            
            this.reportViewer1.RefreshReport();
        }
       
    }
}
