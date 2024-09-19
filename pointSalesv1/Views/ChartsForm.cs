using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using pointSalesv1.Repository.Charts;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.Views
{
    public partial class ChartsForm : Form
    {
        ArrayList categoria = new ArrayList();
        ArrayList cantProd = new ArrayList();
        ArrayList producto = new ArrayList();
        ArrayList cant = new ArrayList();
        public ChartsForm()
        {
            InitializeComponent();
            grafCategorias();
            productosPreferidos();
            getsCount();
        }
        public void getsCount()
        {
            countCategorias.Text = sourceCategorias.Count.ToString();
            countMarcas.Text = sourceMarcas.Count.ToString();
            countProd.Text = sourceProductos.Count.ToString();
            countClientes.Text = sourceClientes.Count.ToString();
            labelTotalVentas.Text = sourceVentas.OfType<venta>().Sum(v => v.total).ToString();
            sourceMarcas.Reload();
            sourceCategorias.Reload();
            sourceProductos.Reload();
            sourceClientes.Reload();
        }
        private void grafCategorias()
        {
            using (var reader = new ChartsDao().getChartProductosxCategoria())
            {
                while (reader.Read())
                {
                    categoria.Add(reader.GetString(0));
                    cantProd.Add(reader.GetInt32(1));
                }
            }
            chartProductoCategoria.Series[0].Points.DataBindXY(categoria,cantProd);
        }
       private void productosPreferidos()
        {
            using (var reader = new ChartsDao().getChartxProductoPreferidos())
            {
                while (reader.Read())
                {
                    producto.Add(reader.GetString(1));
                    cant.Add(reader.GetInt32(2));
                }
            }
            chartProductosPreferidos.Series[0].Points.DataBindXY(producto, cant);
        }
    }
}
