using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Promowork
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

       
        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            usuariosDataGridView.EndEdit();
            if (Convert.ToString(usuariosDataGridView.CurrentRow.Cells["Usuario"].Value).Trim().Length == 0)
            {
                MessageBox.Show("El Usuario no puede estar vacío", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sClave = claveUsuarioTextBox.Text;
                string sClave1 = claveUsuarioTextBox1.Text;

                if (sClave == sClave1 && sClave.Length != 0)
                {

                    byte[] tmpClave = ASCIIEncoding.ASCII.GetBytes(sClave);
                    byte[] tmpClaveHash = new MD5CryptoServiceProvider().ComputeHash(tmpClave);

                    try
                    {
                        DataRowView RowActual = (DataRowView)usuariosBindingSource.Current;

                        object Clave = RowActual["ClaveUsuario"];
                       // if (Convert.ToString(Clave) != sClave)
                      //  {
                            //promowork_dataDataSet.Tables["Usuarios"].Rows[usuariosDataGridView.CurrentRow.Index]["ClaveUsuario"]
                            RowActual["ClaveUsuario"] = Convert.ToBase64String(tmpClaveHash);
                            claveUsuarioTextBox.Text = Convert.ToBase64String(tmpClaveHash);
                            claveUsuarioTextBox1.Text = Convert.ToBase64String(tmpClaveHash);
                      //  }
                        
                        this.Validate();
                        this.usuariosBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

                    }
                    catch (DBConcurrencyException)
                    {

                        MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.usuariosTableAdapter.Fill(this.promowork_dataDataSet.Usuarios);
                    }
                    catch (SqlException ex)
                    {
                        if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                        {
                        this.usuariosTableAdapter.Fill(this.promowork_dataDataSet.Usuarios);

                        }

                    }
                    
                }
                else
                {
                    MessageBox.Show("Las Contraseñas tiene que coincidir y no pueden estar vacias", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            bindingNavigatorAddNewItem.Enabled = true;
            //usuariosBindingNavigatorSaveItem.Enabled = false;

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.promowork_dataDataSet.Usuarios);

        }

        private void usuariosDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
          
            bindingNavigatorAddNewItem.Enabled = false;
          // usuariosBindingNavigatorSaveItem.Enabled = true;
         
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            DataRowView RowActual = (DataRowView)usuariosBindingSource.Current;
            RowActual["ActivoUsuario"]=true;
        }

        private void usuariosDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //this.usuariosBindingSource.EndEdit();
        }

       
       
    }
}
