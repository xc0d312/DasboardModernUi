
namespace pointSalesv1.Views
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.subMenuProveedor = new System.Windows.Forms.Panel();
            this.btnRegistroProveedor = new System.Windows.Forms.Button();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.subMenuClientes = new System.Windows.Forms.Panel();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.submenuInventario = new System.Windows.Forms.Panel();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.subMenuReportes = new System.Windows.Forms.Panel();
            this.btnReporteGanancias = new System.Windows.Forms.Button();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            this.btnReporteEntrada = new System.Windows.Forms.Button();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCharts = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.profileInformation = new System.Windows.Forms.LinkLabel();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imagePerfil = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnBell = new FontAwesome.Sharp.IconButton();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.sourceProductos = new System.Windows.Forms.Panel();
            this.sessionWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.sourceProducts = new DevExpress.Xpo.XPCollection(this.components);
            this.panelLeft.SuspendLayout();
            this.subMenuProveedor.SuspendLayout();
            this.subMenuClientes.SuspendLayout();
            this.submenuInventario.SuspendLayout();
            this.subMenuReportes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCharts)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnUsers);
            this.panelLeft.Controls.Add(this.btnCompras);
            this.panelLeft.Controls.Add(this.subMenuProveedor);
            this.panelLeft.Controls.Add(this.btnProveedores);
            this.panelLeft.Controls.Add(this.subMenuClientes);
            this.panelLeft.Controls.Add(this.btnClientes);
            this.panelLeft.Controls.Add(this.btnVentas);
            this.panelLeft.Controls.Add(this.submenuInventario);
            this.panelLeft.Controls.Add(this.btnProductos);
            this.panelLeft.Controls.Add(this.subMenuReportes);
            this.panelLeft.Controls.Add(this.btnReportes);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(235, 749);
            this.panelLeft.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 25;
            this.btnSettings.Location = new System.Drawing.Point(0, 748);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(218, 40);
            this.btnSettings.TabIndex = 49;
            this.btnSettings.Text = "Configuracion";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            this.btnUsers.IconColor = System.Drawing.Color.White;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 25;
            this.btnUsers.Location = new System.Drawing.Point(0, 708);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(218, 40);
            this.btnUsers.TabIndex = 55;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 25;
            this.btnCompras.Location = new System.Drawing.Point(0, 668);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(218, 40);
            this.btnCompras.TabIndex = 54;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // subMenuProveedor
            // 
            this.subMenuProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.subMenuProveedor.Controls.Add(this.btnRegistroProveedor);
            this.subMenuProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProveedor.Location = new System.Drawing.Point(0, 621);
            this.subMenuProveedor.Name = "subMenuProveedor";
            this.subMenuProveedor.Size = new System.Drawing.Size(218, 47);
            this.subMenuProveedor.TabIndex = 3;
            // 
            // btnRegistroProveedor
            // 
            this.btnRegistroProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroProveedor.FlatAppearance.BorderSize = 0;
            this.btnRegistroProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroProveedor.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegistroProveedor.Location = new System.Drawing.Point(0, 0);
            this.btnRegistroProveedor.Name = "btnRegistroProveedor";
            this.btnRegistroProveedor.Size = new System.Drawing.Size(218, 40);
            this.btnRegistroProveedor.TabIndex = 0;
            this.btnRegistroProveedor.Text = "Registro Proveedor";
            this.btnRegistroProveedor.UseVisualStyleBackColor = true;
            this.btnRegistroProveedor.Click += new System.EventHandler(this.btnRegistroProveedor_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 25;
            this.btnProveedores.Location = new System.Drawing.Point(0, 581);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(218, 40);
            this.btnProveedores.TabIndex = 53;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // subMenuClientes
            // 
            this.subMenuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.subMenuClientes.Controls.Add(this.btnNewCliente);
            this.subMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuClientes.Location = new System.Drawing.Point(0, 526);
            this.subMenuClientes.Name = "subMenuClientes";
            this.subMenuClientes.Size = new System.Drawing.Size(218, 55);
            this.subMenuClientes.TabIndex = 28;
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnNewCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewCliente.FlatAppearance.BorderSize = 0;
            this.btnNewCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCliente.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCliente.Location = new System.Drawing.Point(0, 0);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNewCliente.Size = new System.Drawing.Size(218, 40);
            this.btnNewCliente.TabIndex = 27;
            this.btnNewCliente.Text = "Registro Cliente";
            this.btnNewCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCliente.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 25;
            this.btnClientes.Location = new System.Drawing.Point(0, 486);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(218, 40);
            this.btnClientes.TabIndex = 52;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 25;
            this.btnVentas.Location = new System.Drawing.Point(0, 446);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(218, 40);
            this.btnVentas.TabIndex = 51;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // submenuInventario
            // 
            this.submenuInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.submenuInventario.Controls.Add(this.btnMarcas);
            this.submenuInventario.Controls.Add(this.btnCategorias);
            this.submenuInventario.Controls.Add(this.btnArticulo);
            this.submenuInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuInventario.Location = new System.Drawing.Point(0, 320);
            this.submenuInventario.Name = "submenuInventario";
            this.submenuInventario.Size = new System.Drawing.Size(218, 126);
            this.submenuInventario.TabIndex = 28;
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.DimGray;
            this.btnMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.Location = new System.Drawing.Point(0, 80);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(218, 40);
            this.btnMarcas.TabIndex = 28;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 40);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(218, 40);
            this.btnCategorias.TabIndex = 27;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnArticulo
            // 
            this.btnArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArticulo.FlatAppearance.BorderSize = 0;
            this.btnArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo.ForeColor = System.Drawing.Color.DimGray;
            this.btnArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulo.Location = new System.Drawing.Point(0, 0);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnArticulo.Size = new System.Drawing.Size(218, 40);
            this.btnArticulo.TabIndex = 26;
            this.btnArticulo.Text = "Productos";
            this.btnArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulo.UseVisualStyleBackColor = false;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnProductos.IconColor = System.Drawing.Color.White;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 25;
            this.btnProductos.Location = new System.Drawing.Point(0, 280);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(218, 40);
            this.btnProductos.TabIndex = 29;
            this.btnProductos.Text = "Inventario";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // subMenuReportes
            // 
            this.subMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.subMenuReportes.Controls.Add(this.btnReporteGanancias);
            this.subMenuReportes.Controls.Add(this.btnReporteVentas);
            this.subMenuReportes.Controls.Add(this.btnReporteEntrada);
            this.subMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuReportes.Location = new System.Drawing.Point(0, 152);
            this.subMenuReportes.Name = "subMenuReportes";
            this.subMenuReportes.Size = new System.Drawing.Size(218, 128);
            this.subMenuReportes.TabIndex = 38;
            // 
            // btnReporteGanancias
            // 
            this.btnReporteGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnReporteGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteGanancias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteGanancias.FlatAppearance.BorderSize = 0;
            this.btnReporteGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGanancias.ForeColor = System.Drawing.Color.DimGray;
            this.btnReporteGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteGanancias.Location = new System.Drawing.Point(0, 80);
            this.btnReporteGanancias.Name = "btnReporteGanancias";
            this.btnReporteGanancias.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnReporteGanancias.Size = new System.Drawing.Size(218, 40);
            this.btnReporteGanancias.TabIndex = 29;
            this.btnReporteGanancias.Text = "Ganancia por ventas";
            this.btnReporteGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteGanancias.UseVisualStyleBackColor = false;
            this.btnReporteGanancias.Click += new System.EventHandler(this.btnReporteGanancias_Click);
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnReporteVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteVentas.FlatAppearance.BorderSize = 0;
            this.btnReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentas.ForeColor = System.Drawing.Color.DimGray;
            this.btnReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.Location = new System.Drawing.Point(0, 40);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnReporteVentas.Size = new System.Drawing.Size(218, 40);
            this.btnReporteVentas.TabIndex = 28;
            this.btnReporteVentas.Text = "Reporte Ventas";
            this.btnReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.UseVisualStyleBackColor = false;
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // btnReporteEntrada
            // 
            this.btnReporteEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnReporteEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteEntrada.FlatAppearance.BorderSize = 0;
            this.btnReporteEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.btnReporteEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteEntrada.Location = new System.Drawing.Point(0, 0);
            this.btnReporteEntrada.Name = "btnReporteEntrada";
            this.btnReporteEntrada.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnReporteEntrada.Size = new System.Drawing.Size(218, 40);
            this.btnReporteEntrada.TabIndex = 27;
            this.btnReporteEntrada.Text = "Reporte Entrada";
            this.btnReporteEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteEntrada.UseVisualStyleBackColor = false;
            this.btnReporteEntrada.Click += new System.EventHandler(this.btnReporteEntrada_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 25;
            this.btnReportes.Location = new System.Drawing.Point(0, 112);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(218, 40);
            this.btnReportes.TabIndex = 28;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCharts);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 112);
            this.panel1.TabIndex = 13;
            // 
            // btnCharts
            // 
            this.btnCharts.BackColor = System.Drawing.Color.Transparent;
            this.btnCharts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCharts.Image = ((System.Drawing.Image)(resources.GetObject("btnCharts.Image")));
            this.btnCharts.Location = new System.Drawing.Point(60, 11);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(123, 46);
            this.btnCharts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCharts.TabIndex = 12;
            this.btnCharts.TabStop = false;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.DimGray;
            this.labelEmail.Location = new System.Drawing.Point(199, 18);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(12, 94);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(51, 15);
            this.labelPosition.TabIndex = 13;
            this.labelPosition.Text = "Position";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 788);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(218, 40);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Cerrar Session";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // profileInformation
            // 
            this.profileInformation.AutoSize = true;
            this.profileInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileInformation.ForeColor = System.Drawing.Color.DimGray;
            this.profileInformation.LinkColor = System.Drawing.Color.DimGray;
            this.profileInformation.Location = new System.Drawing.Point(6, 12);
            this.profileInformation.Name = "profileInformation";
            this.profileInformation.Size = new System.Drawing.Size(69, 18);
            this.profileInformation.TabIndex = 11;
            this.profileInformation.TabStop = true;
            this.profileInformation.Text = "Tu perfil";
            this.profileInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.profileInformation_LinkClicked_1);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.DimGray;
            this.labelUser.Location = new System.Drawing.Point(947, 15);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(88, 16);
            this.labelUser.TabIndex = 14;
            this.labelUser.Text = "Iniciar Sesión";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.labelEmail);
            this.panelTop.Controls.Add(this.labelUser);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.profileInformation);
            this.panelTop.Controls.Add(this.imagePerfil);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnBell);
            this.panelTop.Controls.Add(this.shapeContainer2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(235, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1129, 40);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(80)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(88, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "DashBoard";
            // 
            // imagePerfil
            // 
            this.imagePerfil.BackColor = System.Drawing.Color.White;
            this.imagePerfil.ForeColor = System.Drawing.Color.DimGray;
            this.imagePerfil.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.imagePerfil.IconColor = System.Drawing.Color.DimGray;
            this.imagePerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imagePerfil.IconSize = 35;
            this.imagePerfil.Location = new System.Drawing.Point(903, 4);
            this.imagePerfil.Name = "imagePerfil";
            this.imagePerfil.Size = new System.Drawing.Size(38, 35);
            this.imagePerfil.TabIndex = 5;
            this.imagePerfil.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.Color.DimGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(1094, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnBell
            // 
            this.btnBell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBell.FlatAppearance.BorderSize = 0;
            this.btnBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBell.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnBell.IconColor = System.Drawing.Color.DimGray;
            this.btnBell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBell.IconSize = 30;
            this.btnBell.Location = new System.Drawing.Point(1054, 6);
            this.btnBell.Name = "btnBell";
            this.btnBell.Size = new System.Drawing.Size(30, 30);
            this.btnBell.TabIndex = 3;
            this.btnBell.UseVisualStyleBackColor = true;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(1129, 40);
            this.shapeContainer2.TabIndex = 12;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 1045;
            this.lineShape3.X2 = 1045;
            this.lineShape3.Y1 = 1;
            this.lineShape3.Y2 = 42;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 1088;
            this.lineShape2.X2 = 1088;
            this.lineShape2.Y1 = 2;
            this.lineShape2.Y2 = 42;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 72;
            this.lineShape1.X2 = 82;
            this.lineShape1.Y1 = 32;
            this.lineShape1.Y2 = 11;
            // 
            // sourceProductos
            // 
            this.sourceProductos.BackColor = System.Drawing.SystemColors.Control;
            this.sourceProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceProductos.ForeColor = System.Drawing.Color.DimGray;
            this.sourceProductos.Location = new System.Drawing.Point(235, 40);
            this.sourceProductos.Name = "sourceProductos";
            this.sourceProductos.Size = new System.Drawing.Size(1129, 709);
            this.sourceProductos.TabIndex = 2;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "58c2c2a1-d61d-40ab-b97d-9bcea8177c8f";
            // 
            // sourceProducts
            // 
            this.sourceProducts.ObjectType = typeof(pointSalesv1.Models.puntoVenta.productos);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.sourceProductos);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.panelLeft.ResumeLayout(false);
            this.subMenuProveedor.ResumeLayout(false);
            this.subMenuClientes.ResumeLayout(false);
            this.submenuInventario.ResumeLayout(false);
            this.subMenuReportes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCharts)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        public System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox btnCharts;
        public System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.LinkLabel profileInformation;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel sourceProductos;
        private DevExpress.Xpo.UnitOfWork sessionWork;
        private DevExpress.Xpo.XPCollection sourceProducts;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnBell;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconPictureBox imagePerfil;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnNewCliente;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnCompras;
        private System.Windows.Forms.Panel subMenuProveedor;
        private System.Windows.Forms.Button btnRegistroProveedor;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private System.Windows.Forms.Panel subMenuClientes;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnVentas;
        private System.Windows.Forms.Panel submenuInventario;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Panel subMenuReportes;
        private System.Windows.Forms.Button btnReporteEntrada;
        private System.Windows.Forms.Button btnReporteVentas;
        private System.Windows.Forms.Button btnReporteGanancias;
    }
}