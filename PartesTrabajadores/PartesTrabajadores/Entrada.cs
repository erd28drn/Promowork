using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartesTrabajadores
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

       DataRowView Trab;

        private void Entrada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Trabajadores' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Empresas' Puede moverla o quitarla según sea necesario.
            this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);
            txtClave.EditValue = string.Empty;
            txtClaveActual.EditValue = string.Empty;
            txtNuevaClave.EditValue = string.Empty;
            txtRepetir.EditValue = string.Empty;
            //txtMes.Properties.MaxValue = 12;
            //txtMes.Properties.MinValue = 1;
            //txtAno.Properties.MaxValue = 3000;
            //txtAno.Properties.MinValue = 1000;
            //txtMes.EditValue = DateTime.Today.Month;
            //txtAno.EditValue = DateTime.Today.Year;

        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Trab = (DataRowView)trabajadoresBindingSource.Current;
            //MessageBox.Show("primer" + txtClave.EditValue.ToString() + "Segundo" + Trab["Clave"].ToString());
            if (txtClave.EditValue.ToString() == Trab["Clave"].ToString())
            {
                
                VariablesGlobales.nIdEmpresaActual = (int) cbxEmpresas.SelectedValue;
                VariablesGlobales.nIdTrabajadorActual = (int)cbxTrabajadores.SelectedValue;
                VariablesGlobales.NombreTrabajador = Trab["NomTrabajador"].ToString();
                VariablesGlobales.nIdCategoria = (int)Trab["IdCategoria"];
                //VariablesGlobales.nAnoActual =  (int)txtAno.Value;
                //VariablesGlobales.nMesActual = (byte)txtMes.Value;
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta.",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnGuardarClave_Click(object sender, EventArgs e)
        {
            this.Trab = (DataRowView)trabajadoresBindingSource.Current;
            if (txtClaveActual.EditValue.ToString() == Trab["Clave"].ToString())
            {

                if (txtNuevaClave.EditValue.ToString() == txtRepetir.EditValue.ToString())
                {
                    Trab["Clave"] = txtNuevaClave.EditValue;
                    this.Validate();
                    this.trabajadoresBindingSource.EndEdit();
                    this.trabajadoresTableAdapter.Update(promowork_dataDataSet.Trabajadores);

                    panCambiarClave.Visible = false;
                    this.Height = 190;
                    this.Width = 365;

                }
                else
                {
                    MessageBox.Show("Las Contraseñas no Coinciden.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Contraseña Actual Incorrecta.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.Height = 350;
                this.Width = 365;
           
            panCambiarClave.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panCambiarClave.Visible = false;
            this.Height = 190;
            this.Width = 365;
        }

       
        private void cbxEmpresas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxEmpresas.SelectedIndex != -1)
            {
                // MessageBox.Show(cbxEmpresa.EditValue.ToString());
                this.trabajadoresTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Trabajadores, (int)cbxEmpresas.SelectedValue);
            }
        }

       
    }
}
