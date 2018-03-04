namespace Promowork
{
    partial class frmPresupuestoTabla
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
            System.Windows.Forms.Label numPresupLabel;
            System.Windows.Forms.Label nomPresupLabel;
            System.Windows.Forms.Label desPresupLabel;
            System.Windows.Forms.Label fechaPresupLabel;
            System.Windows.Forms.Label licObraPresupLabel;
            System.Windows.Forms.Label idClienteLabel1;
            System.Windows.Forms.Label idObraLabel1;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.Windows.Forms.Label certificacionAFacturarLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestoTabla));
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPresupCap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumPresupDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumCap = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomPresupDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcion = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colDesPresupDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCab2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaFacturar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aFacturarDet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIdPresupDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalaFacturar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFacturado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantDetFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.presupCapGridControl = new DevExpress.XtraGrid.GridControl();
            this.presupCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosPresupuestos = new Promowork.DatosPresupuestos();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPresupCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCapPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCapPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsCapPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCapaFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFacturado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aFacturarSub = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPresupSub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupDet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCab3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumPresupSub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomPresupSub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesPresupSub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCap2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantInf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantExtra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantSubFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFacturado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPediente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaFacturar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalaFacturar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.presupCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.presupCabGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPresupCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Clientes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Obras = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirObraPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicObraPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPresup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPresupFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPresupPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaFacturarCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spnUltCertificacion = new DevExpress.XtraEditors.SpinEdit();
            this.certificacionAFacturarSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idObraComboBox = new System.Windows.Forms.ComboBox();
            this.obrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.licObraPresupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fechaPresupDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.desPresupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomPresupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.numPresupSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btGenerarPartidas = new System.Windows.Forms.ToolStripButton();
            this.presupCabTableAdapter = new Promowork.DatosPresupuestosTableAdapters.PresupCabTableAdapter();
            this.tableAdapterManager = new Promowork.DatosPresupuestosTableAdapters.TableAdapterManager();
            this.presupCapTableAdapter = new Promowork.DatosPresupuestosTableAdapters.PresupCapTableAdapter();
            this.presupCabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.presupCabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.anosPresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anosPresupuestosTableAdapter = new Promowork.DatosPresupuestosTableAdapters.AnosPresupuestosTableAdapter();
            this.clientesTableAdapter = new Promowork.DatosPresupuestosTableAdapters.ClientesTableAdapter();
            this.obrasTableAdapter = new Promowork.DatosPresupuestosTableAdapters.ObrasTableAdapter();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.presupDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupDetTableAdapter = new Promowork.DatosPresupuestosTableAdapters.PresupDetTableAdapter();
            this.presupSubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupSubTableAdapter = new Promowork.DatosPresupuestosTableAdapters.PresupSubTableAdapter();
            this.queriesAccesos1 = new Promowork.DatosAccesosTableAdapters.QueriesAccesos();
            this.queriesPresupuestos1 = new Promowork.DatosPresupuestosTableAdapters.QueriesPresupuestos();
            this.presupSubCantidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupSubCantidadTableAdapter = new Promowork.DatosPresupuestosTableAdapters.PresupSubCantidadTableAdapter();
            numPresupLabel = new System.Windows.Forms.Label();
            nomPresupLabel = new System.Windows.Forms.Label();
            desPresupLabel = new System.Windows.Forms.Label();
            fechaPresupLabel = new System.Windows.Forms.Label();
            licObraPresupLabel = new System.Windows.Forms.Label();
            idClienteLabel1 = new System.Windows.Forms.Label();
            idObraLabel1 = new System.Windows.Forms.Label();
            certificacionAFacturarLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFacturarDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFacturarSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presupCabGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUltCertificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificacionAFacturarSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licObraPresupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPresupDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPresupDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPresupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomPresupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresupSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presupCabBindingNavigator)).BeginInit();
            this.presupCabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosPresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupSubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupSubCantidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numPresupLabel
            // 
            numPresupLabel.AutoSize = true;
            numPresupLabel.Location = new System.Drawing.Point(29, 16);
            numPresupLabel.Name = "numPresupLabel";
            numPresupLabel.Size = new System.Drawing.Size(47, 13);
            numPresupLabel.TabIndex = 4;
            numPresupLabel.Text = "Número:";
            // 
            // nomPresupLabel
            // 
            nomPresupLabel.AutoSize = true;
            nomPresupLabel.Location = new System.Drawing.Point(29, 42);
            nomPresupLabel.Name = "nomPresupLabel";
            nomPresupLabel.Size = new System.Drawing.Size(47, 13);
            nomPresupLabel.TabIndex = 6;
            nomPresupLabel.Text = "Nombre:";
            // 
            // desPresupLabel
            // 
            desPresupLabel.AutoSize = true;
            desPresupLabel.Location = new System.Drawing.Point(10, 68);
            desPresupLabel.Name = "desPresupLabel";
            desPresupLabel.Size = new System.Drawing.Size(66, 13);
            desPresupLabel.TabIndex = 8;
            desPresupLabel.Text = "Descripción:";
            // 
            // fechaPresupLabel
            // 
            fechaPresupLabel.AutoSize = true;
            fechaPresupLabel.Location = new System.Drawing.Point(36, 94);
            fechaPresupLabel.Name = "fechaPresupLabel";
            fechaPresupLabel.Size = new System.Drawing.Size(40, 13);
            fechaPresupLabel.TabIndex = 10;
            fechaPresupLabel.Text = "Fecha:";
            // 
            // licObraPresupLabel
            // 
            licObraPresupLabel.AutoSize = true;
            licObraPresupLabel.Location = new System.Drawing.Point(218, 94);
            licObraPresupLabel.Name = "licObraPresupLabel";
            licObraPresupLabel.Size = new System.Drawing.Size(53, 13);
            licObraPresupLabel.TabIndex = 12;
            licObraPresupLabel.Text = "Lic. Obra:";
            // 
            // idClienteLabel1
            // 
            idClienteLabel1.AutoSize = true;
            idClienteLabel1.Location = new System.Drawing.Point(34, 120);
            idClienteLabel1.Name = "idClienteLabel1";
            idClienteLabel1.Size = new System.Drawing.Size(42, 13);
            idClienteLabel1.TabIndex = 14;
            idClienteLabel1.Text = "Cliente:";
            // 
            // idObraLabel1
            // 
            idObraLabel1.AutoSize = true;
            idObraLabel1.Location = new System.Drawing.Point(43, 147);
            idObraLabel1.Name = "idObraLabel1";
            idObraLabel1.Size = new System.Drawing.Size(33, 13);
            idObraLabel1.TabIndex = 16;
            idObraLabel1.Text = "Obra:";
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView3.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Empty.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView3.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.White;
            this.gridView3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView3.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.gridView3.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView3.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridView3.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView3.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FooterPanel.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView3.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupButton.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.GroupButton.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupFooter.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView3.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView3.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView3.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupRow.BackColor = System.Drawing.Color.Teal;
            this.gridView3.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseFont = true;
            this.gridView3.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HorzLine.BackColor = System.Drawing.Color.Gray;
            this.gridView3.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridView3.Appearance.Preview.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.Preview.Options.UseBackColor = true;
            this.gridView3.Appearance.Preview.Options.UseForeColor = true;
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Appearance.Row.Options.UseForeColor = true;
            this.gridView3.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView3.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView3.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView3.Appearance.TopNewRow.Options.UseForeColor = true;
            this.gridView3.Appearance.VertLine.BackColor = System.Drawing.Color.Gray;
            this.gridView3.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView3.ChildGridLevelName = "SUBDETALLES";
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPresupCap1,
            this.colNumPresupDet,
            this.colUM,
            this.colNomPresupDet,
            this.colDesPresupDet,
            this.colCantidad,
            this.colCantExtra,
            this.colPrecio,
            this.colColor2,
            this.colIdPresupCab2,
            this.colaFacturar,
            this.colIdPresupDet,
            this.colTotalaFacturar,
            this.colTotalDet1,
            this.colTotalFacturado1,
            this.gridColumn2,
            this.colModifDet,
            this.colCantDetFact,
            this.gridColumn4,
            this.colTotalPendiente,
            this.colDescPrecio});
            this.gridView3.DetailHeight = 999999;
            this.gridView3.GridControl = this.presupCapGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsBehavior.SmartVertScrollBar = false;
            this.gridView3.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView3.OptionsDetail.ShowDetailTabs = false;
            this.gridView3.OptionsDetail.SmartDetailHeight = true;
            this.gridView3.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView3.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.RowAutoHeight = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView3.ViewCaption = "DETALLES";
            this.gridView3.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.gridView3_MasterRowExpanding);
            this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
            this.gridView3.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView3_CellValueChanged);
            this.gridView3.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView3_CellValueChanging);
            this.gridView3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView3_KeyUp);
            // 
            // colIdPresupCap1
            // 
            this.colIdPresupCap1.FieldName = "IdPresupCap";
            this.colIdPresupCap1.Name = "colIdPresupCap1";
            // 
            // colNumPresupDet
            // 
            this.colNumPresupDet.Caption = "Número";
            this.colNumPresupDet.ColumnEdit = this.NumCap;
            this.colNumPresupDet.FieldName = "NumPresupDet";
            this.colNumPresupDet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNumPresupDet.Name = "colNumPresupDet";
            this.colNumPresupDet.Visible = true;
            this.colNumPresupDet.VisibleIndex = 0;
            this.colNumPresupDet.Width = 77;
            // 
            // NumCap
            // 
            this.NumCap.AutoHeight = false;
            this.NumCap.MaxLength = 5;
            this.NumCap.Name = "NumCap";
            // 
            // colUM
            // 
            this.colUM.Caption = "U.M.";
            this.colUM.FieldName = "UM";
            this.colUM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colUM.Name = "colUM";
            this.colUM.Visible = true;
            this.colUM.VisibleIndex = 1;
            this.colUM.Width = 40;
            // 
            // colNomPresupDet
            // 
            this.colNomPresupDet.Caption = "Nombre";
            this.colNomPresupDet.ColumnEdit = this.descripcion;
            this.colNomPresupDet.FieldName = "NomPresupDet";
            this.colNomPresupDet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNomPresupDet.Name = "colNomPresupDet";
            this.colNomPresupDet.Visible = true;
            this.colNomPresupDet.VisibleIndex = 2;
            this.colNomPresupDet.Width = 295;
            // 
            // descripcion
            // 
            this.descripcion.AcceptsTab = true;
            this.descripcion.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.descripcion.Appearance.Options.UseFont = true;
            this.descripcion.Name = "descripcion";
            // 
            // colDesPresupDet
            // 
            this.colDesPresupDet.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F);
            this.colDesPresupDet.AppearanceCell.Options.HighPriority = true;
            this.colDesPresupDet.AppearanceCell.Options.UseFont = true;
            this.colDesPresupDet.Caption = "Descripción";
            this.colDesPresupDet.ColumnEdit = this.descripcion;
            this.colDesPresupDet.FieldName = "DesPresupDet";
            this.colDesPresupDet.Name = "colDesPresupDet";
            this.colDesPresupDet.Visible = true;
            this.colDesPresupDet.VisibleIndex = 3;
            this.colDesPresupDet.Width = 259;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.DisplayFormat.FormatString = "N3";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 4;
            this.colCantidad.Width = 60;
            // 
            // colCantExtra
            // 
            this.colCantExtra.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantExtra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantExtra.Caption = "Extra";
            this.colCantExtra.DisplayFormat.FormatString = "N3";
            this.colCantExtra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantExtra.FieldName = "CantExtra";
            this.colCantExtra.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCantExtra.Name = "colCantExtra";
            this.colCantExtra.Visible = true;
            this.colCantExtra.VisibleIndex = 6;
            this.colCantExtra.Width = 50;
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio.Caption = "Precio";
            this.colPrecio.DisplayFormat.FormatString = "C3";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 5;
            this.colPrecio.Width = 60;
            // 
            // colColor2
            // 
            this.colColor2.FieldName = "Color";
            this.colColor2.Name = "colColor2";
            // 
            // colIdPresupCab2
            // 
            this.colIdPresupCab2.FieldName = "IdPresupCab";
            this.colIdPresupCab2.Name = "colIdPresupCab2";
            // 
            // colaFacturar
            // 
            this.colaFacturar.AppearanceHeader.Options.UseTextOptions = true;
            this.colaFacturar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colaFacturar.Caption = "A Facturar";
            this.colaFacturar.ColumnEdit = this.aFacturarDet;
            this.colaFacturar.DisplayFormat.FormatString = "N3";
            this.colaFacturar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colaFacturar.FieldName = "aFacturar";
            this.colaFacturar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colaFacturar.Name = "colaFacturar";
            this.colaFacturar.ToolTip = "Cantidad a Facturar";
            this.colaFacturar.Visible = true;
            this.colaFacturar.VisibleIndex = 12;
            this.colaFacturar.Width = 80;
            // 
            // aFacturarDet
            // 
            this.aFacturarDet.AutoHeight = false;
            this.aFacturarDet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Partida terminada", null, null, true)});
            this.aFacturarDet.DisplayFormat.FormatString = "N3";
            this.aFacturarDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aFacturarDet.EditFormat.FormatString = "N3";
            this.aFacturarDet.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aFacturarDet.Name = "aFacturarDet";
            this.aFacturarDet.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.aFacturarDet_ButtonPressed);
            // 
            // colIdPresupDet
            // 
            this.colIdPresupDet.FieldName = "IdPresupDet";
            this.colIdPresupDet.Name = "colIdPresupDet";
            // 
            // colTotalaFacturar
            // 
            this.colTotalaFacturar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalaFacturar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalaFacturar.Caption = "Total";
            this.colTotalaFacturar.DisplayFormat.FormatString = "C2";
            this.colTotalaFacturar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalaFacturar.FieldName = "TotalaFacturar";
            this.colTotalaFacturar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalaFacturar.Name = "colTotalaFacturar";
            this.colTotalaFacturar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalaFacturar.ToolTip = "Importe a Facturar";
            this.colTotalaFacturar.Visible = true;
            this.colTotalaFacturar.VisibleIndex = 14;
            this.colTotalaFacturar.Width = 89;
            // 
            // colTotalDet1
            // 
            this.colTotalDet1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalDet1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalDet1.Caption = "Total";
            this.colTotalDet1.DisplayFormat.FormatString = "C2";
            this.colTotalDet1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDet1.FieldName = "TotalDet";
            this.colTotalDet1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalDet1.Name = "colTotalDet1";
            this.colTotalDet1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalDet1.ToolTip = "Importe Total del detalle";
            this.colTotalDet1.Visible = true;
            this.colTotalDet1.VisibleIndex = 7;
            this.colTotalDet1.Width = 100;
            // 
            // colTotalFacturado1
            // 
            this.colTotalFacturado1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalFacturado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalFacturado1.Caption = "Total";
            this.colTotalFacturado1.DisplayFormat.FormatString = "C2";
            this.colTotalFacturado1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFacturado1.FieldName = "TotalFacturado";
            this.colTotalFacturado1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalFacturado1.Name = "colTotalFacturado1";
            this.colTotalFacturado1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalFacturado1.ToolTip = "Importe Facturado";
            this.colTotalFacturado1.Visible = true;
            this.colTotalFacturado1.VisibleIndex = 9;
            this.colTotalFacturado1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.gridColumn2.AppearanceCell.Options.HighPriority = true;
            this.gridColumn2.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumn2.MinWidth = 10;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Width = 18;
            // 
            // colModifDet
            // 
            this.colModifDet.FieldName = "ModifDet";
            this.colModifDet.Name = "colModifDet";
            // 
            // colCantDetFact
            // 
            this.colCantDetFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantDetFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantDetFact.Caption = "Facturado";
            this.colCantDetFact.FieldName = "CantDetFact";
            this.colCantDetFact.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCantDetFact.Name = "colCantDetFact";
            this.colCantDetFact.Visible = true;
            this.colCantDetFact.VisibleIndex = 8;
            this.colCantDetFact.Width = 80;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn4.Caption = "Pendiente";
            this.gridColumn4.DisplayFormat.FormatString = "N2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Pendiente";
            this.gridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundExpression = "[Cantidad]+Iif(IsNull([CantExtra]), 0 ,[CantExtra])-Iif(IsNull([CantDetFact]), 0 " +
                ",[CantDetFact])";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            this.gridColumn4.Width = 80;
            // 
            // colTotalPendiente
            // 
            this.colTotalPendiente.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalPendiente.Caption = "Total";
            this.colTotalPendiente.DisplayFormat.FormatString = "C2";
            this.colTotalPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPendiente.FieldName = "TotalPendiente";
            this.colTotalPendiente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalPendiente.Name = "colTotalPendiente";
            this.colTotalPendiente.Visible = true;
            this.colTotalPendiente.VisibleIndex = 11;
            this.colTotalPendiente.Width = 100;
            // 
            // colDescPrecio
            // 
            this.colDescPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescPrecio.Caption = "Desc.";
            this.colDescPrecio.FieldName = "DescPrecio";
            this.colDescPrecio.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colDescPrecio.Name = "colDescPrecio";
            this.colDescPrecio.Visible = true;
            this.colDescPrecio.VisibleIndex = 13;
            this.colDescPrecio.Width = 50;
            // 
            // presupCapGridControl
            // 
            this.presupCapGridControl.DataSource = this.presupCapBindingSource;
            this.presupCapGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode3.LevelTemplate = this.gridView3;
            gridLevelNode4.LevelTemplate = this.gridView4;
            gridLevelNode4.RelationName = "FK_PresupSub_PresupDet";
            gridLevelNode3.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            gridLevelNode3.RelationName = "FK_PresupDet_PresupCap";
            this.presupCapGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.presupCapGridControl.Location = new System.Drawing.Point(0, 26);
            this.presupCapGridControl.MainView = this.gridView2;
            this.presupCapGridControl.Name = "presupCapGridControl";
            this.presupCapGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.descripcion,
            this.NumCap,
            this.aFacturarDet,
            this.aFacturarSub});
            this.presupCapGridControl.Size = new System.Drawing.Size(1354, 381);
            this.presupCapGridControl.TabIndex = 0;
            this.presupCapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView4,
            this.gridView3});
            // 
            // presupCapBindingSource
            // 
            this.presupCapBindingSource.DataMember = "PresupCap";
            this.presupCapBindingSource.DataSource = this.datosPresupuestos;
            // 
            // datosPresupuestos
            // 
            this.datosPresupuestos.DataSetName = "DatosPresupuestos";
            this.datosPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.gridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.LimeGreen;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LimeGreen;
            this.gridView2.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridView2.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseFont = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.LimeGreen;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.ChildGridLevelName = "DETALLES";
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPresupCab1,
            this.colIdPresupCap,
            this.colNumCapPresup,
            this.colDesCapPresup,
            this.colObsCapPresup,
            this.colExtra,
            this.colColor1,
            this.colTotalCap,
            this.colTotalCapaFact,
            this.colTotalFacturado,
            this.gridColumn1,
            this.colModifCap,
            this.colPendiente,
            this.colExtra2});
            this.gridView2.DetailHeight = 999999;
            this.gridView2.GridControl = this.presupCapGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsDetail.SmartDetailHeight = true;
            this.gridView2.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView2.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView2.OptionsLayout.Columns.StoreLayout = false;
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.ViewCaption = "CAPITULOS";
            this.gridView2.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.gridView2_MasterRowExpanding);
            this.gridView2.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView2_InitNewRow);
            this.gridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            // 
            // colIdPresupCab1
            // 
            this.colIdPresupCab1.FieldName = "IdPresupCab";
            this.colIdPresupCab1.Name = "colIdPresupCab1";
            // 
            // colIdPresupCap
            // 
            this.colIdPresupCap.FieldName = "IdPresupCap";
            this.colIdPresupCap.Name = "colIdPresupCap";
            this.colIdPresupCap.OptionsColumn.ReadOnly = true;
            // 
            // colNumCapPresup
            // 
            this.colNumCapPresup.Caption = "Número";
            this.colNumCapPresup.ColumnEdit = this.NumCap;
            this.colNumCapPresup.FieldName = "NumCapPresup";
            this.colNumCapPresup.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNumCapPresup.Name = "colNumCapPresup";
            this.colNumCapPresup.Visible = true;
            this.colNumCapPresup.VisibleIndex = 0;
            this.colNumCapPresup.Width = 155;
            // 
            // colDesCapPresup
            // 
            this.colDesCapPresup.AppearanceCell.Options.UseTextOptions = true;
            this.colDesCapPresup.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDesCapPresup.Caption = "Descripción";
            this.colDesCapPresup.FieldName = "DesCapPresup";
            this.colDesCapPresup.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDesCapPresup.Name = "colDesCapPresup";
            this.colDesCapPresup.Visible = true;
            this.colDesCapPresup.VisibleIndex = 1;
            this.colDesCapPresup.Width = 215;
            // 
            // colObsCapPresup
            // 
            this.colObsCapPresup.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colObsCapPresup.AppearanceCell.Options.HighPriority = true;
            this.colObsCapPresup.AppearanceCell.Options.UseFont = true;
            this.colObsCapPresup.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colObsCapPresup.AppearanceHeader.BackColor2 = System.Drawing.Color.Green;
            this.colObsCapPresup.AppearanceHeader.Options.UseBackColor = true;
            this.colObsCapPresup.Caption = "Observaciones";
            this.colObsCapPresup.ColumnEdit = this.descripcion;
            this.colObsCapPresup.FieldName = "ObsCapPresup";
            this.colObsCapPresup.Name = "colObsCapPresup";
            this.colObsCapPresup.Visible = true;
            this.colObsCapPresup.VisibleIndex = 4;
            this.colObsCapPresup.Width = 23;
            // 
            // colExtra
            // 
            this.colExtra.AppearanceHeader.Options.UseTextOptions = true;
            this.colExtra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExtra.Caption = "Extra";
            this.colExtra.FieldName = "Extra";
            this.colExtra.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colExtra.Name = "colExtra";
            this.colExtra.Visible = true;
            this.colExtra.VisibleIndex = 2;
            this.colExtra.Width = 40;
            // 
            // colColor1
            // 
            this.colColor1.FieldName = "Color";
            this.colColor1.Name = "colColor1";
            // 
            // colTotalCap
            // 
            this.colTotalCap.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalCap.Caption = "Total";
            this.colTotalCap.DisplayFormat.FormatString = "C2";
            this.colTotalCap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCap.FieldName = "TotalCap";
            this.colTotalCap.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalCap.Name = "colTotalCap";
            this.colTotalCap.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalCap.Visible = true;
            this.colTotalCap.VisibleIndex = 5;
            this.colTotalCap.Width = 270;
            // 
            // colTotalCapaFact
            // 
            this.colTotalCapaFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCapaFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalCapaFact.Caption = "A Facturar";
            this.colTotalCapaFact.DisplayFormat.FormatString = "C2";
            this.colTotalCapaFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCapaFact.FieldName = "TotalCapaFact";
            this.colTotalCapaFact.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalCapaFact.Name = "colTotalCapaFact";
            this.colTotalCapaFact.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalCapaFact.Visible = true;
            this.colTotalCapaFact.VisibleIndex = 8;
            this.colTotalCapaFact.Width = 220;
            // 
            // colTotalFacturado
            // 
            this.colTotalFacturado.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalFacturado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalFacturado.Caption = "Facturado";
            this.colTotalFacturado.DisplayFormat.FormatString = "C2";
            this.colTotalFacturado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFacturado.FieldName = "TotalFacturado";
            this.colTotalFacturado.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalFacturado.Name = "colTotalFacturado";
            this.colTotalFacturado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalFacturado.Visible = true;
            this.colTotalFacturado.VisibleIndex = 6;
            this.colTotalFacturado.Width = 180;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.gridColumn1.AppearanceCell.Options.HighPriority = true;
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumn1.MinWidth = 10;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Width = 36;
            // 
            // colModifCap
            // 
            this.colModifCap.FieldName = "ModifCap";
            this.colModifCap.Name = "colModifCap";
            // 
            // colPendiente
            // 
            this.colPendiente.AppearanceHeader.Options.UseTextOptions = true;
            this.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPendiente.Caption = "Pendiente";
            this.colPendiente.DisplayFormat.FormatString = "C2";
            this.colPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPendiente.FieldName = "Pendiente";
            this.colPendiente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colPendiente.Name = "colPendiente";
            this.colPendiente.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPendiente.Visible = true;
            this.colPendiente.VisibleIndex = 7;
            this.colPendiente.Width = 180;
            // 
            // colExtra2
            // 
            this.colExtra2.FieldName = "Extra2";
            this.colExtra2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colExtra2.Name = "colExtra2";
            this.colExtra2.Visible = true;
            this.colExtra2.VisibleIndex = 3;
            this.colExtra2.Width = 40;
            // 
            // aFacturarSub
            // 
            this.aFacturarSub.AutoHeight = false;
            this.aFacturarSub.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Partida terminada", null, null, true)});
            this.aFacturarSub.DisplayFormat.FormatString = "N3";
            this.aFacturarSub.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aFacturarSub.EditFormat.FormatString = "N3";
            this.aFacturarSub.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aFacturarSub.Name = "aFacturarSub";
            this.aFacturarSub.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.aFacturarSub_ButtonPressed);
            // 
            // gridView4
            // 
            this.gridView4.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView4.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPresupSub,
            this.colIdPresupDet1,
            this.colIdPresupCab3,
            this.colNumPresupSub,
            this.colUM1,
            this.colNomPresupSub,
            this.colDesPresupSub,
            this.colColor3,
            this.colIdPresupCap2,
            this.colCantInf,
            this.colCantidad1,
            this.colPrecio1,
            this.colCantExtra1,
            this.colTotalSub,
            this.colCantSubFact,
            this.colTotalFacturado2,
            this.gridColumn3,
            this.colPediente,
            this.colaFacturar1,
            this.colDescPrecio1,
            this.colTotalaFacturar1});
            this.gridView4.DetailHeight = 999999;
            this.gridView4.GridControl = this.presupCapGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView4.OptionsBehavior.SmartVertScrollBar = false;
            this.gridView4.OptionsDetail.ShowDetailTabs = false;
            this.gridView4.OptionsDetail.SmartDetailHeight = true;
            this.gridView4.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView4.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView4.OptionsView.RowAutoHeight = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView4.ViewCaption = "SUBDETALLES";
            this.gridView4.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView4_InitNewRow);
            this.gridView4.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView4_FocusedRowChanged);
            this.gridView4.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView4_CellValueChanged);
            this.gridView4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView4_KeyUp);
            // 
            // colIdPresupSub
            // 
            this.colIdPresupSub.FieldName = "IdPresupSub";
            this.colIdPresupSub.Name = "colIdPresupSub";
            this.colIdPresupSub.OptionsColumn.ReadOnly = true;
            // 
            // colIdPresupDet1
            // 
            this.colIdPresupDet1.FieldName = "IdPresupDet";
            this.colIdPresupDet1.Name = "colIdPresupDet1";
            // 
            // colIdPresupCab3
            // 
            this.colIdPresupCab3.FieldName = "IdPresupCab";
            this.colIdPresupCab3.Name = "colIdPresupCab3";
            // 
            // colNumPresupSub
            // 
            this.colNumPresupSub.Caption = "Nº.";
            this.colNumPresupSub.ColumnEdit = this.NumCap;
            this.colNumPresupSub.FieldName = "NumPresupSub";
            this.colNumPresupSub.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNumPresupSub.Name = "colNumPresupSub";
            this.colNumPresupSub.Visible = true;
            this.colNumPresupSub.VisibleIndex = 0;
            this.colNumPresupSub.Width = 39;
            // 
            // colUM1
            // 
            this.colUM1.Caption = "U.M.";
            this.colUM1.FieldName = "UM";
            this.colUM1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colUM1.Name = "colUM1";
            this.colUM1.Visible = true;
            this.colUM1.VisibleIndex = 1;
            this.colUM1.Width = 40;
            // 
            // colNomPresupSub
            // 
            this.colNomPresupSub.Caption = "Nombre";
            this.colNomPresupSub.ColumnEdit = this.descripcion;
            this.colNomPresupSub.FieldName = "NomPresupSub";
            this.colNomPresupSub.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNomPresupSub.Name = "colNomPresupSub";
            this.colNomPresupSub.Visible = true;
            this.colNomPresupSub.VisibleIndex = 2;
            this.colNomPresupSub.Width = 295;
            // 
            // colDesPresupSub
            // 
            this.colDesPresupSub.Caption = "Descripción";
            this.colDesPresupSub.ColumnEdit = this.descripcion;
            this.colDesPresupSub.FieldName = "DesPresupSub";
            this.colDesPresupSub.Name = "colDesPresupSub";
            this.colDesPresupSub.Visible = true;
            this.colDesPresupSub.VisibleIndex = 3;
            this.colDesPresupSub.Width = 38;
            // 
            // colColor3
            // 
            this.colColor3.FieldName = "Color";
            this.colColor3.Name = "colColor3";
            // 
            // colIdPresupCap2
            // 
            this.colIdPresupCap2.FieldName = "IdPresupCap";
            this.colIdPresupCap2.Name = "colIdPresupCap2";
            // 
            // colCantInf
            // 
            this.colCantInf.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantInf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantInf.Caption = "Cant. Inf.";
            this.colCantInf.DisplayFormat.FormatString = "N3";
            this.colCantInf.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantInf.FieldName = "CantInf";
            this.colCantInf.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCantInf.Name = "colCantInf";
            this.colCantInf.Visible = true;
            this.colCantInf.VisibleIndex = 4;
            this.colCantInf.Width = 60;
            // 
            // colCantidad1
            // 
            this.colCantidad1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad1.Caption = "Cantidad";
            this.colCantidad1.DisplayFormat.FormatString = "N3";
            this.colCantidad1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad1.FieldName = "Cantidad";
            this.colCantidad1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCantidad1.Name = "colCantidad1";
            this.colCantidad1.Visible = true;
            this.colCantidad1.VisibleIndex = 5;
            this.colCantidad1.Width = 60;
            // 
            // colPrecio1
            // 
            this.colPrecio1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio1.Caption = "Precio";
            this.colPrecio1.DisplayFormat.FormatString = "C3";
            this.colPrecio1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio1.FieldName = "Precio";
            this.colPrecio1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colPrecio1.Name = "colPrecio1";
            this.colPrecio1.Visible = true;
            this.colPrecio1.VisibleIndex = 6;
            this.colPrecio1.Width = 60;
            // 
            // colCantExtra1
            // 
            this.colCantExtra1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantExtra1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantExtra1.Caption = "Extra";
            this.colCantExtra1.DisplayFormat.FormatString = "N3";
            this.colCantExtra1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantExtra1.FieldName = "CantExtra";
            this.colCantExtra1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCantExtra1.Name = "colCantExtra1";
            this.colCantExtra1.Visible = true;
            this.colCantExtra1.VisibleIndex = 7;
            this.colCantExtra1.Width = 50;
            // 
            // colTotalSub
            // 
            this.colTotalSub.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalSub.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalSub.Caption = "Importe";
            this.colTotalSub.CustomizationCaption = "Total";
            this.colTotalSub.DisplayFormat.FormatString = "C2";
            this.colTotalSub.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalSub.FieldName = "TotalSub";
            this.colTotalSub.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalSub.Name = "colTotalSub";
            this.colTotalSub.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalSub.ToolTip = "Importe Total del Subdetalle";
            this.colTotalSub.Visible = true;
            this.colTotalSub.VisibleIndex = 8;
            this.colTotalSub.Width = 100;
            // 
            // colCantSubFact
            // 
            this.colCantSubFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantSubFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantSubFact.Caption = "Facturado";
            this.colCantSubFact.FieldName = "CantSubFact";
            this.colCantSubFact.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCantSubFact.Name = "colCantSubFact";
            this.colCantSubFact.Visible = true;
            this.colCantSubFact.VisibleIndex = 9;
            this.colCantSubFact.Width = 80;
            // 
            // colTotalFacturado2
            // 
            this.colTotalFacturado2.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalFacturado2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalFacturado2.Caption = "Total";
            this.colTotalFacturado2.DisplayFormat.FormatString = "C2";
            this.colTotalFacturado2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFacturado2.FieldName = "TotalFacturado";
            this.colTotalFacturado2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalFacturado2.Name = "colTotalFacturado2";
            this.colTotalFacturado2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalFacturado2.ToolTip = "Importe Facturado";
            this.colTotalFacturado2.Visible = true;
            this.colTotalFacturado2.VisibleIndex = 10;
            this.colTotalFacturado2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn3.Caption = "Pendiente";
            this.gridColumn3.DisplayFormat.FormatString = "N2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "Pendiente";
            this.gridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundExpression = "[Cantidad]+Iif(IsNull([CantExtra]), 0 ,[CantExtra])-Iif(IsNull([CantSubFact]), 0 " +
                ",[CantSubFact])";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 11;
            this.gridColumn3.Width = 80;
            // 
            // colPediente
            // 
            this.colPediente.AppearanceHeader.Options.UseTextOptions = true;
            this.colPediente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPediente.Caption = "Total";
            this.colPediente.DisplayFormat.FormatString = "C2";
            this.colPediente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPediente.FieldName = "Pediente";
            this.colPediente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colPediente.Name = "colPediente";
            this.colPediente.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPediente.ToolTip = "Importe Pendiente";
            this.colPediente.Visible = true;
            this.colPediente.VisibleIndex = 12;
            this.colPediente.Width = 100;
            // 
            // colaFacturar1
            // 
            this.colaFacturar1.AppearanceHeader.Options.UseTextOptions = true;
            this.colaFacturar1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colaFacturar1.Caption = "A Facturar";
            this.colaFacturar1.ColumnEdit = this.aFacturarSub;
            this.colaFacturar1.DisplayFormat.FormatString = "N3";
            this.colaFacturar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colaFacturar1.FieldName = "aFacturar";
            this.colaFacturar1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colaFacturar1.Name = "colaFacturar1";
            this.colaFacturar1.ToolTip = "Cantidad a Facturar";
            this.colaFacturar1.Visible = true;
            this.colaFacturar1.VisibleIndex = 13;
            this.colaFacturar1.Width = 80;
            // 
            // colDescPrecio1
            // 
            this.colDescPrecio1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescPrecio1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDescPrecio1.Caption = "Desc.";
            this.colDescPrecio1.FieldName = "DescPrecio";
            this.colDescPrecio1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colDescPrecio1.Name = "colDescPrecio1";
            this.colDescPrecio1.Visible = true;
            this.colDescPrecio1.VisibleIndex = 14;
            this.colDescPrecio1.Width = 50;
            // 
            // colTotalaFacturar1
            // 
            this.colTotalaFacturar1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalaFacturar1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalaFacturar1.Caption = "Total";
            this.colTotalaFacturar1.DisplayFormat.FormatString = "C2";
            this.colTotalaFacturar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalaFacturar1.FieldName = "TotalaFacturar";
            this.colTotalaFacturar1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTotalaFacturar1.Name = "colTotalaFacturar1";
            this.colTotalaFacturar1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalaFacturar1.ToolTip = "Importe a Facturar";
            this.colTotalaFacturar1.Visible = true;
            this.colTotalaFacturar1.VisibleIndex = 15;
            this.colTotalaFacturar1.Width = 88;
            // 
            // certificacionAFacturarLabel
            // 
            certificacionAFacturarLabel.AutoSize = true;
            certificacionAFacturarLabel.Location = new System.Drawing.Point(24, 220);
            certificacionAFacturarLabel.Name = "certificacionAFacturarLabel";
            certificacionAFacturarLabel.Size = new System.Drawing.Size(120, 13);
            certificacionAFacturarLabel.TabIndex = 21;
            certificacionAFacturarLabel.Text = "Certificación A Facturar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(215, 220);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 13);
            label1.TabIndex = 23;
            label1.Text = "Última Certificación:";
            // 
            // presupCabBindingSource
            // 
            this.presupCabBindingSource.DataMember = "PresupCab";
            this.presupCabBindingSource.DataSource = this.datosPresupuestos;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.presupCapGridControl);
            this.splitContainer1.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 654);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.presupCabGridControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(label1);
            this.splitContainer2.Panel2.Controls.Add(this.spnUltCertificacion);
            this.splitContainer2.Panel2.Controls.Add(certificacionAFacturarLabel);
            this.splitContainer2.Panel2.Controls.Add(this.certificacionAFacturarSpinEdit);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(idObraLabel1);
            this.splitContainer2.Panel2.Controls.Add(this.idObraComboBox);
            this.splitContainer2.Panel2.Controls.Add(idClienteLabel1);
            this.splitContainer2.Panel2.Controls.Add(this.idClienteComboBox);
            this.splitContainer2.Panel2.Controls.Add(licObraPresupLabel);
            this.splitContainer2.Panel2.Controls.Add(this.licObraPresupTextEdit);
            this.splitContainer2.Panel2.Controls.Add(fechaPresupLabel);
            this.splitContainer2.Panel2.Controls.Add(this.fechaPresupDateEdit);
            this.splitContainer2.Panel2.Controls.Add(desPresupLabel);
            this.splitContainer2.Panel2.Controls.Add(this.desPresupTextEdit);
            this.splitContainer2.Panel2.Controls.Add(nomPresupLabel);
            this.splitContainer2.Panel2.Controls.Add(this.nomPresupTextEdit);
            this.splitContainer2.Panel2.Controls.Add(numPresupLabel);
            this.splitContainer2.Panel2.Controls.Add(this.numPresupSpinEdit);
            this.splitContainer2.Size = new System.Drawing.Size(1354, 243);
            this.splitContainer2.SplitterDistance = 942;
            this.splitContainer2.TabIndex = 1;
            // 
            // presupCabGridControl
            // 
            this.presupCabGridControl.DataSource = this.presupCabBindingSource;
            this.presupCabGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presupCabGridControl.Location = new System.Drawing.Point(0, 0);
            this.presupCabGridControl.MainView = this.gridView1;
            this.presupCabGridControl.Name = "presupCabGridControl";
            this.presupCabGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Clientes,
            this.Obras});
            this.presupCabGridControl.Size = new System.Drawing.Size(942, 243);
            this.presupCabGridControl.TabIndex = 0;
            this.presupCabGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPresupCab,
            this.colIdEmpresa,
            this.colIdCliente,
            this.colIdObra,
            this.colIdUsuario,
            this.colDirObraPresup,
            this.colNumPresup,
            this.colNomPresup,
            this.colDesPresup,
            this.colFechaPresup,
            this.colLicObraPresup,
            this.colFacturado,
            this.colColor,
            this.colCopiaPresup,
            this.colTotalPresup,
            this.colTotalPresupFact,
            this.colTotalPresupPendiente,
            this.colaFacturarCab,
            this.colModifCab});
            this.gridView1.GridControl = this.presupCabGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // colIdPresupCab
            // 
            this.colIdPresupCab.FieldName = "IdPresupCab";
            this.colIdPresupCab.Name = "colIdPresupCab";
            this.colIdPresupCab.OptionsColumn.AllowEdit = false;
            this.colIdPresupCab.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Cliente";
            this.colIdCliente.ColumnEdit = this.Clientes;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 3;
            this.colIdCliente.Width = 127;
            // 
            // Clientes
            // 
            this.Clientes.AutoHeight = false;
            this.Clientes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Clientes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesCliente", "Cliente", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Clientes.DataSource = this.clientesBindingSource;
            this.Clientes.DisplayMember = "DesCliente";
            this.Clientes.Name = "Clientes";
            this.Clientes.NullText = "";
            this.Clientes.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.datosPresupuestos;
            // 
            // colIdObra
            // 
            this.colIdObra.Caption = "Obra";
            this.colIdObra.ColumnEdit = this.Obras;
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdObra.Visible = true;
            this.colIdObra.VisibleIndex = 4;
            this.colIdObra.Width = 126;
            // 
            // Obras
            // 
            this.Obras.AutoHeight = false;
            this.Obras.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Obras.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Obra", "Obra", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Obras.DataSource = this.obrasBindingSource;
            this.Obras.DisplayMember = "Obra";
            this.Obras.Name = "Obras";
            this.Obras.NullText = "";
            this.Obras.ValueMember = "IdObra";
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.datosPresupuestos;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colDirObraPresup
            // 
            this.colDirObraPresup.Caption = "Dirección Obra";
            this.colDirObraPresup.FieldName = "DirObraPresup";
            this.colDirObraPresup.Name = "colDirObraPresup";
            this.colDirObraPresup.Width = 138;
            // 
            // colNumPresup
            // 
            this.colNumPresup.AppearanceCell.Options.UseTextOptions = true;
            this.colNumPresup.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumPresup.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumPresup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumPresup.Caption = "Nº.";
            this.colNumPresup.FieldName = "NumPresup";
            this.colNumPresup.Name = "colNumPresup";
            this.colNumPresup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumPresup.Visible = true;
            this.colNumPresup.VisibleIndex = 0;
            this.colNumPresup.Width = 40;
            // 
            // colNomPresup
            // 
            this.colNomPresup.Caption = "Nombre";
            this.colNomPresup.FieldName = "NomPresup";
            this.colNomPresup.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNomPresup.Name = "colNomPresup";
            this.colNomPresup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNomPresup.Visible = true;
            this.colNomPresup.VisibleIndex = 2;
            this.colNomPresup.Width = 159;
            // 
            // colDesPresup
            // 
            this.colDesPresup.Caption = "Descripción";
            this.colDesPresup.FieldName = "DesPresup";
            this.colDesPresup.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesPresup.Name = "colDesPresup";
            this.colDesPresup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesPresup.Width = 193;
            // 
            // colFechaPresup
            // 
            this.colFechaPresup.Caption = "Fecha";
            this.colFechaPresup.FieldName = "FechaPresup";
            this.colFechaPresup.Name = "colFechaPresup";
            this.colFechaPresup.Visible = true;
            this.colFechaPresup.VisibleIndex = 1;
            this.colFechaPresup.Width = 64;
            // 
            // colLicObraPresup
            // 
            this.colLicObraPresup.Caption = "Licencia Obra";
            this.colLicObraPresup.FieldName = "LicObraPresup";
            this.colLicObraPresup.Name = "colLicObraPresup";
            this.colLicObraPresup.Width = 77;
            // 
            // colFacturado
            // 
            this.colFacturado.FieldName = "Facturado";
            this.colFacturado.Name = "colFacturado";
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            // 
            // colCopiaPresup
            // 
            this.colCopiaPresup.FieldName = "CopiaPresup";
            this.colCopiaPresup.Name = "colCopiaPresup";
            // 
            // colTotalPresup
            // 
            this.colTotalPresup.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalPresup.AppearanceCell.Options.UseFont = true;
            this.colTotalPresup.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPresup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalPresup.Caption = "Total";
            this.colTotalPresup.DisplayFormat.FormatString = "C2";
            this.colTotalPresup.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPresup.FieldName = "TotalPresup";
            this.colTotalPresup.Name = "colTotalPresup";
            this.colTotalPresup.Visible = true;
            this.colTotalPresup.VisibleIndex = 5;
            this.colTotalPresup.Width = 81;
            // 
            // colTotalPresupFact
            // 
            this.colTotalPresupFact.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalPresupFact.AppearanceCell.Options.UseFont = true;
            this.colTotalPresupFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPresupFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalPresupFact.Caption = "Facturado";
            this.colTotalPresupFact.DisplayFormat.FormatString = "C2";
            this.colTotalPresupFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPresupFact.FieldName = "TotalPresupFact";
            this.colTotalPresupFact.Name = "colTotalPresupFact";
            this.colTotalPresupFact.Visible = true;
            this.colTotalPresupFact.VisibleIndex = 6;
            this.colTotalPresupFact.Width = 77;
            // 
            // colTotalPresupPendiente
            // 
            this.colTotalPresupPendiente.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalPresupPendiente.AppearanceCell.Options.UseFont = true;
            this.colTotalPresupPendiente.Caption = "Pendiente";
            this.colTotalPresupPendiente.DisplayFormat.FormatString = "C2";
            this.colTotalPresupPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPresupPendiente.FieldName = "TotalPresupPendiente";
            this.colTotalPresupPendiente.Name = "colTotalPresupPendiente";
            this.colTotalPresupPendiente.Visible = true;
            this.colTotalPresupPendiente.VisibleIndex = 7;
            this.colTotalPresupPendiente.Width = 72;
            // 
            // colaFacturarCab
            // 
            this.colaFacturarCab.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.colaFacturarCab.AppearanceCell.Options.UseFont = true;
            this.colaFacturarCab.Caption = "A Facturar";
            this.colaFacturarCab.DisplayFormat.FormatString = "C2";
            this.colaFacturarCab.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colaFacturarCab.FieldName = "aFacturar";
            this.colaFacturarCab.Name = "colaFacturarCab";
            this.colaFacturarCab.Visible = true;
            this.colaFacturarCab.VisibleIndex = 8;
            this.colaFacturarCab.Width = 79;
            // 
            // colModifCab
            // 
            this.colModifCab.FieldName = "ModifCab";
            this.colModifCab.Name = "colModifCab";
            // 
            // spnUltCertificacion
            // 
            this.spnUltCertificacion.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnUltCertificacion.Location = new System.Drawing.Point(320, 217);
            this.spnUltCertificacion.Name = "spnUltCertificacion";
            this.spnUltCertificacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnUltCertificacion.Properties.DisplayFormat.FormatString = "N0";
            this.spnUltCertificacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnUltCertificacion.Properties.EditFormat.FormatString = "N0";
            this.spnUltCertificacion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnUltCertificacion.Properties.ReadOnly = true;
            this.spnUltCertificacion.Size = new System.Drawing.Size(57, 20);
            this.spnUltCertificacion.TabIndex = 24;
            // 
            // certificacionAFacturarSpinEdit
            // 
            this.certificacionAFacturarSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.presupCabBindingSource, "CertificacionAFacturar", true));
            this.certificacionAFacturarSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.certificacionAFacturarSpinEdit.Location = new System.Drawing.Point(147, 217);
            this.certificacionAFacturarSpinEdit.Name = "certificacionAFacturarSpinEdit";
            this.certificacionAFacturarSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.certificacionAFacturarSpinEdit.Properties.DisplayFormat.FormatString = "N0";
            this.certificacionAFacturarSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.certificacionAFacturarSpinEdit.Properties.EditFormat.FormatString = "N0";
            this.certificacionAFacturarSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.certificacionAFacturarSpinEdit.Size = new System.Drawing.Size(57, 20);
            this.certificacionAFacturarSpinEdit.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(221, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Limpiar A Facturar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Crear Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idObraComboBox
            // 
            this.idObraComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idObraComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idObraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.presupCabBindingSource, "IdObra", true));
            this.idObraComboBox.DataSource = this.obrasBindingSource1;
            this.idObraComboBox.DisplayMember = "Obra";
            this.idObraComboBox.FormattingEnabled = true;
            this.idObraComboBox.Location = new System.Drawing.Point(82, 144);
            this.idObraComboBox.Name = "idObraComboBox";
            this.idObraComboBox.Size = new System.Drawing.Size(295, 21);
            this.idObraComboBox.TabIndex = 17;
            this.idObraComboBox.ValueMember = "IdObra";
            // 
            // obrasBindingSource1
            // 
            this.obrasBindingSource1.DataMember = "Obras";
            this.obrasBindingSource1.DataSource = this.datosPresupuestos;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.presupCabBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "DesCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(82, 117);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(295, 21);
            this.idClienteComboBox.TabIndex = 15;
            this.idClienteComboBox.ValueMember = "IdCliente";
            this.idClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.idClienteComboBox_SelectedIndexChanged);
            // 
            // licObraPresupTextEdit
            // 
            this.licObraPresupTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.presupCabBindingSource, "LicObraPresup", true));
            this.licObraPresupTextEdit.Location = new System.Drawing.Point(277, 91);
            this.licObraPresupTextEdit.Name = "licObraPresupTextEdit";
            this.licObraPresupTextEdit.Size = new System.Drawing.Size(100, 20);
            this.licObraPresupTextEdit.TabIndex = 13;
            // 
            // fechaPresupDateEdit
            // 
            this.fechaPresupDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.presupCabBindingSource, "FechaPresup", true));
            this.fechaPresupDateEdit.EditValue = new System.DateTime(2015, 10, 9, 12, 17, 15, 132);
            this.fechaPresupDateEdit.Location = new System.Drawing.Point(82, 91);
            this.fechaPresupDateEdit.Name = "fechaPresupDateEdit";
            this.fechaPresupDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaPresupDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fechaPresupDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fechaPresupDateEdit.TabIndex = 11;
            // 
            // desPresupTextEdit
            // 
            this.desPresupTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.presupCabBindingSource, "DesPresup", true));
            this.desPresupTextEdit.Location = new System.Drawing.Point(82, 65);
            this.desPresupTextEdit.Name = "desPresupTextEdit";
            this.desPresupTextEdit.Size = new System.Drawing.Size(295, 20);
            this.desPresupTextEdit.TabIndex = 9;
            // 
            // nomPresupTextEdit
            // 
            this.nomPresupTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.presupCabBindingSource, "NomPresup", true));
            this.nomPresupTextEdit.Location = new System.Drawing.Point(82, 39);
            this.nomPresupTextEdit.Name = "nomPresupTextEdit";
            this.nomPresupTextEdit.Size = new System.Drawing.Size(295, 20);
            this.nomPresupTextEdit.TabIndex = 7;
            // 
            // numPresupSpinEdit
            // 
            this.numPresupSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.presupCabBindingSource, "NumPresup", true));
            this.numPresupSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPresupSpinEdit.Location = new System.Drawing.Point(82, 13);
            this.numPresupSpinEdit.Name = "numPresupSpinEdit";
            this.numPresupSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numPresupSpinEdit.Properties.Mask.EditMask = "f0";
            this.numPresupSpinEdit.Size = new System.Drawing.Size(66, 20);
            this.numPresupSpinEdit.TabIndex = 5;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.presupCabBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripSeparator9,
            this.toolStripButton2,
            this.toolStripSeparator10,
            this.toolStripButton3,
            this.toolStripSeparator6,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripSeparator7,
            this.btGenerarPartidas});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1354, 26);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Font = new System.Drawing.Font("Arial Black", 10F);
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton6.Tag = "+";
            this.toolStripButton6.Text = "+";
            this.toolStripButton6.ToolTipText = "Expandir / Contraer todos los Capítulos";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Tag = "+";
            this.toolStripButton1.Text = "+";
            this.toolStripButton1.ToolTipText = "Expandir / Contraer todos los Detalles";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton2.Text = "Agregar nuevo";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton3.Text = "Eliminar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton7.Text = "Guardar datos";
            this.toolStripButton7.ToolTipText = "Guarda los cambios de todo el Presupuesto";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 26);
            // 
            // btGenerarPartidas
            // 
            this.btGenerarPartidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btGenerarPartidas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btGenerarPartidas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGenerarPartidas.Name = "btGenerarPartidas";
            this.btGenerarPartidas.Size = new System.Drawing.Size(104, 23);
            this.btGenerarPartidas.Text = "Generar Partidas";
            this.btGenerarPartidas.Click += new System.EventHandler(this.btGenerarPartidas_Click);
            // 
            // presupCabTableAdapter
            // 
            this.presupCabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FacturasCabTableAdapter = null;
            this.tableAdapterManager.FacturasDetDirectaTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = null;
            this.tableAdapterManager.PresupCabTableAdapter = this.presupCabTableAdapter;
            this.tableAdapterManager.PresupCapTableAdapter = null;
            this.tableAdapterManager.PresupDetTableAdapter = null;
            this.tableAdapterManager.PresupSubTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // presupCapTableAdapter
            // 
            this.presupCapTableAdapter.ClearBeforeFill = true;
            // 
            // presupCabBindingNavigator
            // 
            this.presupCabBindingNavigator.AddNewItem = null;
            this.presupCabBindingNavigator.BindingSource = this.presupCabBindingSource;
            this.presupCabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.presupCabBindingNavigator.DeleteItem = null;
            this.presupCabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator8,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.presupCabBindingNavigatorSaveItem,
            this.toolStripSeparator14,
            this.toolStripButton8,
            this.toolStripSeparator3,
            this.imprimirToolStripButton,
            this.toolStripSeparator11,
            this.toolStripButton4,
            this.toolStripSeparator12,
            this.toolStripButton5,
            this.toolStripSeparator13});
            this.presupCabBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.presupCabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.presupCabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.presupCabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.presupCabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.presupCabBindingNavigator.Name = "presupCabBindingNavigator";
            this.presupCabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.presupCabBindingNavigator.Size = new System.Drawing.Size(1354, 25);
            this.presupCabBindingNavigator.TabIndex = 1;
            this.presupCabBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // presupCabBindingNavigatorSaveItem
            // 
            this.presupCabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.presupCabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("presupCabBindingNavigatorSaveItem.Image")));
            this.presupCabBindingNavigatorSaveItem.Name = "presupCabBindingNavigatorSaveItem";
            this.presupCabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.presupCabBindingNavigatorSaveItem.Text = "Guardar datos";
            this.presupCabBindingNavigatorSaveItem.ToolTipText = "Guarda los cambios de todo el Presupuesto";
            this.presupCabBindingNavigatorSaveItem.Click += new System.EventHandler(this.presupCabBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::Promowork.Properties.Resources.Duplicar_32;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton8.Text = "Duplicar";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(137, 22);
            this.imprimirToolStripButton.Text = "Presupuesto Original";
            this.imprimirToolStripButton.ToolTipText = "Imprimir Presupuesto";
            this.imprimirToolStripButton.Click += new System.EventHandler(this.imprimirToolStripButton_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(145, 22);
            this.toolStripButton4.Text = "Facturado y Pendiente";
            this.toolStripButton4.ToolTipText = "Imprimir Facturado y Pendiente";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton5.Text = "A Facturar";
            this.toolStripButton5.ToolTipText = "Imprimir Facturado y Pendiente";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // anosPresupuestosBindingSource
            // 
            this.anosPresupuestosBindingSource.DataMember = "AnosPresupuestos";
            this.anosPresupuestosBindingSource.DataSource = this.datosPresupuestos;
            // 
            // anosPresupuestosTableAdapter
            // 
            this.anosPresupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(997, 2);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AnoPresup", "Año", 55, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.anosPresupuestosBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "AnoPresup";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ValueMember = "AnoPresup";
            this.lookUpEdit1.Size = new System.Drawing.Size(55, 20);
            this.lookUpEdit1.TabIndex = 2;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(842, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mostrar Presupuestos del Año:";
            // 
            // presupDetBindingSource
            // 
            this.presupDetBindingSource.AllowNew = true;
            this.presupDetBindingSource.DataMember = "FK_PresupDet_PresupCap";
            this.presupDetBindingSource.DataSource = this.presupCapBindingSource;
            // 
            // presupDetTableAdapter
            // 
            this.presupDetTableAdapter.ClearBeforeFill = true;
            // 
            // presupSubBindingSource
            // 
            this.presupSubBindingSource.AllowNew = true;
            this.presupSubBindingSource.DataMember = "FK_PresupSub_PresupDet";
            this.presupSubBindingSource.DataSource = this.presupDetBindingSource;
            // 
            // presupSubTableAdapter
            // 
            this.presupSubTableAdapter.ClearBeforeFill = true;
            // 
            // presupSubCantidadBindingSource
            // 
            this.presupSubCantidadBindingSource.DataMember = "PresupSubCantidad";
            this.presupSubCantidadBindingSource.DataSource = this.datosPresupuestos;
            // 
            // presupSubCantidadTableAdapter
            // 
            this.presupSubCantidadTableAdapter.ClearBeforeFill = true;
            // 
            // frmPresupuestoTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 679);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.presupCabBindingNavigator);
            this.Name = "frmPresupuestoTabla";
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.frmPresupuestoTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFacturarDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFacturarSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupCabBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presupCabGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUltCertificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificacionAFacturarSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licObraPresupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPresupDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPresupDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPresupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomPresupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresupSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presupCabBindingNavigator)).EndInit();
            this.presupCabBindingNavigator.ResumeLayout(false);
            this.presupCabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anosPresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupSubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupSubCantidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DatosPresupuestos datosPresupuestos;
        private System.Windows.Forms.BindingSource presupCabBindingSource;
        private DatosPresupuestosTableAdapters.PresupCabTableAdapter presupCabTableAdapter;
        private DatosPresupuestosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator presupCabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton presupCabBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl presupCabGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDirObraPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colNumPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colNomPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colDesPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colLicObraPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturado;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaPresup;
        private DatosPresupuestosTableAdapters.PresupCapTableAdapter presupCapTableAdapter;
        private System.Windows.Forms.BindingSource presupCapBindingSource;
        private DevExpress.XtraGrid.GridControl presupCapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCap;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCab1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCapPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCapPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colObsCapPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colColor1;
        private System.Windows.Forms.BindingSource anosPresupuestosBindingSource;
        private DatosPresupuestosTableAdapters.AnosPresupuestosTableAdapter anosPresupuestosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPresup;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPresupFact;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Clientes;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Obras;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DatosPresupuestosTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private DatosPresupuestosTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.TextEdit licObraPresupTextEdit;
        private DevExpress.XtraEditors.DateEdit fechaPresupDateEdit;
        private DevExpress.XtraEditors.TextEdit desPresupTextEdit;
        private DevExpress.XtraEditors.TextEdit nomPresupTextEdit;
        private DevExpress.XtraEditors.SpinEdit numPresupSpinEdit;
        private System.Windows.Forms.ComboBox idObraComboBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.BindingSource obrasBindingSource1;
        private System.Windows.Forms.BindingSource presupDetBindingSource;
        private DatosPresupuestosTableAdapters.PresupDetTableAdapter presupDetTableAdapter;
        private System.Windows.Forms.BindingSource presupSubBindingSource;
        private DatosPresupuestosTableAdapters.PresupSubTableAdapter presupSubTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCap1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumPresupDet;
        private DevExpress.XtraGrid.Columns.GridColumn colUM;
        private DevExpress.XtraGrid.Columns.GridColumn colNomPresupDet;
        private DevExpress.XtraGrid.Columns.GridColumn colDesPresupDet;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCantExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colColor2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupSub;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupDet1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCab3;
        private DevExpress.XtraGrid.Columns.GridColumn colNumPresupSub;
        private DevExpress.XtraGrid.Columns.GridColumn colUM1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomPresupSub;
        private DevExpress.XtraGrid.Columns.GridColumn colDesPresupSub;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantExtra1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio1;
        private DevExpress.XtraGrid.Columns.GridColumn colColor3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCab2;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCap;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCapaFact;
        private DevExpress.XtraGrid.Columns.GridColumn colaFacturar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCap2;
        private DevExpress.XtraGrid.Columns.GridColumn colaFacturar1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupDet;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit descripcion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPresupPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colaFacturarCab;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFacturado;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalaFacturar;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDet1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFacturado1;
        private DevExpress.XtraGrid.Columns.GridColumn colPediente;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFacturado2;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSub;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalaFacturar1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colModifCap;
        private DevExpress.XtraGrid.Columns.GridColumn colModifDet;
        private DevExpress.XtraGrid.Columns.GridColumn colModifCab;
        private DevExpress.XtraGrid.Columns.GridColumn colCantDetFact;
        private DevExpress.XtraGrid.Columns.GridColumn colCantSubFact;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit NumCap;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private DatosAccesosTableAdapters.QueriesAccesos queriesAccesos1;
        private DatosPresupuestosTableAdapters.QueriesPresupuestos queriesPresupuestos1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colDescPrecio1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private DevExpress.XtraGrid.Columns.GridColumn colExtra2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit aFacturarDet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit aFacturarSub;
        private DevExpress.XtraEditors.SpinEdit certificacionAFacturarSpinEdit;
        private System.Windows.Forms.ToolStripButton btGenerarPartidas;
        private DevExpress.XtraEditors.SpinEdit spnUltCertificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantInf;
        private System.Windows.Forms.BindingSource presupSubCantidadBindingSource;
        private DatosPresupuestosTableAdapters.PresupSubCantidadTableAdapter presupSubCantidadTableAdapter;
    }
}