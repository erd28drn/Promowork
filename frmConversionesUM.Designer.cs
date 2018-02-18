namespace Promowork
{
    partial class frmConversionesUM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversionesUM));
            this.datosAlbaranes = new Promowork.DatosAlbaranes();
            this.conversionesUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conversionesUMTableAdapter = new Promowork.DatosAlbaranesTableAdapters.ConversionesUMTableAdapter();
            this.tableAdapterManager = new Promowork.DatosAlbaranesTableAdapters.TableAdapterManager();
            this.conversionesUMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.conversionesUMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.conversionesUMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdConvUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUMOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UMOrigen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.uMedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIDUMDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UMDestino = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.uMedidasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colMultiplicador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesConversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uMedidasTableAdapter = new Promowork.DatosAlbaranesTableAdapters.UMedidasTableAdapter();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Productos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Promowork.DatosAlbaranesTableAdapters.ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionesUMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionesUMBindingNavigator)).BeginInit();
            this.conversionesUMBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conversionesUMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datosAlbaranes
            // 
            this.datosAlbaranes.DataSetName = "DatosAlbaranes";
            this.datosAlbaranes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conversionesUMBindingSource
            // 
            this.conversionesUMBindingSource.DataMember = "ConversionesUM";
            this.conversionesUMBindingSource.DataSource = this.datosAlbaranes;
            // 
            // conversionesUMTableAdapter
            // 
            this.conversionesUMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbaranesCabTableAdapter = null;
            this.tableAdapterManager.AlbaranesDetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConversionesUMTableAdapter = this.conversionesUMTableAdapter;
            this.tableAdapterManager.LugaresUsoMaterialTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.ObservacionesProveedoresTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosAlbaranesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // conversionesUMBindingNavigator
            // 
            this.conversionesUMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.conversionesUMBindingNavigator.BindingSource = this.conversionesUMBindingSource;
            this.conversionesUMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.conversionesUMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.conversionesUMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.conversionesUMBindingNavigatorSaveItem});
            this.conversionesUMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.conversionesUMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.conversionesUMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.conversionesUMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.conversionesUMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.conversionesUMBindingNavigator.Name = "conversionesUMBindingNavigator";
            this.conversionesUMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.conversionesUMBindingNavigator.Size = new System.Drawing.Size(835, 25);
            this.conversionesUMBindingNavigator.TabIndex = 0;
            this.conversionesUMBindingNavigator.Text = "bindingNavigator1";
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
            // conversionesUMBindingNavigatorSaveItem
            // 
            this.conversionesUMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.conversionesUMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("conversionesUMBindingNavigatorSaveItem.Image")));
            this.conversionesUMBindingNavigatorSaveItem.Name = "conversionesUMBindingNavigatorSaveItem";
            this.conversionesUMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.conversionesUMBindingNavigatorSaveItem.Text = "Guardar datos";
            this.conversionesUMBindingNavigatorSaveItem.Click += new System.EventHandler(this.conversionesUMBindingNavigatorSaveItem_Click);
            // 
            // conversionesUMGridControl
            // 
            this.conversionesUMGridControl.DataSource = this.conversionesUMBindingSource;
            this.conversionesUMGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conversionesUMGridControl.Location = new System.Drawing.Point(0, 25);
            this.conversionesUMGridControl.MainView = this.gridView1;
            this.conversionesUMGridControl.Name = "conversionesUMGridControl";
            this.conversionesUMGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UMOrigen,
            this.UMDestino,
            this.Productos});
            this.conversionesUMGridControl.Size = new System.Drawing.Size(835, 528);
            this.conversionesUMGridControl.TabIndex = 2;
            this.conversionesUMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdConvUM,
            this.colIdEmpresa,
            this.colIdUMOrigen,
            this.colIDUMDestino,
            this.colMultiplicador,
            this.colDesConversion,
            this.colIdProducto});
            this.gridView1.GridControl = this.conversionesUMGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colIdConvUM
            // 
            this.colIdConvUM.FieldName = "IdConvUM";
            this.colIdConvUM.Name = "colIdConvUM";
            this.colIdConvUM.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdUMOrigen
            // 
            this.colIdUMOrigen.Caption = "UM Origen";
            this.colIdUMOrigen.ColumnEdit = this.UMOrigen;
            this.colIdUMOrigen.FieldName = "IdUMOrigen";
            this.colIdUMOrigen.Name = "colIdUMOrigen";
            this.colIdUMOrigen.Visible = true;
            this.colIdUMOrigen.VisibleIndex = 1;
            this.colIdUMOrigen.Width = 162;
            // 
            // UMOrigen
            // 
            this.UMOrigen.AutoHeight = false;
            this.UMOrigen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UMOrigen.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodDesUM", "Unidad de Medida", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UMOrigen.DataSource = this.uMedidasBindingSource;
            this.UMOrigen.DisplayMember = "CodDesUM";
            this.UMOrigen.Name = "UMOrigen";
            this.UMOrigen.ValueMember = "IdUmedida";
            // 
            // uMedidasBindingSource
            // 
            this.uMedidasBindingSource.DataMember = "UMedidas";
            this.uMedidasBindingSource.DataSource = this.datosAlbaranes;
            // 
            // colIDUMDestino
            // 
            this.colIDUMDestino.Caption = "UM Destino";
            this.colIDUMDestino.ColumnEdit = this.UMDestino;
            this.colIDUMDestino.FieldName = "IDUMDestino";
            this.colIDUMDestino.Name = "colIDUMDestino";
            this.colIDUMDestino.Visible = true;
            this.colIDUMDestino.VisibleIndex = 2;
            this.colIDUMDestino.Width = 170;
            // 
            // UMDestino
            // 
            this.UMDestino.AutoHeight = false;
            this.UMDestino.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UMDestino.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodDesUM", "Unidad de Medida", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UMDestino.DataSource = this.uMedidasBindingSource1;
            this.UMDestino.DisplayMember = "CodDesUM";
            this.UMDestino.Name = "UMDestino";
            this.UMDestino.ValueMember = "IdUmedida";
            // 
            // uMedidasBindingSource1
            // 
            this.uMedidasBindingSource1.DataMember = "UMedidas";
            this.uMedidasBindingSource1.DataSource = this.datosAlbaranes;
            // 
            // colMultiplicador
            // 
            this.colMultiplicador.AppearanceHeader.Options.UseTextOptions = true;
            this.colMultiplicador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMultiplicador.Caption = "Multiplicador";
            this.colMultiplicador.FieldName = "Multiplicador";
            this.colMultiplicador.Name = "colMultiplicador";
            this.colMultiplicador.Visible = true;
            this.colMultiplicador.VisibleIndex = 3;
            this.colMultiplicador.Width = 134;
            // 
            // colDesConversion
            // 
            this.colDesConversion.Caption = "Descripción";
            this.colDesConversion.FieldName = "DesConversion";
            this.colDesConversion.Name = "colDesConversion";
            this.colDesConversion.Width = 289;
            // 
            // uMedidasTableAdapter
            // 
            this.uMedidasTableAdapter.ClearBeforeFill = true;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.Productos;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 351;
            // 
            // Productos
            // 
            this.Productos.AutoHeight = false;
            this.Productos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Productos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodDesProducto", "Producto", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Productos.DataSource = this.productosBindingSource;
            this.Productos.DisplayMember = "CodDesProducto";
            this.Productos.Name = "Productos";
            this.Productos.ValueMember = "IdProducto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.datosAlbaranes;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // frmConversionesUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 553);
            this.Controls.Add(this.conversionesUMGridControl);
            this.Controls.Add(this.conversionesUMBindingNavigator);
            this.Name = "frmConversionesUM";
            this.Text = "Conversiones UM";
            this.Load += new System.EventHandler(this.frmConversionesUM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionesUMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionesUMBindingNavigator)).EndInit();
            this.conversionesUMBindingNavigator.ResumeLayout(false);
            this.conversionesUMBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conversionesUMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatosAlbaranes datosAlbaranes;
        private System.Windows.Forms.BindingSource conversionesUMBindingSource;
        private DatosAlbaranesTableAdapters.ConversionesUMTableAdapter conversionesUMTableAdapter;
        private DatosAlbaranesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator conversionesUMBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton conversionesUMBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl conversionesUMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdConvUM;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUMOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUMDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiplicador;
        private DevExpress.XtraGrid.Columns.GridColumn colDesConversion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UMOrigen;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UMDestino;
        private System.Windows.Forms.BindingSource uMedidasBindingSource;
        private DatosAlbaranesTableAdapters.UMedidasTableAdapter uMedidasTableAdapter;
        private System.Windows.Forms.BindingSource uMedidasBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Productos;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DatosAlbaranesTableAdapters.ProductosTableAdapter productosTableAdapter;
    }
}