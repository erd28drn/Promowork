namespace Promowork
{
    partial class TiposCombustibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposCombustibles));
            this.promowork_dataDataSetCombustible = new Promowork.Promowork_dataDataSetCombustible();
            this.TiposServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager();
            this.TiposServiciosTableAdapter = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.TiposServiciosTableAdapter();
            this.TiposServiciosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.TiposServiciosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.TiposServiciosDataGridView = new System.Windows.Forms.DataGridView();
            this.DesServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uMedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivoServicio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uMedidasTableAdapter = new Promowork.Promowork_dataDataSetCombustibleTableAdapters.UMedidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSetCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposServiciosBindingNavigator)).BeginInit();
            this.TiposServiciosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiposServiciosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // promowork_dataDataSetCombustible
            // 
            this.promowork_dataDataSetCombustible.DataSetName = "Promowork_dataDataSetCombustible";
            this.promowork_dataDataSetCombustible.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TiposServiciosBindingSource
            // 
            this.TiposServiciosBindingSource.DataMember = "TiposServicios";
            this.TiposServiciosBindingSource.DataSource = this.promowork_dataDataSetCombustible;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumosVehiculosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EntradasCombustibleDetTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.ServiciosVehiculosTableAdapter = null;
            this.tableAdapterManager.TiposServiciosTableAdapter = this.TiposServiciosTableAdapter;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // TiposServiciosTableAdapter
            // 
            this.TiposServiciosTableAdapter.ClearBeforeFill = true;
            // 
            // TiposServiciosBindingNavigator
            // 
            this.TiposServiciosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.TiposServiciosBindingNavigator.BindingSource = this.TiposServiciosBindingSource;
            this.TiposServiciosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.TiposServiciosBindingNavigator.DeleteItem = null;
            this.TiposServiciosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.TiposServiciosBindingNavigatorSaveItem});
            this.TiposServiciosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.TiposServiciosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.TiposServiciosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.TiposServiciosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.TiposServiciosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.TiposServiciosBindingNavigator.Name = "TiposServiciosBindingNavigator";
            this.TiposServiciosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.TiposServiciosBindingNavigator.Size = new System.Drawing.Size(453, 25);
            this.TiposServiciosBindingNavigator.TabIndex = 0;
            this.TiposServiciosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // TiposServiciosBindingNavigatorSaveItem
            // 
            this.TiposServiciosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TiposServiciosBindingNavigatorSaveItem.Image = global::Promowork.Properties.Resources.combustiblesTiposBindingNavigatorSaveItem_Image;
            this.TiposServiciosBindingNavigatorSaveItem.Name = "TiposServiciosBindingNavigatorSaveItem";
            this.TiposServiciosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.TiposServiciosBindingNavigatorSaveItem.Text = "Save Data";
            this.TiposServiciosBindingNavigatorSaveItem.Click += new System.EventHandler(this.TiposServiciosBindingNavigatorSaveItem_Click);
            // 
            // TiposServiciosDataGridView
            // 
            this.TiposServiciosDataGridView.AutoGenerateColumns = false;
            this.TiposServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiposServiciosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesServicio,
            this.dataGridViewTextBoxColumn4,
            this.ActivoServicio,
            this.Combustible});
            this.TiposServiciosDataGridView.DataSource = this.TiposServiciosBindingSource;
            this.TiposServiciosDataGridView.Location = new System.Drawing.Point(12, 28);
            this.TiposServiciosDataGridView.Name = "TiposServiciosDataGridView";
            this.TiposServiciosDataGridView.RowHeadersWidth = 25;
            this.TiposServiciosDataGridView.Size = new System.Drawing.Size(426, 279);
            this.TiposServiciosDataGridView.TabIndex = 1;
            this.TiposServiciosDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.TiposServiciosDataGridView_UserAddedRow);
            // 
            // DesServicio
            // 
            this.DesServicio.DataPropertyName = "DesServicio";
            this.DesServicio.HeaderText = "Servicio";
            this.DesServicio.Name = "DesServicio";
            this.DesServicio.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdUmedida";
            this.dataGridViewTextBoxColumn4.DataSource = this.uMedidasBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "DesUmedida";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "U. Medida";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdUmedida";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // uMedidasBindingSource
            // 
            this.uMedidasBindingSource.DataMember = "UMedidas";
            this.uMedidasBindingSource.DataSource = this.promowork_dataDataSetCombustible;
            // 
            // ActivoServicio
            // 
            this.ActivoServicio.DataPropertyName = "ActivoServicio";
            this.ActivoServicio.HeaderText = "Activo";
            this.ActivoServicio.Name = "ActivoServicio";
            this.ActivoServicio.Width = 50;
            // 
            // Combustible
            // 
            this.Combustible.DataPropertyName = "Combustible";
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            this.Combustible.Visible = false;
            // 
            // uMedidasTableAdapter
            // 
            this.uMedidasTableAdapter.ClearBeforeFill = true;
            // 
            // TiposCombustibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 319);
            this.Controls.Add(this.TiposServiciosDataGridView);
            this.Controls.Add(this.TiposServiciosBindingNavigator);
            this.Name = "TiposCombustibles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Combustibles";
            this.Load += new System.EventHandler(this.TiposCombustibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSetCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposServiciosBindingNavigator)).EndInit();
            this.TiposServiciosBindingNavigator.ResumeLayout(false);
            this.TiposServiciosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiposServiciosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSetCombustible promowork_dataDataSetCombustible;
        private System.Windows.Forms.BindingSource TiposServiciosBindingSource;
        private Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator TiposServiciosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton TiposServiciosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView TiposServiciosDataGridView;
        private System.Windows.Forms.BindingSource uMedidasBindingSource;
        private Promowork_dataDataSetCombustibleTableAdapters.UMedidasTableAdapter uMedidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoCombustible;
        private Promowork_dataDataSetCombustibleTableAdapters.TiposServiciosTableAdapter TiposServiciosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesServicio;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActivoServicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Combustible;
    }
}