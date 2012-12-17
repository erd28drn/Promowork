namespace Promowork
{
    partial class AnticiposTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnticiposTrabajadores));
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.anticiposTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anticiposTrabajadoresTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.AnticiposTrabajadoresTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.anticiposTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.AnticiposTableAdapter();
            this.anticiposTrabajadoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.anticiposTrabajadoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.anticiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajadoresListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.trabajadoresListaTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.TrabajadoresListaTableAdapter();
            this.anticiposTrabajadoresGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIdTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDetAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnoAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposTrabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposTrabajadoresBindingNavigator)).BeginInit();
            this.anticiposTrabajadoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposTrabajadoresGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anticiposTrabajadoresBindingSource
            // 
            this.anticiposTrabajadoresBindingSource.DataMember = "AnticiposTrabajadores";
            this.anticiposTrabajadoresBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // anticiposTrabajadoresTableAdapter
            // 
            this.anticiposTrabajadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccesosEmpresasTableAdapter = null;
            this.tableAdapterManager.AdjuntosObrasTableAdapter = null;
            this.tableAdapterManager.AnticiposTableAdapter = this.anticiposTableAdapter;
            this.tableAdapterManager.AnticiposTrabajadoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajasMedicaTableAdapter = null;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosTableAdapter = null;
            this.tableAdapterManager.ComprasCabTableAdapter = null;
            this.tableAdapterManager.ComprasDetTableAdapter = null;
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.EmpresasActualTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.FacturasCabTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = null;
            this.tableAdapterManager.FestivosEmpresasTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.HijosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.HorasAdminTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadasTableAdapter = null;
            this.tableAdapterManager.NacionesTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
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
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Provincias1TableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.PuestosTrabajoTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaAdminTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.SeguridadSocialTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresListaTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // anticiposTableAdapter
            // 
            this.anticiposTableAdapter.ClearBeforeFill = true;
            // 
            // anticiposTrabajadoresBindingNavigator
            // 
            this.anticiposTrabajadoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.anticiposTrabajadoresBindingNavigator.BindingSource = this.anticiposTrabajadoresBindingSource;
            this.anticiposTrabajadoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.anticiposTrabajadoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.anticiposTrabajadoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.anticiposTrabajadoresBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3});
            this.anticiposTrabajadoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.anticiposTrabajadoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.anticiposTrabajadoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.anticiposTrabajadoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.anticiposTrabajadoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.anticiposTrabajadoresBindingNavigator.Name = "anticiposTrabajadoresBindingNavigator";
            this.anticiposTrabajadoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.anticiposTrabajadoresBindingNavigator.Size = new System.Drawing.Size(818, 25);
            this.anticiposTrabajadoresBindingNavigator.TabIndex = 0;
            this.anticiposTrabajadoresBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // anticiposTrabajadoresBindingNavigatorSaveItem
            // 
            this.anticiposTrabajadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.anticiposTrabajadoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("anticiposTrabajadoresBindingNavigatorSaveItem.Image")));
            this.anticiposTrabajadoresBindingNavigatorSaveItem.Name = "anticiposTrabajadoresBindingNavigatorSaveItem";
            this.anticiposTrabajadoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.anticiposTrabajadoresBindingNavigatorSaveItem.Text = "Save Data";
            this.anticiposTrabajadoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.anticiposTrabajadoresBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = global::Promowork.Properties.Resources.print11;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton1.Text = "Anticipos";
            this.toolStripButton1.ToolTipText = "Ver Anticipos del Mes";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // anticiposBindingSource
            // 
            this.anticiposBindingSource.DataMember = "Anticipos";
            this.anticiposBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // trabajadoresListaBindingSource
            // 
            this.trabajadoresListaBindingSource.DataMember = "TrabajadoresLista";
            this.trabajadoresListaBindingSource.DataSource = this.promowork_dataDataSet;
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
            // trabajadoresListaTableAdapter
            // 
            this.trabajadoresListaTableAdapter.ClearBeforeFill = true;
            // 
            // anticiposTrabajadoresGridControl
            // 
            this.anticiposTrabajadoresGridControl.DataSource = this.anticiposTrabajadoresBindingSource;
            this.anticiposTrabajadoresGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anticiposTrabajadoresGridControl.Location = new System.Drawing.Point(0, 25);
            this.anticiposTrabajadoresGridControl.MainView = this.gridView1;
            this.anticiposTrabajadoresGridControl.Name = "anticiposTrabajadoresGridControl";
            this.anticiposTrabajadoresGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.anticiposTrabajadoresGridControl.Size = new System.Drawing.Size(818, 461);
            this.anticiposTrabajadoresGridControl.TabIndex = 2;
            this.anticiposTrabajadoresGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAnticipo,
            this.colIdTrabajador,
            this.colDetAnticipo,
            this.colDiaAnticipo,
            this.colMesAnticipo,
            this.colAnoAnticipo,
            this.colImpAnticipo,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.anticiposTrabajadoresGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdAnticipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdAnticipo
            // 
            this.colIdAnticipo.Caption = "Concepto";
            this.colIdAnticipo.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdAnticipo.FieldName = "IdAnticipo";
            this.colIdAnticipo.Name = "colIdAnticipo";
            this.colIdAnticipo.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colIdAnticipo.Visible = true;
            this.colIdAnticipo.VisibleIndex = 1;
            this.colIdAnticipo.Width = 164;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesAnticipo", "Anticipo", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.anticiposBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "DesAnticipo";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdAnticipo";
            // 
            // colIdTrabajador
            // 
            this.colIdTrabajador.Caption = "Trabajador";
            this.colIdTrabajador.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdTrabajador.FieldName = "IdTrabajador";
            this.colIdTrabajador.Name = "colIdTrabajador";
            this.colIdTrabajador.Visible = true;
            this.colIdTrabajador.VisibleIndex = 3;
            this.colIdTrabajador.Width = 187;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.trabajadoresListaBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Nombre";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdTrabajador";
            // 
            // colDetAnticipo
            // 
            this.colDetAnticipo.Caption = "Detalle";
            this.colDetAnticipo.FieldName = "DetAnticipo";
            this.colDetAnticipo.Name = "colDetAnticipo";
            this.colDetAnticipo.Visible = true;
            this.colDetAnticipo.VisibleIndex = 2;
            this.colDetAnticipo.Width = 285;
            // 
            // colDiaAnticipo
            // 
            this.colDiaAnticipo.Caption = "Día";
            this.colDiaAnticipo.FieldName = "DiaAnticipo";
            this.colDiaAnticipo.Name = "colDiaAnticipo";
            this.colDiaAnticipo.Visible = true;
            this.colDiaAnticipo.VisibleIndex = 0;
            this.colDiaAnticipo.Width = 48;
            // 
            // colMesAnticipo
            // 
            this.colMesAnticipo.FieldName = "MesAnticipo";
            this.colMesAnticipo.Name = "colMesAnticipo";
            // 
            // colAnoAnticipo
            // 
            this.colAnoAnticipo.FieldName = "AnoAnticipo";
            this.colAnoAnticipo.Name = "colAnoAnticipo";
            // 
            // colImpAnticipo
            // 
            this.colImpAnticipo.Caption = "Importe";
            this.colImpAnticipo.FieldName = "ImpAnticipo";
            this.colImpAnticipo.Name = "colImpAnticipo";
            this.colImpAnticipo.Visible = true;
            this.colImpAnticipo.VisibleIndex = 4;
            this.colImpAnticipo.Width = 83;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // AnticiposTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 486);
            this.Controls.Add(this.anticiposTrabajadoresGridControl);
            this.Controls.Add(this.anticiposTrabajadoresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AnticiposTrabajadores";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anticipos a Trabajadores";
            this.Load += new System.EventHandler(this.AnticiposTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposTrabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposTrabajadoresBindingNavigator)).EndInit();
            this.anticiposTrabajadoresBindingNavigator.ResumeLayout(false);
            this.anticiposTrabajadoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticiposTrabajadoresGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource anticiposTrabajadoresBindingSource;
        private Promowork_dataDataSetTableAdapters.AnticiposTrabajadoresTableAdapter anticiposTrabajadoresTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator anticiposTrabajadoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton anticiposTrabajadoresBindingNavigatorSaveItem;
        private Promowork_dataDataSetTableAdapters.AnticiposTableAdapter anticiposTableAdapter;
        private System.Windows.Forms.BindingSource anticiposBindingSource;
        private System.Windows.Forms.BindingSource empresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter empresasActualTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource trabajadoresListaBindingSource;
        private Promowork_dataDataSetTableAdapters.TrabajadoresListaTableAdapter trabajadoresListaTableAdapter;
        private DevExpress.XtraGrid.GridControl anticiposTrabajadoresGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colDetAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colMesAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colAnoAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colImpAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    }
}