namespace Promowork
{
    partial class frmrptPendienteCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrptPendienteCobro));
            this.datosReportesNuevos = new Promowork.DatosReportesNuevos();
            this.facturasPendientesCobroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasPendientesCobroTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.FacturasPendientesCobroTableAdapter();
            this.tableAdapterManager = new Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager();
            this.facturasPendientesCobroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.facturasPendientesCobroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.facturasPendientesCobroGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClienteFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVctoFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNINIFCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNINIFClienteFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesClienteFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAbono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpTotalCob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.marcaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaClientesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaClientesTableAdapter();
            this.tableAdapterManager1 = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.marcaClientesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.vPendienteCobroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPendienteCobroTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.vPendienteCobroTableAdapter();
            this.vPendienteCobroGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClienteFact1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieFact1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVctoFact1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsPrevision1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNINIFCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCliente2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNINIFClienteFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesClienteFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumMatriz1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieObra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesObra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAbono1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpTotalCob1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datosReportesNuevos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasPendientesCobroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasPendientesCobroBindingNavigator)).BeginInit();
            this.facturasPendientesCobroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasPendientesCobroGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaClientesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPendienteCobroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPendienteCobroGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // datosReportesNuevos
            // 
            this.datosReportesNuevos.DataSetName = "DatosReportesNuevos";
            this.datosReportesNuevos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasPendientesCobroBindingSource
            // 
            this.facturasPendientesCobroBindingSource.DataMember = "FacturasPendientesCobro";
            this.facturasPendientesCobroBindingSource.DataSource = this.datosReportesNuevos;
            // 
            // facturasPendientesCobroTableAdapter
            // 
            this.facturasPendientesCobroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facturasPendientesCobroBindingNavigator
            // 
            this.facturasPendientesCobroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facturasPendientesCobroBindingNavigator.BindingSource = this.facturasPendientesCobroBindingSource;
            this.facturasPendientesCobroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facturasPendientesCobroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facturasPendientesCobroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.facturasPendientesCobroBindingNavigatorSaveItem});
            this.facturasPendientesCobroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facturasPendientesCobroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facturasPendientesCobroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facturasPendientesCobroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facturasPendientesCobroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facturasPendientesCobroBindingNavigator.Name = "facturasPendientesCobroBindingNavigator";
            this.facturasPendientesCobroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facturasPendientesCobroBindingNavigator.Size = new System.Drawing.Size(1522, 25);
            this.facturasPendientesCobroBindingNavigator.TabIndex = 0;
            this.facturasPendientesCobroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // facturasPendientesCobroBindingNavigatorSaveItem
            // 
            this.facturasPendientesCobroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturasPendientesCobroBindingNavigatorSaveItem.Enabled = false;
            this.facturasPendientesCobroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturasPendientesCobroBindingNavigatorSaveItem.Image")));
            this.facturasPendientesCobroBindingNavigatorSaveItem.Name = "facturasPendientesCobroBindingNavigatorSaveItem";
            this.facturasPendientesCobroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facturasPendientesCobroBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // facturasPendientesCobroGridControl
            // 
            this.facturasPendientesCobroGridControl.DataSource = this.facturasPendientesCobroBindingSource;
            this.facturasPendientesCobroGridControl.Location = new System.Drawing.Point(23, 279);
            this.facturasPendientesCobroGridControl.MainView = this.gridView1;
            this.facturasPendientesCobroGridControl.Name = "facturasPendientesCobroGridControl";
            this.facturasPendientesCobroGridControl.Size = new System.Drawing.Size(1468, 239);
            this.facturasPendientesCobroGridControl.TabIndex = 2;
            this.facturasPendientesCobroGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactCab,
            this.colIdEmpresa,
            this.colIdCliente,
            this.colIdClienteFact,
            this.colIdObra,
            this.colNumFactura,
            this.colSerieFact,
            this.colFechaFactura,
            this.colFechaVctoFact,
            this.colEsPrevision,
            this.colDNINIFCliente,
            this.colDesCliente,
            this.colDNINIFClienteFactura,
            this.colDesClienteFactura,
            this.colNumMatriz,
            this.colNumObra,
            this.colSerieObra,
            this.colDesObra,
            this.colTotalFactura,
            this.colFechaAbono,
            this.colTotalCobro,
            this.colIdFormaPago,
            this.colIdCuenta,
            this.colDesFormaPago,
            this.colBancoCuenta,
            this.colIdCobro,
            this.colImpTotalCob});
            this.gridView1.GridControl = this.facturasPendientesCobroGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colIdFactCab
            // 
            this.colIdFactCab.FieldName = "IdFactCab";
            this.colIdFactCab.Name = "colIdFactCab";
            this.colIdFactCab.OptionsColumn.ReadOnly = true;
            this.colIdFactCab.Visible = true;
            this.colIdFactCab.VisibleIndex = 0;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 1;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 2;
            // 
            // colIdClienteFact
            // 
            this.colIdClienteFact.FieldName = "IdClienteFact";
            this.colIdClienteFact.Name = "colIdClienteFact";
            this.colIdClienteFact.Visible = true;
            this.colIdClienteFact.VisibleIndex = 3;
            // 
            // colIdObra
            // 
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.Visible = true;
            this.colIdObra.VisibleIndex = 4;
            // 
            // colNumFactura
            // 
            this.colNumFactura.FieldName = "NumFactura";
            this.colNumFactura.Name = "colNumFactura";
            this.colNumFactura.Visible = true;
            this.colNumFactura.VisibleIndex = 5;
            // 
            // colSerieFact
            // 
            this.colSerieFact.FieldName = "SerieFact";
            this.colSerieFact.Name = "colSerieFact";
            this.colSerieFact.Visible = true;
            this.colSerieFact.VisibleIndex = 6;
            // 
            // colFechaFactura
            // 
            this.colFechaFactura.FieldName = "FechaFactura";
            this.colFechaFactura.Name = "colFechaFactura";
            this.colFechaFactura.Visible = true;
            this.colFechaFactura.VisibleIndex = 7;
            // 
            // colFechaVctoFact
            // 
            this.colFechaVctoFact.FieldName = "FechaVctoFact";
            this.colFechaVctoFact.Name = "colFechaVctoFact";
            this.colFechaVctoFact.Visible = true;
            this.colFechaVctoFact.VisibleIndex = 8;
            // 
            // colEsPrevision
            // 
            this.colEsPrevision.FieldName = "EsPrevision";
            this.colEsPrevision.Name = "colEsPrevision";
            this.colEsPrevision.OptionsColumn.ReadOnly = true;
            this.colEsPrevision.Visible = true;
            this.colEsPrevision.VisibleIndex = 9;
            // 
            // colDNINIFCliente
            // 
            this.colDNINIFCliente.FieldName = "DNINIFCliente";
            this.colDNINIFCliente.Name = "colDNINIFCliente";
            this.colDNINIFCliente.Visible = true;
            this.colDNINIFCliente.VisibleIndex = 10;
            // 
            // colDesCliente
            // 
            this.colDesCliente.FieldName = "DesCliente";
            this.colDesCliente.Name = "colDesCliente";
            this.colDesCliente.Visible = true;
            this.colDesCliente.VisibleIndex = 11;
            // 
            // colDNINIFClienteFactura
            // 
            this.colDNINIFClienteFactura.FieldName = "DNINIFClienteFactura";
            this.colDNINIFClienteFactura.Name = "colDNINIFClienteFactura";
            this.colDNINIFClienteFactura.Visible = true;
            this.colDNINIFClienteFactura.VisibleIndex = 12;
            // 
            // colDesClienteFactura
            // 
            this.colDesClienteFactura.FieldName = "DesClienteFactura";
            this.colDesClienteFactura.Name = "colDesClienteFactura";
            this.colDesClienteFactura.Visible = true;
            this.colDesClienteFactura.VisibleIndex = 13;
            // 
            // colNumMatriz
            // 
            this.colNumMatriz.FieldName = "NumMatriz";
            this.colNumMatriz.Name = "colNumMatriz";
            this.colNumMatriz.Visible = true;
            this.colNumMatriz.VisibleIndex = 14;
            // 
            // colNumObra
            // 
            this.colNumObra.FieldName = "NumObra";
            this.colNumObra.Name = "colNumObra";
            this.colNumObra.Visible = true;
            this.colNumObra.VisibleIndex = 15;
            // 
            // colSerieObra
            // 
            this.colSerieObra.FieldName = "SerieObra";
            this.colSerieObra.Name = "colSerieObra";
            this.colSerieObra.Visible = true;
            this.colSerieObra.VisibleIndex = 16;
            // 
            // colDesObra
            // 
            this.colDesObra.FieldName = "DesObra";
            this.colDesObra.Name = "colDesObra";
            this.colDesObra.Visible = true;
            this.colDesObra.VisibleIndex = 17;
            // 
            // colTotalFactura
            // 
            this.colTotalFactura.FieldName = "TotalFactura";
            this.colTotalFactura.Name = "colTotalFactura";
            this.colTotalFactura.OptionsColumn.ReadOnly = true;
            this.colTotalFactura.Visible = true;
            this.colTotalFactura.VisibleIndex = 18;
            // 
            // colFechaAbono
            // 
            this.colFechaAbono.FieldName = "FechaAbono";
            this.colFechaAbono.Name = "colFechaAbono";
            this.colFechaAbono.Visible = true;
            this.colFechaAbono.VisibleIndex = 19;
            // 
            // colTotalCobro
            // 
            this.colTotalCobro.FieldName = "TotalCobro";
            this.colTotalCobro.Name = "colTotalCobro";
            this.colTotalCobro.OptionsColumn.ReadOnly = true;
            this.colTotalCobro.Visible = true;
            this.colTotalCobro.VisibleIndex = 20;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.Visible = true;
            this.colIdFormaPago.VisibleIndex = 21;
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Visible = true;
            this.colIdCuenta.VisibleIndex = 22;
            // 
            // colDesFormaPago
            // 
            this.colDesFormaPago.FieldName = "DesFormaPago";
            this.colDesFormaPago.Name = "colDesFormaPago";
            this.colDesFormaPago.Visible = true;
            this.colDesFormaPago.VisibleIndex = 23;
            // 
            // colBancoCuenta
            // 
            this.colBancoCuenta.FieldName = "BancoCuenta";
            this.colBancoCuenta.Name = "colBancoCuenta";
            this.colBancoCuenta.OptionsColumn.ReadOnly = true;
            this.colBancoCuenta.Visible = true;
            this.colBancoCuenta.VisibleIndex = 24;
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.OptionsColumn.ReadOnly = true;
            this.colIdCobro.Visible = true;
            this.colIdCobro.VisibleIndex = 25;
            // 
            // colImpTotalCob
            // 
            this.colImpTotalCob.FieldName = "ImpTotalCob";
            this.colImpTotalCob.Name = "colImpTotalCob";
            this.colImpTotalCob.OptionsColumn.ReadOnly = true;
            this.colImpTotalCob.Visible = true;
            this.colImpTotalCob.VisibleIndex = 26;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaClientesBindingSource
            // 
            this.marcaClientesBindingSource.DataMember = "MarcaClientes";
            this.marcaClientesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // marcaClientesTableAdapter
            // 
            this.marcaClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccesosEmpresasTableAdapter = null;
            this.tableAdapterManager1.AdjuntosObrasTableAdapter = null;
            this.tableAdapterManager1.AnticiposTableAdapter = null;
            this.tableAdapterManager1.AnticiposTrabajadoresTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BajasMedicaTableAdapter = null;
            this.tableAdapterManager1.BancosTableAdapter = null;
            this.tableAdapterManager1.CategoriasTableAdapter = null;
            this.tableAdapterManager1.ClientesTableAdapter = null;
            this.tableAdapterManager1.CobrosTableAdapter = null;
            this.tableAdapterManager1.ComprasCabTableAdapter = null;
            this.tableAdapterManager1.ComprasDetTableAdapter = null;
            this.tableAdapterManager1.ConceptosBancosTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager1.CopiasHorasTableAdapter = null;
            this.tableAdapterManager1.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager1.CuentasTableAdapter = null;
            this.tableAdapterManager1.CursosTableAdapter = null;
            this.tableAdapterManager1.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager1.DescuentosFacturasTableAdapter = null;
            this.tableAdapterManager1.EmpresasActualTableAdapter = null;
            this.tableAdapterManager1.EmpresasTableAdapter = null;
            this.tableAdapterManager1.EstadoCivilTableAdapter = null;
            this.tableAdapterManager1.FabricantesTableAdapter = null;
            this.tableAdapterManager1.FacturasCabListaTableAdapter = null;
            this.tableAdapterManager1.FacturasCabTableAdapter = null;
            this.tableAdapterManager1.FacturasDetHorasTableAdapter = null;
            this.tableAdapterManager1.FacturasDetTableAdapter = null;
            this.tableAdapterManager1.FestivosEmpresasTableAdapter = null;
            this.tableAdapterManager1.FestivosObrasDiaTableAdapter = null;
            this.tableAdapterManager1.FestivosObrasTableAdapter = null;
            this.tableAdapterManager1.FormasPagoTableAdapter = null;
            this.tableAdapterManager1.GruposProductosTableAdapter = null;
            this.tableAdapterManager1.HijosTrabajadoresTableAdapter = null;
            this.tableAdapterManager1.HorasAdminTableAdapter = null;
            this.tableAdapterManager1.HorasTrabajadasTableAdapter = null;
            this.tableAdapterManager1.HorasTrabajadoresTableAdapter = null;
            this.tableAdapterManager1.NacionesTableAdapter = null;
            this.tableAdapterManager1.ObrasTableAdapter = null;
            this.tableAdapterManager1.OperacionesBancoTableAdapter = null;
            this.tableAdapterManager1.PagosTableAdapter = null;
            this.tableAdapterManager1.ParticipantesTableAdapter = null;
            this.tableAdapterManager1.PartObrasTableAdapter = null;
            this.tableAdapterManager1.PartPresupTableAdapter = null;
            this.tableAdapterManager1.Poblaciones1TableAdapter = null;
            this.tableAdapterManager1.PoblacionesProvincias1TableAdapter = null;
            this.tableAdapterManager1.PoblacionesProvinciasTableAdapter = null;
            this.tableAdapterManager1.PoblacionesTableAdapter = null;
            this.tableAdapterManager1.PresupCabTableAdapter = null;
            this.tableAdapterManager1.PresupCapTableAdapter = null;
            this.tableAdapterManager1.PresupDetTableAdapter = null;
            this.tableAdapterManager1.PresupSubTableAdapter = null;
            this.tableAdapterManager1.ProductosTableAdapter = null;
            this.tableAdapterManager1.ProductosUtilizadosTableAdapter = null;
            this.tableAdapterManager1.ProductosUtTrabajadoresTableAdapter = null;
            this.tableAdapterManager1.ProveedoresTableAdapter = null;
            this.tableAdapterManager1.Provincias1TableAdapter = null;
            this.tableAdapterManager1.ProvinciasTableAdapter = null;
            this.tableAdapterManager1.PuestosTrabajoTableAdapter = null;
            this.tableAdapterManager1.SalariosTiposTableAdapter = null;
            this.tableAdapterManager1.SalariosVentaAdminTableAdapter = null;
            this.tableAdapterManager1.SalariosVentaTableAdapter = null;
            this.tableAdapterManager1.SeguridadSocialTableAdapter = null;
            this.tableAdapterManager1.TiposProductosTableAdapter = null;
            this.tableAdapterManager1.TiposProveedoresTableAdapter = null;
            this.tableAdapterManager1.TiposTableAdapter = null;
            this.tableAdapterManager1.TrabajadoresListaTableAdapter = null;
            this.tableAdapterManager1.TrabajadoresTableAdapter = null;
            this.tableAdapterManager1.UMedidasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuariosTableAdapter = null;
            // 
            // marcaClientesGridControl
            // 
            this.marcaClientesGridControl.DataSource = this.marcaClientesBindingSource;
            this.marcaClientesGridControl.Location = new System.Drawing.Point(37, 53);
            this.marcaClientesGridControl.MainView = this.gridView2;
            this.marcaClientesGridControl.Name = "marcaClientesGridControl";
            this.marcaClientesGridControl.Size = new System.Drawing.Size(672, 220);
            this.marcaClientesGridControl.TabIndex = 3;
            this.marcaClientesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarca,
            this.colIdEmpresa1,
            this.colIdCliente1,
            this.colNumCliente,
            this.colDesCliente1});
            this.gridView2.GridControl = this.marcaClientesGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 0;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa1.Visible = true;
            this.colIdEmpresa1.VisibleIndex = 1;
            // 
            // colIdCliente1
            // 
            this.colIdCliente1.FieldName = "IdCliente";
            this.colIdCliente1.Name = "colIdCliente1";
            this.colIdCliente1.OptionsColumn.ReadOnly = true;
            this.colIdCliente1.Visible = true;
            this.colIdCliente1.VisibleIndex = 2;
            // 
            // colNumCliente
            // 
            this.colNumCliente.FieldName = "NumCliente";
            this.colNumCliente.Name = "colNumCliente";
            this.colNumCliente.OptionsColumn.ReadOnly = true;
            this.colNumCliente.Visible = true;
            this.colNumCliente.VisibleIndex = 3;
            // 
            // colDesCliente1
            // 
            this.colDesCliente1.FieldName = "DesCliente";
            this.colDesCliente1.Name = "colDesCliente1";
            this.colDesCliente1.OptionsColumn.ReadOnly = true;
            this.colDesCliente1.Visible = true;
            this.colDesCliente1.VisibleIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vPendienteCobroBindingSource
            // 
            this.vPendienteCobroBindingSource.DataMember = "vPendienteCobro";
            this.vPendienteCobroBindingSource.DataSource = this.datosReportesNuevos;
            // 
            // vPendienteCobroTableAdapter
            // 
            this.vPendienteCobroTableAdapter.ClearBeforeFill = true;
            // 
            // vPendienteCobroGridControl
            // 
            this.vPendienteCobroGridControl.DataSource = this.vPendienteCobroBindingSource;
            this.vPendienteCobroGridControl.Location = new System.Drawing.Point(23, 539);
            this.vPendienteCobroGridControl.MainView = this.gridView3;
            this.vPendienteCobroGridControl.Name = "vPendienteCobroGridControl";
            this.vPendienteCobroGridControl.Size = new System.Drawing.Size(1468, 220);
            this.vPendienteCobroGridControl.TabIndex = 5;
            this.vPendienteCobroGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactCab1,
            this.colIdEmpresa2,
            this.colIdCliente2,
            this.colIdClienteFact1,
            this.colIdObra1,
            this.colNumFactura1,
            this.colSerieFact1,
            this.colFechaFactura1,
            this.colFechaVctoFact1,
            this.colEsPrevision1,
            this.colDNINIFCliente1,
            this.colDesCliente2,
            this.colDNINIFClienteFactura1,
            this.colDesClienteFactura1,
            this.colNumMatriz1,
            this.colNumObra1,
            this.colSerieObra1,
            this.colDesObra1,
            this.colTotalFactura1,
            this.colFechaAbono1,
            this.colTotalCobro1,
            this.colIdFormaPago1,
            this.colIdCuenta1,
            this.colDesFormaPago1,
            this.colBancoCuenta1,
            this.colIdCobro1,
            this.colImpTotalCob1});
            this.gridView3.GridControl = this.vPendienteCobroGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // colIdFactCab1
            // 
            this.colIdFactCab1.FieldName = "IdFactCab";
            this.colIdFactCab1.Name = "colIdFactCab1";
            this.colIdFactCab1.Visible = true;
            this.colIdFactCab1.VisibleIndex = 0;
            // 
            // colIdEmpresa2
            // 
            this.colIdEmpresa2.FieldName = "IdEmpresa";
            this.colIdEmpresa2.Name = "colIdEmpresa2";
            this.colIdEmpresa2.Visible = true;
            this.colIdEmpresa2.VisibleIndex = 1;
            // 
            // colIdCliente2
            // 
            this.colIdCliente2.FieldName = "IdCliente";
            this.colIdCliente2.Name = "colIdCliente2";
            this.colIdCliente2.Visible = true;
            this.colIdCliente2.VisibleIndex = 2;
            // 
            // colIdClienteFact1
            // 
            this.colIdClienteFact1.FieldName = "IdClienteFact";
            this.colIdClienteFact1.Name = "colIdClienteFact1";
            this.colIdClienteFact1.Visible = true;
            this.colIdClienteFact1.VisibleIndex = 3;
            // 
            // colIdObra1
            // 
            this.colIdObra1.FieldName = "IdObra";
            this.colIdObra1.Name = "colIdObra1";
            this.colIdObra1.Visible = true;
            this.colIdObra1.VisibleIndex = 4;
            // 
            // colNumFactura1
            // 
            this.colNumFactura1.FieldName = "NumFactura";
            this.colNumFactura1.Name = "colNumFactura1";
            this.colNumFactura1.Visible = true;
            this.colNumFactura1.VisibleIndex = 5;
            // 
            // colSerieFact1
            // 
            this.colSerieFact1.FieldName = "SerieFact";
            this.colSerieFact1.Name = "colSerieFact1";
            this.colSerieFact1.Visible = true;
            this.colSerieFact1.VisibleIndex = 6;
            // 
            // colFechaFactura1
            // 
            this.colFechaFactura1.FieldName = "FechaFactura";
            this.colFechaFactura1.Name = "colFechaFactura1";
            this.colFechaFactura1.Visible = true;
            this.colFechaFactura1.VisibleIndex = 7;
            // 
            // colFechaVctoFact1
            // 
            this.colFechaVctoFact1.FieldName = "FechaVctoFact";
            this.colFechaVctoFact1.Name = "colFechaVctoFact1";
            this.colFechaVctoFact1.Visible = true;
            this.colFechaVctoFact1.VisibleIndex = 8;
            // 
            // colEsPrevision1
            // 
            this.colEsPrevision1.FieldName = "EsPrevision";
            this.colEsPrevision1.Name = "colEsPrevision1";
            this.colEsPrevision1.OptionsColumn.ReadOnly = true;
            this.colEsPrevision1.Visible = true;
            this.colEsPrevision1.VisibleIndex = 9;
            // 
            // colDNINIFCliente1
            // 
            this.colDNINIFCliente1.FieldName = "DNINIFCliente";
            this.colDNINIFCliente1.Name = "colDNINIFCliente1";
            this.colDNINIFCliente1.Visible = true;
            this.colDNINIFCliente1.VisibleIndex = 10;
            // 
            // colDesCliente2
            // 
            this.colDesCliente2.FieldName = "DesCliente";
            this.colDesCliente2.Name = "colDesCliente2";
            this.colDesCliente2.Visible = true;
            this.colDesCliente2.VisibleIndex = 11;
            // 
            // colDNINIFClienteFactura1
            // 
            this.colDNINIFClienteFactura1.FieldName = "DNINIFClienteFactura";
            this.colDNINIFClienteFactura1.Name = "colDNINIFClienteFactura1";
            this.colDNINIFClienteFactura1.Visible = true;
            this.colDNINIFClienteFactura1.VisibleIndex = 12;
            // 
            // colDesClienteFactura1
            // 
            this.colDesClienteFactura1.FieldName = "DesClienteFactura";
            this.colDesClienteFactura1.Name = "colDesClienteFactura1";
            this.colDesClienteFactura1.Visible = true;
            this.colDesClienteFactura1.VisibleIndex = 13;
            // 
            // colNumMatriz1
            // 
            this.colNumMatriz1.FieldName = "NumMatriz";
            this.colNumMatriz1.Name = "colNumMatriz1";
            this.colNumMatriz1.Visible = true;
            this.colNumMatriz1.VisibleIndex = 14;
            // 
            // colNumObra1
            // 
            this.colNumObra1.FieldName = "NumObra";
            this.colNumObra1.Name = "colNumObra1";
            this.colNumObra1.Visible = true;
            this.colNumObra1.VisibleIndex = 15;
            // 
            // colSerieObra1
            // 
            this.colSerieObra1.FieldName = "SerieObra";
            this.colSerieObra1.Name = "colSerieObra1";
            this.colSerieObra1.Visible = true;
            this.colSerieObra1.VisibleIndex = 16;
            // 
            // colDesObra1
            // 
            this.colDesObra1.FieldName = "DesObra";
            this.colDesObra1.Name = "colDesObra1";
            this.colDesObra1.Visible = true;
            this.colDesObra1.VisibleIndex = 17;
            // 
            // colTotalFactura1
            // 
            this.colTotalFactura1.FieldName = "TotalFactura";
            this.colTotalFactura1.Name = "colTotalFactura1";
            this.colTotalFactura1.OptionsColumn.ReadOnly = true;
            this.colTotalFactura1.Visible = true;
            this.colTotalFactura1.VisibleIndex = 18;
            // 
            // colFechaAbono1
            // 
            this.colFechaAbono1.FieldName = "FechaAbono";
            this.colFechaAbono1.Name = "colFechaAbono1";
            this.colFechaAbono1.Visible = true;
            this.colFechaAbono1.VisibleIndex = 19;
            // 
            // colTotalCobro1
            // 
            this.colTotalCobro1.FieldName = "TotalCobro";
            this.colTotalCobro1.Name = "colTotalCobro1";
            this.colTotalCobro1.OptionsColumn.ReadOnly = true;
            this.colTotalCobro1.Visible = true;
            this.colTotalCobro1.VisibleIndex = 20;
            // 
            // colIdFormaPago1
            // 
            this.colIdFormaPago1.FieldName = "IdFormaPago";
            this.colIdFormaPago1.Name = "colIdFormaPago1";
            this.colIdFormaPago1.Visible = true;
            this.colIdFormaPago1.VisibleIndex = 21;
            // 
            // colIdCuenta1
            // 
            this.colIdCuenta1.FieldName = "IdCuenta";
            this.colIdCuenta1.Name = "colIdCuenta1";
            this.colIdCuenta1.Visible = true;
            this.colIdCuenta1.VisibleIndex = 22;
            // 
            // colDesFormaPago1
            // 
            this.colDesFormaPago1.FieldName = "DesFormaPago";
            this.colDesFormaPago1.Name = "colDesFormaPago1";
            this.colDesFormaPago1.Visible = true;
            this.colDesFormaPago1.VisibleIndex = 23;
            // 
            // colBancoCuenta1
            // 
            this.colBancoCuenta1.FieldName = "BancoCuenta";
            this.colBancoCuenta1.Name = "colBancoCuenta1";
            this.colBancoCuenta1.OptionsColumn.ReadOnly = true;
            this.colBancoCuenta1.Visible = true;
            this.colBancoCuenta1.VisibleIndex = 24;
            // 
            // colIdCobro1
            // 
            this.colIdCobro1.FieldName = "IdCobro";
            this.colIdCobro1.Name = "colIdCobro1";
            this.colIdCobro1.Visible = true;
            this.colIdCobro1.VisibleIndex = 25;
            // 
            // colImpTotalCob1
            // 
            this.colImpTotalCob1.FieldName = "ImpTotalCob";
            this.colImpTotalCob1.Name = "colImpTotalCob1";
            this.colImpTotalCob1.OptionsColumn.ReadOnly = true;
            this.colImpTotalCob1.Visible = true;
            this.colImpTotalCob1.VisibleIndex = 26;
            // 
            // frmrptPendienteCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 806);
            this.Controls.Add(this.vPendienteCobroGridControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.marcaClientesGridControl);
            this.Controls.Add(this.facturasPendientesCobroGridControl);
            this.Controls.Add(this.facturasPendientesCobroBindingNavigator);
            this.Name = "frmrptPendienteCobro";
            this.Text = "frmrptPendienteCobro";
            this.Load += new System.EventHandler(this.frmrptPendienteCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosReportesNuevos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasPendientesCobroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasPendientesCobroBindingNavigator)).EndInit();
            this.facturasPendientesCobroBindingNavigator.ResumeLayout(false);
            this.facturasPendientesCobroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasPendientesCobroGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaClientesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPendienteCobroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPendienteCobroGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatosReportesNuevos datosReportesNuevos;
        private System.Windows.Forms.BindingSource facturasPendientesCobroBindingSource;
        private DatosReportesNuevosTableAdapters.FacturasPendientesCobroTableAdapter facturasPendientesCobroTableAdapter;
        private DatosReportesNuevosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facturasPendientesCobroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton facturasPendientesCobroBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl facturasPendientesCobroGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteFact;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieFact;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVctoFact;
        private DevExpress.XtraGrid.Columns.GridColumn colEsPrevision;
        private DevExpress.XtraGrid.Columns.GridColumn colDNINIFCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDNINIFClienteFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colDesClienteFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObra;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieObra;
        private DevExpress.XtraGrid.Columns.GridColumn colDesObra;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAbono;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colDesFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colImpTotalCob;
        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource marcaClientesBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaClientesTableAdapter marcaClientesTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl marcaClientesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCliente1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vPendienteCobroBindingSource;
        private DatosReportesNuevosTableAdapters.vPendienteCobroTableAdapter vPendienteCobroTableAdapter;
        private DevExpress.XtraGrid.GridControl vPendienteCobroGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteFact1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieFact1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVctoFact1;
        private DevExpress.XtraGrid.Columns.GridColumn colEsPrevision1;
        private DevExpress.XtraGrid.Columns.GridColumn colDNINIFCliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCliente2;
        private DevExpress.XtraGrid.Columns.GridColumn colDNINIFClienteFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesClienteFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMatriz1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObra1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieObra1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesObra1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAbono1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoCuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colImpTotalCob1;

    }
}