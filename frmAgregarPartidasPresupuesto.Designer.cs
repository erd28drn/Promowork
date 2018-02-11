namespace Promowork
{
    partial class frmAgregarPartidasPresupuesto
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
            this.spnCapitulos = new DevExpress.XtraEditors.SpinEdit();
            this.spnDetalles = new DevExpress.XtraEditors.SpinEdit();
            this.spnSubdetalles = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.queriesPresupuestos1 = new Promowork.DatosPresupuestosTableAdapters.QueriesPresupuestos();
            ((System.ComponentModel.ISupportInitialize)(this.spnCapitulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDetalles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSubdetalles.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spnCapitulos
            // 
            this.spnCapitulos.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCapitulos.Location = new System.Drawing.Point(123, 8);
            this.spnCapitulos.Name = "spnCapitulos";
            this.spnCapitulos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnCapitulos.Properties.DisplayFormat.FormatString = "N0";
            this.spnCapitulos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCapitulos.Properties.EditFormat.FormatString = "N0";
            this.spnCapitulos.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCapitulos.Size = new System.Drawing.Size(53, 20);
            this.spnCapitulos.TabIndex = 0;
            // 
            // spnDetalles
            // 
            this.spnDetalles.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnDetalles.Location = new System.Drawing.Point(123, 36);
            this.spnDetalles.Name = "spnDetalles";
            this.spnDetalles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnDetalles.Properties.DisplayFormat.FormatString = "N0";
            this.spnDetalles.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnDetalles.Properties.EditFormat.FormatString = "N0";
            this.spnDetalles.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnDetalles.Size = new System.Drawing.Size(53, 20);
            this.spnDetalles.TabIndex = 1;
            // 
            // spnSubdetalles
            // 
            this.spnSubdetalles.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSubdetalles.Location = new System.Drawing.Point(123, 64);
            this.spnSubdetalles.Name = "spnSubdetalles";
            this.spnSubdetalles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnSubdetalles.Properties.DisplayFormat.FormatString = "N0";
            this.spnSubdetalles.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnSubdetalles.Properties.EditFormat.FormatString = "N0";
            this.spnSubdetalles.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnSubdetalles.Size = new System.Drawing.Size(53, 20);
            this.spnSubdetalles.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Cantidad Capítulos";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cantidad Detalles";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cantidad Subdetalles";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(242, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(242, 58);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarPartidasPresupuesto
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(337, 104);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.spnSubdetalles);
            this.Controls.Add(this.spnDetalles);
            this.Controls.Add(this.spnCapitulos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarPartidasPresupuesto";
            this.ShowIcon = false;
            this.Text = "Agregar Partidas Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.spnCapitulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDetalles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSubdetalles.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spnCapitulos;
        private DevExpress.XtraEditors.SpinEdit spnDetalles;
        private DevExpress.XtraEditors.SpinEdit spnSubdetalles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DatosPresupuestosTableAdapters.QueriesPresupuestos queriesPresupuestos1;
    }
}