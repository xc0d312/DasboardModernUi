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
using pointSalesv1.Models;

namespace pointSalesv1
{
    public partial class ReporteVentas : Form
    {
        Button currentBtn;
        Panel rigthBorderPanel;
        public ReporteVentas()
        {
            InitializeComponent();
            rigthBorderPanel = new Panel();
            rigthBorderPanel.Size = new Size(7, 52);
            panel1.Controls.Add(rigthBorderPanel);
            this.MinimizeBox = false;
        }
        public void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(46, 52, 88);
                currentBtn.ForeColor = Color.DimGray;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }

        }
        public void activeButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //rigth border button
                rigthBorderPanel.BackColor = color;

                rigthBorderPanel.Location = new Point(230, currentBtn.Location.Y);
                rigthBorderPanel.Visible = true;
                rigthBorderPanel.BringToFront();
            }
        }
        private void ReporteVentas_Load(object sender, EventArgs e)
        {
        }
        private void ObtenerVentasReporte(DateTime fechaInicio, DateTime fechaFinal)
        {
            VentasReporte reportModel = new VentasReporte();
            reportModel.creacionVentasReporte(fechaInicio, fechaFinal);
            VentasReporteBindingSource.DataSource = reportModel;
            VentasListBindingSource.DataSource = reportModel.listadoVentas;
            VentasPeriodoBindingSource.DataSource = reportModel.VentasPorPeriodo;
            this.reportViewer1.RefreshReport();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = DateTime.Today;
            var hastaFecha = DateTime.Now;
            ObtenerVentasReporte(desdeFecha, hastaFecha);
        }

        private void btnLast7Day_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = DateTime.Today.AddDays(-7);
            var hastaFecha = DateTime.Now;
            ObtenerVentasReporte(desdeFecha, hastaFecha);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
           
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = DateTime.Today.AddDays(-30);
            var hastaFecha = DateTime.Now;
            ObtenerVentasReporte(desdeFecha, hastaFecha);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var hastaFecha = DateTime.Now;
            ObtenerVentasReporte(desdeFecha, hastaFecha);
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = new DateTime(DateTime.Now.Year, 1, 1);
            var hastaFecha = DateTime.Now;
            ObtenerVentasReporte(desdeFecha, hastaFecha);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var desdeFecha = fromDatePicker.Value;
            var hastaFecha = toDatePicker.Value;
            ObtenerVentasReporte(desdeFecha, new DateTime(hastaFecha.Year, hastaFecha.Month, hastaFecha.Day, 23, 59, 59));
            showButton(false);
        }
        private void showButton(bool active)
        {
            btnAplicar.Visible = active;
            label1.Visible = active;
            label2.Visible = active;
            fromDatePicker.Visible = active;
            toDatePicker.Visible = active;
        }

        private void Personalizado_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            showButton(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color2);
            this.Close();
        }
    }
}
