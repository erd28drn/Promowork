namespace Promowork
{
    partial class RptFichaTrabajador
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ResumenTrabajadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FichaTrabajadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resumenTrabajadorTotalMesesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResumenTrabajadorTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ResumenTrabajadorTableAdapter();
            this.EmpresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.FichaTrabajadorTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FichaTrabajadorTableAdapter();
            this.resumenTrabajadorTotalMesesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ResumenTrabajadorTotalMesesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ResumenTrabajadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FichaTrabajadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenTrabajadorTotalMesesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ResumenTrabajadorBindingSource
            // 
            this.ResumenTrabajadorBindingSource.DataMember = "ResumenTrabajador";
            this.ResumenTrabajadorBindingSource.DataSource = this.Promowork_dataDataSet;
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
            // FichaTrabajadorBindingSource
            // 
            this.FichaTrabajadorBindingSource.DataMember = "FichaTrabajador";
            this.FichaTrabajadorBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // resumenTrabajadorTotalMesesBindingSource
            // 
            this.resumenTrabajadorTotalMesesBindingSource.DataMember = "ResumenTrabajadorTotalMeses";
            this.resumenTrabajadorTotalMesesBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ResumenTrabajadorBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmpresasActualBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.FichaTrabajadorBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.resumenTrabajadorTotalMesesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.FichaTrabajador.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(989, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // ResumenTrabajadorTableAdapter
            // 
            this.ResumenTrabajadorTableAdapter.ClearBeforeFill = true;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // FichaTrabajadorTableAdapter
            // 
            this.FichaTrabajadorTableAdapter.ClearBeforeFill = true;
            // 
            // resumenTrabajadorTotalMesesTableAdapter
            // 
            this.resumenTrabajadorTotalMesesTableAdapter.ClearBeforeFill = true;
            // 
            // RptFichaTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 517);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptFichaTrabajador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ficha de Trabajador";
            ((System.ComponentModel.ISupportInitialize)(this.ResumenTrabajadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FichaTrabajadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenTrabajadorTotalMesesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ResumenTrabajadorBindingSource;
        private Promowork_dataDataSet Promowork_dataDataSet;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private System.Windows.Forms.BindingSource FichaTrabajadorBindingSource;
        private Promowork_dataDataSetTableAdapters.ResumenTrabajadorTableAdapter ResumenTrabajadorTableAdapter;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
        private Promowork_dataDataSetTableAdapters.FichaTrabajadorTableAdapter FichaTrabajadorTableAdapter;
        private System.Windows.Forms.BindingSource resumenTrabajadorTotalMesesBindingSource;
        private Promowork_dataDataSetTableAdapters.ResumenTrabajadorTotalMesesTableAdapter resumenTrabajadorTotalMesesTableAdapter;
    }
}