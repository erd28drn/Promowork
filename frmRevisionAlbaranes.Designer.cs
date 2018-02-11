namespace Promowork
{
    partial class frmRevisionAlbaranes
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label fechaAlbaranLabel;
            this.datosAlbaranes = new Promowork.DatosAlbaranes();
            this.vRevisionAlbaranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRevisionAlbaranesTableAdapter = new Promowork.DatosAlbaranesTableAdapters.vRevisionAlbaranesTableAdapter();
            this.tableAdapterManager = new Promowork.DatosAlbaranesTableAdapters.TableAdapterManager();
            this.vRevisionAlbaranesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAlbaranCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsecutivoAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAlbaran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProductoInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodUmedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesTipoProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesLugarUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Obra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaRecibida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Filtro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.cbxMes = new DevExpress.XtraEditors.LookUpEdit();
            this.mesesAlbaranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxAno = new DevExpress.XtraEditors.LookUpEdit();
            this.anosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.deFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.deFechaIni = new DevExpress.XtraEditors.DateEdit();
            this.mesesAlbaranesTableAdapter = new Promowork.DatosAlbaranesTableAdapters.MesesAlbaranesTableAdapter();
            this.anosTableAdapter = new Promowork.DatosAlbaranesTableAdapters.AnosTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.lbFlecha2 = new System.Windows.Forms.Label();
            this.lbFlecha1 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.vProductosConversionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbxUMDestino = new System.Windows.Forms.ComboBox();
            this.vUMDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCantidadDestino = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxUMOrigen = new System.Windows.Forms.ComboBox();
            this.vUMOrigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbCantidadOrigen = new DevExpress.XtraEditors.TextEdit();
            this.tbMultiplicador = new DevExpress.XtraEditors.TextEdit();
            this.vUMOrigenTableAdapter = new Promowork.DatosAlbaranesTableAdapters.vUMOrigenTableAdapter();
            this.vUMDestinoTableAdapter = new Promowork.DatosAlbaranesTableAdapters.vUMDestinoTableAdapter();
            this.vProductosConversionesTableAdapter = new Promowork.DatosAlbaranesTableAdapters.vProductosConversionesTableAdapter();
            this.colFacturaCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            label1 = new System.Windows.Forms.Label();
            fechaAlbaranLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRevisionAlbaranesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRevisionAlbaranesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesAlbaranesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anosBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIni.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIni.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vProductosConversionesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vUMDestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadDestino.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vUMOrigenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultiplicador.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(172, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 12;
            label1.Text = "Hasta:";
            // 
            // fechaAlbaranLabel
            // 
            fechaAlbaranLabel.AutoSize = true;
            fechaAlbaranLabel.Location = new System.Drawing.Point(11, 15);
            fechaAlbaranLabel.Name = "fechaAlbaranLabel";
            fechaAlbaranLabel.Size = new System.Drawing.Size(41, 13);
            fechaAlbaranLabel.TabIndex = 9;
            fechaAlbaranLabel.Text = "Desde:";
            // 
            // datosAlbaranes
            // 
            this.datosAlbaranes.DataSetName = "DatosAlbaranes";
            this.datosAlbaranes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vRevisionAlbaranesBindingSource
            // 
            this.vRevisionAlbaranesBindingSource.DataMember = "vRevisionAlbaranes";
            this.vRevisionAlbaranesBindingSource.DataSource = this.datosAlbaranes;
            // 
            // vRevisionAlbaranesTableAdapter
            // 
            this.vRevisionAlbaranesTableAdapter.ClearBeforeFill = true;
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
            // vRevisionAlbaranesGridControl
            // 
            this.vRevisionAlbaranesGridControl.DataSource = this.vRevisionAlbaranesBindingSource;
            this.vRevisionAlbaranesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vRevisionAlbaranesGridControl.Location = new System.Drawing.Point(0, 44);
            this.vRevisionAlbaranesGridControl.MainView = this.gridView1;
            this.vRevisionAlbaranesGridControl.Name = "vRevisionAlbaranesGridControl";
            this.vRevisionAlbaranesGridControl.Size = new System.Drawing.Size(1541, 592);
            this.vRevisionAlbaranesGridControl.TabIndex = 2;
            this.vRevisionAlbaranesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAlbaranCab,
            this.colIdObra,
            this.colIdProveedor,
            this.colNumAlbaran,
            this.colConsecutivoAlbaran,
            this.colFechaAlbaran,
            this.colValorado,
            this.colUtilizado,
            this.colNumMatriz,
            this.colNumObra,
            this.colSerieObra,
            this.colNumeroObra,
            this.colDesObra,
            this.colNumProveedor,
            this.colDesProveedor,
            this.colCantidad,
            this.colPrecio,
            this.colDescuento,
            this.colImporte,
            this.colCodProductoInterno,
            this.colDesProducto,
            this.colCodUmedida,
            this.colCodGrupo,
            this.colDesGrupo,
            this.colCodTipoProveedor,
            this.colDesTipoProveedor,
            this.colDesLugarUso,
            this.colIdEmpresa,
            this.Grupo,
            this.TipoProveedor,
            this.Obra,
            this.Producto,
            this.colTrabajador,
            this.colFacturaRecibida,
            this.colObservaciones,
            this.Filtro,
            this.colFacturaCompra});
            this.gridView1.GridControl = this.vRevisionAlbaranesGridControl;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupFormat = "[#image]{1}     {2}";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", null, "(Cantidad: {0:n2})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", null, "(Total: {0:c2})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Obra, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDesProveedor, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdAlbaranCab
            // 
            this.colIdAlbaranCab.FieldName = "IdAlbaranCab";
            this.colIdAlbaranCab.Name = "colIdAlbaranCab";
            this.colIdAlbaranCab.OptionsColumn.ReadOnly = true;
            // 
            // colIdObra
            // 
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsColumn.ReadOnly = true;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colNumAlbaran
            // 
            this.colNumAlbaran.Caption = "Alabran";
            this.colNumAlbaran.FieldName = "NumAlbaran";
            this.colNumAlbaran.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNumAlbaran.Name = "colNumAlbaran";
            this.colNumAlbaran.OptionsColumn.ReadOnly = true;
            this.colNumAlbaran.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumAlbaran.Visible = true;
            this.colNumAlbaran.VisibleIndex = 0;
            this.colNumAlbaran.Width = 93;
            // 
            // colConsecutivoAlbaran
            // 
            this.colConsecutivoAlbaran.AppearanceCell.Options.UseTextOptions = true;
            this.colConsecutivoAlbaran.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colConsecutivoAlbaran.AppearanceHeader.Options.UseTextOptions = true;
            this.colConsecutivoAlbaran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colConsecutivoAlbaran.Caption = "Conc";
            this.colConsecutivoAlbaran.FieldName = "ConsecutivoAlbaran";
            this.colConsecutivoAlbaran.Name = "colConsecutivoAlbaran";
            this.colConsecutivoAlbaran.OptionsColumn.ReadOnly = true;
            this.colConsecutivoAlbaran.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colConsecutivoAlbaran.Visible = true;
            this.colConsecutivoAlbaran.VisibleIndex = 1;
            this.colConsecutivoAlbaran.Width = 57;
            // 
            // colFechaAlbaran
            // 
            this.colFechaAlbaran.Caption = "Fecha";
            this.colFechaAlbaran.FieldName = "FechaAlbaran";
            this.colFechaAlbaran.Name = "colFechaAlbaran";
            this.colFechaAlbaran.OptionsColumn.ReadOnly = true;
            this.colFechaAlbaran.Visible = true;
            this.colFechaAlbaran.VisibleIndex = 2;
            this.colFechaAlbaran.Width = 67;
            // 
            // colValorado
            // 
            this.colValorado.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorado.FieldName = "Valorado";
            this.colValorado.Name = "colValorado";
            this.colValorado.OptionsColumn.ReadOnly = true;
            this.colValorado.Visible = true;
            this.colValorado.VisibleIndex = 14;
            this.colValorado.Width = 46;
            // 
            // colUtilizado
            // 
            this.colUtilizado.AppearanceHeader.Options.UseTextOptions = true;
            this.colUtilizado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUtilizado.FieldName = "Utilizado";
            this.colUtilizado.Name = "colUtilizado";
            this.colUtilizado.OptionsColumn.ReadOnly = true;
            this.colUtilizado.Visible = true;
            this.colUtilizado.VisibleIndex = 15;
            this.colUtilizado.Width = 63;
            // 
            // colNumMatriz
            // 
            this.colNumMatriz.FieldName = "NumMatriz";
            this.colNumMatriz.Name = "colNumMatriz";
            this.colNumMatriz.OptionsColumn.ReadOnly = true;
            // 
            // colNumObra
            // 
            this.colNumObra.FieldName = "NumObra";
            this.colNumObra.Name = "colNumObra";
            this.colNumObra.OptionsColumn.ReadOnly = true;
            // 
            // colSerieObra
            // 
            this.colSerieObra.FieldName = "SerieObra";
            this.colSerieObra.Name = "colSerieObra";
            this.colSerieObra.OptionsColumn.ReadOnly = true;
            // 
            // colNumeroObra
            // 
            this.colNumeroObra.FieldName = "NumeroObra";
            this.colNumeroObra.Name = "colNumeroObra";
            this.colNumeroObra.OptionsColumn.ReadOnly = true;
            this.colNumeroObra.Width = 70;
            // 
            // colDesObra
            // 
            this.colDesObra.FieldName = "DesObra";
            this.colDesObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesObra.Name = "colDesObra";
            this.colDesObra.OptionsColumn.ReadOnly = true;
            this.colDesObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesObra.Width = 165;
            // 
            // colNumProveedor
            // 
            this.colNumProveedor.FieldName = "NumProveedor";
            this.colNumProveedor.Name = "colNumProveedor";
            this.colNumProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colDesProveedor
            // 
            this.colDesProveedor.Caption = "Proveedor";
            this.colDesProveedor.FieldName = "DesProveedor";
            this.colDesProveedor.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesProveedor.Name = "colDesProveedor";
            this.colDesProveedor.OptionsColumn.ReadOnly = true;
            this.colDesProveedor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesProveedor.Visible = true;
            this.colDesProveedor.VisibleIndex = 0;
            this.colDesProveedor.Width = 180;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.DisplayFormat.FormatString = "N2";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 5;
            this.colCantidad.Width = 73;
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio.DisplayFormat.FormatString = "C2";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.ReadOnly = true;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 6;
            this.colPrecio.Width = 50;
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescuento.DisplayFormat.FormatString = "N2";
            this.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.OptionsColumn.ReadOnly = true;
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 7;
            this.colDescuento.Width = 50;
            // 
            // colImporte
            // 
            this.colImporte.AppearanceHeader.Options.UseTextOptions = true;
            this.colImporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImporte.DisplayFormat.FormatString = "C2";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.OptionsColumn.ReadOnly = true;
            this.colImporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")});
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 8;
            this.colImporte.Width = 116;
            // 
            // colCodProductoInterno
            // 
            this.colCodProductoInterno.FieldName = "CodProductoInterno";
            this.colCodProductoInterno.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colCodProductoInterno.Name = "colCodProductoInterno";
            this.colCodProductoInterno.OptionsColumn.ReadOnly = true;
            this.colCodProductoInterno.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCodProductoInterno.Width = 71;
            // 
            // colDesProducto
            // 
            this.colDesProducto.FieldName = "DesProducto";
            this.colDesProducto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesProducto.Name = "colDesProducto";
            this.colDesProducto.OptionsColumn.ReadOnly = true;
            this.colDesProducto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesProducto.Width = 188;
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
            this.colCodUmedida.OptionsColumn.ReadOnly = true;
            this.colCodUmedida.Visible = true;
            this.colCodUmedida.VisibleIndex = 4;
            this.colCodUmedida.Width = 33;
            // 
            // colCodGrupo
            // 
            this.colCodGrupo.FieldName = "CodGrupo";
            this.colCodGrupo.Name = "colCodGrupo";
            this.colCodGrupo.OptionsColumn.ReadOnly = true;
            this.colCodGrupo.Width = 67;
            // 
            // colDesGrupo
            // 
            this.colDesGrupo.FieldName = "DesGrupo";
            this.colDesGrupo.Name = "colDesGrupo";
            this.colDesGrupo.OptionsColumn.ReadOnly = true;
            this.colDesGrupo.Width = 61;
            // 
            // colCodTipoProveedor
            // 
            this.colCodTipoProveedor.FieldName = "CodTipoProveedor";
            this.colCodTipoProveedor.Name = "colCodTipoProveedor";
            this.colCodTipoProveedor.OptionsColumn.ReadOnly = true;
            this.colCodTipoProveedor.Width = 28;
            // 
            // colDesTipoProveedor
            // 
            this.colDesTipoProveedor.FieldName = "DesTipoProveedor";
            this.colDesTipoProveedor.Name = "colDesTipoProveedor";
            this.colDesTipoProveedor.OptionsColumn.ReadOnly = true;
            this.colDesTipoProveedor.Width = 28;
            // 
            // colDesLugarUso
            // 
            this.colDesLugarUso.Caption = "Usado En";
            this.colDesLugarUso.FieldName = "DesLugarUso";
            this.colDesLugarUso.Name = "colDesLugarUso";
            this.colDesLugarUso.OptionsColumn.ReadOnly = true;
            this.colDesLugarUso.Visible = true;
            this.colDesLugarUso.VisibleIndex = 9;
            this.colDesLugarUso.Width = 111;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // Grupo
            // 
            this.Grupo.Caption = "Grupo";
            this.Grupo.FieldName = "Grupo";
            this.Grupo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.Grupo.Name = "Grupo";
            this.Grupo.OptionsColumn.ReadOnly = true;
            this.Grupo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Grupo.UnboundExpression = "[CodGrupo]+\' - \'+[DesGrupo]";
            this.Grupo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Grupo.Visible = true;
            this.Grupo.VisibleIndex = 11;
            this.Grupo.Width = 114;
            // 
            // TipoProveedor
            // 
            this.TipoProveedor.Caption = "Tipo Proveedor";
            this.TipoProveedor.FieldName = "TipoProveedor";
            this.TipoProveedor.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.TipoProveedor.Name = "TipoProveedor";
            this.TipoProveedor.OptionsColumn.ReadOnly = true;
            this.TipoProveedor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TipoProveedor.UnboundExpression = "[CodTipoProveedor]+\' - \'+[DesTipoProveedor]";
            this.TipoProveedor.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoProveedor.Visible = true;
            this.TipoProveedor.VisibleIndex = 12;
            this.TipoProveedor.Width = 118;
            // 
            // Obra
            // 
            this.Obra.AppearanceCell.Options.UseTextOptions = true;
            this.Obra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Obra.Caption = "Obra";
            this.Obra.FieldName = "Obra";
            this.Obra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.Obra.Name = "Obra";
            this.Obra.OptionsColumn.ReadOnly = true;
            this.Obra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Obra.UnboundExpression = "[NumeroObra]+\' - \'+[DesObra]";
            this.Obra.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Obra.Visible = true;
            this.Obra.VisibleIndex = 0;
            this.Obra.Width = 131;
            // 
            // Producto
            // 
            this.Producto.AppearanceCell.Options.UseTextOptions = true;
            this.Producto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Producto.Caption = "Producto";
            this.Producto.FieldName = "Producto";
            this.Producto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.Producto.Name = "Producto";
            this.Producto.OptionsColumn.ReadOnly = true;
            this.Producto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Producto.UnboundExpression = "[CodProductoInterno]+\' - \'+[DesProducto]";
            this.Producto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Producto.Visible = true;
            this.Producto.VisibleIndex = 3;
            this.Producto.Width = 135;
            // 
            // colTrabajador
            // 
            this.colTrabajador.Caption = "Trabajador";
            this.colTrabajador.FieldName = "Trabajador";
            this.colTrabajador.Name = "colTrabajador";
            this.colTrabajador.OptionsColumn.ReadOnly = true;
            this.colTrabajador.Visible = true;
            this.colTrabajador.VisibleIndex = 10;
            this.colTrabajador.Width = 150;
            // 
            // colFacturaRecibida
            // 
            this.colFacturaRecibida.FieldName = "FacturaRecibida";
            this.colFacturaRecibida.Name = "colFacturaRecibida";
            this.colFacturaRecibida.OptionsColumn.ReadOnly = true;
            this.colFacturaRecibida.Visible = true;
            this.colFacturaRecibida.VisibleIndex = 13;
            this.colFacturaRecibida.Width = 79;
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.OptionsColumn.ReadOnly = true;
            this.colObservaciones.Visible = true;
            this.colObservaciones.VisibleIndex = 16;
            this.colObservaciones.Width = 126;
            // 
            // Filtro
            // 
            this.Filtro.AppearanceHeader.Options.UseTextOptions = true;
            this.Filtro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Filtro.Caption = "Filtro";
            this.Filtro.FieldName = "Filtro";
            this.Filtro.Name = "Filtro";
            this.Filtro.Visible = true;
            this.Filtro.VisibleIndex = 17;
            this.Filtro.Width = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 44);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkEdit1);
            this.panel2.Controls.Add(this.cbxMes);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.cbxAno);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(423, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 44);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(370, 13);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Mostrar Todo el Año";
            this.checkEdit1.Size = new System.Drawing.Size(135, 19);
            this.checkEdit1.TabIndex = 7;
            this.checkEdit1.EditValueChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // cbxMes
            // 
            this.cbxMes.Location = new System.Drawing.Point(234, 12);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreMes", "Mes", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbxMes.Properties.DataSource = this.mesesAlbaranesBindingSource;
            this.cbxMes.Properties.DisplayMember = "NombreMes";
            this.cbxMes.Properties.ValueMember = "Mes";
            this.cbxMes.Size = new System.Drawing.Size(118, 20);
            this.cbxMes.TabIndex = 6;
            this.cbxMes.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // mesesAlbaranesBindingSource
            // 
            this.mesesAlbaranesBindingSource.DataMember = "MesesAlbaranes";
            this.mesesAlbaranesBindingSource.DataSource = this.datosAlbaranes;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mostrar Albaranes de:";
            // 
            // cbxAno
            // 
            this.cbxAno.Location = new System.Drawing.Point(150, 12);
            this.cbxAno.Name = "cbxAno";
            this.cbxAno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxAno.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ano", "Año", 42, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.cbxAno.Properties.DataSource = this.anosBindingSource;
            this.cbxAno.Properties.DisplayMember = "Ano";
            this.cbxAno.Properties.ValueMember = "Ano";
            this.cbxAno.Size = new System.Drawing.Size(78, 20);
            this.cbxAno.TabIndex = 4;
            this.cbxAno.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // anosBindingSource
            // 
            this.anosBindingSource.DataMember = "Anos";
            this.anosBindingSource.DataSource = this.datosAlbaranes;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(733, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Imprimir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton2);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(this.deFechaFin);
            this.panel3.Controls.Add(fechaAlbaranLabel);
            this.panel3.Controls.Add(this.deFechaIni);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 44);
            this.panel3.TabIndex = 10;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(331, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Mostrar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // deFechaFin
            // 
            this.deFechaFin.EditValue = null;
            this.deFechaFin.Location = new System.Drawing.Point(216, 12);
            this.deFechaFin.Name = "deFechaFin";
            this.deFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaFin.Size = new System.Drawing.Size(100, 20);
            this.deFechaFin.TabIndex = 11;
            this.deFechaFin.EditValueChanged += new System.EventHandler(this.deFechaFin_EditValueChanged);
            // 
            // deFechaIni
            // 
            this.deFechaIni.EditValue = null;
            this.deFechaIni.Location = new System.Drawing.Point(58, 12);
            this.deFechaIni.Name = "deFechaIni";
            this.deFechaIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaIni.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaIni.Size = new System.Drawing.Size(100, 20);
            this.deFechaIni.TabIndex = 10;
            this.deFechaIni.EditValueChanged += new System.EventHandler(this.deFechaIni_EditValueChanged);
            // 
            // mesesAlbaranesTableAdapter
            // 
            this.mesesAlbaranesTableAdapter.ClearBeforeFill = true;
            // 
            // anosTableAdapter
            // 
            this.anosTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelControl7);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.lbFlecha2);
            this.panel4.Controls.Add(this.lbFlecha1);
            this.panel4.Controls.Add(this.cbxProducto);
            this.panel4.Controls.Add(this.labelControl6);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.tbMultiplicador);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 636);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1541, 84);
            this.panel4.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(28, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Producto";
            // 
            // button2
            // 
            this.button2.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button2.Location = new System.Drawing.Point(455, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 21);
            this.button2.TabIndex = 69;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbFlecha2
            // 
            this.lbFlecha2.AutoSize = true;
            this.lbFlecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlecha2.Location = new System.Drawing.Point(975, 43);
            this.lbFlecha2.Name = "lbFlecha2";
            this.lbFlecha2.Size = new System.Drawing.Size(30, 24);
            this.lbFlecha2.TabIndex = 17;
            this.lbFlecha2.Text = "→";
            // 
            // lbFlecha1
            // 
            this.lbFlecha1.AutoSize = true;
            this.lbFlecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlecha1.Location = new System.Drawing.Point(840, 43);
            this.lbFlecha1.Name = "lbFlecha1";
            this.lbFlecha1.Size = new System.Drawing.Size(30, 24);
            this.lbFlecha1.TabIndex = 16;
            this.lbFlecha1.Text = "→";
            // 
            // cbxProducto
            // 
            this.cbxProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProducto.DataSource = this.vProductosConversionesBindingSource;
            this.cbxProducto.DisplayMember = "CodDesProducto";
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(28, 43);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(421, 21);
            this.cbxProducto.TabIndex = 15;
            this.cbxProducto.ValueMember = "IdProducto";
            this.cbxProducto.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // vProductosConversionesBindingSource
            // 
            this.vProductosConversionesBindingSource.DataMember = "vProductosConversiones";
            this.vProductosConversionesBindingSource.DataSource = this.datosAlbaranes;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(914, 28);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Multiplicador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.cbxUMDestino);
            this.groupBox2.Controls.Add(this.tbCantidadDestino);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Location = new System.Drawing.Point(1007, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 56);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(286, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Cantidad";
            // 
            // cbxUMDestino
            // 
            this.cbxUMDestino.DataSource = this.vUMDestinoBindingSource;
            this.cbxUMDestino.DisplayMember = "CodDesUMOrigen";
            this.cbxUMDestino.FormattingEnabled = true;
            this.cbxUMDestino.Location = new System.Drawing.Point(6, 28);
            this.cbxUMDestino.Name = "cbxUMDestino";
            this.cbxUMDestino.Size = new System.Drawing.Size(210, 21);
            this.cbxUMDestino.TabIndex = 72;
            this.cbxUMDestino.ValueMember = "IDUMDestino";
            // 
            // vUMDestinoBindingSource
            // 
            this.vUMDestinoBindingSource.DataMember = "vUMDestino";
            this.vUMDestinoBindingSource.DataSource = this.datosAlbaranes;
            // 
            // tbCantidadDestino
            // 
            this.tbCantidadDestino.Location = new System.Drawing.Point(229, 28);
            this.tbCantidadDestino.Name = "tbCantidadDestino";
            this.tbCantidadDestino.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbCantidadDestino.Properties.Appearance.Options.UseFont = true;
            this.tbCantidadDestino.Properties.Appearance.Options.UseTextOptions = true;
            this.tbCantidadDestino.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbCantidadDestino.Properties.DisplayFormat.FormatString = "N6";
            this.tbCantidadDestino.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCantidadDestino.Properties.EditFormat.FormatString = "N6";
            this.tbCantidadDestino.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCantidadDestino.Properties.Mask.EditMask = "N6";
            this.tbCantidadDestino.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbCantidadDestino.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadDestino.TabIndex = 5;
            this.tbCantidadDestino.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCantidadDestino_KeyUp);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 13);
            this.labelControl8.TabIndex = 71;
            this.labelControl8.Text = "Unidad Medida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxUMOrigen);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.tbCantidadOrigen);
            this.groupBox1.Location = new System.Drawing.Point(499, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            // 
            // cbxUMOrigen
            // 
            this.cbxUMOrigen.DataSource = this.vUMOrigenBindingSource;
            this.cbxUMOrigen.DisplayMember = "CodDesUMOrigen";
            this.cbxUMOrigen.FormattingEnabled = true;
            this.cbxUMOrigen.Location = new System.Drawing.Point(6, 28);
            this.cbxUMOrigen.Name = "cbxUMOrigen";
            this.cbxUMOrigen.Size = new System.Drawing.Size(210, 21);
            this.cbxUMOrigen.TabIndex = 70;
            this.cbxUMOrigen.ValueMember = "IdUMOrigen";
            this.cbxUMOrigen.SelectedValueChanged += new System.EventHandler(this.cbxUMOrigen_SelectedValueChanged);
            // 
            // vUMOrigenBindingSource
            // 
            this.vUMOrigenBindingSource.DataMember = "vUMOrigen";
            this.vUMOrigenBindingSource.DataSource = this.datosAlbaranes;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Unidad Medida";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(285, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Cantidad";
            // 
            // tbCantidadOrigen
            // 
            this.tbCantidadOrigen.Location = new System.Drawing.Point(228, 28);
            this.tbCantidadOrigen.Name = "tbCantidadOrigen";
            this.tbCantidadOrigen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbCantidadOrigen.Properties.Appearance.Options.UseFont = true;
            this.tbCantidadOrigen.Properties.Appearance.Options.UseTextOptions = true;
            this.tbCantidadOrigen.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbCantidadOrigen.Properties.DisplayFormat.FormatString = "N6";
            this.tbCantidadOrigen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCantidadOrigen.Properties.EditFormat.FormatString = "N6";
            this.tbCantidadOrigen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCantidadOrigen.Properties.Mask.BeepOnError = true;
            this.tbCantidadOrigen.Properties.Mask.EditMask = "n6";
            this.tbCantidadOrigen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbCantidadOrigen.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbCantidadOrigen.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadOrigen.TabIndex = 5;
            this.tbCantidadOrigen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCantidadOrigen_KeyUp);
            // 
            // tbMultiplicador
            // 
            this.tbMultiplicador.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vUMDestinoBindingSource, "Multiplicador", true));
            this.tbMultiplicador.Location = new System.Drawing.Point(873, 45);
            this.tbMultiplicador.Name = "tbMultiplicador";
            this.tbMultiplicador.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbMultiplicador.Properties.Appearance.Options.UseFont = true;
            this.tbMultiplicador.Properties.Appearance.Options.UseTextOptions = true;
            this.tbMultiplicador.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbMultiplicador.Properties.ReadOnly = true;
            this.tbMultiplicador.Size = new System.Drawing.Size(100, 20);
            this.tbMultiplicador.TabIndex = 8;
            this.tbMultiplicador.EditValueChanged += new System.EventHandler(this.tbMultiplicador_EditValueChanged);
            // 
            // vUMOrigenTableAdapter
            // 
            this.vUMOrigenTableAdapter.ClearBeforeFill = true;
            // 
            // vUMDestinoTableAdapter
            // 
            this.vUMDestinoTableAdapter.ClearBeforeFill = true;
            // 
            // vProductosConversionesTableAdapter
            // 
            this.vProductosConversionesTableAdapter.ClearBeforeFill = true;
            // 
            // colFacturaCompra
            // 
            this.colFacturaCompra.Caption = "Fra. Compra";
            this.colFacturaCompra.FieldName = "FacturaCompra";
            this.colFacturaCompra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colFacturaCompra.Name = "colFacturaCompra";
            this.colFacturaCompra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFacturaCompra.Visible = true;
            this.colFacturaCompra.VisibleIndex = 18;
            // 
            // frmRevisionAlbaranes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 720);
            this.Controls.Add(this.vRevisionAlbaranesGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "frmRevisionAlbaranes";
            this.Text = "Revisión de Albaranes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRevisionAlbaranes_FormClosing);
            this.Load += new System.EventHandler(this.frmRevisionAlbaranes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRevisionAlbaranesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRevisionAlbaranesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesAlbaranesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anosBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIni.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIni.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vProductosConversionesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vUMDestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadDestino.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vUMOrigenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultiplicador.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatosAlbaranes datosAlbaranes;
        private System.Windows.Forms.BindingSource vRevisionAlbaranesBindingSource;
        private DatosAlbaranesTableAdapters.vRevisionAlbaranesTableAdapter vRevisionAlbaranesTableAdapter;
        private DatosAlbaranesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vRevisionAlbaranesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlbaranCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colConsecutivoAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAlbaran;
        private DevExpress.XtraGrid.Columns.GridColumn colValorado;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizado;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObra;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroObra;
        private DevExpress.XtraGrid.Columns.GridColumn colDesObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProductoInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodUmedida;
        private DevExpress.XtraGrid.Columns.GridColumn colCodGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colDesGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colDesTipoProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colDesLugarUso;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn Grupo;
        private DevExpress.XtraGrid.Columns.GridColumn TipoProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn Obra;
        private DevExpress.XtraGrid.Columns.GridColumn Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaRecibida;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource mesesAlbaranesBindingSource;
        private DatosAlbaranesTableAdapters.MesesAlbaranesTableAdapter mesesAlbaranesTableAdapter;
        private System.Windows.Forms.BindingSource anosBindingSource;
        private DatosAlbaranesTableAdapters.AnosTableAdapter anosTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.DateEdit deFechaFin;
        private DevExpress.XtraEditors.DateEdit deFechaIni;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LookUpEdit cbxMes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbxAno;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbCantidadDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbCantidadOrigen;
        private DevExpress.XtraEditors.TextEdit tbMultiplicador;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lbFlecha2;
        private System.Windows.Forms.Label lbFlecha1;
        private DevExpress.XtraGrid.Columns.GridColumn Filtro;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbxUMOrigen;
        private System.Windows.Forms.ComboBox cbxUMDestino;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.BindingSource vUMOrigenBindingSource;
        private System.Windows.Forms.BindingSource vUMDestinoBindingSource;
        private DatosAlbaranesTableAdapters.vUMOrigenTableAdapter vUMOrigenTableAdapter;
        private DatosAlbaranesTableAdapters.vUMDestinoTableAdapter vUMDestinoTableAdapter;
        private System.Windows.Forms.BindingSource vProductosConversionesBindingSource;
        private DatosAlbaranesTableAdapters.vProductosConversionesTableAdapter vProductosConversionesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaCompra;
    }
}