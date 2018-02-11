namespace Promowork
{
    partial class RptPresupuestoaFacturar
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
            this.PresupuestoActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PresupuestoActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.PresupuestoActualTableAdapter();
            this.EmpresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PresupuestoActualBindingSource
            // 
            this.PresupuestoActualBindingSource.DataMember = "PresupuestoActual";
            this.PresupuestoActualBindingSource.DataSource = this.Promowork_dataDataSet;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PresupuestoActualBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmpresasActualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.PresupuestoaFacturar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1167, 654);
            this.reportViewer1.TabIndex = 0;
            // 
            // PresupuestoActualTableAdapter
            // 
            this.PresupuestoActualTableAdapter.ClearBeforeFill = true;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // RptPresupuestoaFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 654);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptPresupuestoaFacturar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto Actual";
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PresupuestoActualBindingSource;
        private Promowork_dataDataSet Promowork_dataDataSet;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.PresupuestoActualTableAdapter PresupuestoActualTableAdapter;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
    }
}