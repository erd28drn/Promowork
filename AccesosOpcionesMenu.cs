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
    public partial class AccesosOpcionesMenu : Form
    {
        public AccesosOpcionesMenu()
        {
            InitializeComponent();
        }

       
        private void AccesosOpcionesMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosAccesos.OpcionesMenu' Puede moverla o quitarla según sea necesario.
            this.opcionesMenuTableAdapter.Fill(this.datosAccesos.OpcionesMenu);
            // TODO: esta línea de código carga datos en la tabla 'datosAccesos.AccesosOpciones' Puede moverla o quitarla según sea necesario.
           
            this.usuariosTableAdapter.Fill(this.datosAccesos.Usuarios);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.accesosOpcionesTableAdapter.FillByUsuario(this.datosAccesos.AccesosOpciones, (int)gridView1.GetFocusedRowCellValue("IdUsuario"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accesosOpcionesBindingSource.EndEdit();
            this.accesosOpcionesTableAdapter.Update(datosAccesos.AccesosOpciones);
        }

        private void btnAccesoTodo_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(gridView2.RowCount.ToString());
            
            for (int i = 0; i< gridView2.RowCount; i++)
            {

                gridView2.SetRowCellValue(i, "Acceso", true);
            
            }
        }

        

        private void btnAccesoNada_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, "Acceso", false);

            }
        }
    }
}
