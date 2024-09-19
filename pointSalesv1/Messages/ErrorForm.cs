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
    public partial class ErrorForm : Form
    {
        public ErrorForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
            btnOk.Click += btnOk_Click;
            fadeForm.Tick += opacityAnimation;
            this.Opacity = 0.20;
        }
        public static void showMessageForm(string mensage)
        {
            ErrorForm objForm = new ErrorForm(mensage);
            objForm.ShowDialog();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void opacityAnimation(object sender, EventArgs e)
        {

            fadeForm.Interval = 200;
            fadeForm.Start();
            if (this.Opacity <= 100)
            {
                this.Opacity += 0.1;
            }
            else if (this.Opacity == 100)
            {
                fadeForm.Stop();
            }

        }
    }
}
