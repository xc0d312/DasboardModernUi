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
using pointSalesv1.Cache;
using pointSalesv1.Messages;
using pointSalesv1.ObjValues;
using DevExpress.Xpo;
using DevExpress.Data;
using pointSalesv1.Contracts;

namespace pointSalesv1.Views
{
    public partial class RegistroProveedores : Form, IProveedoresRepository
    {
        public bool update = false;
        proveedores objProv;
        private proveedores proveedorSelected;
        public RegistroProveedores(UnitOfWork session, proveedores proveedor)
        {
            InitializeComponent();
            this.sessionWork = session;
            this.proveedorSelected = proveedor;
        }
        public RegistroProveedores()
        {
            InitializeComponent();

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            objProv = update ? proveedorSelected as proveedores: new proveedores(sessionWork);
            objProv.empresa = txtProveédor.Text.ToUpper();
            objProv.razon = txtRazon.Text.ToUpper();
            objProv.direccion = txtDireccion.Text.ToUpper();
            objProv.telefono = txtTelefono.Text;
            if (!update)
            {
                var result = await validar(objProv);
                if (result == false)
                {
                    objProv.Session.Reload(objProv);
                    return;
                }
            }
            if (update)
            {
                sessionWork.Save(objProv);
                sessionWork.CommitChanges();
                update = false;
                NotifyForm.showMessageForm("Datos guardados correctamente!!");
                this.Close();
                return;
            }
            //en el caso de que no sea un nuevo proveedor
            sessionWork.Save(objProv);
            sessionWork.CommitChanges();
            NotifyForm.showMessageForm("Datos guardados correctamente!!");
            UI.clearCajas(this.Controls);
        }
        public bool existProveedores(string name)
        {
            bool exist = false;
            foreach (proveedores item in sourceProveedores)
            {
                if (name == item.empresa)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        private async Task<bool> validar<T>(T obj) where T : proveedores
        {
            var valid = new ValidationModelsProveedores();

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

        private void btnClosse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
