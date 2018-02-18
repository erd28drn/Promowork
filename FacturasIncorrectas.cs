using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public partial class FacturasIncorrectas : Form
    {
        public FacturasIncorrectas()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DataTable tmpFacturas)
        {
            gridFacturas.DataSource = tmpFacturas;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
