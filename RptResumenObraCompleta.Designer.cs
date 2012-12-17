namespace Promowork
{
    partial class RptResumenObraCompleta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ResumenObraCompletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resumenObraCompletaTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResumenObraCompletaTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ResumenObraCompletaTableAdapter();
            this.EmpresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.resumenObraCompletaTotalTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ResumenObraCompletaTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ResumenObraCompletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenObraCompletaTotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ResumenObraCompletaBindingSource
            // 
            this.ResumenObraCompletaBindingSource.DataMember = "ResumenObraCompleta";
            this.ResumenObraCompletaBindingSource.DataSource = this.Promowork_dataDataSet;
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
            // resumenObraCompletaTotalBindingSource
            // 
            this.resumenObraCompletaTotalBindingSource.DataMember = "ResumenObraCompletaTotal";
            this.resumenObraCompletaTotalBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.ResumenObraCompletaBindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.EmpresasActualBindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.resumenObraCompletaTotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.ResumenObraCompleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1028, 585);
            this.reportViewer1.TabIndex = 0;
            // 
            // ResumenObraCompletaTableAdapter
            // 
            this.ResumenObraCompletaTableAdapter.ClearBeforeFill = true;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // resumenObraCompletaTotalTableAdapter
            // 
            this.resumenObraCompletaTotalTableAdapter.ClearBeforeFill = true;
            // 
            // RptResumenObraCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 585);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptResumenObraCompleta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Resumen Completo de Obra";
            ((System.ComponentModel.ISupportInitialize)(this.ResumenObraCompletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenObraCompletaTotalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ResumenObraCompletaBindingSource;
        private Promowork_dataDataSet Promowork_dataDataSet;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.ResumenObraCompletaTableAdapter ResumenObraCompletaTableAdapter;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
        private System.Windows.Forms.BindingSource resumenObraCompletaTotalBindingSource;
        private Promowork_dataDataSetTableAdapters.ResumenObraCompletaTotalTableAdapter resumenObraCompletaTotalTableAdapter;
    }
}