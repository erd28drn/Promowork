using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Promowork
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Trabajadores"] != null)
            {
                Application.OpenForms["Trabajadores"].Activate();
            }
            else
            {
                Trabajadores frm = new Trabajadores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosAccesos.AccesosOpciones' Puede moverla o quitarla según sea necesario.
            this.accesosOpcionesTableAdapter.FillByUsuario(this.datosAccesos.AccesosOpciones, VariablesGlobales.nIdUsuarioActual);
            // TODO: esta línea de código carga datos en la tabla 'datosAccesos.OpcionesMenu' Puede moverla o quitarla según sea necesario.
            this.opcionesMenuTableAdapter.Fill(this.datosAccesos.OpcionesMenu);

           

            //LO MEJOR SERIA RECORRER LA TABLA Y ESTABLECER LA PROPIEDAD ENABLED DE ACUERDO AL NOMBRE DEL OBJETO DE MENU.

            
            
            foreach (ToolStripMenuItem item1 in MenuPrincipal.Items)
            {
                     
                item1.Enabled = (bool) queriesTableAdapter1.AccesoOpcionUsuario(VariablesGlobales.nIdUsuarioActual, item1.Name);

                if (item1.HasDropDownItems)
                {
                    foreach (ToolStripDropDownItem item2 in item1.DropDownItems)
                    {
                        item2.Enabled = (bool)queriesTableAdapter1.AccesoOpcionUsuario(VariablesGlobales.nIdUsuarioActual, item2.Name);
                        if (item2.HasDropDownItems)
                        {
                            foreach (ToolStripDropDownItem item3 in item2.DropDownItems)
                            {
                                item3.Enabled = (bool)queriesTableAdapter1.AccesoOpcionUsuario(VariablesGlobales.nIdUsuarioActual, item3.Name);
                            }
                        }


                    }
                }

            }
            
            
            
           // OpcionesMenu();
       

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.FillByUsuarioActual(this.promowork_dataDataSet.Usuarios,VariablesGlobales.nIdUsuarioActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Empresas, VariablesGlobales.nIdEmpresaActual);
            //toolStrip1.Items["toolStripLabel1"].Text = Convert.ToString(promowork_dataDataSet.Tables["Empresas"].Rows[0]["DesEmpresa"]);
            toolStrip1.Items["toolStripTextbox1"].Text = Convert.ToString(promowork_dataDataSet.Tables["Empresas"].Rows[0]["DesEmpresa"]);
            toolStrip1.Items["toolStripTextbox2"].Text = Convert.ToString(VariablesGlobales.nMesActual);
            toolStrip1.Items["toolStripTextbox3"].Text = Convert.ToString(VariablesGlobales.nAnoActual);
           // toolStrip1.Items["toolStripTextbox4"].Text = Convert.ToString(promowork_dataDataSet.Tables["Usuarios"].Rows[0]["NomUsuario"]);
            statusStrip1.Items["toolStripStatusLabel3"].Text = "Usuario: "+Convert.ToString(promowork_dataDataSet.Tables["Usuarios"].Rows[0]["NomUsuario"]);

            this.Text =Convert.ToString(promowork_dataDataSet.Tables["Empresas"].Rows[0]["DesEmpresa"]) +" - Gestión de Obras";

            try
            {

                this.BackgroundImage = new Bitmap(Convert.ToString(promowork_dataDataSet.Tables["Usuarios"].Rows[0]["ImageFondo"]));

            }

            catch
            {

                this.BackgroundImage = null;

            }

            
            
        }

        private void OpcionesMenu()
        { 
       
            int menu = 1;
                        int submenu ;
                        int detalle ;

                        foreach (ToolStripMenuItem item1 in MenuPrincipal.Items)
                        {
                            submenu = 0;
                            detalle = 0;
                            opcionesMenuTableAdapter.Insert(item1.Text, item1.Name, 0, menu, submenu, detalle);
                            if (item1.HasDropDownItems)
                            {
                                foreach (ToolStripDropDownItem item2 in item1.DropDownItems)
                                {
                                    detalle = 0;
                                    opcionesMenuTableAdapter.Insert("     "+item2.Text, item2.Name, 1, menu, submenu, detalle);

                                    if (item2.HasDropDownItems)
                                    {
                                        foreach (ToolStripDropDownItem item3 in item2.DropDownItems)
                                        {
                                            opcionesMenuTableAdapter.Insert("          "+item3.Text, item3.Name, 2, menu, submenu, detalle);
                                        }
                                        detalle += 1;

                                    }
                                    submenu += 1;
                                }

                                menu += 1;

                            }



                        }
        
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                EntradaSistema frm = new EntradaSistema();
                frm.ShowDialog();
                Principal_Load(null, null);
            }
            else
            {
                if (MessageBox.Show("Existen Ventanas Abiertas. ¿Desea Cerrarlas?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (Form f in this.MdiChildren)
                    {
                      //  MessageBox.Show(f.Name);
                        f.Close();
                    }
                    cambiarDeUsuarioToolStripMenuItem_Click(null, null);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Empresas"] != null)
            {
                Application.OpenForms["Empresas"].Activate();
            }
            else
            {
                Empresas frm = new Empresas();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Usuarios"] != null)
            {
                Application.OpenForms["Usuarios"].Activate();
            }
            else
            {
                Usuarios frm = new Usuarios();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Clientes"] != null)
            {
                Application.OpenForms["Clientes"].Activate();
            }
            else
            {
              Clientes frm = new Clientes();
              frm.MdiParent = this;
              frm.Show();
            }
    
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Proveedores"] != null)
            {
                Application.OpenForms["Proveedores"].Activate();
            }
            else
            {
                Proveedores frm = new Proveedores();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void obrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Obras"] != null)
            {
                Application.OpenForms["Obras"].Activate();
            }
            else
            {
                Obras frm = new Obras();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void horasTrabajadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HorasCruce"] != null)
            {
                Application.OpenForms["HorasCruce"].Activate();
            }
            else
            {
                HorasCruces frm = new HorasCruces();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Compras"] != null)
            {
                Application.OpenForms["Compras"].Activate();
            }
            else
            {
                Compras frm = new Compras();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAlbaranes"] != null)
            {
                Application.OpenForms["frmAlbaranes"].Activate();
            }
            else
            {
                frmAlbaranes frm = new frmAlbaranes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            statusStrip1.Items["toolStripStatusLabel1"].Text = "Fecha: "+Convert.ToString(DateTime.Now.ToShortDateString());
            
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Categorias"] != null)
            {
                Application.OpenForms["Categorias"].Activate();
            }
            else
            {
                Categorias frm = new Categorias();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void formasDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormasPago"] != null)
            {
                Application.OpenForms["FormasPago"].Activate();
            }
            else
            {
                FormasPago frm = new FormasPago();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tiposDeContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ContratosTrabajadores"] != null)
            {
                Application.OpenForms["ContratosTrabajadores"].Activate();
            }
            else
            {
                ContratosTrabajadores frm = new ContratosTrabajadores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void estadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["EstadoCivil"] != null)
            {
                Application.OpenForms["EstadoCivil"].Activate();
            }
            else
            {
                EstadoCivil frm = new EstadoCivil();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tiposDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Tipos"] != null)
            {
                Application.OpenForms["Tipos"].Activate();
            }
            else
            {
                Tipos frm = new Tipos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Cursos"] != null)
            {
                Application.OpenForms["Cursos"].Activate();
            }
            else
            {
                Cursos frm = new Cursos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tiposDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TiposProveedores"] != null)
            {
                Application.OpenForms["TiposProveedores"].Activate();
            }
            else
            {
                TiposProveedores frm = new TiposProveedores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bancosYCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BancosCuentas"] != null)
            {
                Application.OpenForms["BancosCuentas"].Activate();
            }
            else
            {
                BancosCuentas frm = new BancosCuentas();
                frm.MdiParent = this;
                frm.Show();
            }
        }

       

        private void poblacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Poblaciones"] != null)
            {
                Application.OpenForms["Poblaciones"].Activate();
            }
            else
            {
                Poblaciones frm = new Poblaciones();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AnticiposTrabajadores"] != null)
            {
                Application.OpenForms["AnticiposTrabajadores"].Activate();
            }
            else
            {
                AnticiposTrabajadores frm = new AnticiposTrabajadores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void conceptosDeAnticiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Anticipos"] != null)
            {
                Application.OpenForms["Anticipos"].Activate();
            }
            else
            {
                Anticipos frm = new Anticipos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Nacionalidades"] != null)
            {
                Application.OpenForms["Nacionalidades"].Activate();
            }
            else
            {
                Nacionalidades frm = new Nacionalidades();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2_Click(null, null);
        }

       private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SeguridadSocial"] != null)
            {
                Application.OpenForms["SeguridadSocial"].Activate();
            }
            else
            {
                SeguridadSocial frm = new SeguridadSocial();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3_Click(null, null);
            
        }

        private void salarioYSeguridadSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptParametrosResumenTrabajadoress frm = new RptParametrosResumenTrabajadoress();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salarioYComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptParametrosResumenObras frm = new RptParametrosResumenObras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptParametrosSalarioTrabajadores frm = new RptParametrosSalarioTrabajadores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void seguridadSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptAnticiposTrabajadores frm = new RptAnticiposTrabajadores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void horasYSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptSalarioObras frm = new RptSalarioObras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filtro = 1;

            RptResumenCompras frm = new RptResumenCompras();
            frm.LoadFiltro(filtro);
            frm.MdiParent = this;
            frm.Show();
        }

        private void pendientesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filtro = 2;

            RptResumenCompras frm = new RptResumenCompras();
            frm.LoadFiltro(filtro);
            frm.MdiParent = this;
            frm.Show();
        }

        private void previstoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filtro = 3;

            RptResumenCompras frm = new RptResumenCompras();
            frm.LoadFiltro(filtro);
            frm.MdiParent = this;
            frm.Show();
        }

       private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptResumenPagos frm = new RptResumenPagos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void seguridadSocialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RptSeguridadSocial frm = new RptSeguridadSocial();
            frm.MdiParent = this;
            frm.Show();
        }

        private void facturasPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmFacturasPresupuestos"] != null)
            {
                Application.OpenForms["frmFacturasPresupuestos"].Activate();
            }
            else
            {
                frmFacturasPresupuestos frm = new frmFacturasPresupuestos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosComprasBanco"] != null)
            {
                Application.OpenForms["RptParametrosComprasBanco"].Activate();
            }
            else
            {
                RptParametrosComprasBanco frm = new RptParametrosComprasBanco();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosComprasProveedores"] != null)
            {
                Application.OpenForms["RptParametrosComprasProveedores"].Activate();
            }
            else
            {
                RptParametrosComprasProveedores frm = new RptParametrosComprasProveedores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            int filtro = 1;

            RptResumenCompras frm = new RptResumenCompras();
            frm.LoadFiltro(filtro);
            frm.MdiParent = this;
            frm.Show();
        }

        private void fichaTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosFichaTrabajador"] != null)
            {
                Application.OpenForms["RptParametrosFichaTrabajador"].Activate();
            }
            else
            {
                RptParametrosFichaTrabajador frm = new RptParametrosFichaTrabajador();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void obraCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosObraCompleta"] != null)
            {
                Application.OpenForms["RptParametrosObraCompleta"].Activate();
            }
            else
            {
                RptParametrosObraCompleta frm = new RptParametrosObraCompleta();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void obrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptHojaTrabajadores"] != null)
            {
                Application.OpenForms["RptHojaTrabajadores"].Activate();
            }
            else
            {
                RptHojaTrabajadores frm = new RptHojaTrabajadores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cruceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptHojaTrabajadoresCruce"] != null)
            {
                Application.OpenForms["RptHojaTrabajadoresCruce"].Activate();
            }
            else
            {
                RptHojaTrabajadoresCruce frm = new RptHojaTrabajadoresCruce();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BajasMedica"] != null)
            {
                Application.OpenForms["BajasMedica"].Activate();
            }
            else
            {
                BajasMedica frm = new BajasMedica();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalvaRestaura"] != null)
            {
                Application.OpenForms["SalvaRestaura"].Activate();
            }
            else
            {
                SalvaRestaura frm = new SalvaRestaura();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cambiarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {  
                promowork_dataDataSet.Tables["Usuarios"].Rows[0]["ImageFondo"] = openFileDialog1.FileName;
                this.Validate();
                usuariosBindingSource.EndEdit();
                usuariosTableAdapter.Update(promowork_dataDataSet.Usuarios);
                this.BackgroundImage = new Bitmap(openFileDialog1.FileName);
               
            }

            catch
            {

                this.BackgroundImage = null;

            }
            
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCobros"] != null)
            {
                Application.OpenForms["frmCobros"].Activate();
            }
            else
            {
                frmCobros frm = new frmCobros();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HorasAdmin"] != null)
            {
                Application.OpenForms["HorasAdmin"].Activate();
            }
            else
            {
                HorasAdmin frm = new HorasAdmin();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void obraCompletaHorasAdministraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosObraCompletaAdmin"] != null)
            {
                Application.OpenForms["RptParametrosObraCompletaAdmin"].Activate();
            }
            else
            {
                RptParametrosObraCompletaAdmin frm = new RptParametrosObraCompletaAdmin();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void horasTrabajadasPorDíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosHorasTrabajadasDias"] != null)
            {
                Application.OpenForms["RptParametrosHorasTrabajadasDias"].Activate();
            }
            else
            {
                RptParametrosHorasTrabajadasDias frm = new RptParametrosHorasTrabajadasDias();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tiposDeCombustiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TiposCombustibles"] != null)
            {
                Application.OpenForms["TiposCombustibles"].Activate();
            }
            else
            {
                TiposServicios frm = new TiposServicios();
                frm.MdiParent = this;
                frm.Show();
            }
        }

       
        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Vehiculos"] != null)
            {
                Application.OpenForms["Vehiculos"].Activate();
            }
            else
            {
                VehiculosNotificaciones frm = new VehiculosNotificaciones();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void consumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ConsumosServiciosVehiculos"] != null)
            {
                Application.OpenForms["ConsumosServiciosVehiculos"].Activate();
            }
            else
            {
                ConsumosServiciosVehiculos frm = new ConsumosServiciosVehiculos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TiposCombustibles"] != null)
            {
                Application.OpenForms["TiposCombustibles"].Activate();
            }
            else
            {
                TiposCombustibles frm = new TiposCombustibles();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ConsumosCombustibleVehiculos"] != null)
            {
                Application.OpenForms["ConsumosCombustibleVehiculos"].Activate();
            }
            else
            {
                ConsumosCombustibleVehiculos frm = new ConsumosCombustibleVehiculos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["EntradasCombustible"] != null)
            {
                Application.OpenForms["EntradasCombustible"].Activate();
            }
            else
            {
                EntradasCombustible frm = new EntradasCombustible();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void consumoDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosResumenConsumoCombustible"] != null)
            {
                Application.OpenForms["RptParametrosResumenConsumoCombustible"].Activate();
            }
            else
            {
                RptParametrosResumenConsumoCombustible frm = new RptParametrosResumenConsumoCombustible();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void diferenciasDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptDiferenciasLitros"] != null)
            {
                Application.OpenForms["RptDiferenciasLitros"].Activate();
            }
            else
            {
                RptDiferenciasLitros frm = new RptDiferenciasLitros();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FacturasManuales"] != null)
            {
                Application.OpenForms["FacturasManuales"].Activate();
            }
            else
            {
                FacturasManuales frm = new FacturasManuales();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void resumenFcaturasPorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosFacturasClientes"] != null)
            {
                Application.OpenForms["RptParametrosFacturasClientes"].Activate();
            }
            else
            {
                RptParametrosFacturasClientes frm = new RptParametrosFacturasClientes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void resumenCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosCobrosClientes"] != null)
            {
                Application.OpenForms["RptParametrosCobrosClientes"].Activate();
            }
            else
            {
                RptParametrosCobrosClientes frm = new RptParametrosCobrosClientes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Productos"] != null)
            {
                Application.OpenForms["Productos"].Activate();
            }
            else
            {
                Productos frm = new Productos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void unidadesDeMedidaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["UnidadesMedidas"] != null)
            {
                Application.OpenForms["UnidadesMedidas"].Activate();
            }
            else
            {
                UnidadesMedidas frm = new UnidadesMedidas();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HorasMateriales"] != null)
            {
                Application.OpenForms["HorasMateriales"].Activate();
            }
            else
            {
                HorasMateriales frm = new HorasMateriales();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length != 0)
            {
                if (MessageBox.Show("Existen Ventanas Abiertas. Pueden perderse los cambios que no haya guardado. ¿Desea salir de todos modos?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (MessageBox.Show("Realmente desea Cerrar el Programa?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
           
        }

        private void accesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Accesos"] != null)
            {
                Application.OpenForms["Accesos"].Activate();
            }
            else
            {
                Accesos frm = new Accesos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //private void toolStripButton4_Paint(object sender, PaintEventArgs e)
        //{
        //    toolStripButton4.Enabled = Convert.ToBoolean(promowork_dataDataSet.Tables["Usuarios"].Rows[0]["AdminUsuario"]) == true ? true : false;
        //}

        //private void toolStripButton3_Paint(object sender, PaintEventArgs e)
        //{
        //    toolStripButton3.Enabled = Convert.ToBoolean(promowork_dataDataSet.Tables["Usuarios"].Rows[0]["AdminUsuario"]) == true ? true : false;
        //}

        //private void usuariosToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        //{
        //    usuariosToolStripMenuItem.Enabled = Convert.ToBoolean(promowork_dataDataSet.Tables["Usuarios"].Rows[0]["AdminUsuario"]) == true ? true : false;
        //}

        //private void accesosToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        //{
        //    accesosToolStripMenuItem.Enabled = Convert.ToBoolean(promowork_dataDataSet.Tables["Usuarios"].Rows[0]["AdminUsuario"]) == true ? true : false;
        //}

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FacturasHorasMateriales"] != null)
            {
                Application.OpenForms["FacturasHorasMateriales"].Activate();
            }
            else
            {
                FacturasHorasMateriales frm = new FacturasHorasMateriales();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OperacionesBanco"] != null)
            {
                Application.OpenForms["OperacionesBanco"].Activate();
            }
            else
            {
                OperacionesBanco frm = new OperacionesBanco();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void conceptosOperacionesBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ConceptosBanco"] != null)
            {
                Application.OpenForms["ConceptosBanco"].Activate();
            }
            else
            {
                ConceptosBanco frm = new ConceptosBanco();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void porConceptosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosOperacionesBanco"] != null)
            {
                Application.OpenForms["RptParametrosOperacionesBanco"].Activate();
            }
            else
            {
                RptParametrosOperacionesBanco frm = new RptParametrosOperacionesBanco();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void porConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosOperacionesBancoFecha"] != null)
            {
                Application.OpenForms["RptParametrosOperacionesBancoFecha"].Activate();
            }
            else
            {
                RptParametrosOperacionesBancoFecha frm = new RptParametrosOperacionesBancoFecha();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void pendienteDeFcaturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosPendienteFacturar"] != null)
            {
                Application.OpenForms["RptParametrosPendienteFacturar"].Activate();
            }
            else
            {
                RptParametrosPendienteFacturar frm = new RptParametrosPendienteFacturar();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosSalarioExtraTrabajadores"] != null)
            {
                Application.OpenForms["RptParametrosSalarioExtraTrabajadores"].Activate();
            }
            else
            {
                RptParametrosSalarioExtraTrabajadores frm = new RptParametrosSalarioExtraTrabajadores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void horasTrabajadasPorObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosObrasVenta"] != null)
            {
                Application.OpenForms["RptParametrosObrasVenta"].Activate();
            }
            else
            {
                RptParametrosObrasVenta frm = new RptParametrosObrasVenta();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Fabricantes"] != null)
            {
                Application.OpenForms["Fabricantes"].Activate();
            }
            else
            {
                Fabricantes frm = new Fabricantes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void gruposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GruposProductos"] != null)
            {
                Application.OpenForms["GruposProductos"].Activate();
            }
            else
            {
                GruposProductos frm = new GruposProductos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void facturasEmitidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptParametrosListadoFacturasEmitidas"] != null)
            {
                Application.OpenForms["RptParametrosListadoFacturasEmitidas"].Activate();
            }
            else
            {
                RptParametrosListadoFacturasEmitidas frm = new RptParametrosListadoFacturasEmitidas();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem17_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPresupuestoTabla"] != null)
            {
                Application.OpenForms["frmPresupuestoTabla"].Activate();
            }
            else
            {
                frmPresupuestoTabla frm = new frmPresupuestoTabla();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void beneficioDeObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmrptResumenTotalesObras"] != null)
            {
                Application.OpenForms["frmrptResumenTotalesObras"].Activate();
            }
            else
            {
                frmrptResumenTotalesObras frm = new frmrptResumenTotalesObras();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AccesosOpcionesMenu"] != null)
            {
                Application.OpenForms["AccesosOpcionesMenu"].Activate();
            }
            else
            {
                AccesosOpcionesMenu frm = new AccesosOpcionesMenu();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripButton16_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton16.Enabled = toolStripMenuItem8.Enabled;
        }

        private void toolStripButton1_Paint(object sender, PaintEventArgs e)
        {
           toolStripButton1.Enabled = cambiarDeUsuarioToolStripMenuItem.Enabled;
        }

        private void toolStripButton2_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton2.Enabled = toolStripMenuItem1.Enabled;
        }

        private void toolStripButton3_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton3.Enabled = usuariosToolStripMenuItem.Enabled;
        }

        private void toolStripButton4_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton4.Enabled = accesosToolStripMenuItem.Enabled;
        }

        private void toolStripButton5_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton5.Enabled = trabajadoresToolStripMenuItem.Enabled;
        }

        private void toolStripButton6_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton6.Enabled = clientesToolStripMenuItem.Enabled;
        }

        private void toolStripButton10_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton10.Enabled = proveedoresToolStripMenuItem.Enabled;
        }

        private void toolStripButton11_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton11.Enabled = obrasToolStripMenuItem.Enabled;
        }

        private void toolStripButton7_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton7.Enabled = horasTrabajadasToolStripMenuItem.Enabled;
        }

        private void toolStripButton18_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton18.Enabled = toolStripMenuItem9.Enabled;
        }

        private void toolStripButton19_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton19.Enabled = toolStripMenuItem15.Enabled;
        }

        private void toolStripButton12_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton12.Enabled = toolStripMenuItem2.Enabled;
        }

        private void toolStripButton13_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton13.Enabled = toolStripMenuItem3.Enabled;
        }

        private void toolStripButton15_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton15.Enabled = toolStripMenuItem7.Enabled;
        }

        private void toolStripButton8_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton8.Enabled = comprasToolStripMenuItem.Enabled;
        }

        private void toolStripButton9_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton9.Enabled = presupuestosToolStripMenuItem.Enabled;
        }

        private void toolStripButton14_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton14.Enabled = facturasPresupuestoToolStripMenuItem.Enabled;
        }

        private void toolStripButton17_Paint(object sender, PaintEventArgs e)
        {
            toolStripButton17.Enabled = cobrosToolStripMenuItem.Enabled;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RevisionHorasTrabajadores"] != null)
            {
                Application.OpenForms["RevisionHorasTrabajadores"].Activate();
            }
            else
            {
                RevisionHorasTrabajadores frm = new RevisionHorasTrabajadores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmrptAgenda"] != null)
            {
                Application.OpenForms["frmrptAgenda"].Activate();
            }
            else
            {
                frmrptAgenda frm = new frmrptAgenda();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void conversionesUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmConversionesUM"] != null)
            {
                Application.OpenForms["frmConversionesUM"].Activate();
            }
            else
            {
                frmConversionesUM frm = new frmConversionesUM();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripButton2_Paint_1(object sender, PaintEventArgs e)
        {
            toolStripButton2.Enabled = toolStripMenuItem1.Enabled;
        }

        private void toolStripButton3_Paint_1(object sender, PaintEventArgs e)
        {
            toolStripButton3.Enabled = usuariosToolStripMenuItem.Enabled;
        }

        private void toolStripButton4_Paint_1(object sender, PaintEventArgs e)
        {
            toolStripButton4.Enabled = accesosToolStripMenuItem.Enabled;
        }

       
        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCompras"] != null)
            {
                Application.OpenForms["frmCompras"].Activate();
            }
            else
            {
                frmCompras frm = new frmCompras();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        public bool isEnableRptObraCompleta()
        {
            return obraCompletaToolStripMenuItem.Enabled;
        }

       
       
    }
}
