namespace Promowork
{
    partial class Cobros
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
            System.Windows.Forms.Label copiaFacturaLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label facturaLabel;
            System.Windows.Forms.Label idFactCabLabel;
            System.Windows.Forms.Label observLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label impIVALabel;
            System.Windows.Forms.Label impBaseLabel;
            System.Windows.Forms.Label fechaVctoLabel;
            System.Windows.Forms.Label fechaAbonoLabel;
            System.Windows.Forms.Label fechaRecLabel;
            System.Windows.Forms.Label fechaExpLabel;
            System.Windows.Forms.Label idObraLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idCuentaLabel;
            System.Windows.Forms.Label idFormaPagoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobros));
            this.Cliente = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Obra = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.FormaPago = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Cuenta = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.cobrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobrosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CobrosTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.cobrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cobrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.formasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formasPagoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter();
            this.cuentasBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter();
            this.clientesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ClientesTableAdapter();
            this.obrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ObrasTableAdapter();
            this.formasPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasBancosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.obrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKObrasClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facturasCabListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasCabListaTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FacturasCabListaTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.queriesTableAdapter1 = new Promowork.Promowork_dataDataSetTableAdapters.QueriesTableAdapter();
            this.cobrosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAbono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObserv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Clientes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.fKObrasClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.previsionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.idFormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.idCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.copiaFacturaTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idObraComboBox = new System.Windows.Forms.ComboBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.fechaExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaRecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.facturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaAbonoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idFactCabComboBox = new System.Windows.Forms.ComboBox();
            this.fechaVctoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observTextBox = new System.Windows.Forms.TextBox();
            this.impBaseTextBox = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.impIVATextBox = new System.Windows.Forms.TextBox();
            copiaFacturaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            facturaLabel = new System.Windows.Forms.Label();
            idFactCabLabel = new System.Windows.Forms.Label();
            observLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            impIVALabel = new System.Windows.Forms.Label();
            impBaseLabel = new System.Windows.Forms.Label();
            fechaVctoLabel = new System.Windows.Forms.Label();
            fechaAbonoLabel = new System.Windows.Forms.Label();
            fechaRecLabel = new System.Windows.Forms.Label();
            fechaExpLabel = new System.Windows.Forms.Label();
            idObraLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idCuentaLabel = new System.Windows.Forms.Label();
            idFormaPagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingNavigator)).BeginInit();
            this.cobrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKObrasClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKObrasClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previsionCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // copiaFacturaLabel
            // 
            copiaFacturaLabel.AutoSize = true;
            copiaFacturaLabel.Location = new System.Drawing.Point(35, 181);
            copiaFacturaLabel.Name = "copiaFacturaLabel";
            copiaFacturaLabel.Size = new System.Drawing.Size(76, 13);
            copiaFacturaLabel.TabIndex = 79;
            copiaFacturaLabel.Text = "Copia Factura:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(894, 72);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 73;
            totalLabel.Text = "Total:";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(247, 155);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(79, 13);
            fechaFacturaLabel.TabIndex = 70;
            fechaFacturaLabel.Text = "Fecha Factura:";
            // 
            // facturaLabel
            // 
            facturaLabel.AutoSize = true;
            facturaLabel.Location = new System.Drawing.Point(66, 155);
            facturaLabel.Name = "facturaLabel";
            facturaLabel.Size = new System.Drawing.Size(46, 13);
            facturaLabel.TabIndex = 68;
            facturaLabel.Text = "Factura:";
            // 
            // idFactCabLabel
            // 
            idFactCabLabel.AutoSize = true;
            idFactCabLabel.Location = new System.Drawing.Point(26, 128);
            idFactCabLabel.Name = "idFactCabLabel";
            idFactCabLabel.Size = new System.Drawing.Size(86, 13);
            idFactCabLabel.TabIndex = 67;
            idFactCabLabel.Text = "Factura Sistema:";
            // 
            // observLabel
            // 
            observLabel.AutoSize = true;
            observLabel.Location = new System.Drawing.Point(727, 119);
            observLabel.Name = "observLabel";
            observLabel.Size = new System.Drawing.Size(81, 13);
            observLabel.TabIndex = 65;
            observLabel.Text = "Observaciones:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(534, 19);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(65, 13);
            referenciaLabel.TabIndex = 63;
            referenciaLabel.Text = "Documento:";
            // 
            // impIVALabel
            // 
            impIVALabel.AutoSize = true;
            impIVALabel.Location = new System.Drawing.Point(862, 46);
            impIVALabel.Name = "impIVALabel";
            impIVALabel.Size = new System.Drawing.Size(65, 13);
            impIVALabel.TabIndex = 61;
            impIVALabel.Text = "Importe IVA:";
            // 
            // impBaseLabel
            // 
            impBaseLabel.AutoSize = true;
            impBaseLabel.Location = new System.Drawing.Point(846, 19);
            impBaseLabel.Name = "impBaseLabel";
            impBaseLabel.Size = new System.Drawing.Size(82, 13);
            impBaseLabel.TabIndex = 59;
            impBaseLabel.Text = "Importe Base(*):";
            // 
            // fechaVctoLabel
            // 
            fechaVctoLabel.AutoSize = true;
            fechaVctoLabel.Location = new System.Drawing.Point(498, 129);
            fechaVctoLabel.Name = "fechaVctoLabel";
            fechaVctoLabel.Size = new System.Drawing.Size(101, 13);
            fechaVctoLabel.TabIndex = 57;
            fechaVctoLabel.Text = "Fecha Vencimiento:";
            // 
            // fechaAbonoLabel
            // 
            fechaAbonoLabel.AutoSize = true;
            fechaAbonoLabel.Location = new System.Drawing.Point(525, 102);
            fechaAbonoLabel.Name = "fechaAbonoLabel";
            fechaAbonoLabel.Size = new System.Drawing.Size(74, 13);
            fechaAbonoLabel.TabIndex = 55;
            fechaAbonoLabel.Text = "Fecha Abono:";
            // 
            // fechaRecLabel
            // 
            fechaRecLabel.AutoSize = true;
            fechaRecLabel.Location = new System.Drawing.Point(514, 75);
            fechaRecLabel.Name = "fechaRecLabel";
            fechaRecLabel.Size = new System.Drawing.Size(85, 13);
            fechaRecLabel.TabIndex = 53;
            fechaRecLabel.Text = "Fecha Recibido:";
            // 
            // fechaExpLabel
            // 
            fechaExpLabel.AutoSize = true;
            fechaExpLabel.Location = new System.Drawing.Point(504, 48);
            fechaExpLabel.Name = "fechaExpLabel";
            fechaExpLabel.Size = new System.Drawing.Size(95, 13);
            fechaExpLabel.TabIndex = 51;
            fechaExpLabel.Text = "Fecha Expedición:";
            // 
            // idObraLabel
            // 
            idObraLabel.AutoSize = true;
            idObraLabel.Location = new System.Drawing.Point(79, 101);
            idObraLabel.Name = "idObraLabel";
            idObraLabel.Size = new System.Drawing.Size(33, 13);
            idObraLabel.TabIndex = 49;
            idObraLabel.Text = "Obra:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(61, 74);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(52, 13);
            idClienteLabel.TabIndex = 47;
            idClienteLabel.Text = "Cliente(*):";
            // 
            // idCuentaLabel
            // 
            idCuentaLabel.AutoSize = true;
            idCuentaLabel.Location = new System.Drawing.Point(59, 47);
            idCuentaLabel.Name = "idCuentaLabel";
            idCuentaLabel.Size = new System.Drawing.Size(54, 13);
            idCuentaLabel.TabIndex = 45;
            idCuentaLabel.Text = "Cuenta(*):";
            // 
            // idFormaPagoLabel
            // 
            idFormaPagoLabel.AutoSize = true;
            idFormaPagoLabel.Location = new System.Drawing.Point(36, 20);
            idFormaPagoLabel.Name = "idFormaPagoLabel";
            idFormaPagoLabel.Size = new System.Drawing.Size(77, 13);
            idFormaPagoLabel.TabIndex = 43;
            idFormaPagoLabel.Text = "Forma Pago(*):";
            // 
            // Cliente
            // 
            this.Cliente.AutoHeight = false;
            this.Cliente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cliente.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesCliente", "Cliente", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Cliente.DisplayMember = "DesCliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ValueMember = "IdCliente";
            // 
            // Obra
            // 
            this.Obra.AutoHeight = false;
            this.Obra.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Obra.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Obra", "Obra", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Obra.DisplayMember = "Obra";
            this.Obra.Name = "Obra";
            this.Obra.NullText = "";
            this.Obra.ValueMember = "IdObra";
            // 
            // FormaPago
            // 
            this.FormaPago.AutoHeight = false;
            this.FormaPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FormaPago.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesFormaPago", "Des Forma Pago", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.FormaPago.DisplayMember = "DesFormaPago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ValueMember = "IdFormaPago";
            // 
            // Cuenta
            // 
            this.Cuenta.AutoHeight = false;
            this.Cuenta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cuenta.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CuentaBanco", "Cuenta Banco", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Cuenta.DisplayMember = "CuentaBanco";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ValueMember = "IdCuenta";
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobrosBindingSource
            // 
            this.cobrosBindingSource.DataMember = "Cobros";
            this.cobrosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // cobrosTableAdapter
            // 
            this.cobrosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CobrosTableAdapter = this.cobrosTableAdapter;
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
            // cobrosBindingNavigator
            // 
            this.cobrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cobrosBindingNavigator.BindingSource = this.cobrosBindingSource;
            this.cobrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cobrosBindingNavigator.DeleteItem = null;
            this.cobrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.cobrosBindingNavigatorSaveItem});
            this.cobrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cobrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cobrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cobrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cobrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cobrosBindingNavigator.Name = "cobrosBindingNavigator";
            this.cobrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cobrosBindingNavigator.Size = new System.Drawing.Size(1191, 25);
            this.cobrosBindingNavigator.TabIndex = 0;
            this.cobrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // cobrosBindingNavigatorSaveItem
            // 
            this.cobrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cobrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cobrosBindingNavigatorSaveItem.Image")));
            this.cobrosBindingNavigatorSaveItem.Name = "cobrosBindingNavigatorSaveItem";
            this.cobrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cobrosBindingNavigatorSaveItem.Text = "Save Data";
            this.cobrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cobrosBindingNavigatorSaveItem_Click);
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
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // formasPagoTableAdapter
            // 
            this.formasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // cuentasBancosTableAdapter
            // 
            this.cuentasBancosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // formasPagoBindingSource1
            // 
            this.formasPagoBindingSource1.DataMember = "FormasPago";
            this.formasPagoBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // cuentasBancosBindingSource1
            // 
            this.cuentasBancosBindingSource1.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // obrasBindingSource1
            // 
            this.obrasBindingSource1.DataMember = "Obras";
            this.obrasBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // fKObrasClientesBindingSource1
            // 
            this.fKObrasClientesBindingSource1.DataMember = "FK_Obras_Clientes";
            this.fKObrasClientesBindingSource1.DataSource = this.clientesBindingSource;
            // 
            // facturasCabListaBindingSource
            // 
            this.facturasCabListaBindingSource.DataMember = "FacturasCabLista";
            this.facturasCabListaBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // facturasCabListaTableAdapter
            // 
            this.facturasCabListaTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagenes|*.jpg; *.bmp; *.png; *.gif; *.pdf";
            // 
            // cobrosGridControl
            // 
            this.cobrosGridControl.DataSource = this.cobrosBindingSource;
            this.cobrosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cobrosGridControl.Location = new System.Drawing.Point(0, 0);
            this.cobrosGridControl.MainView = this.gridView1;
            this.cobrosGridControl.Name = "cobrosGridControl";
            this.cobrosGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Clientes});
            this.cobrosGridControl.Size = new System.Drawing.Size(1191, 362);
            this.cobrosGridControl.TabIndex = 41;
            this.cobrosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro,
            this.colIdUsuario,
            this.colIdEmpresa,
            this.colIdCliente,
            this.colIdObra,
            this.colFechaExp,
            this.colFechaRec,
            this.colFechaAbono,
            this.colFechaVcto,
            this.colIdFactCab,
            this.colFactura,
            this.colIdFormaPago,
            this.colIdCuenta,
            this.colImpBase,
            this.colImpIVA,
            this.colReferencia,
            this.colObserv,
            this.colTotal,
            this.colFechaFactura,
            this.colCopiaFactura,
            this.colEnBanco,
            this.colPrevision});
            this.gridView1.GridControl = this.cobrosGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Cliente";
            this.colIdCliente.ColumnEdit = this.Cliente;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 3;
            this.colIdCliente.Width = 223;
            // 
            // colIdObra
            // 
            this.colIdObra.Caption = "Obra";
            this.colIdObra.ColumnEdit = this.Obra;
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdObra.Width = 214;
            // 
            // colFechaExp
            // 
            this.colFechaExp.Caption = "Fecha";
            this.colFechaExp.FieldName = "FechaExp";
            this.colFechaExp.Name = "colFechaExp";
            this.colFechaExp.Visible = true;
            this.colFechaExp.VisibleIndex = 0;
            this.colFechaExp.Width = 104;
            // 
            // colFechaRec
            // 
            this.colFechaRec.FieldName = "FechaRec";
            this.colFechaRec.Name = "colFechaRec";
            // 
            // colFechaAbono
            // 
            this.colFechaAbono.FieldName = "FechaAbono";
            this.colFechaAbono.Name = "colFechaAbono";
            // 
            // colFechaVcto
            // 
            this.colFechaVcto.FieldName = "FechaVcto";
            this.colFechaVcto.Name = "colFechaVcto";
            // 
            // colIdFactCab
            // 
            this.colIdFactCab.FieldName = "IdFactCab";
            this.colIdFactCab.Name = "colIdFactCab";
            this.colIdFactCab.Width = 107;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colFactura.Name = "colFactura";
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 5;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.Caption = "Forma Cobro";
            this.colIdFormaPago.ColumnEdit = this.FormaPago;
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdFormaPago.Visible = true;
            this.colIdFormaPago.VisibleIndex = 1;
            this.colIdFormaPago.Width = 105;
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "Cuenta";
            this.colIdCuenta.ColumnEdit = this.Cuenta;
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdCuenta.Visible = true;
            this.colIdCuenta.VisibleIndex = 2;
            this.colIdCuenta.Width = 163;
            // 
            // colImpBase
            // 
            this.colImpBase.FieldName = "ImpBase";
            this.colImpBase.Name = "colImpBase";
            // 
            // colImpIVA
            // 
            this.colImpIVA.FieldName = "ImpIVA";
            this.colImpIVA.Name = "colImpIVA";
            // 
            // colReferencia
            // 
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            // 
            // colObserv
            // 
            this.colObserv.FieldName = "Observ";
            this.colObserv.Name = "colObserv";
            // 
            // colTotal
            // 
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.Caption = "Importe Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            this.colTotal.Width = 100;
            // 
            // colFechaFactura
            // 
            this.colFechaFactura.FieldName = "FechaFactura";
            this.colFechaFactura.Name = "colFechaFactura";
            // 
            // colCopiaFactura
            // 
            this.colCopiaFactura.FieldName = "CopiaFactura";
            this.colCopiaFactura.Name = "colCopiaFactura";
            // 
            // colEnBanco
            // 
            this.colEnBanco.FieldName = "EnBanco";
            this.colEnBanco.Name = "colEnBanco";
            // 
            // colPrevision
            // 
            this.colPrevision.FieldName = "Prevision";
            this.colPrevision.Name = "colPrevision";
            // 
            // Clientes
            // 
            this.Clientes.AutoHeight = false;
            this.Clientes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Clientes.Name = "Clientes";
            // 
            // fKObrasClientesBindingSource
            // 
            this.fKObrasClientesBindingSource.DataMember = "FK_Obras_Clientes";
            this.fKObrasClientesBindingSource.DataSource = this.clientesBindingSource;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.previsionCheckEdit);
            this.splitContainer1.Panel2.Controls.Add(idFormaPagoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.idFormaPagoComboBox);
            this.splitContainer1.Panel2.Controls.Add(copiaFacturaLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idCuentaComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.copiaFacturaTextBox);
            this.splitContainer1.Panel2.Controls.Add(idCuentaLabel);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.idClienteComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(idClienteLabel);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.idObraComboBox);
            this.splitContainer1.Panel2.Controls.Add(totalLabel);
            this.splitContainer1.Panel2.Controls.Add(idObraLabel);
            this.splitContainer1.Panel2.Controls.Add(this.totalTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.fechaExpDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(fechaFacturaLabel);
            this.splitContainer1.Panel2.Controls.Add(fechaExpLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fechaFacturaDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.fechaRecDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(facturaLabel);
            this.splitContainer1.Panel2.Controls.Add(fechaRecLabel);
            this.splitContainer1.Panel2.Controls.Add(this.facturaTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.fechaAbonoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(idFactCabLabel);
            this.splitContainer1.Panel2.Controls.Add(fechaAbonoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idFactCabComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.fechaVctoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(observLabel);
            this.splitContainer1.Panel2.Controls.Add(fechaVctoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.observTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.impBaseTextBox);
            this.splitContainer1.Panel2.Controls.Add(referenciaLabel);
            this.splitContainer1.Panel2.Controls.Add(impBaseLabel);
            this.splitContainer1.Panel2.Controls.Add(this.referenciaTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.impIVATextBox);
            this.splitContainer1.Panel2.Controls.Add(impIVALabel);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 604);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 42;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cobrosBindingNavigator);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cobrosGridControl);
            this.splitContainer2.Size = new System.Drawing.Size(1191, 391);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 42;
            // 
            // previsionCheckEdit
            // 
            this.previsionCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cobrosBindingSource, "Prevision", true));
            this.previsionCheckEdit.Location = new System.Drawing.Point(928, 95);
            this.previsionCheckEdit.Name = "previsionCheckEdit";
            this.previsionCheckEdit.Properties.Caption = "Previsión";
            this.previsionCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.previsionCheckEdit.TabIndex = 81;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 80;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // idFormaPagoComboBox
            // 
            this.idFormaPagoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idFormaPagoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idFormaPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdFormaPago", true));
            this.idFormaPagoComboBox.DataSource = this.formasPagoBindingSource1;
            this.idFormaPagoComboBox.DisplayMember = "DesFormaPago";
            this.idFormaPagoComboBox.FormattingEnabled = true;
            this.idFormaPagoComboBox.Location = new System.Drawing.Point(115, 16);
            this.idFormaPagoComboBox.Name = "idFormaPagoComboBox";
            this.idFormaPagoComboBox.Size = new System.Drawing.Size(314, 21);
            this.idFormaPagoComboBox.TabIndex = 44;
            this.idFormaPagoComboBox.ValueMember = "IdFormaPago";
            // 
            // idCuentaComboBox
            // 
            this.idCuentaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idCuentaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idCuentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdCuenta", true));
            this.idCuentaComboBox.DataSource = this.cuentasBancosBindingSource1;
            this.idCuentaComboBox.DisplayMember = "CuentaBanco";
            this.idCuentaComboBox.DropDownWidth = 314;
            this.idCuentaComboBox.FormattingEnabled = true;
            this.idCuentaComboBox.Location = new System.Drawing.Point(115, 43);
            this.idCuentaComboBox.Name = "idCuentaComboBox";
            this.idCuentaComboBox.Size = new System.Drawing.Size(314, 21);
            this.idCuentaComboBox.TabIndex = 46;
            this.idCuentaComboBox.ValueMember = "IdCuenta";
            // 
            // copiaFacturaTextBox
            // 
            this.copiaFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "CopiaFactura", true));
            this.copiaFacturaTextBox.Location = new System.Drawing.Point(115, 177);
            this.copiaFacturaTextBox.Name = "copiaFacturaTextBox";
            this.copiaFacturaTextBox.Size = new System.Drawing.Size(314, 20);
            this.copiaFacturaTextBox.TabIndex = 75;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 77;
            this.button4.Text = "Ver";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource1;
            this.idClienteComboBox.DisplayMember = "DesCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(115, 70);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(314, 21);
            this.idClienteComboBox.TabIndex = 48;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // button3
            // 
            this.button3.Image = global::Promowork.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.button3.Location = new System.Drawing.Point(562, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 78;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 76;
            this.button1.Text = "Copia Factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idObraComboBox
            // 
            this.idObraComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idObraComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idObraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdObra", true));
            this.idObraComboBox.DataSource = this.obrasBindingSource1;
            this.idObraComboBox.DisplayMember = "Obra";
            this.idObraComboBox.FormattingEnabled = true;
            this.idObraComboBox.Location = new System.Drawing.Point(115, 97);
            this.idObraComboBox.Name = "idObraComboBox";
            this.idObraComboBox.Size = new System.Drawing.Size(314, 21);
            this.idObraComboBox.TabIndex = 50;
            this.idObraComboBox.ValueMember = "IdObra";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(930, 69);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 74;
            // 
            // fechaExpDateTimePicker
            // 
            this.fechaExpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaExp", true));
            this.fechaExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaExpDateTimePicker.Location = new System.Drawing.Point(601, 44);
            this.fechaExpDateTimePicker.Name = "fechaExpDateTimePicker";
            this.fechaExpDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaExpDateTimePicker.TabIndex = 52;
            // 
            // fechaFacturaDateTimePicker
            // 
            this.fechaFacturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaFactura", true));
            this.fechaFacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFacturaDateTimePicker.Location = new System.Drawing.Point(329, 151);
            this.fechaFacturaDateTimePicker.Name = "fechaFacturaDateTimePicker";
            this.fechaFacturaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaFacturaDateTimePicker.TabIndex = 72;
            // 
            // fechaRecDateTimePicker
            // 
            this.fechaRecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaRec", true));
            this.fechaRecDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRecDateTimePicker.Location = new System.Drawing.Point(601, 71);
            this.fechaRecDateTimePicker.Name = "fechaRecDateTimePicker";
            this.fechaRecDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaRecDateTimePicker.TabIndex = 54;
            // 
            // facturaTextBox
            // 
            this.facturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Factura", true));
            this.facturaTextBox.Location = new System.Drawing.Point(115, 151);
            this.facturaTextBox.Name = "facturaTextBox";
            this.facturaTextBox.Size = new System.Drawing.Size(105, 20);
            this.facturaTextBox.TabIndex = 71;
            // 
            // fechaAbonoDateTimePicker
            // 
            this.fechaAbonoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaAbono", true));
            this.fechaAbonoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaAbonoDateTimePicker.Location = new System.Drawing.Point(601, 98);
            this.fechaAbonoDateTimePicker.Name = "fechaAbonoDateTimePicker";
            this.fechaAbonoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaAbonoDateTimePicker.TabIndex = 56;
            // 
            // idFactCabComboBox
            // 
            this.idFactCabComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdFactCab", true));
            this.idFactCabComboBox.DataSource = this.facturasCabListaBindingSource;
            this.idFactCabComboBox.DisplayMember = "Factura";
            this.idFactCabComboBox.FormattingEnabled = true;
            this.idFactCabComboBox.Location = new System.Drawing.Point(115, 124);
            this.idFactCabComboBox.Name = "idFactCabComboBox";
            this.idFactCabComboBox.Size = new System.Drawing.Size(314, 21);
            this.idFactCabComboBox.TabIndex = 69;
            this.idFactCabComboBox.ValueMember = "IdFactCab";
            // 
            // fechaVctoDateTimePicker
            // 
            this.fechaVctoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaVcto", true));
            this.fechaVctoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVctoDateTimePicker.Location = new System.Drawing.Point(601, 125);
            this.fechaVctoDateTimePicker.Name = "fechaVctoDateTimePicker";
            this.fechaVctoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaVctoDateTimePicker.TabIndex = 58;
            // 
            // observTextBox
            // 
            this.observTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Observ", true));
            this.observTextBox.Location = new System.Drawing.Point(812, 123);
            this.observTextBox.Multiline = true;
            this.observTextBox.Name = "observTextBox";
            this.observTextBox.Size = new System.Drawing.Size(218, 48);
            this.observTextBox.TabIndex = 66;
            // 
            // impBaseTextBox
            // 
            this.impBaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpBase", true));
            this.impBaseTextBox.Location = new System.Drawing.Point(930, 16);
            this.impBaseTextBox.Name = "impBaseTextBox";
            this.impBaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.impBaseTextBox.TabIndex = 60;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Referencia", true));
            this.referenciaTextBox.Location = new System.Drawing.Point(601, 16);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(204, 20);
            this.referenciaTextBox.TabIndex = 64;
            // 
            // impIVATextBox
            // 
            this.impIVATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpIVA", true));
            this.impIVATextBox.Location = new System.Drawing.Point(930, 43);
            this.impIVATextBox.Name = "impIVATextBox";
            this.impIVATextBox.Size = new System.Drawing.Size(100, 20);
            this.impIVATextBox.TabIndex = 62;
            // 
            // Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 604);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cobros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.Cobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingNavigator)).EndInit();
            this.cobrosBindingNavigator.ResumeLayout(false);
            this.cobrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKObrasClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKObrasClientesBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previsionCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource cobrosBindingSource;
        private Promowork_dataDataSetTableAdapters.CobrosTableAdapter cobrosTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cobrosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cobrosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource formasPagoBindingSource;
        private Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter formasPagoTableAdapter;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource;
        private Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter cuentasBancosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Promowork_dataDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private Promowork_dataDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private System.Windows.Forms.BindingSource formasPagoBindingSource1;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource obrasBindingSource1;
        private System.Windows.Forms.BindingSource facturasCabListaBindingSource;
        private Promowork_dataDataSetTableAdapters.FacturasCabListaTableAdapter facturasCabListaTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Promowork_dataDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraGrid.GridControl cobrosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaExp;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRec;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAbono;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVcto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colImpBase;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colObserv;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colEnBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevision;
        private System.Windows.Forms.BindingSource fKObrasClientesBindingSource1;
        private System.Windows.Forms.BindingSource fKObrasClientesBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Cliente;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Obra;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FormaPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Cuenta;
        private DevExpress.XtraEditors.CheckEdit previsionCheckEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox idFormaPagoComboBox;
        private System.Windows.Forms.ComboBox idCuentaComboBox;
        private System.Windows.Forms.TextBox copiaFacturaTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox idObraComboBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DateTimePicker fechaExpDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaFacturaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaRecDateTimePicker;
        private System.Windows.Forms.TextBox facturaTextBox;
        private System.Windows.Forms.DateTimePicker fechaAbonoDateTimePicker;
        private System.Windows.Forms.ComboBox idFactCabComboBox;
        private System.Windows.Forms.DateTimePicker fechaVctoDateTimePicker;
        private System.Windows.Forms.TextBox observTextBox;
        private System.Windows.Forms.TextBox impBaseTextBox;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox impIVATextBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Clientes;
    }
}