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
using pointSalesv1.Messages;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Models;

namespace pointSalesv1.Views
{
    public partial class PerfileActiveForm : Form
    {
        
        LoginForm objLogin;
        public PerfileActiveForm()
        {
            InitializeComponent();
            this.Load += load_Configs;
            this.panelRigth.Visible = false;
            this.btnClose.Click += btnClose_Click;
        
        }
        private void loadPermissionUser()
        {
            if (UserActive.rol == Position.vendedor)
            {
                txtCargo.Enabled = false;
            }
        }
        private void load_Configs(object sender, EventArgs e)
        {
            loadProfileUser();
            initializePasEditControls();
            loadPermissionUser();

        }
        private void loadProfileUser()
        {
            //view
            labelUsername.Text = UserActive.userName;
            labelfullName.Text = UserActive.fullname;
            labelEmail.Text = UserActive.email;
            labelPosition.Text = UserActive.rol;
            //Edit
            txtUser.Text = UserActive.userName;
            txtFullname.Text = UserActive.fullname;
            txtPassword.Text = UserActive.password;
            txtConfirmPassword.Text = UserActive.password;
            txtCargo.Text = UserActive.rol;
            txtEmail.Text = UserActive.email;
        }
        private void initializePasEditControls()
        {
            labelEditarPassword.Text = "Edit";
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
        }
        private void reset()
        {
            loadProfileUser();
            initializePasEditControls();
            UI.clearCajas(this.panelRigth.Controls);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEditarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (labelEditarPassword.Text == "Edit")
            {
                labelEditarPassword.Text = "Cancel";
                txtPassword.Enabled = true;
                txtPassword.Text = "";
                txtConfirmPassword.Enabled = true;
                txtConfirmPassword.Text = "";
            }
            else if (labelEditarPassword.Text == "Cancel")
            {
                reset();
            }
        }
        private void loadDashBoardDataUser()
        {
            var obj = new DashboardForm();
            obj.labelUser.Text = UserActive.fullname;
            obj.labelEmail.Text = UserActive.email;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToUpper() == txtConfirmPassword.Text.ToUpper())
            {
                if (txtCurrentPassword.Text.ToUpper() == UserActive.password)
                {
                    var userModel = new UsersModels(
                        id: UserActive.idUsuario,
                        userName: txtUser.Text.ToUpper(),
                        password: txtPassword.Text.ToUpper(),
                        fullName: txtFullname.Text.ToUpper(),
                        rol: txtCargo.Text.ToUpper(),
                        email: txtEmail.Text.ToUpper());
                    userModel.editProfile();
                    objLogin = new LoginForm();
                    objLogin.existUser(txtUser.Text.ToUpper(), txtCurrentPassword.Text.ToUpper());
                    loadDashBoardDataUser();
                    NotifyForm.showMessageForm("Perfil Actualizado");
                    reset();
                    panelRigth.Visible = false;
                }
                else
                {
                    ErrorForm.showMessageForm("Contraseña actual incorrecta");
                }
            }
            else
            {
                ErrorForm.showMessageForm("Las contraseñas no coinciden");
            }
        }

        private void profileInformation_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panelRigth.Visible = true;
            loadProfileUser();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            UI.clearCajas(this.panelRigth.Controls);
            this.panelRigth.Visible = false;
        }

        private void labelEditarPassword_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (labelEditarPassword.Text == "Edit")
            {
                labelEditarPassword.Text = "Cancel";
                txtPassword.Enabled = true;
                txtPassword.Text = "";
                txtConfirmPassword.Enabled = true;
                txtConfirmPassword.Text = "";
            }
            else if (labelEditarPassword.Text == "Cancel")
            {
                reset();
            }
        }
    }
}
