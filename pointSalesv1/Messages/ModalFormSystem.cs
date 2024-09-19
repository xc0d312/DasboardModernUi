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
    public partial class ModalFormSystem : Form
    {
        public ModalFormSystem()
        {
            InitializeComponent();
        }

        private void btnClosse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
