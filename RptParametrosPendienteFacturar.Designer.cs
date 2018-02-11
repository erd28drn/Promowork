namespace Promowork
{
    partial class RptParametrosPendienteFacturar
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
            this.marcaObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.marcaTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.rdgFacturado = new DevExpress.XtraEditors.RadioGroup();
            this.marcaObrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaObrasTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.marcaTrabajadoresTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaTrabajadoresTableAdapter();
            this.empresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.chkResumen = new System.Windows.Forms.CheckBox();
            this.marcaObrasGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObraInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAgruparDescripcion = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.marcaTrabajadoresGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNITrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApeTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgFacturado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaObrasBindingSource
            // 
            this.marcaObrasBindingSource.DataMember = "MarcaObras";
            this.marcaObrasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaTrabajadoresBindingSource
            // 
            this.marcaTrabajadoresBindingSource.DataMember = "MarcaTrabajadores";
            this.marcaTrabajadoresBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(216, 14);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver Informe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(20, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(22, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rdgFacturado
            // 
            this.rdgFacturado.AutoSizeInLayoutControl = true;
            this.rdgFacturado.Location = new System.Drawing.Point(776, 12);
            this.rdgFacturado.Name = "rdgFacturado";
            this.rdgFacturado.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.rdgFacturado.Properties.Appearance.Options.UseBackColor = true;
            this.rdgFacturado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mostrar Solo Pendiente de Facturar"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mostrar Solo Facturado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mostrar Todo")});
            this.rdgFacturado.Size = new System.Drawing.Size(616, 24);
            this.rdgFacturado.TabIndex = 16;
            // 
            // marcaObrasTableAdapter
            // 
            this.marcaObrasTableAdapter.ClearBeforeFill = true;
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
            // marcaTrabajadoresTableAdapter
            // 
            this.marcaTrabajadoresTableAdapter.ClearBeforeFill = true;
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
            // chkResumen
            // 
            this.chkResumen.AutoSize = true;
            this.chkResumen.Location = new System.Drawing.Point(461, 16);
            this.chkResumen.Name = "chkResumen";
            this.chkResumen.Size = new System.Drawing.Size(109, 17);
            this.chkResumen.TabIndex = 17;
            this.chkResumen.Text = "Mostrar Resumen";
            this.chkResumen.UseVisualStyleBackColor = true;
            // 
            // marcaObrasGridControl
            // 
            this.marcaObrasGridControl.DataSource = this.marcaObrasBindingSource;
            this.marcaObrasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marcaObrasGridControl.Location = new System.Drawing.Point(0, 0);
            this.marcaObrasGridControl.MainView = this.gridView1;
            this.marcaObrasGridControl.Name = "marcaObrasGridControl";
            this.marcaObrasGridControl.Size = new System.Drawing.Size(769, 429);
            this.marcaObrasGridControl.TabIndex = 0;
            this.marcaObrasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarca,
            this.colIdEmpresa,
            this.colIdObra,
            this.colNumMatriz,
            this.colNumObra,
            this.colDesObra,
            this.colNumCliente,
            this.colDesCliente,
            this.colNumObraInt});
            this.gridView1.GridControl = this.marcaObrasGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMarca
            // 
            this.colMarca.AppearanceCell.Options.UseTextOptions = true;
            this.colMarca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMarca.Caption = " ";
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowSize = false;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 0;
            this.colMarca.Width = 20;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdObra
            // 
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsColumn.ReadOnly = true;
            // 
            // colNumMatriz
            // 
            this.colNumMatriz.AppearanceCell.Options.UseTextOptions = true;
            this.colNumMatriz.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumMatriz.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumMatriz.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumMatriz.Caption = "Matriz";
            this.colNumMatriz.FieldName = "NumMatriz";
            this.colNumMatriz.Name = "colNumMatriz";
            this.colNumMatriz.Visible = true;
            this.colNumMatriz.VisibleIndex = 1;
            this.colNumMatriz.Width = 40;
            // 
            // colNumObra
            // 
            this.colNumObra.Caption = "Nº Obra";
            this.colNumObra.FieldName = "NumObra";
            this.colNumObra.Name = "colNumObra";
            this.colNumObra.OptionsColumn.ReadOnly = true;
            this.colNumObra.Visible = true;
            this.colNumObra.VisibleIndex = 2;
            this.colNumObra.Width = 49;
            // 
            // colDesObra
            // 
            this.colDesObra.Caption = "Nombre Obra";
            this.colDesObra.FieldName = "DesObra";
            this.colDesObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesObra.Name = "colDesObra";
            this.colDesObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesObra.Visible = true;
            this.colDesObra.VisibleIndex = 3;
            this.colDesObra.Width = 208;
            // 
            // colNumCliente
            // 
            this.colNumCliente.Caption = "Nº Cliente";
            this.colNumCliente.FieldName = "NumCliente";
            this.colNumCliente.Name = "colNumCliente";
            this.colNumCliente.Visible = true;
            this.colNumCliente.VisibleIndex = 4;
            this.colNumCliente.Width = 49;
            // 
            // colDesCliente
            // 
            this.colDesCliente.Caption = "Nombre Cliente";
            this.colDesCliente.FieldName = "DesCliente";
            this.colDesCliente.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesCliente.Name = "colDesCliente";
            this.colDesCliente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesCliente.Visible = true;
            this.colDesCliente.VisibleIndex = 5;
            this.colDesCliente.Width = 235;
            // 
            // colNumObraInt
            // 
            this.colNumObraInt.FieldName = "NumObraInt";
            this.colNumObraInt.Name = "colNumObraInt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkAgruparDescripcion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 48);
            this.panel1.TabIndex = 1;
            // 
            // chkAgruparDescripcion
            // 
            this.chkAgruparDescripcion.AutoSize = true;
            this.chkAgruparDescripcion.Location = new System.Drawing.Point(586, 16);
            this.chkAgruparDescripcion.Name = "chkAgruparDescripcion";
            this.chkAgruparDescripcion.Size = new System.Drawing.Size(140, 17);
            this.chkAgruparDescripcion.TabIndex = 19;
            this.chkAgruparDescripcion.Text = "Agrupar por Descripción";
            this.chkAgruparDescripcion.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(447, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 30);
            this.panel2.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.marcaObrasGridControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox2);
            this.splitContainer1.Panel2.Controls.Add(this.marcaTrabajadoresGridControl);
            this.splitContainer1.Size = new System.Drawing.Size(1571, 429);
            this.splitContainer1.SplitterDistance = 769;
            this.splitContainer1.TabIndex = 18;
            // 
            // marcaTrabajadoresGridControl
            // 
            this.marcaTrabajadoresGridControl.DataSource = this.marcaTrabajadoresBindingSource;
            this.marcaTrabajadoresGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marcaTrabajadoresGridControl.Location = new System.Drawing.Point(0, 0);
            this.marcaTrabajadoresGridControl.MainView = this.gridView2;
            this.marcaTrabajadoresGridControl.Name = "marcaTrabajadoresGridControl";
            this.marcaTrabajadoresGridControl.Size = new System.Drawing.Size(798, 429);
            this.marcaTrabajadoresGridControl.TabIndex = 0;
            this.marcaTrabajadoresGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarca1,
            this.colIdEmpresa1,
            this.colIdTrabajador,
            this.colNumTrabajador,
            this.colDNITrabajador,
            this.colNomTrabajador,
            this.colApeTrabajador,
            this.colDesCategoria});
            this.gridView2.GridControl = this.marcaTrabajadoresGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMarca1
            // 
            this.colMarca1.Caption = " ";
            this.colMarca1.FieldName = "Marca";
            this.colMarca1.Name = "colMarca1";
            this.colMarca1.OptionsColumn.AllowSize = false;
            this.colMarca1.OptionsFilter.AllowAutoFilter = false;
            this.colMarca1.Visible = true;
            this.colMarca1.VisibleIndex = 0;
            this.colMarca1.Width = 24;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdTrabajador
            // 
            this.colIdTrabajador.FieldName = "IdTrabajador";
            this.colIdTrabajador.Name = "colIdTrabajador";
            this.colIdTrabajador.OptionsColumn.ReadOnly = true;
            // 
            // colNumTrabajador
            // 
            this.colNumTrabajador.Caption = "Nº";
            this.colNumTrabajador.FieldName = "NumTrabajador";
            this.colNumTrabajador.Name = "colNumTrabajador";
            this.colNumTrabajador.Visible = true;
            this.colNumTrabajador.VisibleIndex = 1;
            this.colNumTrabajador.Width = 34;
            // 
            // colDNITrabajador
            // 
            this.colDNITrabajador.FieldName = "DNITrabajador";
            this.colDNITrabajador.Name = "colDNITrabajador";
            // 
            // colNomTrabajador
            // 
            this.colNomTrabajador.Caption = "Nombre";
            this.colNomTrabajador.FieldName = "NomTrabajador";
            this.colNomTrabajador.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNomTrabajador.Name = "colNomTrabajador";
            this.colNomTrabajador.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNomTrabajador.Visible = true;
            this.colNomTrabajador.VisibleIndex = 2;
            this.colNomTrabajador.Width = 185;
            // 
            // colApeTrabajador
            // 
            this.colApeTrabajador.Caption = "Apellidos";
            this.colApeTrabajador.FieldName = "ApeTrabajador";
            this.colApeTrabajador.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colApeTrabajador.Name = "colApeTrabajador";
            this.colApeTrabajador.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colApeTrabajador.Visible = true;
            this.colApeTrabajador.VisibleIndex = 3;
            this.colApeTrabajador.Width = 185;
            // 
            // colDesCategoria
            // 
            this.colDesCategoria.Caption = "Categoría";
            this.colDesCategoria.FieldName = "DesCategoria";
            this.colDesCategoria.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesCategoria.Name = "colDesCategoria";
            this.colDesCategoria.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesCategoria.Visible = true;
            this.colDesCategoria.VisibleIndex = 4;
            this.colDesCategoria.Width = 195;
            // 
            // RptParametrosPendienteFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 477);
            this.Controls.Add(this.chkResumen);
            this.Controls.Add(this.rdgFacturado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "RptParametrosPendienteFacturar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendiente de Facturar";
            this.Load += new System.EventHandler(this.RptParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgFacturado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource marcaObrasBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaObrasTableAdapter marcaObrasTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource marcaTrabajadoresBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaTrabajadoresTableAdapter marcaTrabajadoresTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource empresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter empresasActualTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private DevExpress.XtraEditors.RadioGroup rdgFacturado;
        private System.Windows.Forms.CheckBox chkResumen;
        private DevExpress.XtraGrid.GridControl marcaObrasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObra;
        private DevExpress.XtraGrid.Columns.GridColumn colDesObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObraInt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl marcaTrabajadoresGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colNumTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colDNITrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colNomTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colApeTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCategoria;
        private System.Windows.Forms.CheckBox chkAgruparDescripcion;
        private System.Windows.Forms.Panel panel2;
       
    }
}