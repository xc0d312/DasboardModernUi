using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Repository.Reporting;
using System.Data;

namespace pointSalesv1.Models
{
    public class VentasReporte
    {
        public DateTime fechaInforme { get; private set; }
        public DateTime fechaInicio { get; private set; }
        public DateTime fechaFin { get; private set; }
        public List<VentasList> listadoVentas { get; private set; }
        public List<VentasPeriodo> VentasPorPeriodo { get; private set; }
        public double ventasNetasTotales { get; private set; }

        //Methods
        public void creacionVentasReporte(DateTime inicioFecha, DateTime hastaFecha)
        {
            //implementas fechas
            fechaInforme = DateTime.Now;
            fechaInicio = inicioFecha;
            fechaFin = hastaFecha;

            //crear ventas listas

            var objVenta = new OrderDao();
            var result = objVenta.getSaleOrder(inicioFecha, hastaFecha);
            listadoVentas = new List<VentasList>();

            foreach (DataRow row in result.Rows)
            {
                var ventasModel = new VentasList()
                {
                    codigo = Convert.ToString(row[0]),
                    fechaVenta = Convert.ToDateTime(row[1]),
                    cliente = Convert.ToString(row[2]),
                    producto = Convert.ToString(row[3]),
                    montoTotal = Convert.ToDouble(row[4])
                };
                listadoVentas.Add(ventasModel);
                //calcular las ventas totales netas
                ventasNetasTotales += Convert.ToDouble(row[4]);
            }
            //crear vetas netas por periodos
            //crear lista temporal de las ventas por fecha
            var ventasPorFechas = (from ventas in listadoVentas
                                   group ventas by ventas.fechaVenta
                                    into listaVentas
                                   select new
                                   {
                                       fecha = listaVentas.Key,
                                       montoTotal = listaVentas.Sum(item => item.montoTotal)
                                   }).AsEnumerable();

            int totalDias = Convert.ToInt32((hastaFecha - fechaInicio).Days);

            //agrupar por dias
            if (totalDias <= 7)
            {
                VentasPorPeriodo = (from ventas in ventasPorFechas
                                    group ventas by ventas.fecha
                                     into listaVentas
                                    select new VentasPeriodo
                                    {
                                        period = listaVentas.Key.ToShortDateString(),
                                        ventasNetas = listaVentas.Sum(item => item.montoTotal)
                                    }).ToList();
            }
            //agrupar por semanas
            if (totalDias <= 30)
            {
                VentasPorPeriodo = (from ventas in ventasPorFechas
                                    group ventas by
                                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        ventas.fecha, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                     into listaVentas
                                    select new VentasPeriodo
                                    {
                                        period = "week " + listaVentas.Key.ToString(),
                                        ventasNetas = listaVentas.Sum(item => item.montoTotal)
                                    }).ToList();
            }


            //agrupar por mes
            if (totalDias <= 365)
            {
                VentasPorPeriodo = (from ventas in ventasPorFechas
                                    group ventas by ventas.fecha.ToString("MMM-yyyy")
                                     into listaVentas
                                    select new VentasPeriodo
                                    {
                                        period = listaVentas.Key,
                                        ventasNetas = listaVentas.Sum(item => item.montoTotal)
                                    }).ToList();
            }
            //agrupar por años
            else
            {
                VentasPorPeriodo = (from ventas in ventasPorFechas
                                    group ventas by ventas.fecha.ToString("dd-MMM-yyyy")
                                     into listaVentas
                                    select new VentasPeriodo
                                    {
                                        period = listaVentas.Key,
                                        ventasNetas = listaVentas.Sum(item => item.montoTotal)
                                    }).ToList();
            }
        }
    }
}
