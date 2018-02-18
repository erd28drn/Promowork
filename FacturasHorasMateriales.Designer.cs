namespace Promowork
{
    partial class FacturasHorasMateriales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label desFormaPagoLabel;
            System.Windows.Forms.Label impBaseLabel;
            System.Windows.Forms.Label impIVALabel;
            System.Windows.Forms.Label fechaExpLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label obsFactura2Label;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idPresupLabel;
            System.Windows.Forms.Label numFacturaLabel;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label fechaVctoFactLabel;
            System.Windows.Forms.Label idCuentaLabel;
            System.Windows.Forms.Label certificacionLabel;
            System.Windows.Forms.Label iVAFacturaLabel;
            System.Windows.Forms.Label descFacuraLabel;
            System.Windows.Forms.Label importeLabel1;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label descProntoLabel;
            System.Windows.Forms.Label retencionLabel;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label mostrarVctoLabel;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label obsFacturaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label copiaFacturaLabel;
            System.Windows.Forms.Label anticipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasHorasMateriales));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colEntregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCobrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.facturasCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.obrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet1 = new Promowork.Promowork_dataDataSet();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anosFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.importeFacturaHorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.facturasCabTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FacturasCabTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ClientesTableAdapter();
            this.cuentasBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter();
            this.obrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ObrasTableAdapter();
            this.horasTrabajadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horasTrabajadasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.HorasTrabajadasTableAdapter();
            this.empresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.vFacturaDetHorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vFacturaDetHorasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vFacturaDetHorasTableAdapter();
            this.vHorasTrabajadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vHorasTrabajadasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vHorasTrabajadasTableAdapter();
            this.colIdHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHoras1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vProductosUtilizadosGridControl = new DevExpress.XtraGrid.GridControl();
            this.productosUtilizadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProdUtiliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHoras2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHorasAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPVP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorciento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuentoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vFacturaDetHorasGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdFactDetHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaTrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesTrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnoTrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApeTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalarioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFestivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaParte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuentoHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.vHorasTrabajadasGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDiaTrab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesTrab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnoTrab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantAdmin1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalarioVenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesTrabajo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirTrabajo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesTipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCategoria1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumTrabajador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomTrabajador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApeTrabajador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHoras3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrabajador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFestivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaParte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.queriesTableAdapter1 = new Promowork.Promowork_dataDataSetTableAdapters.QueriesTableAdapter();
            this.productosUtilizadosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ProductosUtilizadosTableAdapter();
            this.productosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ProductosTableAdapter();
            this.productosUtilizadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.importeFacturaHorasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ImporteFacturaHorasTableAdapter();
            this.formasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formasPagoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter();
            this.desFormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.cobrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobrosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CobrosTableAdapter();
            this.impBaseTextBox = new System.Windows.Forms.TextBox();
            this.impIVATextBox = new System.Windows.Forms.TextBox();
            this.fechaExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cuentasBancosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.descuentosFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descuentosFacturasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.DescuentosFacturasTableAdapter();
            this.descuentosFacturasGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDesFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.anosFacturasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.AnosFacturasTableAdapter();
            this.obsFactura2TextBox = new System.Windows.Forms.TextBox();
            this.facturaIncorrectaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaIncorrectaTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FacturaIncorrectaTableAdapter();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.obsFacturaTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.idPresupComboBox = new System.Windows.Forms.ComboBox();
            this.numFacturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaVctoFactDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.certificacionTextBox = new System.Windows.Forms.TextBox();
            this.iVAFacturaTextBox = new System.Windows.Forms.TextBox();
            this.descFacuraTextBox = new System.Windows.Forms.TextBox();
            this.importeTextBox1 = new System.Windows.Forms.TextBox();
            this.facturasCabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.facturasCabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.descProntoTextBox = new System.Windows.Forms.TextBox();
            this.retencionTextBox = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.mostrarVctoCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.copiaFacturaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.facturaCheckBox = new System.Windows.Forms.CheckBox();
            this.entregadaCheckBox = new System.Windows.Forms.CheckBox();
            this.noDetalleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cbxanos = new System.Windows.Forms.ComboBox();
            this.cbxfacturas = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.facturasCabGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactCab2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIdPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIdClienteFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClienteFactura = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpCobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVctoFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCertificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVAFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescPronto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMostrarVcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsFactura2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMostrarSubTot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.anticipoTextBox = new System.Windows.Forms.TextBox();
            this.esPrevisionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.chkSubTot = new DevExpress.XtraEditors.CheckEdit();
            this.txtSerieFact = new System.Windows.Forms.TextBox();
            this.chkMostrarObra = new DevExpress.XtraEditors.CheckEdit();
            this.vPrecioHorasFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPrecioHorasFacturasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vPrecioHorasFacturasTableAdapter();
            this.vPrecioHorasFacturasGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalarioVenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCategoria2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesTipo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.TiposTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.unificarMaterialCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            desFormaPagoLabel = new System.Windows.Forms.Label();
            impBaseLabel = new System.Windows.Forms.Label();
            impIVALabel = new System.Windows.Forms.Label();
            fechaExpLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            obsFactura2Label = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idPresupLabel = new System.Windows.Forms.Label();
            numFacturaLabel = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            fechaVctoFactLabel = new System.Windows.Forms.Label();
            idCuentaLabel = new System.Windows.Forms.Label();
            certificacionLabel = new System.Windows.Forms.Label();
            iVAFacturaLabel = new System.Windows.Forms.Label();
            descFacuraLabel = new System.Windows.Forms.Label();
            importeLabel1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            descProntoLabel = new System.Windows.Forms.Label();
            retencionLabel = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            mostrarVctoLabel = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            obsFacturaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            copiaFacturaLabel = new System.Windows.Forms.Label();
            anticipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anosFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importeFacturaHorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasTrabajadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFacturaDetHorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vHorasTrabajadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductosUtilizadosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosUtilizadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFacturaDetHorasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vHorasTrabajadasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosUtilizadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentosFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentosFacturasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaIncorrectaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsFacturaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingNavigator)).BeginInit();
            this.facturasCabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noDetalleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esPrevisionCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubTot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarObra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrecioHorasFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrecioHorasFacturasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unificarMaterialCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.SuspendLayout();
            // 
            // desFormaPagoLabel
            // 
            desFormaPagoLabel.AutoSize = true;
            desFormaPagoLabel.Location = new System.Drawing.Point(12, 333);
            desFormaPagoLabel.Name = "desFormaPagoLabel";
            desFormaPagoLabel.Size = new System.Drawing.Size(67, 13);
            desFormaPagoLabel.TabIndex = 116;
            desFormaPagoLabel.Text = "Forma Pago:";
            // 
            // impBaseLabel
            // 
            impBaseLabel.AutoSize = true;
            impBaseLabel.Location = new System.Drawing.Point(265, 361);
            impBaseLabel.Name = "impBaseLabel";
            impBaseLabel.Size = new System.Drawing.Size(57, 13);
            impBaseLabel.TabIndex = 117;
            impBaseLabel.Text = "Imp. Base:";
            // 
            // impIVALabel
            // 
            impIVALabel.AutoSize = true;
            impIVALabel.Location = new System.Drawing.Point(432, 361);
            impIVALabel.Name = "impIVALabel";
            impIVALabel.Size = new System.Drawing.Size(50, 13);
            impIVALabel.TabIndex = 120;
            impIVALabel.Text = "Imp. IVA:";
            // 
            // fechaExpLabel
            // 
            fechaExpLabel.AutoSize = true;
            fechaExpLabel.Location = new System.Drawing.Point(37, 360);
            fechaExpLabel.Name = "fechaExpLabel";
            fechaExpLabel.Size = new System.Drawing.Size(40, 13);
            fechaExpLabel.TabIndex = 122;
            fechaExpLabel.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(273, 333);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 13);
            label3.TabIndex = 112;
            label3.Text = "Cuenta:";
            // 
            // obsFactura2Label
            // 
            obsFactura2Label.AutoSize = true;
            obsFactura2Label.Location = new System.Drawing.Point(7, 9);
            obsFactura2Label.Name = "obsFactura2Label";
            obsFactura2Label.Size = new System.Drawing.Size(53, 13);
            obsFactura2Label.TabIndex = 124;
            obsFactura2Label.Text = "Observ 2:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(23, 58);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(42, 13);
            idClienteLabel.TabIndex = 4;
            idClienteLabel.Text = "Cliente:";
            // 
            // idPresupLabel
            // 
            idPresupLabel.AutoSize = true;
            idPresupLabel.Location = new System.Drawing.Point(32, 102);
            idPresupLabel.Name = "idPresupLabel";
            idPresupLabel.Size = new System.Drawing.Size(33, 13);
            idPresupLabel.TabIndex = 6;
            idPresupLabel.Text = "Obra:";
            // 
            // numFacturaLabel
            // 
            numFacturaLabel.AutoSize = true;
            numFacturaLabel.Location = new System.Drawing.Point(18, 37);
            numFacturaLabel.Name = "numFacturaLabel";
            numFacturaLabel.Size = new System.Drawing.Size(47, 13);
            numFacturaLabel.TabIndex = 8;
            numFacturaLabel.Text = "Número:";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(25, 146);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(40, 13);
            fechaFacturaLabel.TabIndex = 10;
            fechaFacturaLabel.Text = "Fecha:";
            // 
            // fechaVctoFactLabel
            // 
            fechaVctoFactLabel.AutoSize = true;
            fechaVctoFactLabel.Location = new System.Drawing.Point(183, 146);
            fechaVctoFactLabel.Name = "fechaVctoFactLabel";
            fechaVctoFactLabel.Size = new System.Drawing.Size(65, 13);
            fechaVctoFactLabel.TabIndex = 12;
            fechaVctoFactLabel.Text = "Fecha Vcto:";
            // 
            // idCuentaLabel
            // 
            idCuentaLabel.AutoSize = true;
            idCuentaLabel.Location = new System.Drawing.Point(21, 124);
            idCuentaLabel.Name = "idCuentaLabel";
            idCuentaLabel.Size = new System.Drawing.Size(44, 13);
            idCuentaLabel.TabIndex = 14;
            idCuentaLabel.Text = "Cuenta:";
            // 
            // certificacionLabel
            // 
            certificacionLabel.AutoSize = true;
            certificacionLabel.Location = new System.Drawing.Point(50, 168);
            certificacionLabel.Name = "certificacionLabel";
            certificacionLabel.Size = new System.Drawing.Size(68, 13);
            certificacionLabel.TabIndex = 16;
            certificacionLabel.Text = "Certificación:";
            // 
            // iVAFacturaLabel
            // 
            iVAFacturaLabel.AutoSize = true;
            iVAFacturaLabel.Location = new System.Drawing.Point(256, 190);
            iVAFacturaLabel.Name = "iVAFacturaLabel";
            iVAFacturaLabel.Size = new System.Drawing.Size(41, 13);
            iVAFacturaLabel.TabIndex = 18;
            iVAFacturaLabel.Text = "IVA(%):";
            // 
            // descFacuraLabel
            // 
            descFacuraLabel.AutoSize = true;
            descFacuraLabel.Location = new System.Drawing.Point(39, 190);
            descFacuraLabel.Name = "descFacuraLabel";
            descFacuraLabel.Size = new System.Drawing.Size(79, 13);
            descFacuraLabel.TabIndex = 20;
            descFacuraLabel.Text = "Desc. Com.(%):";
            // 
            // importeLabel1
            // 
            importeLabel1.AutoSize = true;
            importeLabel1.Location = new System.Drawing.Point(510, 39);
            importeLabel1.Name = "importeLabel1";
            importeLabel1.Size = new System.Drawing.Size(57, 13);
            importeLabel1.TabIndex = 75;
            importeLabel1.Text = "Imp. Base:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(517, 126);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(50, 13);
            label13.TabIndex = 81;
            label13.Text = "Imp. IVA:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(465, 60);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(102, 13);
            label14.TabIndex = 83;
            label14.Text = "Imp. Dto. Comercial:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(490, 192);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(77, 13);
            label18.TabIndex = 85;
            label18.Text = "Total a Cobrar:";
            // 
            // descProntoLabel
            // 
            descProntoLabel.AutoSize = true;
            descProntoLabel.Location = new System.Drawing.Point(25, 212);
            descProntoLabel.Name = "descProntoLabel";
            descProntoLabel.Size = new System.Drawing.Size(93, 13);
            descProntoLabel.TabIndex = 90;
            descProntoLabel.Text = "Desc. P. Pago(%):";
            // 
            // retencionLabel
            // 
            retencionLabel.AutoSize = true;
            retencionLabel.Location = new System.Drawing.Point(224, 212);
            retencionLabel.Name = "retencionLabel";
            retencionLabel.Size = new System.Drawing.Size(73, 13);
            retencionLabel.TabIndex = 91;
            retencionLabel.Text = "Retencion(%):";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(452, 82);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(115, 13);
            label21.TabIndex = 93;
            label21.Text = "Imp. Dto. Pronto Pago:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(485, 170);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(82, 13);
            label23.TabIndex = 95;
            label23.Text = "Imp. Retención:";
            // 
            // mostrarVctoLabel
            // 
            mostrarVctoLabel.AutoSize = true;
            mostrarVctoLabel.Location = new System.Drawing.Point(258, 168);
            mostrarVctoLabel.Name = "mostrarVctoLabel";
            mostrarVctoLabel.Size = new System.Drawing.Size(70, 13);
            mostrarVctoLabel.TabIndex = 96;
            mostrarVctoLabel.Text = "Mostrar Vcto:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(469, 104);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(97, 13);
            label24.TabIndex = 98;
            label24.Text = "Base con Desctos:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(494, 148);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(73, 13);
            label25.TabIndex = 100;
            label25.Text = "Total Factura:";
            // 
            // obsFacturaLabel
            // 
            obsFacturaLabel.AutoSize = true;
            obsFacturaLabel.Location = new System.Drawing.Point(365, 212);
            obsFacturaLabel.Name = "obsFacturaLabel";
            obsFacturaLabel.Size = new System.Drawing.Size(44, 13);
            obsFacturaLabel.TabIndex = 101;
            obsFacturaLabel.Text = "Observ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 79);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 104;
            label1.Text = "Facturar a:";
            // 
            // copiaFacturaLabel
            // 
            copiaFacturaLabel.AutoSize = true;
            copiaFacturaLabel.Location = new System.Drawing.Point(28, 260);
            copiaFacturaLabel.Name = "copiaFacturaLabel";
            copiaFacturaLabel.Size = new System.Drawing.Size(37, 13);
            copiaFacturaLabel.TabIndex = 107;
            copiaFacturaLabel.Text = "Copia:";
            // 
            // anticipoLabel
            // 
            anticipoLabel.AutoSize = true;
            anticipoLabel.Location = new System.Drawing.Point(249, 234);
            anticipoLabel.Name = "anticipoLabel";
            anticipoLabel.Size = new System.Drawing.Size(48, 13);
            anticipoLabel.TabIndex = 126;
            anticipoLabel.Text = "Anticipo:";
            // 
            // colEntregada
            // 
            this.colEntregada.AppearanceHeader.Options.UseTextOptions = true;
            this.colEntregada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEntregada.Caption = "Ent";
            this.colEntregada.FieldName = "Entregada";
            this.colEntregada.Name = "colEntregada";
            this.colEntregada.OptionsColumn.AllowEdit = false;
            this.colEntregada.Width = 36;
            // 
            // colImpPendiente
            // 
            this.colImpPendiente.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpPendiente.Caption = "Pendiente";
            this.colImpPendiente.DisplayFormat.FormatString = "N2";
            this.colImpPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpPendiente.FieldName = "ImpPendiente";
            this.colImpPendiente.Name = "colImpPendiente";
            this.colImpPendiente.Visible = true;
            this.colImpPendiente.VisibleIndex = 7;
            this.colImpPendiente.Width = 77;
            // 
            // colFacturaPresup
            // 
            this.colFacturaPresup.FieldName = "FacturaPresup";
            this.colFacturaPresup.Name = "colFacturaPresup";
            this.colFacturaPresup.OptionsColumn.AllowEdit = false;
            // 
            // colCobrada
            // 
            this.colCobrada.AppearanceHeader.Options.UseTextOptions = true;
            this.colCobrada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCobrada.Caption = "Cob";
            this.colCobrada.FieldName = "Cobrada";
            this.colCobrada.Name = "colCobrada";
            this.colCobrada.OptionsColumn.AllowEdit = false;
            this.colCobrada.Width = 46;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fecha", "Fecha", 39, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CantAdmin", "Cant Admin", 65, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalarioVenta", "Salario Venta", 73, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesTrabajo", "Des Trabajo", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DirTrabajo", "Dir Trabajo", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Facturado", "Facturado", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesTipo", "Des Tipo", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesCategoria", "Des Categoria", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumTrabajador", "Num Trabajador", 87, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomTrabajador", "Nom Trabajador", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ApeTrabajador", "Ape Trabajador", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Festivo", "Festivo", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cantidad", "Cantidad", 53, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Salario", "Salario", 42, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Fecha";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdHoras";
            // 
            // facturasCabBindingSource
            // 
            this.facturasCabBindingSource.DataMember = "FacturasCab";
            this.facturasCabBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obrasBindingSource1
            // 
            this.obrasBindingSource1.DataMember = "Obras";
            this.obrasBindingSource1.DataSource = this.promowork_dataDataSet1;
            // 
            // promowork_dataDataSet1
            // 
            this.promowork_dataDataSet1.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.promowork_dataDataSet;
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "FK_Obras_Clientes";
            this.obrasBindingSource.DataSource = this.clientesBindingSource;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // cuentasBancosBindingSource
            // 
            this.cuentasBancosBindingSource.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // anosFacturasBindingSource
            // 
            this.anosFacturasBindingSource.DataMember = "AnosFacturas";
            this.anosFacturasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.promowork_dataDataSet1;
            // 
            // importeFacturaHorasBindingSource
            // 
            this.importeFacturaHorasBindingSource.DataMember = "ImporteFacturaHoras";
            this.importeFacturaHorasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagenes|*.jpg; *.bmp; *.png; *.gif; *.pdf";
            // 
            // facturasCabTableAdapter
            // 
            this.facturasCabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccesosEmpresasTableAdapter = null;
            this.tableAdapterManager.AdjuntosObrasTableAdapter = null;
            this.tableAdapterManager.AnticiposTableAdapter = null;
            this.tableAdapterManager.AnticiposTrabajadoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajasMedicaTableAdapter = null;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosTableAdapter = null;
            this.tableAdapterManager.ComprasCabTableAdapter = null;
            this.tableAdapterManager.ComprasDetTableAdapter = null;
            this.tableAdapterManager.ConceptosBancosTableAdapter = null;
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.DescuentosFacturasTableAdapter = null;
            this.tableAdapterManager.EmpresasActualTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.FabricantesTableAdapter = null;
            this.tableAdapterManager.FacturasCabListaTableAdapter = null;
            this.tableAdapterManager.FacturasCabTableAdapter = this.facturasCabTableAdapter;
            this.tableAdapterManager.FacturasDetHorasTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = null;
            this.tableAdapterManager.FestivosEmpresasTableAdapter = null;
            this.tableAdapterManager.FestivosObrasDiaTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.GruposProductosTableAdapter = null;
            this.tableAdapterManager.HijosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.HorasAdminTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadasTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadoresTableAdapter = null;
            this.tableAdapterManager.NacionesTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.OperacionesBancoTableAdapter = null;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.ParticipantesTableAdapter = null;
            this.tableAdapterManager.PartObrasTableAdapter = null;
            this.tableAdapterManager.PartPresupTableAdapter = null;
            this.tableAdapterManager.Poblaciones1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvincias1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvinciasTableAdapter = null;
            this.tableAdapterManager.PoblacionesTableAdapter = null;
            this.tableAdapterManager.PresupCabTableAdapter = null;
            this.tableAdapterManager.PresupCapTableAdapter = null;
            this.tableAdapterManager.PresupDetTableAdapter = null;
            this.tableAdapterManager.PresupSubTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProductosUtilizadosTableAdapter = null;
            this.tableAdapterManager.ProductosUtTrabajadoresTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Provincias1TableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.PuestosTrabajoTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaAdminTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.SeguridadSocialTableAdapter = null;
            this.tableAdapterManager.TiposProductosTableAdapter = null;
            this.tableAdapterManager.TiposProveedoresTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresListaTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cuentasBancosTableAdapter
            // 
            this.cuentasBancosTableAdapter.ClearBeforeFill = true;
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // horasTrabajadasBindingSource
            // 
            this.horasTrabajadasBindingSource.DataMember = "HorasTrabajadas";
            this.horasTrabajadasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // horasTrabajadasTableAdapter
            // 
            this.horasTrabajadasTableAdapter.ClearBeforeFill = true;
            // 
            // empresasActualBindingSource
            // 
            this.empresasActualBindingSource.DataMember = "EmpresasActual";
            this.empresasActualBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // empresasActualTableAdapter
            // 
            this.empresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // vFacturaDetHorasBindingSource
            // 
            this.vFacturaDetHorasBindingSource.DataMember = "vFacturaDetHoras";
            this.vFacturaDetHorasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // vFacturaDetHorasTableAdapter
            // 
            this.vFacturaDetHorasTableAdapter.ClearBeforeFill = true;
            // 
            // vHorasTrabajadasBindingSource
            // 
            this.vHorasTrabajadasBindingSource.DataMember = "vHorasTrabajadas";
            this.vHorasTrabajadasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // vHorasTrabajadasTableAdapter
            // 
            this.vHorasTrabajadasTableAdapter.ClearBeforeFill = true;
            // 
            // colIdHoras
            // 
            this.colIdHoras.FieldName = "IdHoras";
            this.colIdHoras.Name = "colIdHoras";
            // 
            // colIdHoras1
            // 
            this.colIdHoras1.FieldName = "IdHoras1";
            this.colIdHoras1.Name = "colIdHoras1";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdObra
            // 
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.Name = "colIdObra";
            // 
            // colIdTrabajador
            // 
            this.colIdTrabajador.FieldName = "IdTrabajador";
            this.colIdTrabajador.Name = "colIdTrabajador";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCantidad1});
            this.gridView2.Name = "gridView2";
            // 
            // colCantidad1
            // 
            this.colCantidad1.FieldName = "Cantidad";
            this.colCantidad1.Name = "colCantidad1";
            this.colCantidad1.Visible = true;
            this.colCantidad1.VisibleIndex = 2;
            // 
            // vProductosUtilizadosGridControl
            // 
            this.vProductosUtilizadosGridControl.DataSource = this.productosUtilizadosBindingSource;
            this.vProductosUtilizadosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vProductosUtilizadosGridControl.Location = new System.Drawing.Point(0, 25);
            this.vProductosUtilizadosGridControl.MainView = this.gridView3;
            this.vProductosUtilizadosGridControl.Name = "vProductosUtilizadosGridControl";
            this.vProductosUtilizadosGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2});
            this.vProductosUtilizadosGridControl.Size = new System.Drawing.Size(670, 117);
            this.vProductosUtilizadosGridControl.TabIndex = 114;
            this.vProductosUtilizadosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // productosUtilizadosBindingSource
            // 
            this.productosUtilizadosBindingSource.DataMember = "ProductosUtilizados";
            this.productosUtilizadosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProdUtiliza,
            this.colIdHoras2,
            this.colIdHorasAdmin,
            this.colIdProducto,
            this.colPVP,
            this.colDescuento,
            this.colPorciento,
            this.colCantidad2,
            this.colDescuentoProducto});
            this.gridView3.GridControl = this.vProductosUtilizadosGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView3_CellValueChanging);
            // 
            // colIdProdUtiliza
            // 
            this.colIdProdUtiliza.FieldName = "IdProdUtiliza";
            this.colIdProdUtiliza.Name = "colIdProdUtiliza";
            this.colIdProdUtiliza.OptionsColumn.AllowEdit = false;
            this.colIdProdUtiliza.OptionsColumn.ReadOnly = true;
            // 
            // colIdHoras2
            // 
            this.colIdHoras2.FieldName = "IdHoras";
            this.colIdHoras2.Name = "colIdHoras2";
            this.colIdHoras2.OptionsColumn.AllowEdit = false;
            // 
            // colIdHorasAdmin
            // 
            this.colIdHorasAdmin.FieldName = "IdHorasAdmin";
            this.colIdHorasAdmin.Name = "colIdHorasAdmin";
            this.colIdHorasAdmin.OptionsColumn.AllowEdit = false;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.AllowEdit = false;
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 266;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Producto", "Producto", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.productosBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Producto";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdProducto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colPVP
            // 
            this.colPVP.AppearanceHeader.Options.UseTextOptions = true;
            this.colPVP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPVP.Caption = "PVP";
            this.colPVP.FieldName = "PVP";
            this.colPVP.Name = "colPVP";
            this.colPVP.Visible = true;
            this.colPVP.VisibleIndex = 2;
            this.colPVP.Width = 68;
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuento.Caption = "Descuento";
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 3;
            this.colDescuento.Width = 68;
            // 
            // colPorciento
            // 
            this.colPorciento.AppearanceHeader.Options.UseTextOptions = true;
            this.colPorciento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPorciento.Caption = "Porciento";
            this.colPorciento.FieldName = "Porciento";
            this.colPorciento.Name = "colPorciento";
            this.colPorciento.Visible = true;
            this.colPorciento.VisibleIndex = 4;
            this.colPorciento.Width = 70;
            // 
            // colCantidad2
            // 
            this.colCantidad2.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad2.Caption = "Cantidad";
            this.colCantidad2.FieldName = "Cantidad";
            this.colCantidad2.Name = "colCantidad2";
            this.colCantidad2.Visible = true;
            this.colCantidad2.VisibleIndex = 1;
            this.colCantidad2.Width = 68;
            // 
            // colDescuentoProducto
            // 
            this.colDescuentoProducto.AppearanceCell.Options.UseTextOptions = true;
            this.colDescuentoProducto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuentoProducto.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuentoProducto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuentoProducto.Caption = "Desc. (%)";
            this.colDescuentoProducto.FieldName = "DescuentoProducto";
            this.colDescuentoProducto.Name = "colDescuentoProducto";
            this.colDescuentoProducto.Visible = true;
            this.colDescuentoProducto.VisibleIndex = 5;
            // 
            // vFacturaDetHorasGridControl
            // 
            this.vFacturaDetHorasGridControl.DataSource = this.vFacturaDetHorasBindingSource;
            this.vFacturaDetHorasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vFacturaDetHorasGridControl.Location = new System.Drawing.Point(0, 25);
            this.vFacturaDetHorasGridControl.MainView = this.gridView1;
            this.vFacturaDetHorasGridControl.Name = "vFacturaDetHorasGridControl";
            this.vFacturaDetHorasGridControl.Size = new System.Drawing.Size(636, 118);
            this.vFacturaDetHorasGridControl.TabIndex = 112;
            this.vFacturaDetHorasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdFactDetHoras,
            this.colIdFactCab,
            this.IdHoras,
            this.colDiaTrab,
            this.colMesTrab,
            this.colAnoTrab,
            this.colFecha,
            this.colNumTrabajador,
            this.colNomTrabajador,
            this.colApeTrabajador,
            this.colCantAdmin,
            this.colSalarioVenta,
            this.colDesTrabajo,
            this.colDirTrabajo,
            this.colFacturado,
            this.colDesTipo,
            this.colDesCategoria,
            this.colCantidad,
            this.colSalario,
            this.colFestivo,
            this.colCopiaParte,
            this.colDescuentoHoras});
            this.gridView1.GridControl = this.vFacturaDetHorasGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.GotFocus += new System.EventHandler(this.gridView1_GotFocus);
            // 
            // IdFactDetHoras
            // 
            this.IdFactDetHoras.FieldName = "IdFactDetHoras";
            this.IdFactDetHoras.Name = "IdFactDetHoras";
            this.IdFactDetHoras.OptionsColumn.AllowEdit = false;
            // 
            // colIdFactCab
            // 
            this.colIdFactCab.FieldName = "IdFactCab";
            this.colIdFactCab.Name = "colIdFactCab";
            this.colIdFactCab.OptionsColumn.AllowEdit = false;
            // 
            // IdHoras
            // 
            this.IdHoras.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.IdHoras.FieldName = "IdHoras";
            this.IdHoras.Name = "IdHoras";
            this.IdHoras.OptionsColumn.AllowEdit = false;
            this.IdHoras.Width = 78;
            // 
            // colDiaTrab
            // 
            this.colDiaTrab.FieldName = "DiaTrab";
            this.colDiaTrab.Name = "colDiaTrab";
            this.colDiaTrab.OptionsColumn.AllowEdit = false;
            // 
            // colMesTrab
            // 
            this.colMesTrab.FieldName = "MesTrab";
            this.colMesTrab.Name = "colMesTrab";
            this.colMesTrab.OptionsColumn.AllowEdit = false;
            // 
            // colAnoTrab
            // 
            this.colAnoTrab.FieldName = "AnoTrab";
            this.colAnoTrab.Name = "colAnoTrab";
            this.colAnoTrab.OptionsColumn.AllowEdit = false;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 53;
            // 
            // colNumTrabajador
            // 
            this.colNumTrabajador.Caption = "Nº";
            this.colNumTrabajador.FieldName = "NumTrabajador";
            this.colNumTrabajador.Name = "colNumTrabajador";
            this.colNumTrabajador.OptionsColumn.AllowEdit = false;
            this.colNumTrabajador.Width = 26;
            // 
            // colNomTrabajador
            // 
            this.colNomTrabajador.Caption = "Nombre";
            this.colNomTrabajador.FieldName = "NomTrabajador";
            this.colNomTrabajador.Name = "colNomTrabajador";
            this.colNomTrabajador.OptionsColumn.AllowEdit = false;
            this.colNomTrabajador.Visible = true;
            this.colNomTrabajador.VisibleIndex = 1;
            this.colNomTrabajador.Width = 76;
            // 
            // colApeTrabajador
            // 
            this.colApeTrabajador.Caption = "Apellidos";
            this.colApeTrabajador.FieldName = "ApeTrabajador";
            this.colApeTrabajador.Name = "colApeTrabajador";
            this.colApeTrabajador.OptionsColumn.AllowEdit = false;
            this.colApeTrabajador.Width = 93;
            // 
            // colCantAdmin
            // 
            this.colCantAdmin.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantAdmin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantAdmin.Caption = "Admin";
            this.colCantAdmin.FieldName = "CantAdmin";
            this.colCantAdmin.Name = "colCantAdmin";
            this.colCantAdmin.Visible = true;
            this.colCantAdmin.VisibleIndex = 4;
            this.colCantAdmin.Width = 53;
            // 
            // colSalarioVenta
            // 
            this.colSalarioVenta.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalarioVenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalarioVenta.Caption = "Sal. Admin";
            this.colSalarioVenta.FieldName = "SalarioVenta";
            this.colSalarioVenta.Name = "colSalarioVenta";
            this.colSalarioVenta.Visible = true;
            this.colSalarioVenta.VisibleIndex = 5;
            this.colSalarioVenta.Width = 54;
            // 
            // colDesTrabajo
            // 
            this.colDesTrabajo.Caption = "Trabajo Realizado";
            this.colDesTrabajo.FieldName = "DesTrabajo";
            this.colDesTrabajo.Name = "colDesTrabajo";
            this.colDesTrabajo.OptionsColumn.AllowEdit = false;
            this.colDesTrabajo.Visible = true;
            this.colDesTrabajo.VisibleIndex = 2;
            this.colDesTrabajo.Width = 139;
            // 
            // colDirTrabajo
            // 
            this.colDirTrabajo.Caption = "Dirección";
            this.colDirTrabajo.FieldName = "DirTrabajo";
            this.colDirTrabajo.Name = "colDirTrabajo";
            this.colDirTrabajo.OptionsColumn.AllowEdit = false;
            this.colDirTrabajo.Visible = true;
            this.colDirTrabajo.VisibleIndex = 3;
            this.colDirTrabajo.Width = 77;
            // 
            // colFacturado
            // 
            this.colFacturado.FieldName = "Facturado";
            this.colFacturado.Name = "colFacturado";
            this.colFacturado.OptionsColumn.AllowEdit = false;
            // 
            // colDesTipo
            // 
            this.colDesTipo.Caption = "Tipo";
            this.colDesTipo.FieldName = "DesTipo";
            this.colDesTipo.Name = "colDesTipo";
            this.colDesTipo.OptionsColumn.AllowEdit = false;
            this.colDesTipo.Width = 44;
            // 
            // colDesCategoria
            // 
            this.colDesCategoria.Caption = "Categoría";
            this.colDesCategoria.FieldName = "DesCategoria";
            this.colDesCategoria.Name = "colDesCategoria";
            this.colDesCategoria.OptionsColumn.AllowEdit = false;
            this.colDesCategoria.Width = 54;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 7;
            this.colCantidad.Width = 59;
            // 
            // colSalario
            // 
            this.colSalario.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalario.Caption = "Coste";
            this.colSalario.FieldName = "Salario";
            this.colSalario.Name = "colSalario";
            this.colSalario.OptionsColumn.AllowEdit = false;
            this.colSalario.Visible = true;
            this.colSalario.VisibleIndex = 8;
            this.colSalario.Width = 57;
            // 
            // colFestivo
            // 
            this.colFestivo.FieldName = "Festivo";
            this.colFestivo.Name = "colFestivo";
            this.colFestivo.OptionsColumn.AllowEdit = false;
            // 
            // colCopiaParte
            // 
            this.colCopiaParte.FieldName = "CopiaParte";
            this.colCopiaParte.Name = "colCopiaParte";
            this.colCopiaParte.OptionsColumn.AllowEdit = false;
            // 
            // colDescuentoHoras
            // 
            this.colDescuentoHoras.AppearanceCell.Options.UseTextOptions = true;
            this.colDescuentoHoras.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuentoHoras.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuentoHoras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuentoHoras.Caption = "Desc. (%)";
            this.colDescuentoHoras.FieldName = "DescuentoHoras";
            this.colDescuentoHoras.Name = "colDescuentoHoras";
            this.colDescuentoHoras.Visible = true;
            this.colDescuentoHoras.VisibleIndex = 6;
            this.colDescuentoHoras.Width = 50;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.vFacturaDetHorasBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton8,
            this.toolStripButton2,
            this.toolStripButton7,
            this.toolStripSeparator4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(636, 25);
            this.bindingNavigator1.TabIndex = 111;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(130, 22);
            this.toolStripLabel1.Text = "Pendiente de Facturar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Promowork.Properties.Resources.FlechaArriba16;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Add new";
            this.toolStripButton8.ToolTipText = "Agrega el parte seleccionado a la Factura";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Promowork.Properties.Resources.FlechaAbajo16Roja;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Elimina el parte seleccionado de la Factura";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Save Data";
            this.toolStripButton7.ToolTipText = "Guarda los Cambios en el Detalle de la Factura";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click_2);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // vHorasTrabajadasGridControl
            // 
            this.vHorasTrabajadasGridControl.DataSource = this.vHorasTrabajadasBindingSource;
            this.vHorasTrabajadasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vHorasTrabajadasGridControl.Location = new System.Drawing.Point(0, 25);
            this.vHorasTrabajadasGridControl.MainView = this.gridView4;
            this.vHorasTrabajadasGridControl.Name = "vHorasTrabajadasGridControl";
            this.vHorasTrabajadasGridControl.Size = new System.Drawing.Size(636, 144);
            this.vHorasTrabajadasGridControl.TabIndex = 114;
            this.vHorasTrabajadasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView4.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.gridView4.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.Empty.Options.UseBackColor = true;
            this.gridView4.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.gridView4.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView4.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView4.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView4.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView4.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.gridView4.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(153)))), ((int)(((byte)(73)))));
            this.gridView4.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(167)))), ((int)(((byte)(103)))));
            this.gridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView4.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.gridView4.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView4.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.gridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(167)))), ((int)(((byte)(103)))));
            this.gridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView4.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView4.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView4.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(208)))));
            this.gridView4.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView4.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView4.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.gridView4.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView4.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(146)))), ((int)(((byte)(78)))));
            this.gridView4.Appearance.Preview.Options.UseBackColor = true;
            this.gridView4.Appearance.Preview.Options.UseFont = true;
            this.gridView4.Appearance.Preview.Options.UseForeColor = true;
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.gridView4.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.gridView4.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.Appearance.Row.Options.UseBorderColor = true;
            this.gridView4.Appearance.Row.Options.UseForeColor = true;
            this.gridView4.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.gridView4.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView4.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(167)))), ((int)(((byte)(103)))));
            this.gridView4.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView4.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView4.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.gridView4.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDiaTrab1,
            this.colMesTrab1,
            this.colAnoTrab1,
            this.colFecha1,
            this.colCantAdmin1,
            this.colSalarioVenta1,
            this.colDesTrabajo1,
            this.colDirTrabajo1,
            this.colFacturado1,
            this.colDesTipo1,
            this.colDesCategoria1,
            this.colNumTrabajador1,
            this.colNomTrabajador1,
            this.colApeTrabajador1,
            this.colIdHoras3,
            this.colIdEmpresa1,
            this.colIdObra1,
            this.colIdTrabajador1,
            this.colFestivo1,
            this.colCantidad3,
            this.colSalario1,
            this.colCopiaParte1});
            this.gridView4.GridControl = this.vHorasTrabajadasGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView4.OptionsView.EnableAppearanceOddRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView4_FocusedRowChanged);
            this.gridView4.DoubleClick += new System.EventHandler(this.gridView4_DoubleClick);
            // 
            // colDiaTrab1
            // 
            this.colDiaTrab1.FieldName = "DiaTrab";
            this.colDiaTrab1.Name = "colDiaTrab1";
            this.colDiaTrab1.OptionsColumn.AllowEdit = false;
            this.colDiaTrab1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMesTrab1
            // 
            this.colMesTrab1.FieldName = "MesTrab";
            this.colMesTrab1.Name = "colMesTrab1";
            this.colMesTrab1.OptionsColumn.AllowEdit = false;
            this.colMesTrab1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colAnoTrab1
            // 
            this.colAnoTrab1.FieldName = "AnoTrab";
            this.colAnoTrab1.Name = "colAnoTrab1";
            this.colAnoTrab1.OptionsColumn.AllowEdit = false;
            this.colAnoTrab1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colFecha1
            // 
            this.colFecha1.Caption = "Fecha";
            this.colFecha1.FieldName = "Fecha";
            this.colFecha1.Name = "colFecha1";
            this.colFecha1.OptionsColumn.AllowEdit = false;
            this.colFecha1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colFecha1.OptionsColumn.ReadOnly = true;
            this.colFecha1.Visible = true;
            this.colFecha1.VisibleIndex = 0;
            this.colFecha1.Width = 63;
            // 
            // colCantAdmin1
            // 
            this.colCantAdmin1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantAdmin1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantAdmin1.Caption = "Admin";
            this.colCantAdmin1.FieldName = "CantAdmin";
            this.colCantAdmin1.Name = "colCantAdmin1";
            this.colCantAdmin1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colCantAdmin1.Visible = true;
            this.colCantAdmin1.VisibleIndex = 4;
            this.colCantAdmin1.Width = 67;
            // 
            // colSalarioVenta1
            // 
            this.colSalarioVenta1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalarioVenta1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalarioVenta1.Caption = "Sal. Admin";
            this.colSalarioVenta1.FieldName = "SalarioVenta";
            this.colSalarioVenta1.Name = "colSalarioVenta1";
            this.colSalarioVenta1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSalarioVenta1.Visible = true;
            this.colSalarioVenta1.VisibleIndex = 5;
            this.colSalarioVenta1.Width = 60;
            // 
            // colDesTrabajo1
            // 
            this.colDesTrabajo1.Caption = "Trabajo Realizado";
            this.colDesTrabajo1.FieldName = "DesTrabajo";
            this.colDesTrabajo1.Name = "colDesTrabajo1";
            this.colDesTrabajo1.OptionsColumn.AllowEdit = false;
            this.colDesTrabajo1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDesTrabajo1.Visible = true;
            this.colDesTrabajo1.VisibleIndex = 2;
            this.colDesTrabajo1.Width = 172;
            // 
            // colDirTrabajo1
            // 
            this.colDirTrabajo1.Caption = "Dirección";
            this.colDirTrabajo1.FieldName = "DirTrabajo";
            this.colDirTrabajo1.Name = "colDirTrabajo1";
            this.colDirTrabajo1.OptionsColumn.AllowEdit = false;
            this.colDirTrabajo1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDirTrabajo1.Visible = true;
            this.colDirTrabajo1.VisibleIndex = 3;
            this.colDirTrabajo1.Width = 93;
            // 
            // colFacturado1
            // 
            this.colFacturado1.FieldName = "Facturado";
            this.colFacturado1.Name = "colFacturado1";
            this.colFacturado1.OptionsColumn.AllowEdit = false;
            this.colFacturado1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colDesTipo1
            // 
            this.colDesTipo1.FieldName = "DesTipo";
            this.colDesTipo1.Name = "colDesTipo1";
            this.colDesTipo1.OptionsColumn.AllowEdit = false;
            this.colDesTipo1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colDesCategoria1
            // 
            this.colDesCategoria1.FieldName = "DesCategoria";
            this.colDesCategoria1.Name = "colDesCategoria1";
            this.colDesCategoria1.OptionsColumn.AllowEdit = false;
            this.colDesCategoria1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colNumTrabajador1
            // 
            this.colNumTrabajador1.FieldName = "NumTrabajador";
            this.colNumTrabajador1.Name = "colNumTrabajador1";
            this.colNumTrabajador1.OptionsColumn.AllowEdit = false;
            this.colNumTrabajador1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colNomTrabajador1
            // 
            this.colNomTrabajador1.Caption = "Trabajador";
            this.colNomTrabajador1.FieldName = "NomTrabajador";
            this.colNomTrabajador1.Name = "colNomTrabajador1";
            this.colNomTrabajador1.OptionsColumn.AllowEdit = false;
            this.colNomTrabajador1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNomTrabajador1.Visible = true;
            this.colNomTrabajador1.VisibleIndex = 1;
            this.colNomTrabajador1.Width = 83;
            // 
            // colApeTrabajador1
            // 
            this.colApeTrabajador1.FieldName = "ApeTrabajador";
            this.colApeTrabajador1.Name = "colApeTrabajador1";
            this.colApeTrabajador1.OptionsColumn.AllowEdit = false;
            this.colApeTrabajador1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIdHoras3
            // 
            this.colIdHoras3.FieldName = "IdHoras";
            this.colIdHoras3.Name = "colIdHoras3";
            this.colIdHoras3.OptionsColumn.AllowEdit = false;
            this.colIdHoras3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIdObra1
            // 
            this.colIdObra1.FieldName = "IdObra";
            this.colIdObra1.Name = "colIdObra1";
            this.colIdObra1.OptionsColumn.AllowEdit = false;
            this.colIdObra1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIdTrabajador1
            // 
            this.colIdTrabajador1.FieldName = "IdTrabajador";
            this.colIdTrabajador1.Name = "colIdTrabajador1";
            this.colIdTrabajador1.OptionsColumn.AllowEdit = false;
            this.colIdTrabajador1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colFestivo1
            // 
            this.colFestivo1.FieldName = "Festivo";
            this.colFestivo1.Name = "colFestivo1";
            this.colFestivo1.OptionsColumn.AllowEdit = false;
            this.colFestivo1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colCantidad3
            // 
            this.colCantidad3.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad3.Caption = "Cantidad";
            this.colCantidad3.FieldName = "Cantidad";
            this.colCantidad3.Name = "colCantidad3";
            this.colCantidad3.OptionsColumn.AllowEdit = false;
            this.colCantidad3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colCantidad3.Visible = true;
            this.colCantidad3.VisibleIndex = 6;
            this.colCantidad3.Width = 63;
            // 
            // colSalario1
            // 
            this.colSalario1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalario1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalario1.Caption = "Coste";
            this.colSalario1.FieldName = "Salario";
            this.colSalario1.Name = "colSalario1";
            this.colSalario1.OptionsColumn.AllowEdit = false;
            this.colSalario1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSalario1.Visible = true;
            this.colSalario1.VisibleIndex = 7;
            this.colSalario1.Width = 57;
            // 
            // colCopiaParte1
            // 
            this.colCopiaParte1.FieldName = "CopiaParte";
            this.colCopiaParte1.Name = "colCopiaParte1";
            this.colCopiaParte1.OptionsColumn.AllowEdit = false;
            // 
            // productosUtilizadosTableAdapter
            // 
            this.productosUtilizadosTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // productosUtilizadosBindingSource1
            // 
            this.productosUtilizadosBindingSource1.DataMember = "ProductosUtilizados";
            this.productosUtilizadosBindingSource1.DataSource = this.promowork_dataDataSet1;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // importeFacturaHorasTableAdapter
            // 
            this.importeFacturaHorasTableAdapter.ClearBeforeFill = true;
            // 
            // formasPagoBindingSource
            // 
            this.formasPagoBindingSource.DataMember = "FormasPago";
            this.formasPagoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // formasPagoTableAdapter
            // 
            this.formasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // desFormaPagoComboBox
            // 
            this.desFormaPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdFormaPago", true));
            this.desFormaPagoComboBox.DataSource = this.formasPagoBindingSource;
            this.desFormaPagoComboBox.DisplayMember = "DesFormaPago";
            this.desFormaPagoComboBox.FormattingEnabled = true;
            this.desFormaPagoComboBox.Location = new System.Drawing.Point(78, 329);
            this.desFormaPagoComboBox.Name = "desFormaPagoComboBox";
            this.desFormaPagoComboBox.Size = new System.Drawing.Size(189, 21);
            this.desFormaPagoComboBox.TabIndex = 117;
            this.desFormaPagoComboBox.ValueMember = "IdFormaPago";
            // 
            // cobrosBindingSource
            // 
            this.cobrosBindingSource.DataMember = "Cobros";
            this.cobrosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // cobrosTableAdapter
            // 
            this.cobrosTableAdapter.ClearBeforeFill = true;
            // 
            // impBaseTextBox
            // 
            this.impBaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpBase", true));
            this.impBaseTextBox.Location = new System.Drawing.Point(323, 357);
            this.impBaseTextBox.Name = "impBaseTextBox";
            this.impBaseTextBox.Size = new System.Drawing.Size(86, 20);
            this.impBaseTextBox.TabIndex = 118;
            // 
            // impIVATextBox
            // 
            this.impIVATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpIVA", true));
            this.impIVATextBox.Location = new System.Drawing.Point(483, 357);
            this.impIVATextBox.Name = "impIVATextBox";
            this.impIVATextBox.Size = new System.Drawing.Size(83, 20);
            this.impIVATextBox.TabIndex = 121;
            // 
            // fechaExpDateTimePicker
            // 
            this.fechaExpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaExp", true));
            this.fechaExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaExpDateTimePicker.Location = new System.Drawing.Point(78, 356);
            this.fechaExpDateTimePicker.Name = "fechaExpDateTimePicker";
            this.fechaExpDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaExpDateTimePicker.TabIndex = 123;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdCuenta", true));
            this.comboBox2.DataSource = this.cuentasBancosBindingSource1;
            this.comboBox2.DisplayMember = "BancoCuenta";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(323, 329);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(333, 21);
            this.comboBox2.TabIndex = 111;
            this.comboBox2.ValueMember = "IdCuenta";
            // 
            // cuentasBancosBindingSource1
            // 
            this.cuentasBancosBindingSource1.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // descuentosFacturasBindingSource
            // 
            this.descuentosFacturasBindingSource.DataMember = "DescuentosFacturas";
            this.descuentosFacturasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // descuentosFacturasTableAdapter
            // 
            this.descuentosFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // descuentosFacturasGridControl
            // 
            this.descuentosFacturasGridControl.DataSource = this.descuentosFacturasBindingSource;
            this.descuentosFacturasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descuentosFacturasGridControl.Location = new System.Drawing.Point(0, 25);
            this.descuentosFacturasGridControl.MainView = this.gridView5;
            this.descuentosFacturasGridControl.Name = "descuentosFacturasGridControl";
            this.descuentosFacturasGridControl.Size = new System.Drawing.Size(670, 88);
            this.descuentosFacturasGridControl.TabIndex = 124;
            this.descuentosFacturasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDesFactura,
            this.colIdFactCab1,
            this.colDesDescuento,
            this.colImpDescuento});
            this.gridView5.GridControl = this.descuentosFacturasGridControl;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDesFactura
            // 
            this.colIdDesFactura.FieldName = "IdDesFactura";
            this.colIdDesFactura.Name = "colIdDesFactura";
            this.colIdDesFactura.OptionsColumn.ReadOnly = true;
            // 
            // colIdFactCab1
            // 
            this.colIdFactCab1.FieldName = "IdFactCab";
            this.colIdFactCab1.Name = "colIdFactCab1";
            // 
            // colDesDescuento
            // 
            this.colDesDescuento.Caption = "Descuentos";
            this.colDesDescuento.FieldName = "DesDescuento";
            this.colDesDescuento.Name = "colDesDescuento";
            this.colDesDescuento.Visible = true;
            this.colDesDescuento.VisibleIndex = 0;
            this.colDesDescuento.Width = 387;
            // 
            // colImpDescuento
            // 
            this.colImpDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpDescuento.Caption = "Importe";
            this.colImpDescuento.FieldName = "ImpDescuento";
            this.colImpDescuento.Name = "colImpDescuento";
            this.colImpDescuento.Visible = true;
            this.colImpDescuento.VisibleIndex = 1;
            this.colImpDescuento.Width = 95;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton14;
            this.bindingNavigator2.BindingSource = this.descuentosFacturasBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator8,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripSeparator9});
            this.bindingNavigator2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(670, 25);
            this.bindingNavigator2.TabIndex = 113;
            this.bindingNavigator2.Text = "bindingNavigator1";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Add new";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel2.Text = "Descuentos";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Delete";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Save Data";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // anosFacturasTableAdapter
            // 
            this.anosFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // obsFactura2TextBox
            // 
            this.obsFactura2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "ObsFactura2", true));
            this.obsFactura2TextBox.Location = new System.Drawing.Point(66, 6);
            this.obsFactura2TextBox.Multiline = true;
            this.obsFactura2TextBox.Name = "obsFactura2TextBox";
            this.obsFactura2TextBox.Size = new System.Drawing.Size(590, 44);
            this.obsFactura2TextBox.TabIndex = 125;
            // 
            // facturaIncorrectaBindingSource
            // 
            this.facturaIncorrectaBindingSource.DataMember = "FacturaIncorrecta";
            this.facturaIncorrectaBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // facturaIncorrectaTableAdapter
            // 
            this.facturaIncorrectaTableAdapter.ClearBeforeFill = true;
            // 
            // importeTextBox
            // 
            this.importeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "Importe", true));
            this.importeTextBox.Location = new System.Drawing.Point(572, 144);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.ReadOnly = true;
            this.importeTextBox.Size = new System.Drawing.Size(84, 20);
            this.importeTextBox.TabIndex = 108;
            this.importeTextBox.TextChanged += new System.EventHandler(this.importeTextBox_TextChanged);
            // 
            // obsFacturaTextEdit
            // 
            this.obsFacturaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "ObsFactura", true));
            this.obsFacturaTextEdit.Location = new System.Drawing.Point(409, 211);
            this.obsFacturaTextEdit.Name = "obsFacturaTextEdit";
            this.obsFacturaTextEdit.Size = new System.Drawing.Size(247, 95);
            this.obsFacturaTextEdit.TabIndex = 102;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "DesCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(67, 54);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(282, 21);
            this.idClienteComboBox.TabIndex = 2;
            this.idClienteComboBox.ValueMember = "IdCliente";
            this.idClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.idClienteComboBox_SelectedIndexChanged);
            // 
            // idPresupComboBox
            // 
            this.idPresupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idPresupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idPresupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdObra", true));
            this.idPresupComboBox.DataSource = this.obrasBindingSource;
            this.idPresupComboBox.DisplayMember = "Obra";
            this.idPresupComboBox.FormattingEnabled = true;
            this.idPresupComboBox.Location = new System.Drawing.Point(67, 98);
            this.idPresupComboBox.Name = "idPresupComboBox";
            this.idPresupComboBox.Size = new System.Drawing.Size(282, 21);
            this.idPresupComboBox.TabIndex = 3;
            this.idPresupComboBox.ValueMember = "IdObra";
            // 
            // numFacturaTextBox
            // 
            this.numFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "NumFactura", true));
            this.numFacturaTextBox.Location = new System.Drawing.Point(67, 33);
            this.numFacturaTextBox.Name = "numFacturaTextBox";
            this.numFacturaTextBox.Size = new System.Drawing.Size(51, 20);
            this.numFacturaTextBox.TabIndex = 1;
            // 
            // fechaFacturaDateTimePicker
            // 
            this.fechaFacturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturasCabBindingSource, "FechaFactura", true));
            this.fechaFacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFacturaDateTimePicker.Location = new System.Drawing.Point(67, 142);
            this.fechaFacturaDateTimePicker.Name = "fechaFacturaDateTimePicker";
            this.fechaFacturaDateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.fechaFacturaDateTimePicker.TabIndex = 5;
            // 
            // fechaVctoFactDateTimePicker
            // 
            this.fechaVctoFactDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturasCabBindingSource, "FechaVctoFact", true));
            this.fechaVctoFactDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVctoFactDateTimePicker.Location = new System.Drawing.Point(254, 142);
            this.fechaVctoFactDateTimePicker.Name = "fechaVctoFactDateTimePicker";
            this.fechaVctoFactDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.fechaVctoFactDateTimePicker.TabIndex = 6;
            // 
            // idCuentaComboBox
            // 
            this.idCuentaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idCuentaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idCuentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdCuenta", true));
            this.idCuentaComboBox.DataSource = this.cuentasBancosBindingSource;
            this.idCuentaComboBox.DisplayMember = "CuentaBanco";
            this.idCuentaComboBox.FormattingEnabled = true;
            this.idCuentaComboBox.Location = new System.Drawing.Point(67, 120);
            this.idCuentaComboBox.Name = "idCuentaComboBox";
            this.idCuentaComboBox.Size = new System.Drawing.Size(282, 21);
            this.idCuentaComboBox.TabIndex = 4;
            this.idCuentaComboBox.ValueMember = "IdCuenta";
            // 
            // certificacionTextBox
            // 
            this.certificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "Certificacion", true));
            this.certificacionTextBox.Location = new System.Drawing.Point(121, 164);
            this.certificacionTextBox.Name = "certificacionTextBox";
            this.certificacionTextBox.Size = new System.Drawing.Size(49, 20);
            this.certificacionTextBox.TabIndex = 7;
            // 
            // iVAFacturaTextBox
            // 
            this.iVAFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "IVAFactura", true));
            this.iVAFacturaTextBox.Location = new System.Drawing.Point(300, 186);
            this.iVAFacturaTextBox.Name = "iVAFacturaTextBox";
            this.iVAFacturaTextBox.Size = new System.Drawing.Size(49, 20);
            this.iVAFacturaTextBox.TabIndex = 10;
            // 
            // descFacuraTextBox
            // 
            this.descFacuraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "DescFactura", true));
            this.descFacuraTextBox.Location = new System.Drawing.Point(121, 186);
            this.descFacuraTextBox.Name = "descFacuraTextBox";
            this.descFacuraTextBox.Size = new System.Drawing.Size(49, 20);
            this.descFacuraTextBox.TabIndex = 8;
            // 
            // importeTextBox1
            // 
            this.importeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTextBox1.Location = new System.Drawing.Point(572, 34);
            this.importeTextBox1.Name = "importeTextBox1";
            this.importeTextBox1.ReadOnly = true;
            this.importeTextBox1.Size = new System.Drawing.Size(84, 20);
            this.importeTextBox1.TabIndex = 76;
            this.importeTextBox1.TextChanged += new System.EventHandler(this.importeTextBox1_TextChanged);
            // 
            // facturasCabBindingNavigator
            // 
            this.facturasCabBindingNavigator.AddNewItem = null;
            this.facturasCabBindingNavigator.BindingSource = this.facturasCabBindingSource;
            this.facturasCabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facturasCabBindingNavigator.DeleteItem = null;
            this.facturasCabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.facturasCabBindingNavigatorSaveItem,
            this.toolStripSeparator7,
            this.toolStripButton16,
            this.toolStripButton1,
            this.toolStripSeparator});
            this.facturasCabBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.facturasCabBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facturasCabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facturasCabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facturasCabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facturasCabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facturasCabBindingNavigator.Name = "facturasCabBindingNavigator";
            this.facturasCabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facturasCabBindingNavigator.Size = new System.Drawing.Size(1553, 25);
            this.facturasCabBindingNavigator.TabIndex = 0;
            this.facturasCabBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // facturasCabBindingNavigatorSaveItem
            // 
            this.facturasCabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturasCabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturasCabBindingNavigatorSaveItem.Image")));
            this.facturasCabBindingNavigatorSaveItem.Name = "facturasCabBindingNavigatorSaveItem";
            this.facturasCabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facturasCabBindingNavigatorSaveItem.Text = "Guardar Datos";
            this.facturasCabBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturasCabBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Factura";
            this.toolStripButton16.ToolTipText = "Imprimir Factura";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Factura";
            this.toolStripButton1.ToolTipText = "Imprimir Factura con Descuentos y Cargos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(572, 123);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(84, 20);
            this.textBox15.TabIndex = 82;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(572, 56);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(84, 20);
            this.textBox16.TabIndex = 84;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(572, 188);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(84, 20);
            this.textBox17.TabIndex = 86;
            // 
            // descProntoTextBox
            // 
            this.descProntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "DescPronto", true));
            this.descProntoTextBox.Location = new System.Drawing.Point(121, 208);
            this.descProntoTextBox.Name = "descProntoTextBox";
            this.descProntoTextBox.Size = new System.Drawing.Size(49, 20);
            this.descProntoTextBox.TabIndex = 9;
            // 
            // retencionTextBox
            // 
            this.retencionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "Retencion", true));
            this.retencionTextBox.Location = new System.Drawing.Point(300, 208);
            this.retencionTextBox.Name = "retencionTextBox";
            this.retencionTextBox.Size = new System.Drawing.Size(49, 20);
            this.retencionTextBox.TabIndex = 11;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(572, 78);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(84, 20);
            this.textBox20.TabIndex = 94;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(572, 166);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(84, 20);
            this.textBox21.TabIndex = 96;
            // 
            // mostrarVctoCheckBox
            // 
            this.mostrarVctoCheckBox.AutoSize = true;
            this.mostrarVctoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.facturasCabBindingSource, "MostrarVcto", true));
            this.mostrarVctoCheckBox.Location = new System.Drawing.Point(331, 167);
            this.mostrarVctoCheckBox.Name = "mostrarVctoCheckBox";
            this.mostrarVctoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.mostrarVctoCheckBox.TabIndex = 97;
            this.mostrarVctoCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(572, 100);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(84, 20);
            this.textBox22.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 104;
            this.button1.Text = "Copia Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox23
            // 
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(572, 144);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(84, 20);
            this.textBox23.TabIndex = 101;
            // 
            // button3
            // 
            this.button3.Image = global::Promowork.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.button3.Location = new System.Drawing.Point(196, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 106;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(158, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 105;
            this.button4.Text = "Ver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // copiaFacturaTextBox
            // 
            this.copiaFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "CopiaFactura", true));
            this.copiaFacturaTextBox.Location = new System.Drawing.Point(67, 257);
            this.copiaFacturaTextBox.Name = "copiaFacturaTextBox";
            this.copiaFacturaTextBox.Size = new System.Drawing.Size(282, 20);
            this.copiaFacturaTextBox.TabIndex = 103;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdClienteFact", true));
            this.comboBox1.DataSource = this.clientesBindingSource1;
            this.comboBox1.DisplayMember = "DesCliente";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 21);
            this.comboBox1.TabIndex = 103;
            this.comboBox1.ValueMember = "IdCliente";
            // 
            // facturaCheckBox
            // 
            this.facturaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.facturasCabBindingSource, "Factura", true));
            this.facturaCheckBox.Location = new System.Drawing.Point(154, 13);
            this.facturaCheckBox.Name = "facturaCheckBox";
            this.facturaCheckBox.Size = new System.Drawing.Size(66, 22);
            this.facturaCheckBox.TabIndex = 111;
            this.facturaCheckBox.Text = "Factura";
            this.facturaCheckBox.UseVisualStyleBackColor = true;
            // 
            // entregadaCheckBox
            // 
            this.entregadaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.facturasCabBindingSource, "Entregada", true));
            this.entregadaCheckBox.Location = new System.Drawing.Point(154, 33);
            this.entregadaCheckBox.Name = "entregadaCheckBox";
            this.entregadaCheckBox.Size = new System.Drawing.Size(84, 21);
            this.entregadaCheckBox.TabIndex = 112;
            this.entregadaCheckBox.Text = "Entregada";
            this.entregadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // noDetalleCheckEdit
            // 
            this.noDetalleCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "NoDetalle", true));
            this.noDetalleCheckEdit.Location = new System.Drawing.Point(242, 14);
            this.noDetalleCheckEdit.Name = "noDetalleCheckEdit";
            this.noDetalleCheckEdit.Properties.Caption = "Sin Detalle";
            this.noDetalleCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.noDetalleCheckEdit.TabIndex = 113;
            // 
            // cbxanos
            // 
            this.cbxanos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anosFacturasBindingSource, "Ano", true));
            this.cbxanos.DataSource = this.anosFacturasBindingSource;
            this.cbxanos.DisplayMember = "Ano";
            this.cbxanos.FormattingEnabled = true;
            this.cbxanos.Location = new System.Drawing.Point(507, 4);
            this.cbxanos.Name = "cbxanos";
            this.cbxanos.Size = new System.Drawing.Size(58, 21);
            this.cbxanos.TabIndex = 114;
            this.cbxanos.ValueMember = "Ano";
            this.cbxanos.SelectedIndexChanged += new System.EventHandler(this.cbxanos_SelectedIndexChanged);
            // 
            // cbxfacturas
            // 
            this.cbxfacturas.FormattingEnabled = true;
            this.cbxfacturas.Items.AddRange(new object[] {
            "Facturas",
            "Partes de Trabajo"});
            this.cbxfacturas.Location = new System.Drawing.Point(369, 4);
            this.cbxfacturas.Name = "cbxfacturas";
            this.cbxfacturas.Size = new System.Drawing.Size(132, 21);
            this.cbxfacturas.TabIndex = 115;
            this.cbxfacturas.Text = "Facturas";
            this.cbxfacturas.SelectedIndexChanged += new System.EventHandler(this.cbxfacturas_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button2.Location = new System.Drawing.Point(351, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 21);
            this.button2.TabIndex = 116;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button5.Location = new System.Drawing.Point(351, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 21);
            this.button5.TabIndex = 117;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // facturasCabGridControl
            // 
            this.facturasCabGridControl.DataSource = this.facturasCabBindingSource;
            this.facturasCabGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facturasCabGridControl.Location = new System.Drawing.Point(0, 0);
            this.facturasCabGridControl.MainView = this.gridView6;
            this.facturasCabGridControl.Name = "facturasCabGridControl";
            this.facturasCabGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4,
            this.ClienteFactura});
            this.facturasCabGridControl.Size = new System.Drawing.Size(636, 398);
            this.facturasCabGridControl.TabIndex = 127;
            this.facturasCabGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView6.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView6.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView6.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView6.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView6.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView6.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView6.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactCab2,
            this.colIdCliente,
            this.colIdPresup,
            this.colNumFactura,
            this.colFechaFactura,
            this.colCobrada,
            this.colImporte,
            this.colFacturaPresup,
            this.colIdObra2,
            this.colIdClienteFact,
            this.colFactura,
            this.colEntregada,
            this.colNoDetalle,
            this.colImpCobrado,
            this.colImpPendiente});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colEntregada;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightGray;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colImpPendiente;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition2.Value1 = new decimal(new int[] {
            1,
            0,
            0,
            0});
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colFacturaPresup;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition4.Appearance.Options.UseFont = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colFacturaPresup;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            this.gridView6.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4});
            this.gridView6.GridControl = this.facturasCabGridControl;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsDetail.EnableMasterViewMode = false;
            this.gridView6.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView6.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumFactura, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView6.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView6_FocusedRowChanged);
            this.gridView6.ColumnFilterChanged += new System.EventHandler(this.gridView6_ColumnFilterChanged);
            // 
            // colIdFactCab2
            // 
            this.colIdFactCab2.FieldName = "IdFactCab";
            this.colIdFactCab2.Name = "colIdFactCab2";
            this.colIdFactCab2.OptionsColumn.AllowEdit = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Cliente";
            this.colIdCliente.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsColumn.AllowEdit = false;
            this.colIdCliente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdCliente.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 3;
            this.colIdCliente.Width = 101;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesCliente", "Cliente", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit4.DataSource = this.clientesBindingSource2;
            this.repositoryItemLookUpEdit4.DisplayMember = "DesCliente";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.NullText = "";
            this.repositoryItemLookUpEdit4.ValueMember = "IdCliente";
            // 
            // colIdPresup
            // 
            this.colIdPresup.FieldName = "IdPresup";
            this.colIdPresup.Name = "colIdPresup";
            this.colIdPresup.OptionsColumn.AllowEdit = false;
            // 
            // colNumFactura
            // 
            this.colNumFactura.Caption = "Nº";
            this.colNumFactura.FieldName = "NumFactura";
            this.colNumFactura.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNumFactura.Name = "colNumFactura";
            this.colNumFactura.OptionsColumn.AllowEdit = false;
            this.colNumFactura.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumFactura.Visible = true;
            this.colNumFactura.VisibleIndex = 0;
            this.colNumFactura.Width = 35;
            // 
            // colFechaFactura
            // 
            this.colFechaFactura.Caption = "Fecha";
            this.colFechaFactura.FieldName = "FechaFactura";
            this.colFechaFactura.Name = "colFechaFactura";
            this.colFechaFactura.OptionsColumn.AllowEdit = false;
            this.colFechaFactura.Visible = true;
            this.colFechaFactura.VisibleIndex = 1;
            this.colFechaFactura.Width = 62;
            // 
            // colImporte
            // 
            this.colImporte.AppearanceHeader.Options.UseTextOptions = true;
            this.colImporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImporte.Caption = "Total";
            this.colImporte.DisplayFormat.FormatString = "N2";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.OptionsColumn.AllowEdit = false;
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 5;
            this.colImporte.Width = 80;
            // 
            // colIdObra2
            // 
            this.colIdObra2.Caption = "Obra";
            this.colIdObra2.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colIdObra2.FieldName = "IdObra";
            this.colIdObra2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdObra2.Name = "colIdObra2";
            this.colIdObra2.OptionsColumn.AllowEdit = false;
            this.colIdObra2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdObra2.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colIdObra2.Visible = true;
            this.colIdObra2.VisibleIndex = 2;
            this.colIdObra2.Width = 96;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Obra", "Obra", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit3.DataSource = this.obrasBindingSource1;
            this.repositoryItemLookUpEdit3.DisplayMember = "Obra";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "IdObra";
            // 
            // colIdClienteFact
            // 
            this.colIdClienteFact.Caption = "Cliente Factura";
            this.colIdClienteFact.ColumnEdit = this.ClienteFactura;
            this.colIdClienteFact.FieldName = "IdClienteFact";
            this.colIdClienteFact.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdClienteFact.Name = "colIdClienteFact";
            this.colIdClienteFact.OptionsColumn.AllowEdit = false;
            this.colIdClienteFact.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdClienteFact.Visible = true;
            this.colIdClienteFact.VisibleIndex = 4;
            this.colIdClienteFact.Width = 98;
            // 
            // ClienteFactura
            // 
            this.ClienteFactura.AutoHeight = false;
            this.ClienteFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ClienteFactura.DataSource = this.clientesBindingSource1;
            this.ClienteFactura.DisplayMember = "DesCliente";
            this.ClienteFactura.Name = "ClienteFactura";
            this.ClienteFactura.ValueMember = "IdCliente";
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            this.colFactura.OptionsColumn.AllowEdit = false;
            // 
            // colNoDetalle
            // 
            this.colNoDetalle.FieldName = "NoDetalle";
            this.colNoDetalle.Name = "colNoDetalle";
            this.colNoDetalle.OptionsColumn.AllowEdit = false;
            // 
            // colImpCobrado
            // 
            this.colImpCobrado.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpCobrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpCobrado.Caption = "Cobrado";
            this.colImpCobrado.DisplayFormat.FormatString = "N2";
            this.colImpCobrado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpCobrado.FieldName = "ImpCobrado";
            this.colImpCobrado.Name = "colImpCobrado";
            this.colImpCobrado.Visible = true;
            this.colImpCobrado.VisibleIndex = 6;
            this.colImpCobrado.Width = 69;
            // 
            // colIdEmpresa2
            // 
            this.colIdEmpresa2.FieldName = "IdEmpresa";
            this.colIdEmpresa2.Name = "colIdEmpresa2";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFechaVctoFact
            // 
            this.colFechaVctoFact.FieldName = "FechaVctoFact";
            this.colFechaVctoFact.Name = "colFechaVctoFact";
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            // 
            // colCertificacion
            // 
            this.colCertificacion.FieldName = "Certificacion";
            this.colCertificacion.Name = "colCertificacion";
            // 
            // colIVAFactura
            // 
            this.colIVAFactura.FieldName = "IVAFactura";
            this.colIVAFactura.Name = "colIVAFactura";
            // 
            // colDescFactura
            // 
            this.colDescFactura.FieldName = "DescFactura";
            this.colDescFactura.Name = "colDescFactura";
            // 
            // colDescPronto
            // 
            this.colDescPronto.FieldName = "DescPronto";
            this.colDescPronto.Name = "colDescPronto";
            // 
            // colRetencion
            // 
            this.colRetencion.FieldName = "Retencion";
            this.colRetencion.Name = "colRetencion";
            // 
            // colMostrarVcto
            // 
            this.colMostrarVcto.FieldName = "MostrarVcto";
            this.colMostrarVcto.Name = "colMostrarVcto";
            // 
            // colObsFactura
            // 
            this.colObsFactura.FieldName = "ObsFactura";
            this.colObsFactura.Name = "colObsFactura";
            // 
            // colCopiaFactura
            // 
            this.colCopiaFactura.FieldName = "CopiaFactura";
            this.colCopiaFactura.Name = "colCopiaFactura";
            // 
            // colObsFactura2
            // 
            this.colObsFactura2.FieldName = "ObsFactura2";
            this.colObsFactura2.Name = "colObsFactura2";
            // 
            // colEsPrevision
            // 
            this.colEsPrevision.FieldName = "EsPrevision";
            this.colEsPrevision.Name = "colEsPrevision";
            // 
            // colAnticipo
            // 
            this.colAnticipo.FieldName = "Anticipo";
            this.colAnticipo.Name = "colAnticipo";
            // 
            // colMostrarSubTot
            // 
            this.colMostrarSubTot.FieldName = "MostrarSubTot";
            this.colMostrarSubTot.Name = "colMostrarSubTot";
            // 
            // anticipoTextBox
            // 
            this.anticipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "Anticipo", true));
            this.anticipoTextBox.Location = new System.Drawing.Point(300, 231);
            this.anticipoTextBox.Name = "anticipoTextBox";
            this.anticipoTextBox.Size = new System.Drawing.Size(49, 20);
            this.anticipoTextBox.TabIndex = 127;
            // 
            // esPrevisionCheckEdit
            // 
            this.esPrevisionCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "EsPrevision", true));
            this.esPrevisionCheckEdit.Location = new System.Drawing.Point(242, 33);
            this.esPrevisionCheckEdit.Name = "esPrevisionCheckEdit";
            this.esPrevisionCheckEdit.Properties.Caption = "Previsión";
            this.esPrevisionCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.esPrevisionCheckEdit.TabIndex = 128;
            // 
            // chkSubTot
            // 
            this.chkSubTot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "MostrarSubTot", true));
            this.chkSubTot.Location = new System.Drawing.Point(315, 34);
            this.chkSubTot.Name = "chkSubTot";
            this.chkSubTot.Properties.Caption = "Mostrar Subtotales ";
            this.chkSubTot.Size = new System.Drawing.Size(118, 19);
            this.chkSubTot.TabIndex = 129;
            this.chkSubTot.ToolTip = "Muestra subtotales por días.";
            // 
            // txtSerieFact
            // 
            this.txtSerieFact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "SerieFact", true));
            this.txtSerieFact.Location = new System.Drawing.Point(121, 33);
            this.txtSerieFact.MaxLength = 1;
            this.txtSerieFact.Name = "txtSerieFact";
            this.txtSerieFact.Size = new System.Drawing.Size(22, 20);
            this.txtSerieFact.TabIndex = 130;
            // 
            // chkMostrarObra
            // 
            this.chkMostrarObra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "MostrarObra", true));
            this.chkMostrarObra.Location = new System.Drawing.Point(315, 14);
            this.chkMostrarObra.Name = "chkMostrarObra";
            this.chkMostrarObra.Properties.Caption = "Mostrar Obra";
            this.chkMostrarObra.Size = new System.Drawing.Size(90, 19);
            this.chkMostrarObra.TabIndex = 126;
            // 
            // vPrecioHorasFacturasBindingSource
            // 
            this.vPrecioHorasFacturasBindingSource.DataMember = "vPrecioHorasFacturas";
            this.vPrecioHorasFacturasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // vPrecioHorasFacturasTableAdapter
            // 
            this.vPrecioHorasFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // vPrecioHorasFacturasGridControl
            // 
            this.vPrecioHorasFacturasGridControl.DataSource = this.vPrecioHorasFacturasBindingSource;
            this.vPrecioHorasFacturasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vPrecioHorasFacturasGridControl.Location = new System.Drawing.Point(0, 0);
            this.vPrecioHorasFacturasGridControl.MainView = this.gridView7;
            this.vPrecioHorasFacturasGridControl.Name = "vPrecioHorasFacturasGridControl";
            this.vPrecioHorasFacturasGridControl.Size = new System.Drawing.Size(239, 718);
            this.vPrecioHorasFacturasGridControl.TabIndex = 126;
            this.vPrecioHorasFacturasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa3,
            this.colIdObra3,
            this.colNumFactura1,
            this.colAnoFactura,
            this.colSalarioVenta2,
            this.colDesCategoria2,
            this.colDesTipo2});
            this.gridView7.GridControl = this.vPrecioHorasFacturasGridControl;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsBehavior.Editable = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            this.gridView7.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAnoFactura, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdEmpresa3
            // 
            this.colIdEmpresa3.FieldName = "IdEmpresa";
            this.colIdEmpresa3.Name = "colIdEmpresa3";
            // 
            // colIdObra3
            // 
            this.colIdObra3.FieldName = "IdObra";
            this.colIdObra3.Name = "colIdObra3";
            // 
            // colNumFactura1
            // 
            this.colNumFactura1.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumFactura1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNumFactura1.Caption = "Fra.";
            this.colNumFactura1.FieldName = "NumFactura";
            this.colNumFactura1.Name = "colNumFactura1";
            this.colNumFactura1.Visible = true;
            this.colNumFactura1.VisibleIndex = 0;
            this.colNumFactura1.Width = 31;
            // 
            // colAnoFactura
            // 
            this.colAnoFactura.AppearanceHeader.Options.UseTextOptions = true;
            this.colAnoFactura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAnoFactura.Caption = "Año";
            this.colAnoFactura.FieldName = "AnoFactura";
            this.colAnoFactura.Name = "colAnoFactura";
            this.colAnoFactura.Visible = true;
            this.colAnoFactura.VisibleIndex = 1;
            this.colAnoFactura.Width = 36;
            // 
            // colSalarioVenta2
            // 
            this.colSalarioVenta2.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalarioVenta2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalarioVenta2.Caption = "Precio";
            this.colSalarioVenta2.FieldName = "SalarioVenta";
            this.colSalarioVenta2.Name = "colSalarioVenta2";
            this.colSalarioVenta2.Visible = true;
            this.colSalarioVenta2.VisibleIndex = 4;
            this.colSalarioVenta2.Width = 48;
            // 
            // colDesCategoria2
            // 
            this.colDesCategoria2.Caption = "Categoría";
            this.colDesCategoria2.FieldName = "DesCategoria";
            this.colDesCategoria2.Name = "colDesCategoria2";
            this.colDesCategoria2.Visible = true;
            this.colDesCategoria2.VisibleIndex = 3;
            this.colDesCategoria2.Width = 84;
            // 
            // colDesTipo2
            // 
            this.colDesTipo2.Caption = "Tipo";
            this.colDesTipo2.FieldName = "DesTipo";
            this.colDesTipo2.Name = "colDesTipo2";
            this.colDesTipo2.Visible = true;
            this.colDesTipo2.VisibleIndex = 2;
            this.colDesTipo2.Width = 46;
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "Tipos";
            this.tiposBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vPrecioHorasFacturasGridControl);
            this.splitContainer1.Size = new System.Drawing.Size(1553, 718);
            this.splitContainer1.SplitterDistance = 1310;
            this.splitContainer1.TabIndex = 127;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1310, 718);
            this.splitContainer2.SplitterDistance = 398;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.facturasCabGridControl);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.unificarMaterialCheckEdit);
            this.splitContainer3.Panel2.Controls.Add(this.txtSerieFact);
            this.splitContainer3.Panel2.Controls.Add(this.facturaCheckBox);
            this.splitContainer3.Panel2.Controls.Add(this.chkMostrarObra);
            this.splitContainer3.Panel2.Controls.Add(this.importeTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.chkSubTot);
            this.splitContainer3.Panel2.Controls.Add(this.obsFacturaTextEdit);
            this.splitContainer3.Panel2.Controls.Add(anticipoLabel);
            this.splitContainer3.Panel2.Controls.Add(this.idClienteComboBox);
            this.splitContainer3.Panel2.Controls.Add(label3);
            this.splitContainer3.Panel2.Controls.Add(this.esPrevisionCheckEdit);
            this.splitContainer3.Panel2.Controls.Add(fechaExpLabel);
            this.splitContainer3.Panel2.Controls.Add(idClienteLabel);
            this.splitContainer3.Panel2.Controls.Add(this.anticipoTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.idPresupComboBox);
            this.splitContainer3.Panel2.Controls.Add(this.button5);
            this.splitContainer3.Panel2.Controls.Add(this.fechaExpDateTimePicker);
            this.splitContainer3.Panel2.Controls.Add(this.impBaseTextBox);
            this.splitContainer3.Panel2.Controls.Add(idPresupLabel);
            this.splitContainer3.Panel2.Controls.Add(impIVALabel);
            this.splitContainer3.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer3.Panel2.Controls.Add(impBaseLabel);
            this.splitContainer3.Panel2.Controls.Add(this.button2);
            this.splitContainer3.Panel2.Controls.Add(this.impIVATextBox);
            this.splitContainer3.Panel2.Controls.Add(desFormaPagoLabel);
            this.splitContainer3.Panel2.Controls.Add(this.numFacturaTextBox);
            this.splitContainer3.Panel2.Controls.Add(numFacturaLabel);
            this.splitContainer3.Panel2.Controls.Add(this.desFormaPagoComboBox);
            this.splitContainer3.Panel2.Controls.Add(this.fechaFacturaDateTimePicker);
            this.splitContainer3.Panel2.Controls.Add(this.noDetalleCheckEdit);
            this.splitContainer3.Panel2.Controls.Add(fechaFacturaLabel);
            this.splitContainer3.Panel2.Controls.Add(this.entregadaCheckBox);
            this.splitContainer3.Panel2.Controls.Add(this.fechaVctoFactDateTimePicker);
            this.splitContainer3.Panel2.Controls.Add(fechaVctoFactLabel);
            this.splitContainer3.Panel2.Controls.Add(copiaFacturaLabel);
            this.splitContainer3.Panel2.Controls.Add(this.idCuentaComboBox);
            this.splitContainer3.Panel2.Controls.Add(label1);
            this.splitContainer3.Panel2.Controls.Add(idCuentaLabel);
            this.splitContainer3.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer3.Panel2.Controls.Add(this.certificacionTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.copiaFacturaTextBox);
            this.splitContainer3.Panel2.Controls.Add(certificacionLabel);
            this.splitContainer3.Panel2.Controls.Add(this.button4);
            this.splitContainer3.Panel2.Controls.Add(this.iVAFacturaTextBox);
            this.splitContainer3.Panel2.Controls.Add(obsFacturaLabel);
            this.splitContainer3.Panel2.Controls.Add(iVAFacturaLabel);
            this.splitContainer3.Panel2.Controls.Add(label25);
            this.splitContainer3.Panel2.Controls.Add(this.descFacuraTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.button3);
            this.splitContainer3.Panel2.Controls.Add(descFacuraLabel);
            this.splitContainer3.Panel2.Controls.Add(this.textBox23);
            this.splitContainer3.Panel2.Controls.Add(this.importeTextBox1);
            this.splitContainer3.Panel2.Controls.Add(label24);
            this.splitContainer3.Panel2.Controls.Add(importeLabel1);
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Panel2.Controls.Add(this.textBox15);
            this.splitContainer3.Panel2.Controls.Add(this.textBox22);
            this.splitContainer3.Panel2.Controls.Add(label13);
            this.splitContainer3.Panel2.Controls.Add(mostrarVctoLabel);
            this.splitContainer3.Panel2.Controls.Add(this.textBox16);
            this.splitContainer3.Panel2.Controls.Add(this.mostrarVctoCheckBox);
            this.splitContainer3.Panel2.Controls.Add(label14);
            this.splitContainer3.Panel2.Controls.Add(label23);
            this.splitContainer3.Panel2.Controls.Add(this.textBox17);
            this.splitContainer3.Panel2.Controls.Add(this.textBox21);
            this.splitContainer3.Panel2.Controls.Add(label18);
            this.splitContainer3.Panel2.Controls.Add(label21);
            this.splitContainer3.Panel2.Controls.Add(this.descProntoTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.textBox20);
            this.splitContainer3.Panel2.Controls.Add(descProntoLabel);
            this.splitContainer3.Panel2.Controls.Add(retencionLabel);
            this.splitContainer3.Panel2.Controls.Add(this.retencionTextBox);
            this.splitContainer3.Size = new System.Drawing.Size(1310, 398);
            this.splitContainer3.SplitterDistance = 636;
            this.splitContainer3.TabIndex = 0;
            // 
            // unificarMaterialCheckEdit
            // 
            this.unificarMaterialCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "UnificarMaterial", true));
            this.unificarMaterialCheckEdit.Location = new System.Drawing.Point(424, 16);
            this.unificarMaterialCheckEdit.Name = "unificarMaterialCheckEdit";
            this.unificarMaterialCheckEdit.Properties.Caption = "Unificar Material";
            this.unificarMaterialCheckEdit.Size = new System.Drawing.Size(107, 19);
            this.unificarMaterialCheckEdit.TabIndex = 131;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer4.Size = new System.Drawing.Size(1310, 316);
            this.splitContainer4.SplitterDistance = 636;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.vFacturaDetHorasGridControl);
            this.splitContainer5.Panel1.Controls.Add(this.bindingNavigator4);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.vHorasTrabajadasGridControl);
            this.splitContainer5.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainer5.Size = new System.Drawing.Size(636, 316);
            this.splitContainer5.SplitterDistance = 143;
            this.splitContainer5.TabIndex = 0;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = null;
            this.bindingNavigator4.BindingSource = this.vFacturaDetHorasBindingSource;
            this.bindingNavigator4.CountItem = null;
            this.bindingNavigator4.DeleteItem = null;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator4.MoveFirstItem = null;
            this.bindingNavigator4.MoveLastItem = null;
            this.bindingNavigator4.MoveNextItem = null;
            this.bindingNavigator4.MovePreviousItem = null;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = null;
            this.bindingNavigator4.Size = new System.Drawing.Size(636, 25);
            this.bindingNavigator4.TabIndex = 116;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel4.Text = "Detalles Factura";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.vProductosUtilizadosGridControl);
            this.splitContainer6.Panel1.Controls.Add(this.bindingNavigator3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer6.Size = new System.Drawing.Size(670, 316);
            this.splitContainer6.SplitterDistance = 142;
            this.splitContainer6.TabIndex = 0;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BindingSource = this.vFacturaDetHorasBindingSource;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(670, 25);
            this.bindingNavigator3.TabIndex = 115;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(120, 22);
            this.toolStripLabel3.Text = "Productos Utilizados";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.descuentosFacturasGridControl);
            this.splitContainer7.Panel1.Controls.Add(this.bindingNavigator2);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.obsFactura2TextBox);
            this.splitContainer7.Panel2.Controls.Add(obsFactura2Label);
            this.splitContainer7.Size = new System.Drawing.Size(670, 170);
            this.splitContainer7.SplitterDistance = 113;
            this.splitContainer7.TabIndex = 0;
            // 
            // FacturasHorasMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1553, 743);
            this.Controls.Add(this.cbxfacturas);
            this.Controls.Add(this.cbxanos);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.facturasCabBindingNavigator);
            this.Name = "FacturasHorasMateriales";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación Parte de Trabajadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacturasHorasMateriales_FormClosing);
            this.Load += new System.EventHandler(this.FacturasPresup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anosFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importeFacturaHorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasTrabajadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFacturaDetHorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vHorasTrabajadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductosUtilizadosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosUtilizadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFacturaDetHorasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vHorasTrabajadasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosUtilizadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentosFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentosFacturasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaIncorrectaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsFacturaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingNavigator)).EndInit();
            this.facturasCabBindingNavigator.ResumeLayout(false);
            this.facturasCabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noDetalleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esPrevisionCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubTot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarObra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrecioHorasFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrecioHorasFacturasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unificarMaterialCheckEdit.Properties)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource facturasCabBindingSource;
        private Promowork_dataDataSetTableAdapters.FacturasCabTableAdapter facturasCabTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Promowork_dataDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource;
        private Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter cuentasBancosTableAdapter;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private Promowork_dataDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource horasTrabajadasBindingSource;
        private Promowork_dataDataSetTableAdapters.HorasTrabajadasTableAdapter horasTrabajadasTableAdapter;
        private System.Windows.Forms.BindingSource empresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter empresasActualTableAdapter;
        private System.Windows.Forms.BindingSource obrasBindingSource1;
        private System.Windows.Forms.BindingSource vFacturaDetHorasBindingSource;
        private Promowork_dataDataSetTableAdapters.vFacturaDetHorasTableAdapter vFacturaDetHorasTableAdapter;
        private System.Windows.Forms.BindingSource vHorasTrabajadasBindingSource;
        private Promowork_dataDataSetTableAdapters.vHorasTrabajadasTableAdapter vHorasTrabajadasTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHoras1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad1;
        private DevExpress.XtraGrid.GridControl vProductosUtilizadosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl vFacturaDetHorasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdFactDetHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab;
        private DevExpress.XtraGrid.Columns.GridColumn IdHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaTrab;
        private DevExpress.XtraGrid.Columns.GridColumn colMesTrab;
        private DevExpress.XtraGrid.Columns.GridColumn colAnoTrab;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNumTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colNomTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colApeTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colCantAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colSalarioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colDesTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colDirTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturado;
        private DevExpress.XtraGrid.Columns.GridColumn colDesTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colSalario;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DevExpress.XtraGrid.GridControl vHorasTrabajadasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaTrab1;
        private DevExpress.XtraGrid.Columns.GridColumn colMesTrab1;
        private DevExpress.XtraGrid.Columns.GridColumn colAnoTrab1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantAdmin1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalarioVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesTrabajo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDirTrabajo1;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturado1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesTipo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCategoria1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumTrabajador1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomTrabajador1;
        private DevExpress.XtraGrid.Columns.GridColumn colApeTrabajador1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHoras3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador1;
        private DevExpress.XtraGrid.Columns.GridColumn colFestivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad3;
        private DevExpress.XtraGrid.Columns.GridColumn colSalario1;
        private Promowork_dataDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.BindingSource productosUtilizadosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProdUtiliza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHoras2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHorasAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPVP;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colPorciento;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad2;
        private Promowork_dataDataSetTableAdapters.ProductosUtilizadosTableAdapter productosUtilizadosTableAdapter;
        private Promowork_dataDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private Promowork_dataDataSet promowork_dataDataSet1;
        private System.Windows.Forms.BindingSource productosUtilizadosBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colFestivo;
        private System.Windows.Forms.BindingSource importeFacturaHorasBindingSource;
        private Promowork_dataDataSetTableAdapters.ImporteFacturaHorasTableAdapter importeFacturaHorasTableAdapter;
        private System.Windows.Forms.BindingSource formasPagoBindingSource;
        private Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter formasPagoTableAdapter;
        private System.Windows.Forms.ComboBox desFormaPagoComboBox;
        private System.Windows.Forms.BindingSource cobrosBindingSource;
        private Promowork_dataDataSetTableAdapters.CobrosTableAdapter cobrosTableAdapter;
        private System.Windows.Forms.TextBox impBaseTextBox;
        private System.Windows.Forms.TextBox impIVATextBox;
        private System.Windows.Forms.DateTimePicker fechaExpDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource1;
        private System.Windows.Forms.BindingSource descuentosFacturasBindingSource;
        private Promowork_dataDataSetTableAdapters.DescuentosFacturasTableAdapter descuentosFacturasTableAdapter;
        private DevExpress.XtraGrid.GridControl descuentosFacturasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDesFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colImpDescuento;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.BindingSource anosFacturasBindingSource;
        private Promowork_dataDataSetTableAdapters.AnosFacturasTableAdapter anosFacturasTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaParte;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaParte1;
        private System.Windows.Forms.TextBox obsFactura2TextBox;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.BindingSource facturaIncorrectaBindingSource;
        private Promowork_dataDataSetTableAdapters.FacturaIncorrectaTableAdapter facturaIncorrectaTableAdapter;
        private System.Windows.Forms.TextBox importeTextBox;
        private DevExpress.XtraEditors.MemoEdit obsFacturaTextEdit;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.ComboBox idPresupComboBox;
        private System.Windows.Forms.TextBox numFacturaTextBox;
        private System.Windows.Forms.DateTimePicker fechaFacturaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaVctoFactDateTimePicker;
        private System.Windows.Forms.ComboBox idCuentaComboBox;
        private System.Windows.Forms.TextBox certificacionTextBox;
        private System.Windows.Forms.TextBox iVAFacturaTextBox;
        private System.Windows.Forms.TextBox descFacuraTextBox;
        private System.Windows.Forms.TextBox importeTextBox1;
        private System.Windows.Forms.BindingNavigator facturasCabBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton facturasCabBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox descProntoTextBox;
        private System.Windows.Forms.TextBox retencionTextBox;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.CheckBox mostrarVctoCheckBox;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox copiaFacturaTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox facturaCheckBox;
        private System.Windows.Forms.CheckBox entregadaCheckBox;
        private DevExpress.XtraEditors.CheckEdit noDetalleCheckEdit;
        private System.Windows.Forms.ComboBox cbxanos;
        private System.Windows.Forms.ComboBox cbxfacturas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraGrid.GridControl facturasCabGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colCobrada;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteFact;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colEntregada;
        private DevExpress.XtraGrid.Columns.GridColumn colNoDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVctoFact;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCertificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIVAFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colDescPronto;
        private DevExpress.XtraGrid.Columns.GridColumn colRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colMostrarVcto;
        private DevExpress.XtraGrid.Columns.GridColumn colObsFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colObsFactura2;
        private DevExpress.XtraGrid.Columns.GridColumn colEsPrevision;
        private DevExpress.XtraGrid.Columns.GridColumn colAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colMostrarSubTot;
        private System.Windows.Forms.TextBox anticipoTextBox;
        private DevExpress.XtraEditors.CheckEdit esPrevisionCheckEdit;
        private DevExpress.XtraEditors.CheckEdit chkSubTot;
        private DevExpress.XtraEditors.CheckEdit chkMostrarObra;
        private System.Windows.Forms.BindingSource vPrecioHorasFacturasBindingSource;
        private Promowork_dataDataSetTableAdapters.vPrecioHorasFacturasTableAdapter vPrecioHorasFacturasTableAdapter;
        private DevExpress.XtraGrid.GridControl vPrecioHorasFacturasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra3;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colAnoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colSalarioVenta2;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private Promowork_dataDataSetTableAdapters.TiposTableAdapter tiposTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCategoria2;
        private DevExpress.XtraGrid.Columns.GridColumn colDesTipo2;
        private DevExpress.XtraGrid.Columns.GridColumn colImpCobrado;
        private DevExpress.XtraGrid.Columns.GridColumn colImpPendiente;
        private System.Windows.Forms.TextBox txtSerieFact;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuentoProducto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuentoHoras;
        private DevExpress.XtraEditors.CheckEdit unificarMaterialCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ClienteFactura;
    }
}