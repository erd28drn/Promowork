namespace Promowork
{
    partial class frmrptSinAlbaran
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
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.vAlbaranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosReportesNuevos = new Promowork.DatosReportesNuevos();
            this.vAlbaranesTableAdapter = new Promowork.DatosReportesNuevosTableAdapters.vAlbaranesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlbaranesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1330, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
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
            // vAlbaranesTableAdapter
            // 
            this.vAlbaranesTableAdapter.ClearBeforeFill = true;
            // 
            // frmrptSinAlbaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 741);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrptSinAlbaran";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sin Albaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmrptSinAlbaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlbaranesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesNuevos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vAlbaranesBindingSource;
        private DatosReportesNuevos DatosReportesNuevos;
        private DatosReportesNuevosTableAdapters.vAlbaranesTableAdapter vAlbaranesTableAdapter;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private Promowork_dataDataSet Promowork_dataDataSet;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
    }
}