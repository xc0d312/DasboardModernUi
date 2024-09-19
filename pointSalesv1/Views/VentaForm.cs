using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Contracts;
using pointSalesv1.Messages;
using pointSalesv1.ObjValues;
using pointSalesv1.Cache;
using DevExpress.Xpo;

namespace pointSalesv1.Views
{
    public partial class VentaForm : Form
    {
        venta objVenta;
        detalle_venta objDetalleVenta;
        decimal costoProducto;
        int stock;
        productos productSelected;
        public VentaForm()
        {
            InitializeComponent();
            checkout(false);
            agregarColumnasTabla();
            configAutoComplete();
            customTable();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!addProductsTableSales()) return;
            transactionMath obj = new transactionMath();
            if (txtDescuento.Value != 0)
            {
                var importe = calcularDescuento(txtDescuento.Value);
                var result = obj.mountTotal(Convert.ToDouble(txtPrecio.Value), Convert.ToInt32(txtCantidad.Value));
                var precioNeto = result - (importe * result);
                txtTotal.Value += precioNeto;
            }
            else
            {
                var result = obj.mountTotal(Convert.ToDouble(txtPrecio.Value), Convert.ToInt32(txtCantidad.Value));
                txtTotal.Value += result;
            }
            saveDataMemory();
            txtProducto.Text = "";
            UI.clearBoxNumericDown(new List<NumericUpDown> { txtCantidad, txtPrecio, txtDescuento });
            txtDescuento.Value = 0;
        }
        private void saveDataMemory()
        {
            objDetalleVenta = new detalle_venta(sessionWork);
            objDetalleVenta.id_prod = productSelected;
            objDetalleVenta.precioUnitario = Convert.ToDouble(txtPrecio.Value);
            objDetalleVenta.costoUnitario = Convert.ToDouble(costoProducto);
            objDetalleVenta.descuento = Convert.ToDouble(txtDescuento.Value);
            objDetalleVenta.cantidad = Convert.ToInt32(txtCantidad.Value);
            objDetalleVenta.Save();
            objVenta.detalle_ventas.Add(objDetalleVenta);
        }

        private bool addProductsTableSales()
        {
            groupBoxOperacionesCajas.Enabled = true;
            if (UI.areFieldsNotEmpty(txtCliente, txtCantidad))
            {
                ErrorForm.showMessageForm("Complete los campos");
                return false;
            }


            //var codigo = getProductosList()
            //                .Where(p => p.nombre == productSelected)
            //                 .Select(p => p.codigo)
            //                 .FirstOrDefault();

            //var codigo = viewProductos.GetFocusedRowCellValue("codigo");
            var codigo = productSelected.codigo;
            if (validarExistenciaProducto(codigo.ToString(), tableVentas))
            {
                return false;
            }

            tableVentas.Rows.Add(codigo, txtProducto.Text, txtPrecio.Value.ToString(), txtCantidad.Value.ToString(), txtCliente.Text);
            tableVentas.ClearSelection();
            return true;
        }
        private void txtCliente_EditValueChanged(object sender, EventArgs e)
        {
            clientes objCliente = searchLookUpEdit2View.GetFocusedRow() as clientes;
            objVenta.id_cliente = objCliente;
        }
        private void reloadBoxs()
        {
            txtTotal.Value = 0;
            txtDescuento.Value = 0;
            txtPrecio.Value = 0;
            txtCantidad.Value = 0;
            tableVentas.Rows.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UI.clearBoxNumericDown(new List<NumericUpDown>() { txtDescuento, txtPrecio, txtTotal });
            checkout(true);
        }

        private void tableVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tableVentas.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                e.Value = pointSalesv1.Properties.Resources.Delete_16;
            }
        }
        private void checkout(bool done)
        {
            groupBoxCajas.Enabled = done;
            btnGuardar.Enabled = done;
            txtTotal.Enabled = false;
        }
        private void clearCajas()
        {
            txtProducto.Text = "";
            txtCliente.Text = "";
            labelCobro.Text = "";
        }
        private bool validar<T>(T obj) where T : venta
        {
            var models = new validationModelsVenta();
            var res = models.Validate(obj);
            if (!res.IsValid)
            {
                foreach (var item in res.Errors)
                {
                    ErrorForm.showMessageForm(item.ErrorMessage);
                }
                return false;
            }
            return true;
        }
        private bool validarDetalleVentas<T>(T obj) where T : detalle_venta
        {
            var models = new validationModelsDetalleVenta();
            var res = models.Validate(obj);
            if (!res.IsValid)
            {
                foreach (var item in res.Errors)
                {
                    ErrorForm.showMessageForm(item.ErrorMessage);
                }
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                try
                {
                    objVenta.fecha = rjDatePicker1.Value;
                    objVenta.total = Convert.ToDouble(txtTotal.Value);
                    //objVenta.id_usuario = viewUsuario.GetFocusedRow() as usuarios;
                    objVenta.id_usuario = sourceUsuarios.OfType<usuarios>().FirstOrDefault(user => user.fullName == UserActive.fullname);
                    if (!validar(objVenta))
                    {
                        objVenta.Session.Reload(objVenta);
                        return;
                    }
                    else if (!validarDetalleVentas(objDetalleVenta))
                    {
                        objDetalleVenta.Session.Reload(objDetalleVenta);
                        return;
                    }
                    sessionWork.Save(objVenta);
                    sessionWork.CommitChanges();
                    NotifyForm.showMessageForm("Datos guardados correctamente!!");
                    clearCajas();
                    UI.clearBoxNumericDown(new List<NumericUpDown> { txtCantidad, txtTotal, txtPrecio, txtDescuento });
                    reloadBoxs();
                    sourceVentas.Reload();
                    sourceProducts.Reload();
                    productSelected.Reload();
                }
                catch (Exception ex)
                {
                    throw;
                }
        }
        private bool validarExistenciaProducto(string product, DataGridView dg)
        {
            if (product == null) return false;
            foreach (DataGridViewRow item in dg.Rows)
            {
                string verify = Convert.ToString(item.Cells[0].Value);
                if (product == verify.ToString())
                {
                    //dg.Rows.Remove(dg.CurrentRow);
                    txtPrecio.Value = 0;
                    txtCantidad.Value = 0;
                    ErrorForm.showMessageForm("Este producto ya esta en el carrito");
                    return true;
                }
            }
            return false;
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            objVenta = new venta(sessionWork);

        }
        private void agregarColumnasTabla()
        {
            DataGridViewImageColumn columnDelete = new DataGridViewImageColumn();

            columnDelete.Name = "btnDelete";
            tableVentas.Columns.Insert(5, columnDelete);

        }
        private void customTable()
        {
            tableVentas.Columns[0].Width = 100;
            tableVentas.Columns[1].Width = 250;
            tableVentas.Columns[2].Width = 100;
            tableVentas.Columns[3].Width = 100;
            tableVentas.Columns[4].Width = 250;
            tableVentas.Columns[5].Width = 60;
        }
        private decimal calcularDescuento(decimal descuento)
        {
            return descuento / 100;
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Value > stock)
            {
                ErrorForm.showMessageForm("No puede pasar la cantidad de stock");
                txtCantidad.ResetText();
                txtCantidad.Value = 0;
                return;
            }
        }

        private void labelCalcular_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbMoneda.Text == "Dolar")
            {
                labelCobro.Text = Convert.ToString(txtCobro.Value - txtTotal.Value);
            }
            else if (cbMoneda.Text == "Cordobas")
            {
                if (txtCambioMoneda.Value != 0)
                {
                    var result = Math.Round(txtCobro.Value / txtCambioMoneda.Value);//cambiamos a dolares

                    var cambio = result > txtTotal.Value ? result - txtTotal.Value : txtTotal.Value - result;
                    labelCobro.Text = Convert.ToString(cambio * txtCambioMoneda.Value);

                }
                else
                {
                    ErrorForm.showMessageForm("Campo moneda de cambio esta vacio");
                }

            }
        }

     
        private void configAutoComplete()
        {
            //AutoCompleteStringCollection fuenteCompletar = new AutoCompleteStringCollection();
            //fuenteCompletar.AddRange(getProductosList().Select(producto => producto.nombre).ToArray());
            //textBox1.AutoCompleteCustomSource = fuenteCompletar;
            //textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private List<productos> getProductosList()
        {
            //return sourceProducts.OfType<productos>().Select(d => new productos(sessionWork)
            //{
            //    idProductos = d.idProductos,
            //    codigo = d.codigo,
            //    nombre = d.nombre,
            //    id_estado = d.id_estado,
            //    id_categoria = d.id_categoria,
            //    id_marcas = d.id_marcas,
            //    costo = d.costo,
            //    stock = d.stock,
            //    precio = d.precio,
            //    tipoUnidad = d.tipoUnidad

            //}).ToList();
            List<productos> lst = new List<productos>();

            var products = sessionWork.Query<productos>().ToList();

            foreach (productos item in products)
            {
                lst.Add(new productos(sessionWork)
                {
                    idProductos = item.idProductos,
                    codigo = item.codigo,
                    nombre = item.nombre,
                    id_estado = item.id_estado,
                    id_categoria = item.id_categoria,
                    id_marcas = item.id_marcas,
                    costo = item.costo,
                    stock = item.stock,
                    precio = item.precio,
                    tipoUnidad = item.tipoUnidad
                });
            }

            return lst;
        }
        private void SetSelectedProductValues()
        {
            if (productSelected == null) return;

            if (productSelected.stock > 0 && productSelected.id_estado.estado1 == "DISPONIBLE")
            {

                txtPrecio.Value = (decimal)productSelected.precio;
                costoProducto = (decimal)productSelected.costo;
                stock = productSelected.stock;
            }
            else
            {
                clearCajas();
                UI.clearBoxNumericDown(new List<NumericUpDown>() { txtDescuento, txtPrecio });
                ErrorForm.showMessageForm("Producto no esta en stock");
                return;
            }
        }

        private void btnListProducto_Click(object sender, EventArgs e)
        {
            var frm = new ListaProductsForm(sessionWork);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                productSelected = frm.getProductSelected();
                txtProducto.Text = productSelected.nombre;
                SetSelectedProductValues();
            }
        }

        private void tableVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableVentas.Rows.Count == 0) return;
            if (tableVentas.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var cell = tableVentas["ColumnCodigo", e.RowIndex].Value.ToString();
                var detalleVentaToRemove = objVenta.detalle_ventas.FirstOrDefault(d => d.id_prod.codigo == cell);
                objVenta.detalle_ventas.Remove(detalleVentaToRemove);
                objVenta.Session.Reload(detalleVentaToRemove);
                var resul = detalleVentaToRemove.precioUnitario * detalleVentaToRemove.cantidad;
                txtTotal.Value -= Convert.ToInt32(resul);
                tableVentas.Rows.Remove(tableVentas.CurrentRow);
                tableVentas.ClearSelection();
            };
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            viewSales.ShowPrintPreview();
        }
    }
}
