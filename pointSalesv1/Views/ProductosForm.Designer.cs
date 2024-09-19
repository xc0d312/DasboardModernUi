namespace pointSalesv1.Views
{
    partial class ProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClosse = new System.Windows.Forms.PictureBox();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.sourceUnidades = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMarcas = new DevExpress.XtraEditors.LookUpEdit();
            this.sourceMarcas = new DevExpress.Xpo.XPCollection(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.sourceEstado = new DevExpress.Xpo.XPCollection(this.components);
            this.cbCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.sourceCategoria = new DevExpress.Xpo.XPCollection(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddUnidad = new System.Windows.Forms.PictureBox();
            this.btnAddEstado = new System.Windows.Forms.PictureBox();
            this.sourceProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMarcas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnClosse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 34);
            this.panel1.TabIndex = 125;
            // 
            // btnClosse
            // 
            this.btnClosse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosse.Image = ((System.Drawing.Image)(resources.GetObject("btnClosse.Image")));
            this.btnClosse.Location = new System.Drawing.Point(434, 0);
            this.btnClosse.Name = "btnClosse";
            this.btnClosse.Size = new System.Drawing.Size(31, 33);
            this.btnClosse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClosse.TabIndex = 143;
            this.btnClosse.TabStop = false;
            this.btnClosse.Click += new System.EventHandler(this.btnClosse_Click);
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.DimGray;
            this.txtStock.Location = new System.Drawing.Point(19, 329);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(94, 19);
            this.txtStock.TabIndex = 170;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.Location = new System.Drawing.Point(19, 268);
            this.txtPrecio.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(94, 19);
            this.txtPrecio.TabIndex = 169;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 324);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 168;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(22, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 167;
            this.label4.Text = "Stock";
            // 
            // cbTipoUnidad
            // 
            this.cbTipoUnidad.Location = new System.Drawing.Point(268, 266);
            this.cbTipoUnidad.Name = "cbTipoUnidad";
            this.cbTipoUnidad.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUnidad.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.cbTipoUnidad.Properties.Appearance.Options.UseFont = true;
            this.cbTipoUnidad.Properties.Appearance.Options.UseForeColor = true;
            this.cbTipoUnidad.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoUnidad.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.cbTipoUnidad.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.cbTipoUnidad.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUnidad.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.DimGray;
            this.cbTipoUnidad.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cbTipoUnidad.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbTipoUnidad.Properties.AppearanceDropDown.Options.UseBorderColor = true;
            this.cbTipoUnidad.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbTipoUnidad.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbTipoUnidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbTipoUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipoUnidad", "Unidad")});
            this.cbTipoUnidad.Properties.DataSource = this.sourceUnidades;
            this.cbTipoUnidad.Properties.DisplayMember = "tipoUnidad";
            this.cbTipoUnidad.Properties.NullText = "";
            this.cbTipoUnidad.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.cbTipoUnidad.Properties.ValueMember = "idtipoUnidad";
            this.cbTipoUnidad.Size = new System.Drawing.Size(152, 22);
            this.cbTipoUnidad.TabIndex = 166;
            // 
            // sourceUnidades
            // 
            this.sourceUnidades.ObjectType = typeof(pointSalesv1.Models.puntoVenta.tipounidad);
            this.sourceUnidades.Session = this.sessionWork;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(264, 263);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(189, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 165;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(274, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 164;
            this.label7.Text = "Tipo de unidad";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 263);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(108, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 163;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(22, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 162;
            this.label6.Text = "Precio Venta";
            // 
            // cbMarcas
            // 
            this.cbMarcas.Location = new System.Drawing.Point(268, 199);
            this.cbMarcas.Name = "cbMarcas";
            this.cbMarcas.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcas.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.cbMarcas.Properties.Appearance.Options.UseFont = true;
            this.cbMarcas.Properties.Appearance.Options.UseForeColor = true;
            this.cbMarcas.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.Transparent;
            this.cbMarcas.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.cbMarcas.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.cbMarcas.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcas.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.DimGray;
            this.cbMarcas.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cbMarcas.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbMarcas.Properties.AppearanceDropDown.Options.UseBorderColor = true;
            this.cbMarcas.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbMarcas.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbMarcas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbMarcas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMarcas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("marcas1", "marcas1", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMarcas.Properties.DataSource = this.sourceMarcas;
            this.cbMarcas.Properties.DisplayMember = "marcas1";
            this.cbMarcas.Properties.NullText = "";
            this.cbMarcas.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.cbMarcas.Properties.ValueMember = "idMarcas";
            this.cbMarcas.Size = new System.Drawing.Size(182, 22);
            this.cbMarcas.TabIndex = 161;
            // 
            // sourceMarcas
            // 
            this.sourceMarcas.ObjectType = typeof(pointSalesv1.Models.puntoVenta.marcas);
            this.sourceMarcas.Session = this.sessionWork;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(264, 196);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(189, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 160;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(274, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 159;
            this.label3.Text = "Marcas";
            // 
            // cbEstado
            // 
            this.cbEstado.Location = new System.Drawing.Point(267, 134);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.cbEstado.Properties.Appearance.Options.UseFont = true;
            this.cbEstado.Properties.Appearance.Options.UseForeColor = true;
            this.cbEstado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("estado1", "estado1", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbEstado.Properties.DataSource = this.sourceEstado;
            this.cbEstado.Properties.DisplayMember = "estado1";
            this.cbEstado.Properties.NullText = "";
            this.cbEstado.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.cbEstado.Properties.ValueMember = "idstado";
            this.cbEstado.Size = new System.Drawing.Size(153, 22);
            this.cbEstado.TabIndex = 158;
            // 
            // sourceEstado
            // 
            this.sourceEstado.ObjectType = typeof(pointSalesv1.Models.puntoVenta.estado);
            this.sourceEstado.Session = this.sessionWork;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Location = new System.Drawing.Point(267, 66);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.cbCategoria.Properties.Appearance.Options.UseFont = true;
            this.cbCategoria.Properties.Appearance.Options.UseForeColor = true;
            this.cbCategoria.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCategoria.Properties.DataSource = this.sourceCategoria;
            this.cbCategoria.Properties.DisplayMember = "nombre";
            this.cbCategoria.Properties.NullText = "";
            this.cbCategoria.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.cbCategoria.Properties.ValueMember = "idCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(183, 22);
            this.cbCategoria.TabIndex = 157;
            // 
            // sourceCategoria
            // 
            this.sourceCategoria.ObjectType = typeof(pointSalesv1.Models.puntoVenta.categoria);
            this.sourceCategoria.Session = this.sessionWork;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(17, 136);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 86);
            this.txtNombre.TabIndex = 156;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(16, 68);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(178, 20);
            this.txtCodigo.TabIndex = 155;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(264, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 151;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 150;
            this.pictureBox2.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(23, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(422, 35);
            this.btnGuardar.TabIndex = 154;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(25, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 153;
            this.label11.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(274, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 148;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(274, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 147;
            this.label1.Text = "Categoria";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(12, 64);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(189, 29);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 152;
            this.pictureBox12.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(22, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 146;
            this.label17.Text = "Nombre";
            // 
            // btnAddUnidad
            // 
            this.btnAddUnidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUnidad.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUnidad.Image")));
            this.btnAddUnidad.Location = new System.Drawing.Point(424, 265);
            this.btnAddUnidad.Name = "btnAddUnidad";
            this.btnAddUnidad.Size = new System.Drawing.Size(27, 26);
            this.btnAddUnidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddUnidad.TabIndex = 172;
            this.btnAddUnidad.TabStop = false;
            this.btnAddUnidad.Click += new System.EventHandler(this.btnAddUnidad_Click);
            // 
            // btnAddEstado
            // 
            this.btnAddEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEstado.Image")));
            this.btnAddEstado.Location = new System.Drawing.Point(424, 133);
            this.btnAddEstado.Name = "btnAddEstado";
            this.btnAddEstado.Size = new System.Drawing.Size(27, 26);
            this.btnAddEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddEstado.TabIndex = 171;
            this.btnAddEstado.TabStop = false;
            this.btnAddEstado.Click += new System.EventHandler(this.btnAddEstado_Click);
            // 
            // sourceProductos
            // 
            this.sourceProductos.ObjectType = typeof(pointSalesv1.Models.puntoVenta.productos);
            this.sourceProductos.Session = this.sessionWork;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pointSalesv1.Properties.Resources.boxShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 452);
            this.Controls.Add(this.btnAddUnidad);
            this.Controls.Add(this.btnAddEstado);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipoUnidad);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMarcas);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClosse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMarcas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClosse;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.LookUpEdit cbTipoUnidad;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.LookUpEdit cbMarcas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.LookUpEdit cbEstado;
        public DevExpress.XtraEditors.LookUpEdit cbCategoria;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label17;
        private DevExpress.Xpo.XPCollection sourceCategoria;
        private DevExpress.Xpo.XPCollection sourceEstado;
        private DevExpress.Xpo.XPCollection sourceMarcas;
        private DevExpress.Xpo.XPCollection sourceUnidades;
        private DevExpress.Xpo.XPCollection sourceProductos;
        private System.Windows.Forms.PictureBox btnAddUnidad;
        private System.Windows.Forms.PictureBox btnAddEstado;
        public System.Windows.Forms.NumericUpDown txtStock;
        public System.Windows.Forms.NumericUpDown txtPrecio;
        private DevExpress.Xpo.UnitOfWork sessionWork;
    }
}