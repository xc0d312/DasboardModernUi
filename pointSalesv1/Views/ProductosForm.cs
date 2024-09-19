using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Cache;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.ObjValues;
using pointSalesv1.Messages;
using pointSalesv1.Contracts;
using DevExpress.Xpo;

namespace pointSalesv1.Views
{
    public partial class ProductosForm : Form,IProductsRepository
    {
        productos objProductos;
        public bool update = false;
        private productos productSelected;
        //private Session sessionWork1;        //private Session sessionWork1;
        public ProductosForm(DevExpress.Xpo.UnitOfWork session,productos product)
        {
            InitializeComponent();
            this.sessionWork = session;
            this.productSelected = product;
        }
        public ProductosForm()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            objProductos = update ? productSelected as productos : new productos(sessionWork);
            objProductos.nombre = txtNombre.Text.Trim().ToUpper();
            objProductos.id_categoria = (categoria)cbCategoria.GetSelectedDataRow();
            objProductos.id_estado = (estado)cbEstado.GetSelectedDataRow();
            objProductos.id_marcas = (marcas)cbMarcas.GetSelectedDataRow();
            objProductos.tipoUnidad = (tipounidad)cbTipoUnidad.GetSelectedDataRow();
            objProductos.precio = Convert.ToDouble(txtPrecio.Value);
            objProductos.stock = Convert.ToInt32(txtStock.Value);

            //validar campos y existencia de productos

            if (!update)
            {
                var result = await validar(objProductos);
                if (!result)
                {
                    objProductos.Session.Reload(objProductos);
                    return;
                }
            }
         

            if (update)
            {
                sessionWork.Save(objProductos);
                sessionWork.CommitChanges();
                update = false;
                this.Close();
            }
            sessionWork.Save(objProductos);
            sessionWork.CommitChanges();


           
            NotifyForm.showMessageForm("Datos guardados correctamente!!");
            clearComboxs();
            UI.clearCajas(this.Controls);
            UI.clearBoxNumericDown(new List<NumericUpDown> { txtPrecio, txtStock });

        }
        private void loadComboboxs()
        {
            cbCategoria.Properties.NullText = string.Empty;
            cbCategoria.Properties.DataSource = sourceCategoria;
            cbCategoria.Properties.DisplayMember = "nombre";
            cbCategoria.Properties.ValueMember = "idCategoria";
            cbCategoria.Properties.ForceInitialize();

            cbEstado.Properties.NullText = string.Empty;
            cbEstado.Properties.DataSource = sourceEstado;
            cbEstado.Properties.DisplayMember = "estado1";
            cbEstado.Properties.ValueMember = "idstado";
            cbEstado.Properties.ForceInitialize();

            cbMarcas.Properties.NullText = string.Empty;
            cbMarcas.Properties.DataSource = sourceMarcas;
            cbMarcas.Properties.DisplayMember = "marcas1";
            cbMarcas.Properties.ValueMember = "idMarcas";
            cbMarcas.Properties.ForceInitialize();

            cbTipoUnidad.Properties.NullText = string.Empty;
            cbTipoUnidad.Properties.DataSource = sourceUnidades;
            cbTipoUnidad.Properties.DisplayMember = "tipoUnidad";
            cbTipoUnidad.Properties.ValueMember = "idtipoUnidad";
            cbTipoUnidad.Properties.ForceInitialize();
          }
        private async Task<bool> validar<T>(T obj) where T : productos
        {
            var valid = new ValidationModelsProducts();

            var result = await valid.ValidateAsync(obj);

            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ErrorForm.showMessageForm(item.ToString());
                    break;
                }
                return false;
            }
            return true;
        }
        private void clearComboxs()
        {

            cbCategoria.Text = "";
            cbEstado.Text = "";
            cbMarcas.Text = "";
            cbTipoUnidad.Text = "";
        }
        public bool existProdStock(string name)
        {
            bool exist = false;
            foreach (productos item in sourceProductos)
            {
                if (name == item.nombre)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        private void btnClosse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUnidad_Click(object sender, EventArgs e)
        {
            var frm = TipoUnidadForm.getInstance();

            frm.Show();
            frm.BringToFront();
            frm.FormClosed += formClosedTipoUnidad;
        }

        private void btnAddEstado_Click(object sender, EventArgs e)
        {
            var frm = EstadoForm.getIntance();

            frm.Show();
            frm.BringToFront();
            frm.FormClosed += formClosed;
        }
        private void formClosedTipoUnidad(object sender, FormClosedEventArgs e)
        {
            sourceUnidades.Reload();

        }
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            sourceEstado.Reload();
        }

    }
}
