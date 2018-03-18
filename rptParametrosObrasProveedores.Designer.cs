namespace Promowork
{
    partial class rptParametrosObrasProveedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.colValido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnviado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosReportesNuevos = new Promowork.DatosReportesNuevos();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.EmpresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btObras = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager();
            this.tabResumenEnvioCorreo = new System.Windows.Forms.TabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tbCuerpoCorreo = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRespuesta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabReporte = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabObras = new System.Windows.Forms.TabPage();
            this.obrasGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarcaObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObraStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObraSM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ObrasTableAdapter();
            this.proveedoresComprasAlbaranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresComprasAlbaranesTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.ProveedoresComprasAlbaranesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabResumenEnvioCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuerpoCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabReporte.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabObras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresComprasAlbaranesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colValido
            // 
            this.colValido.AppearanceCell.Options.UseTextOptions = true;
            this.colValido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValido.AppearanceHeader.Options.UseTextOptions = true;
            this.colValido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValido.Caption = "E-mail Válido";
            this.colValido.FieldName = "Valido";
            this.colValido.Name = "colValido";
            this.colValido.OptionsColumn.ReadOnly = true;
            this.colValido.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colValido.Visible = true;
            this.colValido.VisibleIndex = 3;
            this.colValido.Width = 118;
            // 
            // colEnviado
            // 
            this.colEnviado.AppearanceCell.Options.UseTextOptions = true;
            this.colEnviado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEnviado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEnviado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEnviado.Caption = "Enviado";
            this.colEnviado.FieldName = "Enviado";
            this.colEnviado.Name = "colEnviado";
            this.colEnviado.OptionsColumn.ReadOnly = true;
            this.colEnviado.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colEnviado.Visible = true;
            this.colEnviado.VisibleIndex = 4;
            this.colEnviado.Width = 112;
            // 
            // ObrasBindingSource
            // 
            this.ObrasBindingSource.DataMember = "Obras";
            this.ObrasBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // Promowork_dataDataSet
            // 
            this.Promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.Promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresasActualBindingSource
            // 
            this.EmpresasActualBindingSource.DataMember = "EmpresasActual";
            this.EmpresasActualBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // DatosReportesNuevos
            // 
            this.DatosReportesNuevos.DataSetName = "DatosReportesNuevos";
            this.DatosReportesNuevos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ver Informe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desde:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cargar Proveedores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btObras);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 44);
            this.panel1.TabIndex = 18;
            // 
            // btObras
            // 
            this.btObras.Location = new System.Drawing.Point(351, 11);
            this.btObras.Name = "btObras";
            this.btObras.Size = new System.Drawing.Size(86, 23);
            this.btObras.TabIndex = 18;
            this.btObras.Text = "Cargar Obras";
            this.btObras.UseVisualStyleBackColor = true;
            this.btObras.Click += new System.EventHandler(this.btObras_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(674, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Enviar a Proveedores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ServidorSMTPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabResumenEnvioCorreo
            // 
            this.tabResumenEnvioCorreo.Controls.Add(this.splitContainerControl2);
            this.tabResumenEnvioCorreo.Location = new System.Drawing.Point(4, 22);
            this.tabResumenEnvioCorreo.Name = "tabResumenEnvioCorreo";
            this.tabResumenEnvioCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.tabResumenEnvioCorreo.Size = new System.Drawing.Size(1411, 578);
            this.tabResumenEnvioCorreo.TabIndex = 1;
            this.tabResumenEnvioCorreo.Text = "Resumen Envio Correos";
            this.tabResumenEnvioCorreo.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.tbCuerpoCorreo);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1405, 572);
            this.splitContainerControl2.SplitterPosition = 128;
            this.splitContainerControl2.TabIndex = 3;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // tbCuerpoCorreo
            // 
            this.tbCuerpoCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCuerpoCorreo.EditValue = "Aqui hay que escribir el texto del cuerpo del mensaje";
            this.tbCuerpoCorreo.Location = new System.Drawing.Point(0, 0);
            this.tbCuerpoCorreo.Name = "tbCuerpoCorreo";
            this.tbCuerpoCorreo.Size = new System.Drawing.Size(1405, 128);
            this.tbCuerpoCorreo.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1405, 439);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedor,
            this.colMarca,
            this.colProveedor,
            this.colEmail,
            this.colValido,
            this.colEnviado,
            this.colRespuesta});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colValido;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.HighPriority = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colEnviado;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = false;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "IdProveedor";
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colMarca
            // 
            this.colMarca.AppearanceCell.Options.UseTextOptions = true;
            this.colMarca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarca.AppearanceHeader.Options.UseTextOptions = true;
            this.colMarca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 0;
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.ReadOnly = true;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 1;
            this.colProveedor.Width = 518;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 316;
            // 
            // colRespuesta
            // 
            this.colRespuesta.Caption = "Resultado";
            this.colRespuesta.FieldName = "Respuesta";
            this.colRespuesta.Name = "colRespuesta";
            this.colRespuesta.OptionsColumn.ReadOnly = true;
            this.colRespuesta.Visible = true;
            this.colRespuesta.VisibleIndex = 5;
            this.colRespuesta.Width = 670;
            // 
            // tabReporte
            // 
            this.tabReporte.Controls.Add(this.reportViewer1);
            this.tabReporte.Location = new System.Drawing.Point(4, 22);
            this.tabReporte.Name = "tabReporte";
            this.tabReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporte.Size = new System.Drawing.Size(1411, 578);
            this.tabReporte.TabIndex = 0;
            this.tabReporte.Text = "Reporte";
            this.tabReporte.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.ObrasBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.EmpresasActualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.ListadoObras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1405, 572);
            this.reportViewer1.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabObras);
            this.tabControl1.Controls.Add(this.tabReporte);
            this.tabControl1.Controls.Add(this.tabResumenEnvioCorreo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1419, 607);
            this.tabControl1.TabIndex = 19;
            // 
            // tabObras
            // 
            this.tabObras.Controls.Add(this.obrasGridControl);
            this.tabObras.Location = new System.Drawing.Point(4, 22);
            this.tabObras.Name = "tabObras";
            this.tabObras.Size = new System.Drawing.Size(1411, 581);
            this.tabObras.TabIndex = 2;
            this.tabObras.Text = "Obras para Enviar";
            this.tabObras.UseVisualStyleBackColor = true;
            // 
            // obrasGridControl
            // 
            this.obrasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obrasGridControl.Location = new System.Drawing.Point(0, 0);
            this.obrasGridControl.MainView = this.gridView2;
            this.obrasGridControl.Name = "obrasGridControl";
            this.obrasGridControl.Size = new System.Drawing.Size(1411, 581);
            this.obrasGridControl.TabIndex = 2;
            this.obrasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarcaObra,
            this.colIdObra,
            this.colMatriz,
            this.colNumObra,
            this.colNumObraStr,
            this.colDesObra,
            this.colObra,
            this.colObraSM});
            this.gridView2.GridControl = this.obrasGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMarcaObra
            // 
            this.colMarcaObra.AppearanceCell.Options.UseTextOptions = true;
            this.colMarcaObra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarcaObra.AppearanceHeader.Options.UseTextOptions = true;
            this.colMarcaObra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarcaObra.Caption = "Marca";
            this.colMarcaObra.FieldName = "Marca";
            this.colMarcaObra.Name = "colMarcaObra";
            this.colMarcaObra.Visible = true;
            this.colMarcaObra.VisibleIndex = 0;
            this.colMarcaObra.Width = 34;
            // 
            // colIdObra
            // 
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.Name = "colIdObra";
            // 
            // colMatriz
            // 
            this.colMatriz.Caption = "Matriz";
            this.colMatriz.FieldName = "Matriz";
            this.colMatriz.Name = "colMatriz";
            this.colMatriz.Visible = true;
            this.colMatriz.VisibleIndex = 1;
            this.colMatriz.Width = 38;
            // 
            // colNumObra
            // 
            this.colNumObra.Caption = "Numero";
            this.colNumObra.FieldName = "NumObra";
            this.colNumObra.Name = "colNumObra";
            this.colNumObra.Width = 62;
            // 
            // colNumObraStr
            // 
            this.colNumObraStr.Caption = "Número";
            this.colNumObraStr.FieldName = "NumObraStr";
            this.colNumObraStr.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNumObraStr.Name = "colNumObraStr";
            this.colNumObraStr.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumObraStr.Visible = true;
            this.colNumObraStr.VisibleIndex = 2;
            this.colNumObraStr.Width = 53;
            // 
            // colDesObra
            // 
            this.colDesObra.Caption = "Descripción";
            this.colDesObra.FieldName = "DesObra";
            this.colDesObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesObra.Name = "colDesObra";
            this.colDesObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesObra.Visible = true;
            this.colDesObra.VisibleIndex = 3;
            this.colDesObra.Width = 415;
            // 
            // colObra
            // 
            this.colObra.FieldName = "MatrizNumeroDescripcion";
            this.colObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colObra.Name = "colObra";
            this.colObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colObraSM
            // 
            this.colObraSM.FieldName = "NumeroDescripcion";
            this.colObraSM.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colObraSM.Name = "colObraSM";
            this.colObraSM.OptionsColumn.ReadOnly = true;
            this.colObraSM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // ObrasTableAdapter
            // 
            this.ObrasTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresComprasAlbaranesBindingSource
            // 
            this.proveedoresComprasAlbaranesBindingSource.DataMember = "ProveedoresComprasAlbaranes";
            this.proveedoresComprasAlbaranesBindingSource.DataSource = this.DatosReportesNuevos;
            // 
            // proveedoresComprasAlbaranesTableAdapter
            // 
            this.proveedoresComprasAlbaranesTableAdapter.ClearBeforeFill = true;
            // 
            // rptParametrosObrasProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 651);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "rptParametrosObrasProveedores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Enviar Obras a Provedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptParametrosSinAlbaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabResumenEnvioCorreo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCuerpoCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabReporte.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabObras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.obrasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresComprasAlbaranesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private DatosReportesNuevos DatosReportesNuevos;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private Promowork_dataDataSet Promowork_dataDataSet;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DatosReportesNuevosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabResumenEnvioCorreo;
        private System.Windows.Forms.TabPage tabReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource ObrasBindingSource;
        private Promowork_dataDataSetTableAdapters.ObrasTableAdapter ObrasTableAdapter;
        private System.Windows.Forms.Button btObras;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.MemoEdit tbCuerpoCorreo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colValido;
        private DevExpress.XtraGrid.Columns.GridColumn colEnviado;
        private DevExpress.XtraGrid.Columns.GridColumn colRespuesta;
        private System.Windows.Forms.TabPage tabObras;
        private DevExpress.XtraGrid.GridControl obrasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObraStr;
        private DevExpress.XtraGrid.Columns.GridColumn colDesObra;
        private DevExpress.XtraGrid.Columns.GridColumn colObra;
        private DevExpress.XtraGrid.Columns.GridColumn colObraSM;
        private System.Windows.Forms.BindingSource proveedoresComprasAlbaranesBindingSource;
        private DatosReportesNuevosTableAdapters.ProveedoresComprasAlbaranesTableAdapter proveedoresComprasAlbaranesTableAdapter;
    }
}