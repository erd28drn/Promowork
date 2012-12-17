namespace Promowork
{
    partial class RptParametrosHorasTrabajadasDias
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
            this.marcaObrasDataGridView = new System.Windows.Forms.DataGridView();
            this.marcaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.marcaTrabajadoresDataGridView = new System.Windows.Forms.DataGridView();
            this.marcaDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNITrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.marcaObrasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaObrasTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.marcaTrabajadoresTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaTrabajadoresTableAdapter();
            this.empresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasActualTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.marcaAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaAnoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaAnoTableAdapter();
            this.marcaMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaMesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaMesTableAdapter();
            this.anoTrabComboBox = new System.Windows.Forms.ComboBox();
            this.nomMesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaMesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaObrasDataGridView
            // 
            this.marcaObrasDataGridView.AllowUserToAddRows = false;
            this.marcaObrasDataGridView.AllowUserToDeleteRows = false;
            this.marcaObrasDataGridView.AutoGenerateColumns = false;
            this.marcaObrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marcaObrasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewCheckBoxColumn,
            this.numObraDataGridViewTextBoxColumn,
            this.desObraDataGridViewTextBoxColumn,
            this.NumCliente,
            this.DesCliente,
            this.idEmpresaDataGridViewTextBoxColumn,
            this.idObraDataGridViewTextBoxColumn});
            this.marcaObrasDataGridView.DataSource = this.marcaObrasBindingSource;
            this.marcaObrasDataGridView.Location = new System.Drawing.Point(553, 53);
            this.marcaObrasDataGridView.Name = "marcaObrasDataGridView";
            this.marcaObrasDataGridView.RowHeadersVisible = false;
            this.marcaObrasDataGridView.Size = new System.Drawing.Size(530, 446);
            this.marcaObrasDataGridView.TabIndex = 3;
            // 
            // marcaDataGridViewCheckBoxColumn
            // 
            this.marcaDataGridViewCheckBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewCheckBoxColumn.HeaderText = "";
            this.marcaDataGridViewCheckBoxColumn.Name = "marcaDataGridViewCheckBoxColumn";
            this.marcaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.marcaDataGridViewCheckBoxColumn.Width = 20;
            // 
            // numObraDataGridViewTextBoxColumn
            // 
            this.numObraDataGridViewTextBoxColumn.DataPropertyName = "NumObra";
            this.numObraDataGridViewTextBoxColumn.HeaderText = "Nº";
            this.numObraDataGridViewTextBoxColumn.Name = "numObraDataGridViewTextBoxColumn";
            this.numObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.numObraDataGridViewTextBoxColumn.Width = 50;
            // 
            // desObraDataGridViewTextBoxColumn
            // 
            this.desObraDataGridViewTextBoxColumn.DataPropertyName = "DesObra";
            this.desObraDataGridViewTextBoxColumn.HeaderText = "Descripción Obra";
            this.desObraDataGridViewTextBoxColumn.Name = "desObraDataGridViewTextBoxColumn";
            this.desObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.desObraDataGridViewTextBoxColumn.Width = 220;
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
            this.DesCliente.HeaderText = "Descripción Cliente";
            this.DesCliente.Name = "DesCliente";
            this.DesCliente.ReadOnly = true;
            this.DesCliente.Width = 170;
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            this.idEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObraDataGridViewTextBoxColumn.Visible = false;
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
            // marcaTrabajadoresDataGridView
            // 
            this.marcaTrabajadoresDataGridView.AllowUserToAddRows = false;
            this.marcaTrabajadoresDataGridView.AllowUserToDeleteRows = false;
            this.marcaTrabajadoresDataGridView.AutoGenerateColumns = false;
            this.marcaTrabajadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marcaTrabajadoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewCheckBoxColumn1,
            this.numTrabajadorDataGridViewTextBoxColumn,
            this.nomTrabajadorDataGridViewTextBoxColumn,
            this.apeTrabajadorDataGridViewTextBoxColumn,
            this.DesCategoria,
            this.idEmpresaDataGridViewTextBoxColumn1,
            this.idTrabajadorDataGridViewTextBoxColumn,
            this.dNITrabajadorDataGridViewTextBoxColumn});
            this.marcaTrabajadoresDataGridView.DataSource = this.marcaTrabajadoresBindingSource;
            this.marcaTrabajadoresDataGridView.Location = new System.Drawing.Point(12, 53);
            this.marcaTrabajadoresDataGridView.Name = "marcaTrabajadoresDataGridView";
            this.marcaTrabajadoresDataGridView.RowHeadersVisible = false;
            this.marcaTrabajadoresDataGridView.Size = new System.Drawing.Size(530, 446);
            this.marcaTrabajadoresDataGridView.TabIndex = 4;
            // 
            // marcaDataGridViewCheckBoxColumn1
            // 
            this.marcaDataGridViewCheckBoxColumn1.DataPropertyName = "Marca";
            this.marcaDataGridViewCheckBoxColumn1.HeaderText = "";
            this.marcaDataGridViewCheckBoxColumn1.Name = "marcaDataGridViewCheckBoxColumn1";
            this.marcaDataGridViewCheckBoxColumn1.Width = 20;
            // 
            // numTrabajadorDataGridViewTextBoxColumn
            // 
            this.numTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "NumTrabajador";
            this.numTrabajadorDataGridViewTextBoxColumn.HeaderText = "Nº";
            this.numTrabajadorDataGridViewTextBoxColumn.Name = "numTrabajadorDataGridViewTextBoxColumn";
            this.numTrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.numTrabajadorDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomTrabajadorDataGridViewTextBoxColumn
            // 
            this.nomTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "NomTrabajador";
            this.nomTrabajadorDataGridViewTextBoxColumn.HeaderText = "Nombre Trabajador";
            this.nomTrabajadorDataGridViewTextBoxColumn.Name = "nomTrabajadorDataGridViewTextBoxColumn";
            this.nomTrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomTrabajadorDataGridViewTextBoxColumn.Width = 150;
            // 
            // apeTrabajadorDataGridViewTextBoxColumn
            // 
            this.apeTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "ApeTrabajador";
            this.apeTrabajadorDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apeTrabajadorDataGridViewTextBoxColumn.Name = "apeTrabajadorDataGridViewTextBoxColumn";
            this.apeTrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.apeTrabajadorDataGridViewTextBoxColumn.Width = 150;
            // 
            // DesCategoria
            // 
            this.DesCategoria.DataPropertyName = "DesCategoria";
            this.DesCategoria.HeaderText = "Categoría";
            this.DesCategoria.Name = "DesCategoria";
            this.DesCategoria.ReadOnly = true;
            // 
            // idEmpresaDataGridViewTextBoxColumn1
            // 
            this.idEmpresaDataGridViewTextBoxColumn1.DataPropertyName = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn1.HeaderText = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn1.Name = "idEmpresaDataGridViewTextBoxColumn1";
            this.idEmpresaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idEmpresaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idTrabajadorDataGridViewTextBoxColumn
            // 
            this.idTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IdTrabajador";
            this.idTrabajadorDataGridViewTextBoxColumn.HeaderText = "IdTrabajador";
            this.idTrabajadorDataGridViewTextBoxColumn.Name = "idTrabajadorDataGridViewTextBoxColumn";
            this.idTrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrabajadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // dNITrabajadorDataGridViewTextBoxColumn
            // 
            this.dNITrabajadorDataGridViewTextBoxColumn.DataPropertyName = "DNITrabajador";
            this.dNITrabajadorDataGridViewTextBoxColumn.HeaderText = "DNITrabajador";
            this.dNITrabajadorDataGridViewTextBoxColumn.Name = "dNITrabajadorDataGridViewTextBoxColumn";
            this.dNITrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.dNITrabajadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // marcaTrabajadoresBindingSource
            // 
            this.marcaTrabajadoresBindingSource.DataMember = "MarcaTrabajadores";
            this.marcaTrabajadoresBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Año:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 18);
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
            this.checkBox1.Location = new System.Drawing.Point(558, 57);
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
            this.checkBox2.Location = new System.Drawing.Point(17, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // marcaObrasTableAdapter
            // 
            this.marcaObrasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
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
            this.tableAdapterManager.Connection = null;
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
            // marcaAnoBindingSource
            // 
            this.marcaAnoBindingSource.DataMember = "MarcaAno";
            this.marcaAnoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // marcaAnoTableAdapter
            // 
            this.marcaAnoTableAdapter.ClearBeforeFill = true;
            // 
            // marcaMesBindingSource
            // 
            this.marcaMesBindingSource.DataMember = "MarcaAno_MarcaMes";
            this.marcaMesBindingSource.DataSource = this.marcaAnoBindingSource;
            // 
            // marcaMesTableAdapter
            // 
            this.marcaMesTableAdapter.ClearBeforeFill = true;
            // 
            // anoTrabComboBox
            // 
            this.anoTrabComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcaAnoBindingSource, "AnoTrab", true));
            this.anoTrabComboBox.DataSource = this.marcaAnoBindingSource;
            this.anoTrabComboBox.DisplayMember = "AnoTrab";
            this.anoTrabComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anoTrabComboBox.FormattingEnabled = true;
            this.anoTrabComboBox.Location = new System.Drawing.Point(41, 19);
            this.anoTrabComboBox.Name = "anoTrabComboBox";
            this.anoTrabComboBox.Size = new System.Drawing.Size(70, 21);
            this.anoTrabComboBox.TabIndex = 16;
            this.anoTrabComboBox.ValueMember = "AnoTrab";
            // 
            // nomMesComboBox
            // 
            this.nomMesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcaMesBindingSource, "NomMes", true));
            this.nomMesComboBox.DataSource = this.marcaMesBindingSource;
            this.nomMesComboBox.DisplayMember = "NomMes";
            this.nomMesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomMesComboBox.FormattingEnabled = true;
            this.nomMesComboBox.Location = new System.Drawing.Point(158, 19);
            this.nomMesComboBox.Name = "nomMesComboBox";
            this.nomMesComboBox.Size = new System.Drawing.Size(121, 21);
            this.nomMesComboBox.TabIndex = 17;
            this.nomMesComboBox.ValueMember = "MesTrab";
            // 
            // RptParametrosHorasTrabajadasDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 511);
            this.Controls.Add(this.nomMesComboBox);
            this.Controls.Add(this.anoTrabComboBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marcaTrabajadoresDataGridView);
            this.Controls.Add(this.marcaObrasDataGridView);
            this.Name = "RptParametrosHorasTrabajadasDias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horas Trabajadas por Días";
            this.Load += new System.EventHandler(this.RptParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTrabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaMesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView marcaObrasDataGridView;
        private System.Windows.Forms.DataGridView marcaTrabajadoresDataGridView;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marcaDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNITrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.BindingSource marcaAnoBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaAnoTableAdapter marcaAnoTableAdapter;
        private System.Windows.Forms.BindingSource marcaMesBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaMesTableAdapter marcaMesTableAdapter;
        private System.Windows.Forms.ComboBox anoTrabComboBox;
        private System.Windows.Forms.ComboBox nomMesComboBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marcaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
    }
}