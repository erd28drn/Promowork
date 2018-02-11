using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace Promowork
{
    public partial class frmPresupuestos : Form
    {
        public frmPresupuestos()
        {
            InitializeComponent();
        }

        private void presupCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.presupCabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);

        }

        private void frmPresupuestos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.promowork_dataDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'promowork_dataDataSet.Obras' Puede moverla o quitarla según sea necesario.
            this.obrasTableAdapter.Fill(this.promowork_dataDataSet.Obras);
            this.WindowState = FormWindowState.Maximized;

            this.presupCabTableAdapter.FillByEmpresa(this.promowork_dataDataSet.PresupCab, VariablesGlobales.nIdEmpresaActual, VariablesGlobales.nAnoActual);
             this.presupCapTableAdapter.Fill(this.promowork_dataDataSet.PresupCap);
             this.presupDetTableAdapter.Fill(this.promowork_dataDataSet.PresupDet); 
             this.presupSubTableAdapter.Fill(this.promowork_dataDataSet.PresupSub);
           

        }

        private void frmPresupuestos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (promowork_dataDataSet.HasChanges() == true)
            {
                if (MessageBox.Show("Desea Salvar los Cambios realizados al Presupuesto?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    presupCabBindingNavigatorSaveItem_Click(null, null);

                }

            }
            promowork_dataDataSet.Clear();
        }

        private void BotonesCapitulo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
            if (e.Button.Tag == "Borrar")
            {
                gridView3.DeleteSelectedRows();
            }
            else if (e.Button.Tag == "SubCapitulo")
            {
               // presupDetBindingSource.AddNew();
                //DataRowView detalle = (DataRowView)presupDetBindingSource.Current;

                presupDetTableAdapter.Insert(null,null,null,"",(int)gridView3.GetFocusedRowCellValue("IdPresupCap"),"", "", null, null);
               // detalle["IdPresupCap"] = gridView3.GetFocusedRowCellValue("IdPresupCap");
                gridView3.RefreshData();
                gridView3.ExpandGroupRow(gridView3.FocusedRowHandle);
               
                //gridView4.AddNewRow();
                //gridView4.SetFocusedRowCellValue("IdPresupCap", gridView3.GetFocusedRowCellValue("IdPresupCap"));
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // && e.Modifiers == Keys.Control
            {
                if (MessageBox.Show("Confirma que desea Eliminar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GridView grid = (GridView)gridControl1.FocusedView;

                    grid.DeleteSelectedRows();
                }
            }
        }

        private void btnExpCap_Click(object sender, EventArgs e)
        {
           
            if (btnExpCap.Tag == "+")
            {
                gridView3.BeginUpdate();
                for (int i = 0; i < gridView3.RowCount; i++)
                {
                    
                    gridView3.SetMasterRowExpanded(i,true);

                }
                gridView3.EndUpdate();
                btnExpCap.Text = "- Contraer Capítulos";
                btnExpCap.Tag = "-";
            }
            else
            {
                gridView3.CollapseAllDetails();
                btnExpCap.Text = "+ Expandir Capítulos";
                btnExpCap.Tag = "+";
            }
            btnExpCap.ForeColor = Color.Black;
        }

        private void btnExpSubcap_Click(object sender, EventArgs e)
        {
            
            if (btnExpSubcap.Tag == "+")
            {
                
                gridView3.BeginUpdate();
                for (int i = 0; i < gridView3.RowCount; i++)
                {

                    gridView3.SetMasterRowExpanded(i, true);

                    try
                    {
                        GridView detalle = (GridView)gridView3.GetDetailView(i, 2);
                        //MessageBox.Show(detalle.RowCount.ToString());
                        for (int j = 0; j < detalle.RowCount; j++)
                        {
                            detalle.SetMasterRowExpanded(j, true);
                        }

                    }
                    catch
                    { }
                }
                  gridView3.EndUpdate();
                  btnExpSubcap.Text = "- Contraer Subcapítulos";
                  btnExpSubcap.Tag = "-";
            }
            else
            {

                gridView3.BeginUpdate();
                for (int i = 0; i < gridView3.RowCount; i++)
                {

                  //  gridView3.SetMasterRowExpanded(i, true);

                    try
                    {
                        GridView detalle = (GridView)gridView3.GetDetailView(i, 2);
                        //MessageBox.Show(detalle.RowCount.ToString());
                        for (int j = 0; j < detalle.RowCount; j++)
                        {
                            detalle.SetMasterRowExpanded(j, false);
                        }

                    }
                    catch
                    { }
                }
                gridView3.EndUpdate();
                btnExpSubcap.Text = "+ Expandir Subcapítulos";
                btnExpSubcap.Tag = "+";
            }
            btnExpSubcap.ForeColor = Color.Black;

        }

        private void btnExpSubcap_MouseDown(object sender, MouseEventArgs e)
        {
            btnExpSubcap.Text = "Espere por Favor...";
            btnExpSubcap.ForeColor = Color.Blue;
        }

        private void btnExpCap_MouseDown(object sender, MouseEventArgs e)
        {
            btnExpCap.Text = "Espere por Favor...";
            btnExpCap.ForeColor = Color.Blue;
        }

       
    }
}
