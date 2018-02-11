namespace Promowork
{
    partial class RptParametrosListadoFacturasEmitidas
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
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.empresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.marcaProveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NumCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.marcaClientesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaClientesTableAdapter();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkFacturas = new System.Windows.Forms.CheckBox();
            this.chkCliFactura = new System.Windows.Forms.CheckBox();
            this.chkPartes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaProveedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(212, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver Informe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Provincias1TableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.PuestosTrabajoTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaAdminTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.SeguridadSocialTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresListaTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // empresasActualBindingSource
            // 
            this.empresasActualBindingSource.DataMember = "EmpresasActual";
            this.empresasActualBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // empresasActualTableAdapter
            // 
            this.empresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // marcaProveedoresDataGridView
            // 
            this.marcaProveedoresDataGridView.AllowUserToAddRows = false;
            this.marcaProveedoresDataGridView.AllowUserToDeleteRows = false;
            this.marcaProveedoresDataGridView.AutoGenerateColumns = false;
            this.marcaProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marcaProveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.NumCliente,
            this.DesCliente});
            this.marcaProveedoresDataGridView.DataSource = this.marcaClientesBindingSource;
            this.marcaProveedoresDataGridView.Location = new System.Drawing.Point(11, 63);
            this.marcaProveedoresDataGridView.Name = "marcaProveedoresDataGridView";
            this.marcaProveedoresDataGridView.RowHeadersVisible = false;
            this.marcaProveedoresDataGridView.Size = new System.Drawing.Size(576, 319);
            this.marcaProveedoresDataGridView.TabIndex = 26;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Marca";
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 20;
            // 
            // NumCliente
            // 
            this.NumCliente.DataPropertyName = "NumCliente";
            this.NumCliente.HeaderText = "Nº";
            this.NumCliente.Name = "NumCliente";
            this.NumCliente.ReadOnly = true;
            this.NumCliente.Width = 50;
            // 
            // DesCliente
            // 
            this.DesCliente.DataPropertyName = "DesCliente";
            this.DesCliente.HeaderText = "Cliente";
            this.DesCliente.Name = "DesCliente";
            this.DesCliente.ReadOnly = true;
            this.DesCliente.Width = 480;
            // 
            // marcaClientesBindingSource
            // 
            this.marcaClientesBindingSource.DataMember = "MarcaClientes";
            this.marcaClientesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(17, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // marcaClientesTableAdapter
            // 
            this.marcaClientesTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(17, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(118, 17);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "Mostrar Previsiones";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chkFacturas
            // 
            this.chkFacturas.AutoSize = true;
            this.chkFacturas.Checked = true;
            this.chkFacturas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFacturas.Location = new System.Drawing.Point(141, 40);
            this.chkFacturas.Name = "chkFacturas";
            this.chkFacturas.Size = new System.Drawing.Size(105, 17);
            this.chkFacturas.TabIndex = 30;
            this.chkFacturas.Text = "Mostrar Facturas";
            this.chkFacturas.UseVisualStyleBackColor = true;
            // 
            // chkCliFactura
            // 
            this.chkCliFactura.AutoSize = true;
            this.chkCliFactura.Checked = true;
            this.chkCliFactura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCliFactura.Location = new System.Drawing.Point(431, 40);
            this.chkCliFactura.Name = "chkCliFactura";
            this.chkCliFactura.Size = new System.Drawing.Size(122, 17);
            this.chkCliFactura.TabIndex = 31;
            this.chkCliFactura.Text = "Usar Cliente Factura";
            this.chkCliFactura.UseVisualStyleBackColor = true;
            // 
            // chkPartes
            // 
            this.chkPartes.AutoSize = true;
            this.chkPartes.Location = new System.Drawing.Point(268, 40);
            this.chkPartes.Name = "chkPartes";
            this.chkPartes.Size = new System.Drawing.Size(144, 17);
            this.chkPartes.TabIndex = 32;
            this.chkPartes.Text = "Mostrar Partes Valorados";
            this.chkPartes.UseVisualStyleBackColor = true;
            // 
            // RptParametrosListadoFacturasEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 394);
            this.Controls.Add(this.chkPartes);
            this.Controls.Add(this.chkCliFactura);
            this.Controls.Add(this.chkFacturas);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.marcaProveedoresDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "RptParametrosListadoFacturasEmitidas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Facturas Emitidas";
            this.Load += new System.EventHandler(this.RptParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaProveedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource empresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter empresasActualTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView marcaProveedoresDataGridView;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.BindingSource marcaClientesBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaClientesTableAdapter marcaClientesTableAdapter;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chkFacturas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesCliente;
        private System.Windows.Forms.CheckBox chkCliFactura;
        private System.Windows.Forms.CheckBox chkPartes;
    }
}