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

namespace pointSalesv1.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (existUser(txtUsername.Text.ToUpper(), txtPassword.Text.ToUpper()))
            {
                var dashBoardForm = new DashboardForm();
                var welcomeForm = new SaludoForm();
                this.Hide();
                welcomeForm.ShowDialog();
                dashBoardForm.Show();
                dashBoardForm.FormClosed += logout;
            }
            else
            {
                labelMensage.Visible = true;
                labelMensage.Text = "      Contraseña o usuario incorrectos!!";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "  Usuario")
            {
                txtUsername.Clear();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "  Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        { 
            if (txtPassword.Text == "  Contraseña")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "  Contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        public List<usuarios> getUsers()
        {

            List<usuarios> lstUsers = new List<usuarios>();

            if (sourceUsuarios.Count > 0)
            {
                foreach (usuarios item in sourceUsuarios)
                {
                    lstUsers.Add(new usuarios(sessionWork)
                    {
                        idUsuarios = item.idUsuarios,
                        userName = item.userName,
                        password = item.password,
                        fullName = item.fullName,
                        rol = item.rol,
                        email = item.email,
                      
                    });
                }

            }

            return lstUsers;
        }
      
        public bool existUser(string username, string password)
        {
            bool exist = false;

            getUsers().ToList().ForEach(e => {

                if (username == e.userName && password == e.password)
                {
                    UserActive.idUsuario = e.idUsuarios;
                    UserActive.userName = e.userName;
                    UserActive.password = e.password;
                    UserActive.fullname = e.fullName;
                    UserActive.rol = e.rol;
                    UserActive.email = e.email;
                    exist = true;
                }

            });
            return exist;
        }
        private void logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LoginForm_Load(sender,e);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "  Usuario";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "  Contraseña";
            txtUsername.Focus();
        }
    }
}
