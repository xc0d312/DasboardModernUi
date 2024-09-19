using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Contracts;
using pointSalesv1.Cache;
using pointSalesv1.Messages;
using pointSalesv1.ObjValues;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.Views
{
    public partial class CompraForm : Form
    {
        entrada objEntrada;
        detalle_entrada objDetalleEntrada;
        public CompraForm()
        {
            InitializeComponent();
            agregarColumnasTabla();
        }

        private void txtProducto_EditValueChanged(object sender, EventArgs e)
        {
            var row = ViewProductos.GetFocusedRow() as productos;
            textCantidad.Value = row.stock;
            textPrecio.Value = (decimal)row.precio;
        }

        private void txtProveedor_EditValueChanged(object sender, EventArgs e)
        {
            proveedores objProveedores = (proveedores)viewProveedores.GetFocusedRow();
            objEntrada.id_proveedor = objProveedores;
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {
            objEntrada = new entrada(sessionWork);
            customTable();
         
        }
        //para validar que el producto nose repita en el carrito de compras
        private bool validarComprasProductoAdd(string product, DataGridView dg)
        {
            if (product == null) return false;
            foreach (DataGridViewRow item in dg.Rows)
            {
                string rowToVerify = Convert.ToString(item.Cells[0].Value);

                if (product == rowToVerify)
                {
                    ErrorForm.showMessageForm("Este producto ya está en el carrito");
                    return true; // El producto ya existe en el carrito
                }
            }
            return false; // El producto no existe en el carrito
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objEntrada.fecha = dateTimePicker1.Value;
            objEntrada.total = Convert.ToDouble(textTotal.Value);
            if (!validar(objEntrada))
            {
                objEntrada.Session.Reload(objEntrada);
                return;
            }
            sessionWork.Save(objEntrada);
            sessionWork.CommitChanges();
            NotifyForm.showMessageForm("Datos guardados correctamente!!");
            clearCajas();
            UI.clearBoxNumericDown(new List<NumericUpDown> { textCantidad, textTotal, textPrecio, textCosto });
            reloadBoxs();
            CompraForm_Load(sender, e);
            checkout(false);
            ViewProductos.RefreshEditor(true);

        }
        private bool validar<T>(T obj) where T : entrada
        {
            var models = new ValidationModelsEntrada();
            var res = models.Validate(obj);
            if (!res.IsValid)
            {
                foreach (var item in res.Errors)
                {
                    ErrorForm.showMessageForm(item.ErrorMessage);
                    res.Errors.Clear();
                    break;
                }
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UI.clearBoxNumericDown(new List<NumericUpDown>() { textCantidad, textCosto, textPrecio, textTotal });
            clearCajas();
            txtProveedor.Text = "";
            checkout(true);
        }
        private void checkout(bool done)
        {
            groupBoxCajas.Enabled = done;
            btnGuardar.Enabled = done;
            textTotal.Enabled = false;
        }
        private void clearCajas()
        {
            txtProducto.Text = "";
            txtProveedor.Text = "";
            txtTipoUnidad.Text = "";
        }

        private void tableCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableCompras.Rows.Count == 0) return;
            if (tableCompras.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                //var row = tableCompras.CurrentRow.Index;
                //var obj = (detalle_entrada)gridView2.GetRow(row);
                var cell = tableCompras["ColumnCodigo",e.RowIndex].Value.ToString();
                var detalleToRemove = objEntrada.detalle_entradas.FirstOrDefault(d => d.id_prod.codigo == cell); ;
                objEntrada.detalle_entradas.Remove(detalleToRemove);
                objEntrada.Session.Reload(detalleToRemove);
                var result = detalleToRemove.costo * detalleToRemove.cantidad;
                textTotal.Value -= Convert.ToInt32(result);
                //objEntrada.detalle_entradas.Remove(obj);
                //objEntrada.Session.Reload(obj);
                //var result = obj.costo * obj.cantidad;
                //textTotal.Value -= Convert.ToInt32(result);
                tableCompras.Rows.Remove(tableCompras.CurrentRow);
                objEntrada.detalle_entradas.Remove(detalleToRemove);

                tableCompras.ClearSelection();
                clearCajas();
                UI.clearBoxNumericDown(new List<NumericUpDown>() { textCantidad, textPrecio });
            }
        }
        private void tableCompras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tableCompras.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                e.Value = pointSalesv1.Properties.Resources.Delete_16;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reloadBoxs()
        {
            textTotal.Value = 0;
            textCosto.Value = 0;
            textPrecio.Value = 0;
            textCantidad.Value = 0;
            tableCompras.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!addProductsTableShoppings()) return;
            
            transactionMath obj = new transactionMath();
            if (textTotal.Value > 0)
            {
                var resul = obj.mountTotal(Convert.ToDouble(textCosto.Value), Convert.ToInt32(textCantidad.Value));
                textTotal.Value += resul;
            }
            else
            {
                var resul = obj.mountTotal(Convert.ToDouble(textCosto.Value), Convert.ToInt32(textCantidad.Value));
                textTotal.Value = resul;
            }
            saveDataMemory();
            clearCajas();
            UI.clearBoxNumericDown(new List<NumericUpDown>() { textCantidad, textCosto, textPrecio });
        }
        private void saveDataMemory()
        {
            //objetos 
            objDetalleEntrada = new detalle_entrada(sessionWork);
            objDetalleEntrada.id_prod = ViewProductos.GetFocusedRow() as productos;
            objDetalleEntrada.tipoUnidad = gridView3.GetFocusedRow() as tipounidad;
            objDetalleEntrada.costo = Convert.ToDouble(textCosto.Value);
            objDetalleEntrada.cantidad = Convert.ToInt32(textCantidad.Value);
            objDetalleEntrada.precio = Convert.ToDouble(textPrecio.Value);
            objDetalleEntrada.tipoUnidad = (tipounidad)txtTipoUnidad.GetSelectedDataRow();
            objDetalleEntrada.Save();
      
            objEntrada.detalle_entradas.Add(objDetalleEntrada);

        }
        private bool addProductsTableShoppings()
        { 
            if (UI.areFieldsNotEmpty(txtProducto, txtProveedor, txtTipoUnidad,textCantidad,textCosto))
            {
                ErrorForm.showMessageForm("Complete los campos");
                return false;
            }
            if(textCosto.Value >= textPrecio.Value)
            {
                ErrorForm.showMessageForm("El costo no puede ser mayor ó igual que el precio de venta!!");
                return false;
            }
           
                ////codigo producto
                var codigo = ViewProductos.GetFocusedRowCellValue("codigo");

                //validar si el producto ya esta en el carrito de compras
                if (validarComprasProductoAdd(codigo.ToString(), tableCompras)) return false;

                tableCompras.Rows.Add(
                    codigo.ToString(), 
                    txtProducto.Text, 
                    textCosto.Value.ToString(), 
                    textPrecio.Value.ToString(),
                    textCantidad.Value.ToString(), 
                    txtProveedor.Text);

                tableCompras.ClearSelection();
                return true;
        }
        private void customTable()
        {
            tableCompras.Columns[0].Width = 70;
            tableCompras.Columns[1].Width = 200;
            tableCompras.Columns[2].Width = 70;
            tableCompras.Columns[3].Width = 70;
            tableCompras.Columns[4].Width = 70;
            tableCompras.Columns[5].Width = 200;
        }
        private void agregarColumnasTabla()
        {
            DataGridViewImageColumn columnDelete = new DataGridViewImageColumn();

            columnDelete.Name = "btnDelete";
            tableCompras.Columns.Insert(6, columnDelete);
        }

        private void labelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textCantidad.Value = 0;
            textCosto.Value = 0;
            textTotal.Value = 0;
            textPrecio.Value = 0;
        }

      
    }
}
