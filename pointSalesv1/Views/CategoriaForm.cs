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
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Contracts;
using pointSalesv1.ObjValues;
using pointSalesv1.Messages;

namespace pointSalesv1
{
    public partial class CategoriasForm : Form,ICategoriaRepository
    {
        categoria objCategoria;
        bool update = false;
        public CategoriasForm()
        {
            InitializeComponent();
            btnClosse.Click += close_click;
            this.Load += load_config;
        }
        //controls
        private void close_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            if (update) update = false;
            btnGuardar.Enabled = true;
            UI.clearCajas(this.Controls);
            txtCategorias.Focus();
        }

        private void load_config(object sender, EventArgs e)
        {
            tableCategorias.DataSource = sourceCategoria;
            reloadTable();
            tableCategorias.ClearSelection();
            UI.clearCajas(this.Controls);
        
        }
        private void reloadTable() {
            sourceCategoria.Reload();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            objCategoria = update ? (categoria)viewCategorias.GetFocusedRow() : new categoria(sessionWork);
          
            objCategoria.nombre = txtCategorias.Text.ToUpper().Trim();
            objCategoria.descripcion = txtDecripcion.Text.ToUpper().Trim();
            if (!update)
            {
                var result = await validar(objCategoria);
                if (!result)
                {
                    objCategoria.Session.Reload(objCategoria);
                    return;
                }
            }
            sessionWork.Save(objCategoria);
            sessionWork.CommitChanges();
            NotifyForm.showMessageForm("Datos guardados correctamente!!");
            objCategoria.Reload();
            this.load_config(sender, e);
            btnGuardar.Enabled = false;
        }
        private async Task<bool> validar<T>(T obj)where T:categoria
        {
            var valid = new ValidationModelsCategorias();

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
        public bool existCategoria(string name)
        {
            bool exist = false;
            foreach (categoria item in sourceCategoria)
            {
                if(name == item.nombre)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tableCategorias.SelectedRows.Count > 0)
            {
                txtCategorias.Text = tableCategorias.CurrentRow.Cells[1].Value.ToString();
                txtDecripcion.Text = tableCategorias.CurrentRow.Cells[2].Value.ToString();
                update = true;
                btnGuardar.Enabled = true;
            }
            else{
                ErrorForm.showMessageForm("Elija un elemento!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DangerForm objForm = new DangerForm("Esta seguro que " +
                " desea eliminar esta categoria");
            if (tableCategorias.SelectedRows.Count > 0)
            {
                if (objForm.ShowDialog() == DialogResult.OK)
                {
                    objCategoria = (categoria)viewCategorias.GetFocusedRow();

                    sessionWork.Delete(objCategoria);
                    sessionWork.CommitChanges();
                    NotifyForm.showMessageForm("Categoria eliminada!!");
                }
            }
            else
            {
                ErrorForm.showMessageForm("Elija un elemento!!");
            }
            tableCategorias.ClearSelection();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                viewCategorias.ExportToXls(path);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            viewCategorias.ShowPrintPreview();
        }
    }
}
