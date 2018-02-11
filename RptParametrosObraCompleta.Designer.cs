namespace Promowork
{
    partial class RptParametrosObraCompleta
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.marcaObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaObrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaObrasTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkRojo = new System.Windows.Forms.CheckBox();
            this.chkAzul = new System.Windows.Forms.CheckBox();
            this.chkNegro = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.marcaObrasGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumObraInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colNumMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver Informe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Solo Activas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(143, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Incluir Cobros";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // marcaObrasBindingSource
            // 
            this.marcaObrasBindingSource.DataMember = "MarcaObras";
            this.marcaObrasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // marcaObrasTableAdapter
            // 
            this.marcaObrasTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Colores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // chkRojo
            // 
            this.chkRojo.AutoSize = true;
            this.chkRojo.Checked = true;
            this.chkRojo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRojo.ForeColor = System.Drawing.Color.Red;
            this.chkRojo.Location = new System.Drawing.Point(355, 8);
            this.chkRojo.Name = "chkRojo";
            this.chkRojo.Size = new System.Drawing.Size(52, 17);
            this.chkRojo.TabIndex = 20;
            this.chkRojo.Text = "Rojo";
            this.chkRojo.UseVisualStyleBackColor = true;
            // 
            // chkAzul
            // 
            this.chkAzul.AutoSize = true;
            this.chkAzul.Checked = true;
            this.chkAzul.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAzul.ForeColor = System.Drawing.Color.Blue;
            this.chkAzul.Location = new System.Drawing.Point(355, 26);
            this.chkAzul.Name = "chkAzul";
            this.chkAzul.Size = new System.Drawing.Size(50, 17);
            this.chkAzul.TabIndex = 21;
            this.chkAzul.Text = "Azul";
            this.chkAzul.UseVisualStyleBackColor = true;
            // 
            // chkNegro
            // 
            this.chkNegro.AutoSize = true;
            this.chkNegro.Checked = true;
            this.chkNegro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNegro.Location = new System.Drawing.Point(355, 44);
            this.chkNegro.Name = "chkNegro";
            this.chkNegro.Size = new System.Drawing.Size(60, 17);
            this.chkNegro.TabIndex = 22;
            this.chkNegro.Text = "Negro";
            this.chkNegro.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(143, 34);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(170, 17);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "Incluir Previsiones de Facturas";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 43);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(10, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(88, 17);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Toda la Obra";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Enabled = false;
            this.dtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(315, 16);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(104, 20);
            this.dtFechaFin.TabIndex = 12;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Enabled = false;
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(158, 16);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(104, 20);
            this.dtFechaInicio.TabIndex = 11;
            this.dtFechaInicio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hasta:";
            // 
            // marcaObrasGridControl
            // 
            this.marcaObrasGridControl.DataSource = this.marcaObrasBindingSource;
            this.marcaObrasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marcaObrasGridControl.Location = new System.Drawing.Point(0, 136);
            this.marcaObrasGridControl.MainView = this.gridView1;
            this.marcaObrasGridControl.Name = "marcaObrasGridControl";
            this.marcaObrasGridControl.Size = new System.Drawing.Size(642, 463);
            this.marcaObrasGridControl.TabIndex = 24;
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
            this.colMarca.AppearanceHeader.Options.UseTextOptions = true;
            this.colMarca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarca.Caption = " ";
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsFilter.AllowAutoFilter = false;
            this.colMarca.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 0;
            this.colMarca.Width = 23;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // colIdObra
            // 
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsColumn.ReadOnly = true;
            // 
            // colNumObra
            // 
            this.colNumObra.Caption = "Nº. Obra";
            this.colNumObra.FieldName = "NumObra";
            this.colNumObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNumObra.Name = "colNumObra";
            this.colNumObra.OptionsColumn.ReadOnly = true;
            this.colNumObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumObra.Visible = true;
            this.colNumObra.VisibleIndex = 2;
            this.colNumObra.Width = 63;
            // 
            // colDesObra
            // 
            this.colDesObra.Caption = "Nombre Obra";
            this.colDesObra.FieldName = "DesObra";
            this.colDesObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesObra.Name = "colDesObra";
            this.colDesObra.OptionsColumn.ReadOnly = true;
            this.colDesObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesObra.Visible = true;
            this.colDesObra.VisibleIndex = 3;
            this.colDesObra.Width = 232;
            // 
            // colNumCliente
            // 
            this.colNumCliente.FieldName = "NumCliente";
            this.colNumCliente.Name = "colNumCliente";
            this.colNumCliente.OptionsColumn.ReadOnly = true;
            // 
            // colDesCliente
            // 
            this.colDesCliente.Caption = "Cliente";
            this.colDesCliente.FieldName = "DesCliente";
            this.colDesCliente.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesCliente.Name = "colDesCliente";
            this.colDesCliente.OptionsColumn.ReadOnly = true;
            this.colDesCliente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesCliente.Visible = true;
            this.colDesCliente.VisibleIndex = 4;
            this.colDesCliente.Width = 263;
            // 
            // colNumObraInt
            // 
            this.colNumObraInt.FieldName = "NumObraInt";
            this.colNumObraInt.Name = "colNumObraInt";
            this.colNumObraInt.OptionsColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 136);
            this.panel1.TabIndex = 25;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(22, 115);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(185, 17);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.Text = "Marcar/Desmarcar Todas la Obra";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 599);
            this.panel2.TabIndex = 26;
            // 
            // colNumMatriz
            // 
            this.colNumMatriz.AppearanceCell.Options.UseTextOptions = true;
            this.colNumMatriz.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumMatriz.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumMatriz.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumMatriz.Caption = "Matriz";
            this.colNumMatriz.FieldName = "NumMatriz";
            this.colNumMatriz.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNumMatriz.Name = "colNumMatriz";
            this.colNumMatriz.Visible = true;
            this.colNumMatriz.VisibleIndex = 1;
            this.colNumMatriz.Width = 43;
            // 
            // RptParametrosObraCompleta
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 599);
            this.Controls.Add(this.marcaObrasGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.chkNegro);
            this.Controls.Add(this.chkAzul);
            this.Controls.Add(this.chkRojo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RptParametrosObraCompleta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen Completo de Obra";
            this.Load += new System.EventHandler(this.RptParametrosObraCompleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource marcaObrasBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaObrasTableAdapter marcaObrasTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkRojo;
        private System.Windows.Forms.CheckBox chkAzul;
        private System.Windows.Forms.CheckBox chkNegro;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl marcaObrasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObra;
        private DevExpress.XtraGrid.Columns.GridColumn colDesObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNumObraInt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox3;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMatriz;
    }
}