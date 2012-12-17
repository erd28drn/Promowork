namespace Promowork
{
    partial class SeguridadSocial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguridadSocial));
            this.seguridadSocialDataGridView = new System.Windows.Forms.DataGridView();
            this.idTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.trabajadoresSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.ImpSegSocila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpIRPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguridadSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queriesTableAdapter1 = new Promowork.Promowork_dataDataSetTableAdapters.QueriesTableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seguridadSocialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.seguridadSocialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.seguridadSocialTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.SeguridadSocialTableAdapter();
            this.empresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.trabajadoresSSTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.TrabajadoresSSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadSocialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresSSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadSocialBindingNavigator)).BeginInit();
            this.seguridadSocialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // seguridadSocialDataGridView
            // 
            this.seguridadSocialDataGridView.AllowUserToAddRows = false;
            this.seguridadSocialDataGridView.AutoGenerateColumns = false;
            this.seguridadSocialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seguridadSocialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrabajadorDataGridViewTextBoxColumn,
            this.ImpSegSocila,
            this.ImpIRPF});
            this.seguridadSocialDataGridView.DataSource = this.seguridadSocialBindingSource;
            this.seguridadSocialDataGridView.Location = new System.Drawing.Point(12, 28);
            this.seguridadSocialDataGridView.Name = "seguridadSocialDataGridView";
            this.seguridadSocialDataGridView.Size = new System.Drawing.Size(566, 354);
            this.seguridadSocialDataGridView.TabIndex = 1;
            // 
            // idTrabajadorDataGridViewTextBoxColumn
            // 
            this.idTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IdTrabajador";
            this.idTrabajadorDataGridViewTextBoxColumn.DataSource = this.trabajadoresSSBindingSource;
            this.idTrabajadorDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.idTrabajadorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idTrabajadorDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.idTrabajadorDataGridViewTextBoxColumn.HeaderText = "Trabajador";
            this.idTrabajadorDataGridViewTextBoxColumn.Name = "idTrabajadorDataGridViewTextBoxColumn";
            this.idTrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrabajadorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTrabajadorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTrabajadorDataGridViewTextBoxColumn.ValueMember = "IdTrabajador";
            this.idTrabajadorDataGridViewTextBoxColumn.Width = 300;
            // 
            // trabajadoresSSBindingSource
            // 
            this.trabajadoresSSBindingSource.DataMember = "TrabajadoresSS";
            this.trabajadoresSSBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImpSegSocila
            // 
            this.ImpSegSocila.DataPropertyName = "ImpSegSocila";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.ImpSegSocila.DefaultCellStyle = dataGridViewCellStyle1;
            this.ImpSegSocila.HeaderText = "Seg. Social";
            this.ImpSegSocila.Name = "ImpSegSocila";
            // 
            // ImpIRPF
            // 
            this.ImpIRPF.DataPropertyName = "ImpIRPF";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ImpIRPF.DefaultCellStyle = dataGridViewCellStyle2;
            this.ImpIRPF.HeaderText = "IRPF";
            this.ImpIRPF.Name = "ImpIRPF";
            // 
            // seguridadSocialBindingSource
            // 
            this.seguridadSocialBindingSource.DataMember = "SeguridadSocial";
            this.seguridadSocialBindingSource.DataSource = this.promowork_dataDataSet;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // seguridadSocialBindingNavigatorSaveItem
            // 
            this.seguridadSocialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seguridadSocialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("seguridadSocialBindingNavigatorSaveItem.Image")));
            this.seguridadSocialBindingNavigatorSaveItem.Name = "seguridadSocialBindingNavigatorSaveItem";
            this.seguridadSocialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.seguridadSocialBindingNavigatorSaveItem.Text = "Save Data";
            this.seguridadSocialBindingNavigatorSaveItem.Click += new System.EventHandler(this.seguridadSocialBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // seguridadSocialBindingNavigator
            // 
            this.seguridadSocialBindingNavigator.AddNewItem = null;
            this.seguridadSocialBindingNavigator.BindingSource = this.seguridadSocialBindingSource;
            this.seguridadSocialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.seguridadSocialBindingNavigator.DeleteItem = null;
            this.seguridadSocialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.seguridadSocialBindingNavigatorSaveItem,
            this.toolStripSeparator3,
            this.printToolStripButton,
            this.toolStripSeparator});
            this.seguridadSocialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.seguridadSocialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.seguridadSocialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.seguridadSocialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.seguridadSocialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.seguridadSocialBindingNavigator.Name = "seguridadSocialBindingNavigator";
            this.seguridadSocialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.seguridadSocialBindingNavigator.Size = new System.Drawing.Size(591, 25);
            this.seguridadSocialBindingNavigator.TabIndex = 0;
            this.seguridadSocialBindingNavigator.Text = "bindingNavigator1";
            // 
            // seguridadSocialTableAdapter
            // 
            this.seguridadSocialTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CobrosTableAdapter = null;
            this.tableAdapterManager.ComprasCabTableAdapter = null;
            this.tableAdapterManager.ComprasDetTableAdapter = null;
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.EmpresasActualTableAdapter = this.empresasActualTableAdapter;
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
            // trabajadoresSSTableAdapter
            // 
            this.trabajadoresSSTableAdapter.ClearBeforeFill = true;
            // 
            // SeguridadSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 393);
            this.Controls.Add(this.seguridadSocialDataGridView);
            this.Controls.Add(this.seguridadSocialBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SeguridadSocial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad Social";
            this.Load += new System.EventHandler(this.SeguridadSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seguridadSocialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresSSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadSocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadSocialBindingNavigator)).EndInit();
            this.seguridadSocialBindingNavigator.ResumeLayout(false);
            this.seguridadSocialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seguridadSocialDataGridView;
        private Promowork_dataDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton seguridadSocialBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.BindingNavigator seguridadSocialBindingNavigator;
        private System.Windows.Forms.BindingSource seguridadSocialBindingSource;
        private Promowork_dataDataSet promowork_dataDataSet;
        private Promowork_dataDataSetTableAdapters.SeguridadSocialTableAdapter seguridadSocialTableAdapter;
        private System.Windows.Forms.BindingSource empresasActualBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter empresasActualTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource trabajadoresSSBindingSource;
        private Promowork_dataDataSetTableAdapters.TrabajadoresSSTableAdapter trabajadoresSSTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpSegSocila;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpIRPF;
    }
}