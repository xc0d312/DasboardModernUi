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
    public partial class DangerForm : Form
    {
        public DangerForm(string message)
        {
            InitializeComponent();
            labelMessages.Text = message;
            fadeForm.Tick += opacityAnimation;
            this.Opacity = 0.20;
            btnOk.Click += btnOk_Click;
            btnCancel.Click += btnCancel_Click;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void opacityAnimation(object sender,EventArgs e)
        {
            fadeForm.Interval = 200;
            fadeForm.Start();
            if(this.Opacity < 100)
            {
                this.Opacity += 0.1;
            }
            else
            {
                fadeForm.Stop();
            }
        }
        public static void showMessageForm(string name) {
            DangerForm objForm = new DangerForm(name);
            objForm.ShowDialog();
        }
    }
}
