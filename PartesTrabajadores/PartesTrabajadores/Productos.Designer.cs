namespace PartesTrabajadores
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.promowork_dataDataSet = new PartesTrabajadores.Promowork_dataDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new PartesTrabajadores.Promowork_dataDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new PartesTrabajadores.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.productosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.productosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.uMedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPVP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorciento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proveedores = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFechaCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uMedidasTableAdapter = new PartesTrabajadores.Promowork_dataDataSetTableAdapters.UMedidasTableAdapter();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new PartesTrabajadores.Promowork_dataDataSetTableAdapters.ProveedoresTableAdapter();
            this.colFechaUtilizado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingNavigator)).BeginInit();
            this.productosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.FabricantesTableAdapter = null;
            this.tableAdapterManager.FestivosObrasDiaTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.GruposProductosTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadoresTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProductosUtTrabajadoresTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PartesTrabajadores.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productosBindingNavigator
            // 
            this.productosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productosBindingNavigator.BindingSource = this.productosBindingSource;
            this.productosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productosBindingNavigator.DeleteItem = null;
            this.productosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productosBindingNavigatorSaveItem});
            this.productosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productosBindingNavigator.Name = "productosBindingNavigator";
            this.productosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productosBindingNavigator.Size = new System.Drawing.Size(1276, 25);
            this.productosBindingNavigator.TabIndex = 0;
            this.productosBindingNavigator.Text = "bindingNavigator1";
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
            // productosBindingNavigatorSaveItem
            // 
            this.productosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productosBindingNavigatorSaveItem.Image")));
            this.productosBindingNavigatorSaveItem.Name = "productosBindingNavigatorSaveItem";
            this.productosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productosBindingNavigatorSaveItem.Text = "Save Data";
            this.productosBindingNavigatorSaveItem.Click += new System.EventHandler(this.productosBindingNavigatorSaveItem_Click);
            // 
            // productosGridControl
            // 
            this.productosGridControl.DataSource = this.productosBindingSource;
            this.productosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosGridControl.Location = new System.Drawing.Point(0, 25);
            this.productosGridControl.MainView = this.gridView1;
            this.productosGridControl.Name = "productosGridControl";
            this.productosGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UM,
            this.proveedores});
            this.productosGridControl.Size = new System.Drawing.Size(1276, 688);
            this.productosGridControl.TabIndex = 2;
            this.productosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.IdEmpresa,
            this.colCodProducto,
            this.colDesProducto,
            this.colIdUMedida,
            this.colPVP,
            this.colDescuento,
            this.colPorciento,
            this.PC,
            this.PV,
            this.colProducto,
            this.colIdProveedor,
            this.colFechaCrea,
            this.colFechaModif,
            this.colFechaUtilizado});
            this.gridView1.GridControl = this.productosGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Id Producto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.FieldNameSortGroup = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.ReadOnly = true;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Caption = "Empresa";
            this.IdEmpresa.FieldName = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            // 
            // colCodProducto
            // 
            this.colCodProducto.Caption = "Código";
            this.colCodProducto.FieldName = "CodProducto";
            this.colCodProducto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colCodProducto.Name = "colCodProducto";
            this.colCodProducto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCodProducto.Visible = true;
            this.colCodProducto.VisibleIndex = 1;
            this.colCodProducto.Width = 137;
            // 
            // colDesProducto
            // 
            this.colDesProducto.Caption = "Descripción";
            this.colDesProducto.FieldName = "DesProducto";
            this.colDesProducto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesProducto.Name = "colDesProducto";
            this.colDesProducto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesProducto.Visible = true;
            this.colDesProducto.VisibleIndex = 2;
            this.colDesProducto.Width = 452;
            // 
            // colIdUMedida
            // 
            this.colIdUMedida.Caption = "UM";
            this.colIdUMedida.ColumnEdit = this.UM;
            this.colIdUMedida.FieldName = "IdUMedida";
            this.colIdUMedida.Name = "colIdUMedida";
            this.colIdUMedida.Visible = true;
            this.colIdUMedida.VisibleIndex = 3;
            this.colIdUMedida.Width = 54;
            // 
            // UM
            // 
            this.UM.AutoHeight = false;
            this.UM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UM.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodUmedida", "Código", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesUmedida", "Descripción", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UM.DataSource = this.uMedidasBindingSource;
            this.UM.DisplayMember = "CodUmedida";
            this.UM.Name = "UM";
            this.UM.NullText = "";
            this.UM.ValueMember = "IdUmedida";
            // 
            // uMedidasBindingSource
            // 
            this.uMedidasBindingSource.DataMember = "UMedidas";
            this.uMedidasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colPVP
            // 
            this.colPVP.AppearanceHeader.Options.UseTextOptions = true;
            this.colPVP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPVP.Caption = "PVP";
            this.colPVP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPVP.FieldName = "PVP";
            this.colPVP.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPVP.Name = "colPVP";
            this.colPVP.Visible = true;
            this.colPVP.VisibleIndex = 4;
            this.colPVP.Width = 81;
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuento.Caption = "Descuento (%)";
            this.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 5;
            this.colDescuento.Width = 84;
            // 
            // colPorciento
            // 
            this.colPorciento.AppearanceHeader.Options.UseTextOptions = true;
            this.colPorciento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPorciento.Caption = "Porciento (%)";
            this.colPorciento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPorciento.FieldName = "Porciento";
            this.colPorciento.Name = "colPorciento";
            this.colPorciento.Width = 84;
            // 
            // PC
            // 
            this.PC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PC.AppearanceCell.Options.UseBackColor = true;
            this.PC.AppearanceCell.Options.UseTextOptions = true;
            this.PC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PC.AppearanceHeader.Options.UseTextOptions = true;
            this.PC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PC.Caption = "Precio Compra";
            this.PC.DisplayFormat.FormatString = "N4";
            this.PC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PC.FieldName = "PC";
            this.PC.Name = "PC";
            this.PC.OptionsColumn.ReadOnly = true;
            this.PC.Width = 84;
            // 
            // PV
            // 
            this.PV.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PV.AppearanceCell.Options.UseBackColor = true;
            this.PV.AppearanceCell.Options.UseTextOptions = true;
            this.PV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PV.AppearanceHeader.Options.UseTextOptions = true;
            this.PV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PV.Caption = "Precio Venta";
            this.PV.DisplayFormat.FormatString = "N4";
            this.PV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PV.FieldName = "PV";
            this.PV.Name = "PV";
            this.PV.OptionsColumn.ReadOnly = true;
            this.PV.Width = 77;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.ReadOnly = true;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "Proveedor";
            this.colIdProveedor.ColumnEdit = this.proveedores;
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdProveedor.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 0;
            this.colIdProveedor.Width = 210;
            // 
            // proveedores
            // 
            this.proveedores.AutoHeight = false;
            this.proveedores.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.proveedores.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProveedor", "Des Proveedor", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.proveedores.DataSource = this.proveedoresBindingSource;
            this.proveedores.DisplayMember = "DesProveedor";
            this.proveedores.Name = "proveedores";
            this.proveedores.NullText = "";
            this.proveedores.ValueMember = "IdProveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colFechaCrea
            // 
            this.colFechaCrea.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colFechaCrea.AppearanceCell.Options.UseBackColor = true;
            this.colFechaCrea.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaCrea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colFechaCrea.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaCrea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colFechaCrea.Caption = "Creado";
            this.colFechaCrea.FieldName = "FechaCrea";
            this.colFechaCrea.Name = "colFechaCrea";
            this.colFechaCrea.OptionsColumn.AllowEdit = false;
            this.colFechaCrea.OptionsColumn.ReadOnly = true;
            // 
            // colFechaModif
            // 
            this.colFechaModif.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colFechaModif.AppearanceCell.Options.UseBackColor = true;
            this.colFechaModif.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaModif.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaModif.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaModif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaModif.Caption = "Modificado";
            this.colFechaModif.FieldName = "FechaModif";
            this.colFechaModif.Name = "colFechaModif";
            this.colFechaModif.OptionsColumn.AllowEdit = false;
            this.colFechaModif.OptionsColumn.ReadOnly = true;
            this.colFechaModif.Visible = true;
            this.colFechaModif.VisibleIndex = 6;
            // 
            // uMedidasTableAdapter
            // 
            this.uMedidasTableAdapter.ClearBeforeFill = true;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // colFechaUtilizado
            // 
            this.colFechaUtilizado.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colFechaUtilizado.AppearanceCell.Options.UseBackColor = true;
            this.colFechaUtilizado.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaUtilizado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaUtilizado.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaUtilizado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaUtilizado.Caption = "Utilizado";
            this.colFechaUtilizado.FieldName = "FechaUtilizado";
            this.colFechaUtilizado.Name = "colFechaUtilizado";
            this.colFechaUtilizado.OptionsColumn.AllowEdit = false;
            this.colFechaUtilizado.OptionsColumn.ReadOnly = true;
            this.colFechaUtilizado.Visible = true;
            this.colFechaUtilizado.VisibleIndex = 7;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 713);
            this.Controls.Add(this.productosGridControl);
            this.Controls.Add(this.productosBindingNavigator);
            this.Name = "Productos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingNavigator)).EndInit();
            this.productosBindingNavigator.ResumeLayout(false);
            this.productosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Promowork_dataDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productosBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl productosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colPVP;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colPorciento;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private System.Windows.Forms.BindingSource uMedidasBindingSource;
        private Promowork_dataDataSetTableAdapters.UMedidasTableAdapter uMedidasTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UM;
        private DevExpress.XtraGrid.Columns.GridColumn PC;
        private DevExpress.XtraGrid.Columns.GridColumn PV;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit proveedores;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModif;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCrea;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Promowork_dataDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaUtilizado;
    }
}