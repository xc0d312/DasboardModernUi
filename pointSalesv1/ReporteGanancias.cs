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
    public partial class ReporteGanancias : Form
    {
        Button currentBtn;
        Panel rigthBorderPanel;
        public ReporteGanancias()
        {
            InitializeComponent();
            rigthBorderPanel = new Panel();
            rigthBorderPanel.Size = new Size(7, 52);
            panelControls.Controls.Add(rigthBorderPanel);
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

        private void ReporteGanancias_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private void obtenerGananciasReporte(DateTime fechaInicio, DateTime fechaFinal)
        {
            GananciasReporte reportGanancia = new GananciasReporte();
            reportGanancia.creacionGananciasReporte(fechaInicio, fechaFinal);
            GananciasReporteBindingSource.DataSource = reportGanancia;
            listGananciasBindingSource.DataSource = reportGanancia.listadoGanancias;
            gananciasPeriodoBindingSource.DataSource = reportGanancia.gananciasPeriodo;
            this.reportViewer1.RefreshReport();
        }
        
        private void btnToday_Click(object sender, EventArgs e)
        {

            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = DateTime.Today;
            var hastaFecha = DateTime.Now;
            obtenerGananciasReporte(desdeFecha, hastaFecha);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = fromDatePicker.Value;
            var hastaFecha = toDatePicker.Value;
            obtenerGananciasReporte(desdeFecha, new DateTime(hastaFecha.Year, hastaFecha.Month, hastaFecha.Day, 23, 59, 59));
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
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var hastaFecha = DateTime.Now;
            obtenerGananciasReporte(desdeFecha, hastaFecha);
        }

        private void btnLast7Day_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = DateTime.Today.AddDays(-7);
            var hastaFecha = DateTime.Now;
            obtenerGananciasReporte(desdeFecha, hastaFecha);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = DateTime.Today.AddDays(-30);
            var hastaFecha = DateTime.Now;
            obtenerGananciasReporte(desdeFecha, hastaFecha);
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            var desdeFecha = new DateTime(DateTime.Now.Year, 1, 1);
            var hastaFecha = DateTime.Now;
            obtenerGananciasReporte(desdeFecha, hastaFecha);
        }

        private void Personalizado_Click(object sender, EventArgs e)
        {
            activeButton(sender, UI.RGBcolors.color1);
            showButton(true);
        }
    }
}
