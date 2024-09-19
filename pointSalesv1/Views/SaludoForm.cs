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


namespace pointSalesv1.Views
{
    public partial class SaludoForm : Form
    {
        public SaludoForm()
        {
            InitializeComponent();
            timer1.Tick += greeting_timer;
            this.timer2.Tick += fade_Form;
            this.Load += load_Config;

        }
        Action<Label> loadCache = (lbl) => {
            lbl.Text = UserActive.userName;
        };
        private void greeting_timer(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            if (this.Opacity <= 1) { this.Opacity += 0.05; }
            circuleProgressBar.Value += 2;
            circuleProgressBar.Text = circuleProgressBar.Value.ToString();
            if (circuleProgressBar.Value == 100) { timer1.Stop(); timer2.Start(); }
        }
        private void fade_Form(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0) { timer2.Stop(); this.Close(); }
        }
        private void load_Config(object sender, EventArgs e)
        {
            loadCache(labelUser);
            timer1.Enabled = true;
            timer1.Start();
            this.Opacity = 0;
        }
    }
}
