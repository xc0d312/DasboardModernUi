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
using pointSalesv1.Cache;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Repository;
using pointSalesv1.Messages;
using pointSalesv1.ObjValues;
using DevExpress.Data;
using DevExpress.Xpo;


namespace pointSalesv1.Views
{
    public partial class ProductHijoForm : Form
    {
        productos objProductos;
        productos productSelected;
        public ProductHijoForm()
        {
            InitializeComponent();
            this.viewsProductos.RowCellClick += actualizarOEliminarProducto;
            this.viewsProductos.RowUpdated += ViewsProductos_RowUpdated;
            permissionUsers();
        }

        private void productHijoForm_Load(object sender, EventArgs e)
        {
           
        }

        private void permissionUsers()
        {
            if (UserActive.rol == Position.vendedor.ToUpper())
            {
                //btnCategorias.Enabled = false;
                //btnNuevoProducto.Enabled = false;
                //btnMarcas.Enabled = false;
            }
        }
     
        private void actualizarOEliminarProducto(object sender, RowCellClickEventArgs e)
        {
            switch (viewsProductos.Columns[e.Column.VisibleIndex].Name)
            {
                case "colEditar":
                    // objProductos.id_categoria = repositoryItemLookUpEdit1.GetDataSourceValue();
                    //string value = viewsProductos.GetRowCellValue(1, "gridColumn1", MyOperationCompleted).ToString();
                    // int index = (int)viewsProductos.FocusedRowHandle;
                    //  int index = viewsProductos.GetDataRowHandleByGroupRowHandle(viewsProductos.FocusedRowHandle);
                    //var cellValue= repositoryItemLookUpEdit1.GetDataSourceValue(gridColumn1.GetCaption(), index);

                    //productos row = viewsProductos.GetRow(viewsProductos.GetSelectedRows()[0]) as productos;

                    productSelected = viewsProductos.GetRow(viewsProductos.GetSelectedRows()[0]) as productos;
                    using (var frm = new ProductosForm(sessionWork,productSelected))
                    {

                        frm.update = true;
                        frm.txtCodigo.Text = productSelected.codigo;
                        frm.txtNombre.Text = productSelected.nombre;
                        frm.txtPrecio.Value = (Decimal)productSelected.precio;
                        frm.txtStock.Value = productSelected.stock;

                        frm.cbCategoria.Properties.DataSource = sourceCategoria;
                        frm.cbCategoria.Properties.DisplayMember = "nombre";
                        frm.cbCategoria.Properties.ValueMember = "idCategoria";

                        frm.cbCategoria.EditValue = productSelected.id_categoria.idCategoria;

                        frm.cbEstado.Properties.DataSource = sourceEstado;
                        frm.cbEstado.Properties.DisplayMember = "estado1";
                        frm.cbEstado.Properties.ValueMember = "idstado";

                        frm.cbEstado.EditValue = productSelected.id_estado.idstado;// se supone que estos controles son xtraEditor.lookUpedits, pero nose como mandar este tipo de datos 

                        frm.cbMarcas.Properties.DataSource = sourceMarcas;
                        frm.cbMarcas.Properties.DisplayMember = "marcas1";
                        frm.cbMarcas.Properties.ValueMember = "idMarcas";
                        frm.cbMarcas.EditValue = productSelected.id_marcas.idMarcas;

                        frm.cbTipoUnidad.Properties.DataSource = sourceUnidades;
                        frm.cbTipoUnidad.Properties.DisplayMember = "tipoUnidad";
                        frm.cbTipoUnidad.Properties.ValueMember = "idtipoUnidad";

                        frm.cbTipoUnidad.EditValue = productSelected.tipoUnidad.idtipoUnidad;// se supone que estos controles son xtraEditor.lookUpedits, pero nose como mandar este tipo de datos 

                        
                        frm.ShowDialog();
                    }
                    
                    //objProductos = viewsProductos.GetFocusedRow() as productos;
                    //objProductos.nombre = row.nombre.ToUpper();

                    //sessionWork.Save(objProductos);
                    //sessionWork.CommitChanges();
                    //NotifyForm.showMessageForm("Datos Actualizados correctamente");
                    break;
                case "colDelete":

                    DangerForm objForm = new DangerForm("Esta seguro que " +
                " desea eliminar este producto");
                    if (viewsProductos.SelectedRowsCount > 0)
                    {
                        if (objForm.ShowDialog() == DialogResult.OK)
                        {
                            objProductos = viewsProductos.GetFocusedRow() as productos;
                            sessionWork.Delete(objProductos);
                            sessionWork.CommitChanges();
                            sourceProductos.Reload();
                        }

                    }

                    break;

                default:
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
           
        }
        private void ViewsProductos_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            // Guardar los cambios en la base de datos
            NotifyForm.showMessageForm("Necesita confirmar la actualizacion en el icono de editar");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                viewsProductos.ExportToXls(path);

            }
        }

        //private void btnCategorias_Click(object sender, EventArgs e)
        //{
        //    var frm = new CategoriasForm();
        //    frm.ShowDialog();
        //    getsCount();
        //}

        //private void btnMarcas_Click(object sender, EventArgs e)
        //{
        //    var frm = new MarcasForm();
        //    frm.ShowDialog();
        //    getsCount();
        //}

        //private void btnNuevoProducto_Click(object sender, EventArgs e)
        //{
        //    var frm = new ProductosForm();
        //    frm.ShowDialog();
        //    getsCount();
        //}

        private void viewsProductos_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            productos row = viewsProductos.GetRow(viewsProductos.GetSelectedRows()[0]) as productos;
            countStock.Text = row.stock.ToString();

        }
    }
}
