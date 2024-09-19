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
using pointSalesv1.ObjValues;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Views;

namespace pointSalesv1.Views
{
    public partial class EstadoForm : Form
    {
        //PATRON SINGLETON
        bool update = false;
        estado objEstado;
        public EstadoForm()
        {
            InitializeComponent();
        }
        private static EstadoForm instance = null;
        public static EstadoForm getIntance()
        {
            if (instance == null)
            {
                instance = new EstadoForm();
            }

            return instance;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (update)
            {
                objEstado = viewEstado.GetFocusedRow() as estado;
            }
            else
            {
                objEstado = new estado(sessionWork);

            }

            objEstado.estado1 = txtEstado.Text.ToUpper();

            sessionWork.CommitChanges();
            sourceEstado.Reload();
            NotifyForm.showMessageForm("Guardado correctamente");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            instance = null;
            this.Close();
        }

        private void viewEstado_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            switch (viewEstado.Columns[e.Column.VisibleIndex].Name)
            {
                case "colEdit":
                    estado row = viewEstado.GetRow(viewEstado.GetSelectedRows()[0]) as estado;
                    txtEstado.Text = row.estado1.ToUpper();
                    update = true;
                    break;

                default:
                    break;
            }
        }
    }
}
