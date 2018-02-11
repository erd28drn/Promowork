namespace Promowork
{
    partial class frmrptAgenda
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
            this.vAgendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosReportesNuevos = new Promowork.DatosReportesNuevos();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.spnAno = new DevExpress.XtraEditors.SpinEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PgReporte = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PgListado1 = new System.Windows.Forms.TabPage();
            this.vAgendaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrimestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vAgendaTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.vAgendaTableAdapter();
            this.tableAdapterManager = new Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager();
            this.vAgendaGastosGeneralesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vAgendaGastosGeneralesTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.vAgendaGastosGeneralesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vAgendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReportesNuevos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnAno.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PgReporte.SuspendLayout();
            this.PgListado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAgendaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAgendaGastosGeneralesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vAgendaBindingSource
            // 
            this.vAgendaBindingSource.DataMember = "vAgenda";
            this.vAgendaBindingSource.DataSource = this.datosReportesNuevos;
            // 
            // datosReportesNuevos
            // 
            this.datosReportesNuevos.DataSetName = "DatosReportesNuevos";
            this.datosReportesNuevos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.Controls.Add(this.spnAno);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 678);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mostrar Agenda del Año: ";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(220, 9);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(71, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // spnAno
            // 
            this.spnAno.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnAno.Location = new System.Drawing.Point(144, 11);
            this.spnAno.Name = "spnAno";
            this.spnAno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnAno.Properties.DisplayFormat.FormatString = "n0";
            this.spnAno.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnAno.Properties.EditFormat.FormatString = "n0";
            this.spnAno.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnAno.Properties.Mask.EditMask = "n0";
            this.spnAno.Size = new System.Drawing.Size(70, 20);
            this.spnAno.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PgReporte);
            this.tabControl1.Controls.Add(this.PgListado1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 631);
            this.tabControl1.TabIndex = 1;
            // 
            // PgReporte
            // 
            this.PgReporte.Controls.Add(this.reportViewer1);
            this.PgReporte.Location = new System.Drawing.Point(4, 22);
            this.PgReporte.Name = "PgReporte";
            this.PgReporte.Padding = new System.Windows.Forms.Padding(3);
            this.PgReporte.Size = new System.Drawing.Size(1161, 605);
            this.PgReporte.TabIndex = 0;
            this.PgReporte.Text = "Reporte";
            this.PgReporte.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Agenda";
            reportDataSource1.Value = this.vAgendaBindingSource;
            reportDataSource2.Name = "AgendaGastosGenerales";
            reportDataSource2.Value = this.vAgendaGastosGeneralesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.rptAgenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1155, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // PgListado1
            // 
            this.PgListado1.Controls.Add(this.vAgendaGridControl);
            this.PgListado1.Location = new System.Drawing.Point(4, 22);
            this.PgListado1.Name = "PgListado1";
            this.PgListado1.Padding = new System.Windows.Forms.Padding(3);
            this.PgListado1.Size = new System.Drawing.Size(1161, 605);
            this.PgListado1.TabIndex = 1;
            this.PgListado1.Text = "Listado";
            this.PgListado1.UseVisualStyleBackColor = true;
            // 
            // vAgendaGridControl
            // 
            this.vAgendaGridControl.DataSource = this.vAgendaBindingSource;
            this.vAgendaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vAgendaGridControl.Location = new System.Drawing.Point(3, 3);
            this.vAgendaGridControl.MainView = this.gridView1;
            this.vAgendaGridControl.Name = "vAgendaGridControl";
            this.vAgendaGridControl.Size = new System.Drawing.Size(1155, 599);
            this.vAgendaGridControl.TabIndex = 0;
            this.vAgendaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpresa,
            this.colPosicion,
            this.colTipo,
            this.colID,
            this.colNumero,
            this.colNIF,
            this.colNOMBRE,
            this.colAno,
            this.colTrimestre,
            this.colMes,
            this.colBase,
            this.colIVA,
            this.colTotal,
            this.colNomMes});
            this.gridView1.GridControl = this.vAgendaGridControl;
            this.gridView1.GroupCount = 3;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Base", this.colBase, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", this.colIVA, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", this.colTotal, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrimestre, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNomMes, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            // 
            // colPosicion
            // 
            this.colPosicion.FieldName = "Posicion";
            this.colPosicion.Name = "colPosicion";
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 0;
            this.colTipo.Width = 83;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 104;
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.Width = 104;
            // 
            // colNIF
            // 
            this.colNIF.FieldName = "NIF";
            this.colNIF.Name = "colNIF";
            this.colNIF.Width = 104;
            // 
            // colNOMBRE
            // 
            this.colNOMBRE.FieldName = "NOMBRE";
            this.colNOMBRE.Name = "colNOMBRE";
            this.colNOMBRE.Visible = true;
            this.colNOMBRE.VisibleIndex = 0;
            this.colNOMBRE.Width = 104;
            // 
            // colAno
            // 
            this.colAno.FieldName = "Ano";
            this.colAno.Name = "colAno";
            // 
            // colTrimestre
            // 
            this.colTrimestre.FieldName = "Trimestre";
            this.colTrimestre.Name = "colTrimestre";
            this.colTrimestre.Visible = true;
            this.colTrimestre.VisibleIndex = 5;
            // 
            // colMes
            // 
            this.colMes.FieldName = "Mes";
            this.colMes.Name = "colMes";
            // 
            // colBase
            // 
            this.colBase.FieldName = "Base";
            this.colBase.Name = "colBase";
            this.colBase.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colBase.Visible = true;
            this.colBase.VisibleIndex = 1;
            // 
            // colIVA
            // 
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 2;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            // 
            // colNomMes
            // 
            this.colNomMes.FieldName = "NomMes";
            this.colNomMes.Name = "colNomMes";
            this.colNomMes.Visible = true;
            this.colNomMes.VisibleIndex = 1;
            // 
            // vAgendaTableAdapter
            // 
            this.vAgendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosReportesNuevosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vAgendaGastosGeneralesBindingSource
            // 
            this.vAgendaGastosGeneralesBindingSource.DataMember = "vAgendaGastosGenerales";
            this.vAgendaGastosGeneralesBindingSource.DataSource = this.datosReportesNuevos;
            // 
            // vAgendaGastosGeneralesTableAdapter
            // 
            this.vAgendaGastosGeneralesTableAdapter.ClearBeforeFill = true;
            // 
            // frmrptAgenda
            // 
            this.AcceptButton = this.btnVer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 678);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmrptAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmrpdAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vAgendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReportesNuevos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnAno.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PgReporte.ResumeLayout(false);
            this.PgListado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vAgendaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAgendaGastosGeneralesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVer;
        private DevExpress.XtraEditors.SpinEdit spnAno;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PgListado1;
        private System.Windows.Forms.TabPage PgReporte;
        private DatosReportesNuevos datosReportesNuevos;
        private System.Windows.Forms.BindingSource vAgendaBindingSource;
        private DatosReportesNuevosTableAdapters.vAgendaTableAdapter vAgendaTableAdapter;
        private DatosReportesNuevosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vAgendaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colPosicion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colNIF;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colAno;
        private DevExpress.XtraGrid.Columns.GridColumn colTrimestre;
        private DevExpress.XtraGrid.Columns.GridColumn colMes;
        private DevExpress.XtraGrid.Columns.GridColumn colBase;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colNomMes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vAgendaGastosGeneralesBindingSource;
        private DatosReportesNuevosTableAdapters.vAgendaGastosGeneralesTableAdapter vAgendaGastosGeneralesTableAdapter;
    }
}