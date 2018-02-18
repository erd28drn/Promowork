namespace Promowork
{
    partial class frmAlbaranes
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
            System.Windows.Forms.Label numAlbaranLabel;
            System.Windows.Forms.Label fechaAlbaranLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label copiaAlbaranLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label consecutivoAlbaranLabel;
            System.Windows.Forms.Label idObraLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlbaranes));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colUtilizadoEn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcbxUtilizadoEn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.datosAlbaranes = new Promowork.DatosAlbaranes();
            this.albaranesCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albaranesCabTableAdapter = new Promowork.DatosAlbaranesTableAdapters.AlbaranesCabTableAdapter();
            this.tableAdapterManager = new Promowork.DatosAlbaranesTableAdapters.TableAdapterManager();
            this.albaranesDetTableAdapter = new Promowork.DatosAlbaranesTableAdapters.AlbaranesDetTableAdapter();
            this.albaranesCabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.albaranesCabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbAnos = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btRevisionAlbaranes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btSinAlbaran = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.albaranesCabGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAlbaranCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Proveedores = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNumAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsecutivoAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Obra = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFacturaRecibida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tbFacturaCompra = new DevExpress.XtraEditors.TextEdit();
            this.chkSinAlbaran = new DevExpress.XtraEditors.CheckEdit();
            this.chkFacturaRecibida = new DevExpress.XtraEditors.CheckEdit();
            this.observacionesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.chkUtilizado = new DevExpress.XtraEditors.CheckEdit();
            this.copiaAlbaranTextEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.cbxProveedores = new DevExpress.XtraEditors.LookUpEdit();
            this.txtConsecutivo = new DevExpress.XtraEditors.TextEdit();
            this.cbxObra = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNumeroAlbaran = new DevExpress.XtraEditors.TextEdit();
            this.deFechaAlbaran = new DevExpress.XtraEditors.DateEdit();
            this.chkValorado = new DevExpress.XtraEditors.CheckEdit();
            this.spnIdAlbaran = new DevExpress.XtraEditors.SpinEdit();
            this.cbxUtilizadoEn = new DevExpress.XtraEditors.LookUpEdit();
            this.observacionesProveedoresGridControl = new DevExpress.XtraGrid.GridControl();
            this.observacionesProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdObservProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidObra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observaciones = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.albaranesDetGridControl = new DevExpress.XtraGrid.GridControl();
            this.albaranesDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAlbaranDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAlbaranCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigosProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Importe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLugarUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lugares = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lugaresUsoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Trabajadores = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.trabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colObservaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UMProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.anosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new Promowork.DatosAlbaranesTableAdapters.ProveedoresTableAdapter();
            this.obrasTableAdapter = new Promowork.DatosAlbaranesTableAdapters.ObrasTableAdapter();
            this.productosTableAdapter = new Promowork.DatosAlbaranesTableAdapters.ProductosTableAdapter();
            this.anosTableAdapter = new Promowork.DatosAlbaranesTableAdapters.AnosTableAdapter();
            this.queriesAlbaranes1 = new Promowork.DatosAlbaranesTableAdapters.QueriesAlbaranes();
            this.lugaresUsoMaterialTableAdapter = new Promowork.DatosAlbaranesTableAdapters.LugaresUsoMaterialTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trabajadoresTableAdapter = new Promowork.DatosAlbaranesTableAdapters.TrabajadoresTableAdapter();
            this.observacionesProveedoresTableAdapter = new Promowork.DatosAlbaranesTableAdapters.ObservacionesProveedoresTableAdapter();
            numAlbaranLabel = new System.Windows.Forms.Label();
            fechaAlbaranLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            copiaAlbaranLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            consecutivoAlbaranLabel = new System.Windows.Forms.Label();
            idObraLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvcbxUtilizadoEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabBindingNavigator)).BeginInit();
            this.albaranesCabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbFacturaCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSinAlbaran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFacturaRecibida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUtilizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiaAlbaranTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsecutivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxObra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroAlbaran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAlbaran.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAlbaran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnIdAlbaran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUtilizadoEn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesProveedoresGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Observaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesDetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigosProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numAlbaranLabel
            // 
            numAlbaranLabel.AutoSize = true;
            numAlbaranLabel.Location = new System.Drawing.Point(30, 27);
            numAlbaranLabel.Name = "numAlbaranLabel";
            numAlbaranLabel.Size = new System.Drawing.Size(86, 13);
            numAlbaranLabel.TabIndex = 0;
            numAlbaranLabel.Text = "Número Albaran:";
            // 
            // fechaAlbaranLabel
            // 
            fechaAlbaranLabel.AutoSize = true;
            fechaAlbaranLabel.Location = new System.Drawing.Point(37, 81);
            fechaAlbaranLabel.Name = "fechaAlbaranLabel";
            fechaAlbaranLabel.Size = new System.Drawing.Size(79, 13);
            fechaAlbaranLabel.TabIndex = 2;
            fechaAlbaranLabel.Text = "Fecha Albaran:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(35, 185);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 6;
            observacionesLabel.Text = "Observaciones:";
            // 
            // copiaAlbaranLabel
            // 
            copiaAlbaranLabel.AutoSize = true;
            copiaAlbaranLabel.Location = new System.Drawing.Point(40, 159);
            copiaAlbaranLabel.Name = "copiaAlbaranLabel";
            copiaAlbaranLabel.Size = new System.Drawing.Size(76, 13);
            copiaAlbaranLabel.TabIndex = 8;
            copiaAlbaranLabel.Text = "Copia Albaran:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(57, 107);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(59, 13);
            idProveedorLabel.TabIndex = 9;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // consecutivoAlbaranLabel
            // 
            consecutivoAlbaranLabel.AutoSize = true;
            consecutivoAlbaranLabel.Location = new System.Drawing.Point(8, 53);
            consecutivoAlbaranLabel.Name = "consecutivoAlbaranLabel";
            consecutivoAlbaranLabel.Size = new System.Drawing.Size(108, 13);
            consecutivoAlbaranLabel.TabIndex = 11;
            consecutivoAlbaranLabel.Text = "Consecutivo Albaran:";
            // 
            // idObraLabel
            // 
            idObraLabel.AutoSize = true;
            idObraLabel.Location = new System.Drawing.Point(83, 132);
            idObraLabel.Name = "idObraLabel";
            idObraLabel.Size = new System.Drawing.Size(33, 13);
            idObraLabel.TabIndex = 13;
            idObraLabel.Text = "Obra:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 288);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 13);
            label1.TabIndex = 22;
            label1.Text = "Factura Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 262);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 13);
            label2.TabIndex = 23;
            label2.Text = "Utilizado En:";
            // 
            // colUtilizadoEn
            // 
            this.colUtilizadoEn.ColumnEdit = this.gvcbxUtilizadoEn;
            this.colUtilizadoEn.FieldName = "UtilizadoEn";
            this.colUtilizadoEn.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colUtilizadoEn.Name = "colUtilizadoEn";
            this.colUtilizadoEn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUtilizadoEn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colUtilizadoEn.Visible = true;
            this.colUtilizadoEn.VisibleIndex = 8;
            this.colUtilizadoEn.Width = 129;
            // 
            // gvcbxUtilizadoEn
            // 
            this.gvcbxUtilizadoEn.AutoHeight = false;
            this.gvcbxUtilizadoEn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvcbxUtilizadoEn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Utilizado en:")});
            this.gvcbxUtilizadoEn.Name = "gvcbxUtilizadoEn";
            this.gvcbxUtilizadoEn.NullText = "";
            // 
            // datosAlbaranes
            // 
            this.datosAlbaranes.DataSetName = "DatosAlbaranes";
            this.datosAlbaranes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albaranesCabBindingSource
            // 
            this.albaranesCabBindingSource.DataMember = "AlbaranesCab";
            this.albaranesCabBindingSource.DataSource = this.datosAlbaranes;
            // 
            // albaranesCabTableAdapter
            // 
            this.albaranesCabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbaranesCabTableAdapter = this.albaranesCabTableAdapter;
            this.tableAdapterManager.AlbaranesDetTableAdapter = this.albaranesDetTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConversionesUMTableAdapter = null;
            this.tableAdapterManager.LugaresUsoMaterialTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.ObservacionesProveedoresTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosAlbaranesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // albaranesDetTableAdapter
            // 
            this.albaranesDetTableAdapter.ClearBeforeFill = true;
            // 
            // albaranesCabBindingNavigator
            // 
            this.albaranesCabBindingNavigator.AddNewItem = null;
            this.albaranesCabBindingNavigator.BindingSource = this.albaranesCabBindingSource;
            this.albaranesCabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.albaranesCabBindingNavigator.DeleteItem = null;
            this.albaranesCabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.albaranesCabBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbAnos,
            this.toolStripSeparator7,
            this.btRevisionAlbaranes,
            this.toolStripSeparator9,
            this.btSinAlbaran,
            this.toolStripSeparator8,
            this.toolStripButton9});
            this.albaranesCabBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.albaranesCabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.albaranesCabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.albaranesCabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.albaranesCabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.albaranesCabBindingNavigator.Name = "albaranesCabBindingNavigator";
            this.albaranesCabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.albaranesCabBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.albaranesCabBindingNavigator.TabIndex = 0;
            this.albaranesCabBindingNavigator.Text = "bindingNavigator1";
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
            // albaranesCabBindingNavigatorSaveItem
            // 
            this.albaranesCabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.albaranesCabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("albaranesCabBindingNavigatorSaveItem.Image")));
            this.albaranesCabBindingNavigatorSaveItem.Name = "albaranesCabBindingNavigatorSaveItem";
            this.albaranesCabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.albaranesCabBindingNavigatorSaveItem.Text = "Guardar datos";
            this.albaranesCabBindingNavigatorSaveItem.Click += new System.EventHandler(this.albaranesCabBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel1.Text = "Mostrar Albaranes de: ";
            // 
            // cbAnos
            // 
            this.cbAnos.Name = "cbAnos";
            this.cbAnos.Size = new System.Drawing.Size(75, 25);
            this.cbAnos.Sorted = true;
            this.cbAnos.SelectedIndexChanged += new System.EventHandler(this.cbAnos_SelectedIndexChanged);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btRevisionAlbaranes
            // 
            this.btRevisionAlbaranes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRevisionAlbaranes.Name = "btRevisionAlbaranes";
            this.btRevisionAlbaranes.Size = new System.Drawing.Size(126, 22);
            this.btRevisionAlbaranes.Text = "Revisión de Albaranes";
            this.btRevisionAlbaranes.Click += new System.EventHandler(this.btRevisionAlbaranes_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btSinAlbaran
            // 
            this.btSinAlbaran.Image = ((System.Drawing.Image)(resources.GetObject("btSinAlbaran.Image")));
            this.btSinAlbaran.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSinAlbaran.Name = "btSinAlbaran";
            this.btSinAlbaran.Size = new System.Drawing.Size(87, 22);
            this.btSinAlbaran.Text = "Sin Albarán";
            this.btSinAlbaran.Click += new System.EventHandler(this.btSinAlbaran_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(129, 22);
            this.toolStripButton9.Text = "Prueba Fra-Albaranes";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // albaranesCabGridControl
            // 
            this.albaranesCabGridControl.DataSource = this.albaranesCabBindingSource;
            this.albaranesCabGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albaranesCabGridControl.Location = new System.Drawing.Point(0, 25);
            this.albaranesCabGridControl.MainView = this.gridView1;
            this.albaranesCabGridControl.Name = "albaranesCabGridControl";
            this.albaranesCabGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Proveedores,
            this.Obra,
            this.gvcbxUtilizadoEn});
            this.albaranesCabGridControl.Size = new System.Drawing.Size(856, 437);
            this.albaranesCabGridControl.TabIndex = 1;
            this.albaranesCabGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAlbaranCab,
            this.colIdEmpresa,
            this.colIdProveedor,
            this.colNumAlbaran,
            this.colFechaAlbaran,
            this.colValorado,
            this.colObservaciones,
            this.colCopiaAlbaran,
            this.colConsecutivoAlbaran,
            this.colIdObra,
            this.colFacturaRecibida,
            this.colSinAlbaran,
            this.colUtilizadoEn,
            this.colIdCompra,
            this.colFacturaCompra});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(762, 446, 216, 185);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colUtilizadoEn;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 1;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Green;
            styleFormatCondition2.Appearance.Options.HighPriority = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colUtilizadoEn;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = 2;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.Options.HighPriority = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colUtilizadoEn;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = 3;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gridView1.GridControl = this.albaranesCabGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAlbaranCab
            // 
            this.colIdAlbaranCab.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab.Name = "colIdAlbaranCab";
            this.colIdAlbaranCab.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "Empresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "Proveedor";
            this.colIdProveedor.ColumnEdit = this.Proveedores;
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdProveedor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 3;
            this.colIdProveedor.Width = 185;
            // 
            // Proveedores
            // 
            this.Proveedores.AutoHeight = false;
            this.Proveedores.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Proveedores.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProveedor", "Proveedor", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DNINIFProveedor", "NIF", 98, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Proveedores.DataSource = this.proveedoresBindingSource;
            this.Proveedores.DisplayMember = "DesProveedor";
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.NullText = "";
            this.Proveedores.ValueMember = "IdProveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.datosAlbaranes;
            // 
            // colNumAlbaran
            // 
            this.colNumAlbaran.Caption = "Albaran";
            this.colNumAlbaran.FieldName = "NumAlbaran";
            this.colNumAlbaran.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNumAlbaran.Name = "colNumAlbaran";
            this.colNumAlbaran.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumAlbaran.Visible = true;
            this.colNumAlbaran.VisibleIndex = 0;
            this.colNumAlbaran.Width = 103;
            // 
            // colFechaAlbaran
            // 
            this.colFechaAlbaran.Caption = "Fecha";
            this.colFechaAlbaran.FieldName = "FechaAlbaran";
            this.colFechaAlbaran.Name = "colFechaAlbaran";
            this.colFechaAlbaran.Visible = true;
            this.colFechaAlbaran.VisibleIndex = 2;
            this.colFechaAlbaran.Width = 56;
            // 
            // colValorado
            // 
            this.colValorado.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorado.Caption = "Valorado";
            this.colValorado.FieldName = "Valorado";
            this.colValorado.Name = "colValorado";
            this.colValorado.Visible = true;
            this.colValorado.VisibleIndex = 6;
            this.colValorado.Width = 45;
            // 
            // colObservaciones
            // 
            this.colObservaciones.Caption = "Observaciones";
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colObservaciones.Width = 219;
            // 
            // colCopiaAlbaran
            // 
            this.colCopiaAlbaran.Caption = "Copia";
            this.colCopiaAlbaran.FieldName = "CopiaAlbaran";
            this.colCopiaAlbaran.Name = "colCopiaAlbaran";
            this.colCopiaAlbaran.Width = 270;
            // 
            // colConsecutivoAlbaran
            // 
            this.colConsecutivoAlbaran.Caption = "Consecutivo";
            this.colConsecutivoAlbaran.FieldName = "ConsecutivoAlbaran";
            this.colConsecutivoAlbaran.Name = "colConsecutivoAlbaran";
            this.colConsecutivoAlbaran.Visible = true;
            this.colConsecutivoAlbaran.VisibleIndex = 1;
            this.colConsecutivoAlbaran.Width = 53;
            // 
            // colIdObra
            // 
            this.colIdObra.Caption = "Obra";
            this.colIdObra.ColumnEdit = this.Obra;
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdObra.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colIdObra.Visible = true;
            this.colIdObra.VisibleIndex = 4;
            this.colIdObra.Width = 185;
            // 
            // Obra
            // 
            this.Obra.AutoHeight = false;
            this.Obra.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Obra.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ObraSM", "Obra", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Obra.DataSource = this.obrasBindingSource;
            this.Obra.DisplayMember = "ObraSM";
            this.Obra.Name = "Obra";
            this.Obra.NullText = "";
            this.Obra.ValueMember = "IdObra";
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.datosAlbaranes;
            // 
            // colFacturaRecibida
            // 
            this.colFacturaRecibida.AppearanceHeader.Options.UseTextOptions = true;
            this.colFacturaRecibida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFacturaRecibida.Caption = "Factura";
            this.colFacturaRecibida.FieldName = "FacturaRecibida";
            this.colFacturaRecibida.Name = "colFacturaRecibida";
            this.colFacturaRecibida.Visible = true;
            this.colFacturaRecibida.VisibleIndex = 5;
            this.colFacturaRecibida.Width = 43;
            // 
            // colSinAlbaran
            // 
            this.colSinAlbaran.FieldName = "SinAlbaran";
            this.colSinAlbaran.Name = "colSinAlbaran";
            this.colSinAlbaran.Visible = true;
            this.colSinAlbaran.VisibleIndex = 7;
            this.colSinAlbaran.Width = 45;
            // 
            // colIdCompra
            // 
            this.colIdCompra.FieldName = "IdCompra";
            this.colIdCompra.Name = "colIdCompra";
            // 
            // colFacturaCompra
            // 
            this.colFacturaCompra.Caption = "Fra. Compra";
            this.colFacturaCompra.FieldName = "FacturaCompra";
            this.colFacturaCompra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colFacturaCompra.Name = "colFacturaCompra";
            this.colFacturaCompra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFacturaCompra.Visible = true;
            this.colFacturaCompra.VisibleIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.albaranesDetGridControl);
            this.splitContainer1.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 733);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.albaranesCabGridControl);
            this.splitContainer2.Panel1.Controls.Add(this.albaranesCabBindingNavigator);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1354, 462);
            this.splitContainer2.SplitterDistance = 856;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(label2);
            this.splitContainer3.Panel1.Controls.Add(label1);
            this.splitContainer3.Panel1.Controls.Add(this.tbFacturaCompra);
            this.splitContainer3.Panel1.Controls.Add(this.chkSinAlbaran);
            this.splitContainer3.Panel1.Controls.Add(this.chkFacturaRecibida);
            this.splitContainer3.Panel1.Controls.Add(this.observacionesTextEdit);
            this.splitContainer3.Panel1.Controls.Add(this.chkUtilizado);
            this.splitContainer3.Panel1.Controls.Add(this.copiaAlbaranTextEdit);
            this.splitContainer3.Panel1.Controls.Add(this.cbxProveedores);
            this.splitContainer3.Panel1.Controls.Add(this.txtConsecutivo);
            this.splitContainer3.Panel1.Controls.Add(this.cbxObra);
            this.splitContainer3.Panel1.Controls.Add(this.txtNumeroAlbaran);
            this.splitContainer3.Panel1.Controls.Add(idObraLabel);
            this.splitContainer3.Panel1.Controls.Add(numAlbaranLabel);
            this.splitContainer3.Panel1.Controls.Add(consecutivoAlbaranLabel);
            this.splitContainer3.Panel1.Controls.Add(this.deFechaAlbaran);
            this.splitContainer3.Panel1.Controls.Add(idProveedorLabel);
            this.splitContainer3.Panel1.Controls.Add(fechaAlbaranLabel);
            this.splitContainer3.Panel1.Controls.Add(copiaAlbaranLabel);
            this.splitContainer3.Panel1.Controls.Add(this.chkValorado);
            this.splitContainer3.Panel1.Controls.Add(observacionesLabel);
            this.splitContainer3.Panel1.Controls.Add(this.spnIdAlbaran);
            this.splitContainer3.Panel1.Controls.Add(this.cbxUtilizadoEn);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.observacionesProveedoresGridControl);
            this.splitContainer3.Size = new System.Drawing.Size(494, 462);
            this.splitContainer3.SplitterDistance = 327;
            this.splitContainer3.TabIndex = 19;
            // 
            // tbFacturaCompra
            // 
            this.tbFacturaCompra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "FacturaCompra", true));
            this.tbFacturaCompra.Location = new System.Drawing.Point(122, 284);
            this.tbFacturaCompra.Name = "tbFacturaCompra";
            this.tbFacturaCompra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbFacturaCompra.Properties.Appearance.Options.UseFont = true;
            this.tbFacturaCompra.Properties.ReadOnly = true;
            this.tbFacturaCompra.Size = new System.Drawing.Size(179, 20);
            this.tbFacturaCompra.TabIndex = 21;
            // 
            // chkSinAlbaran
            // 
            this.chkSinAlbaran.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "SinAlbaran", true));
            this.chkSinAlbaran.Location = new System.Drawing.Point(316, 25);
            this.chkSinAlbaran.Name = "chkSinAlbaran";
            this.chkSinAlbaran.Properties.Caption = "\"X\" Reclamar Albaran";
            this.chkSinAlbaran.Size = new System.Drawing.Size(163, 19);
            this.chkSinAlbaran.TabIndex = 19;
            // 
            // chkFacturaRecibida
            // 
            this.chkFacturaRecibida.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "FacturaRecibida", true));
            this.chkFacturaRecibida.Location = new System.Drawing.Point(371, 259);
            this.chkFacturaRecibida.Name = "chkFacturaRecibida";
            this.chkFacturaRecibida.Properties.Caption = "Factura Recibida";
            this.chkFacturaRecibida.Size = new System.Drawing.Size(111, 19);
            this.chkFacturaRecibida.TabIndex = 18;
            // 
            // observacionesTextEdit
            // 
            this.observacionesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "Observaciones", true));
            this.observacionesTextEdit.Location = new System.Drawing.Point(122, 182);
            this.observacionesTextEdit.Name = "observacionesTextEdit";
            this.observacionesTextEdit.Size = new System.Drawing.Size(360, 70);
            this.observacionesTextEdit.TabIndex = 5;
            // 
            // chkUtilizado
            // 
            this.chkUtilizado.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "Utilizado", true));
            this.chkUtilizado.Location = new System.Drawing.Point(31, 233);
            this.chkUtilizado.Name = "chkUtilizado";
            this.chkUtilizado.Properties.Caption = "Utilizado";
            this.chkUtilizado.Size = new System.Drawing.Size(75, 19);
            this.chkUtilizado.TabIndex = 16;
            this.chkUtilizado.Visible = false;
            // 
            // copiaAlbaranTextEdit
            // 
            this.copiaAlbaranTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "CopiaAlbaran", true));
            this.copiaAlbaranTextEdit.Location = new System.Drawing.Point(122, 156);
            this.copiaAlbaranTextEdit.Name = "copiaAlbaranTextEdit";
            this.copiaAlbaranTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.copiaAlbaranTextEdit.Size = new System.Drawing.Size(360, 20);
            this.copiaAlbaranTextEdit.TabIndex = 4;
            this.copiaAlbaranTextEdit.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.copiaAlbaranTextEdit_ButtonPressed);
            // 
            // cbxProveedores
            // 
            this.cbxProveedores.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "IdProveedor", true));
            this.cbxProveedores.Location = new System.Drawing.Point(122, 104);
            this.cbxProveedores.Name = "cbxProveedores";
            this.cbxProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxProveedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProveedor", "Proveedor", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbxProveedores.Properties.DataSource = this.proveedoresBindingSource;
            this.cbxProveedores.Properties.DisplayMember = "DesProveedor";
            this.cbxProveedores.Properties.DropDownRows = 15;
            this.cbxProveedores.Properties.ValueMember = "IdProveedor";
            this.cbxProveedores.Size = new System.Drawing.Size(357, 20);
            this.cbxProveedores.TabIndex = 2;
            this.cbxProveedores.EditValueChanged += new System.EventHandler(this.cbxProveedores_EditValueChanged);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "ConsecutivoAlbaran", true));
            this.txtConsecutivo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtConsecutivo.Location = new System.Drawing.Point(122, 50);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Properties.DisplayFormat.FormatString = "N0";
            this.txtConsecutivo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtConsecutivo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtConsecutivo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtConsecutivo.Properties.ReadOnly = true;
            this.txtConsecutivo.Size = new System.Drawing.Size(100, 20);
            this.txtConsecutivo.TabIndex = 12;
            // 
            // cbxObra
            // 
            this.cbxObra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "IdObra", true));
            this.cbxObra.Location = new System.Drawing.Point(122, 130);
            this.cbxObra.Name = "cbxObra";
            this.cbxObra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxObra.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ObraSM", "Obra", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbxObra.Properties.DataSource = this.obrasBindingSource;
            this.cbxObra.Properties.DisplayMember = "ObraSM";
            this.cbxObra.Properties.DropDownRows = 15;
            this.cbxObra.Properties.ValueMember = "IdObra";
            this.cbxObra.Size = new System.Drawing.Size(357, 20);
            this.cbxObra.TabIndex = 3;
            this.cbxObra.EditValueChanged += new System.EventHandler(this.cbxObra_EditValueChanged);
            // 
            // txtNumeroAlbaran
            // 
            this.txtNumeroAlbaran.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "NumAlbaran", true));
            this.txtNumeroAlbaran.Location = new System.Drawing.Point(122, 24);
            this.txtNumeroAlbaran.Name = "txtNumeroAlbaran";
            this.txtNumeroAlbaran.Size = new System.Drawing.Size(179, 20);
            this.txtNumeroAlbaran.TabIndex = 0;
            // 
            // deFechaAlbaran
            // 
            this.deFechaAlbaran.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "FechaAlbaran", true));
            this.deFechaAlbaran.EditValue = null;
            this.deFechaAlbaran.Location = new System.Drawing.Point(122, 78);
            this.deFechaAlbaran.Name = "deFechaAlbaran";
            this.deFechaAlbaran.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaAlbaran.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaAlbaran.Size = new System.Drawing.Size(100, 20);
            this.deFechaAlbaran.TabIndex = 1;
            // 
            // chkValorado
            // 
            this.chkValorado.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "Valorado", true));
            this.chkValorado.Location = new System.Drawing.Point(371, 285);
            this.chkValorado.Name = "chkValorado";
            this.chkValorado.Properties.Caption = "Valorado";
            this.chkValorado.Size = new System.Drawing.Size(75, 19);
            this.chkValorado.TabIndex = 6;
            this.chkValorado.CheckedChanged += new System.EventHandler(this.chkValorado_CheckedChanged);
            // 
            // spnIdAlbaran
            // 
            this.spnIdAlbaran.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "IdAlbaranCab", true));
            this.spnIdAlbaran.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnIdAlbaran.Location = new System.Drawing.Point(122, 50);
            this.spnIdAlbaran.Name = "spnIdAlbaran";
            this.spnIdAlbaran.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnIdAlbaran.Properties.NullText = "0";
            this.spnIdAlbaran.Size = new System.Drawing.Size(100, 20);
            this.spnIdAlbaran.TabIndex = 17;
            this.spnIdAlbaran.EditValueChanged += new System.EventHandler(this.spnIdAlbaran_EditValueChanged);
            // 
            // cbxUtilizadoEn
            // 
            this.cbxUtilizadoEn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.albaranesCabBindingSource, "UtilizadoEn", true));
            this.cbxUtilizadoEn.Location = new System.Drawing.Point(122, 258);
            this.cbxUtilizadoEn.Name = "cbxUtilizadoEn";
            this.cbxUtilizadoEn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxUtilizadoEn.Properties.Appearance.Options.UseFont = true;
            this.cbxUtilizadoEn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Poner en Blanco", null, null, true)});
            this.cbxUtilizadoEn.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", 80, "Utilizado en")});
            this.cbxUtilizadoEn.Properties.NullText = "";
            this.cbxUtilizadoEn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxUtilizadoEn.Size = new System.Drawing.Size(179, 20);
            this.cbxUtilizadoEn.TabIndex = 20;
            this.cbxUtilizadoEn.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxUtilizadoEn_ButtonPressed);
            // 
            // observacionesProveedoresGridControl
            // 
            this.observacionesProveedoresGridControl.DataSource = this.observacionesProveedoresBindingSource;
            this.observacionesProveedoresGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacionesProveedoresGridControl.Location = new System.Drawing.Point(0, 0);
            this.observacionesProveedoresGridControl.MainView = this.gridView3;
            this.observacionesProveedoresGridControl.Name = "observacionesProveedoresGridControl";
            this.observacionesProveedoresGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Observaciones,
            this.btnEliminar});
            this.observacionesProveedoresGridControl.Size = new System.Drawing.Size(494, 131);
            this.observacionesProveedoresGridControl.TabIndex = 18;
            this.observacionesProveedoresGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // observacionesProveedoresBindingSource
            // 
            this.observacionesProveedoresBindingSource.DataMember = "ObservacionesProveedores";
            this.observacionesProveedoresBindingSource.DataSource = this.datosAlbaranes;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdObservProv,
            this.colIdEmpresa1,
            this.colIdProveedor1,
            this.colidObra1,
            this.colObservaciones2,
            this.Eliminar});
            this.gridView3.GridControl = this.observacionesProveedoresGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsCustomization.AllowRowSizing = true;
            this.gridView3.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.RowAutoHeight = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView3_InitNewRow);
            // 
            // colIdObservProv
            // 
            this.colIdObservProv.FieldName = "IdObservProv";
            this.colIdObservProv.Name = "colIdObservProv";
            this.colIdObservProv.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdProveedor1
            // 
            this.colIdProveedor1.FieldName = "IdProveedor";
            this.colIdProveedor1.Name = "colIdProveedor1";
            // 
            // colidObra1
            // 
            this.colidObra1.FieldName = "idObra";
            this.colidObra1.Name = "colidObra1";
            // 
            // colObservaciones2
            // 
            this.colObservaciones2.Caption = "Observaciones Proveedor - Obra";
            this.colObservaciones2.ColumnEdit = this.Observaciones;
            this.colObservaciones2.FieldName = "Observaciones";
            this.colObservaciones2.Name = "colObservaciones2";
            this.colObservaciones2.Visible = true;
            this.colObservaciones2.VisibleIndex = 0;
            this.colObservaciones2.Width = 487;
            // 
            // Observaciones
            // 
            this.Observaciones.MaxLength = 1000;
            this.Observaciones.Name = "Observaciones";
            // 
            // Eliminar
            // 
            this.Eliminar.ColumnEdit = this.btnEliminar;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = true;
            this.Eliminar.VisibleIndex = 1;
            this.Eliminar.Width = 29;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEliminar.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEliminar_ButtonPressed);
            // 
            // albaranesDetGridControl
            // 
            this.albaranesDetGridControl.DataSource = this.albaranesDetBindingSource;
            this.albaranesDetGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albaranesDetGridControl.Location = new System.Drawing.Point(0, 25);
            this.albaranesDetGridControl.MainView = this.gridView2;
            this.albaranesDetGridControl.Name = "albaranesDetGridControl";
            this.albaranesDetGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DescripcionProductos,
            this.CodigosProductos,
            this.Lugares,
            this.Trabajadores,
            this.UMProductos});
            this.albaranesDetGridControl.Size = new System.Drawing.Size(1354, 242);
            this.albaranesDetGridControl.TabIndex = 0;
            this.albaranesDetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // albaranesDetBindingSource
            // 
            this.albaranesDetBindingSource.DataMember = "FK_AlbaranesDet_AlbaranesCab";
            this.albaranesDetBindingSource.DataSource = this.albaranesCabBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAlbaranDet,
            this.colIdAlbaranCab1,
            this.Codigo,
            this.colCantidad,
            this.colPrecio,
            this.Descripcion,
            this.colDescuento,
            this.Importe,
            this.colIdLugarUso,
            this.colIdTrabajador,
            this.colObservaciones1,
            this.colIdProducto});
            this.gridView2.GridControl = this.albaranesDetGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            this.gridView2.RowCountChanged += new System.EventHandler(this.gridView2_RowCountChanged);
            // 
            // colIdAlbaranDet
            // 
            this.colIdAlbaranDet.FieldName = "IdAlbaranDet";
            this.colIdAlbaranDet.Name = "colIdAlbaranDet";
            this.colIdAlbaranDet.OptionsColumn.ReadOnly = true;
            // 
            // colIdAlbaranCab1
            // 
            this.colIdAlbaranCab1.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab1.Name = "colIdAlbaranCab1";
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código Producto";
            this.Codigo.ColumnEdit = this.CodigosProductos;
            this.Codigo.FieldName = "IdProducto";
            this.Codigo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 146;
            // 
            // CodigosProductos
            // 
            this.CodigosProductos.AutoHeight = false;
            this.CodigosProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Crear Nuevo Prioducto", null, null, true)});
            this.CodigosProductos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodProductoInterno", "Código", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcioPMin", "Descripción", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PVP", "Precio", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descuento", "Descuento", 60, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductoGenerico", "Genérico")});
            this.CodigosProductos.DataSource = this.productosBindingSource;
            this.CodigosProductos.DisplayMember = "CodProductoInterno";
            this.CodigosProductos.Name = "CodigosProductos";
            this.CodigosProductos.NullText = "";
            this.CodigosProductos.ValueMember = "IdProducto";
            this.CodigosProductos.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.CodigosProductos_ButtonPressed);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.datosAlbaranes;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.DisplayFormat.FormatString = "N2";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 76;
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio.Caption = "Precio";
            this.colPrecio.DisplayFormat.FormatString = "C6";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 67;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripción Producto";
            this.Descripcion.ColumnEdit = this.DescripcionProductos;
            this.Descripcion.FieldName = "IdProducto";
            this.Descripcion.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            this.Descripcion.Width = 324;
            // 
            // DescripcionProductos
            // 
            this.DescripcionProductos.AutoHeight = false;
            this.DescripcionProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Crear Nuevo Producto", null, null, true)});
            this.DescripcionProductos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcioPMin", "Descripción", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodProductoInterno", "Código", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PVP", "Precio", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descuento", "Descuento", 60, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductoGenerico", "Genérico")});
            this.DescripcionProductos.DataSource = this.productosBindingSource;
            this.DescripcionProductos.DisplayMember = "DescripcioPMin";
            this.DescripcionProductos.Name = "DescripcionProductos";
            this.DescripcionProductos.NullText = "";
            this.DescripcionProductos.ValueMember = "IdProducto";
            this.DescripcionProductos.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.DescripcionProductos_ButtonPressed);
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuento.Caption = "Descuento (%)";
            this.colDescuento.DisplayFormat.FormatString = "N2";
            this.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 5;
            this.colDescuento.Width = 73;
            // 
            // Importe
            // 
            this.Importe.AppearanceHeader.Options.UseTextOptions = true;
            this.Importe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Importe.Caption = "Importe";
            this.Importe.DisplayFormat.FormatString = "C2";
            this.Importe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Importe.FieldName = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")});
            this.Importe.UnboundExpression = "[Cantidad]*[Precio]*Iif(IsNullOrEmpty([Descuento]),1,(1-[Descuento]/100))";
            this.Importe.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Importe.Visible = true;
            this.Importe.VisibleIndex = 6;
            this.Importe.Width = 84;
            // 
            // colIdLugarUso
            // 
            this.colIdLugarUso.Caption = "Usado en";
            this.colIdLugarUso.ColumnEdit = this.Lugares;
            this.colIdLugarUso.FieldName = "IdLugarUso";
            this.colIdLugarUso.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdLugarUso.Name = "colIdLugarUso";
            this.colIdLugarUso.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdLugarUso.Visible = true;
            this.colIdLugarUso.VisibleIndex = 7;
            this.colIdLugarUso.Width = 138;
            // 
            // Lugares
            // 
            this.Lugares.AutoHeight = false;
            this.Lugares.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Agregar Nuevo Lugar", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Eliminar", null, null, true)});
            this.Lugares.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesLugarUso", "Lugar", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Lugares.DataSource = this.lugaresUsoMaterialBindingSource;
            this.Lugares.DisplayMember = "DesLugarUso";
            this.Lugares.Name = "Lugares";
            this.Lugares.NullText = "";
            this.Lugares.ValueMember = "IdLugarUso";
            this.Lugares.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Lugares_ButtonPressed);
            // 
            // lugaresUsoMaterialBindingSource
            // 
            this.lugaresUsoMaterialBindingSource.DataMember = "LugaresUsoMaterial";
            this.lugaresUsoMaterialBindingSource.DataSource = this.datosAlbaranes;
            // 
            // colIdTrabajador
            // 
            this.colIdTrabajador.Caption = "Trabajador";
            this.colIdTrabajador.ColumnEdit = this.Trabajadores;
            this.colIdTrabajador.FieldName = "IdTrabajador";
            this.colIdTrabajador.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdTrabajador.Name = "colIdTrabajador";
            this.colIdTrabajador.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdTrabajador.Visible = true;
            this.colIdTrabajador.VisibleIndex = 8;
            this.colIdTrabajador.Width = 138;
            // 
            // Trabajadores
            // 
            this.Trabajadores.AutoHeight = false;
            this.Trabajadores.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Trabajadores.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Trabajador", "Trabajador", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Trabajadores.DataSource = this.trabajadoresBindingSource;
            this.Trabajadores.DisplayMember = "Trabajador";
            this.Trabajadores.Name = "Trabajadores";
            this.Trabajadores.NullText = "";
            this.Trabajadores.ValueMember = "IdTrabajador";
            // 
            // trabajadoresBindingSource
            // 
            this.trabajadoresBindingSource.DataMember = "Trabajadores";
            this.trabajadoresBindingSource.DataSource = this.datosAlbaranes;
            // 
            // colObservaciones1
            // 
            this.colObservaciones1.Caption = "Observaciones";
            this.colObservaciones1.FieldName = "Observaciones";
            this.colObservaciones1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colObservaciones1.Name = "colObservaciones1";
            this.colObservaciones1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colObservaciones1.Visible = true;
            this.colObservaciones1.VisibleIndex = 9;
            this.colObservaciones1.Width = 246;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "U.M";
            this.colIdProducto.ColumnEdit = this.UMProductos;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.ReadOnly = true;
            this.colIdProducto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 2;
            this.colIdProducto.Width = 44;
            // 
            // UMProductos
            // 
            this.UMProductos.AutoHeight = false;
            this.UMProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UMProductos.DataSource = this.productosBindingSource;
            this.UMProductos.DisplayMember = "UM";
            this.UMProductos.Name = "UMProductos";
            this.UMProductos.ValueMember = "IdProducto";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.albaranesDetBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel2;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton7,
            this.toolStripSeparator5,
            this.toolStripButton8,
            this.toolStripSeparator6});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1354, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "de {0}";
            this.toolStripLabel2.ToolTipText = "Número total de elementos";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover primero";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover anterior";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posición";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posición actual";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Mover siguiente";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Mover último";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Eliminar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Agregar nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Guardar datos";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Actualizar Productos";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // anosBindingSource
            // 
            this.anosBindingSource.DataMember = "Anos";
            this.anosBindingSource.DataSource = this.datosAlbaranes;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // anosTableAdapter
            // 
            this.anosTableAdapter.ClearBeforeFill = true;
            // 
            // lugaresUsoMaterialTableAdapter
            // 
            this.lugaresUsoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagenes|*.jpg; *.bmp; *.png; *.gif; *.pdf";
            // 
            // trabajadoresTableAdapter
            // 
            this.trabajadoresTableAdapter.ClearBeforeFill = true;
            // 
            // observacionesProveedoresTableAdapter
            // 
            this.observacionesProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmAlbaranes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAlbaranes";
            this.Text = "Albaranes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlbaranes_FormClosing);
            this.Load += new System.EventHandler(this.frmAlbaranes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvcbxUtilizadoEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabBindingNavigator)).EndInit();
            this.albaranesCabBindingNavigator.ResumeLayout(false);
            this.albaranesCabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesCabGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbFacturaCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSinAlbaran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFacturaRecibida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUtilizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiaAlbaranTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsecutivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxObra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroAlbaran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAlbaran.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAlbaran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnIdAlbaran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUtilizadoEn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesProveedoresGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Observaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesDetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigosProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatosAlbaranes datosAlbaranes;
        private System.Windows.Forms.BindingSource albaranesCabBindingSource;
        private DatosAlbaranesTableAdapters.AlbaranesCabTableAdapter albaranesCabTableAdapter;
        private DatosAlbaranesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator albaranesCabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton albaranesCabBindingNavigatorSaveItem;
        private DatosAlbaranesTableAdapters.AlbaranesDetTableAdapter albaranesDetTableAdapter;
        private DevExpress.XtraGrid.GridControl albaranesCabGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colValorado;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaAlbaran;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingSource albaranesDetBindingSource;
        private DevExpress.XtraGrid.GridControl albaranesDetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab1;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Proveedores;
        private DevExpress.XtraEditors.CheckEdit chkValorado;
        private DevExpress.XtraEditors.DateEdit deFechaAlbaran;
        private DevExpress.XtraEditors.TextEdit txtNumeroAlbaran;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DatosAlbaranesTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private DevExpress.XtraEditors.MemoEdit observacionesTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DescripcionProductos;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private DatosAlbaranesTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DatosAlbaranesTableAdapters.ProductosTableAdapter productosTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CodigosProductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.BindingSource anosBindingSource;
        private DatosAlbaranesTableAdapters.AnosTableAdapter anosTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private DevExpress.XtraGrid.Columns.GridColumn Importe;
        private DevExpress.XtraEditors.TextEdit txtConsecutivo;
        private DevExpress.XtraEditors.ButtonEdit copiaAlbaranTextEdit;
        private DatosAlbaranesTableAdapters.QueriesAlbaranes queriesAlbaranes1;
        private DevExpress.XtraGrid.Columns.GridColumn colConsecutivoAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Obra;
        private DevExpress.XtraEditors.LookUpEdit cbxObra;
        private DevExpress.XtraEditors.LookUpEdit cbxProveedores;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLugarUso;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Lugares;
        private System.Windows.Forms.BindingSource lugaresUsoMaterialBindingSource;
        private DatosAlbaranesTableAdapters.LugaresUsoMaterialTableAdapter lugaresUsoMaterialTableAdapter;
        private DevExpress.XtraEditors.CheckEdit chkUtilizado;
        private DevExpress.XtraEditors.SpinEdit spnIdAlbaran;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Trabajadores;
        private System.Windows.Forms.BindingSource trabajadoresBindingSource;
        private DatosAlbaranesTableAdapters.TrabajadoresTableAdapter trabajadoresTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaRecibida;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones1;
        private DevExpress.XtraEditors.CheckEdit chkFacturaRecibida;
        private System.Windows.Forms.BindingSource observacionesProveedoresBindingSource;
        private DatosAlbaranesTableAdapters.ObservacionesProveedoresTableAdapter observacionesProveedoresTableAdapter;
        private DevExpress.XtraGrid.GridControl observacionesProveedoresGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObservProv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colidObra1;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit Observaciones;
        private DevExpress.XtraGrid.Columns.GridColumn Eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private DevExpress.XtraEditors.CheckEdit chkSinAlbaran;
        private System.Windows.Forms.ToolStripComboBox cbAnos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btRevisionAlbaranes;
        private System.Windows.Forms.ToolStripButton btSinAlbaran;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private DevExpress.XtraGrid.Columns.GridColumn colSinAlbaran;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private DevExpress.XtraEditors.LookUpEdit cbxUtilizadoEn;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizadoEn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvcbxUtilizadoEn;
        private DevExpress.XtraEditors.TextEdit tbFacturaCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UMProductos;

    }
}