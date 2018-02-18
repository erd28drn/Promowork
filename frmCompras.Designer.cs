namespace Promowork
{
    partial class frmCompras
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
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label facturaLabel;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label fechaRecibLabel;
            System.Windows.Forms.Label fechaVctoLabel;
            System.Windows.Forms.Label idFormaPagoLabel;
            System.Windows.Forms.Label idCuentaLabel;
            System.Windows.Forms.Label copiaFacturaLabel;
            System.Windows.Forms.Label observLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label fechaPagoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.vComprasProveedoresGridControl = new DevExpress.XtraGrid.GridControl();
            this.comprasCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.gvComprasCab = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Proveedores = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRecib = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormasPago = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.formasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cuentas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vCuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCopiaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIRPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObserv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaFacturaImg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpPagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaDirecta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comprasCabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbtDelete = new System.Windows.Forms.ToolStripButton();
            this.tbbtAdd = new System.Windows.Forms.ToolStripButton();
            this.tbbtSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbtPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbcbAnos = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tbcbCargarCompras = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.tbcbObras = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVcto = new System.Windows.Forms.RadioButton();
            this.rbPrevision = new System.Windows.Forms.RadioButton();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tbbtAddPago = new System.Windows.Forms.ToolStripButton();
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbbtDeletePago = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbtSavePago = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.pagosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvPagos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCompra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormaPago = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.formasPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colIdCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cuenta = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vCuentasBancosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colIdOpeBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdConBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportePagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fechaPagoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.facturaDirectaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbImporteSeleccion = new DevExpress.XtraEditors.TextEdit();
            this.tbCantidadSeleccion = new DevExpress.XtraEditors.TextEdit();
            this.facturaPendienteCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.pagadaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cbCuenta = new DevExpress.XtraEditors.LookUpEdit();
            this.cbFormaPago = new DevExpress.XtraEditors.LookUpEdit();
            this.fechaVctoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fechaRecibDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fechaFacturaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.facturaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cbProveedores = new DevExpress.XtraEditors.LookUpEdit();
            this.tbCopiaFactura = new DevExpress.XtraEditors.ButtonEdit();
            this.observTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl5 = new DevExpress.XtraEditors.SplitContainerControl();
            this.comprasDetGridControl = new DevExpress.XtraGrid.GridControl();
            this.comprasDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvComprasDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompraCompraDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObraCompraDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Obras = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colImpBaseCompraDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIvaCompraDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVACompraDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIRPF1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl4 = new DevExpress.XtraEditors.SplitContainerControl();
            this.albaranesCabGridControl = new DevExpress.XtraGrid.GridControl();
            this.albaranesCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosAlbaranes = new Promowork.DatosAlbaranes();
            this.gvAlbaranesCompra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAlbaranCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsecutivoAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaRecibida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteAlbaranCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObraAlbaranCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObrasAlbaranes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vObrasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.colQuitarAsociacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuitarAsociacion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colModificaImporteCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.albaranesCabProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosAlbaranesProveedor = new Promowork.DatosAlbaranes();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.albaranesDetGridControl = new DevExpress.XtraGrid.GridControl();
            this.vImportarAlbaranesDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAlbaranesDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAlbaranDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAlbaranCab2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLugarUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProductoInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodUmedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorciento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tbbtAddDet = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbtDeleteDet = new System.Windows.Forms.ToolStripButton();
            this.tbbtSaveDet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.chkAutocalcular = new DevExpress.XtraEditors.CheckEdit();
            this.albaranesCabGridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvAlbaranesProveedorObra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAsociar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AsociarAFactura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIdAlbaranCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumAlbaran1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAlbaran1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaAlbaran1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObraAlbaranProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbObraAlbaran = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vObrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colConsecutivoAlbaran1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilizado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaRecibida1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinAlbaran1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteAlbaranProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModificaImporteCompraAlbProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tbcbCargaAlbaranes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tbIVA = new System.Windows.Forms.ToolStripTextBox();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.comprasCabTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ComprasCabTableAdapter();
            this.comprasDetTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ComprasDetTableAdapter();
            this.anosComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anosComprasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.AnosComprasTableAdapter();
            this.vObrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vObrasTableAdapter();
            this.vProveedoresTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vProveedoresTableAdapter();
            this.formasPagoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter();
            this.vCuentasBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vCuentasBancosTableAdapter();
            this.albaranesCabTableAdapter = new Promowork.DatosAlbaranesTableAdapters.AlbaranesCabTableAdapter();
            this.tableAdapterManager1 = new Promowork.DatosAlbaranesTableAdapters.TableAdapterManager();
            this.albaranesCabProveedoresTableAdapter = new Promowork.DatosAlbaranesTableAdapters.AlbaranesCabTableAdapter();
            this.tableAdapterManager2 = new Promowork.DatosAlbaranesTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.vImportarAlbaranesDetTableAdapter = new Promowork.DatosAlbaranesTableAdapters.vImportarAlbaranesDetTableAdapter();
            this.pagosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.PagosTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            idProveedorLabel = new System.Windows.Forms.Label();
            facturaLabel = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            fechaRecibLabel = new System.Windows.Forms.Label();
            fechaVctoLabel = new System.Windows.Forms.Label();
            idFormaPagoLabel = new System.Windows.Forms.Label();
            idCuentaLabel = new System.Windows.Forms.Label();
            copiaFacturaLabel = new System.Windows.Forms.Label();
            observLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasProveedoresGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComprasCab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormasPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasCabBindingNavigator)).BeginInit();
            this.comprasCabBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCuentasBancosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPagoDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPagoDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDirectaCheckEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImporteSeleccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadSeleccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaPendienteCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadaCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVctoDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVctoDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaRecibDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaRecibDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaFacturaDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaFacturaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCopiaFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).BeginInit();
            this.splitContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComprasDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).BeginInit();
            this.splitContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbaranesCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObrasAlbaranes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vObrasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitarAsociacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranesProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesDetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbaranesDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutocalcular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbaranesProveedorObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsociarAFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObraAlbaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vObrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosComprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(72, 43);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(59, 13);
            idProveedorLabel.TabIndex = 0;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // facturaLabel
            // 
            facturaLabel.AutoSize = true;
            facturaLabel.Location = new System.Drawing.Point(85, 69);
            facturaLabel.Name = "facturaLabel";
            facturaLabel.Size = new System.Drawing.Size(46, 13);
            facturaLabel.TabIndex = 2;
            facturaLabel.Text = "Factura:";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(52, 95);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(79, 13);
            fechaFacturaLabel.TabIndex = 4;
            fechaFacturaLabel.Text = "Fecha Factura:";
            // 
            // fechaRecibLabel
            // 
            fechaRecibLabel.AutoSize = true;
            fechaRecibLabel.Location = new System.Drawing.Point(60, 121);
            fechaRecibLabel.Name = "fechaRecibLabel";
            fechaRecibLabel.Size = new System.Drawing.Size(71, 13);
            fechaRecibLabel.TabIndex = 6;
            fechaRecibLabel.Text = "Fecha Recib:";
            // 
            // fechaVctoLabel
            // 
            fechaVctoLabel.AutoSize = true;
            fechaVctoLabel.Location = new System.Drawing.Point(30, 147);
            fechaVctoLabel.Name = "fechaVctoLabel";
            fechaVctoLabel.Size = new System.Drawing.Size(101, 13);
            fechaVctoLabel.TabIndex = 8;
            fechaVctoLabel.Text = "Fecha Vencimiento:";
            // 
            // idFormaPagoLabel
            // 
            idFormaPagoLabel.AutoSize = true;
            idFormaPagoLabel.Location = new System.Drawing.Point(64, 199);
            idFormaPagoLabel.Name = "idFormaPagoLabel";
            idFormaPagoLabel.Size = new System.Drawing.Size(67, 13);
            idFormaPagoLabel.TabIndex = 10;
            idFormaPagoLabel.Text = "Forma Pago:";
            // 
            // idCuentaLabel
            // 
            idCuentaLabel.AutoSize = true;
            idCuentaLabel.Location = new System.Drawing.Point(87, 225);
            idCuentaLabel.Name = "idCuentaLabel";
            idCuentaLabel.Size = new System.Drawing.Size(44, 13);
            idCuentaLabel.TabIndex = 12;
            idCuentaLabel.Text = "Cuenta:";
            // 
            // copiaFacturaLabel
            // 
            copiaFacturaLabel.AutoSize = true;
            copiaFacturaLabel.Location = new System.Drawing.Point(55, 251);
            copiaFacturaLabel.Name = "copiaFacturaLabel";
            copiaFacturaLabel.Size = new System.Drawing.Size(76, 13);
            copiaFacturaLabel.TabIndex = 14;
            copiaFacturaLabel.Text = "Copia Factura:";
            // 
            // observLabel
            // 
            observLabel.AutoSize = true;
            observLabel.Location = new System.Drawing.Point(50, 277);
            observLabel.Name = "observLabel";
            observLabel.Size = new System.Drawing.Size(81, 13);
            observLabel.TabIndex = 18;
            observLabel.Text = "Observaciones:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 23;
            label1.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(206, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 25;
            label2.Text = "Importe:";
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(17, 173);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(114, 13);
            fechaPagoLabel.TabIndex = 23;
            fechaPagoLabel.Text = "Fecha Previsión Pago:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1728, 859);
            this.splitContainerControl1.SplitterPosition = 620;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.vComprasProveedoresGridControl);
            this.splitContainerControl2.Panel1.Controls.Add(this.comprasCabBindingNavigator);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.button6);
            this.splitContainerControl2.Panel2.Controls.Add(this.button5);
            this.splitContainerControl2.Panel2.Controls.Add(this.button2);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerControl2.Panel2.Controls.Add(this.bindingNavigator5);
            this.splitContainerControl2.Panel2.Controls.Add(this.pagosGridControl);
            this.splitContainerControl2.Panel2.Controls.Add(fechaPagoLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.fechaPagoDateEdit);
            this.splitContainerControl2.Panel2.Controls.Add(this.facturaDirectaCheckEdit);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerControl2.Panel2.Controls.Add(this.facturaPendienteCheckEdit);
            this.splitContainerControl2.Panel2.Controls.Add(observLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.pagadaCheckEdit);
            this.splitContainerControl2.Panel2.Controls.Add(copiaFacturaLabel);
            this.splitContainerControl2.Panel2.Controls.Add(idCuentaLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.cbCuenta);
            this.splitContainerControl2.Panel2.Controls.Add(idFormaPagoLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.cbFormaPago);
            this.splitContainerControl2.Panel2.Controls.Add(fechaVctoLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.fechaVctoDateEdit);
            this.splitContainerControl2.Panel2.Controls.Add(fechaRecibLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.fechaRecibDateEdit);
            this.splitContainerControl2.Panel2.Controls.Add(fechaFacturaLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.fechaFacturaDateEdit);
            this.splitContainerControl2.Panel2.Controls.Add(facturaLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.facturaTextEdit);
            this.splitContainerControl2.Panel2.Controls.Add(idProveedorLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.cbProveedores);
            this.splitContainerControl2.Panel2.Controls.Add(this.tbCopiaFactura);
            this.splitContainerControl2.Panel2.Controls.Add(this.observTextEdit);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1728, 620);
            this.splitContainerControl2.SplitterPosition = 511;
            this.splitContainerControl2.TabIndex = 3;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // vComprasProveedoresGridControl
            // 
            this.vComprasProveedoresGridControl.DataSource = this.comprasCabBindingSource;
            this.vComprasProveedoresGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vComprasProveedoresGridControl.Location = new System.Drawing.Point(0, 25);
            this.vComprasProveedoresGridControl.MainView = this.gvComprasCab;
            this.vComprasProveedoresGridControl.Name = "vComprasProveedoresGridControl";
            this.vComprasProveedoresGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Proveedores,
            this.FormasPago,
            this.Cuentas});
            this.vComprasProveedoresGridControl.Size = new System.Drawing.Size(1212, 595);
            this.vComprasProveedoresGridControl.TabIndex = 2;
            this.vComprasProveedoresGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComprasCab});
            // 
            // comprasCabBindingSource
            // 
            this.comprasCabBindingSource.DataMember = "ComprasCab";
            this.comprasCabBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvComprasCab
            // 
            this.gvComprasCab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCompra,
            this.colIdEmpresa,
            this.colidProveedor,
            this.colFactura,
            this.colFechaFactura,
            this.colFechaRecib,
            this.colIdUsuario,
            this.colFechaVcto,
            this.colIdFormaPago,
            this.colIdCuenta,
            this.colCopiaFactura,
            this.colFechaPago,
            this.colPagada,
            this.colImpBase,
            this.colImpIVA,
            this.colImpIRPF,
            this.colObserv,
            this.colcolor1,
            this.colcolor,
            this.colPrevision,
            this.colObsBanco,
            this.colCopiaFacturaImg,
            this.colFacturaPendiente,
            this.colImpPagado,
            this.colImporte,
            this.colFacturaDirecta,
            this.colObras});
            this.gvComprasCab.GridControl = this.vComprasProveedoresGridControl;
            this.gvComprasCab.Name = "gvComprasCab";
            this.gvComprasCab.OptionsBehavior.ReadOnly = true;
            this.gvComprasCab.OptionsDetail.EnableMasterViewMode = false;
            this.gvComprasCab.OptionsSelection.MultiSelect = true;
            this.gvComprasCab.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvComprasCab.OptionsView.ShowAutoFilterRow = true;
            this.gvComprasCab.OptionsView.ShowFooter = true;
            this.gvComprasCab.OptionsView.ShowGroupPanel = false;
            this.gvComprasCab.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvComprasCab_SelectionChanged);
            this.gvComprasCab.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvComprasCab_FocusedRowChanged);
            // 
            // colIdCompra
            // 
            this.colIdCompra.FieldName = "IdCompra";
            this.colIdCompra.Name = "colIdCompra";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colidProveedor
            // 
            this.colidProveedor.Caption = "Proveedor";
            this.colidProveedor.ColumnEdit = this.Proveedores;
            this.colidProveedor.FieldName = "idProveedor";
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.Visible = true;
            this.colidProveedor.VisibleIndex = 0;
            this.colidProveedor.Width = 233;
            // 
            // Proveedores
            // 
            this.Proveedores.AutoHeight = false;
            this.Proveedores.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Proveedores.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProveedor", "Proveedores", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Proveedores.DataSource = this.vProveedoresBindingSource;
            this.Proveedores.DisplayMember = "DesProveedor";
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.ValueMember = "IdProveedor";
            // 
            // vProveedoresBindingSource
            // 
            this.vProveedoresBindingSource.DataMember = "vProveedores";
            this.vProveedoresBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colFactura
            // 
            this.colFactura.Caption = "Factura";
            this.colFactura.FieldName = "Factura";
            this.colFactura.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colFactura.Name = "colFactura";
            this.colFactura.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 1;
            this.colFactura.Width = 87;
            // 
            // colFechaFactura
            // 
            this.colFechaFactura.Caption = "Fecha";
            this.colFechaFactura.FieldName = "FechaFactura";
            this.colFechaFactura.Name = "colFechaFactura";
            this.colFechaFactura.Visible = true;
            this.colFechaFactura.VisibleIndex = 2;
            this.colFechaFactura.Width = 58;
            // 
            // colFechaRecib
            // 
            this.colFechaRecib.FieldName = "FechaRecib";
            this.colFechaRecib.Name = "colFechaRecib";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFechaVcto
            // 
            this.colFechaVcto.Caption = "Vencimiento";
            this.colFechaVcto.FieldName = "FechaVcto";
            this.colFechaVcto.Name = "colFechaVcto";
            this.colFechaVcto.Visible = true;
            this.colFechaVcto.VisibleIndex = 3;
            this.colFechaVcto.Width = 57;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.Caption = "Forma Pago";
            this.colIdFormaPago.ColumnEdit = this.FormasPago;
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.Visible = true;
            this.colIdFormaPago.VisibleIndex = 9;
            this.colIdFormaPago.Width = 134;
            // 
            // FormasPago
            // 
            this.FormasPago.AutoHeight = false;
            this.FormasPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FormasPago.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesFormaPago", "Formas Pago", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.FormasPago.DataSource = this.formasPagoBindingSource;
            this.FormasPago.DisplayMember = "DesFormaPago";
            this.FormasPago.Name = "FormasPago";
            this.FormasPago.ValueMember = "IdFormaPago";
            // 
            // formasPagoBindingSource
            // 
            this.formasPagoBindingSource.DataMember = "FormasPago";
            this.formasPagoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "Cuenta";
            this.colIdCuenta.ColumnEdit = this.Cuentas;
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Visible = true;
            this.colIdCuenta.VisibleIndex = 10;
            this.colIdCuenta.Width = 231;
            // 
            // Cuentas
            // 
            this.Cuentas.AutoHeight = false;
            this.Cuentas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cuentas.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BancoCuenta", "Cuentas", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Cuentas.DataSource = this.vCuentasBancosBindingSource;
            this.Cuentas.DisplayMember = "BancoCuenta";
            this.Cuentas.Name = "Cuentas";
            this.Cuentas.ValueMember = "IdCuenta";
            // 
            // vCuentasBancosBindingSource
            // 
            this.vCuentasBancosBindingSource.DataMember = "vCuentasBancos";
            this.vCuentasBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colCopiaFactura
            // 
            this.colCopiaFactura.FieldName = "CopiaFactura";
            this.colCopiaFactura.Name = "colCopiaFactura";
            // 
            // colFechaPago
            // 
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            // 
            // colPagada
            // 
            this.colPagada.Caption = "Pagada";
            this.colPagada.FieldName = "Pagada";
            this.colPagada.Name = "colPagada";
            this.colPagada.Width = 78;
            // 
            // colImpBase
            // 
            this.colImpBase.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpBase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpBase.Caption = "Importe Base";
            this.colImpBase.FieldName = "ImpBase";
            this.colImpBase.Name = "colImpBase";
            this.colImpBase.OptionsColumn.ReadOnly = true;
            this.colImpBase.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpBase", "{0:c2}")});
            this.colImpBase.Visible = true;
            this.colImpBase.VisibleIndex = 4;
            this.colImpBase.Width = 69;
            // 
            // colImpIVA
            // 
            this.colImpIVA.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpIVA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpIVA.Caption = "Importe IVA";
            this.colImpIVA.FieldName = "ImpIVA";
            this.colImpIVA.Name = "colImpIVA";
            this.colImpIVA.OptionsColumn.ReadOnly = true;
            this.colImpIVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpIVA", "{0:c2}")});
            this.colImpIVA.Visible = true;
            this.colImpIVA.VisibleIndex = 5;
            this.colImpIVA.Width = 61;
            // 
            // colImpIRPF
            // 
            this.colImpIRPF.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpIRPF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpIRPF.Caption = "Importe IRPF";
            this.colImpIRPF.FieldName = "ImpIRPF";
            this.colImpIRPF.Name = "colImpIRPF";
            this.colImpIRPF.OptionsColumn.ReadOnly = true;
            this.colImpIRPF.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpIRPF", "{0:c2}")});
            this.colImpIRPF.Visible = true;
            this.colImpIRPF.VisibleIndex = 6;
            this.colImpIRPF.Width = 67;
            // 
            // colObserv
            // 
            this.colObserv.FieldName = "Observ";
            this.colObserv.Name = "colObserv";
            // 
            // colcolor1
            // 
            this.colcolor1.FieldName = "color1";
            this.colcolor1.Name = "colcolor1";
            this.colcolor1.OptionsColumn.ReadOnly = true;
            // 
            // colcolor
            // 
            this.colcolor.FieldName = "color";
            this.colcolor.Name = "colcolor";
            // 
            // colPrevision
            // 
            this.colPrevision.Caption = "Previsión";
            this.colPrevision.FieldName = "Prevision";
            this.colPrevision.Name = "colPrevision";
            this.colPrevision.Width = 78;
            // 
            // colObsBanco
            // 
            this.colObsBanco.FieldName = "ObsBanco";
            this.colObsBanco.Name = "colObsBanco";
            // 
            // colCopiaFacturaImg
            // 
            this.colCopiaFacturaImg.FieldName = "CopiaFacturaImg";
            this.colCopiaFacturaImg.Name = "colCopiaFacturaImg";
            // 
            // colFacturaPendiente
            // 
            this.colFacturaPendiente.Caption = "Pendiente Recibir";
            this.colFacturaPendiente.FieldName = "FacturaPendiente";
            this.colFacturaPendiente.Name = "colFacturaPendiente";
            this.colFacturaPendiente.Width = 78;
            // 
            // colImpPagado
            // 
            this.colImpPagado.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpPagado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpPagado.Caption = "Importe Pagado";
            this.colImpPagado.FieldName = "ImpPagado";
            this.colImpPagado.Name = "colImpPagado";
            this.colImpPagado.OptionsColumn.ReadOnly = true;
            this.colImpPagado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpPagado", "{0:c2}")});
            this.colImpPagado.Visible = true;
            this.colImpPagado.VisibleIndex = 8;
            this.colImpPagado.Width = 82;
            // 
            // colImporte
            // 
            this.colImporte.AppearanceHeader.Options.UseTextOptions = true;
            this.colImporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImporte.Caption = "Importe Total";
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")});
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 7;
            this.colImporte.Width = 76;
            // 
            // colFacturaDirecta
            // 
            this.colFacturaDirecta.AppearanceHeader.Options.UseTextOptions = true;
            this.colFacturaDirecta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFacturaDirecta.Caption = "Directa";
            this.colFacturaDirecta.FieldName = "FacturaDirecta";
            this.colFacturaDirecta.Name = "colFacturaDirecta";
            this.colFacturaDirecta.Visible = true;
            this.colFacturaDirecta.VisibleIndex = 11;
            this.colFacturaDirecta.Width = 48;
            // 
            // colObras
            // 
            this.colObras.FieldName = "Obras";
            this.colObras.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colObras.Name = "colObras";
            this.colObras.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // comprasCabBindingNavigator
            // 
            this.comprasCabBindingNavigator.AddNewItem = null;
            this.comprasCabBindingNavigator.BindingSource = this.comprasCabBindingSource;
            this.comprasCabBindingNavigator.CountItem = this.toolStripLabel1;
            this.comprasCabBindingNavigator.DeleteItem = null;
            this.comprasCabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.tbbtDelete,
            this.tbbtAdd,
            this.tbbtSave,
            this.toolStripSeparator7,
            this.tbbtPrint,
            this.toolStripSeparator10,
            this.toolStripLabel2,
            this.tbcbAnos,
            this.toolStripSeparator11,
            this.toolStripLabel3,
            this.tbcbCargarCompras,
            this.toolStripSeparator5,
            this.toolStripLabel10,
            this.tbcbObras,
            this.toolStripButton1});
            this.comprasCabBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.comprasCabBindingNavigator.MoveFirstItem = this.toolStripButton2;
            this.comprasCabBindingNavigator.MoveLastItem = this.toolStripButton5;
            this.comprasCabBindingNavigator.MoveNextItem = this.toolStripButton4;
            this.comprasCabBindingNavigator.MovePreviousItem = this.toolStripButton3;
            this.comprasCabBindingNavigator.Name = "comprasCabBindingNavigator";
            this.comprasCabBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.comprasCabBindingNavigator.Size = new System.Drawing.Size(1212, 25);
            this.comprasCabBindingNavigator.TabIndex = 2;
            this.comprasCabBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move first";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move next";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbtDelete
            // 
            this.tbbtDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbbtDelete.Image")));
            this.tbbtDelete.Name = "tbbtDelete";
            this.tbbtDelete.RightToLeftAutoMirrorImage = true;
            this.tbbtDelete.Size = new System.Drawing.Size(23, 22);
            this.tbbtDelete.Text = "Delete";
            this.tbbtDelete.Click += new System.EventHandler(this.tbbtDelete_Click);
            // 
            // tbbtAdd
            // 
            this.tbbtAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbbtAdd.Image")));
            this.tbbtAdd.Name = "tbbtAdd";
            this.tbbtAdd.RightToLeftAutoMirrorImage = true;
            this.tbbtAdd.Size = new System.Drawing.Size(23, 22);
            this.tbbtAdd.Text = "Add new";
            this.tbbtAdd.Click += new System.EventHandler(this.tbbtAdd_Click);
            // 
            // tbbtSave
            // 
            this.tbbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtSave.Image = ((System.Drawing.Image)(resources.GetObject("tbbtSave.Image")));
            this.tbbtSave.Name = "tbbtSave";
            this.tbbtSave.Size = new System.Drawing.Size(23, 22);
            this.tbbtSave.Text = "Save Data";
            this.tbbtSave.Click += new System.EventHandler(this.tbbtSave_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbtPrint
            // 
            this.tbbtPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtPrint.Image = global::Promowork.Properties.Resources.print11;
            this.tbbtPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbtPrint.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tbbtPrint.Name = "tbbtPrint";
            this.tbbtPrint.Size = new System.Drawing.Size(23, 22);
            this.tbbtPrint.Text = "Posibles Compras Duplicadas desde la fecha Indicada";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "Año: ";
            // 
            // tbcbAnos
            // 
            this.tbcbAnos.DropDownWidth = 75;
            this.tbcbAnos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbcbAnos.Name = "tbcbAnos";
            this.tbcbAnos.Size = new System.Drawing.Size(75, 25);
            this.tbcbAnos.Sorted = true;
            this.tbcbAnos.SelectedIndexChanged += new System.EventHandler(this.tbcbAnos_SelectedIndexChanged);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel3.Text = "Estado: ";
            // 
            // tbcbCargarCompras
            // 
            this.tbcbCargarCompras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbcbCargarCompras.Name = "tbcbCargarCompras";
            this.tbcbCargarCompras.Size = new System.Drawing.Size(150, 25);
            this.tbcbCargarCompras.SelectedIndexChanged += new System.EventHandler(this.tbcbCargarCompras_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel10.Text = "Obra:";
            // 
            // tbcbObras
            // 
            this.tbcbObras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbcbObras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbcbObras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbcbObras.Name = "tbcbObras";
            this.tbcbObras.Size = new System.Drawing.Size(300, 25);
            this.tbcbObras.SelectedIndexChanged += new System.EventHandler(this.tbcbObras_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Promowork.Properties.Resources.sc_removefilter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Quitar filtro de Obra";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVcto);
            this.groupBox2.Controls.Add(this.rbPrevision);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(259, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 65);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            // 
            // rbVcto
            // 
            this.rbVcto.Location = new System.Drawing.Point(6, 12);
            this.rbVcto.Name = "rbVcto";
            this.rbVcto.Size = new System.Drawing.Size(84, 24);
            this.rbVcto.TabIndex = 93;
            this.rbVcto.TabStop = true;
            this.rbVcto.Text = "Vencimiento";
            this.rbVcto.UseVisualStyleBackColor = true;
            // 
            // rbPrevision
            // 
            this.rbPrevision.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.comprasCabBindingSource, "Prevision", true));
            this.rbPrevision.Location = new System.Drawing.Point(6, 39);
            this.rbPrevision.Name = "rbPrevision";
            this.rbPrevision.Size = new System.Drawing.Size(69, 24);
            this.rbPrevision.TabIndex = 92;
            this.rbPrevision.TabStop = true;
            this.rbPrevision.Text = "Previsión";
            this.rbPrevision.UseVisualStyleBackColor = true;
            this.rbPrevision.CheckedChanged += new System.EventHandler(this.previsionRadioButton_CheckedChanged);
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.tbbtAddPago;
            this.bindingNavigator5.BindingSource = this.pagosBindingSource;
            this.bindingNavigator5.CountItem = null;
            this.bindingNavigator5.DeleteItem = this.tbbtDeletePago;
            this.bindingNavigator5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel11,
            this.toolStripSeparator14,
            this.tbbtDeletePago,
            this.tbbtAddPago,
            this.tbbtSavePago,
            this.toolStripSeparator15});
            this.bindingNavigator5.Location = new System.Drawing.Point(0, 405);
            this.bindingNavigator5.MoveFirstItem = null;
            this.bindingNavigator5.MoveLastItem = null;
            this.bindingNavigator5.MoveNextItem = null;
            this.bindingNavigator5.MovePreviousItem = null;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = null;
            this.bindingNavigator5.Size = new System.Drawing.Size(511, 25);
            this.bindingNavigator5.TabIndex = 25;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // tbbtAddPago
            // 
            this.tbbtAddPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtAddPago.Image = ((System.Drawing.Image)(resources.GetObject("tbbtAddPago.Image")));
            this.tbbtAddPago.Name = "tbbtAddPago";
            this.tbbtAddPago.RightToLeftAutoMirrorImage = true;
            this.tbbtAddPago.Size = new System.Drawing.Size(23, 22);
            this.tbbtAddPago.Text = "Add new";
            this.tbbtAddPago.Click += new System.EventHandler(this.tbbtAddPago_Click);
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataMember = "Pagos";
            this.pagosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // tbbtDeletePago
            // 
            this.tbbtDeletePago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtDeletePago.Image = ((System.Drawing.Image)(resources.GetObject("tbbtDeletePago.Image")));
            this.tbbtDeletePago.Name = "tbbtDeletePago";
            this.tbbtDeletePago.RightToLeftAutoMirrorImage = true;
            this.tbbtDeletePago.Size = new System.Drawing.Size(23, 22);
            this.tbbtDeletePago.Text = "Delete";
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel11.Text = "Detalles de Pago";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbtSavePago
            // 
            this.tbbtSavePago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtSavePago.Image = ((System.Drawing.Image)(resources.GetObject("tbbtSavePago.Image")));
            this.tbbtSavePago.Name = "tbbtSavePago";
            this.tbbtSavePago.Size = new System.Drawing.Size(23, 22);
            this.tbbtSavePago.Text = "Save Data";
            this.tbbtSavePago.Click += new System.EventHandler(this.tbbtSave_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // pagosGridControl
            // 
            this.pagosGridControl.DataSource = this.pagosBindingSource;
            this.pagosGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagosGridControl.Location = new System.Drawing.Point(0, 430);
            this.pagosGridControl.MainView = this.gvPagos;
            this.pagosGridControl.Name = "pagosGridControl";
            this.pagosGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.FormaPago,
            this.Cuenta});
            this.pagosGridControl.Size = new System.Drawing.Size(511, 190);
            this.pagosGridControl.TabIndex = 24;
            this.pagosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPagos});
            // 
            // gvPagos
            // 
            this.gvPagos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCompra1,
            this.colIdUsuario1,
            this.colIdFormaPago1,
            this.colIdCuenta1,
            this.colIdOpeBanco,
            this.colIdEmpresa1,
            this.colFecha,
            this.colIdConBanco,
            this.colIdCobro,
            this.colDesOperacion,
            this.colImportePagado,
            this.colEnCuenta,
            this.colSaldoAnterior,
            this.colFechaOpe,
            this.colTipoOpe,
            this.colObsBanco1});
            this.gvPagos.GridControl = this.pagosGridControl;
            this.gvPagos.Name = "gvPagos";
            this.gvPagos.OptionsView.ShowFooter = true;
            this.gvPagos.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCompra1
            // 
            this.colIdCompra1.FieldName = "IdCompra";
            this.colIdCompra1.Name = "colIdCompra1";
            // 
            // colIdUsuario1
            // 
            this.colIdUsuario1.FieldName = "IdUsuario";
            this.colIdUsuario1.Name = "colIdUsuario1";
            // 
            // colIdFormaPago1
            // 
            this.colIdFormaPago1.Caption = "Forma Pago";
            this.colIdFormaPago1.ColumnEdit = this.FormaPago;
            this.colIdFormaPago1.FieldName = "IdFormaPago";
            this.colIdFormaPago1.Name = "colIdFormaPago1";
            this.colIdFormaPago1.Visible = true;
            this.colIdFormaPago1.VisibleIndex = 1;
            this.colIdFormaPago1.Width = 100;
            // 
            // FormaPago
            // 
            this.FormaPago.AutoHeight = false;
            this.FormaPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FormaPago.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesFormaPago", "Forma Pago", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.FormaPago.DataSource = this.formasPagoBindingSource1;
            this.FormaPago.DisplayMember = "DesFormaPago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ValueMember = "IdFormaPago";
            // 
            // formasPagoBindingSource1
            // 
            this.formasPagoBindingSource1.DataMember = "FormasPago";
            this.formasPagoBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // colIdCuenta1
            // 
            this.colIdCuenta1.Caption = "Cuenta";
            this.colIdCuenta1.ColumnEdit = this.Cuenta;
            this.colIdCuenta1.FieldName = "IdCuenta";
            this.colIdCuenta1.Name = "colIdCuenta1";
            this.colIdCuenta1.Visible = true;
            this.colIdCuenta1.VisibleIndex = 2;
            this.colIdCuenta1.Width = 226;
            // 
            // Cuenta
            // 
            this.Cuenta.AutoHeight = false;
            this.Cuenta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cuenta.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BancoCuenta", "Cuenta", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Cuenta.DataSource = this.vCuentasBancosBindingSource1;
            this.Cuenta.DisplayMember = "BancoCuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ValueMember = "IdCuenta";
            // 
            // vCuentasBancosBindingSource1
            // 
            this.vCuentasBancosBindingSource1.DataMember = "vCuentasBancos";
            this.vCuentasBancosBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // colIdOpeBanco
            // 
            this.colIdOpeBanco.FieldName = "IdOpeBanco";
            this.colIdOpeBanco.Name = "colIdOpeBanco";
            this.colIdOpeBanco.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha Pago";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 72;
            // 
            // colIdConBanco
            // 
            this.colIdConBanco.FieldName = "IdConBanco";
            this.colIdConBanco.Name = "colIdConBanco";
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            // 
            // colDesOperacion
            // 
            this.colDesOperacion.FieldName = "DesOperacion";
            this.colDesOperacion.Name = "colDesOperacion";
            // 
            // colImportePagado
            // 
            this.colImportePagado.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportePagado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImportePagado.FieldName = "Importe";
            this.colImportePagado.Name = "colImportePagado";
            this.colImportePagado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")});
            this.colImportePagado.Visible = true;
            this.colImportePagado.VisibleIndex = 3;
            this.colImportePagado.Width = 95;
            // 
            // colEnCuenta
            // 
            this.colEnCuenta.FieldName = "EnCuenta";
            this.colEnCuenta.Name = "colEnCuenta";
            // 
            // colSaldoAnterior
            // 
            this.colSaldoAnterior.FieldName = "SaldoAnterior";
            this.colSaldoAnterior.Name = "colSaldoAnterior";
            // 
            // colFechaOpe
            // 
            this.colFechaOpe.FieldName = "FechaOpe";
            this.colFechaOpe.Name = "colFechaOpe";
            // 
            // colTipoOpe
            // 
            this.colTipoOpe.FieldName = "TipoOpe";
            this.colTipoOpe.Name = "colTipoOpe";
            // 
            // colObsBanco1
            // 
            this.colObsBanco1.FieldName = "ObsBanco";
            this.colObsBanco1.Name = "colObsBanco1";
            // 
            // fechaPagoDateEdit
            // 
            this.fechaPagoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "FechaPago", true));
            this.fechaPagoDateEdit.EditValue = null;
            this.fechaPagoDateEdit.Location = new System.Drawing.Point(137, 170);
            this.fechaPagoDateEdit.Name = "fechaPagoDateEdit";
            this.fechaPagoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaPagoDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fechaPagoDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fechaPagoDateEdit.TabIndex = 24;
            // 
            // facturaDirectaCheckEdit
            // 
            this.facturaDirectaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "FacturaDirecta", true));
            this.facturaDirectaCheckEdit.Location = new System.Drawing.Point(135, 12);
            this.facturaDirectaCheckEdit.Name = "facturaDirectaCheckEdit";
            this.facturaDirectaCheckEdit.Properties.Caption = "Directa Cliente";
            this.facturaDirectaCheckEdit.Size = new System.Drawing.Size(122, 19);
            this.facturaDirectaCheckEdit.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.tbImporteSeleccion);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.tbCantidadSeleccion);
            this.groupBox1.Location = new System.Drawing.Point(137, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 51);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // tbImporteSeleccion
            // 
            this.tbImporteSeleccion.Location = new System.Drawing.Point(258, 19);
            this.tbImporteSeleccion.Name = "tbImporteSeleccion";
            this.tbImporteSeleccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbImporteSeleccion.Properties.Appearance.Options.UseFont = true;
            this.tbImporteSeleccion.Size = new System.Drawing.Size(100, 20);
            this.tbImporteSeleccion.TabIndex = 26;
            // 
            // tbCantidadSeleccion
            // 
            this.tbCantidadSeleccion.Location = new System.Drawing.Point(73, 19);
            this.tbCantidadSeleccion.Name = "tbCantidadSeleccion";
            this.tbCantidadSeleccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbCantidadSeleccion.Properties.Appearance.Options.UseFont = true;
            this.tbCantidadSeleccion.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadSeleccion.TabIndex = 24;
            // 
            // facturaPendienteCheckEdit
            // 
            this.facturaPendienteCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "FacturaPendiente", true));
            this.facturaPendienteCheckEdit.Location = new System.Drawing.Point(292, 12);
            this.facturaPendienteCheckEdit.Name = "facturaPendienteCheckEdit";
            this.facturaPendienteCheckEdit.Properties.Caption = "Factura Pendiente";
            this.facturaPendienteCheckEdit.Size = new System.Drawing.Size(122, 19);
            this.facturaPendienteCheckEdit.TabIndex = 21;
            // 
            // pagadaCheckEdit
            // 
            this.pagadaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "Pagada", true));
            this.pagadaCheckEdit.Location = new System.Drawing.Point(420, 12);
            this.pagadaCheckEdit.Name = "pagadaCheckEdit";
            this.pagadaCheckEdit.Properties.Caption = "Pagada";
            this.pagadaCheckEdit.Properties.ReadOnly = true;
            this.pagadaCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.pagadaCheckEdit.TabIndex = 17;
            this.pagadaCheckEdit.Visible = false;
            // 
            // cbCuenta
            // 
            this.cbCuenta.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "IdCuenta", true));
            this.cbCuenta.Location = new System.Drawing.Point(137, 222);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCuenta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BancoCuenta", "Cuentas", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbCuenta.Properties.DataSource = this.vCuentasBancosBindingSource;
            this.cbCuenta.Properties.DisplayMember = "BancoCuenta";
            this.cbCuenta.Properties.NullText = "";
            this.cbCuenta.Properties.ValueMember = "IdCuenta";
            this.cbCuenta.Size = new System.Drawing.Size(340, 20);
            this.cbCuenta.TabIndex = 13;
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "IdFormaPago", true));
            this.cbFormaPago.Location = new System.Drawing.Point(137, 196);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFormaPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesFormaPago", "Formas Pago", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbFormaPago.Properties.DataSource = this.formasPagoBindingSource;
            this.cbFormaPago.Properties.DisplayMember = "DesFormaPago";
            this.cbFormaPago.Properties.NullText = "";
            this.cbFormaPago.Properties.ValueMember = "IdFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(340, 20);
            this.cbFormaPago.TabIndex = 11;
            // 
            // fechaVctoDateEdit
            // 
            this.fechaVctoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "FechaVcto", true));
            this.fechaVctoDateEdit.EditValue = null;
            this.fechaVctoDateEdit.Location = new System.Drawing.Point(137, 144);
            this.fechaVctoDateEdit.Name = "fechaVctoDateEdit";
            this.fechaVctoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaVctoDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fechaVctoDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fechaVctoDateEdit.TabIndex = 9;
            this.fechaVctoDateEdit.Validated += new System.EventHandler(this.fechaVctoDateEdit_Validated);
            // 
            // fechaRecibDateEdit
            // 
            this.fechaRecibDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "FechaRecib", true));
            this.fechaRecibDateEdit.EditValue = null;
            this.fechaRecibDateEdit.Location = new System.Drawing.Point(137, 118);
            this.fechaRecibDateEdit.Name = "fechaRecibDateEdit";
            this.fechaRecibDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaRecibDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fechaRecibDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fechaRecibDateEdit.TabIndex = 7;
            // 
            // fechaFacturaDateEdit
            // 
            this.fechaFacturaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "FechaFactura", true));
            this.fechaFacturaDateEdit.EditValue = null;
            this.fechaFacturaDateEdit.Location = new System.Drawing.Point(137, 92);
            this.fechaFacturaDateEdit.Name = "fechaFacturaDateEdit";
            this.fechaFacturaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaFacturaDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fechaFacturaDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fechaFacturaDateEdit.TabIndex = 5;
            this.fechaFacturaDateEdit.EditValueChanged += new System.EventHandler(this.fechaFacturaDateEdit_EditValueChanged);
            this.fechaFacturaDateEdit.Validated += new System.EventHandler(this.fechaFacturaDateEdit_Validated);
            // 
            // facturaTextEdit
            // 
            this.facturaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "Factura", true));
            this.facturaTextEdit.Location = new System.Drawing.Point(137, 66);
            this.facturaTextEdit.Name = "facturaTextEdit";
            this.facturaTextEdit.Size = new System.Drawing.Size(190, 20);
            this.facturaTextEdit.TabIndex = 3;
            // 
            // cbProveedores
            // 
            this.cbProveedores.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "idProveedor", true));
            this.cbProveedores.Location = new System.Drawing.Point(137, 40);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProveedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProveedor", "Proveedores", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbProveedores.Properties.DataSource = this.vProveedoresBindingSource;
            this.cbProveedores.Properties.DisplayMember = "DesProveedor";
            this.cbProveedores.Properties.NullText = "";
            this.cbProveedores.Properties.ValueMember = "IdProveedor";
            this.cbProveedores.Size = new System.Drawing.Size(340, 20);
            this.cbProveedores.TabIndex = 1;
            this.cbProveedores.EditValueChanged += new System.EventHandler(this.cbProveedores_EditValueChanged);
            this.cbProveedores.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbProveedores_EditValueChanging);
            this.cbProveedores.Validated += new System.EventHandler(this.cbProveedores_Validated);
            // 
            // tbCopiaFactura
            // 
            this.tbCopiaFactura.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "CopiaFactura", true));
            this.tbCopiaFactura.Location = new System.Drawing.Point(137, 248);
            this.tbCopiaFactura.Name = "tbCopiaFactura";
            this.tbCopiaFactura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "Adjuntar copia de la Factura", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Promowork.Properties.Resources.View_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, "Ver copia de factura.", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject14, "Eliminar copia de factura adjunta.", null, null, true)});
            this.tbCopiaFactura.Size = new System.Drawing.Size(370, 22);
            this.tbCopiaFactura.TabIndex = 15;
            this.tbCopiaFactura.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.tbCopiaFactura_ButtonPressed);
            // 
            // observTextEdit
            // 
            this.observTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.comprasCabBindingSource, "Observ", true));
            this.observTextEdit.Location = new System.Drawing.Point(137, 274);
            this.observTextEdit.Name = "observTextEdit";
            this.observTextEdit.Size = new System.Drawing.Size(368, 70);
            this.observTextEdit.TabIndex = 19;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.splitContainerControl5);
            this.splitContainerControl3.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.chkAutocalcular);
            this.splitContainerControl3.Panel2.Controls.Add(this.albaranesCabGridControl1);
            this.splitContainerControl3.Panel2.Controls.Add(this.bindingNavigator2);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1728, 234);
            this.splitContainerControl3.SplitterPosition = 1159;
            this.splitContainerControl3.TabIndex = 1;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // splitContainerControl5
            // 
            this.splitContainerControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl5.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl5.Horizontal = false;
            this.splitContainerControl5.Location = new System.Drawing.Point(0, 25);
            this.splitContainerControl5.Name = "splitContainerControl5";
            this.splitContainerControl5.Panel1.Controls.Add(this.comprasDetGridControl);
            this.splitContainerControl5.Panel1.Text = "Panel1";
            this.splitContainerControl5.Panel2.Controls.Add(this.splitContainerControl4);
            this.splitContainerControl5.Panel2.Text = "Panel2";
            this.splitContainerControl5.Size = new System.Drawing.Size(1159, 209);
            this.splitContainerControl5.SplitterPosition = 106;
            this.splitContainerControl5.TabIndex = 4;
            this.splitContainerControl5.Text = "splitContainerControl5";
            // 
            // comprasDetGridControl
            // 
            this.comprasDetGridControl.DataSource = this.comprasDetBindingSource;
            this.comprasDetGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comprasDetGridControl.Location = new System.Drawing.Point(0, 0);
            this.comprasDetGridControl.MainView = this.gvComprasDet;
            this.comprasDetGridControl.Name = "comprasDetGridControl";
            this.comprasDetGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Obras});
            this.comprasDetGridControl.Size = new System.Drawing.Size(1159, 106);
            this.comprasDetGridControl.TabIndex = 0;
            this.comprasDetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComprasDet});
            // 
            // comprasDetBindingSource
            // 
            this.comprasDetBindingSource.AllowNew = true;
            this.comprasDetBindingSource.DataMember = "ComprasDet";
            this.comprasDetBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // gvComprasDet
            // 
            this.gvComprasDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetCompra,
            this.colIdCompraCompraDet,
            this.colIdObraCompraDet,
            this.colImpBaseCompraDet,
            this.colImpIvaCompraDet,
            this.colIVACompraDet,
            this.colTotal,
            this.colImpIRPF1,
            this.colObsCompra,
            this.colColor2});
            this.gvComprasDet.GridControl = this.comprasDetGridControl;
            this.gvComprasDet.Name = "gvComprasDet";
            this.gvComprasDet.OptionsView.ShowFooter = true;
            this.gvComprasDet.OptionsView.ShowGroupPanel = false;
            this.gvComprasDet.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvComprasDet_FocusedRowChanged);
            // 
            // colIdDetCompra
            // 
            this.colIdDetCompra.FieldName = "IdDetCompra";
            this.colIdDetCompra.Name = "colIdDetCompra";
            this.colIdDetCompra.OptionsColumn.ReadOnly = true;
            // 
            // colIdCompraCompraDet
            // 
            this.colIdCompraCompraDet.FieldName = "IdCompra";
            this.colIdCompraCompraDet.Name = "colIdCompraCompraDet";
            // 
            // colIdObraCompraDet
            // 
            this.colIdObraCompraDet.Caption = "Obra";
            this.colIdObraCompraDet.ColumnEdit = this.Obras;
            this.colIdObraCompraDet.FieldName = "IdObra";
            this.colIdObraCompraDet.Name = "colIdObraCompraDet";
            this.colIdObraCompraDet.Visible = true;
            this.colIdObraCompraDet.VisibleIndex = 0;
            this.colIdObraCompraDet.Width = 217;
            // 
            // Obras
            // 
            this.Obras.AutoHeight = false;
            this.Obras.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Obras.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumeroSerieDesObraSM", "Obras", 139, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Obras.DataSource = this.vObrasBindingSource;
            this.Obras.DisplayMember = "NumeroSerieDesObraSM";
            this.Obras.Name = "Obras";
            this.Obras.ValueMember = "IdObra";
            this.Obras.EditValueChanged += new System.EventHandler(this.Obras_EditValueChanged);
            // 
            // vObrasBindingSource
            // 
            this.vObrasBindingSource.DataMember = "vObras";
            this.vObrasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colImpBaseCompraDet
            // 
            this.colImpBaseCompraDet.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpBaseCompraDet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpBaseCompraDet.Caption = "Imp. Base";
            this.colImpBaseCompraDet.DisplayFormat.FormatString = "C2";
            this.colImpBaseCompraDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpBaseCompraDet.FieldName = "ImpBase";
            this.colImpBaseCompraDet.Name = "colImpBaseCompraDet";
            this.colImpBaseCompraDet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpBase", "{0:c2}")});
            this.colImpBaseCompraDet.Visible = true;
            this.colImpBaseCompraDet.VisibleIndex = 1;
            this.colImpBaseCompraDet.Width = 90;
            // 
            // colImpIvaCompraDet
            // 
            this.colImpIvaCompraDet.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpIvaCompraDet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpIvaCompraDet.Caption = "Imp. IVA";
            this.colImpIvaCompraDet.DisplayFormat.FormatString = "C2";
            this.colImpIvaCompraDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpIvaCompraDet.FieldName = "ImpIva";
            this.colImpIvaCompraDet.Name = "colImpIvaCompraDet";
            this.colImpIvaCompraDet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpIva", "{0:c2}")});
            this.colImpIvaCompraDet.Visible = true;
            this.colImpIvaCompraDet.VisibleIndex = 2;
            this.colImpIvaCompraDet.Width = 90;
            // 
            // colIVACompraDet
            // 
            this.colIVACompraDet.AppearanceHeader.Options.UseTextOptions = true;
            this.colIVACompraDet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colIVACompraDet.Caption = "IVA (%)";
            this.colIVACompraDet.DisplayFormat.FormatString = "N2";
            this.colIVACompraDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVACompraDet.FieldName = "IVA";
            this.colIVACompraDet.Name = "colIVACompraDet";
            this.colIVACompraDet.Visible = true;
            this.colIVACompraDet.VisibleIndex = 3;
            this.colIVACompraDet.Width = 69;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.Caption = "Imp. Total";
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 112;
            // 
            // colImpIRPF1
            // 
            this.colImpIRPF1.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpIRPF1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpIRPF1.Caption = "Imp. IRPF";
            this.colImpIRPF1.FieldName = "ImpIRPF";
            this.colImpIRPF1.Name = "colImpIRPF1";
            this.colImpIRPF1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpIRPF", "{0:c2}")});
            this.colImpIRPF1.Visible = true;
            this.colImpIRPF1.VisibleIndex = 4;
            this.colImpIRPF1.Width = 97;
            // 
            // colObsCompra
            // 
            this.colObsCompra.FieldName = "ObsCompra";
            this.colObsCompra.Name = "colObsCompra";
            // 
            // colColor2
            // 
            this.colColor2.FieldName = "Color";
            this.colColor2.Name = "colColor2";
            // 
            // splitContainerControl4
            // 
            this.splitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl4.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl4.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl4.Name = "splitContainerControl4";
            this.splitContainerControl4.Panel1.Controls.Add(this.albaranesCabGridControl);
            this.splitContainerControl4.Panel1.Controls.Add(this.bindingNavigator3);
            this.splitContainerControl4.Panel1.Text = "Panel1";
            this.splitContainerControl4.Panel2.Controls.Add(this.albaranesDetGridControl);
            this.splitContainerControl4.Panel2.Controls.Add(this.bindingNavigator4);
            this.splitContainerControl4.Panel2.Text = "Panel2";
            this.splitContainerControl4.Size = new System.Drawing.Size(1159, 98);
            this.splitContainerControl4.SplitterPosition = 567;
            this.splitContainerControl4.TabIndex = 3;
            this.splitContainerControl4.Text = "splitContainerControl4";
            // 
            // albaranesCabGridControl
            // 
            this.albaranesCabGridControl.DataSource = this.albaranesCabBindingSource;
            this.albaranesCabGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albaranesCabGridControl.Location = new System.Drawing.Point(0, 25);
            this.albaranesCabGridControl.MainView = this.gvAlbaranesCompra;
            this.albaranesCabGridControl.Name = "albaranesCabGridControl";
            this.albaranesCabGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.QuitarAsociacion,
            this.ObrasAlbaranes});
            this.albaranesCabGridControl.Size = new System.Drawing.Size(567, 73);
            this.albaranesCabGridControl.TabIndex = 0;
            this.albaranesCabGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAlbaranesCompra});
            // 
            // albaranesCabBindingSource
            // 
            this.albaranesCabBindingSource.DataMember = "AlbaranesCab";
            this.albaranesCabBindingSource.DataSource = this.datosAlbaranes;
            // 
            // datosAlbaranes
            // 
            this.datosAlbaranes.DataSetName = "DatosAlbaranes";
            this.datosAlbaranes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAlbaranesCompra
            // 
            this.gvAlbaranesCompra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAlbaranCab,
            this.colIdProveedor1,
            this.colNumAlbaran,
            this.colFechaAlbaran,
            this.colValorado,
            this.colObservaciones,
            this.colConsecutivoAlbaran,
            this.colUtilizado,
            this.colFacturaRecibida,
            this.colSinAlbaran,
            this.colIdCompra2,
            this.colImporteAlbaranCompra,
            this.colIdObraAlbaranCompra,
            this.colQuitarAsociacion,
            this.colModificaImporteCompra});
            this.gvAlbaranesCompra.GridControl = this.albaranesCabGridControl;
            this.gvAlbaranesCompra.Name = "gvAlbaranesCompra";
            this.gvAlbaranesCompra.OptionsBehavior.ReadOnly = true;
            this.gvAlbaranesCompra.OptionsDetail.EnableMasterViewMode = false;
            this.gvAlbaranesCompra.OptionsView.ShowFooter = true;
            this.gvAlbaranesCompra.OptionsView.ShowGroupPanel = false;
            this.gvAlbaranesCompra.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAlbaranesCompra_FocusedRowChanged);
            // 
            // colIdAlbaranCab
            // 
            this.colIdAlbaranCab.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab.Name = "colIdAlbaranCab";
            this.colIdAlbaranCab.OptionsColumn.ReadOnly = true;
            // 
            // colIdProveedor1
            // 
            this.colIdProveedor1.FieldName = "IdProveedor";
            this.colIdProveedor1.Name = "colIdProveedor1";
            // 
            // colNumAlbaran
            // 
            this.colNumAlbaran.Caption = "Número";
            this.colNumAlbaran.FieldName = "NumAlbaran";
            this.colNumAlbaran.Name = "colNumAlbaran";
            this.colNumAlbaran.Visible = true;
            this.colNumAlbaran.VisibleIndex = 1;
            this.colNumAlbaran.Width = 74;
            // 
            // colFechaAlbaran
            // 
            this.colFechaAlbaran.Caption = "Fecha";
            this.colFechaAlbaran.FieldName = "FechaAlbaran";
            this.colFechaAlbaran.Name = "colFechaAlbaran";
            this.colFechaAlbaran.Visible = true;
            this.colFechaAlbaran.VisibleIndex = 2;
            this.colFechaAlbaran.Width = 90;
            // 
            // colValorado
            // 
            this.colValorado.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorado.Caption = "Valorado";
            this.colValorado.FieldName = "Valorado";
            this.colValorado.Name = "colValorado";
            this.colValorado.Visible = true;
            this.colValorado.VisibleIndex = 4;
            this.colValorado.Width = 35;
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            // 
            // colConsecutivoAlbaran
            // 
            this.colConsecutivoAlbaran.Caption = "Consecutivo";
            this.colConsecutivoAlbaran.FieldName = "ConsecutivoAlbaran";
            this.colConsecutivoAlbaran.Name = "colConsecutivoAlbaran";
            this.colConsecutivoAlbaran.Width = 182;
            // 
            // colUtilizado
            // 
            this.colUtilizado.FieldName = "Utilizado";
            this.colUtilizado.Name = "colUtilizado";
            // 
            // colFacturaRecibida
            // 
            this.colFacturaRecibida.FieldName = "FacturaRecibida";
            this.colFacturaRecibida.Name = "colFacturaRecibida";
            // 
            // colSinAlbaran
            // 
            this.colSinAlbaran.FieldName = "SinAlbaran";
            this.colSinAlbaran.Name = "colSinAlbaran";
            // 
            // colIdCompra2
            // 
            this.colIdCompra2.FieldName = "IdCompra";
            this.colIdCompra2.Name = "colIdCompra2";
            // 
            // colImporteAlbaranCompra
            // 
            this.colImporteAlbaranCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.colImporteAlbaranCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImporteAlbaranCompra.Caption = "Importe";
            this.colImporteAlbaranCompra.DisplayFormat.FormatString = "C2";
            this.colImporteAlbaranCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporteAlbaranCompra.FieldName = "Importe";
            this.colImporteAlbaranCompra.Name = "colImporteAlbaranCompra";
            this.colImporteAlbaranCompra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")});
            this.colImporteAlbaranCompra.Visible = true;
            this.colImporteAlbaranCompra.VisibleIndex = 3;
            this.colImporteAlbaranCompra.Width = 92;
            // 
            // colIdObraAlbaranCompra
            // 
            this.colIdObraAlbaranCompra.Caption = "Obra";
            this.colIdObraAlbaranCompra.ColumnEdit = this.ObrasAlbaranes;
            this.colIdObraAlbaranCompra.FieldName = "IdObra";
            this.colIdObraAlbaranCompra.Name = "colIdObraAlbaranCompra";
            this.colIdObraAlbaranCompra.Visible = true;
            this.colIdObraAlbaranCompra.VisibleIndex = 0;
            this.colIdObraAlbaranCompra.Width = 275;
            // 
            // ObrasAlbaranes
            // 
            this.ObrasAlbaranes.AutoHeight = false;
            this.ObrasAlbaranes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ObrasAlbaranes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumeroSerieDesObraSM", "Obra", 139, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ObrasAlbaranes.DataSource = this.vObrasBindingSource2;
            this.ObrasAlbaranes.DisplayMember = "NumeroSerieDesObraSM";
            this.ObrasAlbaranes.Name = "ObrasAlbaranes";
            this.ObrasAlbaranes.ValueMember = "IdObra";
            // 
            // vObrasBindingSource2
            // 
            this.vObrasBindingSource2.DataMember = "vObras";
            this.vObrasBindingSource2.DataSource = this.promowork_dataDataSet;
            // 
            // colQuitarAsociacion
            // 
            this.colQuitarAsociacion.ColumnEdit = this.QuitarAsociacion;
            this.colQuitarAsociacion.Name = "colQuitarAsociacion";
            this.colQuitarAsociacion.Visible = true;
            this.colQuitarAsociacion.VisibleIndex = 6;
            this.colQuitarAsociacion.Width = 31;
            // 
            // QuitarAsociacion
            // 
            this.QuitarAsociacion.AutoHeight = false;
            this.QuitarAsociacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "Quitar Asociación", null, null, true)});
            this.QuitarAsociacion.Name = "QuitarAsociacion";
            this.QuitarAsociacion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.QuitarAsociacion.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.QuitarAsociacion_ButtonPressed);
            // 
            // colModificaImporteCompra
            // 
            this.colModificaImporteCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.colModificaImporteCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModificaImporteCompra.Caption = "Modifica Importe";
            this.colModificaImporteCompra.FieldName = "ModificaImporteCompra";
            this.colModificaImporteCompra.Name = "colModificaImporteCompra";
            this.colModificaImporteCompra.Visible = true;
            this.colModificaImporteCompra.VisibleIndex = 5;
            this.colModificaImporteCompra.Width = 29;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BindingSource = this.albaranesCabProveedoresBindingSource;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel8,
            this.toolStripSeparator12});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(567, 25);
            this.bindingNavigator3.TabIndex = 6;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // albaranesCabProveedoresBindingSource
            // 
            this.albaranesCabProveedoresBindingSource.DataMember = "AlbaranesCab";
            this.albaranesCabProveedoresBindingSource.DataSource = this.datosAlbaranesProveedor;
            // 
            // datosAlbaranesProveedor
            // 
            this.datosAlbaranesProveedor.DataSetName = "DatosAlbaranes";
            this.datosAlbaranesProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(171, 22);
            this.toolStripLabel8.Text = "Albaranes Asociados a Factura";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // albaranesDetGridControl
            // 
            this.albaranesDetGridControl.DataSource = this.vImportarAlbaranesDetBindingSource;
            this.albaranesDetGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albaranesDetGridControl.Location = new System.Drawing.Point(0, 25);
            this.albaranesDetGridControl.MainView = this.gvAlbaranesDet;
            this.albaranesDetGridControl.Name = "albaranesDetGridControl";
            this.albaranesDetGridControl.Size = new System.Drawing.Size(587, 73);
            this.albaranesDetGridControl.TabIndex = 0;
            this.albaranesDetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAlbaranesDet});
            // 
            // vImportarAlbaranesDetBindingSource
            // 
            this.vImportarAlbaranesDetBindingSource.DataMember = "vImportarAlbaranesDet";
            this.vImportarAlbaranesDetBindingSource.DataSource = this.datosAlbaranes;
            // 
            // gvAlbaranesDet
            // 
            this.gvAlbaranesDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAlbaranDet,
            this.colIdAlbaranCab2,
            this.colIdProducto,
            this.colCantidad,
            this.colPrecio,
            this.colDescuento,
            this.colIdLugarUso,
            this.colIdTrabajador,
            this.colCodProductoInterno,
            this.colDesProducto,
            this.colCodUmedida,
            this.colPorciento,
            this.colObservaciones2});
            this.gvAlbaranesDet.GridControl = this.albaranesDetGridControl;
            this.gvAlbaranesDet.Name = "gvAlbaranesDet";
            this.gvAlbaranesDet.OptionsBehavior.ReadOnly = true;
            this.gvAlbaranesDet.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAlbaranDet
            // 
            this.colIdAlbaranDet.FieldName = "IdAlbaranDet";
            this.colIdAlbaranDet.Name = "colIdAlbaranDet";
            // 
            // colIdAlbaranCab2
            // 
            this.colIdAlbaranCab2.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab2.Name = "colIdAlbaranCab2";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 59;
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio.Caption = "Precio";
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            this.colPrecio.Width = 52;
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuento.Caption = "Descuento";
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 4;
            this.colDescuento.Width = 53;
            // 
            // colIdLugarUso
            // 
            this.colIdLugarUso.FieldName = "IdLugarUso";
            this.colIdLugarUso.Name = "colIdLugarUso";
            // 
            // colIdTrabajador
            // 
            this.colIdTrabajador.FieldName = "IdTrabajador";
            this.colIdTrabajador.Name = "colIdTrabajador";
            // 
            // colCodProductoInterno
            // 
            this.colCodProductoInterno.FieldName = "CodProductoInterno";
            this.colCodProductoInterno.Name = "colCodProductoInterno";
            // 
            // colDesProducto
            // 
            this.colDesProducto.Caption = "Nombre Producto";
            this.colDesProducto.FieldName = "DesProducto";
            this.colDesProducto.Name = "colDesProducto";
            this.colDesProducto.Visible = true;
            this.colDesProducto.VisibleIndex = 0;
            this.colDesProducto.Width = 201;
            // 
            // colCodUmedida
            // 
            this.colCodUmedida.AppearanceCell.Options.UseTextOptions = true;
            this.colCodUmedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodUmedida.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodUmedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodUmedida.Caption = "U.M.";
            this.colCodUmedida.FieldName = "CodUmedida";
            this.colCodUmedida.Name = "colCodUmedida";
            this.colCodUmedida.Visible = true;
            this.colCodUmedida.VisibleIndex = 1;
            this.colCodUmedida.Width = 42;
            // 
            // colPorciento
            // 
            this.colPorciento.FieldName = "Porciento";
            this.colPorciento.Name = "colPorciento";
            // 
            // colObservaciones2
            // 
            this.colObservaciones2.Caption = "Observaciones";
            this.colObservaciones2.FieldName = "Observaciones";
            this.colObservaciones2.Name = "colObservaciones2";
            this.colObservaciones2.Visible = true;
            this.colObservaciones2.VisibleIndex = 5;
            this.colObservaciones2.Width = 149;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = null;
            this.bindingNavigator4.BindingSource = this.albaranesCabProveedoresBindingSource;
            this.bindingNavigator4.CountItem = null;
            this.bindingNavigator4.DeleteItem = null;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel9,
            this.toolStripSeparator13});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator4.MoveFirstItem = null;
            this.bindingNavigator4.MoveLastItem = null;
            this.bindingNavigator4.MoveNextItem = null;
            this.bindingNavigator4.MovePreviousItem = null;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = null;
            this.bindingNavigator4.Size = new System.Drawing.Size(587, 25);
            this.bindingNavigator4.TabIndex = 7;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(168, 22);
            this.toolStripLabel9.Text = "Detalle Albaran Seleccionado";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.tbbtAddDet;
            this.bindingNavigator1.BindingSource = this.comprasDetBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel7,
            this.toolStripSeparator6,
            this.tbbtDeleteDet,
            this.tbbtAddDet,
            this.tbbtSaveDet,
            this.toolStripSeparator8});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1159, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tbbtAddDet
            // 
            this.tbbtAddDet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtAddDet.Image = ((System.Drawing.Image)(resources.GetObject("tbbtAddDet.Image")));
            this.tbbtAddDet.Name = "tbbtAddDet";
            this.tbbtAddDet.RightToLeftAutoMirrorImage = true;
            this.tbbtAddDet.Size = new System.Drawing.Size(23, 22);
            this.tbbtAddDet.Text = "Add new";
            this.tbbtAddDet.Click += new System.EventHandler(this.tbbtAddDet_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel7.Text = "Detalle Factura";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbtDeleteDet
            // 
            this.tbbtDeleteDet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtDeleteDet.Image = ((System.Drawing.Image)(resources.GetObject("tbbtDeleteDet.Image")));
            this.tbbtDeleteDet.Name = "tbbtDeleteDet";
            this.tbbtDeleteDet.RightToLeftAutoMirrorImage = true;
            this.tbbtDeleteDet.Size = new System.Drawing.Size(23, 22);
            this.tbbtDeleteDet.Text = "Delete";
            this.tbbtDeleteDet.Click += new System.EventHandler(this.tbbtDeleteDet_Click);
            // 
            // tbbtSaveDet
            // 
            this.tbbtSaveDet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtSaveDet.Image = ((System.Drawing.Image)(resources.GetObject("tbbtSaveDet.Image")));
            this.tbbtSaveDet.Name = "tbbtSaveDet";
            this.tbbtSaveDet.Size = new System.Drawing.Size(23, 22);
            this.tbbtSaveDet.Text = "Save Data";
            this.tbbtSaveDet.Click += new System.EventHandler(this.tbbtSave_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // chkAutocalcular
            // 
            this.chkAutocalcular.EditValue = true;
            this.chkAutocalcular.Location = new System.Drawing.Point(540, 3);
            this.chkAutocalcular.Name = "chkAutocalcular";
            this.chkAutocalcular.Properties.Caption = "Agregar a Detalle de Factura";
            this.chkAutocalcular.Size = new System.Drawing.Size(173, 19);
            this.chkAutocalcular.TabIndex = 24;
            // 
            // albaranesCabGridControl1
            // 
            this.albaranesCabGridControl1.DataSource = this.albaranesCabProveedoresBindingSource;
            this.albaranesCabGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albaranesCabGridControl1.Location = new System.Drawing.Point(0, 25);
            this.albaranesCabGridControl1.MainView = this.gvAlbaranesProveedorObra;
            this.albaranesCabGridControl1.Name = "albaranesCabGridControl1";
            this.albaranesCabGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbObraAlbaran,
            this.AsociarAFactura});
            this.albaranesCabGridControl1.Size = new System.Drawing.Size(564, 209);
            this.albaranesCabGridControl1.TabIndex = 1;
            this.albaranesCabGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAlbaranesProveedorObra});
            // 
            // gvAlbaranesProveedorObra
            // 
            this.gvAlbaranesProveedorObra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAsociar,
            this.colIdAlbaranCab1,
            this.colIdProveedor2,
            this.colNumAlbaran1,
            this.colFechaAlbaran1,
            this.colValorado1,
            this.colObservaciones1,
            this.colCopiaAlbaran1,
            this.colIdObraAlbaranProveedor,
            this.colConsecutivoAlbaran1,
            this.colUtilizado1,
            this.colFacturaRecibida1,
            this.colSinAlbaran1,
            this.colIdCompra3,
            this.colImporteAlbaranProveedor,
            this.colModificaImporteCompraAlbProv});
            this.gvAlbaranesProveedorObra.GridControl = this.albaranesCabGridControl1;
            this.gvAlbaranesProveedorObra.Name = "gvAlbaranesProveedorObra";
            this.gvAlbaranesProveedorObra.OptionsBehavior.ReadOnly = true;
            this.gvAlbaranesProveedorObra.OptionsDetail.EnableMasterViewMode = false;
            this.gvAlbaranesProveedorObra.OptionsView.ShowAutoFilterRow = true;
            this.gvAlbaranesProveedorObra.OptionsView.ShowGroupPanel = false;
            this.gvAlbaranesProveedorObra.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAlbaranesProveedorObra_FocusedRowChanged);
            // 
            // colAsociar
            // 
            this.colAsociar.ColumnEdit = this.AsociarAFactura;
            this.colAsociar.Name = "colAsociar";
            this.colAsociar.Visible = true;
            this.colAsociar.VisibleIndex = 0;
            this.colAsociar.Width = 27;
            // 
            // AsociarAFactura
            // 
            this.AsociarAFactura.AutoHeight = false;
            this.AsociarAFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject11, "Asociar a Factura", null, null, true)});
            this.AsociarAFactura.Name = "AsociarAFactura";
            this.AsociarAFactura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.AsociarAFactura.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.AsociarAFactura_ButtonPressed);
            // 
            // colIdAlbaranCab1
            // 
            this.colIdAlbaranCab1.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab1.Name = "colIdAlbaranCab1";
            this.colIdAlbaranCab1.OptionsColumn.ReadOnly = true;
            // 
            // colIdProveedor2
            // 
            this.colIdProveedor2.FieldName = "IdProveedor";
            this.colIdProveedor2.Name = "colIdProveedor2";
            // 
            // colNumAlbaran1
            // 
            this.colNumAlbaran1.Caption = "Número";
            this.colNumAlbaran1.FieldName = "NumAlbaran";
            this.colNumAlbaran1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNumAlbaran1.Name = "colNumAlbaran1";
            this.colNumAlbaran1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumAlbaran1.Visible = true;
            this.colNumAlbaran1.VisibleIndex = 2;
            this.colNumAlbaran1.Width = 59;
            // 
            // colFechaAlbaran1
            // 
            this.colFechaAlbaran1.Caption = "Fecha";
            this.colFechaAlbaran1.FieldName = "FechaAlbaran";
            this.colFechaAlbaran1.Name = "colFechaAlbaran1";
            this.colFechaAlbaran1.Visible = true;
            this.colFechaAlbaran1.VisibleIndex = 3;
            this.colFechaAlbaran1.Width = 63;
            // 
            // colValorado1
            // 
            this.colValorado1.Caption = "Valorado";
            this.colValorado1.FieldName = "Valorado";
            this.colValorado1.Name = "colValorado1";
            this.colValorado1.Visible = true;
            this.colValorado1.VisibleIndex = 4;
            this.colValorado1.Width = 57;
            // 
            // colObservaciones1
            // 
            this.colObservaciones1.Caption = "Observaciones";
            this.colObservaciones1.FieldName = "Observaciones";
            this.colObservaciones1.Name = "colObservaciones1";
            // 
            // colCopiaAlbaran1
            // 
            this.colCopiaAlbaran1.FieldName = "CopiaAlbaran";
            this.colCopiaAlbaran1.Name = "colCopiaAlbaran1";
            // 
            // colIdObraAlbaranProveedor
            // 
            this.colIdObraAlbaranProveedor.Caption = "Obra";
            this.colIdObraAlbaranProveedor.ColumnEdit = this.cbObraAlbaran;
            this.colIdObraAlbaranProveedor.FieldName = "IdObra";
            this.colIdObraAlbaranProveedor.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdObraAlbaranProveedor.Name = "colIdObraAlbaranProveedor";
            this.colIdObraAlbaranProveedor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdObraAlbaranProveedor.Visible = true;
            this.colIdObraAlbaranProveedor.VisibleIndex = 1;
            this.colIdObraAlbaranProveedor.Width = 301;
            // 
            // cbObraAlbaran
            // 
            this.cbObraAlbaran.AutoHeight = false;
            this.cbObraAlbaran.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbObraAlbaran.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumeroSerieDesObraSM", "Obras", 139, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbObraAlbaran.DataSource = this.vObrasBindingSource1;
            this.cbObraAlbaran.DisplayMember = "NumeroSerieDesObraSM";
            this.cbObraAlbaran.Name = "cbObraAlbaran";
            this.cbObraAlbaran.ValueMember = "IdObra";
            // 
            // vObrasBindingSource1
            // 
            this.vObrasBindingSource1.DataMember = "vObras";
            this.vObrasBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // colConsecutivoAlbaran1
            // 
            this.colConsecutivoAlbaran1.Caption = "Consecutivo";
            this.colConsecutivoAlbaran1.FieldName = "ConsecutivoAlbaran";
            this.colConsecutivoAlbaran1.Name = "colConsecutivoAlbaran1";
            this.colConsecutivoAlbaran1.Width = 47;
            // 
            // colUtilizado1
            // 
            this.colUtilizado1.Caption = "Utilizado";
            this.colUtilizado1.FieldName = "Utilizado";
            this.colUtilizado1.Name = "colUtilizado1";
            this.colUtilizado1.Width = 47;
            // 
            // colFacturaRecibida1
            // 
            this.colFacturaRecibida1.Caption = "Factura Recibida";
            this.colFacturaRecibida1.FieldName = "FacturaRecibida";
            this.colFacturaRecibida1.Name = "colFacturaRecibida1";
            this.colFacturaRecibida1.Width = 47;
            // 
            // colSinAlbaran1
            // 
            this.colSinAlbaran1.Caption = "Sin Albaran";
            this.colSinAlbaran1.FieldName = "SinAlbaran";
            this.colSinAlbaran1.Name = "colSinAlbaran1";
            this.colSinAlbaran1.Width = 47;
            // 
            // colIdCompra3
            // 
            this.colIdCompra3.FieldName = "IdCompra";
            this.colIdCompra3.Name = "colIdCompra3";
            this.colIdCompra3.Width = 71;
            // 
            // colImporteAlbaranProveedor
            // 
            this.colImporteAlbaranProveedor.Caption = "Importe";
            this.colImporteAlbaranProveedor.DisplayFormat.FormatString = "C2";
            this.colImporteAlbaranProveedor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporteAlbaranProveedor.FieldName = "Importe";
            this.colImporteAlbaranProveedor.Name = "colImporteAlbaranProveedor";
            this.colImporteAlbaranProveedor.Visible = true;
            this.colImporteAlbaranProveedor.VisibleIndex = 5;
            this.colImporteAlbaranProveedor.Width = 94;
            // 
            // colModificaImporteCompraAlbProv
            // 
            this.colModificaImporteCompraAlbProv.FieldName = "ModificaImporteCompra";
            this.colModificaImporteCompraAlbProv.Name = "colModificaImporteCompraAlbProv";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.albaranesCabProveedoresBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.tbcbCargaAlbaranes,
            this.toolStripSeparator9,
            this.toolStripLabel5,
            this.tbIVA});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(564, 25);
            this.bindingNavigator2.TabIndex = 5;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(123, 22);
            this.toolStripLabel6.Text = "Albaranes Proveedor";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(106, 22);
            this.toolStripLabel4.Text = "Mostrar Albaranes:";
            // 
            // tbcbCargaAlbaranes
            // 
            this.tbcbCargaAlbaranes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbcbCargaAlbaranes.Name = "tbcbCargaAlbaranes";
            this.tbcbCargaAlbaranes.Size = new System.Drawing.Size(180, 25);
            this.tbcbCargaAlbaranes.SelectedIndexChanged += new System.EventHandler(this.tbcbCargaAlbaranes_SelectedIndexChanged);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel5.Text = "IVA (%):";
            // 
            // tbIVA
            // 
            this.tbIVA.Name = "tbIVA";
            this.tbIVA.Size = new System.Drawing.Size(50, 25);
            this.tbIVA.Text = "21";
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
            this.tableAdapterManager.ComprasCabTableAdapter = this.comprasCabTableAdapter;
            this.tableAdapterManager.ComprasDetTableAdapter = this.comprasDetTableAdapter;
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
            this.tableAdapterManager.FacturasCabTableAdapter = null;
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
            // comprasCabTableAdapter
            // 
            this.comprasCabTableAdapter.ClearBeforeFill = true;
            // 
            // comprasDetTableAdapter
            // 
            this.comprasDetTableAdapter.ClearBeforeFill = true;
            // 
            // anosComprasBindingSource
            // 
            this.anosComprasBindingSource.DataMember = "AnosCompras";
            this.anosComprasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // anosComprasTableAdapter
            // 
            this.anosComprasTableAdapter.ClearBeforeFill = true;
            // 
            // vObrasTableAdapter
            // 
            this.vObrasTableAdapter.ClearBeforeFill = true;
            // 
            // vProveedoresTableAdapter
            // 
            this.vProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // formasPagoTableAdapter
            // 
            this.formasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // vCuentasBancosTableAdapter
            // 
            this.vCuentasBancosTableAdapter.ClearBeforeFill = true;
            // 
            // albaranesCabTableAdapter
            // 
            this.albaranesCabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlbaranesCabTableAdapter = this.albaranesCabTableAdapter;
            this.tableAdapterManager1.AlbaranesDetTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ConversionesUMTableAdapter = null;
            this.tableAdapterManager1.LugaresUsoMaterialTableAdapter = null;
            this.tableAdapterManager1.ObrasTableAdapter = null;
            this.tableAdapterManager1.ObservacionesProveedoresTableAdapter = null;
            this.tableAdapterManager1.ProductosTableAdapter = null;
            this.tableAdapterManager1.ProveedoresTableAdapter = null;
            this.tableAdapterManager1.TrabajadoresTableAdapter = null;
            this.tableAdapterManager1.UMedidasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Promowork.DatosAlbaranesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // albaranesCabProveedoresTableAdapter
            // 
            this.albaranesCabProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.AlbaranesCabTableAdapter = this.albaranesCabProveedoresTableAdapter;
            this.tableAdapterManager2.AlbaranesDetTableAdapter = null;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.ConversionesUMTableAdapter = null;
            this.tableAdapterManager2.LugaresUsoMaterialTableAdapter = null;
            this.tableAdapterManager2.ObrasTableAdapter = null;
            this.tableAdapterManager2.ObservacionesProveedoresTableAdapter = null;
            this.tableAdapterManager2.ProductosTableAdapter = null;
            this.tableAdapterManager2.ProveedoresTableAdapter = null;
            this.tableAdapterManager2.TrabajadoresTableAdapter = null;
            this.tableAdapterManager2.UMedidasTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = Promowork.DatosAlbaranesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagenes|*.jpg; *.bmp; *.png; *.gif; *.pdf";
            // 
            // vImportarAlbaranesDetTableAdapter
            // 
            this.vImportarAlbaranesDetTableAdapter.ClearBeforeFill = true;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button6.Location = new System.Drawing.Point(482, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 21);
            this.button6.TabIndex = 97;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button5.Location = new System.Drawing.Point(482, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 21);
            this.button5.TabIndex = 96;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button2.Location = new System.Drawing.Point(482, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 21);
            this.button2.TabIndex = 95;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 859);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmCompras";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Compras a Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vComprasProveedoresGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComprasCab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormasPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasCabBindingNavigator)).EndInit();
            this.comprasCabBindingNavigator.ResumeLayout(false);
            this.comprasCabBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCuentasBancosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPagoDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPagoDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDirectaCheckEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImporteSeleccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadSeleccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaPendienteCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVctoDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVctoDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaRecibDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaRecibDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaFacturaDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaFacturaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCopiaFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).EndInit();
            this.splitContainerControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComprasDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).EndInit();
            this.splitContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbaranesCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObrasAlbaranes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vObrasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitarAsociacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranesProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesDetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbaranesDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutocalcular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbaranesProveedorObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsociarAFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObraAlbaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vObrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosComprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Promowork_dataDataSet promowork_dataDataSet;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl vComprasProveedoresGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComprasCab;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRecib;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVcto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colPagada;
        private DevExpress.XtraGrid.Columns.GridColumn colImpBase;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIRPF;
        private DevExpress.XtraGrid.Columns.GridColumn colObserv;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor1;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevision;
        private DevExpress.XtraGrid.Columns.GridColumn colObsBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaFacturaImg;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colImpPagado;
        private System.Windows.Forms.BindingNavigator comprasCabBindingNavigator;
        private System.Windows.Forms.ToolStripButton tbbtAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbbtDelete;
        private System.Windows.Forms.ToolStripButton tbbtSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tbbtPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox tbcbAnos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.BindingSource anosComprasBindingSource;
        private Promowork_dataDataSetTableAdapters.AnosComprasTableAdapter anosComprasTableAdapter;
        private System.Windows.Forms.ToolStripComboBox tbcbCargarCompras;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private System.Windows.Forms.BindingSource comprasDetBindingSource;
        private Promowork_dataDataSetTableAdapters.ComprasDetTableAdapter comprasDetTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraGrid.GridControl comprasDetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComprasDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompraCompraDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObraCompraDet;
        private DevExpress.XtraGrid.Columns.GridColumn colImpBaseCompraDet;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIvaCompraDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIVACompraDet;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIRPF1;
        private DevExpress.XtraGrid.Columns.GridColumn colObsCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colColor2;
        private System.Windows.Forms.BindingSource comprasCabBindingSource;
        private Promowork_dataDataSetTableAdapters.ComprasCabTableAdapter comprasCabTableAdapter;
        private DevExpress.XtraEditors.CheckEdit facturaPendienteCheckEdit;
        private DevExpress.XtraEditors.CheckEdit pagadaCheckEdit;
        private DevExpress.XtraEditors.LookUpEdit cbCuenta;
        private DevExpress.XtraEditors.LookUpEdit cbFormaPago;
        private DevExpress.XtraEditors.DateEdit fechaVctoDateEdit;
        private DevExpress.XtraEditors.DateEdit fechaRecibDateEdit;
        private DevExpress.XtraEditors.DateEdit fechaFacturaDateEdit;
        private DevExpress.XtraEditors.TextEdit facturaTextEdit;
        private DevExpress.XtraEditors.LookUpEdit cbProveedores;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Obras;
        private System.Windows.Forms.BindingSource vObrasBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton tbbtAddDet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbbtDeleteDet;
        private System.Windows.Forms.ToolStripButton tbbtSaveDet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private Promowork_dataDataSetTableAdapters.vObrasTableAdapter vObrasTableAdapter;
        private System.Windows.Forms.BindingSource vProveedoresBindingSource;
        private Promowork_dataDataSetTableAdapters.vProveedoresTableAdapter vProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource formasPagoBindingSource;
        private Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter formasPagoTableAdapter;
        private DevExpress.XtraEditors.ButtonEdit tbCopiaFactura;
        private DevExpress.XtraEditors.MemoEdit observTextEdit;
        private System.Windows.Forms.BindingSource vCuentasBancosBindingSource;
        private Promowork.Promowork_dataDataSetTableAdapters.vCuentasBancosTableAdapter vCuentasBancosTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Proveedores;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FormasPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Cuentas;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DatosAlbaranes datosAlbaranes;
        private System.Windows.Forms.BindingSource albaranesCabBindingSource;
        private DatosAlbaranesTableAdapters.AlbaranesCabTableAdapter albaranesCabTableAdapter;
        private DatosAlbaranesTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl albaranesCabGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAlbaranesCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colValorado;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colConsecutivoAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizado;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaRecibida;
        private DevExpress.XtraGrid.Columns.GridColumn colSinAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra2;
        private DevExpress.XtraGrid.GridControl albaranesCabGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAlbaranesProveedorObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor2;
        private DevExpress.XtraGrid.Columns.GridColumn colNumAlbaran1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAlbaran1;
        private DevExpress.XtraGrid.Columns.GridColumn colValorado1;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaAlbaran1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObraAlbaranProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colConsecutivoAlbaran1;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizado1;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaRecibida1;
        private DevExpress.XtraGrid.Columns.GridColumn colSinAlbaran1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra3;
        private DatosAlbaranes datosAlbaranesProveedor;
        private DatosAlbaranesTableAdapters.AlbaranesCabTableAdapter albaranesCabProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource albaranesCabProveedoresBindingSource;
        private DatosAlbaranesTableAdapters.TableAdapterManager tableAdapterManager2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbObraAlbaran;
        private System.Windows.Forms.BindingSource vObrasBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteAlbaranCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObraAlbaranCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteAlbaranProveedor;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colQuitarAsociacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit QuitarAsociacion;
        private DevExpress.XtraGrid.Columns.GridColumn colAsociar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AsociarAFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colModificaImporteCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colModificaImporteCompraAlbProv;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit tbImporteSeleccion;
        private DevExpress.XtraEditors.TextEdit tbCantidadSeleccion;
        private DevExpress.XtraEditors.CheckEdit facturaDirectaCheckEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.DateEdit fechaPagoDateEdit;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl4;
        private DevExpress.XtraGrid.GridControl albaranesDetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAlbaranesDet;
        private DevExpress.XtraEditors.CheckEdit chkAutocalcular;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox tbcbCargaAlbaranes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tbIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLugarUso;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProductoInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodUmedida;
        private DevExpress.XtraGrid.Columns.GridColumn colPorciento;
        private DatosAlbaranesTableAdapters.vImportarAlbaranesDetTableAdapter vImportarAlbaranesDetTableAdapter;
        private System.Windows.Forms.BindingSource vImportarAlbaranesDetBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ObrasAlbaranes;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.BindingSource vObrasBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaDirecta;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripComboBox tbcbObras;
        private DevExpress.XtraGrid.Columns.GridColumn colObras;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private Promowork_dataDataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
        private DevExpress.XtraGrid.GridControl pagosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPagos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOpeBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdConBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colDesOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colImportePagado;
        private DevExpress.XtraGrid.Columns.GridColumn colEnCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaOpe;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoOpe;
        private DevExpress.XtraGrid.Columns.GridColumn colObsBanco1;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton tbbtAddPago;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton tbbtDeletePago;
        private System.Windows.Forms.ToolStripButton tbbtSavePago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FormaPago;
        private System.Windows.Forms.BindingSource formasPagoBindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Cuenta;
        private System.Windows.Forms.BindingSource vCuentasBancosBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbVcto;
        private System.Windows.Forms.RadioButton rbPrevision;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}