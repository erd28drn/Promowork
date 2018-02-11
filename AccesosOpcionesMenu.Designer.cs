namespace Promowork
{
    partial class AccesosOpcionesMenu
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nivel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.opcionesMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosAccesos = new Promowork.DatosAccesos();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Promowork.DatosAccesosTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Promowork.DatosAccesosTableAdapters.TableAdapterManager();
            this.usuariosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdminUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.accesosOpcionesGridControl = new DevExpress.XtraGrid.GridControl();
            this.accesosOpcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAccesoOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Opciones = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAcceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccesoNada = new System.Windows.Forms.Button();
            this.btnAccesoTodo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.accesosOpcionesTableAdapter = new Promowork.DatosAccesosTableAdapters.AccesosOpcionesTableAdapter();
            this.opcionesMenuTableAdapter = new Promowork.DatosAccesosTableAdapters.OpcionesMenuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accesosOpcionesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesosOpcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNivel
            // 
            this.colNivel.Caption = "Nivel";
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            // 
            // Nivel
            // 
            this.Nivel.AutoHeight = false;
            this.Nivel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Nivel.DataSource = this.opcionesMenuBindingSource;
            this.Nivel.DisplayMember = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            this.Nivel.ValueMember = "IdOpcion";
            // 
            // opcionesMenuBindingSource
            // 
            this.opcionesMenuBindingSource.DataMember = "OpcionesMenu";
            this.opcionesMenuBindingSource.DataSource = this.datosAccesos;
            // 
            // datosAccesos
            // 
            this.datosAccesos.DataSetName = "DatosAccesos";
            this.datosAccesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.datosAccesos;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccesosOpcionesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OpcionesMenuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.DatosAccesosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // usuariosGridControl
            // 
            this.usuariosGridControl.DataSource = this.usuariosBindingSource;
            this.usuariosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosGridControl.Location = new System.Drawing.Point(0, 0);
            this.usuariosGridControl.MainView = this.gridView1;
            this.usuariosGridControl.Name = "usuariosGridControl";
            this.usuariosGridControl.Size = new System.Drawing.Size(278, 718);
            this.usuariosGridControl.TabIndex = 1;
            this.usuariosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colNomUsuario,
            this.colDesUsuario,
            this.colAdminUsuario,
            this.colActivoUsuario});
            this.gridView1.GridControl = this.usuariosGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.ReadOnly = true;
            // 
            // colNomUsuario
            // 
            this.colNomUsuario.Caption = "Nombre";
            this.colNomUsuario.FieldName = "NomUsuario";
            this.colNomUsuario.Name = "colNomUsuario";
            this.colNomUsuario.Visible = true;
            this.colNomUsuario.VisibleIndex = 0;
            this.colNomUsuario.Width = 285;
            // 
            // colDesUsuario
            // 
            this.colDesUsuario.Caption = "Nombre Completo";
            this.colDesUsuario.FieldName = "DesUsuario";
            this.colDesUsuario.Name = "colDesUsuario";
            // 
            // colAdminUsuario
            // 
            this.colAdminUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdminUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdminUsuario.Caption = "Admin";
            this.colAdminUsuario.FieldName = "AdminUsuario";
            this.colAdminUsuario.Name = "colAdminUsuario";
            this.colAdminUsuario.Visible = true;
            this.colAdminUsuario.VisibleIndex = 1;
            this.colAdminUsuario.Width = 45;
            // 
            // colActivoUsuario
            // 
            this.colActivoUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivoUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivoUsuario.Caption = "Activo";
            this.colActivoUsuario.FieldName = "ActivoUsuario";
            this.colActivoUsuario.Name = "colActivoUsuario";
            this.colActivoUsuario.Visible = true;
            this.colActivoUsuario.VisibleIndex = 2;
            this.colActivoUsuario.Width = 45;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.usuariosGridControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.accesosOpcionesGridControl);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(899, 718);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 2;
            // 
            // accesosOpcionesGridControl
            // 
            this.accesosOpcionesGridControl.DataSource = this.accesosOpcionesBindingSource;
            this.accesosOpcionesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accesosOpcionesGridControl.Location = new System.Drawing.Point(0, 59);
            this.accesosOpcionesGridControl.MainView = this.gridView2;
            this.accesosOpcionesGridControl.Name = "accesosOpcionesGridControl";
            this.accesosOpcionesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Opciones,
            this.Nivel});
            this.accesosOpcionesGridControl.Size = new System.Drawing.Size(617, 659);
            this.accesosOpcionesGridControl.TabIndex = 0;
            this.accesosOpcionesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // accesosOpcionesBindingSource
            // 
            this.accesosOpcionesBindingSource.DataMember = "AccesosOpciones";
            this.accesosOpcionesBindingSource.DataSource = this.datosAccesos;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAccesoOpcion,
            this.colIdUsuario1,
            this.colIdOpcion,
            this.colAcceso,
            this.colNivel});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colNivel;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 0;
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colNivel;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = 1;
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView2.GridControl = this.accesosOpcionesGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowSort = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAccesoOpcion
            // 
            this.colIdAccesoOpcion.FieldName = "IdAccesoOpcion";
            this.colIdAccesoOpcion.Name = "colIdAccesoOpcion";
            this.colIdAccesoOpcion.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuario1
            // 
            this.colIdUsuario1.FieldName = "IdUsuario";
            this.colIdUsuario1.Name = "colIdUsuario1";
            // 
            // colIdOpcion
            // 
            this.colIdOpcion.Caption = "Opción";
            this.colIdOpcion.ColumnEdit = this.Opciones;
            this.colIdOpcion.FieldName = "IdOpcion";
            this.colIdOpcion.Name = "colIdOpcion";
            this.colIdOpcion.Visible = true;
            this.colIdOpcion.VisibleIndex = 0;
            this.colIdOpcion.Width = 515;
            // 
            // Opciones
            // 
            this.Opciones.AutoHeight = false;
            this.Opciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Opciones.DataSource = this.opcionesMenuBindingSource;
            this.Opciones.DisplayMember = "NombreOpcion";
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            this.Opciones.ValueMember = "IdOpcion";
            // 
            // colAcceso
            // 
            this.colAcceso.AppearanceHeader.Options.UseTextOptions = true;
            this.colAcceso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAcceso.Caption = "Acceso";
            this.colAcceso.FieldName = "Acceso";
            this.colAcceso.Name = "colAcceso";
            this.colAcceso.Visible = true;
            this.colAcceso.VisibleIndex = 1;
            this.colAcceso.Width = 95;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAccesoNada);
            this.panel1.Controls.Add(this.btnAccesoTodo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 59);
            this.panel1.TabIndex = 2;
            // 
            // btnAccesoNada
            // 
            this.btnAccesoNada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesoNada.Location = new System.Drawing.Point(473, 12);
            this.btnAccesoNada.Name = "btnAccesoNada";
            this.btnAccesoNada.Size = new System.Drawing.Size(135, 35);
            this.btnAccesoNada.TabIndex = 3;
            this.btnAccesoNada.Text = "Desmarcar Todo";
            this.btnAccesoNada.UseVisualStyleBackColor = true;
            this.btnAccesoNada.Click += new System.EventHandler(this.btnAccesoNada_Click);
            // 
            // btnAccesoTodo
            // 
            this.btnAccesoTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesoTodo.Location = new System.Drawing.Point(332, 12);
            this.btnAccesoTodo.Name = "btnAccesoTodo";
            this.btnAccesoTodo.Size = new System.Drawing.Size(135, 35);
            this.btnAccesoTodo.TabIndex = 2;
            this.btnAccesoTodo.Text = "Marcar Todo";
            this.btnAccesoTodo.UseVisualStyleBackColor = true;
            this.btnAccesoTodo.Click += new System.EventHandler(this.btnAccesoTodo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accesosOpcionesTableAdapter
            // 
            this.accesosOpcionesTableAdapter.ClearBeforeFill = true;
            // 
            // opcionesMenuTableAdapter
            // 
            this.opcionesMenuTableAdapter.ClearBeforeFill = true;
            // 
            // AccesosOpcionesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 718);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AccesosOpcionesMenu";
            this.Text = "Accesos de Usuarios a Opciones del Menu";
            this.Load += new System.EventHandler(this.AccesosOpcionesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accesosOpcionesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesosOpcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DatosAccesos datosAccesos;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DatosAccesosTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DatosAccesosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl usuariosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNomUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDesUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colAdminUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colActivoUsuario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource accesosOpcionesBindingSource;
        private DatosAccesosTableAdapters.AccesosOpcionesTableAdapter accesosOpcionesTableAdapter;
        private DevExpress.XtraGrid.GridControl accesosOpcionesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAccesoOpcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOpcion;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceso;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Opciones;
        private System.Windows.Forms.BindingSource opcionesMenuBindingSource;
        private DatosAccesosTableAdapters.OpcionesMenuTableAdapter opcionesMenuTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Nivel;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAccesoNada;
        private System.Windows.Forms.Button btnAccesoTodo;
    }
}