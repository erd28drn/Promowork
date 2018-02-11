namespace Promowork
{
    partial class RptDiferenciasLitros
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Promowork_dataDataSetCombustible = new Promowork.Promowork_dataDataSetCombustible();
            this.DiferenciasLitrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiferenciasLitrosTableAdapter = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.DiferenciasLitrosTableAdapter();
            this.EmpresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpresasTableAdapter = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.EmpresasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiferenciasLitrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DiferenciasLitrosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmpresasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.DiferenciasLitros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(923, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // Promowork_dataDataSetCombustible
            // 
            this.Promowork_dataDataSetCombustible.DataSetName = "Promowork_dataDataSetCombustible";
            this.Promowork_dataDataSetCombustible.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DiferenciasLitrosBindingSource
            // 
            this.DiferenciasLitrosBindingSource.DataMember = "DiferenciasLitros";
            this.DiferenciasLitrosBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // DiferenciasLitrosTableAdapter
            // 
            this.DiferenciasLitrosTableAdapter.ClearBeforeFill = true;
            // 
            // EmpresasBindingSource
            // 
            this.EmpresasBindingSource.DataMember = "Empresas";
            this.EmpresasBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // EmpresasTableAdapter
            // 
            this.EmpresasTableAdapter.ClearBeforeFill = true;
            // 
            // RptDiferenciasLitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 406);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptDiferenciasLitros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diferencias de Combustible";
            this.Load += new System.EventHandler(this.RptDiferenciasLitros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiferenciasLitrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DiferenciasLitrosBindingSource;
        private Promowork_dataDataSetCombustible Promowork_dataDataSetCombustible;
        private System.Windows.Forms.BindingSource EmpresasBindingSource;
        private Promowork_dataDataSetCombustibleTableAdapters.DiferenciasLitrosTableAdapter DiferenciasLitrosTableAdapter;
        private Promowork_dataDataSetCombustibleTableAdapters.EmpresasTableAdapter EmpresasTableAdapter;
    }
}