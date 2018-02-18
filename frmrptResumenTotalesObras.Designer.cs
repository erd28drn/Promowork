namespace Promowork
{
    partial class frmrptResumenTotalesObras
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.colBeneficioFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeneficioCob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcBeneficioFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcBeneficioCob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vTotalPorObrasConCalculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosReportesNuevos = new Promowork.DatosReportesNuevos();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.spnPorciento = new DevExpress.XtraEditors.SpinEdit();
            this.cbxTipoReporte = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PgListado1 = new System.Windows.Forms.TabPage();
            this.vTotalPorObrasConCalculosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGastos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PgReporte = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vTotalPorObrasConCalculosTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.vTotalPorObrasConCalculosTableAdapter();
            this.tableAdapterManager = new Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vTotalPorObrasConCalculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPorciento.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PgListado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTotalPorObrasConCalculosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PgReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // colBeneficioFact
            // 
            this.colBeneficioFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colBeneficioFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBeneficioFact.Caption = "Benef. Previsto";
            this.colBeneficioFact.DisplayFormat.FormatString = "c2";
            this.colBeneficioFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBeneficioFact.FieldName = "BeneficioFact";
            this.colBeneficioFact.Name = "colBeneficioFact";
            this.colBeneficioFact.OptionsColumn.ReadOnly = true;
            this.colBeneficioFact.Visible = true;
            this.colBeneficioFact.VisibleIndex = 6;
            this.colBeneficioFact.Width = 54;
            // 
            // colBeneficioCob
            // 
            this.colBeneficioCob.AppearanceHeader.Options.UseTextOptions = true;
            this.colBeneficioCob.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBeneficioCob.Caption = "Benef. Real";
            this.colBeneficioCob.DisplayFormat.FormatString = "c2";
            this.colBeneficioCob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBeneficioCob.FieldName = "BeneficioCob";
            this.colBeneficioCob.Name = "colBeneficioCob";
            this.colBeneficioCob.OptionsColumn.ReadOnly = true;
            this.colBeneficioCob.Visible = true;
            this.colBeneficioCob.VisibleIndex = 9;
            this.colBeneficioCob.Width = 61;
            // 
            // colPorcBeneficioFact
            // 
            this.colPorcBeneficioFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colPorcBeneficioFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPorcBeneficioFact.Caption = "% Benef. Previsto";
            this.colPorcBeneficioFact.DisplayFormat.FormatString = "p2";
            this.colPorcBeneficioFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPorcBeneficioFact.FieldName = "PorcBeneficioFact";
            this.colPorcBeneficioFact.Name = "colPorcBeneficioFact";
            this.colPorcBeneficioFact.OptionsColumn.ReadOnly = true;
            this.colPorcBeneficioFact.Visible = true;
            this.colPorcBeneficioFact.VisibleIndex = 7;
            this.colPorcBeneficioFact.Width = 54;
            // 
            // colPorcBeneficioCob
            // 
            this.colPorcBeneficioCob.AppearanceHeader.Options.UseTextOptions = true;
            this.colPorcBeneficioCob.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPorcBeneficioCob.Caption = "% Benef. Real";
            this.colPorcBeneficioCob.DisplayFormat.FormatString = "p2";
            this.colPorcBeneficioCob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPorcBeneficioCob.FieldName = "PorcBeneficioCob";
            this.colPorcBeneficioCob.Name = "colPorcBeneficioCob";
            this.colPorcBeneficioCob.OptionsColumn.ReadOnly = true;
            this.colPorcBeneficioCob.Visible = true;
            this.colPorcBeneficioCob.VisibleIndex = 10;
            this.colPorcBeneficioCob.Width = 66;
            // 
            // colPendiente
            // 
            this.colPendiente.Caption = "Pendiente Cobro";
            this.colPendiente.DisplayFormat.FormatString = "c2";
            this.colPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPendiente.FieldName = "Pendiente";
            this.colPendiente.Name = "colPendiente";
            this.colPendiente.Visible = true;
            this.colPendiente.VisibleIndex = 11;
            this.colPendiente.Width = 58;
            // 
            // vTotalPorObrasConCalculosBindingSource
            // 
            this.vTotalPorObrasConCalculosBindingSource.DataMember = "vTotalPorObrasConCalculos";
            this.vTotalPorObrasConCalculosBindingSource.DataSource = this.DatosReportesNuevos;
            // 
            // DatosReportesNuevos
            // 
            this.DatosReportesNuevos.DataSetName = "DatosReportesNuevos";
            this.DatosReportesNuevos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnVer);
            this.splitContainer1.Panel1.Controls.Add(this.spnPorciento);
            this.splitContainer1.Panel1.Controls.Add(this.cbxTipoReporte);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 587);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mostrar Obras con: ";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(484, 9);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(71, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // spnPorciento
            // 
            this.spnPorciento.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPorciento.Location = new System.Drawing.Point(398, 10);
            this.spnPorciento.Name = "spnPorciento";
            this.spnPorciento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPorciento.Properties.DisplayFormat.FormatString = "p2";
            this.spnPorciento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPorciento.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spnPorciento.Properties.Mask.EditMask = "p";
            this.spnPorciento.Size = new System.Drawing.Size(70, 20);
            this.spnPorciento.TabIndex = 1;
            // 
            // cbxTipoReporte
            // 
            this.cbxTipoReporte.FormattingEnabled = true;
            this.cbxTipoReporte.Items.AddRange(new object[] {
            "Beneficio Previsto Menor o Igual que:",
            "Beneficio Previsto Mayor o Igual que:",
            "Beneficio Real Menor o Igual que:",
            "Beneficio Real Mayor o Igual que:",
            "Todas las Obras"});
            this.cbxTipoReporte.Location = new System.Drawing.Point(119, 10);
            this.cbxTipoReporte.Name = "cbxTipoReporte";
            this.cbxTipoReporte.Size = new System.Drawing.Size(273, 21);
            this.cbxTipoReporte.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PgListado1);
            this.tabControl1.Controls.Add(this.PgReporte);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 540);
            this.tabControl1.TabIndex = 1;
            // 
            // PgListado1
            // 
            this.PgListado1.Controls.Add(this.vTotalPorObrasConCalculosGridControl);
            this.PgListado1.Location = new System.Drawing.Point(4, 22);
            this.PgListado1.Name = "PgListado1";
            this.PgListado1.Padding = new System.Windows.Forms.Padding(3);
            this.PgListado1.Size = new System.Drawing.Size(1104, 514);
            this.PgListado1.TabIndex = 1;
            this.PgListado1.Text = "Listado";
            this.PgListado1.UseVisualStyleBackColor = true;
            // 
            // vTotalPorObrasConCalculosGridControl
            // 
            this.vTotalPorObrasConCalculosGridControl.DataSource = this.vTotalPorObrasConCalculosBindingSource;
            this.vTotalPorObrasConCalculosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vTotalPorObrasConCalculosGridControl.Location = new System.Drawing.Point(3, 3);
            this.vTotalPorObrasConCalculosGridControl.MainView = this.gridView1;
            this.vTotalPorObrasConCalculosGridControl.Name = "vTotalPorObrasConCalculosGridControl";
            this.vTotalPorObrasConCalculosGridControl.Size = new System.Drawing.Size(1098, 508);
            this.vTotalPorObrasConCalculosGridControl.TabIndex = 0;
            this.vTotalPorObrasConCalculosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdObra,
            this.colIdEmpresa,
            this.colIdCliente,
            this.colNumCliente,
            this.colDesCliente,
            this.colHoras,
            this.colCompras,
            this.colGastos,
            this.colFacturado,
            this.colCobrado,
            this.colBeneficioFact,
            this.colPorcBeneficioFact,
            this.colBeneficioCob,
            this.colPorcBeneficioCob,
            this.colObra,
            this.colUltHora,
            this.colUltCompra,
            this.colUltFactura,
            this.colUltCobro,
            this.colNumObra,
            this.colSerieObra,
            this.colPendiente});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colBeneficioFact;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colBeneficioCob;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.colPorcBeneficioFact;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Column = this.colPorcBeneficioCob;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition4.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.Column = this.colPendiente;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition5.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition6.Appearance.Options.UseForeColor = true;
            styleFormatCondition6.Column = this.colPendiente;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition6.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5,
            styleFormatCondition6});
            this.gridView1.GridControl = this.vTotalPorObrasConCalculosGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdObra
            // 
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.Name = "colIdObra";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colNumCliente
            // 
            this.colNumCliente.FieldName = "NumCliente";
            this.colNumCliente.Name = "colNumCliente";
            // 
            // colDesCliente
            // 
            this.colDesCliente.Caption = "Cliente";
            this.colDesCliente.FieldName = "DesCliente";
            this.colDesCliente.Name = "colDesCliente";
            this.colDesCliente.Visible = true;
            this.colDesCliente.VisibleIndex = 1;
            this.colDesCliente.Width = 100;
            // 
            // colHoras
            // 
            this.colHoras.AppearanceHeader.Options.UseTextOptions = true;
            this.colHoras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colHoras.DisplayFormat.FormatString = "c2";
            this.colHoras.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHoras.FieldName = "Horas";
            this.colHoras.Name = "colHoras";
            this.colHoras.OptionsColumn.ReadOnly = true;
            this.colHoras.Visible = true;
            this.colHoras.VisibleIndex = 2;
            this.colHoras.Width = 61;
            // 
            // colCompras
            // 
            this.colCompras.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCompras.DisplayFormat.FormatString = "c2";
            this.colCompras.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCompras.FieldName = "Compras";
            this.colCompras.Name = "colCompras";
            this.colCompras.OptionsColumn.ReadOnly = true;
            this.colCompras.Visible = true;
            this.colCompras.VisibleIndex = 3;
            this.colCompras.Width = 59;
            // 
            // colGastos
            // 
            this.colGastos.AppearanceHeader.Options.UseTextOptions = true;
            this.colGastos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGastos.DisplayFormat.FormatString = "c2";
            this.colGastos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGastos.FieldName = "Gastos";
            this.colGastos.Name = "colGastos";
            this.colGastos.OptionsColumn.ReadOnly = true;
            this.colGastos.Visible = true;
            this.colGastos.VisibleIndex = 4;
            this.colGastos.Width = 62;
            // 
            // colFacturado
            // 
            this.colFacturado.AppearanceHeader.Options.UseTextOptions = true;
            this.colFacturado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colFacturado.DisplayFormat.FormatString = "c2";
            this.colFacturado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFacturado.FieldName = "Facturado";
            this.colFacturado.Name = "colFacturado";
            this.colFacturado.OptionsColumn.ReadOnly = true;
            this.colFacturado.Visible = true;
            this.colFacturado.VisibleIndex = 5;
            this.colFacturado.Width = 56;
            // 
            // colCobrado
            // 
            this.colCobrado.AppearanceHeader.Options.UseTextOptions = true;
            this.colCobrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCobrado.DisplayFormat.FormatString = "c2";
            this.colCobrado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCobrado.FieldName = "Cobrado";
            this.colCobrado.Name = "colCobrado";
            this.colCobrado.OptionsColumn.ReadOnly = true;
            this.colCobrado.Visible = true;
            this.colCobrado.VisibleIndex = 8;
            this.colCobrado.Width = 54;
            // 
            // colObra
            // 
            this.colObra.FieldName = "Obra";
            this.colObra.Name = "colObra";
            this.colObra.OptionsColumn.ReadOnly = true;
            this.colObra.Visible = true;
            this.colObra.VisibleIndex = 0;
            this.colObra.Width = 134;
            // 
            // colUltHora
            // 
            this.colUltHora.AppearanceCell.Options.UseTextOptions = true;
            this.colUltHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltHora.AppearanceHeader.Options.UseTextOptions = true;
            this.colUltHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltHora.FieldName = "UltHora";
            this.colUltHora.Name = "colUltHora";
            this.colUltHora.Visible = true;
            this.colUltHora.VisibleIndex = 12;
            this.colUltHora.Width = 62;
            // 
            // colUltCompra
            // 
            this.colUltCompra.AppearanceCell.Options.UseTextOptions = true;
            this.colUltCompra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.colUltCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltCompra.FieldName = "UltCompra";
            this.colUltCompra.Name = "colUltCompra";
            this.colUltCompra.Visible = true;
            this.colUltCompra.VisibleIndex = 13;
            this.colUltCompra.Width = 66;
            // 
            // colUltFactura
            // 
            this.colUltFactura.AppearanceCell.Options.UseTextOptions = true;
            this.colUltFactura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltFactura.AppearanceHeader.Options.UseTextOptions = true;
            this.colUltFactura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltFactura.FieldName = "UltFactura";
            this.colUltFactura.Name = "colUltFactura";
            this.colUltFactura.Visible = true;
            this.colUltFactura.VisibleIndex = 14;
            this.colUltFactura.Width = 62;
            // 
            // colUltCobro
            // 
            this.colUltCobro.AppearanceCell.Options.UseTextOptions = true;
            this.colUltCobro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltCobro.AppearanceHeader.Options.UseTextOptions = true;
            this.colUltCobro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUltCobro.FieldName = "UltCobro";
            this.colUltCobro.Name = "colUltCobro";
            this.colUltCobro.Visible = true;
            this.colUltCobro.VisibleIndex = 15;
            this.colUltCobro.Width = 71;
            // 
            // colNumObra
            // 
            this.colNumObra.FieldName = "NumObra";
            this.colNumObra.Name = "colNumObra";
            // 
            // colSerieObra
            // 
            this.colSerieObra.FieldName = "SerieObra";
            this.colSerieObra.Name = "colSerieObra";
            // 
            // PgReporte
            // 
            this.PgReporte.Controls.Add(this.reportViewer1);
            this.PgReporte.Location = new System.Drawing.Point(4, 22);
            this.PgReporte.Name = "PgReporte";
            this.PgReporte.Padding = new System.Windows.Forms.Padding(3);
            this.PgReporte.Size = new System.Drawing.Size(1104, 514);
            this.PgReporte.TabIndex = 0;
            this.PgReporte.Text = "Reporte";
            this.PgReporte.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TotalesObras";
            reportDataSource1.Value = this.vTotalPorObrasConCalculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.rptBeneficiosObras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1098, 508);
            this.reportViewer1.TabIndex = 2;
            // 
            // vTotalPorObrasConCalculosTableAdapter
            // 
            this.vTotalPorObrasConCalculosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmrptResumenTotalesObras
            // 
            this.AcceptButton = this.btnVer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 587);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmrptResumenTotalesObras";
            this.Text = "Beneficios de Obras";
            this.Load += new System.EventHandler(this.frmrptResumenTotalesObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vTotalPorObrasConCalculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnPorciento.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PgListado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vTotalPorObrasConCalculosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PgReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SpinEdit spnPorciento;
        private System.Windows.Forms.ComboBox cbxTipoReporte;
        private System.Windows.Forms.BindingSource vTotalPorObrasConCalculosBindingSource;
        private DatosReportesNuevos DatosReportesNuevos;
        private DatosReportesNuevosTableAdapters.vTotalPorObrasConCalculosTableAdapter vTotalPorObrasConCalculosTableAdapter;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PgListado1;
        private System.Windows.Forms.TabPage PgReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraGrid.GridControl vTotalPorObrasConCalculosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colCompras;
        private DevExpress.XtraGrid.Columns.GridColumn colGastos;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturado;
        private DevExpress.XtraGrid.Columns.GridColumn colCobrado;
        private DevExpress.XtraGrid.Columns.GridColumn colBeneficioFact;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcBeneficioFact;
        private DevExpress.XtraGrid.Columns.GridColumn colBeneficioCob;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcBeneficioCob;
        private DevExpress.XtraGrid.Columns.GridColumn colObra;
        private DevExpress.XtraGrid.Columns.GridColumn colUltHora;
        private DevExpress.XtraGrid.Columns.GridColumn colUltCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colUltFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colUltCobro;
        private DatosReportesNuevosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObra;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieObra;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colPendiente;
    }
}