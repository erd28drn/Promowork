namespace Promowork
{
    partial class SalvaRestaura
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
            System.Windows.Forms.Label pathSalvaLabel;
            System.Windows.Forms.Label pathRestauraLabel;
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.pathSalvaTextBox = new System.Windows.Forms.TextBox();
            this.pathRestauraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new Promowork.Promowork_dataDataSetTableAdapters.QueriesTableAdapter();
            this.queriesTableAdapter2 = new Promowork.masterDataSetTableAdapters.QueriesTableAdapter();
            this.masterDataSet = new Promowork.masterDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.UsuariosTableAdapter();
            pathSalvaLabel = new System.Windows.Forms.Label();
            pathRestauraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pathSalvaLabel
            // 
            pathSalvaLabel.AutoSize = true;
            pathSalvaLabel.Location = new System.Drawing.Point(28, 22);
            pathSalvaLabel.Name = "pathSalvaLabel";
            pathSalvaLabel.Size = new System.Drawing.Size(88, 13);
            pathSalvaLabel.TabIndex = 1;
            pathSalvaLabel.Text = "Ubicación Salva:";
            // 
            // pathRestauraLabel
            // 
            pathRestauraLabel.AutoSize = true;
            pathRestauraLabel.Location = new System.Drawing.Point(12, 86);
            pathRestauraLabel.Name = "pathRestauraLabel";
            pathRestauraLabel.Size = new System.Drawing.Size(104, 13);
            pathRestauraLabel.TabIndex = 3;
            pathRestauraLabel.Text = "Ubicación Restaura:";
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
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
            // pathSalvaTextBox
            // 
            this.pathSalvaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "PathSalva", true));
            this.pathSalvaTextBox.Location = new System.Drawing.Point(122, 22);
            this.pathSalvaTextBox.Name = "pathSalvaTextBox";
            this.pathSalvaTextBox.Size = new System.Drawing.Size(370, 20);
            this.pathSalvaTextBox.TabIndex = 2;
            // 
            // pathRestauraTextBox
            // 
            this.pathRestauraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "PathRestaura", true));
            this.pathRestauraTextBox.Location = new System.Drawing.Point(122, 86);
            this.pathRestauraTextBox.Name = "pathRestauraTextBox";
            this.pathRestauraTextBox.Size = new System.Drawing.Size(370, 20);
            this.pathRestauraTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ubicación (accesible desde el SERVIDOR) y Nombre del Fichero de Salva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ubicación (accesible desde el SERVIDOR) y Nombre del Fichero a Restaurar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "Restaurar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // SalvaRestaura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 136);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(pathRestauraLabel);
            this.Controls.Add(this.pathRestauraTextBox);
            this.Controls.Add(pathSalvaLabel);
            this.Controls.Add(this.pathSalvaTextBox);
            this.Name = "SalvaRestaura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salva y Restaura";
            this.Load += new System.EventHandler(this.SalvaRestaura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox pathSalvaTextBox;
        private System.Windows.Forms.TextBox pathRestauraTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Promowork_dataDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private masterDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter2;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Promowork_dataDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}