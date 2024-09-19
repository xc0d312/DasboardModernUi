using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Messages;
using pointSalesv1.Cache;
using pointSalesv1.Views;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Services;

namespace pointSalesv1.Views
{
    public partial class DashboardForm : Form
    {
        private readonly ProductoService realTimeNotification = new ProductoService();
        private Timer stockCheckTimer;
        List<Mensaje> stockAlertHistory = new List<Mensaje>();
        public DashboardForm()
        {
            InitializeComponent();
            UI.rigthBorderPanel = new Panel();
            UI.rigthBorderPanel.Size = new Size(7, 52);
            UI.locationX = 230;
            panelLeft.Controls.Add(UI.rigthBorderPanel);
            this.btnClose.Click += btnClose_Click;
            this.Load += load_Configs;
            this.btnLogout.Click += btnLogout_Click;
            this.btnCompras.Click += btnCompras_Click;
            this.btnVentas.Click += btnVentas_Click;
            this.btnProductos.Click += btnProducts_Click;
            this.btnClientes.Click += btnClientes_Click;
            this.btnProveedores.Click += btnProveedores_Click;
            this.btnReportes.Click += btnReportes_Click;
            this.btnUsers.Click += btnUsers_Click;
            this.btnSettings.Click += btnSettings_Click;
            this.btnNewCliente.Click += btnNewCliente_Click;

            realTimeNotification.lowStockNotification += handleLowStockNotification;
            // Configurar y comenzar el temporizador
            stockCheckTimer = new Timer();
            stockCheckTimer.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
            stockCheckTimer.Tick += StockCheckTimer_Tick;
            stockCheckTimer.Start();
            customizeDesing();
            
            //
            DisplayOk();

        }

     
        private void StockCheckTimer_Tick(object sender, EventArgs e)
        {
            // Se ejecutará cada vez que el temporizador alcance su intervalo
            verifyStockProduct();
        }
        private void handleLowStockNotification(productos product, int currentStock)
        {
            // Lógica para mostrar la notificación en tu aplicación
            if(stockCheckTimer.Enabled == true)
            {
                stockCheckTimer.Stop();
            }

            stockAlertHistory.Add(new Mensaje()
            {
                Fecha = DateTime.Now,
                Contenido = $"Bajo stock de {product.nombre}, actual stock {currentStock}"

            });
        }
        private async void verifyStockProduct()
        {
            await Task.Run(() =>
            {
                List<productos> productosList = getProducts();

                foreach (productos producto in productosList)
                {
                    // Supongamos que el umbral para considerar bajo stock es 10
                    if (producto.stock < 10)
                    {
                        // Si el stock es bajo, notificar
                        realTimeNotification.notifyLowStock(producto, producto.stock);
                    }
                }
            });
        }
        private List<productos> getProducts()
        {
            return sourceProducts.OfType<productos>()
                .Select(product => createProductCopy(product))
                .ToList();
        }
       
        private productos createProductCopy(productos p)
        {
            return new productos(sessionWork)
            {
                idProductos = p.idProductos,
                codigo = p.codigo,
                nombre = p.nombre,
                costo = p.costo,
                stock = p.stock,
                precio = p.precio,
            };
        }

    
        private void btnSettings_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color1);
            openFormChildren(new ConfiguracionForm());
            hideSubmenu();
        }
        private void btnNotify_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color2);
            openFormChildren(new InboxForm(stockAlertHistory));
            hideSubmenu();        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color2);
            openFormChildren(new UsuariosForm());
            hideSubmenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color3);
            hideSubmenu();
            showSubMenu(this.subMenuReportes);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color4);
            openFormChildren(new ProveedorForm());
            hideSubmenu();
            showSubMenu(this.subMenuProveedor);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color5);
            openFormChildren(new ClientesForm());
            hideSubmenu();
            showSubMenu(this.subMenuClientes);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color6);
            openFormChildren(new ProductHijoForm());
            hideSubmenu();
            showSubMenu(this.submenuInventario);

        }
        private void permissionUsers()
        {
            if (UserActive.rol == Position.vendedor.ToUpper())
            {

                btnReportes.Enabled = false;
                btnCompras.Enabled = false;
                btnClientes.Enabled = false;
                btnProveedores.Enabled = false;
                btnUsers.Enabled = false;
                btnSettings.Enabled = false;
            }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color1);
            openFormChildren(new VentaForm());
            hideSubmenu();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            UI.activeButton(sender, UI.RGBcolors.color1);
            openFormChildren(new CompraForm());
            hideSubmenu();
        }

        private void DisplayOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            this.Close();
        
        }

        private void load_Configs(object sender, EventArgs e)
        {
            permissionUsers();
            openFormChildren(new ChartsForm());
            hideSubmenu();
            loadInformationUser();
            
        }
        private void loadInformationUser()
        {
            labelPosition.Text = UserActive.rol;
            labelUser.Text = UserActive.userName;
            labelEmail.Text = UserActive.email;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openFormChildren(object form)
        {
            if (sourceProductos.Controls.Count > 0) { sourceProductos.Controls.RemoveAt(0); }

            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            fh.FormBorderStyle = FormBorderStyle.None;
            this.sourceProductos.Controls.Add(fh);
            fh.BringToFront();
            fh.Show();
        }
        private void profileInformation_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFormChildren(new PerfileActiveForm());
        }

        private void customizeDesing()
        {
            subMenuReportes.Visible = false;
            submenuInventario.Visible = false;
            subMenuClientes.Visible = false;
            subMenuProveedor.Visible = false;

        }
        private void hideSubmenu()
        {
            if (submenuInventario.Visible == true)
                submenuInventario.Visible = false;
            if (subMenuClientes.Visible == true)
            {
                subMenuClientes.Visible = false;
            }
            if (subMenuProveedor.Visible == true)
            {
                subMenuProveedor.Visible = false;
            }
            if (subMenuReportes.Visible == true)
            {
                subMenuReportes.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
        }

        //Botones Formularios
        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            var frm = new RegistroClientes();
            frm.ShowDialog();
        }

        private void btnReporteEntrada_Click(object sender, EventArgs e)
        {
            var frm = new ReporteEntrada();
            frm.ShowDialog();

        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            var frm = new ReporteVentas();
            frm.ShowDialog();
        }

        private void btnReporteGanancias_Click(object sender, EventArgs e)
        {
            var frm = new ReporteGanancias();
            frm.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            var frm = new MarcasForm();
            frm.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var frm = new CategoriasForm();
            frm.ShowDialog();

        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            var frm = new ProductosForm();
            frm.ShowDialog();
        }

        private void btnRegistroProveedor_Click(object sender, EventArgs e)
        {
            var frm = new RegistroProveedores();
            frm.ShowDialog();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            openFormChildren(new ChartsForm());
        }
    }
}
