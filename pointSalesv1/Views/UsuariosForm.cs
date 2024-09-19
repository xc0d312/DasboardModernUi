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
using pointSalesv1.Messages;
using pointSalesv1.ObjValues;

namespace pointSalesv1.Views
{
    public partial class UsuariosForm : Form
    {
        usuarios objUsuario;
        bool update = false;
        public UsuariosForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (update)
            {
                objUsuario = viewUsers.GetFocusedRow() as usuarios;
            }
            else
            {
                objUsuario = new usuarios(sessionWork);

            }
            objUsuario.userName = txtUser.Text.ToUpper();
            objUsuario.fullName = txtFullname.Text.ToUpper();
            objUsuario.email = txtEmail.Text.ToLower();
            objUsuario.password = txtPassword.Text.ToUpper();
            objUsuario.rol = txtCargo.Text.ToUpper();
            if (!validar(objUsuario))
            {
                objUsuario.Session.Reload(objUsuario);
                return;
            }
            sessionWork.Save(objUsuario);
            sessionWork.CommitChanges();
            viewUsersReload();
            NotifyForm.showMessageForm("Usuario registrado exitosamente");
            UI.clearCajas(this.Controls);
        }
        private void viewUsersReload()
        {
            sourceUsuarios.Reload();
        }
        private bool validar<T>(T obj) where T : usuarios
        {
            var models = new ValidationModelsUsers();
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

        private void viewUsers_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            switch (viewUsers.Columns[e.Column.VisibleIndex].Name)
            {
                case "colEdit":
                    usuarios row = viewUsers.GetRow(viewUsers.GetSelectedRows()[0]) as usuarios;
                    txtUser.Text = row.userName;
                    txtFullname.Text = row.fullName;
                    txtCargo.Text = row.rol;
                    txtEmail.Text = row.email.ToUpper();

                    txtPassword.Text = row.password;

                    update = true;
                    break;
                case "colDelete":
                    DangerForm objForm = new DangerForm("Esta seguro que " +
               " desea eliminar esta usuario");
                    if (objForm.ShowDialog() == DialogResult.OK)
                    {
                        objUsuario = viewUsers.GetFocusedRow() as usuarios;
                        sessionWork.Delete(objUsuario);
                        sessionWork.CommitChanges();
                        NotifyForm.showMessageForm("Cuenta eliminada!!");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
