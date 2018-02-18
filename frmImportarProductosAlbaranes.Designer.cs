namespace Promowork
{
    partial class frmImportarProductosAlbaranes
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarProductosAlbaranes));
            this.colValorado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vImportarAlbaranesCabGridControl = new DevExpress.XtraGrid.GridControl();
            this.vImportarAlbaranesCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosAlbaranes = new Promowork.DatosAlbaranes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAlbaranCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsecutivoAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vImportarAlbaranesDetGridControl = new DevExpress.XtraGrid.GridControl();
            this.vImportarAlbaranesDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAlbaranDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAlbaranCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLugarUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProductoInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodUmedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesLugarUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApeTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorciento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vImportarAlbaranesCabTableAdapter = new Promowork.DatosAlbaranesTableAdapters.vImportarAlbaranesCabTableAdapter();
            this.tableAdapterManager = new Promowork.DatosAlbaranesTableAdapters.TableAdapterManager();
            this.vImportarAlbaranesDetTableAdapter = new Promowork.DatosAlbaranesTableAdapters.vImportarAlbaranesDetTableAdapter();
            this.vImportarAlbaranesCabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.queriesAlbaranes1 = new Promowork.DatosAlbaranesTableAdapters.QueriesAlbaranes();
            this.chkMostraValorados = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesCabGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesDetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesCabBindingNavigator)).BeginInit();
            this.vImportarAlbaranesCabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostraValorados.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colValorado
            // 
            this.colValorado.AppearanceCell.Options.UseTextOptions = true;
            this.colValorado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorado.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorado.Caption = "Valorado";
            this.colValorado.FieldName = "Valorado";
            this.colValorado.Name = "colValorado";
            this.colValorado.Visible = true;
            this.colValorado.VisibleIndex = 4;
            this.colValorado.Width = 55;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.vImportarAlbaranesCabGridControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vImportarAlbaranesDetGridControl);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 605);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 3;
            // 
            // vImportarAlbaranesCabGridControl
            // 
            this.vImportarAlbaranesCabGridControl.DataSource = this.vImportarAlbaranesCabBindingSource;
            this.vImportarAlbaranesCabGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vImportarAlbaranesCabGridControl.Location = new System.Drawing.Point(0, 0);
            this.vImportarAlbaranesCabGridControl.MainView = this.gridView1;
            this.vImportarAlbaranesCabGridControl.Name = "vImportarAlbaranesCabGridControl";
            this.vImportarAlbaranesCabGridControl.Size = new System.Drawing.Size(1031, 275);
            this.vImportarAlbaranesCabGridControl.TabIndex = 0;
            this.vImportarAlbaranesCabGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vImportarAlbaranesCabBindingSource
            // 
            this.vImportarAlbaranesCabBindingSource.DataMember = "vImportarAlbaranesCab";
            this.vImportarAlbaranesCabBindingSource.DataSource = this.datosAlbaranes;
            // 
            // datosAlbaranes
            // 
            this.datosAlbaranes.DataSetName = "DatosAlbaranes";
            this.datosAlbaranes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAlbaranCab,
            this.colIdEmpresa,
            this.colIdObra,
            this.colIdProveedor,
            this.colNumAlbaran,
            this.colConsecutivoAlbaran,
            this.colFechaAlbaran,
            this.colValorado,
            this.colUtilizado,
            this.colObservaciones,
            this.colDesProveedor});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colValorado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition1.Value1 = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.vImportarAlbaranesCabGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdAlbaranCab
            // 
            this.colIdAlbaranCab.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab.Name = "colIdAlbaranCab";
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
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colNumAlbaran
            // 
            this.colNumAlbaran.Caption = "Número";
            this.colNumAlbaran.FieldName = "NumAlbaran";
            this.colNumAlbaran.Name = "colNumAlbaran";
            this.colNumAlbaran.Visible = true;
            this.colNumAlbaran.VisibleIndex = 0;
            this.colNumAlbaran.Width = 109;
            // 
            // colConsecutivoAlbaran
            // 
            this.colConsecutivoAlbaran.Caption = "Consecutivo";
            this.colConsecutivoAlbaran.FieldName = "ConsecutivoAlbaran";
            this.colConsecutivoAlbaran.Name = "colConsecutivoAlbaran";
            this.colConsecutivoAlbaran.Visible = true;
            this.colConsecutivoAlbaran.VisibleIndex = 1;
            this.colConsecutivoAlbaran.Width = 93;
            // 
            // colFechaAlbaran
            // 
            this.colFechaAlbaran.Caption = "Fecha";
            this.colFechaAlbaran.FieldName = "FechaAlbaran";
            this.colFechaAlbaran.Name = "colFechaAlbaran";
            this.colFechaAlbaran.Visible = true;
            this.colFechaAlbaran.VisibleIndex = 2;
            this.colFechaAlbaran.Width = 88;
            // 
            // colUtilizado
            // 
            this.colUtilizado.FieldName = "Utilizado";
            this.colUtilizado.Name = "colUtilizado";
            this.colUtilizado.Width = 241;
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.Width = 241;
            // 
            // colDesProveedor
            // 
            this.colDesProveedor.Caption = "Proveedor";
            this.colDesProveedor.FieldName = "DesProveedor";
            this.colDesProveedor.Name = "colDesProveedor";
            this.colDesProveedor.Visible = true;
            this.colDesProveedor.VisibleIndex = 3;
            this.colDesProveedor.Width = 668;
            // 
            // vImportarAlbaranesDetGridControl
            // 
            this.vImportarAlbaranesDetGridControl.DataSource = this.vImportarAlbaranesDetBindingSource;
            this.vImportarAlbaranesDetGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vImportarAlbaranesDetGridControl.Location = new System.Drawing.Point(0, 0);
            this.vImportarAlbaranesDetGridControl.MainView = this.gridView2;
            this.vImportarAlbaranesDetGridControl.Name = "vImportarAlbaranesDetGridControl";
            this.vImportarAlbaranesDetGridControl.Size = new System.Drawing.Size(1031, 326);
            this.vImportarAlbaranesDetGridControl.TabIndex = 0;
            this.vImportarAlbaranesDetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // vImportarAlbaranesDetBindingSource
            // 
            this.vImportarAlbaranesDetBindingSource.DataMember = "vImportarAlbaranesDet";
            this.vImportarAlbaranesDetBindingSource.DataSource = this.datosAlbaranes;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAlbaranDet,
            this.colIdAlbaranCab1,
            this.colIdProducto,
            this.colCantidad,
            this.colPrecio,
            this.colDescuento,
            this.colIdLugarUso,
            this.colIdTrabajador,
            this.colCodProductoInterno,
            this.colDesProducto,
            this.colCodUmedida,
            this.colDesLugarUso,
            this.colNomTrabajador,
            this.colApeTrabajador,
            this.colNumTrabajador,
            this.colPorciento});
            this.gridView2.GridControl = this.vImportarAlbaranesDetGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAlbaranDet
            // 
            this.colIdAlbaranDet.FieldName = "IdAlbaranDet";
            this.colIdAlbaranDet.Name = "colIdAlbaranDet";
            // 
            // colIdAlbaranCab1
            // 
            this.colIdAlbaranCab1.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab1.Name = "colIdAlbaranCab1";
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
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 88;
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 5;
            this.colDescuento.Width = 65;
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
            this.colCodProductoInterno.Caption = "Código";
            this.colCodProductoInterno.FieldName = "CodProductoInterno";
            this.colCodProductoInterno.Name = "colCodProductoInterno";
            this.colCodProductoInterno.Visible = true;
            this.colCodProductoInterno.VisibleIndex = 0;
            this.colCodProductoInterno.Width = 126;
            // 
            // colDesProducto
            // 
            this.colDesProducto.Caption = "Descripción";
            this.colDesProducto.FieldName = "DesProducto";
            this.colDesProducto.Name = "colDesProducto";
            this.colDesProducto.Visible = true;
            this.colDesProducto.VisibleIndex = 1;
            this.colDesProducto.Width = 304;
            // 
            // colCodUmedida
            // 
            this.colCodUmedida.Caption = "U.M";
            this.colCodUmedida.FieldName = "CodUmedida";
            this.colCodUmedida.Name = "colCodUmedida";
            this.colCodUmedida.Visible = true;
            this.colCodUmedida.VisibleIndex = 2;
            this.colCodUmedida.Width = 42;
            // 
            // colDesLugarUso
            // 
            this.colDesLugarUso.Caption = "Usado En";
            this.colDesLugarUso.FieldName = "DesLugarUso";
            this.colDesLugarUso.Name = "colDesLugarUso";
            this.colDesLugarUso.Visible = true;
            this.colDesLugarUso.VisibleIndex = 7;
            this.colDesLugarUso.Width = 158;
            // 
            // colNomTrabajador
            // 
            this.colNomTrabajador.Caption = "Nombre";
            this.colNomTrabajador.FieldName = "NomTrabajador";
            this.colNomTrabajador.Name = "colNomTrabajador";
            this.colNomTrabajador.Visible = true;
            this.colNomTrabajador.VisibleIndex = 8;
            this.colNomTrabajador.Width = 154;
            // 
            // colApeTrabajador
            // 
            this.colApeTrabajador.Caption = "Apellido";
            this.colApeTrabajador.FieldName = "ApeTrabajador";
            this.colApeTrabajador.Name = "colApeTrabajador";
            // 
            // colNumTrabajador
            // 
            this.colNumTrabajador.Caption = "Número";
            this.colNumTrabajador.FieldName = "NumTrabajador";
            this.colNumTrabajador.Name = "colNumTrabajador";
            // 
            // colPorciento
            // 
            this.colPorciento.AppearanceHeader.Options.UseTextOptions = true;
            this.colPorciento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPorciento.FieldName = "Porciento";
            this.colPorciento.Name = "colPorciento";
            this.colPorciento.Visible = true;
            this.colPorciento.VisibleIndex = 6;
            // 
            // vImportarAlbaranesCabTableAdapter
            // 
            this.vImportarAlbaranesCabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbaranesCabTableAdapter = null;
            this.tableAdapterManager.AlbaranesDetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            // vImportarAlbaranesDetTableAdapter
            // 
            this.vImportarAlbaranesDetTableAdapter.ClearBeforeFill = true;
            // 
            // vImportarAlbaranesCabBindingNavigator
            // 
            this.vImportarAlbaranesCabBindingNavigator.AddNewItem = null;
            this.vImportarAlbaranesCabBindingNavigator.BindingSource = this.vImportarAlbaranesCabBindingSource;
            this.vImportarAlbaranesCabBindingNavigator.CountItem = null;
            this.vImportarAlbaranesCabBindingNavigator.DeleteItem = null;
            this.vImportarAlbaranesCabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.vImportarAlbaranesCabBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vImportarAlbaranesCabBindingNavigator.MoveFirstItem = null;
            this.vImportarAlbaranesCabBindingNavigator.MoveLastItem = null;
            this.vImportarAlbaranesCabBindingNavigator.MoveNextItem = null;
            this.vImportarAlbaranesCabBindingNavigator.MovePreviousItem = null;
            this.vImportarAlbaranesCabBindingNavigator.Name = "vImportarAlbaranesCabBindingNavigator";
            this.vImportarAlbaranesCabBindingNavigator.PositionItem = null;
            this.vImportarAlbaranesCabBindingNavigator.Size = new System.Drawing.Size(1031, 25);
            this.vImportarAlbaranesCabBindingNavigator.TabIndex = 4;
            this.vImportarAlbaranesCabBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripButton1.Text = "<< Importar Albaran";
            this.toolStripButton1.ToolTipText = "Importa los productos del Albaran seleccionado al parte de trabajo actual.";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // chkMostraValorados
            // 
            this.chkMostraValorados.EditValue = true;
            this.chkMostraValorados.Location = new System.Drawing.Point(145, 3);
            this.chkMostraValorados.Name = "chkMostraValorados";
            this.chkMostraValorados.Properties.Caption = "Mostra Solo Albaranes Valorados";
            this.chkMostraValorados.Size = new System.Drawing.Size(193, 19);
            this.chkMostraValorados.TabIndex = 5;
            this.chkMostraValorados.CheckedChanged += new System.EventHandler(this.chkMostraNoValorados_CheckedChanged);
            // 
            // frmImportarProductosAlbaranes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 630);
            this.Controls.Add(this.chkMostraValorados);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.vImportarAlbaranesCabBindingNavigator);
            this.Name = "frmImportarProductosAlbaranes";
            this.Text = "Importar Productos Albaranes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesCabGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesDetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImportarAlbaranesCabBindingNavigator)).EndInit();
            this.vImportarAlbaranesCabBindingNavigator.ResumeLayout(false);
            this.vImportarAlbaranesCabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostraValorados.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DatosAlbaranes datosAlbaranes;
        private System.Windows.Forms.BindingSource vImportarAlbaranesCabBindingSource;
        private DatosAlbaranesTableAdapters.vImportarAlbaranesCabTableAdapter vImportarAlbaranesCabTableAdapter;
        private DatosAlbaranesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vImportarAlbaranesCabGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colConsecutivoAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colValorado;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizado;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProveedor;
        private System.Windows.Forms.BindingSource vImportarAlbaranesDetBindingSource;
        private DatosAlbaranesTableAdapters.vImportarAlbaranesDetTableAdapter vImportarAlbaranesDetTableAdapter;
        private DevExpress.XtraGrid.GridControl vImportarAlbaranesDetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLugarUso;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProductoInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodUmedida;
        private DevExpress.XtraGrid.Columns.GridColumn colDesLugarUso;
        private DevExpress.XtraGrid.Columns.GridColumn colNomTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colApeTrabajador;
        private System.Windows.Forms.BindingNavigator vImportarAlbaranesCabBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumTrabajador;
        private DatosAlbaranesTableAdapters.QueriesAlbaranes queriesAlbaranes1;
        private DevExpress.XtraGrid.Columns.GridColumn colPorciento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.CheckEdit chkMostraValorados;

    }
}