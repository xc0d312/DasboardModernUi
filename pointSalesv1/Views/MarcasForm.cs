using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1.Contracts;
using pointSalesv1.Cache;
using pointSalesv1.Messages;
using pointSalesv1.Models;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.ObjValues;

namespace pointSalesv1.Views
{
    public partial class MarcasForm : Form, IMarcasRepository
    {
        private bool update = false;
        marcas objMarcas;
        public MarcasForm()
        {
            InitializeComponent();
        }

        public bool existMarcas(string marcas)
        {
            bool exits = false;
            foreach (marcas item in sourceMarcas)
            {
                if (marcas == item.marcas1)
                {
                    exits = true;
                }
            }
            return exits;
        }

        private void MarcasForm_Load(object sender, EventArgs e)
        {
            tableMarcas.DataSource = sourceMarcas;
            reloadTable();
            tableMarcas.ClearSelection();
            UI.clearCajas(this.Controls);
        }
        private void reloadTable()
        {
            sourceMarcas.Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DangerForm objForm = new DangerForm("Estas seguro de eliminar esta marca");
            if (tableMarcas.SelectedRows.Count > 0)
            {
                if (objForm.ShowDialog() == DialogResult.OK)
                {
                    objMarcas = (marcas)viewMarcas.GetFocusedRow();
                    sessionWork.Delete(objMarcas);
                    sessionWork.CommitChanges();
                    NotifyForm.showMessageForm("Marca Eliminada");
                    MarcasForm_Load(sender, e);
                }
            }
            else
            {
                ErrorForm.showMessageForm("Elija un registro");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tableMarcas.SelectedRows.Count > 0)
            {
                txtMarcas.Text = tableMarcas.CurrentRow.Cells[1].Value.ToString();
                txtDecripcion.Text = tableMarcas.CurrentRow.Cells[2].Value.ToString();
                update = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                ErrorForm.showMessageForm("Elija un registro");
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            objMarcas = update ? (marcas)viewMarcas.GetFocusedRow() : new marcas(sessionWork);
            objMarcas.marcas1 = txtMarcas.Text.ToUpper();
            objMarcas.descripcion = txtDecripcion.Text.ToUpper();
            if (update == false)
            {
                var result = await validar(objMarcas);
                if (result == false)
                {
                    objMarcas.Session.Reload(objMarcas);
                    return;
                }
            }

            sessionWork.Save(objMarcas);
            sessionWork.CommitChanges();
            NotifyForm.showMessageForm("Datos guardados correctamente!!");
            objMarcas.Reload();
            MarcasForm_Load(sender, e);
            btnGuardar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (update) update = false;
            UI.clearCajas(this.Controls);
            btnGuardar.Enabled = true;
            txtMarcas.Focus();
        }
        private async Task<bool> validar<T>(T obj) where T : marcas
        {
            var valid = new ValidationModelsMarcas();

            var result = await valid.ValidateAsync(obj);

            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ErrorForm.showMessageForm(item.ToString());
                    break;
                }
                return false;
            }
            return true;
        }

        private void btnClosse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                viewMarcas.ExportToXls(path);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            viewMarcas.ShowPrintPreview();
        }
    }
}
