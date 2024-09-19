using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Messages;
using pointSalesv1.Models.puntoVenta;


namespace pointSalesv1.Views
{
    public partial class TipoUnidadForm : Form
    {
        tipounidad objTipoUnidad;
        bool update = false;
        public TipoUnidadForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            instance = null;
            this.Close();
        }

        private static TipoUnidadForm instance = null;
        public static TipoUnidadForm getInstance()
        {

            if (instance == null)
            {
                instance = new TipoUnidadForm();
            }
            return instance;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (update)
            {
                objTipoUnidad = viewUnidades.GetFocusedRow() as tipounidad;
            }
            else
            {
                objTipoUnidad = new tipounidad(sessionWork);

            }
            objTipoUnidad.tipoUnidad = txtUnidad.Text.ToUpper();
            sessionWork.Save(objTipoUnidad);
            sessionWork.CommitChanges();
            sourceTipoUnidad.Reload();
            NotifyForm.showMessageForm("Datos guardados correctamente!!");
        }

        private void viewUnidades_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            switch (viewUnidades.Columns[e.Column.VisibleIndex].Name)
            {
                case "colEdit":
                    tipounidad row = viewUnidades.GetRow(viewUnidades.GetSelectedRows()[0]) as tipounidad;
                    txtUnidad.Text = row.tipoUnidad.ToUpper();
                    update = true;
                    break;

                default:
                    break;
            }
        }
    }
}
