namespace Promowork
{
    partial class ResultadoCruce
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.resultadoCruceTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultadoCruceTrabajadoresTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ResultadoCruceTrabajadoresTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.rbPrimeraQuincena = new System.Windows.Forms.RadioButton();
            this.rbSegundaQuincena = new System.Windows.Forms.RadioButton();
            this.rbTodoMes = new System.Windows.Forms.RadioButton();
            this.btVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoCruceTrabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // resultadoCruceTrabajadoresBindingSource
            // 
            this.resultadoCruceTrabajadoresBindingSource.DataMember = "ResultadoCruceTrabajadores";
            this.resultadoCruceTrabajadoresBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresasActualBindingSource
            // 
            this.EmpresasActualBindingSource.DataMember = "EmpresasActual";
            this.EmpresasActualBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // resultadoCruceTrabajadoresTableAdapter
            // 
            this.resultadoCruceTrabajadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccesosEmpresasTableAdapter = null;
            this.tableAdapterManager.AdjuntosObrasTableAdapter = null;
            this.tableAdapterManager.AnticiposTableAdapter = null;
            this.tableAdapterManager.AnticiposTrabajadoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajasMedicaTableAdapter = null;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosTableAdapter = null;
            this.tableAdapterManager.ComprasCabTableAdapter = null;
            this.tableAdapterManager.ComprasDetTableAdapter = null;
            this.tableAdapterManager.ConceptosBancosTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.DescuentosFacturasTableAdapter = null;
            this.tableAdapterManager.EmpresasActualTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.FabricantesTableAdapter = null;
            this.tableAdapterManager.FacturasCabListaTableAdapter = null;
            this.tableAdapterManager.FacturasCabTableAdapter = null;
            this.tableAdapterManager.FacturasDetHorasTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = null;
            this.tableAdapterManager.FestivosEmpresasTableAdapter = null;
            this.tableAdapterManager.FestivosObrasDiaTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.GruposProductosTableAdapter = null;
            this.tableAdapterManager.HijosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.HorasAdminTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadasTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadoresTableAdapter = null;
            this.tableAdapterManager.NacionesTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.OperacionesBancoTableAdapter = null;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.ParticipantesTableAdapter = null;
            this.tableAdapterManager.PartObrasTableAdapter = null;
            this.tableAdapterManager.PartPresupTableAdapter = null;
            this.tableAdapterManager.Poblaciones1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvincias1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvinciasTableAdapter = null;
            this.tableAdapterManager.PoblacionesTableAdapter = null;
            this.tableAdapterManager.PresupCabTableAdapter = null;
            this.tableAdapterManager.PresupCapTableAdapter = null;
            this.tableAdapterManager.PresupDetTableAdapter = null;
            this.tableAdapterManager.PresupSubTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProductosUtilizadosTableAdapter = null;
            this.tableAdapterManager.ProductosUtTrabajadoresTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Provincias1TableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.PuestosTrabajoTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaAdminTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.SeguridadSocialTableAdapter = null;
            this.tableAdapterManager.TiposProductosTableAdapter = null;
            this.tableAdapterManager.TiposProveedoresTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresListaTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.resultadoCruceTrabajadoresBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.EmpresasActualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.ResultadosCruce.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1195, 618);
            this.reportViewer1.TabIndex = 4;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // rbPrimeraQuincena
            // 
            this.rbPrimeraQuincena.AutoSize = true;
            this.rbPrimeraQuincena.Location = new System.Drawing.Point(16, 12);
            this.rbPrimeraQuincena.Name = "rbPrimeraQuincena";
            this.rbPrimeraQuincena.Size = new System.Drawing.Size(109, 17);
            this.rbPrimeraQuincena.TabIndex = 5;
            this.rbPrimeraQuincena.Text = "Primera Quincena";
            this.rbPrimeraQuincena.UseVisualStyleBackColor = true;
            // 
            // rbSegundaQuincena
            // 
            this.rbSegundaQuincena.AutoSize = true;
            this.rbSegundaQuincena.Location = new System.Drawing.Point(136, 12);
            this.rbSegundaQuincena.Name = "rbSegundaQuincena";
            this.rbSegundaQuincena.Size = new System.Drawing.Size(117, 17);
            this.rbSegundaQuincena.TabIndex = 6;
            this.rbSegundaQuincena.Text = "Segunda Quincena";
            this.rbSegundaQuincena.UseVisualStyleBackColor = true;
            // 
            // rbTodoMes
            // 
            this.rbTodoMes.AutoSize = true;
            this.rbTodoMes.Checked = true;
            this.rbTodoMes.Location = new System.Drawing.Point(270, 12);
            this.rbTodoMes.Name = "rbTodoMes";
            this.rbTodoMes.Size = new System.Drawing.Size(84, 17);
            this.rbTodoMes.TabIndex = 7;
            this.rbTodoMes.TabStop = true;
            this.rbTodoMes.Text = "Todo el Mes";
            this.rbTodoMes.UseVisualStyleBackColor = true;
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(376, 9);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 23);
            this.btVer.TabIndex = 8;
            this.btVer.Text = "Ver";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // ResultadoCruce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 653);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.rbTodoMes);
            this.Controls.Add(this.rbSegundaQuincena);
            this.Controls.Add(this.rbPrimeraQuincena);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ResultadoCruce";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado Cruce Trabajadores";
            this.Load += new System.EventHandler(this.ResultadoCruce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoCruceTrabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource resultadoCruceTrabajadoresBindingSource;
        private Promowork_dataDataSetTableAdapters.ResultadoCruceTrabajadoresTableAdapter resultadoCruceTrabajadoresTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
        private System.Windows.Forms.RadioButton rbPrimeraQuincena;
        private System.Windows.Forms.RadioButton rbSegundaQuincena;
        private System.Windows.Forms.RadioButton rbTodoMes;
        private System.Windows.Forms.Button btVer;

    }
}