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
using pointSalesv1.Messages;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.ObjValues;
using pointSalesv1.Cache;

namespace pointSalesv1.Views
{
    public partial class RegistroClientes : Form,IClientesRepository
    {
        clientes objClientes;
        public bool update = false;
        private clientes clienteSelected;
       public RegistroClientes(DevExpress.Xpo.UnitOfWork session,clientes client)
        {
            InitializeComponent();
            this.sessionWork = session;
            this.clienteSelected = client;
        }
        public RegistroClientes()
        {
            InitializeComponent();
            boxGenero();
        }
        private void boxGenero()
        {
            cbSexo.Items.Add("M");
            cbSexo.Items.Add("F");
        }
        private async void btnGurdar_Click(object sender, EventArgs e)
        {
            objClientes = update ? clienteSelected as clientes : new clientes(sessionWork);
            try
            {
                var sexo = returnGenero(cbSexo.SelectedIndex);
                if (sexo == null)
                {
                    // Manejar el caso en que el género no sea válido
                    throw new ArgumentException("Género no válido seleccionado.");

                }

                objClientes.dni = string.IsNullOrWhiteSpace(txtDni.Text) ? throw new ArgumentException("DNI no puede estar vacío.") : txtDni.Text.Trim().ToUpper();
                objClientes.nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? throw new ArgumentException("Nombre no puede estar vacío.") : txtNombre.Text.Trim().ToUpper();
                objClientes.telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? throw new ArgumentException("Teléfono no puede estar vacío.") : txtTelefono.Text.Trim().ToUpper();
                objClientes.direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? throw new ArgumentException("Dirección no puede estar vacía.") : txtDireccion.Text.Trim().ToUpper();
                objClientes.sexo = Convert.ToChar(sexo);
                if (!update)
                {
                    var result = await validar(objClientes);
                    if (result == false)
                    {
                        objClientes.Session.Reload(objClientes);
                        return;
                    }
                }
                if (update)
                {
                    sessionWork.Save(objClientes);
                    sessionWork.CommitChanges();
                    update = false;
                    this.Close();
                    return;
                }
                sessionWork.Save(objClientes);
                sessionWork.CommitChanges();
                NotifyForm.showMessageForm("Datos guardados correctamente!!");
                UI.clearCajas(this.Controls);
            }
            catch (ArgumentException ex)
            {

                ErrorForm.showMessageForm(ex.Message);
            }

        }
        private void clearCombos()
        {
            cbSexo.Text = "";
        }
        
        Func<int, string> returnGenero = (int index) =>
         {
             return index == 0 ? "M" : "F";
         };
        public bool existClient(string dni)
        {
            bool exist = false;
            foreach (clientes item in sourceClientes)
            {
                if (dni == item.dni)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        private async Task<bool> validar<T>(T obj) where T : clientes
        {
            var valid = new ValidationModelsClientes();

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
