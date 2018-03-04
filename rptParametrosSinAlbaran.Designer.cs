namespace Promowork
{
    partial class rptParametrosSinAlbaran
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.vAlbaranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosReportesNuevos = new Promowork.DatosReportesNuevos();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.colValido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnviado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReporte = new System.Windows.Forms.TabPage();
            this.tabResumenEnvioCorreo = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRespuesta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vAlbaranesTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.vAlbaranesTableAdapter();
            this.proveedoresSinAlbaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresSinAlbaranTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.ProveedoresSinAlbaranTableAdapter();
            this.tableAdapterManager = new Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vAlbaranesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabReporte.SuspendLayout();
            this.tabResumenEnvioCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresSinAlbaranBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vAlbaranesBindingSource
            // 
            this.vAlbaranesBindingSource.DataMember = "vAlbaranes";
            this.vAlbaranesBindingSource.DataSource = this.DatosReportesNuevos;
            // 
            // DatosReportesNuevos
            // 
            this.DatosReportesNuevos.DataSetName = "DatosReportesNuevos";
            this.DatosReportesNuevos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresasActualBindingSource
            // 
            this.EmpresasActualBindingSource.DataMember = "EmpresasActual";
            this.EmpresasActualBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // Promowork_dataDataSet
            // 
            this.Promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.Promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 11);
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
            this.button2.Location = new System.Drawing.Point(439, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Validar Proveedores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SinAlbaran";
            reportDataSource1.Value = this.vAlbaranesBindingSource;
            reportDataSource2.Name = "Empresa";
            reportDataSource2.Value = this.EmpresasActualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.rptSinAlbaran.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1063, 339);
            this.reportViewer1.TabIndex = 17;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 46);
            this.panel1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(568, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Enviar a Proveedores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReporte);
            this.tabControl1.Controls.Add(this.tabResumenEnvioCorreo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 371);
            this.tabControl1.TabIndex = 19;
            // 
            // tabReporte
            // 
            this.tabReporte.Controls.Add(this.reportViewer1);
            this.tabReporte.Location = new System.Drawing.Point(4, 22);
            this.tabReporte.Name = "tabReporte";
            this.tabReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporte.Size = new System.Drawing.Size(1069, 345);
            this.tabReporte.TabIndex = 0;
            this.tabReporte.Text = "Reporte";
            this.tabReporte.UseVisualStyleBackColor = true;
            // 
            // tabResumenEnvioCorreo
            // 
            this.tabResumenEnvioCorreo.Controls.Add(this.gridControl1);
            this.tabResumenEnvioCorreo.Location = new System.Drawing.Point(4, 22);
            this.tabResumenEnvioCorreo.Name = "tabResumenEnvioCorreo";
            this.tabResumenEnvioCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.tabResumenEnvioCorreo.Size = new System.Drawing.Size(1069, 345);
            this.tabResumenEnvioCorreo.TabIndex = 1;
            this.tabResumenEnvioCorreo.Text = "Resumen Envio Correos";
            this.tabResumenEnvioCorreo.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1063, 339);
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
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
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
            // vAlbaranesTableAdapter
            // 
            this.vAlbaranesTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresSinAlbaranBindingSource
            // 
            this.proveedoresSinAlbaranBindingSource.DataMember = "ProveedoresSinAlbaran";
            this.proveedoresSinAlbaranBindingSource.DataSource = this.DatosReportesNuevos;
            // 
            // proveedoresSinAlbaranTableAdapter
            // 
            this.proveedoresSinAlbaranTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ServidorSMTPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rptParametrosSinAlbaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 417);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rptParametrosSinAlbaran";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sin Albaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptParametrosSinAlbaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vAlbaranesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabReporte.ResumeLayout(false);
            this.tabResumenEnvioCorreo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresSinAlbaranBindingSource)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vAlbaranesBindingSource;
        private DatosReportesNuevos DatosReportesNuevos;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private Promowork_dataDataSet Promowork_dataDataSet;
        private DatosReportesNuevosTableAdapters.vAlbaranesTableAdapter vAlbaranesTableAdapter;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReporte;
        private System.Windows.Forms.TabPage tabResumenEnvioCorreo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colValido;
        private DevExpress.XtraGrid.Columns.GridColumn colEnviado;
        private DevExpress.XtraGrid.Columns.GridColumn colRespuesta;
        private System.Windows.Forms.BindingSource proveedoresSinAlbaranBindingSource;
        private DatosReportesNuevosTableAdapters.ProveedoresSinAlbaranTableAdapter proveedoresSinAlbaranTableAdapter;
        private DatosReportesNuevosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
    }
}