namespace Promowork
{
    partial class OperacionesBanco
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
            System.Windows.Forms.Label bancoCuentaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idConBancoLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label idFormaPagoLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoCreditoPrevisto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.operacionesBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operacionesBancoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.OperacionesBancoTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.operacionesBancoGridControl = new DevExpress.XtraGrid.GridControl();
            this.vOperacionesBancoAgrupadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebe1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdOpebanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vPrevisionesGridControl = new DevExpress.XtraGrid.GridControl();
            this.vPrevisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdOpeBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObservacionesBanco = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colObservCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteCredito1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter();
            this.bancoCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.vPrevisionesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vPrevisionesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.queriesTableAdapter1 = new Promowork.Promowork_dataDataSetTableAdapters.QueriesTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.PagosTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.saldoAnteriorTextBox = new System.Windows.Forms.TextBox();
            this.formasPagoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vOperacionesBancoAgrupadasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vOperacionesBancoAgrupadasTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtimportesel = new System.Windows.Forms.TextBox();
            this.txtsaldofinal = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbxconcepto = new System.Windows.Forms.ComboBox();
            this.conceptosBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.idFormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.formasPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conceptosBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ConceptosBancosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.chkdebito = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbCredito = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            bancoCuentaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idConBancoLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            idFormaPagoLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOperacionesBancoAgrupadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionesBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bancoCuentaLabel
            // 
            bancoCuentaLabel.AutoSize = true;
            bancoCuentaLabel.Location = new System.Drawing.Point(12, 16);
            bancoCuentaLabel.Name = "bancoCuentaLabel";
            bancoCuentaLabel.Size = new System.Drawing.Size(44, 13);
            bancoCuentaLabel.TabIndex = 5;
            bancoCuentaLabel.Text = "Cuenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(682, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 13);
            label1.TabIndex = 10;
            label1.Text = "Mostrar a partir de:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 13);
            label2.TabIndex = 13;
            label2.Text = "Fecha Banco:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(214, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 13);
            label3.TabIndex = 15;
            label3.Text = "Forma Pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(746, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 13);
            label4.TabIndex = 18;
            label4.Text = "Importe Seleccionado:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(38, 25);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 21;
            fechaLabel.Text = "Fecha:";
            // 
            // idConBancoLabel
            // 
            idConBancoLabel.AutoSize = true;
            idConBancoLabel.Location = new System.Drawing.Point(279, 25);
            idConBancoLabel.Name = "idConBancoLabel";
            idConBancoLabel.Size = new System.Drawing.Size(56, 13);
            idConBancoLabel.TabIndex = 22;
            idConBancoLabel.Text = "Concepto:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(290, 52);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 24;
            importeLabel.Text = "Importe:";
            // 
            // idFormaPagoLabel
            // 
            idFormaPagoLabel.AutoSize = true;
            idFormaPagoLabel.Location = new System.Drawing.Point(11, 52);
            idFormaPagoLabel.Name = "idFormaPagoLabel";
            idFormaPagoLabel.Size = new System.Drawing.Size(67, 13);
            idFormaPagoLabel.TabIndex = 26;
            idFormaPagoLabel.Text = "Forma Pago:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(625, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 13);
            label5.TabIndex = 31;
            label5.Text = "Anotaciones:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(476, 17);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(43, 13);
            label6.TabIndex = 32;
            label6.Text = "Crédito:";
            // 
            // colSaldo
            // 
            this.colSaldo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaldo.DisplayFormat.FormatString = "C2";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 7;
            this.colSaldo.Width = 117;
            // 
            // colSaldoCredito
            // 
            this.colSaldoCredito.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSaldoCredito.AppearanceCell.Options.UseFont = true;
            this.colSaldoCredito.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldoCredito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaldoCredito.Caption = "Saldo+Crédito";
            this.colSaldoCredito.DisplayFormat.FormatString = "C2";
            this.colSaldoCredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldoCredito.FieldName = "SaldoCredito";
            this.colSaldoCredito.Name = "colSaldoCredito";
            this.colSaldoCredito.UnboundExpression = "[Saldo]+[ImporteCredito]";
            this.colSaldoCredito.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colSaldoCredito.Visible = true;
            this.colSaldoCredito.VisibleIndex = 8;
            // 
            // colPrevision
            // 
            this.colPrevision.FieldName = "Prevision";
            this.colPrevision.Name = "colPrevision";
            this.colPrevision.OptionsColumn.AllowEdit = false;
            this.colPrevision.Width = 176;
            // 
            // Saldo
            // 
            this.Saldo.AppearanceHeader.Options.UseTextOptions = true;
            this.Saldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Saldo.DisplayFormat.FormatString = "C2";
            this.Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Saldo.FieldName = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.OptionsColumn.ReadOnly = true;
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 9;
            this.Saldo.Width = 119;
            // 
            // colSaldoCreditoPrevisto
            // 
            this.colSaldoCreditoPrevisto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSaldoCreditoPrevisto.AppearanceCell.Options.UseFont = true;
            this.colSaldoCreditoPrevisto.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldoCreditoPrevisto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaldoCreditoPrevisto.Caption = "Saldo+Crédito";
            this.colSaldoCreditoPrevisto.FieldName = "gridColumn2";
            this.colSaldoCreditoPrevisto.Name = "colSaldoCreditoPrevisto";
            this.colSaldoCreditoPrevisto.UnboundExpression = "[Saldo]+[ImporteCredito]";
            this.colSaldoCreditoPrevisto.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colSaldoCreditoPrevisto.Visible = true;
            this.colSaldoCreditoPrevisto.VisibleIndex = 10;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operacionesBancoBindingSource
            // 
            this.operacionesBancoBindingSource.DataMember = "OperacionesBanco";
            this.operacionesBancoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // operacionesBancoTableAdapter
            // 
            this.operacionesBancoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OperacionesBancoTableAdapter = this.operacionesBancoTableAdapter;
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
            // operacionesBancoGridControl
            // 
            this.operacionesBancoGridControl.DataSource = this.vOperacionesBancoAgrupadasBindingSource;
            this.operacionesBancoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operacionesBancoGridControl.Location = new System.Drawing.Point(0, 45);
            this.operacionesBancoGridControl.MainView = this.gridView1;
            this.operacionesBancoGridControl.Name = "operacionesBancoGridControl";
            this.operacionesBancoGridControl.Size = new System.Drawing.Size(1370, 305);
            this.operacionesBancoGridControl.TabIndex = 2;
            this.operacionesBancoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vOperacionesBancoAgrupadasBindingSource
            // 
            this.vOperacionesBancoAgrupadasBindingSource.DataMember = "vOperacionesBancoAgrupadas";
            this.vOperacionesBancoAgrupadasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaOpe,
            this.colFecha,
            this.colIdFormaPago1,
            this.colIdCuenta,
            this.colImporte,
            this.colSaldoAnterior,
            this.colDesOperacion,
            this.colDesFormaPago,
            this.colIdEmpresa,
            this.colDebe1,
            this.colHaber1,
            this.colSaldo,
            this.IdOpebanco,
            this.colTipoOpe,
            this.colObsBanco,
            this.colSaldoCredito,
            this.colImporteCredito});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colSaldo;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = 0D;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colSaldoCredito;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition2.Value1 = 0D;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView1.GridControl = this.operacionesBancoGridControl;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", this.colImporte, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFechaOpe
            // 
            this.colFechaOpe.FieldName = "FechaOpe";
            this.colFechaOpe.Name = "colFechaOpe";
            this.colFechaOpe.Width = 60;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 117;
            // 
            // colIdFormaPago1
            // 
            this.colIdFormaPago1.FieldName = "IdFormaPago";
            this.colIdFormaPago1.Name = "colIdFormaPago1";
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "Cuenta";
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Width = 279;
            // 
            // colImporte
            // 
            this.colImporte.Caption = "Importe";
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Width = 272;
            // 
            // colSaldoAnterior
            // 
            this.colSaldoAnterior.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldoAnterior.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaldoAnterior.FieldName = "SaldoAnterior";
            this.colSaldoAnterior.Name = "colSaldoAnterior";
            this.colSaldoAnterior.Width = 80;
            // 
            // colDesOperacion
            // 
            this.colDesOperacion.Caption = "Descripción";
            this.colDesOperacion.FieldName = "DesOperacion";
            this.colDesOperacion.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesOperacion.Name = "colDesOperacion";
            this.colDesOperacion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesOperacion.Visible = true;
            this.colDesOperacion.VisibleIndex = 2;
            this.colDesOperacion.Width = 548;
            // 
            // colDesFormaPago
            // 
            this.colDesFormaPago.Caption = "Forma Pago";
            this.colDesFormaPago.FieldName = "DesFormaPago";
            this.colDesFormaPago.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesFormaPago.Name = "colDesFormaPago";
            this.colDesFormaPago.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesFormaPago.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colDesFormaPago.Visible = true;
            this.colDesFormaPago.VisibleIndex = 4;
            this.colDesFormaPago.Width = 137;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colDebe1
            // 
            this.colDebe1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebe1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDebe1.DisplayFormat.FormatString = "C2";
            this.colDebe1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebe1.FieldName = "Debe";
            this.colDebe1.Name = "colDebe1";
            this.colDebe1.Visible = true;
            this.colDebe1.VisibleIndex = 5;
            this.colDebe1.Width = 92;
            // 
            // colHaber1
            // 
            this.colHaber1.AppearanceHeader.Options.UseTextOptions = true;
            this.colHaber1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colHaber1.DisplayFormat.FormatString = "C2";
            this.colHaber1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHaber1.FieldName = "Haber";
            this.colHaber1.Name = "colHaber1";
            this.colHaber1.Visible = true;
            this.colHaber1.VisibleIndex = 6;
            this.colHaber1.Width = 92;
            // 
            // IdOpebanco
            // 
            this.IdOpebanco.FieldName = "IdOpebanco";
            this.IdOpebanco.Name = "IdOpebanco";
            this.IdOpebanco.Width = 54;
            // 
            // colTipoOpe
            // 
            this.colTipoOpe.Caption = "Tipo";
            this.colTipoOpe.FieldName = "TipoOpe";
            this.colTipoOpe.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colTipoOpe.Name = "colTipoOpe";
            this.colTipoOpe.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTipoOpe.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colTipoOpe.Visible = true;
            this.colTipoOpe.VisibleIndex = 1;
            this.colTipoOpe.Width = 117;
            // 
            // colObsBanco
            // 
            this.colObsBanco.Caption = "Anotaciones";
            this.colObsBanco.FieldName = "ObsBanco";
            this.colObsBanco.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colObsBanco.Name = "colObsBanco";
            this.colObsBanco.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colObsBanco.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colObsBanco.Visible = true;
            this.colObsBanco.VisibleIndex = 3;
            this.colObsBanco.Width = 247;
            // 
            // colImporteCredito
            // 
            this.colImporteCredito.FieldName = "ImporteCredito";
            this.colImporteCredito.Name = "colImporteCredito";
            // 
            // vPrevisionesGridControl
            // 
            this.vPrevisionesGridControl.DataSource = this.vPrevisionesBindingSource;
            this.vPrevisionesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vPrevisionesGridControl.Location = new System.Drawing.Point(0, 44);
            this.vPrevisionesGridControl.MainView = this.gridView2;
            this.vPrevisionesGridControl.Name = "vPrevisionesGridControl";
            this.vPrevisionesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ObservacionesBanco});
            this.vPrevisionesGridControl.Size = new System.Drawing.Size(1370, 250);
            this.vPrevisionesGridControl.TabIndex = 4;
            this.vPrevisionesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // vPrevisionesBindingSource
            // 
            this.vPrevisionesBindingSource.DataMember = "vPrevisiones";
            this.vPrevisionesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha1,
            this.colDesProveedor,
            this.colFactura,
            this.colImporte1,
            this.marca,
            this.colIdEmpresa1,
            this.colIdCuenta1,
            this.colPagada,
            this.colTipo,
            this.colPrevision,
            this.colDebe,
            this.colHaber,
            this.colIdCobro1,
            this.colIdCompra1,
            this.colIdFormaPago,
            this.Saldo,
            this.IdOpeBanco1,
            this.colObsBanco1,
            this.colObservCompra,
            this.colImporteCredito1,
            this.colSaldoCreditoPrevisto});
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.LightGreen;
            styleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.LightGreen;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colPrevision;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "1";
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Column = this.Saldo;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition4.Value1 = 0D;
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.Column = this.colSaldoCreditoPrevisto;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition5.Value1 = 0D;
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5});
            this.gridView2.GridControl = this.vPrevisionesGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colFecha1
            // 
            this.colFecha1.FieldName = "Fecha";
            this.colFecha1.Name = "colFecha1";
            this.colFecha1.OptionsColumn.AllowEdit = false;
            this.colFecha1.Visible = true;
            this.colFecha1.VisibleIndex = 0;
            this.colFecha1.Width = 100;
            // 
            // colDesProveedor
            // 
            this.colDesProveedor.Caption = "Descripción";
            this.colDesProveedor.FieldName = "DesProveedor";
            this.colDesProveedor.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesProveedor.Name = "colDesProveedor";
            this.colDesProveedor.OptionsColumn.ReadOnly = true;
            this.colDesProveedor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesProveedor.Visible = true;
            this.colDesProveedor.VisibleIndex = 2;
            this.colDesProveedor.Width = 259;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colFactura.Name = "colFactura";
            this.colFactura.OptionsColumn.ReadOnly = true;
            this.colFactura.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 3;
            this.colFactura.Width = 82;
            // 
            // colImporte1
            // 
            this.colImporte1.FieldName = "Importe";
            this.colImporte1.Name = "colImporte1";
            this.colImporte1.OptionsColumn.AllowEdit = false;
            // 
            // marca
            // 
            this.marca.Caption = " ";
            this.marca.FieldName = "marca";
            this.marca.Name = "marca";
            this.marca.Visible = true;
            this.marca.VisibleIndex = 6;
            this.marca.Width = 29;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.OptionsColumn.AllowEdit = false;
            // 
            // colIdCuenta1
            // 
            this.colIdCuenta1.FieldName = "IdCuenta";
            this.colIdCuenta1.Name = "colIdCuenta1";
            this.colIdCuenta1.OptionsColumn.AllowEdit = false;
            // 
            // colPagada
            // 
            this.colPagada.FieldName = "Pagada";
            this.colPagada.Name = "colPagada";
            this.colPagada.OptionsColumn.AllowEdit = false;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.ReadOnly = true;
            this.colTipo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 100;
            // 
            // colDebe
            // 
            this.colDebe.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDebe.DisplayFormat.FormatString = "C2";
            this.colDebe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebe.FieldName = "Debe";
            this.colDebe.Name = "colDebe";
            this.colDebe.Visible = true;
            this.colDebe.VisibleIndex = 7;
            this.colDebe.Width = 87;
            // 
            // colHaber
            // 
            this.colHaber.AppearanceHeader.Options.UseTextOptions = true;
            this.colHaber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colHaber.DisplayFormat.FormatString = "C2";
            this.colHaber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHaber.FieldName = "Haber";
            this.colHaber.Name = "colHaber";
            this.colHaber.Visible = true;
            this.colHaber.VisibleIndex = 8;
            this.colHaber.Width = 98;
            // 
            // colIdCobro1
            // 
            this.colIdCobro1.FieldName = "IdCobro";
            this.colIdCobro1.Name = "colIdCobro1";
            this.colIdCobro1.OptionsColumn.AllowEdit = false;
            this.colIdCobro1.Width = 36;
            // 
            // colIdCompra1
            // 
            this.colIdCompra1.FieldName = "IdCompra";
            this.colIdCompra1.Name = "colIdCompra1";
            this.colIdCompra1.OptionsColumn.AllowEdit = false;
            this.colIdCompra1.Width = 34;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.OptionsColumn.AllowEdit = false;
            this.colIdFormaPago.Width = 139;
            // 
            // IdOpeBanco1
            // 
            this.IdOpeBanco1.FieldName = "IdOpeBanco";
            this.IdOpeBanco1.Name = "IdOpeBanco1";
            this.IdOpeBanco1.OptionsColumn.AllowEdit = false;
            this.IdOpeBanco1.Width = 35;
            // 
            // colObsBanco1
            // 
            this.colObsBanco1.Caption = "Anotaciones";
            this.colObsBanco1.ColumnEdit = this.ObservacionesBanco;
            this.colObsBanco1.FieldName = "ObsBanco";
            this.colObsBanco1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colObsBanco1.Name = "colObsBanco1";
            this.colObsBanco1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colObsBanco1.Visible = true;
            this.colObsBanco1.VisibleIndex = 4;
            this.colObsBanco1.Width = 252;
            // 
            // ObservacionesBanco
            // 
            this.ObservacionesBanco.Name = "ObservacionesBanco";
            // 
            // colObservCompra
            // 
            this.colObservCompra.Caption = "Observaciones Operación Original";
            this.colObservCompra.ColumnEdit = this.ObservacionesBanco;
            this.colObservCompra.FieldName = "ObservCompra";
            this.colObservCompra.Name = "colObservCompra";
            this.colObservCompra.Visible = true;
            this.colObservCompra.VisibleIndex = 5;
            this.colObservCompra.Width = 243;
            // 
            // colImporteCredito1
            // 
            this.colImporteCredito1.DisplayFormat.FormatString = "C2";
            this.colImporteCredito1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporteCredito1.FieldName = "ImporteCredito";
            this.colImporteCredito1.Name = "colImporteCredito1";
            // 
            // formasPagoBindingSource
            // 
            this.formasPagoBindingSource.DataMember = "FormasPago";
            this.formasPagoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // cuentasBancosBindingSource
            // 
            this.cuentasBancosBindingSource.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // cuentasBancosTableAdapter
            // 
            this.cuentasBancosTableAdapter.ClearBeforeFill = true;
            // 
            // bancoCuentaComboBox
            // 
            this.bancoCuentaComboBox.DataSource = this.cuentasBancosBindingSource;
            this.bancoCuentaComboBox.DisplayMember = "BancoCuenta";
            this.bancoCuentaComboBox.FormattingEnabled = true;
            this.bancoCuentaComboBox.Location = new System.Drawing.Point(62, 12);
            this.bancoCuentaComboBox.Name = "bancoCuentaComboBox";
            this.bancoCuentaComboBox.Size = new System.Drawing.Size(398, 21);
            this.bancoCuentaComboBox.TabIndex = 6;
            this.bancoCuentaComboBox.ValueMember = "IdCuenta";
            this.bancoCuentaComboBox.SelectedIndexChanged += new System.EventHandler(this.bancoCuentaComboBox_SelectedIndexChanged);
            // 
            // vPrevisionesTableAdapter
            // 
            this.vPrevisionesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(783, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Value = new System.DateTime(2013, 1, 11, 0, 0, 0, 0);
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataMember = "Pagos";
            this.pagosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(886, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saldoAnteriorTextBox
            // 
            this.saldoAnteriorTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.saldoAnteriorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoAnteriorTextBox.Location = new System.Drawing.Point(1268, 12);
            this.saldoAnteriorTextBox.Name = "saldoAnteriorTextBox";
            this.saldoAnteriorTextBox.ReadOnly = true;
            this.saldoAnteriorTextBox.Size = new System.Drawing.Size(100, 21);
            this.saldoAnteriorTextBox.TabIndex = 12;
            this.saldoAnteriorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saldoAnteriorTextBox.Visible = false;
            this.saldoAnteriorTextBox.TextChanged += new System.EventHandler(this.saldoAnteriorTextBox_TextChanged);
            // 
            // formasPagoTableAdapter
            // 
            this.formasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vPrevisionesBindingSource, "IdFormaPago", true));
            this.comboBox1.DataSource = this.formasPagoBindingSource;
            this.comboBox1.DisplayMember = "DesFormaPago";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "IdFormaPago";
            // 
            // vOperacionesBancoAgrupadasTableAdapter
            // 
            this.vOperacionesBancoAgrupadasTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(967, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Recalcular Saldo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1248, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtimportesel
            // 
            this.txtimportesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimportesel.Location = new System.Drawing.Point(865, 11);
            this.txtimportesel.Name = "txtimportesel";
            this.txtimportesel.ReadOnly = true;
            this.txtimportesel.Size = new System.Drawing.Size(81, 21);
            this.txtimportesel.TabIndex = 19;
            this.txtimportesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsaldofinal
            // 
            this.txtsaldofinal.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtsaldofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldofinal.Location = new System.Drawing.Point(1268, 12);
            this.txtsaldofinal.Name = "txtsaldofinal";
            this.txtsaldofinal.ReadOnly = true;
            this.txtsaldofinal.Size = new System.Drawing.Size(100, 21);
            this.txtsaldofinal.TabIndex = 21;
            this.txtsaldofinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsaldofinal.Visible = false;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(84, 21);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechaDateTimePicker.TabIndex = 22;
            // 
            // cbxconcepto
            // 
            this.cbxconcepto.DataSource = this.conceptosBancosBindingSource;
            this.cbxconcepto.DisplayMember = "Concepto";
            this.cbxconcepto.FormattingEnabled = true;
            this.cbxconcepto.Location = new System.Drawing.Point(341, 21);
            this.cbxconcepto.Name = "cbxconcepto";
            this.cbxconcepto.Size = new System.Drawing.Size(208, 21);
            this.cbxconcepto.TabIndex = 24;
            this.cbxconcepto.ValueMember = "IdConBanco";
            // 
            // conceptosBancosBindingSource
            // 
            this.conceptosBancosBindingSource.DataMember = "ConceptosBancos";
            this.conceptosBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // importeTextBox
            // 
            this.importeTextBox.Location = new System.Drawing.Point(341, 48);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTextBox.TabIndex = 25;
            this.importeTextBox.TextChanged += new System.EventHandler(this.importeTextBox_TextChanged);
            // 
            // idFormaPagoComboBox
            // 
            this.idFormaPagoComboBox.DataSource = this.formasPagoBindingSource1;
            this.idFormaPagoComboBox.DisplayMember = "DesFormaPago";
            this.idFormaPagoComboBox.FormattingEnabled = true;
            this.idFormaPagoComboBox.Location = new System.Drawing.Point(84, 48);
            this.idFormaPagoComboBox.Name = "idFormaPagoComboBox";
            this.idFormaPagoComboBox.Size = new System.Drawing.Size(171, 21);
            this.idFormaPagoComboBox.TabIndex = 27;
            this.idFormaPagoComboBox.ValueMember = "IdFormaPago";
            // 
            // formasPagoBindingSource1
            // 
            this.formasPagoBindingSource1.DataMember = "FormasPago";
            this.formasPagoBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // conceptosBancosTableAdapter
            // 
            this.conceptosBancosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.chkdebito);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.importeTextBox);
            this.groupBox1.Controls.Add(this.cbxconcepto);
            this.groupBox1.Controls.Add(idConBancoLabel);
            this.groupBox1.Controls.Add(idFormaPagoLabel);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(importeLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(this.idFormaPagoComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 86);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otras Operaciones";
            // 
            // button10
            // 
            this.button10.Image = global::Promowork.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.button10.Location = new System.Drawing.Point(552, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(22, 21);
            this.button10.TabIndex = 69;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(428, 47);
            this.textBox1.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1155, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // chkdebito
            // 
            this.chkdebito.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conceptosBancosBindingSource, "Debito", true));
            this.chkdebito.Location = new System.Drawing.Point(466, 47);
            this.chkdebito.Name = "chkdebito";
            this.chkdebito.Size = new System.Drawing.Size(19, 24);
            this.chkdebito.TabIndex = 29;
            this.chkdebito.UseVisualStyleBackColor = true;
            this.chkdebito.Visible = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(1155, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Agregar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(585, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 23);
            this.button7.TabIndex = 29;
            this.button7.Text = "Salvar Anotaciones";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(970, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 23);
            this.button8.TabIndex = 30;
            this.button8.Text = "Agregar Detallado";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1074, 11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 23);
            this.button9.TabIndex = 31;
            this.button9.Text = "Imprimir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.operacionesBancoGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.vPrevisionesGridControl);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1370, 749);
            this.splitContainerControl1.SplitterPosition = 350;
            this.splitContainerControl1.TabIndex = 32;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbCredito);
            this.panelControl1.Controls.Add(label6);
            this.panelControl1.Controls.Add(this.button9);
            this.panelControl1.Controls.Add(this.button4);
            this.panelControl1.Controls.Add(bancoCuentaLabel);
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(this.button3);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.dateTimePicker2);
            this.panelControl1.Controls.Add(this.saldoAnteriorTextBox);
            this.panelControl1.Controls.Add(this.bancoCuentaComboBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelControl1.Size = new System.Drawing.Size(1370, 45);
            this.panelControl1.TabIndex = 32;
            // 
            // tbCredito
            // 
            this.tbCredito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuentasBancosBindingSource, "ImporteCredito", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N2"));
            this.tbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCredito.Location = new System.Drawing.Point(524, 13);
            this.tbCredito.Name = "tbCredito";
            this.tbCredito.ReadOnly = true;
            this.tbCredito.Size = new System.Drawing.Size(99, 21);
            this.tbCredito.TabIndex = 33;
            this.tbCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.button8);
            this.panelControl2.Controls.Add(label2);
            this.panelControl2.Controls.Add(label3);
            this.panelControl2.Controls.Add(this.button7);
            this.panelControl2.Controls.Add(this.txtimportesel);
            this.panelControl2.Controls.Add(this.comboBox1);
            this.panelControl2.Controls.Add(label4);
            this.panelControl2.Controls.Add(this.button1);
            this.panelControl2.Controls.Add(this.dateTimePicker1);
            this.panelControl2.Controls.Add(this.txtsaldofinal);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelControl2.Size = new System.Drawing.Size(1370, 44);
            this.panelControl2.TabIndex = 31;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupBox1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 294);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelControl3.Size = new System.Drawing.Size(1370, 100);
            this.panelControl3.TabIndex = 32;
            // 
            // OperacionesBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "OperacionesBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Operaciones Banco";
            this.Load += new System.EventHandler(this.OperacionesBanco_Load);
            this.Resize += new System.EventHandler(this.OperacionesBanco_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOperacionesBancoAgrupadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionesBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource operacionesBancoBindingSource;
        private Promowork_dataDataSetTableAdapters.OperacionesBancoTableAdapter operacionesBancoTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl operacionesBancoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl vPrevisionesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource;
        private Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter cuentasBancosTableAdapter;
        private System.Windows.Forms.ComboBox bancoCuentaComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte1;
        private DevExpress.XtraGrid.Columns.GridColumn marca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colPagada;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevision;
        private System.Windows.Forms.BindingSource vPrevisionesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDebe;
        private DevExpress.XtraGrid.Columns.GridColumn colHaber;
        private Promowork_dataDataSetTableAdapters.vPrevisionesTableAdapter vPrevisionesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Promowork_dataDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private Promowork_dataDataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn IdOpeBanco1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox saldoAnteriorTextBox;
        private System.Windows.Forms.BindingSource formasPagoBindingSource;
        private Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter formasPagoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource vOperacionesBancoAgrupadasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaOpe;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colDesOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDesFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private Promowork_dataDataSetTableAdapters.vOperacionesBancoAgrupadasTableAdapter vOperacionesBancoAgrupadasTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDebe1;
        private DevExpress.XtraGrid.Columns.GridColumn colHaber1;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.Columns.GridColumn IdOpebanco;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoOpe;
        private System.Windows.Forms.TextBox txtimportesel;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private System.Windows.Forms.TextBox txtsaldofinal;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox cbxconcepto;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.ComboBox idFormaPagoComboBox;
        private System.Windows.Forms.BindingSource conceptosBancosBindingSource;
        private Promowork_dataDataSetTableAdapters.ConceptosBancosTableAdapter conceptosBancosTableAdapter;
        private System.Windows.Forms.BindingSource formasPagoBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox chkdebito;
        private System.Windows.Forms.Button button6;
        private DevExpress.XtraGrid.Columns.GridColumn colObsBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colObsBanco1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit ObservacionesBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colObservCompra;
        private System.Windows.Forms.TextBox tbCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteCredito1;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoCreditoPrevisto;
    }
}