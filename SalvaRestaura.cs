using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public partial class SalvaRestaura : Form
    {
        public SalvaRestaura()
        {
            InitializeComponent();
        }

       
         private void SalvaRestaura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.FillByUsuarioActual(this.promowork_dataDataSet.Usuarios,VariablesGlobales.nIdUsuarioActual);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               
                string Camino = pathSalvaTextBox.Text;
                queriesTableAdapter1.Backup_data(Camino, VariablesGlobales.nIdUsuarioActual);
                
                MessageBox.Show("Salva Realizada Correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la Salva. Revice que exista y tenga permisos de escritura (desde el servidor) la Ubicación donde se pretende almacenar el fichero de la Salva.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Camino = pathRestauraTextBox.Text;
                queriesTableAdapter2.Restore_data(Camino, VariablesGlobales.nIdUsuarioActual);
                
                MessageBox.Show("Restaura Realizada Correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                try
                {
                    string Camino1 = pathSalvaTextBox.Text;
                    queriesTableAdapter1.Backup_data(Camino1, VariablesGlobales.nIdUsuarioActual);
                }
                catch { }
               
              }
              
              catch
              {
                  MessageBox.Show("No se pudo realizar la Restaura. Verifique que no existan otros usuarios conectados al sistema. Revice que exista y sea accesible (desde el servidor) la Ubicación y el Fichero que pretende Restaurar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            

        }
        
    }
}
