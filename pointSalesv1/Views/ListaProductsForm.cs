using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Models.puntoVenta;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Xpo;

namespace pointSalesv1.Views
{
    public partial class ListaProductsForm : Form
    {


        private productos productSelected;
        public ListaProductsForm(Session sessionWork)
        {
            InitializeComponent();
            XpoDefault.Session = sessionWork;
        }

        private void viewsProductos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                GridView view = sender as GridView;
                var result = viewsProductos.GetFocusedRow() as productos;
                productSelected = result;
                this.Close();
            }
        }
        public productos getProductSelected()
        {
            return productSelected;
        }

        private void ListaProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
           
        }
    }
}
