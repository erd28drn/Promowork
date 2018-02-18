namespace PartesTrabajadores
{
    partial class Entrada
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
            System.Windows.Forms.Label desEmpresaLabel;
            System.Windows.Forms.Label nomTrabajadorLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.promowork_dataDataSet = new PartesTrabajadores.Promowork_dataDataSet();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new PartesTrabajadores.Promowork_dataDataSetTableAdapters.EmpresasTableAdapter();
            this.tableAdapterManager = new PartesTrabajadores.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.trabajadoresTableAdapter = new PartesTrabajadores.Promowork_dataDataSetTableAdapters.TrabajadoresTableAdapter();
            this.trabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panCambiarClave = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardarClave = new System.Windows.Forms.Button();
            this.txtRepetir = new DevExpress.XtraEditors.TextEdit();
            this.txtNuevaClave = new DevExpress.XtraEditors.TextEdit();
            this.txtClaveActual = new DevExpress.XtraEditors.TextEdit();
            this.cbxTrabajadores = new System.Windows.Forms.ComboBox();
            this.cbxEmpresas = new System.Windows.Forms.ComboBox();
            desEmpresaLabel = new System.Windows.Forms.Label();
            nomTrabajadorLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            this.panCambiarClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevaClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveActual.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // desEmpresaLabel
            // 
            desEmpresaLabel.AutoSize = true;
            desEmpresaLabel.Location = new System.Drawing.Point(32, 26);
            desEmpresaLabel.Name = "desEmpresaLabel";
            desEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            desEmpresaLabel.TabIndex = 1;
            desEmpresaLabel.Text = "Empresa:";
            // 
            // nomTrabajadorLabel
            // 
            nomTrabajadorLabel.AutoSize = true;
            nomTrabajadorLabel.Location = new System.Drawing.Point(22, 57);
            nomTrabajadorLabel.Name = "nomTrabajadorLabel";
            nomTrabajadorLabel.Size = new System.Drawing.Size(61, 13);
            nomTrabajadorLabel.TabIndex = 2;
            nomTrabajadorLabel.Text = "Trabajador:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(19, 83);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(64, 13);
            claveLabel.TabIndex = 4;
            claveLabel.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 13);
            label3.TabIndex = 6;
            label3.Text = "Contraseña Actual:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(99, 13);
            label4.TabIndex = 8;
            label4.Text = "Nueva Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(5, 69);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 13);
            label5.TabIndex = 10;
            label5.Text = "Repetir Contraseña:";
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.FabricantesTableAdapter = null;
            this.tableAdapterManager.FestivosObrasDiaTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.GruposProductosTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadoresTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProductosUtTrabajadoresTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = this.trabajadoresTableAdapter;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PartesTrabajadores.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trabajadoresTableAdapter
            // 
            this.trabajadoresTableAdapter.ClearBeforeFill = true;
            // 
            // trabajadoresBindingSource
            // 
            this.trabajadoresBindingSource.DataMember = "Trabajadores";
            this.trabajadoresBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // txtClave
            // 
            this.txtClave.EnterMoveNextControl = true;
            this.txtClave.Location = new System.Drawing.Point(89, 80);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(138, 20);
            this.txtClave.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(159, 116);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(258, 116);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modificar Contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panCambiarClave
            // 
            this.panCambiarClave.Controls.Add(this.button2);
            this.panCambiarClave.Controls.Add(this.btnGuardarClave);
            this.panCambiarClave.Controls.Add(this.txtRepetir);
            this.panCambiarClave.Controls.Add(label5);
            this.panCambiarClave.Controls.Add(this.txtNuevaClave);
            this.panCambiarClave.Controls.Add(label4);
            this.panCambiarClave.Controls.Add(this.txtClaveActual);
            this.panCambiarClave.Controls.Add(label3);
            this.panCambiarClave.Location = new System.Drawing.Point(17, 163);
            this.panCambiarClave.Name = "panCambiarClave";
            this.panCambiarClave.Size = new System.Drawing.Size(316, 137);
            this.panCambiarClave.TabIndex = 14;
            this.panCambiarClave.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardarClave
            // 
            this.btnGuardarClave.Location = new System.Drawing.Point(142, 92);
            this.btnGuardarClave.Name = "btnGuardarClave";
            this.btnGuardarClave.Size = new System.Drawing.Size(66, 23);
            this.btnGuardarClave.TabIndex = 15;
            this.btnGuardarClave.Text = "Guardar";
            this.btnGuardarClave.UseVisualStyleBackColor = true;
            this.btnGuardarClave.Click += new System.EventHandler(this.btnGuardarClave_Click);
            // 
            // txtRepetir
            // 
            this.txtRepetir.EnterMoveNextControl = true;
            this.txtRepetir.Location = new System.Drawing.Point(109, 66);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.Properties.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(176, 20);
            this.txtRepetir.TabIndex = 9;
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.EnterMoveNextControl = true;
            this.txtNuevaClave.Location = new System.Drawing.Point(109, 40);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.Properties.PasswordChar = '*';
            this.txtNuevaClave.Size = new System.Drawing.Size(176, 20);
            this.txtNuevaClave.TabIndex = 7;
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.EnterMoveNextControl = true;
            this.txtClaveActual.Location = new System.Drawing.Point(109, 14);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.Properties.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(176, 20);
            this.txtClaveActual.TabIndex = 5;
            // 
            // cbxTrabajadores
            // 
            this.cbxTrabajadores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTrabajadores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTrabajadores.DataSource = this.trabajadoresBindingSource;
            this.cbxTrabajadores.DisplayMember = "NomTrabajador";
            this.cbxTrabajadores.FormattingEnabled = true;
            this.cbxTrabajadores.Location = new System.Drawing.Point(89, 53);
            this.cbxTrabajadores.Name = "cbxTrabajadores";
            this.cbxTrabajadores.Size = new System.Drawing.Size(244, 21);
            this.cbxTrabajadores.TabIndex = 1;
            this.cbxTrabajadores.ValueMember = "IdTrabajador";
            // 
            // cbxEmpresas
            // 
            this.cbxEmpresas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmpresas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmpresas.DataSource = this.empresasBindingSource;
            this.cbxEmpresas.DisplayMember = "DesEmpresa";
            this.cbxEmpresas.FormattingEnabled = true;
            this.cbxEmpresas.Location = new System.Drawing.Point(89, 26);
            this.cbxEmpresas.Name = "cbxEmpresas";
            this.cbxEmpresas.Size = new System.Drawing.Size(244, 21);
            this.cbxEmpresas.TabIndex = 0;
            this.cbxEmpresas.ValueMember = "IdEmpresa";
            this.cbxEmpresas.SelectedValueChanged += new System.EventHandler(this.cbxEmpresas_SelectedValueChanged);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(349, 152);
            this.Controls.Add(this.cbxEmpresas);
            this.Controls.Add(this.cbxTrabajadores);
            this.Controls.Add(this.panCambiarClave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(claveLabel);
            this.Controls.Add(nomTrabajadorLabel);
            this.Controls.Add(desEmpresaLabel);
            this.MaximizeBox = false;
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada a Sistema";
            this.Load += new System.EventHandler(this.Entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            this.panCambiarClave.ResumeLayout(false);
            this.panCambiarClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevaClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveActual.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private Promowork_dataDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Promowork_dataDataSetTableAdapters.TrabajadoresTableAdapter trabajadoresTableAdapter;
        private System.Windows.Forms.BindingSource trabajadoresBindingSource;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panCambiarClave;
        private DevExpress.XtraEditors.TextEdit txtRepetir;
        private DevExpress.XtraEditors.TextEdit txtNuevaClave;
        private DevExpress.XtraEditors.TextEdit txtClaveActual;
        private System.Windows.Forms.Button btnGuardarClave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxTrabajadores;
        private System.Windows.Forms.ComboBox cbxEmpresas;
    }
}