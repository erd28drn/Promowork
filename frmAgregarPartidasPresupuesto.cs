using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Promowork
{
    public partial class frmAgregarPartidasPresupuesto : Form
    {
        private int vIdPresupCab;

        public frmAgregarPartidasPresupuesto(int pIdPresupCab)
        {
            InitializeComponent();
            vIdPresupCab = pIdPresupCab;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                queriesPresupuestos1.AgregarCapDetSub(vIdPresupCab, (int)spnCapitulos.Value, (int)spnDetalles.Value, (int)spnSubdetalles.Value);
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No fue posible agregar las partidas. Mensaje de error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
