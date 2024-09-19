namespace pointSalesv1
{
    partial class ReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VentasReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentasListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentasPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.Personalizado = new System.Windows.Forms.Button();
            this.btnThisYear = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Day = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VentasReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPeriodoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentasReporteBindingSource
            // 
            this.VentasReporteBindingSource.DataSource = typeof(pointSalesv1.Models.VentasReporte);
            // 
            // VentasListBindingSource
            // 
            this.VentasListBindingSource.DataSource = typeof(pointSalesv1.Models.VentasList);
            // 
            // VentasPeriodoBindingSource
            // 
            this.VentasPeriodoBindingSource.DataSource = typeof(pointSalesv1.Models.VentasPeriodo);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toDatePicker);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.Personalizado);
            this.panel1.Controls.Add(this.btnThisYear);
            this.panel1.Controls.Add(this.btnThisMonth);
            this.panel1.Controls.Add(this.btnLast30Days);
            this.panel1.Controls.Add(this.btnLast7Day);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 678);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(0, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(235, 52);
            this.btnClose.TabIndex = 136;
            this.btnClose.Text = "Cerrar Reporte";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(24, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "hasta";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(24, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "desde";
            this.label1.Visible = false;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(75, 489);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(134, 22);
            this.toDatePicker.TabIndex = 2;
            this.toDatePicker.Visible = false;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(75, 453);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(134, 22);
            this.fromDatePicker.TabIndex = 2;
            this.fromDatePicker.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.Gray;
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicar.Location = new System.Drawing.Point(24, 526);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAplicar.Size = new System.Drawing.Size(190, 35);
            this.btnAplicar.TabIndex = 134;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Visible = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(75, 450);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(137, 29);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 132;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Visible = false;
            // 
            // Personalizado
            // 
            this.Personalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.Personalizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Personalizado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Personalizado.FlatAppearance.BorderSize = 0;
            this.Personalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personalizado.ForeColor = System.Drawing.Color.DimGray;
            this.Personalizado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Personalizado.Location = new System.Drawing.Point(0, 382);
            this.Personalizado.Name = "Personalizado";
            this.Personalizado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Personalizado.Size = new System.Drawing.Size(235, 52);
            this.Personalizado.TabIndex = 114;
            this.Personalizado.Text = "Personalizado";
            this.Personalizado.UseVisualStyleBackColor = false;
            this.Personalizado.Click += new System.EventHandler(this.Personalizado_Click);
            // 
            // btnThisYear
            // 
            this.btnThisYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnThisYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThisYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThisYear.FlatAppearance.BorderSize = 0;
            this.btnThisYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisYear.ForeColor = System.Drawing.Color.DimGray;
            this.btnThisYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThisYear.Location = new System.Drawing.Point(0, 330);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThisYear.Size = new System.Drawing.Size(235, 52);
            this.btnThisYear.TabIndex = 114;
            this.btnThisYear.Text = "Este Año";
            this.btnThisYear.UseVisualStyleBackColor = false;
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnThisMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThisMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThisMonth.FlatAppearance.BorderSize = 0;
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.DimGray;
            this.btnThisMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThisMonth.Location = new System.Drawing.Point(0, 278);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThisMonth.Size = new System.Drawing.Size(235, 52);
            this.btnThisMonth.TabIndex = 114;
            this.btnThisMonth.Text = "Este mes";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnLast30Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast30Days.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLast30Days.FlatAppearance.BorderSize = 0;
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Days.ForeColor = System.Drawing.Color.DimGray;
            this.btnLast30Days.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLast30Days.Location = new System.Drawing.Point(0, 226);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLast30Days.Size = new System.Drawing.Size(235, 52);
            this.btnLast30Days.TabIndex = 114;
            this.btnLast30Days.Text = "Los  ultimos 30 dias";
            this.btnLast30Days.UseVisualStyleBackColor = false;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnLast7Day
            // 
            this.btnLast7Day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnLast7Day.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast7Day.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLast7Day.FlatAppearance.BorderSize = 0;
            this.btnLast7Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Day.ForeColor = System.Drawing.Color.DimGray;
            this.btnLast7Day.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLast7Day.Location = new System.Drawing.Point(0, 174);
            this.btnLast7Day.Name = "btnLast7Day";
            this.btnLast7Day.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLast7Day.Size = new System.Drawing.Size(235, 52);
            this.btnLast7Day.TabIndex = 114;
            this.btnLast7Day.Text = "Los  ultimos 7 dias";
            this.btnLast7Day.UseVisualStyleBackColor = false;
            this.btnLast7Day.Click += new System.EventHandler(this.btnLast7Day_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.DimGray;
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(0, 122);
            this.btnToday.Name = "btnToday";
            this.btnToday.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnToday.Size = new System.Drawing.Size(235, 52);
            this.btnToday.TabIndex = 114;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 122);
            this.panel2.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "informe por fechas y periodos";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "VentasReporte";
            reportDataSource1.Value = this.VentasReporteBindingSource;
            reportDataSource2.Name = "VentasList";
            reportDataSource2.Value = this.VentasListBindingSource;
            reportDataSource3.Name = "VentasPeriodo";
            reportDataSource3.Value = this.VentasPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pointSalesv1.Reports.ReportVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(241, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(936, 663);
            this.reportViewer1.TabIndex = 3;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 678);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteVentas";
            this.Text = "ReporteVentas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPeriodoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button Personalizado;
        private System.Windows.Forms.Button btnThisYear;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Day;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentasReporteBindingSource;
        private System.Windows.Forms.BindingSource VentasListBindingSource;
        private System.Windows.Forms.BindingSource VentasPeriodoBindingSource;
    }
}