namespace Promowork
{
    partial class RptFacturasManualImp
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
            this.FacturasDetImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.empresasPoblacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasCabImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturasDetImpTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FacturasDetImpTableAdapter();
            this.FacturasCabImpTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FacturasCabImpTableAdapter();
            this.empresasPoblacion = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasPoblacion();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasPoblacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasCabImpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturasDetImpBindingSource
            // 
            this.FacturasDetImpBindingSource.DataMember = "FacturasDetImp";
            this.FacturasDetImpBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // Promowork_dataDataSet
            // 
            this.Promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.Promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasPoblacionBindingSource
            // 
            this.empresasPoblacionBindingSource.DataMember = "EmpresasPoblacion";
            this.empresasPoblacionBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // FacturasCabImpBindingSource
            // 
            this.FacturasCabImpBindingSource.DataMember = "FacturasCabImp";
            this.FacturasCabImpBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturasDetImpBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.empresasPoblacionBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.FacturasCabImpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.FacturaManualImp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1167, 654);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturasDetImpTableAdapter
            // 
            this.FacturasDetImpTableAdapter.ClearBeforeFill = true;
            // 
            // FacturasCabImpTableAdapter
            // 
            this.FacturasCabImpTableAdapter.ClearBeforeFill = true;
            // 
            // empresasPoblacion
            // 
            this.empresasPoblacion.ClearBeforeFill = true;
            // 
            // RptFacturasManualImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 654);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptFacturasManualImp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto Actual";
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasPoblacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasCabImpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Promowork_dataDataSet Promowork_dataDataSet;
        private System.Windows.Forms.BindingSource FacturasDetImpBindingSource;
        private System.Windows.Forms.BindingSource FacturasCabImpBindingSource;
        private Promowork_dataDataSetTableAdapters.FacturasDetImpTableAdapter FacturasDetImpTableAdapter;
        private Promowork_dataDataSetTableAdapters.FacturasCabImpTableAdapter FacturasCabImpTableAdapter;
        private System.Windows.Forms.BindingSource empresasPoblacionBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasPoblacion empresasPoblacion;
    }
}