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
            System.Windows.Forms.Label idFormaPagoLabel;
            System.Windows.Forms.Label idCuentaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idObraLabel;
            System.Windows.Forms.Label fechaExpLabel;
            System.Windows.Forms.Label fechaRecLabel;
            System.Windows.Forms.Label fechaAbonoLabel;
            System.Windows.Forms.Label fechaVctoLabel;
            System.Windows.Forms.Label impBaseLabel;
            System.Windows.Forms.Label impIVALabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label observLabel;
            System.Windows.Forms.Label idFactCabLabel;
            System.Windows.Forms.Label facturaLabel;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label copiaFacturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.cobrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobrosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CobrosTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.cobrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cobrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cobrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.formasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formasPagoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter();
            this.cuentasBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter();
            this.clientesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ClientesTableAdapter();
            this.obrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ObrasTableAdapter();
            this.idFormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.formasPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.cuentasBancosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idObraComboBox = new System.Windows.Forms.ComboBox();
            this.obrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fechaExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaRecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaAbonoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaVctoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.impBaseTextBox = new System.Windows.Forms.TextBox();
            this.impIVATextBox = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.observTextBox = new System.Windows.Forms.TextBox();
            this.idFactCabComboBox = new System.Windows.Forms.ComboBox();
            this.facturasCabListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasCabListaTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FacturasCabListaTableAdapter();
            this.facturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.copiaFacturaTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            idFormaPagoLabel = new System.Windows.Forms.Label();
            idCuentaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idObraLabel = new System.Windows.Forms.Label();
            fechaExpLabel = new System.Windows.Forms.Label();
            fechaRecLabel = new System.Windows.Forms.Label();
            fechaAbonoLabel = new System.Windows.Forms.Label();
            fechaVctoLabel = new System.Windows.Forms.Label();
            impBaseLabel = new System.Windows.Forms.Label();
            impIVALabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            observLabel = new System.Windows.Forms.Label();
            idFactCabLabel = new System.Windows.Forms.Label();
            facturaLabel = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            copiaFacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingNavigator)).BeginInit();
            this.cobrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabListaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idFormaPagoLabel
            // 
            idFormaPagoLabel.AutoSize = true;
            idFormaPagoLabel.Location = new System.Drawing.Point(52, 332);
            idFormaPagoLabel.Name = "idFormaPagoLabel";
            idFormaPagoLabel.Size = new System.Drawing.Size(77, 13);
            idFormaPagoLabel.TabIndex = 2;
            idFormaPagoLabel.Text = "Forma Pago(*):";
            // 
            // idCuentaLabel
            // 
            idCuentaLabel.AutoSize = true;
            idCuentaLabel.Location = new System.Drawing.Point(75, 359);
            idCuentaLabel.Name = "idCuentaLabel";
            idCuentaLabel.Size = new System.Drawing.Size(54, 13);
            idCuentaLabel.TabIndex = 4;
            idCuentaLabel.Text = "Cuenta(*):";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(77, 386);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(52, 13);
            idClienteLabel.TabIndex = 6;
            idClienteLabel.Text = "Cliente(*):";
            // 
            // idObraLabel
            // 
            idObraLabel.AutoSize = true;
            idObraLabel.Location = new System.Drawing.Point(95, 413);
            idObraLabel.Name = "idObraLabel";
            idObraLabel.Size = new System.Drawing.Size(33, 13);
            idObraLabel.TabIndex = 8;
            idObraLabel.Text = "Obra:";
            // 
            // fechaExpLabel
            // 
            fechaExpLabel.AutoSize = true;
            fechaExpLabel.Location = new System.Drawing.Point(520, 360);
            fechaExpLabel.Name = "fechaExpLabel";
            fechaExpLabel.Size = new System.Drawing.Size(95, 13);
            fechaExpLabel.TabIndex = 10;
            fechaExpLabel.Text = "Fecha Expedición:";
            // 
            // fechaRecLabel
            // 
            fechaRecLabel.AutoSize = true;
            fechaRecLabel.Location = new System.Drawing.Point(530, 387);
            fechaRecLabel.Name = "fechaRecLabel";
            fechaRecLabel.Size = new System.Drawing.Size(85, 13);
            fechaRecLabel.TabIndex = 12;
            fechaRecLabel.Text = "Fecha Recibido:";
            // 
            // fechaAbonoLabel
            // 
            fechaAbonoLabel.AutoSize = true;
            fechaAbonoLabel.Location = new System.Drawing.Point(541, 414);
            fechaAbonoLabel.Name = "fechaAbonoLabel";
            fechaAbonoLabel.Size = new System.Drawing.Size(74, 13);
            fechaAbonoLabel.TabIndex = 14;
            fechaAbonoLabel.Text = "Fecha Abono:";
            // 
            // fechaVctoLabel
            // 
            fechaVctoLabel.AutoSize = true;
            fechaVctoLabel.Location = new System.Drawing.Point(514, 441);
            fechaVctoLabel.Name = "fechaVctoLabel";
            fechaVctoLabel.Size = new System.Drawing.Size(101, 13);
            fechaVctoLabel.TabIndex = 16;
            fechaVctoLabel.Text = "Fecha Vencimiento:";
            // 
            // impBaseLabel
            // 
            impBaseLabel.AutoSize = true;
            impBaseLabel.Location = new System.Drawing.Point(862, 331);
            impBaseLabel.Name = "impBaseLabel";
            impBaseLabel.Size = new System.Drawing.Size(82, 13);
            impBaseLabel.TabIndex = 18;
            impBaseLabel.Text = "Importe Base(*):";
            // 
            // impIVALabel
            // 
            impIVALabel.AutoSize = true;
            impIVALabel.Location = new System.Drawing.Point(878, 358);
            impIVALabel.Name = "impIVALabel";
            impIVALabel.Size = new System.Drawing.Size(65, 13);
            impIVALabel.TabIndex = 20;
            impIVALabel.Text = "Importe IVA:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(550, 331);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(65, 13);
            referenciaLabel.TabIndex = 22;
            referenciaLabel.Text = "Documento:";
            // 
            // observLabel
            // 
            observLabel.AutoSize = true;
            observLabel.Location = new System.Drawing.Point(743, 405);
            observLabel.Name = "observLabel";
            observLabel.Size = new System.Drawing.Size(81, 13);
            observLabel.TabIndex = 24;
            observLabel.Text = "Observaciones:";
            // 
            // idFactCabLabel
            // 
            idFactCabLabel.AutoSize = true;
            idFactCabLabel.Location = new System.Drawing.Point(42, 440);
            idFactCabLabel.Name = "idFactCabLabel";
            idFactCabLabel.Size = new System.Drawing.Size(86, 13);
            idFactCabLabel.TabIndex = 28;
            idFactCabLabel.Text = "Factura Sistema:";
            // 
            // facturaLabel
            // 
            facturaLabel.AutoSize = true;
            facturaLabel.Location = new System.Drawing.Point(82, 467);
            facturaLabel.Name = "facturaLabel";
            facturaLabel.Size = new System.Drawing.Size(46, 13);
            facturaLabel.TabIndex = 29;
            facturaLabel.Text = "Factura:";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(263, 467);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(79, 13);
            fechaFacturaLabel.TabIndex = 30;
            fechaFacturaLabel.Text = "Fecha Factura:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(910, 384);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 32;
            totalLabel.Text = "Total:";
            // 
            // copiaFacturaLabel
            // 
            copiaFacturaLabel.AutoSize = true;
            copiaFacturaLabel.Location = new System.Drawing.Point(51, 493);
            copiaFacturaLabel.Name = "copiaFacturaLabel";
            copiaFacturaLabel.Size = new System.Drawing.Size(76, 13);
            copiaFacturaLabel.TabIndex = 38;
            copiaFacturaLabel.Text = "Copia Factura:";
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
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.EmpresasActualTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.FacturasCabTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = null;
            this.tableAdapterManager.FestivosEmpresasTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.HijosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.HorasAdminTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadasTableAdapter = null;
            this.tableAdapterManager.NacionesTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
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
            this.cobrosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.cobrosBindingNavigator.Size = new System.Drawing.Size(1059, 25);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // cobrosBindingNavigatorSaveItem
            // 
            this.cobrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cobrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cobrosBindingNavigatorSaveItem.Image")));
            this.cobrosBindingNavigatorSaveItem.Name = "cobrosBindingNavigatorSaveItem";
            this.cobrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cobrosBindingNavigatorSaveItem.Text = "Save Data";
            this.cobrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cobrosBindingNavigatorSaveItem_Click);
            // 
            // cobrosDataGridView
            // 
            this.cobrosDataGridView.AllowUserToAddRows = false;
            this.cobrosDataGridView.AutoGenerateColumns = false;
            this.cobrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cobrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.Total,
            this.dataGridViewTextBoxColumn15});
            this.cobrosDataGridView.DataSource = this.cobrosBindingSource;
            this.cobrosDataGridView.Location = new System.Drawing.Point(12, 31);
            this.cobrosDataGridView.Name = "cobrosDataGridView";
            this.cobrosDataGridView.ReadOnly = true;
            this.cobrosDataGridView.RowHeadersVisible = false;
            this.cobrosDataGridView.Size = new System.Drawing.Size(1034, 282);
            this.cobrosDataGridView.TabIndex = 1;
            this.cobrosDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cobrosDataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdFormaPago";
            this.dataGridViewTextBoxColumn4.DataSource = this.formasPagoBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "DesFormaPago";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Forma Cobro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdFormaPago";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // formasPagoBindingSource
            // 
            this.formasPagoBindingSource.DataMember = "FormasPago";
            this.formasPagoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdCuenta";
            this.dataGridViewTextBoxColumn5.DataSource = this.cuentasBancosBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "CuentaBanco";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Cuenta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "IdCuenta";
            this.dataGridViewTextBoxColumn5.Width = 152;
            // 
            // cuentasBancosBindingSource
            // 
            this.cuentasBancosBindingSource.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn7.DataSource = this.clientesBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "DesCliente";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn7.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "IdCliente";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdObra";
            this.dataGridViewTextBoxColumn8.DataSource = this.obrasBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "DesObra";
            this.dataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn8.HeaderText = "Obra";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IdObra";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FechaExp";
            this.dataGridViewTextBoxColumn9.HeaderText = "Expedición";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaVcto";
            this.dataGridViewTextBoxColumn12.HeaderText = "Vencimiento";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 70;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle1;
            this.Total.HeaderText = "Importe Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Referencia";
            this.dataGridViewTextBoxColumn15.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 110;
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
            // idFormaPagoComboBox
            // 
            this.idFormaPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdFormaPago", true));
            this.idFormaPagoComboBox.DataSource = this.formasPagoBindingSource1;
            this.idFormaPagoComboBox.DisplayMember = "DesFormaPago";
            this.idFormaPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idFormaPagoComboBox.FormattingEnabled = true;
            this.idFormaPagoComboBox.Location = new System.Drawing.Point(131, 328);
            this.idFormaPagoComboBox.Name = "idFormaPagoComboBox";
            this.idFormaPagoComboBox.Size = new System.Drawing.Size(314, 21);
            this.idFormaPagoComboBox.TabIndex = 3;
            this.idFormaPagoComboBox.ValueMember = "IdFormaPago";
            // 
            // formasPagoBindingSource1
            // 
            this.formasPagoBindingSource1.DataMember = "FormasPago";
            this.formasPagoBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // idCuentaComboBox
            // 
            this.idCuentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdCuenta", true));
            this.idCuentaComboBox.DataSource = this.cuentasBancosBindingSource1;
            this.idCuentaComboBox.DisplayMember = "CuentaBanco";
            this.idCuentaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCuentaComboBox.DropDownWidth = 300;
            this.idCuentaComboBox.FormattingEnabled = true;
            this.idCuentaComboBox.Location = new System.Drawing.Point(131, 355);
            this.idCuentaComboBox.Name = "idCuentaComboBox";
            this.idCuentaComboBox.Size = new System.Drawing.Size(314, 21);
            this.idCuentaComboBox.TabIndex = 5;
            this.idCuentaComboBox.ValueMember = "IdCuenta";
            // 
            // cuentasBancosBindingSource1
            // 
            this.cuentasBancosBindingSource1.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource1;
            this.idClienteComboBox.DisplayMember = "DesCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(131, 382);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(314, 21);
            this.idClienteComboBox.TabIndex = 7;
            this.idClienteComboBox.ValueMember = "IdCliente";
            this.idClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.idClienteComboBox_SelectedIndexChanged);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // idObraComboBox
            // 
            this.idObraComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idObraComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idObraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdObra", true));
            this.idObraComboBox.DataSource = this.obrasBindingSource1;
            this.idObraComboBox.DisplayMember = "Obra";
            this.idObraComboBox.FormattingEnabled = true;
            this.idObraComboBox.Location = new System.Drawing.Point(131, 409);
            this.idObraComboBox.Name = "idObraComboBox";
            this.idObraComboBox.Size = new System.Drawing.Size(314, 21);
            this.idObraComboBox.TabIndex = 9;
            this.idObraComboBox.ValueMember = "IdObra";
            this.idObraComboBox.SelectedIndexChanged += new System.EventHandler(this.idObraComboBox_SelectedIndexChanged);
            // 
            // obrasBindingSource1
            // 
            this.obrasBindingSource1.DataMember = "Obras";
            this.obrasBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // fechaExpDateTimePicker
            // 
            this.fechaExpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaExp", true));
            this.fechaExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaExpDateTimePicker.Location = new System.Drawing.Point(617, 356);
            this.fechaExpDateTimePicker.Name = "fechaExpDateTimePicker";
            this.fechaExpDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaExpDateTimePicker.TabIndex = 11;
            this.fechaExpDateTimePicker.Validated += new System.EventHandler(this.fechaExpDateTimePicker_Validated);
            // 
            // fechaRecDateTimePicker
            // 
            this.fechaRecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaRec", true));
            this.fechaRecDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRecDateTimePicker.Location = new System.Drawing.Point(617, 383);
            this.fechaRecDateTimePicker.Name = "fechaRecDateTimePicker";
            this.fechaRecDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaRecDateTimePicker.TabIndex = 13;
            // 
            // fechaAbonoDateTimePicker
            // 
            this.fechaAbonoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaAbono", true));
            this.fechaAbonoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaAbonoDateTimePicker.Location = new System.Drawing.Point(617, 410);
            this.fechaAbonoDateTimePicker.Name = "fechaAbonoDateTimePicker";
            this.fechaAbonoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaAbonoDateTimePicker.TabIndex = 15;
            // 
            // fechaVctoDateTimePicker
            // 
            this.fechaVctoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaVcto", true));
            this.fechaVctoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVctoDateTimePicker.Location = new System.Drawing.Point(617, 437);
            this.fechaVctoDateTimePicker.Name = "fechaVctoDateTimePicker";
            this.fechaVctoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaVctoDateTimePicker.TabIndex = 17;
            // 
            // impBaseTextBox
            // 
            this.impBaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpBase", true));
            this.impBaseTextBox.Location = new System.Drawing.Point(946, 328);
            this.impBaseTextBox.Name = "impBaseTextBox";
            this.impBaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.impBaseTextBox.TabIndex = 19;
            // 
            // impIVATextBox
            // 
            this.impIVATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpIVA", true));
            this.impIVATextBox.Location = new System.Drawing.Point(946, 355);
            this.impIVATextBox.Name = "impIVATextBox";
            this.impIVATextBox.Size = new System.Drawing.Size(100, 20);
            this.impIVATextBox.TabIndex = 21;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Referencia", true));
            this.referenciaTextBox.Location = new System.Drawing.Point(617, 328);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(204, 20);
            this.referenciaTextBox.TabIndex = 23;
            // 
            // observTextBox
            // 
            this.observTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Observ", true));
            this.observTextBox.Location = new System.Drawing.Point(828, 409);
            this.observTextBox.Multiline = true;
            this.observTextBox.Name = "observTextBox";
            this.observTextBox.Size = new System.Drawing.Size(218, 48);
            this.observTextBox.TabIndex = 25;
            // 
            // idFactCabComboBox
            // 
            this.idFactCabComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdFactCab", true));
            this.idFactCabComboBox.DataSource = this.facturasCabListaBindingSource;
            this.idFactCabComboBox.DisplayMember = "Factura";
            this.idFactCabComboBox.FormattingEnabled = true;
            this.idFactCabComboBox.Location = new System.Drawing.Point(131, 436);
            this.idFactCabComboBox.Name = "idFactCabComboBox";
            this.idFactCabComboBox.Size = new System.Drawing.Size(314, 21);
            this.idFactCabComboBox.TabIndex = 29;
            this.idFactCabComboBox.ValueMember = "IdFactCab";
            this.idFactCabComboBox.SelectedIndexChanged += new System.EventHandler(this.idFactCabComboBox_SelectedIndexChanged);
            this.idFactCabComboBox.Leave += new System.EventHandler(this.idFactCabComboBox_Leave);
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
            // facturaTextBox
            // 
            this.facturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Factura", true));
            this.facturaTextBox.Location = new System.Drawing.Point(131, 463);
            this.facturaTextBox.Name = "facturaTextBox";
            this.facturaTextBox.Size = new System.Drawing.Size(105, 20);
            this.facturaTextBox.TabIndex = 30;
            this.facturaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.facturaTextBox_KeyUp);
            // 
            // fechaFacturaDateTimePicker
            // 
            this.fechaFacturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaFactura", true));
            this.fechaFacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFacturaDateTimePicker.Location = new System.Drawing.Point(345, 463);
            this.fechaFacturaDateTimePicker.Name = "fechaFacturaDateTimePicker";
            this.fechaFacturaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaFacturaDateTimePicker.TabIndex = 31;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(946, 381);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 33;
            // 
            // copiaFacturaTextBox
            // 
            this.copiaFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "CopiaFactura", true));
            this.copiaFacturaTextBox.Location = new System.Drawing.Point(131, 489);
            this.copiaFacturaTextBox.Name = "copiaFacturaTextBox";
            this.copiaFacturaTextBox.Size = new System.Drawing.Size(314, 20);
            this.copiaFacturaTextBox.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Ver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Promowork.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.button3.Location = new System.Drawing.Point(578, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 37;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Copia Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagenes|*.jpg; *.bmp; *.png; *.gif; *.pdf";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(copiaFacturaLabel);
            this.Controls.Add(this.copiaFacturaTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(fechaFacturaLabel);
            this.Controls.Add(this.fechaFacturaDateTimePicker);
            this.Controls.Add(facturaLabel);
            this.Controls.Add(this.facturaTextBox);
            this.Controls.Add(idFactCabLabel);
            this.Controls.Add(this.idFactCabComboBox);
            this.Controls.Add(observLabel);
            this.Controls.Add(this.observTextBox);
            this.Controls.Add(referenciaLabel);
            this.Controls.Add(this.referenciaTextBox);
            this.Controls.Add(impIVALabel);
            this.Controls.Add(this.impIVATextBox);
            this.Controls.Add(impBaseLabel);
            this.Controls.Add(this.impBaseTextBox);
            this.Controls.Add(fechaVctoLabel);
            this.Controls.Add(this.fechaVctoDateTimePicker);
            this.Controls.Add(fechaAbonoLabel);
            this.Controls.Add(this.fechaAbonoDateTimePicker);
            this.Controls.Add(fechaRecLabel);
            this.Controls.Add(this.fechaRecDateTimePicker);
            this.Controls.Add(fechaExpLabel);
            this.Controls.Add(this.fechaExpDateTimePicker);
            this.Controls.Add(idObraLabel);
            this.Controls.Add(this.idObraComboBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(idCuentaLabel);
            this.Controls.Add(this.idCuentaComboBox);
            this.Controls.Add(idFormaPagoLabel);
            this.Controls.Add(this.idFormaPagoComboBox);
            this.Controls.Add(this.cobrosDataGridView);
            this.Controls.Add(this.cobrosBindingNavigator);
            this.Name = "Cobros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.Cobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingNavigator)).EndInit();
            this.cobrosBindingNavigator.ResumeLayout(false);
            this.cobrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabListaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView cobrosDataGridView;
        private System.Windows.Forms.BindingSource formasPagoBindingSource;
        private Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter formasPagoTableAdapter;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource;
        private Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter cuentasBancosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Promowork_dataDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private Promowork_dataDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private System.Windows.Forms.ComboBox idFormaPagoComboBox;
        private System.Windows.Forms.BindingSource formasPagoBindingSource1;
        private System.Windows.Forms.ComboBox idCuentaComboBox;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource1;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.ComboBox idObraComboBox;
        private System.Windows.Forms.BindingSource obrasBindingSource1;
        private System.Windows.Forms.DateTimePicker fechaExpDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaRecDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaAbonoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaVctoDateTimePicker;
        private System.Windows.Forms.TextBox impBaseTextBox;
        private System.Windows.Forms.TextBox impIVATextBox;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox observTextBox;
        private System.Windows.Forms.ComboBox idFactCabComboBox;
        private System.Windows.Forms.BindingSource facturasCabListaBindingSource;
        private Promowork_dataDataSetTableAdapters.FacturasCabListaTableAdapter facturasCabListaTableAdapter;
        private System.Windows.Forms.TextBox facturaTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DateTimePicker fechaFacturaDateTimePicker;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox copiaFacturaTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}