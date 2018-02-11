namespace Promowork
{
    partial class frmFacturasPresupuestos
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
            System.Windows.Forms.Label anticipoLabel;
            System.Windows.Forms.Label copiaFacturaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label obsFacturaLabel;
            System.Windows.Forms.Label mostrarVctoLabel;
            System.Windows.Forms.Label retencionLabel;
            System.Windows.Forms.Label descProntoLabel;
            System.Windows.Forms.Label descFacuraLabel;
            System.Windows.Forms.Label iVAFacturaLabel;
            System.Windows.Forms.Label certificacionLabel;
            System.Windows.Forms.Label idCuentaLabel;
            System.Windows.Forms.Label fechaVctoFactLabel;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label numFacturaLabel;
            System.Windows.Forms.Label idPresupLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label cantidadLabel1;
            System.Windows.Forms.Label cantExtraLabel;
            System.Windows.Forms.Label precioLabel1;
            System.Windows.Forms.Label totalDetLabel;
            System.Windows.Forms.Label totalFacturadoLabel;
            System.Windows.Forms.Label totalPendienteLabel;
            System.Windows.Forms.Label cantDetFactLabel;
            System.Windows.Forms.Label cantidadLabel2;
            System.Windows.Forms.Label cantExtraLabel1;
            System.Windows.Forms.Label precioLabel2;
            System.Windows.Forms.Label pedienteLabel;
            System.Windows.Forms.Label totalSubLabel;
            System.Windows.Forms.Label cantSubFactLabel;
            System.Windows.Forms.Label totalFacturadoLabel1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label obsFactura2Label;
            System.Windows.Forms.Label label4;
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition7 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition8 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturasPresupuestos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colFacturaPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObraCorrecta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaDirecta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.facturasCabGridControl = new DevExpress.XtraGrid.GridControl();
            this.facturasCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosPresupuestos = new Promowork.DatosPresupuestos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Clientes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdClienteFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClienteFactura = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Obras = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVctoFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMostrarVcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMostrarObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCertificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescPronto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVAFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCobrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsFactura2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMostrarSubTot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargoMitadDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImporteIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descuentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsCertificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbObra = new System.Windows.Forms.ComboBox();
            this.obrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chkMostarPresup = new DevExpress.XtraEditors.CheckEdit();
            this.esCertificacionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.txtSerieFact = new System.Windows.Forms.TextBox();
            this.chkMostrarObra = new DevExpress.XtraEditors.CheckEdit();
            this.chkSubTot = new DevExpress.XtraEditors.CheckEdit();
            this.esPrevisionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.anticipoTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.noDetalleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.entregadaCheckBox = new System.Windows.Forms.CheckBox();
            this.facturaCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.copiaFacturaTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mostrarVctoCheckBox = new System.Windows.Forms.CheckBox();
            this.retencionTextBox = new System.Windows.Forms.TextBox();
            this.descProntoTextBox = new System.Windows.Forms.TextBox();
            this.descFacuraTextBox = new System.Windows.Forms.TextBox();
            this.iVAFacturaTextBox = new System.Windows.Forms.TextBox();
            this.certificacionTextBox = new System.Windows.Forms.TextBox();
            this.idCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.cuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaVctoFactDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numFacturaTextBox = new System.Windows.Forms.TextBox();
            this.idPresupComboBox = new System.Windows.Forms.ComboBox();
            this.presupCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.obsFacturaTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDetalleHorasMateriales = new DevExpress.XtraTab.XtraTabPage();
            this.vDetallesHorasMaterialesGridControl = new DevExpress.XtraGrid.GridControl();
            this.vDetallesHorasMaterialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactCab5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabDetallePresupuesto = new DevExpress.XtraTab.XtraTabPage();
            this.facturasDetGridControl = new DevExpress.XtraGrid.GridControl();
            this.vDetallesFacturasPresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupSub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubdetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDescPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tabDetallesFactura = new DevExpress.XtraTab.XtraTabControl();
            this.tabFacturaDirectaCliente = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.facturasDetDirectaGridControl = new DevExpress.XtraGrid.GridControl();
            this.vComprasDirectasBindingSourceFactura = new System.Windows.Forms.BindingSource(this.components);
            this.datosPresupuestos1 = new Promowork.DatosPresupuestos();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpBase1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIva1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIRPF1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btQuitarCompraDirecta = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.vComprasDirectasGridControl = new DevExpress.XtraGrid.GridControl();
            this.vComprasDirectasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompraDirecta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIRPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaDirecta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFacturaDirecta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgregarCompraDirecta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgregarCompraDirecta = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabPresupuesto = new DevExpress.XtraTab.XtraTabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.obsFactura2TextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.spnImporte = new DevExpress.XtraEditors.SpinEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPendienteDet = new System.Windows.Forms.Label();
            this.spnPendienteDet = new DevExpress.XtraEditors.SpinEdit();
            this.cantDetFactSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.detallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalPendienteSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.totalFacturadoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.totalDetSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.precioSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cantExtraSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cantidadSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtUM = new DevExpress.XtraEditors.TextEdit();
            this.spnDescuento = new DevExpress.XtraEditors.SpinEdit();
            this.uMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.uMTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.subdetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spnPrecio = new DevExpress.XtraEditors.SpinEdit();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.spnCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPendienteSub = new System.Windows.Forms.Label();
            this.spnPendienteSub = new DevExpress.XtraEditors.SpinEdit();
            this.totalFacturadoSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.cantSubFactSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.totalSubSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.pedienteSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.precioSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.cantExtraSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.cantidadSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.spnPorciento = new DevExpress.XtraEditors.SpinEdit();
            this.facturasDetGridControl1 = new DevExpress.XtraGrid.GridControl();
            this.facturasDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactDet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupDet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupSub1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUm1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.facturasDetDirectaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasCabTableAdapter = new Promowork.DatosPresupuestosTableAdapters.FacturasCabTableAdapter();
            this.tableAdapterManager = new Promowork.DatosPresupuestosTableAdapters.TableAdapterManager();
            this.facturasDetTableAdapter = new Promowork.DatosPresupuestosTableAdapters.FacturasDetTableAdapter();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.anosFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anosFacturasTableAdapter = new Promowork.DatosPresupuestosTableAdapters.AnosFacturasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new Promowork.DatosPresupuestosTableAdapters.ClientesTableAdapter();
            this.obrasTableAdapter = new Promowork.DatosPresupuestosTableAdapters.ObrasTableAdapter();
            this.capitulosTableAdapter = new Promowork.DatosPresupuestosTableAdapters.CapitulosTableAdapter();
            this.vDetallesFacturasPresupuestosTableAdapter = new Promowork.DatosPresupuestosTableAdapters.vDetallesFacturasPresupuestosTableAdapter();
            this.detallesTableAdapter = new Promowork.DatosPresupuestosTableAdapters.DetallesTableAdapter();
            this.subdetallesTableAdapter = new Promowork.DatosPresupuestosTableAdapters.SubdetallesTableAdapter();
            this.cbxfacturas = new System.Windows.Forms.ComboBox();
            this.facturaPresupCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cuentasBancosTableAdapter = new Promowork.DatosPresupuestosTableAdapters.CuentasBancosTableAdapter();
            this.presupCabTableAdapter = new Promowork.DatosPresupuestosTableAdapters.PresupCabTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.facturaIncorrectaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaIncorrectaTableAdapter = new Promowork.DatosPresupuestosTableAdapters.FacturaIncorrectaTableAdapter();
            this.queriesPresupuestos1 = new Promowork.DatosPresupuestosTableAdapters.QueriesPresupuestos();
            this.chkSoloPrevisiones = new DevExpress.XtraEditors.CheckEdit();
            this.vComprasDirectasTableAdapter = new Promowork.DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter();
            this.facturasDetDirectaTableAdapter = new Promowork.DatosPresupuestosTableAdapters.FacturasDetDirectaTableAdapter();
            this.vComprasDirectasTableAdapterFactura = new Promowork.DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter();
            this.vDetallesHorasMaterialesTableAdapter = new Promowork.DatosPresupuestosTableAdapters.vDetallesHorasMaterialesTableAdapter();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            anticipoLabel = new System.Windows.Forms.Label();
            copiaFacturaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            obsFacturaLabel = new System.Windows.Forms.Label();
            mostrarVctoLabel = new System.Windows.Forms.Label();
            retencionLabel = new System.Windows.Forms.Label();
            descProntoLabel = new System.Windows.Forms.Label();
            descFacuraLabel = new System.Windows.Forms.Label();
            iVAFacturaLabel = new System.Windows.Forms.Label();
            certificacionLabel = new System.Windows.Forms.Label();
            idCuentaLabel = new System.Windows.Forms.Label();
            fechaVctoFactLabel = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            numFacturaLabel = new System.Windows.Forms.Label();
            idPresupLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            cantidadLabel1 = new System.Windows.Forms.Label();
            cantExtraLabel = new System.Windows.Forms.Label();
            precioLabel1 = new System.Windows.Forms.Label();
            totalDetLabel = new System.Windows.Forms.Label();
            totalFacturadoLabel = new System.Windows.Forms.Label();
            totalPendienteLabel = new System.Windows.Forms.Label();
            cantDetFactLabel = new System.Windows.Forms.Label();
            cantidadLabel2 = new System.Windows.Forms.Label();
            cantExtraLabel1 = new System.Windows.Forms.Label();
            precioLabel2 = new System.Windows.Forms.Label();
            pedienteLabel = new System.Windows.Forms.Label();
            totalSubLabel = new System.Windows.Forms.Label();
            cantSubFactLabel = new System.Windows.Forms.Label();
            totalFacturadoLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            obsFactura2Label = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostarPresup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esCertificacionCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarObra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubTot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esPrevisionCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDetalleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsFacturaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabDetalleHorasMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDetallesHorasMaterialesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetallesHorasMaterialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.tabDetallePresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetallesFacturasPresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetallesFactura)).BeginInit();
            this.tabDetallesFactura.SuspendLayout();
            this.tabFacturaDirectaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetDirectaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasBindingSourceFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPresupuestos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btQuitarCompraDirecta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarCompraDirecta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.tabPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obsFactura2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnImporte.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPendienteDet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantDetFactSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPendienteSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFacturadoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalDetSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantExtraSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subdetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPendienteSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFacturadoSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantSubFactSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSubSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedienteSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantExtraSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPorciento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetDirectaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingNavigator)).BeginInit();
            this.facturasCabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaPresupCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaIncorrectaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSoloPrevisiones.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // anticipoLabel
            // 
            anticipoLabel.AutoSize = true;
            anticipoLabel.Location = new System.Drawing.Point(314, 290);
            anticipoLabel.Name = "anticipoLabel";
            anticipoLabel.Size = new System.Drawing.Size(48, 13);
            anticipoLabel.TabIndex = 187;
            anticipoLabel.Text = "Anticipo:";
            // 
            // copiaFacturaLabel
            // 
            copiaFacturaLabel.AutoSize = true;
            copiaFacturaLabel.Location = new System.Drawing.Point(93, 379);
            copiaFacturaLabel.Name = "copiaFacturaLabel";
            copiaFacturaLabel.Size = new System.Drawing.Size(37, 13);
            copiaFacturaLabel.TabIndex = 179;
            copiaFacturaLabel.Text = "Copia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(72, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 176;
            label2.Text = "Facturar a:";
            // 
            // obsFacturaLabel
            // 
            obsFacturaLabel.AutoSize = true;
            obsFacturaLabel.Location = new System.Drawing.Point(85, 315);
            obsFacturaLabel.Name = "obsFacturaLabel";
            obsFacturaLabel.Size = new System.Drawing.Size(44, 13);
            obsFacturaLabel.TabIndex = 171;
            obsFacturaLabel.Text = "Observ:";
            // 
            // mostrarVctoLabel
            // 
            mostrarVctoLabel.AutoSize = true;
            mostrarVctoLabel.Location = new System.Drawing.Point(323, 224);
            mostrarVctoLabel.Name = "mostrarVctoLabel";
            mostrarVctoLabel.Size = new System.Drawing.Size(70, 13);
            mostrarVctoLabel.TabIndex = 165;
            mostrarVctoLabel.Text = "Mostrar Vcto:";
            // 
            // retencionLabel
            // 
            retencionLabel.AutoSize = true;
            retencionLabel.Location = new System.Drawing.Point(289, 268);
            retencionLabel.Name = "retencionLabel";
            retencionLabel.Size = new System.Drawing.Size(73, 13);
            retencionLabel.TabIndex = 160;
            retencionLabel.Text = "Retencion(%):";
            // 
            // descProntoLabel
            // 
            descProntoLabel.AutoSize = true;
            descProntoLabel.Location = new System.Drawing.Point(90, 268);
            descProntoLabel.Name = "descProntoLabel";
            descProntoLabel.Size = new System.Drawing.Size(93, 13);
            descProntoLabel.TabIndex = 159;
            descProntoLabel.Text = "Desc. P. Pago(%):";
            // 
            // descFacuraLabel
            // 
            descFacuraLabel.AutoSize = true;
            descFacuraLabel.Location = new System.Drawing.Point(104, 246);
            descFacuraLabel.Name = "descFacuraLabel";
            descFacuraLabel.Size = new System.Drawing.Size(79, 13);
            descFacuraLabel.TabIndex = 150;
            descFacuraLabel.Text = "Desc. Com.(%):";
            // 
            // iVAFacturaLabel
            // 
            iVAFacturaLabel.AutoSize = true;
            iVAFacturaLabel.Location = new System.Drawing.Point(321, 246);
            iVAFacturaLabel.Name = "iVAFacturaLabel";
            iVAFacturaLabel.Size = new System.Drawing.Size(41, 13);
            iVAFacturaLabel.TabIndex = 149;
            iVAFacturaLabel.Text = "IVA(%):";
            // 
            // certificacionLabel
            // 
            certificacionLabel.AutoSize = true;
            certificacionLabel.Location = new System.Drawing.Point(115, 224);
            certificacionLabel.Name = "certificacionLabel";
            certificacionLabel.Size = new System.Drawing.Size(68, 13);
            certificacionLabel.TabIndex = 148;
            certificacionLabel.Text = "Certificación:";
            // 
            // idCuentaLabel
            // 
            idCuentaLabel.AutoSize = true;
            idCuentaLabel.Location = new System.Drawing.Point(61, 134);
            idCuentaLabel.Name = "idCuentaLabel";
            idCuentaLabel.Size = new System.Drawing.Size(69, 13);
            idCuentaLabel.TabIndex = 147;
            idCuentaLabel.Text = "Presupuesto:";
            // 
            // fechaVctoFactLabel
            // 
            fechaVctoFactLabel.AutoSize = true;
            fechaVctoFactLabel.Location = new System.Drawing.Point(248, 202);
            fechaVctoFactLabel.Name = "fechaVctoFactLabel";
            fechaVctoFactLabel.Size = new System.Drawing.Size(65, 13);
            fechaVctoFactLabel.TabIndex = 146;
            fechaVctoFactLabel.Text = "Fecha Vcto:";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(90, 202);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(40, 13);
            fechaFacturaLabel.TabIndex = 143;
            fechaFacturaLabel.Text = "Fecha:";
            // 
            // numFacturaLabel
            // 
            numFacturaLabel.AutoSize = true;
            numFacturaLabel.Location = new System.Drawing.Point(83, 68);
            numFacturaLabel.Name = "numFacturaLabel";
            numFacturaLabel.Size = new System.Drawing.Size(47, 13);
            numFacturaLabel.TabIndex = 141;
            numFacturaLabel.Text = "Número:";
            // 
            // idPresupLabel
            // 
            idPresupLabel.AutoSize = true;
            idPresupLabel.Location = new System.Drawing.Point(85, 179);
            idPresupLabel.Name = "idPresupLabel";
            idPresupLabel.Size = new System.Drawing.Size(44, 13);
            idPresupLabel.TabIndex = 138;
            idPresupLabel.Text = "Cuenta:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(88, 91);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(42, 13);
            idClienteLabel.TabIndex = 135;
            idClienteLabel.Text = "Cliente:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(351, 167);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(15, 13);
            label27.TabIndex = 112;
            label27.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 59);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 13);
            label6.TabIndex = 108;
            label6.Text = "Subdetalle:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(29, 37);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(43, 13);
            label19.TabIndex = 107;
            label19.Text = "Detalle:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(22, 12);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(50, 13);
            label20.TabIndex = 106;
            label20.Text = "Capítulo:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(676, 167);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 104;
            importeLabel.Text = "Importe:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(217, 167);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 101;
            precioLabel.Text = "Precio:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(19, 167);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 99;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadLabel1
            // 
            cantidadLabel1.AutoSize = true;
            cantidadLabel1.Location = new System.Drawing.Point(13, 19);
            cantidadLabel1.Name = "cantidadLabel1";
            cantidadLabel1.Size = new System.Drawing.Size(52, 13);
            cantidadLabel1.TabIndex = 0;
            cantidadLabel1.Text = "Cantidad:";
            // 
            // cantExtraLabel
            // 
            cantExtraLabel.AutoSize = true;
            cantExtraLabel.Location = new System.Drawing.Point(456, 19);
            cantExtraLabel.Name = "cantExtraLabel";
            cantExtraLabel.Size = new System.Drawing.Size(34, 13);
            cantExtraLabel.TabIndex = 2;
            cantExtraLabel.Text = "Extra:";
            // 
            // precioLabel1
            // 
            precioLabel1.AutoSize = true;
            precioLabel1.Location = new System.Drawing.Point(249, 19);
            precioLabel1.Name = "precioLabel1";
            precioLabel1.Size = new System.Drawing.Size(40, 13);
            precioLabel1.TabIndex = 4;
            precioLabel1.Text = "Precio:";
            // 
            // totalDetLabel
            // 
            totalDetLabel.AutoSize = true;
            totalDetLabel.Location = new System.Drawing.Point(676, 19);
            totalDetLabel.Name = "totalDetLabel";
            totalDetLabel.Size = new System.Drawing.Size(34, 13);
            totalDetLabel.TabIndex = 6;
            totalDetLabel.Text = "Total:";
            // 
            // totalFacturadoLabel
            // 
            totalFacturadoLabel.AutoSize = true;
            totalFacturadoLabel.Location = new System.Drawing.Point(204, 46);
            totalFacturadoLabel.Name = "totalFacturadoLabel";
            totalFacturadoLabel.Size = new System.Drawing.Size(85, 13);
            totalFacturadoLabel.TabIndex = 8;
            totalFacturadoLabel.Text = "Total Facturado:";
            // 
            // totalPendienteLabel
            // 
            totalPendienteLabel.AutoSize = true;
            totalPendienteLabel.Location = new System.Drawing.Point(625, 46);
            totalPendienteLabel.Name = "totalPendienteLabel";
            totalPendienteLabel.Size = new System.Drawing.Size(85, 13);
            totalPendienteLabel.TabIndex = 10;
            totalPendienteLabel.Text = "Total Pendiente:";
            // 
            // cantDetFactLabel
            // 
            cantDetFactLabel.AutoSize = true;
            cantDetFactLabel.Location = new System.Drawing.Point(6, 46);
            cantDetFactLabel.Name = "cantDetFactLabel";
            cantDetFactLabel.Size = new System.Drawing.Size(58, 13);
            cantDetFactLabel.TabIndex = 12;
            cantDetFactLabel.Text = "Facturado:";
            // 
            // cantidadLabel2
            // 
            cantidadLabel2.AutoSize = true;
            cantidadLabel2.Location = new System.Drawing.Point(13, 19);
            cantidadLabel2.Name = "cantidadLabel2";
            cantidadLabel2.Size = new System.Drawing.Size(52, 13);
            cantidadLabel2.TabIndex = 0;
            cantidadLabel2.Text = "Cantidad:";
            // 
            // cantExtraLabel1
            // 
            cantExtraLabel1.AutoSize = true;
            cantExtraLabel1.Location = new System.Drawing.Point(456, 19);
            cantExtraLabel1.Name = "cantExtraLabel1";
            cantExtraLabel1.Size = new System.Drawing.Size(34, 13);
            cantExtraLabel1.TabIndex = 2;
            cantExtraLabel1.Text = "Extra:";
            // 
            // precioLabel2
            // 
            precioLabel2.AutoSize = true;
            precioLabel2.Location = new System.Drawing.Point(249, 19);
            precioLabel2.Name = "precioLabel2";
            precioLabel2.Size = new System.Drawing.Size(40, 13);
            precioLabel2.TabIndex = 4;
            precioLabel2.Text = "Precio:";
            // 
            // pedienteLabel
            // 
            pedienteLabel.AutoSize = true;
            pedienteLabel.Location = new System.Drawing.Point(631, 46);
            pedienteLabel.Name = "pedienteLabel";
            pedienteLabel.Size = new System.Drawing.Size(79, 13);
            pedienteLabel.TabIndex = 6;
            pedienteLabel.Text = "Total Pediente:";
            // 
            // totalSubLabel
            // 
            totalSubLabel.AutoSize = true;
            totalSubLabel.Location = new System.Drawing.Point(676, 19);
            totalSubLabel.Name = "totalSubLabel";
            totalSubLabel.Size = new System.Drawing.Size(34, 13);
            totalSubLabel.TabIndex = 8;
            totalSubLabel.Text = "Total:";
            // 
            // cantSubFactLabel
            // 
            cantSubFactLabel.AutoSize = true;
            cantSubFactLabel.Location = new System.Drawing.Point(7, 46);
            cantSubFactLabel.Name = "cantSubFactLabel";
            cantSubFactLabel.Size = new System.Drawing.Size(58, 13);
            cantSubFactLabel.TabIndex = 10;
            cantSubFactLabel.Text = "Facturado:";
            // 
            // totalFacturadoLabel1
            // 
            totalFacturadoLabel1.AutoSize = true;
            totalFacturadoLabel1.Location = new System.Drawing.Point(204, 46);
            totalFacturadoLabel1.Name = "totalFacturadoLabel1";
            totalFacturadoLabel1.Size = new System.Drawing.Size(85, 13);
            totalFacturadoLabel1.TabIndex = 12;
            totalFacturadoLabel1.Text = "Total Facturado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(486, 167);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 13);
            label3.TabIndex = 120;
            label3.Text = "Descuento (%):";
            // 
            // obsFactura2Label
            // 
            obsFactura2Label.AutoSize = true;
            obsFactura2Label.Location = new System.Drawing.Point(14, 248);
            obsFactura2Label.Name = "obsFactura2Label";
            obsFactura2Label.Size = new System.Drawing.Size(149, 13);
            obsFactura2Label.TabIndex = 0;
            obsFactura2Label.Text = "Observaciones pie de Página:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(97, 156);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 13);
            label4.TabIndex = 195;
            label4.Text = "Obra:";
            // 
            // colFacturaPresup
            // 
            this.colFacturaPresup.FieldName = "FacturaPresup";
            this.colFacturaPresup.Name = "colFacturaPresup";
            // 
            // colEntregada
            // 
            this.colEntregada.FieldName = "Entregada";
            this.colEntregada.Name = "colEntregada";
            // 
            // Pendiente
            // 
            this.Pendiente.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Pendiente.AppearanceCell.Options.UseFont = true;
            this.Pendiente.AppearanceHeader.Options.UseTextOptions = true;
            this.Pendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Pendiente.Caption = "Pendiente";
            this.Pendiente.DisplayFormat.FormatString = "c2";
            this.Pendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Pendiente.FieldName = "Pendiente";
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pendiente", "{0:c2}")});
            this.Pendiente.UnboundExpression = "([Total]-round([Total]*iif(isnull([Retencion]),0,[Retencion])/100,2))-[TotalCobra" +
    "do]";
            this.Pendiente.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Pendiente.Visible = true;
            this.Pendiente.VisibleIndex = 13;
            this.Pendiente.Width = 66;
            // 
            // colObraCorrecta
            // 
            this.colObraCorrecta.FieldName = "ObraCorrecta";
            this.colObraCorrecta.Name = "colObraCorrecta";
            // 
            // colFacturaDirecta1
            // 
            this.colFacturaDirecta1.FieldName = "FacturaDirecta";
            this.colFacturaDirecta1.Name = "colFacturaDirecta1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 724);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.facturasCabGridControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(label4);
            this.splitContainer2.Panel2.Controls.Add(this.cbObra);
            this.splitContainer2.Panel2.Controls.Add(this.chkMostarPresup);
            this.splitContainer2.Panel2.Controls.Add(this.esCertificacionCheckEdit);
            this.splitContainer2.Panel2.Controls.Add(this.txtSerieFact);
            this.splitContainer2.Panel2.Controls.Add(this.chkMostrarObra);
            this.splitContainer2.Panel2.Controls.Add(this.chkSubTot);
            this.splitContainer2.Panel2.Controls.Add(anticipoLabel);
            this.splitContainer2.Panel2.Controls.Add(this.esPrevisionCheckEdit);
            this.splitContainer2.Panel2.Controls.Add(this.anticipoTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.button5);
            this.splitContainer2.Panel2.Controls.Add(this.noDetalleCheckEdit);
            this.splitContainer2.Panel2.Controls.Add(this.entregadaCheckBox);
            this.splitContainer2.Panel2.Controls.Add(this.facturaCheckBox);
            this.splitContainer2.Panel2.Controls.Add(copiaFacturaLabel);
            this.splitContainer2.Panel2.Controls.Add(label2);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer2.Panel2.Controls.Add(this.copiaFacturaTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(obsFacturaLabel);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(mostrarVctoLabel);
            this.splitContainer2.Panel2.Controls.Add(this.mostrarVctoCheckBox);
            this.splitContainer2.Panel2.Controls.Add(retencionLabel);
            this.splitContainer2.Panel2.Controls.Add(this.retencionTextBox);
            this.splitContainer2.Panel2.Controls.Add(descProntoLabel);
            this.splitContainer2.Panel2.Controls.Add(this.descProntoTextBox);
            this.splitContainer2.Panel2.Controls.Add(descFacuraLabel);
            this.splitContainer2.Panel2.Controls.Add(this.descFacuraTextBox);
            this.splitContainer2.Panel2.Controls.Add(iVAFacturaLabel);
            this.splitContainer2.Panel2.Controls.Add(this.iVAFacturaTextBox);
            this.splitContainer2.Panel2.Controls.Add(certificacionLabel);
            this.splitContainer2.Panel2.Controls.Add(this.certificacionTextBox);
            this.splitContainer2.Panel2.Controls.Add(idCuentaLabel);
            this.splitContainer2.Panel2.Controls.Add(this.idCuentaComboBox);
            this.splitContainer2.Panel2.Controls.Add(fechaVctoFactLabel);
            this.splitContainer2.Panel2.Controls.Add(this.fechaVctoFactDateTimePicker);
            this.splitContainer2.Panel2.Controls.Add(fechaFacturaLabel);
            this.splitContainer2.Panel2.Controls.Add(this.fechaFacturaDateTimePicker);
            this.splitContainer2.Panel2.Controls.Add(numFacturaLabel);
            this.splitContainer2.Panel2.Controls.Add(this.numFacturaTextBox);
            this.splitContainer2.Panel2.Controls.Add(idPresupLabel);
            this.splitContainer2.Panel2.Controls.Add(this.idPresupComboBox);
            this.splitContainer2.Panel2.Controls.Add(idClienteLabel);
            this.splitContainer2.Panel2.Controls.Add(this.idClienteComboBox);
            this.splitContainer2.Panel2.Controls.Add(this.obsFacturaTextEdit);
            this.splitContainer2.Size = new System.Drawing.Size(1366, 409);
            this.splitContainer2.SplitterDistance = 853;
            this.splitContainer2.TabIndex = 0;
            // 
            // facturasCabGridControl
            // 
            this.facturasCabGridControl.DataSource = this.facturasCabBindingSource;
            this.facturasCabGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facturasCabGridControl.Location = new System.Drawing.Point(0, 0);
            this.facturasCabGridControl.MainView = this.gridView1;
            this.facturasCabGridControl.Name = "facturasCabGridControl";
            this.facturasCabGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Clientes,
            this.Obras,
            this.ClienteFactura});
            this.facturasCabGridControl.Size = new System.Drawing.Size(853, 409);
            this.facturasCabGridControl.TabIndex = 0;
            this.facturasCabGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // facturasCabBindingSource
            // 
            this.facturasCabBindingSource.DataMember = "FacturasCab";
            this.facturasCabBindingSource.DataSource = this.datosPresupuestos;
            // 
            // datosPresupuestos
            // 
            this.datosPresupuestos.DataSetName = "DatosPresupuestos";
            this.datosPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactCab,
            this.colIdEmpresa,
            this.colIdCliente,
            this.colIdClienteFact,
            this.colIdObra,
            this.colIdPresup,
            this.colIdUsuario,
            this.colNumFactura,
            this.colSerieFact,
            this.colFechaFactura,
            this.colFechaVctoFact,
            this.colMostrarVcto,
            this.colMostrarObra,
            this.colIdCuenta,
            this.colCertificacion,
            this.colDescFactura,
            this.colDescPronto,
            this.colRetencion,
            this.colIVAFactura,
            this.colCobrada,
            this.colObsFactura,
            this.colFacturaPresup,
            this.colCopiaFactura,
            this.colFactura,
            this.colEntregada,
            this.colNoDetalle,
            this.colObsFactura2,
            this.colEsPrevision,
            this.colAnticipo,
            this.colMostrarSubTot,
            this.colCargoMitadDesc,
            this.colTotalBase,
            this.ImporteIVA,
            this.Descuentos,
            this.colTotal1,
            this.Retencion,
            this.TotalPagar,
            this.colTotalCobrado,
            this.Pendiente,
            this.colEsCertificacion});
            styleFormatCondition6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            styleFormatCondition6.Appearance.Options.UseFont = true;
            styleFormatCondition6.ApplyToRow = true;
            styleFormatCondition6.Column = this.colFacturaPresup;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition6.Value1 = true;
            styleFormatCondition7.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition7.Appearance.Options.UseBackColor = true;
            styleFormatCondition7.ApplyToRow = true;
            styleFormatCondition7.Column = this.colEntregada;
            styleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition7.Value1 = true;
            styleFormatCondition8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            styleFormatCondition8.Appearance.Options.UseBackColor = true;
            styleFormatCondition8.ApplyToRow = true;
            styleFormatCondition8.Column = this.Pendiente;
            styleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition8.Value1 = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition6,
            styleFormatCondition7,
            styleFormatCondition8});
            this.gridView1.GridControl = this.facturasCabGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdFactCab
            // 
            this.colIdFactCab.FieldName = "IdFactCab";
            this.colIdFactCab.Name = "colIdFactCab";
            this.colIdFactCab.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Cliente";
            this.colIdCliente.ColumnEdit = this.Clientes;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 3;
            this.colIdCliente.Width = 101;
            // 
            // Clientes
            // 
            this.Clientes.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.Clientes.AutoHeight = false;
            this.Clientes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Clientes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesCliente", "Cliente", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Clientes.DataSource = this.clientesBindingSource;
            this.Clientes.DisplayMember = "DesCliente";
            this.Clientes.Name = "Clientes";
            this.Clientes.NullText = "";
            this.Clientes.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.Clientes.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.datosPresupuestos;
            // 
            // colIdClienteFact
            // 
            this.colIdClienteFact.Caption = "Cliente Factura";
            this.colIdClienteFact.ColumnEdit = this.ClienteFactura;
            this.colIdClienteFact.FieldName = "IdClienteFact";
            this.colIdClienteFact.Name = "colIdClienteFact";
            this.colIdClienteFact.Visible = true;
            this.colIdClienteFact.VisibleIndex = 4;
            this.colIdClienteFact.Width = 102;
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
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.datosPresupuestos;
            // 
            // colIdObra
            // 
            this.colIdObra.Caption = "Obra";
            this.colIdObra.ColumnEdit = this.Obras;
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdObra.Visible = true;
            this.colIdObra.VisibleIndex = 5;
            this.colIdObra.Width = 109;
            // 
            // Obras
            // 
            this.Obras.AutoHeight = false;
            this.Obras.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Obras.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Obra", "Obra", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Obras.DataSource = this.obrasBindingSource;
            this.Obras.DisplayMember = "Obra";
            this.Obras.Name = "Obras";
            this.Obras.NullText = "";
            this.Obras.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.Obras.ValueMember = "IdObra";
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.datosPresupuestos;
            // 
            // colIdPresup
            // 
            this.colIdPresup.Caption = "Presupuesto";
            this.colIdPresup.FieldName = "IdPresup";
            this.colIdPresup.Name = "colIdPresup";
            this.colIdPresup.Width = 58;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colNumFactura
            // 
            this.colNumFactura.AppearanceCell.Options.UseTextOptions = true;
            this.colNumFactura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumFactura.Caption = "Nº";
            this.colNumFactura.FieldName = "NumFactura";
            this.colNumFactura.Name = "colNumFactura";
            this.colNumFactura.Visible = true;
            this.colNumFactura.VisibleIndex = 0;
            this.colNumFactura.Width = 31;
            // 
            // colSerieFact
            // 
            this.colSerieFact.Caption = " ";
            this.colSerieFact.FieldName = "SerieFact";
            this.colSerieFact.Name = "colSerieFact";
            this.colSerieFact.Visible = true;
            this.colSerieFact.VisibleIndex = 1;
            this.colSerieFact.Width = 20;
            // 
            // colFechaFactura
            // 
            this.colFechaFactura.Caption = "Fecha";
            this.colFechaFactura.FieldName = "FechaFactura";
            this.colFechaFactura.Name = "colFechaFactura";
            this.colFechaFactura.Visible = true;
            this.colFechaFactura.VisibleIndex = 2;
            this.colFechaFactura.Width = 48;
            // 
            // colFechaVctoFact
            // 
            this.colFechaVctoFact.Caption = "Vencimiento";
            this.colFechaVctoFact.FieldName = "FechaVctoFact";
            this.colFechaVctoFact.Name = "colFechaVctoFact";
            // 
            // colMostrarVcto
            // 
            this.colMostrarVcto.Caption = "Mostrar Vto";
            this.colMostrarVcto.FieldName = "MostrarVcto";
            this.colMostrarVcto.Name = "colMostrarVcto";
            // 
            // colMostrarObra
            // 
            this.colMostrarObra.FieldName = "MostrarObra";
            this.colMostrarObra.Name = "colMostrarObra";
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "Cuenta";
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Width = 58;
            // 
            // colCertificacion
            // 
            this.colCertificacion.FieldName = "Certificacion";
            this.colCertificacion.Name = "colCertificacion";
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
            // colIVAFactura
            // 
            this.colIVAFactura.Caption = "IVA";
            this.colIVAFactura.FieldName = "IVAFactura";
            this.colIVAFactura.Name = "colIVAFactura";
            this.colIVAFactura.Width = 214;
            // 
            // colCobrada
            // 
            this.colCobrada.FieldName = "Cobrada";
            this.colCobrada.Name = "colCobrada";
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
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            // 
            // colNoDetalle
            // 
            this.colNoDetalle.FieldName = "NoDetalle";
            this.colNoDetalle.Name = "colNoDetalle";
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
            // colCargoMitadDesc
            // 
            this.colCargoMitadDesc.FieldName = "CargoMitadDesc";
            this.colCargoMitadDesc.Name = "colCargoMitadDesc";
            // 
            // colTotalBase
            // 
            this.colTotalBase.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotalBase.AppearanceCell.Options.UseFont = true;
            this.colTotalBase.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalBase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalBase.Caption = "Base";
            this.colTotalBase.DisplayFormat.FormatString = "C2";
            this.colTotalBase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalBase.FieldName = "TotalBase";
            this.colTotalBase.Name = "colTotalBase";
            this.colTotalBase.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalBase", "{0:c2}")});
            this.colTotalBase.Visible = true;
            this.colTotalBase.VisibleIndex = 6;
            this.colTotalBase.Width = 56;
            // 
            // ImporteIVA
            // 
            this.ImporteIVA.AppearanceHeader.Options.UseTextOptions = true;
            this.ImporteIVA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ImporteIVA.Caption = "IVA";
            this.ImporteIVA.DisplayFormat.FormatString = "C2";
            this.ImporteIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImporteIVA.FieldName = "ImporteIVA";
            this.ImporteIVA.Name = "ImporteIVA";
            this.ImporteIVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteIVA", "{0:c2}")});
            this.ImporteIVA.UnboundExpression = "round(([TotalBase]- round([TotalBase]*((Iif(IsNull([DescFactura]),0 ,[DescFactura" +
    "])+Iif(IsNull([DescPronto]),0 ,[DescPronto]))/100),2) )*Iif(IsNull([IVAFactura])" +
    ",0  , [IVAFactura])/100,2)";
            this.ImporteIVA.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.ImporteIVA.Visible = true;
            this.ImporteIVA.VisibleIndex = 8;
            this.ImporteIVA.Width = 40;
            // 
            // Descuentos
            // 
            this.Descuentos.AppearanceHeader.Options.UseTextOptions = true;
            this.Descuentos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Descuentos.Caption = "Descuentos";
            this.Descuentos.DisplayFormat.FormatString = "C2";
            this.Descuentos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Descuentos.FieldName = "Descuentos";
            this.Descuentos.Name = "Descuentos";
            this.Descuentos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuentos", "{0:c2}")});
            this.Descuentos.UnboundExpression = "round([TotalBase]*((Iif(IsNull([DescFactura]),0 ,[DescFactura])+Iif(IsNull([DescP" +
    "ronto]),0 ,[DescPronto]))/100),2)";
            this.Descuentos.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Descuentos.Visible = true;
            this.Descuentos.VisibleIndex = 7;
            this.Descuentos.Width = 40;
            // 
            // colTotal1
            // 
            this.colTotal1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotal1.AppearanceCell.Options.UseFont = true;
            this.colTotal1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal1.Caption = "Total";
            this.colTotal1.DisplayFormat.FormatString = "C2";
            this.colTotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal1.FieldName = "Total";
            this.colTotal1.Name = "colTotal1";
            this.colTotal1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")});
            this.colTotal1.Visible = true;
            this.colTotal1.VisibleIndex = 9;
            this.colTotal1.Width = 61;
            // 
            // Retencion
            // 
            this.Retencion.AppearanceHeader.Options.UseTextOptions = true;
            this.Retencion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Retencion.Caption = "Retención";
            this.Retencion.DisplayFormat.FormatString = "C2";
            this.Retencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Retencion.FieldName = "Retencion";
            this.Retencion.Name = "Retencion";
            this.Retencion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retencion", "{0:c2}")});
            this.Retencion.UnboundExpression = "round([Total]*iif(isnull([Retencion]),0,[Retencion])/100,2)";
            this.Retencion.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Retencion.Visible = true;
            this.Retencion.VisibleIndex = 10;
            this.Retencion.Width = 46;
            // 
            // TotalPagar
            // 
            this.TotalPagar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TotalPagar.AppearanceCell.Options.UseFont = true;
            this.TotalPagar.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalPagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TotalPagar.Caption = "Total a Pagar";
            this.TotalPagar.DisplayFormat.FormatString = "C2";
            this.TotalPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPagar.FieldName = "TotalPagar";
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPagar", "{0:c2}")});
            this.TotalPagar.UnboundExpression = "[Total]-round([Total]*iif(isnull([Retencion]),0,[Retencion])/100,2)";
            this.TotalPagar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalPagar.Visible = true;
            this.TotalPagar.VisibleIndex = 11;
            this.TotalPagar.Width = 53;
            // 
            // colTotalCobrado
            // 
            this.colTotalCobrado.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCobrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalCobrado.Caption = "Cobrado";
            this.colTotalCobrado.DisplayFormat.FormatString = "C2";
            this.colTotalCobrado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCobrado.FieldName = "TotalCobrado";
            this.colTotalCobrado.Name = "colTotalCobrado";
            this.colTotalCobrado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCobrado", "{0:c2}")});
            this.colTotalCobrado.Visible = true;
            this.colTotalCobrado.VisibleIndex = 12;
            this.colTotalCobrado.Width = 54;
            // 
            // colEsCertificacion
            // 
            this.colEsCertificacion.Caption = "Cerificación";
            this.colEsCertificacion.FieldName = "EsCertificacion";
            this.colEsCertificacion.Name = "colEsCertificacion";
            // 
            // cbObra
            // 
            this.cbObra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbObra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdObra", true));
            this.cbObra.DataSource = this.obrasBindingSource1;
            this.cbObra.DisplayMember = "Obra";
            this.cbObra.FormattingEnabled = true;
            this.cbObra.Location = new System.Drawing.Point(132, 153);
            this.cbObra.Name = "cbObra";
            this.cbObra.Size = new System.Drawing.Size(282, 21);
            this.cbObra.TabIndex = 194;
            this.cbObra.ValueMember = "IdObra";
            // 
            // obrasBindingSource1
            // 
            this.obrasBindingSource1.DataMember = "Obras";
            this.obrasBindingSource1.DataSource = this.datosPresupuestos;
            // 
            // chkMostarPresup
            // 
            this.chkMostarPresup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "MostrarPresup", true));
            this.chkMostarPresup.Location = new System.Drawing.Point(339, 29);
            this.chkMostarPresup.Name = "chkMostarPresup";
            this.chkMostarPresup.Properties.Caption = "Mostrar Nombre Presupuesto";
            this.chkMostarPresup.Size = new System.Drawing.Size(167, 19);
            this.chkMostarPresup.TabIndex = 193;
            // 
            // esCertificacionCheckEdit
            // 
            this.esCertificacionCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "EsCertificacion", true));
            this.esCertificacionCheckEdit.Location = new System.Drawing.Point(130, 30);
            this.esCertificacionCheckEdit.Name = "esCertificacionCheckEdit";
            this.esCertificacionCheckEdit.Properties.Caption = "Certificación";
            this.esCertificacionCheckEdit.Size = new System.Drawing.Size(86, 19);
            this.esCertificacionCheckEdit.TabIndex = 192;
            // 
            // txtSerieFact
            // 
            this.txtSerieFact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "SerieFact", true));
            this.txtSerieFact.Location = new System.Drawing.Point(186, 64);
            this.txtSerieFact.MaxLength = 1;
            this.txtSerieFact.Name = "txtSerieFact";
            this.txtSerieFact.Size = new System.Drawing.Size(22, 20);
            this.txtSerieFact.TabIndex = 191;
            // 
            // chkMostrarObra
            // 
            this.chkMostrarObra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "MostrarObra", true));
            this.chkMostrarObra.Location = new System.Drawing.Point(339, 7);
            this.chkMostrarObra.Name = "chkMostrarObra";
            this.chkMostrarObra.Properties.Caption = "Mostrar Obra";
            this.chkMostrarObra.Size = new System.Drawing.Size(90, 19);
            this.chkMostrarObra.TabIndex = 186;
            // 
            // chkSubTot
            // 
            this.chkSubTot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "MostrarSubTot", true));
            this.chkSubTot.Location = new System.Drawing.Point(215, 30);
            this.chkSubTot.Name = "chkSubTot";
            this.chkSubTot.Properties.Caption = "Mostrar Subtotales ";
            this.chkSubTot.Size = new System.Drawing.Size(118, 19);
            this.chkSubTot.TabIndex = 190;
            this.chkSubTot.ToolTip = "Muestra subtotales por días.";
            // 
            // esPrevisionCheckEdit
            // 
            this.esPrevisionCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "EsPrevision", true));
            this.esPrevisionCheckEdit.Location = new System.Drawing.Point(130, 8);
            this.esPrevisionCheckEdit.Name = "esPrevisionCheckEdit";
            this.esPrevisionCheckEdit.Properties.Caption = "Previsión";
            this.esPrevisionCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.esPrevisionCheckEdit.TabIndex = 189;
            // 
            // anticipoTextBox
            // 
            this.anticipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "Anticipo", true));
            this.anticipoTextBox.Location = new System.Drawing.Point(365, 287);
            this.anticipoTextBox.Name = "anticipoTextBox";
            this.anticipoTextBox.Size = new System.Drawing.Size(49, 20);
            this.anticipoTextBox.TabIndex = 188;
            // 
            // button5
            // 
            this.button5.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button5.Location = new System.Drawing.Point(416, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 21);
            this.button5.TabIndex = 185;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // noDetalleCheckEdit
            // 
            this.noDetalleCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "NoDetalle", true));
            this.noDetalleCheckEdit.Location = new System.Drawing.Point(215, 8);
            this.noDetalleCheckEdit.Name = "noDetalleCheckEdit";
            this.noDetalleCheckEdit.Properties.Caption = "Sin Detalle";
            this.noDetalleCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.noDetalleCheckEdit.TabIndex = 183;
            // 
            // entregadaCheckBox
            // 
            this.entregadaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.facturasCabBindingSource, "Entregada", true));
            this.entregadaCheckBox.Location = new System.Drawing.Point(35, 29);
            this.entregadaCheckBox.Name = "entregadaCheckBox";
            this.entregadaCheckBox.Size = new System.Drawing.Size(84, 21);
            this.entregadaCheckBox.TabIndex = 182;
            this.entregadaCheckBox.Text = "Entregada";
            this.entregadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // facturaCheckBox
            // 
            this.facturaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.facturasCabBindingSource, "Factura", true));
            this.facturaCheckBox.Location = new System.Drawing.Point(35, 6);
            this.facturaCheckBox.Name = "facturaCheckBox";
            this.facturaCheckBox.Size = new System.Drawing.Size(66, 22);
            this.facturaCheckBox.TabIndex = 181;
            this.facturaCheckBox.Text = "Factura";
            this.facturaCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdClienteFact", true));
            this.comboBox2.DataSource = this.clientesBindingSource1;
            this.comboBox2.DisplayMember = "DesCliente";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(132, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "IdCliente";
            // 
            // copiaFacturaTextBox
            // 
            this.copiaFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "CopiaFactura", true));
            this.copiaFacturaTextBox.Location = new System.Drawing.Point(132, 376);
            this.copiaFacturaTextBox.Name = "copiaFacturaTextBox";
            this.copiaFacturaTextBox.Size = new System.Drawing.Size(122, 20);
            this.copiaFacturaTextBox.TabIndex = 173;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 177;
            this.button4.Text = "Ver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Promowork.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.button3.Location = new System.Drawing.Point(389, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 178;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 175;
            this.button1.Text = "Copia Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarVctoCheckBox
            // 
            this.mostrarVctoCheckBox.AutoSize = true;
            this.mostrarVctoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.facturasCabBindingSource, "MostrarVcto", true));
            this.mostrarVctoCheckBox.Location = new System.Drawing.Point(396, 223);
            this.mostrarVctoCheckBox.Name = "mostrarVctoCheckBox";
            this.mostrarVctoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.mostrarVctoCheckBox.TabIndex = 166;
            this.mostrarVctoCheckBox.UseVisualStyleBackColor = true;
            // 
            // retencionTextBox
            // 
            this.retencionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "Retencion", true));
            this.retencionTextBox.Location = new System.Drawing.Point(365, 264);
            this.retencionTextBox.Name = "retencionTextBox";
            this.retencionTextBox.Size = new System.Drawing.Size(49, 20);
            this.retencionTextBox.TabIndex = 145;
            // 
            // descProntoTextBox
            // 
            this.descProntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "DescPronto", true));
            this.descProntoTextBox.Location = new System.Drawing.Point(186, 264);
            this.descProntoTextBox.Name = "descProntoTextBox";
            this.descProntoTextBox.Size = new System.Drawing.Size(49, 20);
            this.descProntoTextBox.TabIndex = 142;
            // 
            // descFacuraTextBox
            // 
            this.descFacuraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "DescFactura", true));
            this.descFacuraTextBox.Location = new System.Drawing.Point(186, 242);
            this.descFacuraTextBox.Name = "descFacuraTextBox";
            this.descFacuraTextBox.Size = new System.Drawing.Size(49, 20);
            this.descFacuraTextBox.TabIndex = 140;
            // 
            // iVAFacturaTextBox
            // 
            this.iVAFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "IVAFactura", true));
            this.iVAFacturaTextBox.Location = new System.Drawing.Point(365, 242);
            this.iVAFacturaTextBox.Name = "iVAFacturaTextBox";
            this.iVAFacturaTextBox.Size = new System.Drawing.Size(49, 20);
            this.iVAFacturaTextBox.TabIndex = 144;
            // 
            // certificacionTextBox
            // 
            this.certificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "Certificacion", true));
            this.certificacionTextBox.Location = new System.Drawing.Point(186, 220);
            this.certificacionTextBox.Name = "certificacionTextBox";
            this.certificacionTextBox.Size = new System.Drawing.Size(49, 20);
            this.certificacionTextBox.TabIndex = 139;
            // 
            // idCuentaComboBox
            // 
            this.idCuentaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idCuentaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idCuentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdCuenta", true));
            this.idCuentaComboBox.DataSource = this.cuentasBancosBindingSource;
            this.idCuentaComboBox.DisplayMember = "CuentaBanco";
            this.idCuentaComboBox.FormattingEnabled = true;
            this.idCuentaComboBox.Location = new System.Drawing.Point(132, 176);
            this.idCuentaComboBox.Name = "idCuentaComboBox";
            this.idCuentaComboBox.Size = new System.Drawing.Size(282, 21);
            this.idCuentaComboBox.TabIndex = 4;
            this.idCuentaComboBox.ValueMember = "IdCuenta";
            // 
            // cuentasBancosBindingSource
            // 
            this.cuentasBancosBindingSource.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource.DataSource = this.datosPresupuestos;
            // 
            // fechaVctoFactDateTimePicker
            // 
            this.fechaVctoFactDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturasCabBindingSource, "FechaVctoFact", true));
            this.fechaVctoFactDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVctoFactDateTimePicker.Location = new System.Drawing.Point(319, 198);
            this.fechaVctoFactDateTimePicker.Name = "fechaVctoFactDateTimePicker";
            this.fechaVctoFactDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.fechaVctoFactDateTimePicker.TabIndex = 6;
            // 
            // fechaFacturaDateTimePicker
            // 
            this.fechaFacturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturasCabBindingSource, "FechaFactura", true));
            this.fechaFacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFacturaDateTimePicker.Location = new System.Drawing.Point(132, 198);
            this.fechaFacturaDateTimePicker.Name = "fechaFacturaDateTimePicker";
            this.fechaFacturaDateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.fechaFacturaDateTimePicker.TabIndex = 5;
            // 
            // numFacturaTextBox
            // 
            this.numFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasCabBindingSource, "NumFactura", true));
            this.numFacturaTextBox.Location = new System.Drawing.Point(132, 64);
            this.numFacturaTextBox.Name = "numFacturaTextBox";
            this.numFacturaTextBox.Size = new System.Drawing.Size(51, 20);
            this.numFacturaTextBox.TabIndex = 0;
            // 
            // idPresupComboBox
            // 
            this.idPresupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idPresupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idPresupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdPresup", true));
            this.idPresupComboBox.DataSource = this.presupCabBindingSource;
            this.idPresupComboBox.DisplayMember = "NomPresup";
            this.idPresupComboBox.FormattingEnabled = true;
            this.idPresupComboBox.Location = new System.Drawing.Point(132, 131);
            this.idPresupComboBox.Name = "idPresupComboBox";
            this.idPresupComboBox.Size = new System.Drawing.Size(282, 21);
            this.idPresupComboBox.TabIndex = 3;
            this.idPresupComboBox.ValueMember = "IdPresupCab";
            // 
            // presupCabBindingSource
            // 
            this.presupCabBindingSource.DataMember = "FK_Presupuestos_Clientes";
            this.presupCabBindingSource.DataSource = this.clientesBindingSource;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturasCabBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "DesCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(132, 87);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(282, 21);
            this.idClienteComboBox.TabIndex = 1;
            this.idClienteComboBox.ValueMember = "IdCliente";
            this.idClienteComboBox.SelectedValueChanged += new System.EventHandler(this.idClienteComboBox_SelectedValueChanged);
            // 
            // obsFacturaTextEdit
            // 
            this.obsFacturaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "ObsFactura", true));
            this.obsFacturaTextEdit.Location = new System.Drawing.Point(132, 313);
            this.obsFacturaTextEdit.Name = "obsFacturaTextEdit";
            this.obsFacturaTextEdit.Size = new System.Drawing.Size(282, 55);
            this.obsFacturaTextEdit.TabIndex = 172;
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
            this.splitContainer3.Panel1.Controls.Add(this.xtraTabControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1366, 303);
            this.splitContainer3.SplitterDistance = 511;
            this.splitContainer3.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabDetalleHorasMateriales;
            this.xtraTabControl1.Size = new System.Drawing.Size(511, 303);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDetallePresupuesto,
            this.tabDetalleHorasMateriales});
            // 
            // tabDetalleHorasMateriales
            // 
            this.tabDetalleHorasMateriales.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabDetalleHorasMateriales.Appearance.Header.Options.UseFont = true;
            this.tabDetalleHorasMateriales.Controls.Add(this.vDetallesHorasMaterialesGridControl);
            this.tabDetalleHorasMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDetalleHorasMateriales.Name = "tabDetalleHorasMateriales";
            this.tabDetalleHorasMateriales.Size = new System.Drawing.Size(505, 275);
            this.tabDetalleHorasMateriales.Text = "Detalle Horas Materiales";
            // 
            // vDetallesHorasMaterialesGridControl
            // 
            this.vDetallesHorasMaterialesGridControl.DataSource = this.vDetallesHorasMaterialesBindingSource;
            this.vDetallesHorasMaterialesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vDetallesHorasMaterialesGridControl.Location = new System.Drawing.Point(0, 0);
            this.vDetallesHorasMaterialesGridControl.MainView = this.gridView6;
            this.vDetallesHorasMaterialesGridControl.Name = "vDetallesHorasMaterialesGridControl";
            this.vDetallesHorasMaterialesGridControl.Size = new System.Drawing.Size(505, 275);
            this.vDetallesHorasMaterialesGridControl.TabIndex = 0;
            this.vDetallesHorasMaterialesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // vDetallesHorasMaterialesBindingSource
            // 
            this.vDetallesHorasMaterialesBindingSource.DataMember = "vDetallesHorasMateriales";
            this.vDetallesHorasMaterialesBindingSource.DataSource = this.datosPresupuestos;
            // 
            // gridView6
            // 
            this.gridView6.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView6.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView6.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactCab5,
            this.colIdHoras,
            this.colDirTrabajo,
            this.colFechaDescripcion,
            this.colCantidad2,
            this.colPrecio2,
            this.colDescuento,
            this.colTotal3,
            this.colDetalle1,
            this.colUM2});
            this.gridView6.GridControl = this.vDetallesHorasMaterialesGridControl;
            this.gridView6.GroupCount = 2;
            this.gridView6.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, "{0:c2}")});
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsBehavior.ReadOnly = true;
            this.gridView6.OptionsView.ShowFooter = true;
            this.gridView6.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDirTrabajo, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaDescripcion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdFactCab5
            // 
            this.colIdFactCab5.FieldName = "IdFactCab";
            this.colIdFactCab5.Name = "colIdFactCab5";
            // 
            // colIdHoras
            // 
            this.colIdHoras.FieldName = "IdHoras";
            this.colIdHoras.Name = "colIdHoras";
            // 
            // colDirTrabajo
            // 
            this.colDirTrabajo.Caption = "Dirección";
            this.colDirTrabajo.FieldName = "DirTrabajo";
            this.colDirTrabajo.Name = "colDirTrabajo";
            this.colDirTrabajo.Visible = true;
            this.colDirTrabajo.VisibleIndex = 0;
            // 
            // colFechaDescripcion
            // 
            this.colFechaDescripcion.Caption = "Trabajo Realizado";
            this.colFechaDescripcion.FieldName = "FechaDescripcion";
            this.colFechaDescripcion.Name = "colFechaDescripcion";
            this.colFechaDescripcion.Visible = true;
            this.colFechaDescripcion.VisibleIndex = 0;
            // 
            // colCantidad2
            // 
            this.colCantidad2.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad2.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad2.Caption = "Cantidad";
            this.colCantidad2.DisplayFormat.FormatString = "N2";
            this.colCantidad2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad2.FieldName = "Cantidad";
            this.colCantidad2.Name = "colCantidad2";
            this.colCantidad2.Visible = true;
            this.colCantidad2.VisibleIndex = 0;
            this.colCantidad2.Width = 62;
            // 
            // colPrecio2
            // 
            this.colPrecio2.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio2.Caption = "Precio";
            this.colPrecio2.DisplayFormat.FormatString = "C6";
            this.colPrecio2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio2.FieldName = "Precio";
            this.colPrecio2.Name = "colPrecio2";
            this.colPrecio2.Visible = true;
            this.colPrecio2.VisibleIndex = 3;
            this.colPrecio2.Width = 120;
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuento.Caption = "Descuento";
            this.colDescuento.DisplayFormat.FormatString = "P2";
            this.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 4;
            this.colDescuento.Width = 120;
            // 
            // colTotal3
            // 
            this.colTotal3.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal3.Caption = "Total";
            this.colTotal3.DisplayFormat.FormatString = "C2";
            this.colTotal3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal3.FieldName = "Total";
            this.colTotal3.Name = "colTotal3";
            this.colTotal3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")});
            this.colTotal3.Visible = true;
            this.colTotal3.VisibleIndex = 5;
            this.colTotal3.Width = 116;
            // 
            // colDetalle1
            // 
            this.colDetalle1.Caption = "Descripción";
            this.colDetalle1.FieldName = "Detalle";
            this.colDetalle1.Name = "colDetalle1";
            this.colDetalle1.Visible = true;
            this.colDetalle1.VisibleIndex = 2;
            this.colDetalle1.Width = 316;
            // 
            // colUM2
            // 
            this.colUM2.AppearanceCell.Options.UseTextOptions = true;
            this.colUM2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUM2.AppearanceHeader.Options.UseTextOptions = true;
            this.colUM2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUM2.Caption = "U.M.";
            this.colUM2.FieldName = "UM";
            this.colUM2.Name = "colUM2";
            this.colUM2.Visible = true;
            this.colUM2.VisibleIndex = 1;
            this.colUM2.Width = 55;
            // 
            // tabDetallePresupuesto
            // 
            this.tabDetallePresupuesto.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabDetallePresupuesto.Appearance.Header.Options.UseFont = true;
            this.tabDetallePresupuesto.Controls.Add(this.facturasDetGridControl);
            this.tabDetallePresupuesto.Name = "tabDetallePresupuesto";
            this.tabDetallePresupuesto.Size = new System.Drawing.Size(505, 275);
            this.tabDetallePresupuesto.Text = "Detalle Presupuesto";
            // 
            // facturasDetGridControl
            // 
            this.facturasDetGridControl.DataSource = this.vDetallesFacturasPresupuestosBindingSource;
            this.facturasDetGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facturasDetGridControl.Location = new System.Drawing.Point(0, 0);
            this.facturasDetGridControl.MainView = this.gridView2;
            this.facturasDetGridControl.Name = "facturasDetGridControl";
            this.facturasDetGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminar});
            this.facturasDetGridControl.Size = new System.Drawing.Size(505, 275);
            this.facturasDetGridControl.TabIndex = 0;
            this.facturasDetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // vDetallesFacturasPresupuestosBindingSource
            // 
            this.vDetallesFacturasPresupuestosBindingSource.DataMember = "vDetallesFacturasPresupuestos";
            this.vDetallesFacturasPresupuestosBindingSource.DataSource = this.datosPresupuestos;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactDet,
            this.colIdFactCab1,
            this.colIdPresupCap,
            this.colIdPresupDet,
            this.colIdPresupSub,
            this.colUm,
            this.colCantidad,
            this.colPrecio,
            this.colDescripcion,
            this.colCapitulo,
            this.colDetalle,
            this.colSubdetalle,
            this.colTotal,
            this.Eliminar,
            this.colDescPrecio,
            this.PrecioOriginal});
            this.gridView2.GridControl = this.facturasDetGridControl;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, "({0:c2})")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCapitulo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdFactDet
            // 
            this.colIdFactDet.FieldName = "IdFactDet";
            this.colIdFactDet.Name = "colIdFactDet";
            // 
            // colIdFactCab1
            // 
            this.colIdFactCab1.FieldName = "IdFactCab";
            this.colIdFactCab1.Name = "colIdFactCab1";
            // 
            // colIdPresupCap
            // 
            this.colIdPresupCap.FieldName = "IdPresupCap";
            this.colIdPresupCap.Name = "colIdPresupCap";
            // 
            // colIdPresupDet
            // 
            this.colIdPresupDet.FieldName = "IdPresupDet";
            this.colIdPresupDet.Name = "colIdPresupDet";
            // 
            // colIdPresupSub
            // 
            this.colIdPresupSub.FieldName = "IdPresupSub";
            this.colIdPresupSub.Name = "colIdPresupSub";
            // 
            // colUm
            // 
            this.colUm.AppearanceCell.Options.UseTextOptions = true;
            this.colUm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUm.AppearanceHeader.Options.UseTextOptions = true;
            this.colUm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUm.Caption = "UM";
            this.colUm.FieldName = "Um";
            this.colUm.Name = "colUm";
            this.colUm.Visible = true;
            this.colUm.VisibleIndex = 2;
            this.colUm.Width = 52;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.DisplayFormat.FormatString = "N3";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 97;
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio.Caption = "Precio Descuento";
            this.colPrecio.DisplayFormat.FormatString = "C3";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 80;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colCapitulo
            // 
            this.colCapitulo.Caption = "Capítulo";
            this.colCapitulo.FieldName = "Capitulo";
            this.colCapitulo.Name = "colCapitulo";
            this.colCapitulo.OptionsColumn.ReadOnly = true;
            this.colCapitulo.Visible = true;
            this.colCapitulo.VisibleIndex = 0;
            this.colCapitulo.Width = 198;
            // 
            // colDetalle
            // 
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.OptionsColumn.ReadOnly = true;
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 0;
            this.colDetalle.Width = 146;
            // 
            // colSubdetalle
            // 
            this.colSubdetalle.FieldName = "Subdetalle";
            this.colSubdetalle.Name = "colSubdetalle";
            this.colSubdetalle.OptionsColumn.ReadOnly = true;
            this.colSubdetalle.Visible = true;
            this.colSubdetalle.VisibleIndex = 1;
            this.colSubdetalle.Width = 212;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 100;
            // 
            // Eliminar
            // 
            this.Eliminar.ColumnEdit = this.btnEliminar;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = true;
            this.Eliminar.VisibleIndex = 7;
            this.Eliminar.Width = 36;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            serializableAppearanceObject4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject4.Options.UseFont = true;
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Eliminar", null, null, true)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEliminar_ButtonClick);
            // 
            // colDescPrecio
            // 
            this.colDescPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescPrecio.Caption = "Desc. (%)";
            this.colDescPrecio.DisplayFormat.FormatString = "N2";
            this.colDescPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescPrecio.FieldName = "DescPrecio";
            this.colDescPrecio.Name = "colDescPrecio";
            this.colDescPrecio.Visible = true;
            this.colDescPrecio.VisibleIndex = 5;
            this.colDescPrecio.Width = 85;
            // 
            // PrecioOriginal
            // 
            this.PrecioOriginal.AppearanceHeader.Options.UseTextOptions = true;
            this.PrecioOriginal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PrecioOriginal.Caption = "Precio";
            this.PrecioOriginal.DisplayFormat.FormatString = "C3";
            this.PrecioOriginal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PrecioOriginal.FieldName = "PrecioOriginal";
            this.PrecioOriginal.Name = "PrecioOriginal";
            this.PrecioOriginal.UnboundExpression = "[Precio]/((100-Iif(IsNull([DescPrecio]), 0 ,[DescPrecio] ))/100)";
            this.PrecioOriginal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.PrecioOriginal.Visible = true;
            this.PrecioOriginal.VisibleIndex = 4;
            this.PrecioOriginal.Width = 100;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tabDetallesFactura);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.AutoScroll = true;
            this.splitContainer4.Panel2.Controls.Add(this.facturasDetGridControl1);
            this.splitContainer4.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainer4.Size = new System.Drawing.Size(851, 303);
            this.splitContainer4.SplitterDistance = 274;
            this.splitContainer4.TabIndex = 122;
            // 
            // tabDetallesFactura
            // 
            this.tabDetallesFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetallesFactura.Location = new System.Drawing.Point(0, 0);
            this.tabDetallesFactura.Name = "tabDetallesFactura";
            this.tabDetallesFactura.SelectedTabPage = this.tabFacturaDirectaCliente;
            this.tabDetallesFactura.Size = new System.Drawing.Size(851, 274);
            this.tabDetallesFactura.TabIndex = 122;
            this.tabDetallesFactura.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPresupuesto,
            this.tabFacturaDirectaCliente});
            // 
            // tabFacturaDirectaCliente
            // 
            this.tabFacturaDirectaCliente.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabFacturaDirectaCliente.Appearance.Header.Options.UseFont = true;
            this.tabFacturaDirectaCliente.Controls.Add(this.splitContainerControl1);
            this.tabFacturaDirectaCliente.Name = "tabFacturaDirectaCliente";
            this.tabFacturaDirectaCliente.Size = new System.Drawing.Size(845, 246);
            this.tabFacturaDirectaCliente.Text = "Directo Cliente";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.facturasDetDirectaGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.bindingNavigator2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.vComprasDirectasGridControl);
            this.splitContainerControl1.Panel2.Controls.Add(this.bindingNavigator3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(845, 246);
            this.splitContainerControl1.SplitterPosition = 414;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // facturasDetDirectaGridControl
            // 
            this.facturasDetDirectaGridControl.DataSource = this.vComprasDirectasBindingSourceFactura;
            this.facturasDetDirectaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facturasDetDirectaGridControl.Location = new System.Drawing.Point(0, 25);
            this.facturasDetDirectaGridControl.MainView = this.gridView4;
            this.facturasDetDirectaGridControl.Name = "facturasDetDirectaGridControl";
            this.facturasDetDirectaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btQuitarCompraDirecta});
            this.facturasDetDirectaGridControl.Size = new System.Drawing.Size(414, 221);
            this.facturasDetDirectaGridControl.TabIndex = 0;
            this.facturasDetDirectaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // vComprasDirectasBindingSourceFactura
            // 
            this.vComprasDirectasBindingSourceFactura.DataMember = "vComprasDirectas";
            this.vComprasDirectasBindingSourceFactura.DataSource = this.datosPresupuestos1;
            // 
            // datosPresupuestos1
            // 
            this.datosPresupuestos1.DataSetName = "DatosPresupuestos";
            this.datosPresupuestos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView4
            // 
            this.gridView4.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView4.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa2,
            this.colIdCompra,
            this.colIdObra2,
            this.colImpBase1,
            this.colImpIva1,
            this.colImpIRPF1,
            this.colidProveedor1,
            this.colFactura1,
            this.colFechaFactura1,
            this.colDesProveedor1,
            this.colIdFactCab4,
            this.colDelete,
            this.colFacturaDirecta1,
            this.colObraCorrecta});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Orange;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colObraCorrecta;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colFacturaDirecta1;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition2.Value1 = true;
            this.gridView4.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView4.GridControl = this.facturasDetDirectaGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowFooter = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa2
            // 
            this.colIdEmpresa2.FieldName = "IdEmpresa";
            this.colIdEmpresa2.Name = "colIdEmpresa2";
            // 
            // colIdCompra
            // 
            this.colIdCompra.FieldName = "IdCompra";
            this.colIdCompra.Name = "colIdCompra";
            // 
            // colIdObra2
            // 
            this.colIdObra2.FieldName = "IdObra";
            this.colIdObra2.Name = "colIdObra2";
            // 
            // colImpBase1
            // 
            this.colImpBase1.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpBase1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpBase1.Caption = "Imp. Base";
            this.colImpBase1.DisplayFormat.FormatString = "C2";
            this.colImpBase1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpBase1.FieldName = "ImpBase";
            this.colImpBase1.Name = "colImpBase1";
            this.colImpBase1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpBase", "{0:c2}")});
            this.colImpBase1.Visible = true;
            this.colImpBase1.VisibleIndex = 3;
            this.colImpBase1.Width = 69;
            // 
            // colImpIva1
            // 
            this.colImpIva1.FieldName = "ImpIva";
            this.colImpIva1.Name = "colImpIva1";
            // 
            // colImpIRPF1
            // 
            this.colImpIRPF1.FieldName = "ImpIRPF";
            this.colImpIRPF1.Name = "colImpIRPF1";
            // 
            // colidProveedor1
            // 
            this.colidProveedor1.FieldName = "idProveedor";
            this.colidProveedor1.Name = "colidProveedor1";
            // 
            // colFactura1
            // 
            this.colFactura1.Caption = "Factura";
            this.colFactura1.FieldName = "Factura";
            this.colFactura1.Name = "colFactura1";
            this.colFactura1.Visible = true;
            this.colFactura1.VisibleIndex = 1;
            this.colFactura1.Width = 50;
            // 
            // colFechaFactura1
            // 
            this.colFechaFactura1.Caption = "Fecha";
            this.colFechaFactura1.FieldName = "FechaFactura";
            this.colFechaFactura1.Name = "colFechaFactura1";
            this.colFechaFactura1.Visible = true;
            this.colFechaFactura1.VisibleIndex = 0;
            this.colFechaFactura1.Width = 55;
            // 
            // colDesProveedor1
            // 
            this.colDesProveedor1.Caption = "Proveedor";
            this.colDesProveedor1.FieldName = "DesProveedor";
            this.colDesProveedor1.Name = "colDesProveedor1";
            this.colDesProveedor1.Visible = true;
            this.colDesProveedor1.VisibleIndex = 2;
            this.colDesProveedor1.Width = 201;
            // 
            // colIdFactCab4
            // 
            this.colIdFactCab4.FieldName = "IdFactCab";
            this.colIdFactCab4.Name = "colIdFactCab4";
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btQuitarCompraDirecta;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 4;
            this.colDelete.Width = 21;
            // 
            // btQuitarCompraDirecta
            // 
            this.btQuitarCompraDirecta.AutoHeight = false;
            this.btQuitarCompraDirecta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Quitar Compra Directa de la Factura", null, null, true)});
            this.btQuitarCompraDirecta.Name = "btQuitarCompraDirecta";
            this.btQuitarCompraDirecta.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btQuitarCompraDirecta.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btQuitarCompraDirecta_ButtonPressed);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.facturasCabBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator6,
            this.toolStripButton10,
            this.toolStripSeparator7});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(414, 25);
            this.bindingNavigator2.TabIndex = 194;
            this.bindingNavigator2.Text = "bindingNavigator1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(178, 22);
            this.toolStripLabel3.Text = "Compras incluidas en la Factura";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Guardar datos";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // vComprasDirectasGridControl
            // 
            this.vComprasDirectasGridControl.DataSource = this.vComprasDirectasBindingSource;
            this.vComprasDirectasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vComprasDirectasGridControl.Location = new System.Drawing.Point(0, 25);
            this.vComprasDirectasGridControl.MainView = this.gridView5;
            this.vComprasDirectasGridControl.Name = "vComprasDirectasGridControl";
            this.vComprasDirectasGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.AgregarCompraDirecta});
            this.vComprasDirectasGridControl.Size = new System.Drawing.Size(426, 221);
            this.vComprasDirectasGridControl.TabIndex = 0;
            this.vComprasDirectasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // vComprasDirectasBindingSource
            // 
            this.vComprasDirectasBindingSource.DataMember = "vComprasDirectas";
            this.vComprasDirectasBindingSource.DataSource = this.datosPresupuestos;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa1,
            this.colIdCompraDirecta,
            this.colIdObra1,
            this.colImpBase,
            this.colImpIva,
            this.colImpIRPF,
            this.colidProveedor,
            this.colFacturaDirecta,
            this.colFechaFacturaDirecta,
            this.colDesProveedor,
            this.colIdFactCab3,
            this.colAgregarCompraDirecta});
            this.gridView5.GridControl = this.vComprasDirectasGridControl;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowFooter = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.OptionsColumn.ReadOnly = true;
            // 
            // colIdCompraDirecta
            // 
            this.colIdCompraDirecta.FieldName = "IdCompra";
            this.colIdCompraDirecta.Name = "colIdCompraDirecta";
            this.colIdCompraDirecta.OptionsColumn.ReadOnly = true;
            // 
            // colIdObra1
            // 
            this.colIdObra1.FieldName = "IdObra";
            this.colIdObra1.Name = "colIdObra1";
            this.colIdObra1.OptionsColumn.ReadOnly = true;
            // 
            // colImpBase
            // 
            this.colImpBase.AppearanceHeader.Options.UseTextOptions = true;
            this.colImpBase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpBase.Caption = "Imp. Base";
            this.colImpBase.DisplayFormat.FormatString = "C2";
            this.colImpBase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpBase.FieldName = "ImpBase";
            this.colImpBase.Name = "colImpBase";
            this.colImpBase.OptionsColumn.ReadOnly = true;
            this.colImpBase.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpBase", "{0:c2}")});
            this.colImpBase.Visible = true;
            this.colImpBase.VisibleIndex = 4;
            this.colImpBase.Width = 68;
            // 
            // colImpIva
            // 
            this.colImpIva.FieldName = "ImpIva";
            this.colImpIva.Name = "colImpIva";
            this.colImpIva.OptionsColumn.ReadOnly = true;
            // 
            // colImpIRPF
            // 
            this.colImpIRPF.FieldName = "ImpIRPF";
            this.colImpIRPF.Name = "colImpIRPF";
            this.colImpIRPF.OptionsColumn.ReadOnly = true;
            // 
            // colidProveedor
            // 
            this.colidProveedor.FieldName = "idProveedor";
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colFacturaDirecta
            // 
            this.colFacturaDirecta.Caption = "Factura";
            this.colFacturaDirecta.FieldName = "Factura";
            this.colFacturaDirecta.Name = "colFacturaDirecta";
            this.colFacturaDirecta.OptionsColumn.ReadOnly = true;
            this.colFacturaDirecta.Visible = true;
            this.colFacturaDirecta.VisibleIndex = 2;
            this.colFacturaDirecta.Width = 65;
            // 
            // colFechaFacturaDirecta
            // 
            this.colFechaFacturaDirecta.Caption = "Fecha";
            this.colFechaFacturaDirecta.FieldName = "FechaFactura";
            this.colFechaFacturaDirecta.Name = "colFechaFacturaDirecta";
            this.colFechaFacturaDirecta.OptionsColumn.ReadOnly = true;
            this.colFechaFacturaDirecta.Visible = true;
            this.colFechaFacturaDirecta.VisibleIndex = 1;
            this.colFechaFacturaDirecta.Width = 72;
            // 
            // colDesProveedor
            // 
            this.colDesProveedor.Caption = "Proveedor";
            this.colDesProveedor.FieldName = "DesProveedor";
            this.colDesProveedor.Name = "colDesProveedor";
            this.colDesProveedor.OptionsColumn.ReadOnly = true;
            this.colDesProveedor.Visible = true;
            this.colDesProveedor.VisibleIndex = 3;
            this.colDesProveedor.Width = 182;
            // 
            // colIdFactCab3
            // 
            this.colIdFactCab3.FieldName = "IdFactCab";
            this.colIdFactCab3.Name = "colIdFactCab3";
            this.colIdFactCab3.OptionsColumn.ReadOnly = true;
            // 
            // colAgregarCompraDirecta
            // 
            this.colAgregarCompraDirecta.ColumnEdit = this.AgregarCompraDirecta;
            this.colAgregarCompraDirecta.Name = "colAgregarCompraDirecta";
            this.colAgregarCompraDirecta.Visible = true;
            this.colAgregarCompraDirecta.VisibleIndex = 0;
            this.colAgregarCompraDirecta.Width = 21;
            // 
            // AgregarCompraDirecta
            // 
            this.AgregarCompraDirecta.AutoHeight = false;
            this.AgregarCompraDirecta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "Agregar Compra Directa a Factura", null, null, true)});
            this.AgregarCompraDirecta.Name = "AgregarCompraDirecta";
            this.AgregarCompraDirecta.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.AgregarCompraDirecta.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.AgregarCompraDirecta_ButtonPressed);
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BindingSource = this.facturasCabBindingSource;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(426, 25);
            this.bindingNavigator3.TabIndex = 195;
            this.bindingNavigator3.Text = "bindingNavigator1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(120, 22);
            this.toolStripLabel2.Text = "Compras Pendientes";
            // 
            // tabPresupuesto
            // 
            this.tabPresupuesto.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabPresupuesto.Appearance.Header.Options.UseFont = true;
            this.tabPresupuesto.Controls.Add(obsFactura2Label);
            this.tabPresupuesto.Controls.Add(this.button6);
            this.tabPresupuesto.Controls.Add(this.obsFactura2TextEdit);
            this.tabPresupuesto.Controls.Add(this.spnImporte);
            this.tabPresupuesto.Controls.Add(label20);
            this.tabPresupuesto.Controls.Add(this.groupBox2);
            this.tabPresupuesto.Controls.Add(this.txtUM);
            this.tabPresupuesto.Controls.Add(label6);
            this.tabPresupuesto.Controls.Add(importeLabel);
            this.tabPresupuesto.Controls.Add(label19);
            this.tabPresupuesto.Controls.Add(this.spnDescuento);
            this.tabPresupuesto.Controls.Add(this.uMTextEdit);
            this.tabPresupuesto.Controls.Add(this.uMTextEdit1);
            this.tabPresupuesto.Controls.Add(this.spnPrecio);
            this.tabPresupuesto.Controls.Add(this.comboBox3);
            this.tabPresupuesto.Controls.Add(label3);
            this.tabPresupuesto.Controls.Add(label27);
            this.tabPresupuesto.Controls.Add(this.spnCantidad);
            this.tabPresupuesto.Controls.Add(this.comboBox4);
            this.tabPresupuesto.Controls.Add(precioLabel);
            this.tabPresupuesto.Controls.Add(this.comboBox5);
            this.tabPresupuesto.Controls.Add(this.groupBox1);
            this.tabPresupuesto.Controls.Add(cantidadLabel);
            this.tabPresupuesto.Controls.Add(this.spnPorciento);
            this.tabPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPresupuesto.Name = "tabPresupuesto";
            this.tabPresupuesto.Size = new System.Drawing.Size(845, 246);
            this.tabPresupuesto.Text = "Presupuesto";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(77, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 23);
            this.button6.TabIndex = 96;
            this.button6.Text = "Agregar a Factura";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // obsFactura2TextEdit
            // 
            this.obsFactura2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturasCabBindingSource, "ObsFactura2", true));
            this.obsFactura2TextEdit.Location = new System.Drawing.Point(169, 245);
            this.obsFactura2TextEdit.Name = "obsFactura2TextEdit";
            this.obsFactura2TextEdit.Size = new System.Drawing.Size(664, 92);
            this.obsFactura2TextEdit.TabIndex = 1;
            // 
            // spnImporte
            // 
            this.spnImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnImporte.Location = new System.Drawing.Point(728, 163);
            this.spnImporte.Name = "spnImporte";
            this.spnImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnImporte.Properties.DisplayFormat.FormatString = "C2";
            this.spnImporte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnImporte.Properties.ReadOnly = true;
            this.spnImporte.Size = new System.Drawing.Size(100, 20);
            this.spnImporte.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPendienteDet);
            this.groupBox2.Controls.Add(this.spnPendienteDet);
            this.groupBox2.Controls.Add(cantDetFactLabel);
            this.groupBox2.Controls.Add(this.cantDetFactSpinEdit);
            this.groupBox2.Controls.Add(totalPendienteLabel);
            this.groupBox2.Controls.Add(this.totalPendienteSpinEdit);
            this.groupBox2.Controls.Add(totalFacturadoLabel);
            this.groupBox2.Controls.Add(this.totalFacturadoSpinEdit);
            this.groupBox2.Controls.Add(totalDetLabel);
            this.groupBox2.Controls.Add(this.totalDetSpinEdit);
            this.groupBox2.Controls.Add(precioLabel1);
            this.groupBox2.Controls.Add(this.precioSpinEdit);
            this.groupBox2.Controls.Add(cantExtraLabel);
            this.groupBox2.Controls.Add(this.cantExtraSpinEdit);
            this.groupBox2.Controls.Add(cantidadLabel1);
            this.groupBox2.Controls.Add(this.cantidadSpinEdit);
            this.groupBox2.Location = new System.Drawing.Point(7, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 73);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // lblPendienteDet
            // 
            this.lblPendienteDet.AutoSize = true;
            this.lblPendienteDet.Location = new System.Drawing.Point(432, 46);
            this.lblPendienteDet.Name = "lblPendienteDet";
            this.lblPendienteDet.Size = new System.Drawing.Size(58, 13);
            this.lblPendienteDet.TabIndex = 17;
            this.lblPendienteDet.Text = "Pendiente:";
            this.lblPendienteDet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // spnPendienteDet
            // 
            this.spnPendienteDet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPendienteDet.Location = new System.Drawing.Point(496, 42);
            this.spnPendienteDet.Name = "spnPendienteDet";
            this.spnPendienteDet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPendienteDet.Properties.DisplayFormat.FormatString = "N2";
            this.spnPendienteDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPendienteDet.Properties.ReadOnly = true;
            this.spnPendienteDet.Size = new System.Drawing.Size(100, 20);
            this.spnPendienteDet.TabIndex = 15;
            // 
            // cantDetFactSpinEdit
            // 
            this.cantDetFactSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "CantDetFact", true));
            this.cantDetFactSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantDetFactSpinEdit.Location = new System.Drawing.Point(70, 42);
            this.cantDetFactSpinEdit.Name = "cantDetFactSpinEdit";
            this.cantDetFactSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantDetFactSpinEdit.Properties.DisplayFormat.FormatString = "N2";
            this.cantDetFactSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantDetFactSpinEdit.Properties.ReadOnly = true;
            this.cantDetFactSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cantDetFactSpinEdit.TabIndex = 13;
            // 
            // detallesBindingSource
            // 
            this.detallesBindingSource.DataMember = "FK_PresupDet_PresupCap3";
            this.detallesBindingSource.DataSource = this.capitulosBindingSource;
            this.detallesBindingSource.PositionChanged += new System.EventHandler(this.detallesBindingSource_PositionChanged);
            // 
            // capitulosBindingSource
            // 
            this.capitulosBindingSource.DataMember = "Capitulos";
            this.capitulosBindingSource.DataSource = this.datosPresupuestos;
            this.capitulosBindingSource.PositionChanged += new System.EventHandler(this.capitulosBindingSource_PositionChanged);
            // 
            // totalPendienteSpinEdit
            // 
            this.totalPendienteSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "TotalPendiente", true));
            this.totalPendienteSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalPendienteSpinEdit.Location = new System.Drawing.Point(716, 42);
            this.totalPendienteSpinEdit.Name = "totalPendienteSpinEdit";
            this.totalPendienteSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.totalPendienteSpinEdit.Properties.DisplayFormat.FormatString = "C2";
            this.totalPendienteSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalPendienteSpinEdit.Properties.ReadOnly = true;
            this.totalPendienteSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.totalPendienteSpinEdit.TabIndex = 11;
            // 
            // totalFacturadoSpinEdit
            // 
            this.totalFacturadoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "TotalFacturado", true));
            this.totalFacturadoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalFacturadoSpinEdit.Location = new System.Drawing.Point(295, 42);
            this.totalFacturadoSpinEdit.Name = "totalFacturadoSpinEdit";
            this.totalFacturadoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.totalFacturadoSpinEdit.Properties.DisplayFormat.FormatString = "C2";
            this.totalFacturadoSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalFacturadoSpinEdit.Properties.ReadOnly = true;
            this.totalFacturadoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.totalFacturadoSpinEdit.TabIndex = 9;
            // 
            // totalDetSpinEdit
            // 
            this.totalDetSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "TotalDet", true));
            this.totalDetSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalDetSpinEdit.Location = new System.Drawing.Point(716, 15);
            this.totalDetSpinEdit.Name = "totalDetSpinEdit";
            this.totalDetSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.totalDetSpinEdit.Properties.DisplayFormat.FormatString = "C2";
            this.totalDetSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalDetSpinEdit.Properties.ReadOnly = true;
            this.totalDetSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.totalDetSpinEdit.TabIndex = 7;
            // 
            // precioSpinEdit
            // 
            this.precioSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "Precio", true));
            this.precioSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.precioSpinEdit.Location = new System.Drawing.Point(295, 15);
            this.precioSpinEdit.Name = "precioSpinEdit";
            this.precioSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.precioSpinEdit.Properties.DisplayFormat.FormatString = "C2";
            this.precioSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.precioSpinEdit.Properties.ReadOnly = true;
            this.precioSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.precioSpinEdit.TabIndex = 5;
            // 
            // cantExtraSpinEdit
            // 
            this.cantExtraSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "CantExtra", true));
            this.cantExtraSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantExtraSpinEdit.Location = new System.Drawing.Point(496, 15);
            this.cantExtraSpinEdit.Name = "cantExtraSpinEdit";
            this.cantExtraSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantExtraSpinEdit.Properties.DisplayFormat.FormatString = "N2";
            this.cantExtraSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantExtraSpinEdit.Properties.ReadOnly = true;
            this.cantExtraSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cantExtraSpinEdit.TabIndex = 3;
            // 
            // cantidadSpinEdit
            // 
            this.cantidadSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "Cantidad", true));
            this.cantidadSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantidadSpinEdit.Location = new System.Drawing.Point(71, 15);
            this.cantidadSpinEdit.Name = "cantidadSpinEdit";
            this.cantidadSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantidadSpinEdit.Properties.DisplayFormat.FormatString = "N2";
            this.cantidadSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantidadSpinEdit.Properties.ReadOnly = true;
            this.cantidadSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cantidadSpinEdit.TabIndex = 1;
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(165, 163);
            this.txtUM.Name = "txtUM";
            this.txtUM.Properties.ReadOnly = true;
            this.txtUM.Size = new System.Drawing.Size(34, 20);
            this.txtUM.TabIndex = 119;
            // 
            // spnDescuento
            // 
            this.spnDescuento.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnDescuento.EnterMoveNextControl = true;
            this.spnDescuento.Location = new System.Drawing.Point(572, 163);
            this.spnDescuento.Name = "spnDescuento";
            this.spnDescuento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnDescuento.Properties.DisplayFormat.FormatString = "N2";
            this.spnDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnDescuento.Properties.EditFormat.FormatString = "N2";
            this.spnDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnDescuento.Properties.Mask.BeepOnError = true;
            this.spnDescuento.Properties.Mask.EditMask = "f";
            this.spnDescuento.Size = new System.Drawing.Size(80, 20);
            this.spnDescuento.TabIndex = 121;
            this.spnDescuento.Validated += new System.EventHandler(this.spinEdit1_Validated);
            // 
            // uMTextEdit
            // 
            this.uMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detallesBindingSource, "UM", true));
            this.uMTextEdit.Location = new System.Drawing.Point(393, 35);
            this.uMTextEdit.Name = "uMTextEdit";
            this.uMTextEdit.Properties.ReadOnly = true;
            this.uMTextEdit.Size = new System.Drawing.Size(34, 20);
            this.uMTextEdit.TabIndex = 114;
            // 
            // uMTextEdit1
            // 
            this.uMTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "UM", true));
            this.uMTextEdit1.Location = new System.Drawing.Point(393, 57);
            this.uMTextEdit1.Name = "uMTextEdit1";
            this.uMTextEdit1.Properties.ReadOnly = true;
            this.uMTextEdit1.Size = new System.Drawing.Size(34, 20);
            this.uMTextEdit1.TabIndex = 115;
            // 
            // subdetallesBindingSource
            // 
            this.subdetallesBindingSource.DataMember = "FK_PresupSub_PresupDet3";
            this.subdetallesBindingSource.DataSource = this.detallesBindingSource;
            this.subdetallesBindingSource.PositionChanged += new System.EventHandler(this.subdetallesBindingSource_PositionChanged);
            // 
            // spnPrecio
            // 
            this.spnPrecio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPrecio.EnterMoveNextControl = true;
            this.spnPrecio.Location = new System.Drawing.Point(264, 163);
            this.spnPrecio.Name = "spnPrecio";
            this.spnPrecio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPrecio.Properties.DisplayFormat.FormatString = "C3";
            this.spnPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.EditFormat.FormatString = "C2";
            this.spnPrecio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.Mask.BeepOnError = true;
            this.spnPrecio.Properties.Mask.EditMask = "c";
            this.spnPrecio.Properties.ReadOnly = true;
            this.spnPrecio.Size = new System.Drawing.Size(80, 20);
            this.spnPrecio.TabIndex = 117;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.subdetallesBindingSource;
            this.comboBox3.DisplayMember = "Subdetalle";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(78, 56);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(309, 21);
            this.comboBox3.TabIndex = 100;
            this.comboBox3.ValueMember = "IdPresupSub";
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // spnCantidad
            // 
            this.spnCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCantidad.EnterMoveNextControl = true;
            this.spnCantidad.Location = new System.Drawing.Point(77, 163);
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnCantidad.Properties.DisplayFormat.FormatString = "N3";
            this.spnCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCantidad.Properties.EditFormat.FormatString = "N3";
            this.spnCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCantidad.Properties.Mask.BeepOnError = true;
            this.spnCantidad.Properties.Mask.EditMask = "f";
            this.spnCantidad.Size = new System.Drawing.Size(80, 20);
            this.spnCantidad.TabIndex = 116;
            this.spnCantidad.Validated += new System.EventHandler(this.spnCantidad_Validated);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.detallesBindingSource;
            this.comboBox4.DisplayMember = "Detalle";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(78, 34);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(309, 21);
            this.comboBox4.TabIndex = 98;
            this.comboBox4.ValueMember = "IdPresupDet";
            this.comboBox4.SelectedValueChanged += new System.EventHandler(this.comboBox4_SelectedValueChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.capitulosBindingSource;
            this.comboBox5.DisplayMember = "Capitulo";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(78, 12);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(309, 21);
            this.comboBox5.TabIndex = 97;
            this.comboBox5.ValueMember = "IdPresupCap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPendienteSub);
            this.groupBox1.Controls.Add(this.spnPendienteSub);
            this.groupBox1.Controls.Add(totalFacturadoLabel1);
            this.groupBox1.Controls.Add(this.totalFacturadoSpinEdit1);
            this.groupBox1.Controls.Add(cantSubFactLabel);
            this.groupBox1.Controls.Add(this.cantSubFactSpinEdit);
            this.groupBox1.Controls.Add(totalSubLabel);
            this.groupBox1.Controls.Add(this.totalSubSpinEdit);
            this.groupBox1.Controls.Add(pedienteLabel);
            this.groupBox1.Controls.Add(this.pedienteSpinEdit);
            this.groupBox1.Controls.Add(precioLabel2);
            this.groupBox1.Controls.Add(this.precioSpinEdit1);
            this.groupBox1.Controls.Add(cantExtraLabel1);
            this.groupBox1.Controls.Add(this.cantExtraSpinEdit1);
            this.groupBox1.Controls.Add(cantidadLabel2);
            this.groupBox1.Controls.Add(this.cantidadSpinEdit1);
            this.groupBox1.Location = new System.Drawing.Point(7, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 73);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // lblPendienteSub
            // 
            this.lblPendienteSub.AutoSize = true;
            this.lblPendienteSub.Location = new System.Drawing.Point(432, 46);
            this.lblPendienteSub.Name = "lblPendienteSub";
            this.lblPendienteSub.Size = new System.Drawing.Size(58, 13);
            this.lblPendienteSub.TabIndex = 18;
            this.lblPendienteSub.Text = "Pendiente:";
            this.lblPendienteSub.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // spnPendienteSub
            // 
            this.spnPendienteSub.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPendienteSub.Location = new System.Drawing.Point(496, 42);
            this.spnPendienteSub.Name = "spnPendienteSub";
            this.spnPendienteSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPendienteSub.Properties.DisplayFormat.FormatString = "N3";
            this.spnPendienteSub.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPendienteSub.Properties.ReadOnly = true;
            this.spnPendienteSub.Size = new System.Drawing.Size(100, 20);
            this.spnPendienteSub.TabIndex = 15;
            // 
            // totalFacturadoSpinEdit1
            // 
            this.totalFacturadoSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "TotalFacturado", true));
            this.totalFacturadoSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalFacturadoSpinEdit1.Location = new System.Drawing.Point(295, 42);
            this.totalFacturadoSpinEdit1.Name = "totalFacturadoSpinEdit1";
            this.totalFacturadoSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.totalFacturadoSpinEdit1.Properties.DisplayFormat.FormatString = "C2";
            this.totalFacturadoSpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalFacturadoSpinEdit1.Properties.ReadOnly = true;
            this.totalFacturadoSpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.totalFacturadoSpinEdit1.TabIndex = 13;
            // 
            // cantSubFactSpinEdit
            // 
            this.cantSubFactSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "CantSubFact", true));
            this.cantSubFactSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantSubFactSpinEdit.Location = new System.Drawing.Point(71, 42);
            this.cantSubFactSpinEdit.Name = "cantSubFactSpinEdit";
            this.cantSubFactSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantSubFactSpinEdit.Properties.DisplayFormat.FormatString = "N3";
            this.cantSubFactSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantSubFactSpinEdit.Properties.ReadOnly = true;
            this.cantSubFactSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cantSubFactSpinEdit.TabIndex = 11;
            // 
            // totalSubSpinEdit
            // 
            this.totalSubSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "TotalSub", true));
            this.totalSubSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalSubSpinEdit.Location = new System.Drawing.Point(716, 15);
            this.totalSubSpinEdit.Name = "totalSubSpinEdit";
            this.totalSubSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.totalSubSpinEdit.Properties.DisplayFormat.FormatString = "C2";
            this.totalSubSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalSubSpinEdit.Properties.ReadOnly = true;
            this.totalSubSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.totalSubSpinEdit.TabIndex = 9;
            // 
            // pedienteSpinEdit
            // 
            this.pedienteSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "Pediente", true));
            this.pedienteSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pedienteSpinEdit.Location = new System.Drawing.Point(716, 42);
            this.pedienteSpinEdit.Name = "pedienteSpinEdit";
            this.pedienteSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.pedienteSpinEdit.Properties.DisplayFormat.FormatString = "C2";
            this.pedienteSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pedienteSpinEdit.Properties.ReadOnly = true;
            this.pedienteSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.pedienteSpinEdit.TabIndex = 7;
            // 
            // precioSpinEdit1
            // 
            this.precioSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "Precio", true));
            this.precioSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.precioSpinEdit1.Location = new System.Drawing.Point(295, 15);
            this.precioSpinEdit1.Name = "precioSpinEdit1";
            this.precioSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.precioSpinEdit1.Properties.DisplayFormat.FormatString = "C3";
            this.precioSpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.precioSpinEdit1.Properties.ReadOnly = true;
            this.precioSpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.precioSpinEdit1.TabIndex = 5;
            // 
            // cantExtraSpinEdit1
            // 
            this.cantExtraSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "CantExtra", true));
            this.cantExtraSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantExtraSpinEdit1.Location = new System.Drawing.Point(496, 15);
            this.cantExtraSpinEdit1.Name = "cantExtraSpinEdit1";
            this.cantExtraSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantExtraSpinEdit1.Properties.DisplayFormat.FormatString = "N3";
            this.cantExtraSpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantExtraSpinEdit1.Properties.ReadOnly = true;
            this.cantExtraSpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.cantExtraSpinEdit1.TabIndex = 3;
            // 
            // cantidadSpinEdit1
            // 
            this.cantidadSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subdetallesBindingSource, "Cantidad", true));
            this.cantidadSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantidadSpinEdit1.Location = new System.Drawing.Point(71, 15);
            this.cantidadSpinEdit1.Name = "cantidadSpinEdit1";
            this.cantidadSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantidadSpinEdit1.Properties.DisplayFormat.FormatString = "N3";
            this.cantidadSpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantidadSpinEdit1.Properties.ReadOnly = true;
            this.cantidadSpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.cantidadSpinEdit1.TabIndex = 1;
            // 
            // spnPorciento
            // 
            this.spnPorciento.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPorciento.EnterMoveNextControl = true;
            this.spnPorciento.Location = new System.Drawing.Point(374, 163);
            this.spnPorciento.Name = "spnPorciento";
            this.spnPorciento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPorciento.Properties.DisplayFormat.FormatString = "N3";
            this.spnPorciento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPorciento.Properties.EditFormat.FormatString = "N2";
            this.spnPorciento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPorciento.Properties.Mask.BeepOnError = true;
            this.spnPorciento.Properties.Mask.EditMask = "f";
            this.spnPorciento.Size = new System.Drawing.Size(80, 20);
            this.spnPorciento.TabIndex = 118;
            this.spnPorciento.Validated += new System.EventHandler(this.spnPorciento_Validated);
            // 
            // facturasDetGridControl1
            // 
            this.facturasDetGridControl1.DataSource = this.facturasDetBindingSource;
            this.facturasDetGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facturasDetGridControl1.Location = new System.Drawing.Point(0, 25);
            this.facturasDetGridControl1.MainView = this.gridView3;
            this.facturasDetGridControl1.Name = "facturasDetGridControl1";
            this.facturasDetGridControl1.Size = new System.Drawing.Size(851, 0);
            this.facturasDetGridControl1.TabIndex = 104;
            this.facturasDetGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // facturasDetBindingSource
            // 
            this.facturasDetBindingSource.DataMember = "FK_FacturasDet_FacturasCab";
            this.facturasDetBindingSource.DataSource = this.facturasCabBindingSource;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactDet1,
            this.colIdFactCab2,
            this.colIdPresupCap1,
            this.colIdPresupDet1,
            this.colIdPresupSub1,
            this.colUm1,
            this.colCantidad1,
            this.colPrecio1,
            this.colDescripcion1,
            this.colTotal2,
            this.colDescPrecio1});
            this.gridView3.GridControl = this.facturasDetGridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFactDet1
            // 
            this.colIdFactDet1.FieldName = "IdFactDet";
            this.colIdFactDet1.Name = "colIdFactDet1";
            this.colIdFactDet1.OptionsColumn.ReadOnly = true;
            // 
            // colIdFactCab2
            // 
            this.colIdFactCab2.FieldName = "IdFactCab";
            this.colIdFactCab2.Name = "colIdFactCab2";
            // 
            // colIdPresupCap1
            // 
            this.colIdPresupCap1.FieldName = "IdPresupCap";
            this.colIdPresupCap1.Name = "colIdPresupCap1";
            // 
            // colIdPresupDet1
            // 
            this.colIdPresupDet1.FieldName = "IdPresupDet";
            this.colIdPresupDet1.Name = "colIdPresupDet1";
            // 
            // colIdPresupSub1
            // 
            this.colIdPresupSub1.FieldName = "IdPresupSub";
            this.colIdPresupSub1.Name = "colIdPresupSub1";
            // 
            // colUm1
            // 
            this.colUm1.FieldName = "Um";
            this.colUm1.Name = "colUm1";
            this.colUm1.Visible = true;
            this.colUm1.VisibleIndex = 1;
            this.colUm1.Width = 27;
            // 
            // colCantidad1
            // 
            this.colCantidad1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad1.DisplayFormat.FormatString = "N2";
            this.colCantidad1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad1.FieldName = "Cantidad";
            this.colCantidad1.Name = "colCantidad1";
            this.colCantidad1.Visible = true;
            this.colCantidad1.VisibleIndex = 2;
            this.colCantidad1.Width = 59;
            // 
            // colPrecio1
            // 
            this.colPrecio1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio1.DisplayFormat.FormatString = "C2";
            this.colPrecio1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio1.FieldName = "Precio";
            this.colPrecio1.Name = "colPrecio1";
            this.colPrecio1.Visible = true;
            this.colPrecio1.VisibleIndex = 3;
            this.colPrecio1.Width = 53;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            this.colDescripcion1.Width = 295;
            // 
            // colTotal2
            // 
            this.colTotal2.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal2.DisplayFormat.FormatString = "C2";
            this.colTotal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal2.FieldName = "Total";
            this.colTotal2.Name = "colTotal2";
            this.colTotal2.OptionsColumn.ReadOnly = true;
            this.colTotal2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")});
            this.colTotal2.Visible = true;
            this.colTotal2.VisibleIndex = 4;
            this.colTotal2.Width = 56;
            // 
            // colDescPrecio1
            // 
            this.colDescPrecio1.FieldName = "DescPrecio";
            this.colDescPrecio1.Name = "colDescPrecio1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.facturasDetBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton7,
            this.toolStripSeparator5});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(851, 25);
            this.bindingNavigator1.TabIndex = 104;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "Detalle Manual";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Save Data";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // facturasDetDirectaBindingSource
            // 
            this.facturasDetDirectaBindingSource.DataMember = "FacturasDetDirecta";
            this.facturasDetDirectaBindingSource.DataSource = this.datosPresupuestos;
            // 
            // facturasCabTableAdapter
            // 
            this.facturasCabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FacturasCabTableAdapter = this.facturasCabTableAdapter;
            this.tableAdapterManager.FacturasDetDirectaTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = this.facturasDetTableAdapter;
            this.tableAdapterManager.PresupCabTableAdapter = null;
            this.tableAdapterManager.PresupCapTableAdapter = null;
            this.tableAdapterManager.PresupDetTableAdapter = null;
            this.tableAdapterManager.PresupSubTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facturasDetTableAdapter
            // 
            this.facturasDetTableAdapter.ClearBeforeFill = true;
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
            this.toolStripSeparator1,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.toolStripButton3,
            this.toolStripSeparator3});
            this.facturasCabBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facturasCabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facturasCabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facturasCabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facturasCabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facturasCabBindingNavigator.Name = "facturasCabBindingNavigator";
            this.facturasCabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facturasCabBindingNavigator.Size = new System.Drawing.Size(1370, 25);
            this.facturasCabBindingNavigator.TabIndex = 1;
            this.facturasCabBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
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
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // facturasCabBindingNavigatorSaveItem
            // 
            this.facturasCabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturasCabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturasCabBindingNavigatorSaveItem.Image")));
            this.facturasCabBindingNavigatorSaveItem.Name = "facturasCabBindingNavigatorSaveItem";
            this.facturasCabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facturasCabBindingNavigatorSaveItem.Text = "Guardar datos";
            this.facturasCabBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturasCabBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "&Imprimir";
            this.imprimirToolStripButton.Click += new System.EventHandler(this.imprimirToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Promowork.Properties.Resources.Duplicar_32;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Hacer dos Facturas desde la Actual";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.anosFacturasBindingSource;
            this.comboBox1.DisplayMember = "AnoFactura";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(573, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "AnoFactura";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // anosFacturasBindingSource
            // 
            this.anosFacturasBindingSource.DataMember = "AnosFacturas";
            this.anosFacturasBindingSource.DataSource = this.datosPresupuestos;
            // 
            // anosFacturasTableAdapter
            // 
            this.anosFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mostrar:";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // capitulosTableAdapter
            // 
            this.capitulosTableAdapter.ClearBeforeFill = true;
            // 
            // vDetallesFacturasPresupuestosTableAdapter
            // 
            this.vDetallesFacturasPresupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // detallesTableAdapter
            // 
            this.detallesTableAdapter.ClearBeforeFill = true;
            // 
            // subdetallesTableAdapter
            // 
            this.subdetallesTableAdapter.ClearBeforeFill = true;
            // 
            // cbxfacturas
            // 
            this.cbxfacturas.FormattingEnabled = true;
            this.cbxfacturas.Items.AddRange(new object[] {
            "Facturas",
            "Partes de Trabajo"});
            this.cbxfacturas.Location = new System.Drawing.Point(435, 2);
            this.cbxfacturas.Name = "cbxfacturas";
            this.cbxfacturas.Size = new System.Drawing.Size(132, 21);
            this.cbxfacturas.TabIndex = 116;
            this.cbxfacturas.Text = "Facturas";
            this.cbxfacturas.SelectedValueChanged += new System.EventHandler(this.cbxfacturas_SelectedValueChanged);
            // 
            // facturaPresupCheckEdit
            // 
            this.facturaPresupCheckEdit.EditValue = true;
            this.facturaPresupCheckEdit.Location = new System.Drawing.Point(653, 2);
            this.facturaPresupCheckEdit.Name = "facturaPresupCheckEdit";
            this.facturaPresupCheckEdit.Properties.Caption = "Mostrar solo Facturas de Presupuestos";
            this.facturaPresupCheckEdit.Size = new System.Drawing.Size(214, 19);
            this.facturaPresupCheckEdit.TabIndex = 192;
            this.facturaPresupCheckEdit.CheckedChanged += new System.EventHandler(this.facturaPresupCheckEdit_CheckedChanged);
            this.facturaPresupCheckEdit.EnabledChanged += new System.EventHandler(this.facturaPresupCheckEdit_CheckedChanged);
            // 
            // cuentasBancosTableAdapter
            // 
            this.cuentasBancosTableAdapter.ClearBeforeFill = true;
            // 
            // presupCabTableAdapter
            // 
            this.presupCabTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagenes|*.jpg; *.bmp; *.png; *.gif; *.pdf";
            // 
            // facturaIncorrectaBindingSource
            // 
            this.facturaIncorrectaBindingSource.DataMember = "FacturaIncorrecta";
            this.facturaIncorrectaBindingSource.DataSource = this.datosPresupuestos;
            // 
            // facturaIncorrectaTableAdapter
            // 
            this.facturaIncorrectaTableAdapter.ClearBeforeFill = true;
            // 
            // chkSoloPrevisiones
            // 
            this.chkSoloPrevisiones.Location = new System.Drawing.Point(873, 2);
            this.chkSoloPrevisiones.Name = "chkSoloPrevisiones";
            this.chkSoloPrevisiones.Properties.Caption = "Mostrar solo Previsiones";
            this.chkSoloPrevisiones.Size = new System.Drawing.Size(214, 19);
            this.chkSoloPrevisiones.TabIndex = 193;
            this.chkSoloPrevisiones.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // vComprasDirectasTableAdapter
            // 
            this.vComprasDirectasTableAdapter.ClearBeforeFill = true;
            // 
            // facturasDetDirectaTableAdapter
            // 
            this.facturasDetDirectaTableAdapter.ClearBeforeFill = true;
            // 
            // vComprasDirectasTableAdapterFactura
            // 
            this.vComprasDirectasTableAdapterFactura.ClearBeforeFill = true;
            // 
            // vDetallesHorasMaterialesTableAdapter
            // 
            this.vDetallesHorasMaterialesTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // frmFacturasPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.chkSoloPrevisiones);
            this.Controls.Add(this.facturaPresupCheckEdit);
            this.Controls.Add(this.cbxfacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.facturasCabBindingNavigator);
            this.Name = "frmFacturasPresupuestos";
            this.Text = "Facturas Presupuestos";
            this.Load += new System.EventHandler(this.frmFacturasPresupuestos_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostarPresup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esCertificacionCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarObra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubTot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esPrevisionCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDetalleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsFacturaTextEdit.Properties)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabDetalleHorasMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vDetallesHorasMaterialesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetallesHorasMaterialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.tabDetallePresupuesto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetallesFacturasPresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabDetallesFactura)).EndInit();
            this.tabDetallesFactura.ResumeLayout(false);
            this.tabFacturaDirectaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetDirectaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasBindingSourceFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPresupuestos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btQuitarCompraDirecta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarCompraDirecta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.tabPresupuesto.ResumeLayout(false);
            this.tabPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obsFactura2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnImporte.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPendienteDet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantDetFactSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPendienteSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFacturadoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalDetSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantExtraSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subdetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPendienteSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFacturadoSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantSubFactSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSubSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedienteSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantExtraSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPorciento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetDirectaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabBindingNavigator)).EndInit();
            this.facturasCabBindingNavigator.ResumeLayout(false);
            this.facturasCabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaPresupCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaIncorrectaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSoloPrevisiones.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DatosPresupuestos datosPresupuestos;
        private System.Windows.Forms.BindingSource facturasCabBindingSource;
        private DatosPresupuestosTableAdapters.FacturasCabTableAdapter facturasCabTableAdapter;
        private DatosPresupuestosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facturasCabBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton facturasCabBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl facturasCabGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteFact;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieFact;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVctoFact;
        private DevExpress.XtraGrid.Columns.GridColumn colMostrarVcto;
        private DevExpress.XtraGrid.Columns.GridColumn colMostrarObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCertificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colDescPronto;
        private DevExpress.XtraGrid.Columns.GridColumn colRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colIVAFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colCobrada;
        private DevExpress.XtraGrid.Columns.GridColumn colObsFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colEntregada;
        private DevExpress.XtraGrid.Columns.GridColumn colNoDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colObsFactura2;
        private DevExpress.XtraGrid.Columns.GridColumn colEsPrevision;
        private DevExpress.XtraGrid.Columns.GridColumn colAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colMostrarSubTot;
        private DevExpress.XtraGrid.Columns.GridColumn colCargoMitadDesc;
        private DatosPresupuestosTableAdapters.FacturasDetTableAdapter facturasDetTableAdapter;
        private System.Windows.Forms.BindingSource facturasDetBindingSource;
        private DevExpress.XtraGrid.GridControl facturasDetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource anosFacturasBindingSource;
        private DatosPresupuestosTableAdapters.AnosFacturasTableAdapter anosFacturasTableAdapter;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Clientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Obras;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private DatosPresupuestosTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private DatosPresupuestosTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private System.Windows.Forms.BindingSource capitulosBindingSource;
        private DatosPresupuestosTableAdapters.CapitulosTableAdapter capitulosTableAdapter;
        private System.Windows.Forms.TextBox txtSerieFact;
        private DevExpress.XtraEditors.CheckEdit chkMostrarObra;
        private DevExpress.XtraEditors.CheckEdit chkSubTot;
        private DevExpress.XtraEditors.CheckEdit esPrevisionCheckEdit;
        private System.Windows.Forms.TextBox anticipoTextBox;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraEditors.CheckEdit noDetalleCheckEdit;
        private System.Windows.Forms.CheckBox entregadaCheckBox;
        private System.Windows.Forms.CheckBox facturaCheckBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox copiaFacturaTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox mostrarVctoCheckBox;
        private System.Windows.Forms.TextBox retencionTextBox;
        private System.Windows.Forms.TextBox descProntoTextBox;
        private System.Windows.Forms.TextBox descFacuraTextBox;
        private System.Windows.Forms.TextBox iVAFacturaTextBox;
        private System.Windows.Forms.TextBox certificacionTextBox;
        private System.Windows.Forms.ComboBox idCuentaComboBox;
        private System.Windows.Forms.DateTimePicker fechaVctoFactDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaFacturaDateTimePicker;
        private System.Windows.Forms.TextBox numFacturaTextBox;
        private System.Windows.Forms.ComboBox idPresupComboBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private DevExpress.XtraEditors.MemoEdit obsFacturaTextEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.BindingSource vDetallesFacturasPresupuestosBindingSource;
        private DatosPresupuestosTableAdapters.vDetallesFacturasPresupuestosTableAdapter vDetallesFacturasPresupuestosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCap;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupSub;
        private DevExpress.XtraGrid.Columns.GridColumn colUm;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colSubdetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource detallesBindingSource;
        private DatosPresupuestosTableAdapters.DetallesTableAdapter detallesTableAdapter;
        private System.Windows.Forms.BindingSource subdetallesBindingSource;
        private DatosPresupuestosTableAdapters.SubdetallesTableAdapter subdetallesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalBase;
        private DevExpress.XtraGrid.Columns.GridColumn ImporteIVA;
        private DevExpress.XtraGrid.Columns.GridColumn Descuentos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn Retencion;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPagar;
        private System.Windows.Forms.ComboBox cbxfacturas;
        private DevExpress.XtraEditors.CheckEdit facturaPresupCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCobrado;
        private DevExpress.XtraGrid.Columns.GridColumn Pendiente;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource;
        private DatosPresupuestosTableAdapters.CuentasBancosTableAdapter cuentasBancosTableAdapter;
        private System.Windows.Forms.BindingSource presupCabBindingSource;
        private DatosPresupuestosTableAdapters.PresupCabTableAdapter presupCabTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource facturaIncorrectaBindingSource;
        private DatosPresupuestosTableAdapters.FacturaIncorrectaTableAdapter facturaIncorrectaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SpinEdit cantDetFactSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalPendienteSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalFacturadoSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalDetSpinEdit;
        private DevExpress.XtraEditors.SpinEdit precioSpinEdit;
        private DevExpress.XtraEditors.SpinEdit cantExtraSpinEdit;
        private DevExpress.XtraEditors.SpinEdit cantidadSpinEdit;
        private DevExpress.XtraEditors.SpinEdit spnPendienteDet;
        private DevExpress.XtraEditors.TextEdit uMTextEdit;
        private DevExpress.XtraEditors.TextEdit uMTextEdit1;
        private DevExpress.XtraEditors.SpinEdit spnPendienteSub;
        private DevExpress.XtraEditors.SpinEdit totalFacturadoSpinEdit1;
        private DevExpress.XtraEditors.SpinEdit cantSubFactSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalSubSpinEdit;
        private DevExpress.XtraEditors.SpinEdit pedienteSpinEdit;
        private DevExpress.XtraEditors.SpinEdit precioSpinEdit1;
        private DevExpress.XtraEditors.SpinEdit cantExtraSpinEdit1;
        private DevExpress.XtraEditors.SpinEdit cantidadSpinEdit1;
        private System.Windows.Forms.Label lblPendienteDet;
        private System.Windows.Forms.Label lblPendienteSub;
        private DevExpress.XtraEditors.SpinEdit spnCantidad;
        private DevExpress.XtraEditors.SpinEdit spnPorciento;
        private DevExpress.XtraEditors.SpinEdit spnImporte;
        private DevExpress.XtraEditors.SpinEdit spnPrecio;
        private DevExpress.XtraEditors.TextEdit txtUM;
        private DevExpress.XtraGrid.Columns.GridColumn Eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private DatosPresupuestosTableAdapters.QueriesPresupuestos queriesPresupuestos1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioOriginal;
        private DevExpress.XtraEditors.SpinEdit spnDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colEsCertificacion;
        private DevExpress.XtraEditors.CheckEdit esCertificacionCheckEdit;
        private DevExpress.XtraEditors.CheckEdit chkSoloPrevisiones;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private DevExpress.XtraGrid.GridControl facturasDetGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactDet1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCap1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupDet1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupSub1;
        private DevExpress.XtraGrid.Columns.GridColumn colUm1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescPrecio1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraEditors.CheckEdit chkMostarPresup;
        private DevExpress.XtraEditors.MemoEdit obsFactura2TextEdit;
        private DevExpress.XtraTab.XtraTabControl tabDetallesFactura;
        private DevExpress.XtraTab.XtraTabPage tabPresupuesto;
        private DevExpress.XtraTab.XtraTabPage tabFacturaDirectaCliente;
        private System.Windows.Forms.BindingSource vComprasDirectasBindingSource;
        private DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter vComprasDirectasTableAdapter;
        private System.Windows.Forms.BindingSource facturasDetDirectaBindingSource;
        private DatosPresupuestosTableAdapters.FacturasDetDirectaTableAdapter facturasDetDirectaTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl facturasDetDirectaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl vComprasDirectasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompraDirecta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra1;
        private DevExpress.XtraGrid.Columns.GridColumn colImpBase;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIva;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIRPF;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaDirecta;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFacturaDirecta;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab3;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private DevExpress.XtraGrid.Columns.GridColumn colAgregarCompraDirecta;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AgregarCompraDirecta;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btQuitarCompraDirecta;
        private DatosPresupuestos datosPresupuestos1;
        private System.Windows.Forms.BindingSource vComprasDirectasBindingSourceFactura;
        private DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter vComprasDirectasTableAdapterFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra2;
        private DevExpress.XtraGrid.Columns.GridColumn colImpBase1;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIva1;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIRPF1;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab4;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ClienteFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaDirecta1;
        private DevExpress.XtraGrid.Columns.GridColumn colObraCorrecta;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabDetalleHorasMateriales;
        private DevExpress.XtraTab.XtraTabPage tabDetallePresupuesto;
        private System.Windows.Forms.BindingSource vDetallesHorasMaterialesBindingSource;
        private DatosPresupuestosTableAdapters.vDetallesHorasMaterialesTableAdapter vDetallesHorasMaterialesTableAdapter;
        private DevExpress.XtraGrid.GridControl vDetallesHorasMaterialesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colDirTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad2;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal3;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle1;
        private DevExpress.XtraGrid.Columns.GridColumn colUM2;
        private System.Windows.Forms.ComboBox cbObra;
        private System.Windows.Forms.BindingSource obrasBindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}