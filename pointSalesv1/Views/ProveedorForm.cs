using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Messages;
using pointSalesv1.Models.puntoVenta;
using DevExpress.Data;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
namespace pointSalesv1.Views
{
    public partial class ProveedorForm : Form
    {
        proveedores objProveedor;
        proveedores proveedorSelected;
        public ProveedorForm()
        {
            InitializeComponent();
            this.viewsProveedores.RowCellClick += actualizarOEliminarProveedor;
        }
        private void actualizarOEliminarProveedor(object sender,RowCellClickEventArgs e)
        {
            switch (viewsProveedores.Columns[e.Column.VisibleIndex].Name)
            {
                case "colEditar":

                    proveedorSelected = viewsProveedores.GetRow(viewsProveedores.GetSelectedRows()[0]) as proveedores;
                    using (var frm = new RegistroProveedores(sessionWork,proveedorSelected))
                    {
                        frm.update = true;
                        frm.txtCodigo.Text = proveedorSelected.codigo;
                        frm.txtProveédor.Text = proveedorSelected.empresa;
                        frm.txtRazon.Text = proveedorSelected.razon;
                        frm.txtDireccion.Text = proveedorSelected.direccion;
                        frm.txtTelefono.Text = proveedorSelected.telefono;
                        frm.ShowDialog();

                      }
                    break;
                case "colDelete":
                    DangerForm objForm = new DangerForm("Esta seguro que desea eliminar este cliente");
                    if (viewsProveedores.SelectedRowsCount > 0)
                    {
                        if (objForm.ShowDialog()== DialogResult.OK)
                        {
                            objProveedor = viewsProveedores.GetFocusedRow() as proveedores;
                            sessionWork.Delete(objProveedor);
                            sessionWork.CommitChanges();
                            sourceProveedores.Reload();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                viewsProveedores.ExportToXls(path);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            viewsProveedores.ShowPrintPreview();
        }
    }
}
