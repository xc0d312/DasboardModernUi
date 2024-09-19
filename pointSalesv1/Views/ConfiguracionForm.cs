using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pointSalesv1.Views
{
    public partial class ConfiguracionForm : Form
    {
        public ConfiguracionForm()
        {
            InitializeComponent();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            var frm = new BackupForm();
            frm.ShowDialog();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            var frm = new PerfileActiveForm();
            frm.ShowDialog();
        }
    }
}
