namespace pointSalesv1.Views
{
    partial class VentaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vistaRegistro = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableVentas = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxCajas = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.rjDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.groupBoxOperacionesCajas = new System.Windows.Forms.GroupBox();
            this.txtCambioMoneda = new System.Windows.Forms.NumericUpDown();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.labelCalcular = new System.Windows.Forms.LinkLabel();
            this.txtCobro = new System.Windows.Forms.NumericUpDown();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCobro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtDescuento = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.NumericUpDown();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnListProducto = new System.Windows.Forms.PictureBox();
            this.txtCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.sourceClientes = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vistaVentas = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tableSales = new DevExpress.XtraGrid.GridControl();
            this.sourceVentas = new DevExpress.Xpo.XPCollection(this.components);
            this.viewSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sourceUsuarios = new DevExpress.Xpo.XPCollection(this.components);
            this.sourceProducts = new DevExpress.Xpo.XPCollection(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Compras = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.vistaRegistro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVentas)).BeginInit();
            this.groupBoxCajas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.groupBoxOperacionesCajas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambioMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.vistaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.vistaRegistro);
            this.tabControl1.Controls.Add(this.vistaVentas);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 487);
            this.tabControl1.TabIndex = 129;
            // 
            // vistaRegistro
            // 
            this.vistaRegistro.Controls.Add(this.groupBox2);
            this.vistaRegistro.Controls.Add(this.groupBoxCajas);
            this.vistaRegistro.Location = new System.Drawing.Point(4, 26);
            this.vistaRegistro.Name = "vistaRegistro";
            this.vistaRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.vistaRegistro.Size = new System.Drawing.Size(1104, 457);
            this.vistaRegistro.TabIndex = 0;
            this.vistaRegistro.Text = "Registro";
            this.vistaRegistro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tableVentas);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(5, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1087, 193);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(547, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 158;
            this.label11.Text = "Cliente";
            // 
            // tableVentas
            // 
            this.tableVentas.AllowUserToAddRows = false;
            this.tableVentas.AllowUserToDeleteRows = false;
            this.tableVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableVentas.BackgroundColor = System.Drawing.Color.White;
            this.tableVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVentas.ColumnHeadersVisible = false;
            this.tableVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnProd,
            this.ColumnPrecioVenta,
            this.ColumnCantidad,
            this.cliente});
            this.tableVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableVentas.Location = new System.Drawing.Point(14, 57);
            this.tableVentas.Name = "tableVentas";
            this.tableVentas.ReadOnly = true;
            this.tableVentas.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.tableVentas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableVentas.ShowCellErrors = false;
            this.tableVentas.Size = new System.Drawing.Size(716, 129);
            this.tableVentas.TabIndex = 157;
            this.tableVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableVentas_CellClick);
            this.tableVentas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tableVentas_CellFormatting);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnProd
            // 
            this.ColumnProd.HeaderText = "Producto";
            this.ColumnProd.Name = "ColumnProd";
            this.ColumnProd.ReadOnly = true;
            // 
            // ColumnPrecioVenta
            // 
            this.ColumnPrecioVenta.HeaderText = "PrecioVenta";
            this.ColumnPrecioVenta.Name = "ColumnPrecioVenta";
            this.ColumnPrecioVenta.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(821, 34);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(157, 37);
            this.btnNuevo.TabIndex = 156;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(821, 135);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(159, 35);
            this.btnGuardar.TabIndex = 155;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.DimGray;
            this.label26.Location = new System.Drawing.Point(11, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 17);
            this.label26.TabIndex = 109;
            this.label26.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(106, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(328, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 112;
            this.label10.Text = "Precio V.";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(821, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 37);
            this.btnCancel.TabIndex = 115;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(657, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 109;
            this.label14.Text = "Eliminar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(418, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 109;
            this.label12.Text = "Cantidad";
            // 
            // groupBoxCajas
            // 
            this.groupBoxCajas.Controls.Add(this.txtProducto);
            this.groupBoxCajas.Controls.Add(this.rjDatePicker1);
            this.groupBoxCajas.Controls.Add(this.pictureBox15);
            this.groupBoxCajas.Controls.Add(this.pictureBox13);
            this.groupBoxCajas.Controls.Add(this.groupBoxOperacionesCajas);
            this.groupBoxCajas.Controls.Add(this.label15);
            this.groupBoxCajas.Controls.Add(this.panel2);
            this.groupBoxCajas.Controls.Add(this.txtCantidad);
            this.groupBoxCajas.Controls.Add(this.label13);
            this.groupBoxCajas.Controls.Add(this.pictureBox9);
            this.groupBoxCajas.Controls.Add(this.txtPrecio);
            this.groupBoxCajas.Controls.Add(this.txtDescuento);
            this.groupBoxCajas.Controls.Add(this.txtTotal);
            this.groupBoxCajas.Controls.Add(this.pictureBox7);
            this.groupBoxCajas.Controls.Add(this.btnListProducto);
            this.groupBoxCajas.Controls.Add(this.txtCliente);
            this.groupBoxCajas.Controls.Add(this.label7);
            this.groupBoxCajas.Controls.Add(this.label6);
            this.groupBoxCajas.Controls.Add(this.label5);
            this.groupBoxCajas.Controls.Add(this.label4);
            this.groupBoxCajas.Controls.Add(this.label3);
            this.groupBoxCajas.Controls.Add(this.btnAdd);
            this.groupBoxCajas.Controls.Add(this.pictureBox6);
            this.groupBoxCajas.Controls.Add(this.pictureBox5);
            this.groupBoxCajas.Controls.Add(this.pictureBox4);
            this.groupBoxCajas.Controls.Add(this.pictureBox3);
            this.groupBoxCajas.Controls.Add(this.pictureBox1);
            this.groupBoxCajas.Controls.Add(this.pictureBox2);
            this.groupBoxCajas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCajas.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxCajas.Location = new System.Drawing.Point(5, 0);
            this.groupBoxCajas.Name = "groupBoxCajas";
            this.groupBoxCajas.Size = new System.Drawing.Size(1087, 248);
            this.groupBoxCajas.TabIndex = 7;
            this.groupBoxCajas.TabStop = false;
            this.groupBoxCajas.Text = "Ventas";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducto.ForeColor = System.Drawing.Color.DimGray;
            this.txtProducto.Location = new System.Drawing.Point(387, 45);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(231, 16);
            this.txtProducto.TabIndex = 145;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker1.Location = new System.Drawing.Point(11, 47);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(261, 23);
            this.rjDatePicker1.TabIndex = 144;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(108, 173);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(27, 25);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 143;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(247, 172);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(27, 25);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 142;
            this.pictureBox13.TabStop = false;
            // 
            // groupBoxOperacionesCajas
            // 
            this.groupBoxOperacionesCajas.Controls.Add(this.txtCambioMoneda);
            this.groupBoxOperacionesCajas.Controls.Add(this.pictureBox11);
            this.groupBoxOperacionesCajas.Controls.Add(this.labelCalcular);
            this.groupBoxOperacionesCajas.Controls.Add(this.txtCobro);
            this.groupBoxOperacionesCajas.Controls.Add(this.pictureBox10);
            this.groupBoxOperacionesCajas.Controls.Add(this.cbMoneda);
            this.groupBoxOperacionesCajas.Controls.Add(this.label17);
            this.groupBoxOperacionesCajas.Controls.Add(this.label18);
            this.groupBoxOperacionesCajas.Controls.Add(this.label1);
            this.groupBoxOperacionesCajas.Controls.Add(this.pictureBox8);
            this.groupBoxOperacionesCajas.Enabled = false;
            this.groupBoxOperacionesCajas.Location = new System.Drawing.Point(721, 73);
            this.groupBoxOperacionesCajas.Name = "groupBoxOperacionesCajas";
            this.groupBoxOperacionesCajas.Size = new System.Drawing.Size(309, 121);
            this.groupBoxOperacionesCajas.TabIndex = 140;
            this.groupBoxOperacionesCajas.TabStop = false;
            // 
            // txtCambioMoneda
            // 
            this.txtCambioMoneda.BackColor = System.Drawing.Color.White;
            this.txtCambioMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCambioMoneda.ForeColor = System.Drawing.Color.DimGray;
            this.txtCambioMoneda.Location = new System.Drawing.Point(15, 91);
            this.txtCambioMoneda.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtCambioMoneda.Name = "txtCambioMoneda";
            this.txtCambioMoneda.Size = new System.Drawing.Size(121, 19);
            this.txtCambioMoneda.TabIndex = 132;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(9, 86);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(132, 29);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 131;
            this.pictureBox11.TabStop = false;
            // 
            // labelCalcular
            // 
            this.labelCalcular.AutoSize = true;
            this.labelCalcular.Location = new System.Drawing.Point(227, 63);
            this.labelCalcular.Name = "labelCalcular";
            this.labelCalcular.Size = new System.Drawing.Size(63, 17);
            this.labelCalcular.TabIndex = 130;
            this.labelCalcular.TabStop = true;
            this.labelCalcular.Text = "Calcular";
            this.labelCalcular.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCalcular_LinkClicked);
            // 
            // txtCobro
            // 
            this.txtCobro.BackColor = System.Drawing.Color.White;
            this.txtCobro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCobro.ForeColor = System.Drawing.Color.DimGray;
            this.txtCobro.Location = new System.Drawing.Point(165, 37);
            this.txtCobro.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtCobro.Name = "txtCobro";
            this.txtCobro.Size = new System.Drawing.Size(131, 19);
            this.txtCobro.TabIndex = 129;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(159, 32);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(142, 29);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 128;
            this.pictureBox10.TabStop = false;
            // 
            // cbMoneda
            // 
            this.cbMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMoneda.ForeColor = System.Drawing.Color.DimGray;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Items.AddRange(new object[] {
            "Dolar",
            "Cordobas"});
            this.cbMoneda.Location = new System.Drawing.Point(15, 35);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(121, 25);
            this.cbMoneda.TabIndex = 113;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(223, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 17);
            this.label17.TabIndex = 110;
            this.label17.Text = "Cobro";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(12, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 17);
            this.label18.TabIndex = 110;
            this.label18.Text = "Tipo de Cambio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 110;
            this.label1.Text = "Tipo de Moneda";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(10, 33);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(131, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 115;
            this.pictureBox8.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(109, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 19);
            this.label15.TabIndex = 139;
            this.label15.Text = "%";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.labelCobro);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Location = new System.Drawing.Point(721, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 51);
            this.panel2.TabIndex = 138;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(132, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Operacion de caja";
            // 
            // labelCobro
            // 
            this.labelCobro.AutoSize = true;
            this.labelCobro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCobro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCobro.Location = new System.Drawing.Point(52, 26);
            this.labelCobro.Name = "labelCobro";
            this.labelCobro.Size = new System.Drawing.Size(40, 19);
            this.labelCobro.TabIndex = 3;
            this.labelCobro.Text = "00.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(49, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cambio";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(6, 4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(39, 42);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 1;
            this.pictureBox14.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.txtCantidad.Location = new System.Drawing.Point(155, 112);
            this.txtCantidad.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 19);
            this.txtCantidad.TabIndex = 135;
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(151, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 134;
            this.label13.Text = "Cantidad";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(151, 107);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(126, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 133;
            this.pictureBox9.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.Location = new System.Drawing.Point(9, 176);
            this.txtPrecio.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(95, 19);
            this.txtPrecio.TabIndex = 129;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.White;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescuento.Location = new System.Drawing.Point(10, 111);
            this.txtDescuento.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(94, 19);
            this.txtDescuento.TabIndex = 128;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotal.Location = new System.Drawing.Point(155, 175);
            this.txtTotal.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(86, 19);
            this.txtTotal.TabIndex = 127;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(625, 104);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 126;
            this.pictureBox7.TabStop = false;
            // 
            // btnListProducto
            // 
            this.btnListProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnListProducto.Image")));
            this.btnListProducto.Location = new System.Drawing.Point(625, 41);
            this.btnListProducto.Name = "btnListProducto";
            this.btnListProducto.Size = new System.Drawing.Size(29, 25);
            this.btnListProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnListProducto.TabIndex = 125;
            this.btnListProducto.TabStop = false;
            this.btnListProducto.Click += new System.EventHandler(this.btnListProducto_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.EditValue = "";
            this.txtCliente.Location = new System.Drawing.Point(391, 105);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Properties.Appearance.Options.UseForeColor = true;
            this.txtCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCliente.Properties.DataSource = this.sourceClientes;
            this.txtCliente.Properties.DisplayMember = "nombre";
            this.txtCliente.Properties.PopupView = this.searchLookUpEdit2View;
            this.txtCliente.Properties.ValueMember = "idClientes";
            this.txtCliente.Size = new System.Drawing.Size(225, 22);
            this.txtCliente.TabIndex = 124;
            this.txtCliente.EditValueChanged += new System.EventHandler(this.txtCliente_EditValueChanged);
            // 
            // sourceClientes
            // 
            this.sourceClientes.ObjectType = typeof(pointSalesv1.Models.puntoVenta.clientes);
            this.sourceClientes.Session = this.sessionWork;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.coltelefono,
            this.colemail});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "nombre";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // coltelefono
            // 
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 1;
            // 
            // colemail
            // 
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 122;
            this.label7.Text = "Precio Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 121;
            this.label6.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(379, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 120;
            this.label5.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(380, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 119;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(152, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 118;
            this.label3.Text = "Total";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(727, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(309, 37);
            this.btnAdd.TabIndex = 117;
            this.btnAdd.Text = "Agregar al carrito";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(149, 170);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(127, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 116;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(383, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(273, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 115;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(382, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(273, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 114;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 113;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // vistaVentas
            // 
            this.vistaVentas.Controls.Add(this.btnPrint);
            this.vistaVentas.Controls.Add(this.label25);
            this.vistaVentas.Controls.Add(this.label24);
            this.vistaVentas.Controls.Add(this.label23);
            this.vistaVentas.Controls.Add(this.label22);
            this.vistaVentas.Controls.Add(this.label21);
            this.vistaVentas.Controls.Add(this.label20);
            this.vistaVentas.Controls.Add(this.tableSales);
            this.vistaVentas.Location = new System.Drawing.Point(4, 26);
            this.vistaVentas.Name = "vistaVentas";
            this.vistaVentas.Padding = new System.Windows.Forms.Padding(3);
            this.vistaVentas.Size = new System.Drawing.Size(1104, 457);
            this.vistaVentas.TabIndex = 1;
            this.vistaVentas.Text = "Ventas";
            this.vistaVentas.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(194)))), ((int)(((byte)(132)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Location = new System.Drawing.Point(894, 38);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 33);
            this.btnPrint.TabIndex = 73;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(938, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "Usuario";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Location = new System.Drawing.Point(805, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 16);
            this.label24.TabIndex = 1;
            this.label24.Text = "Estado";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(543, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(405, 94);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "Total";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(135, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Fecha";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(63, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "#";
            // 
            // tableSales
            // 
            this.tableSales.DataSource = this.sourceVentas;
            this.tableSales.Location = new System.Drawing.Point(43, 113);
            this.tableSales.MainView = this.viewSales;
            this.tableSales.Name = "tableSales";
            this.tableSales.Size = new System.Drawing.Size(1021, 301);
            this.tableSales.TabIndex = 0;
            this.tableSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewSales});
            // 
            // sourceVentas
            // 
            this.sourceVentas.ObjectType = typeof(pointSalesv1.Models.puntoVenta.venta);
            this.sourceVentas.Session = this.sessionWork;
            // 
            // viewSales
            // 
            this.viewSales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo,
            this.colfecha,
            this.coltotal,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn9});
            this.viewSales.GridControl = this.tableSales;
            this.viewSales.Name = "viewSales";
            this.viewSales.OptionsView.ShowColumnHeaders = false;
            this.viewSales.OptionsView.ShowDetailButtons = false;
            this.viewSales.OptionsView.ShowGroupPanel = false;
            this.viewSales.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.viewSales.OptionsView.ShowIndicator = false;
            this.viewSales.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.viewSales.RowHeight = 30;
            // 
            // colcodigo
            // 
            this.colcodigo.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcodigo.AppearanceCell.ForeColor = System.Drawing.Color.DimGray;
            this.colcodigo.AppearanceCell.Options.UseFont = true;
            this.colcodigo.AppearanceCell.Options.UseForeColor = true;
            this.colcodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colcodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 70;
            // 
            // colfecha
            // 
            this.colfecha.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colfecha.AppearanceCell.ForeColor = System.Drawing.Color.DimGray;
            this.colfecha.AppearanceCell.Options.UseFont = true;
            this.colfecha.AppearanceCell.Options.UseForeColor = true;
            this.colfecha.AppearanceCell.Options.UseTextOptions = true;
            this.colfecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 100;
            // 
            // coltotal
            // 
            this.coltotal.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltotal.AppearanceCell.ForeColor = System.Drawing.Color.DimGray;
            this.coltotal.AppearanceCell.Options.UseFont = true;
            this.coltotal.AppearanceCell.Options.UseForeColor = true;
            this.coltotal.AppearanceCell.Options.UseTextOptions = true;
            this.coltotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 2;
            this.coltotal.Width = 90;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.ForeColor = System.Drawing.Color.DimGray;
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.FieldName = "id_cliente.nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 248;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.DimGray;
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.FieldName = "id_estado.estado1";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 55;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn9.AppearanceCell.ForeColor = System.Drawing.Color.DimGray;
            this.gridColumn9.AppearanceCell.Options.UseFont = true;
            this.gridColumn9.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.FieldName = "id_usuario.fullName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 458;
            // 
            // sourceUsuarios
            // 
            this.sourceUsuarios.ObjectType = typeof(pointSalesv1.Models.puntoVenta.usuarios);
            this.sourceUsuarios.Session = this.sessionWork;
            // 
            // sourceProducts
            // 
            this.sourceProducts.ObjectType = typeof(pointSalesv1.Models.puntoVenta.productos);
            this.sourceProducts.Session = this.sessionWork;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Compras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 43);
            this.panel1.TabIndex = 128;
            // 
            // Compras
            // 
            this.Compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compras.ForeColor = System.Drawing.Color.DimGray;
            this.Compras.Image = ((System.Drawing.Image)(resources.GetObject("Compras.Image")));
            this.Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Compras.Location = new System.Drawing.Point(517, 9);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(140, 23);
            this.Compras.TabIndex = 0;
            this.Compras.Text = "Ventas";
            this.Compras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 557);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentaForm";
            this.Load += new System.EventHandler(this.VentaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.vistaRegistro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVentas)).EndInit();
            this.groupBoxCajas.ResumeLayout(false);
            this.groupBoxCajas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.groupBoxOperacionesCajas.ResumeLayout(false);
            this.groupBoxOperacionesCajas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambioMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.vistaVentas.ResumeLayout(false);
            this.vistaVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage vistaRegistro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView tableVentas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxCajas;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.GroupBox groupBoxOperacionesCajas;
        private System.Windows.Forms.NumericUpDown txtCambioMoneda;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.LinkLabel labelCalcular;
        private System.Windows.Forms.NumericUpDown txtCobro;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCobro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.NumericUpDown txtDescuento;
        private System.Windows.Forms.NumericUpDown txtTotal;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox btnListProducto;
        private DevExpress.XtraEditors.SearchLookUpEdit txtCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage vistaVentas;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraGrid.GridControl tableSales;
        private DevExpress.XtraGrid.Views.Grid.GridView viewSales;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Compras;
        private DevExpress.Xpo.UnitOfWork sessionWork;
        private DevExpress.Xpo.XPCollection sourceClientes;
        private DevExpress.Xpo.XPCollection sourceProducts;
        private DevExpress.Xpo.XPCollection sourceVentas;
        private DevExpress.Xpo.XPCollection sourceUsuarios;
        private System.Windows.Forms.DateTimePicker rjDatePicker1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
    }
}