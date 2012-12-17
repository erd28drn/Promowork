namespace Promowork
{
    partial class RptResumenConsumoCombustible
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
            this.ConsumosCombustibleVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSetCombustible = new Promowork.Promowork_dataDataSetCombustible();
            this.EmpresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsumosCombustibleVehiculosTableAdapter = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.ConsumosCombustibleVehiculosTableAdapter();
            this.EmpresasTableAdapter = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.EmpresasTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumosCombustibleVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsumosCombustibleVehiculosBindingSource
            // 
            this.ConsumosCombustibleVehiculosBindingSource.DataMember = "ConsumosCombustibleVehiculos";
            this.ConsumosCombustibleVehiculosBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // Promowork_dataDataSetCombustible
            // 
            this.Promowork_dataDataSetCombustible.DataSetName = "Promowork_dataDataSetCombustible";
            this.Promowork_dataDataSetCombustible.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresasBindingSource
            // 
            this.EmpresasBindingSource.DataMember = "Empresas";
            this.EmpresasBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ConsumosCombustibleVehiculosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmpresasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.ResumenConsumoCombustible.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1083, 512);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConsumosCombustibleVehiculosTableAdapter
            // 
            this.ConsumosCombustibleVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // EmpresasTableAdapter
            // 
            this.EmpresasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumosVehiculosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = this.EmpresasTableAdapter;
            this.tableAdapterManager.EntradasCombustibleCabTableAdapter = null;
            this.tableAdapterManager.EntradasCombustibleDetTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.ServiciosVehiculosTableAdapter = null;
            this.tableAdapterManager.TiposServiciosTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // RptResumenConsumoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 512);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptResumenConsumoCombustible";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen Consumo Combustible";
            ((System.ComponentModel.ISupportInitialize)(this.ConsumosCombustibleVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsumosCombustibleVehiculosBindingSource;
        private Promowork_dataDataSetCombustible Promowork_dataDataSetCombustible;
        private System.Windows.Forms.BindingSource EmpresasBindingSource;
        private Promowork_dataDataSetCombustibleTableAdapters.ConsumosCombustibleVehiculosTableAdapter ConsumosCombustibleVehiculosTableAdapter;
        private Promowork_dataDataSetCombustibleTableAdapters.EmpresasTableAdapter EmpresasTableAdapter;
        private Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager tableAdapterManager;
    }
}