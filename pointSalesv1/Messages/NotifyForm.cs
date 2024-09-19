using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pointSalesv1.Messages
{
    public partial class NotifyForm : Form
    {
        public NotifyForm(string name)
        {
            InitializeComponent();
            labelMessages.Text = name;
            btnAceptar.Click += aceptar_click;
            this.fadeForm.Tick += opacityAnimation;
            this.Opacity = 0.20;

        }
        public static void showMessageForm(string name)
        {
            NotifyForm objForm = new NotifyForm(name);
            objForm.ShowDialog();
        }
        private void aceptar_click(object sender,EventArgs e)
        {
            this.Close();
        }
        private void opacityAnimation(object sender,EventArgs e)
        {
            fadeForm.Interval = 200;
            fadeForm.Start();
            if(this.Opacity < 100)
            {
                this.Opacity += 0.1;
            }
            else{
                fadeForm.Stop();
            }
        }
    }
}
