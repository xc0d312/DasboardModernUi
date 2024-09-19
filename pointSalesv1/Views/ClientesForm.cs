using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using pointSalesv1.ObjValues;
using DevExpress.Data;
using DevExpress.Xpo;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Messages;

namespace pointSalesv1.Views
{
    public partial class ClientesForm : Form
    {

        clientes objClientes;
        clientes clientesSelected;
        public ClientesForm()
        {
            InitializeComponent();
            this.viewsClientes.RowCellClick += actualizarOEliminarClientes;

        }
        private void actualizarOEliminarClientes(object sender, RowCellClickEventArgs e)
        {
            switch (viewsClientes.Columns[e.Column.VisibleIndex].Name)
            {
                case "colEditar":

                    clientesSelected = viewsClientes.GetRow(viewsClientes.GetSelectedRows()[0]) as clientes;
                    using (var frm = new RegistroClientes(sessionWork, clientesSelected))
                    {
                        frm.update = true;
                        frm.txtDni.Text = clientesSelected.dni;
                        frm.txtNombre.Text = clientesSelected.nombre;
                        frm.txtTelefono.Text = clientesSelected.telefono;
                        frm.txtDireccion.Text = clientesSelected.direccion;
                        frm.cbSexo.Items.AddRange(new string[] { "M", "F" });
                        frm.cbSexo.SelectedItem = clientesSelected.sexo.ToString();
                        frm.txtEmail.Text = clientesSelected.email;
                        frm.ShowDialog();
                    }
                    break;
                case "colDelete":
                    DangerForm objForm = new DangerForm("Esta seguro que desea eliminar este cliente");
                    if (viewsClientes.SelectedRowsCount > 0)
                    {
                        if (objForm.ShowDialog() == DialogResult.OK)
                        {
                            objClientes = viewsClientes.GetFocusedRow() as clientes;
                            sessionWork.Delete(objClientes);
                            sessionWork.CommitChanges();
                            sourceClientes.Reload();
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
                viewsClientes.ExportToXls(path);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            viewsClientes.ShowPrintPreview();
        }
    }
}
