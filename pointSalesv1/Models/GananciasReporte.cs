using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Repository.Reporting;
using System.Data;

namespace pointSalesv1.Models
{
   public class GananciasReporte
    {
        public DateTime fechaInforme { get; private set; }
        public DateTime fechaInicio { get; private set; }
        public DateTime fechaFin { get; private set; }
        public List<listGanancias> listadoGanancias { get; private set; }
        public List<gananciasPeriodo> gananciasPeriodo { get; private set; }
        public double gananciasNetasTotales { get; private set; }

        public void creacionGananciasReporte(DateTime inicioFecha, DateTime hastaFecha)
        {
            fechaInforme = DateTime.Now;
            fechaInicio = inicioFecha;
            fechaFin = hastaFecha;

            var objGanancias = new GananciasDao();
            var result = objGanancias.getProfitsOrder(inicioFecha, hastaFecha);
            listadoGanancias = new List<listGanancias>();
            foreach (DataRow row in result.Rows)
            {
                var gananciasModel = new listGanancias()
                {
                    codigo = Convert.ToString(row[0]),
                    fecha = Convert.ToDateTime(row[1]),
                    cliente = Convert.ToString(row[2]),
                    producto = Convert.ToString(row[3]),
                    montoTotal = Convert.ToDouble(row[4]),
                    gananciasTotales = Convert.ToDouble(row[5])
                };
                listadoGanancias.Add(gananciasModel);
                gananciasNetasTotales += Convert.ToDouble(row[5]);
            }
            var gananciasPorFechas = (from ganancias in listadoGanancias
                                      group ganancias by ganancias.fecha
                                      into listGanancias
                                      select new
                                      {
                                          fecha = listGanancias.Key,
                                          montoTotal = listGanancias.Sum(item => item.montoTotal),
                                          gananciaTotal = listGanancias.Sum(item => item.gananciasTotales)
                                      });
            int totalDias = Convert.ToInt32((hastaFecha - fechaInicio).Days);

            if (totalDias <= 7)
            {
                gananciasPeriodo = (from ganancias in gananciasPorFechas
                                    group ganancias by ganancias.fecha
                                     into listGanancias
                                    select new gananciasPeriodo
                                    {
                                        period = listGanancias.Key.ToShortDateString(),
                                        ventasNetas = listGanancias.Sum(item => item.montoTotal),
                                        gananciasNetas = listGanancias.Sum(item => item.gananciaTotal)
                                    }).ToList();
            }
            if (totalDias <= 30)
            {
                gananciasPeriodo = (from ganancias in gananciasPorFechas
                                    group ganancias by
                                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        ganancias.fecha, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                     into listGanancias
                                    select new gananciasPeriodo
                                    {
                                        period = "week " + listGanancias.Key.ToString(),
                                        ventasNetas = listGanancias.Sum(item => item.montoTotal),
                                        gananciasNetas = listGanancias.Sum(item => item.gananciaTotal)
                                    }).ToList();
            }

            if (totalDias <= 365)
            {
                gananciasPeriodo = (from ganancias in gananciasPorFechas
                                    group ganancias by ganancias.fecha.ToString("MMM-yyyy")
                                     into listGanancias
                                    select new gananciasPeriodo
                                    {
                                        period = listGanancias.Key,
                                        ventasNetas = listGanancias.Sum(item => item.montoTotal),
                                        gananciasNetas = listGanancias.Sum(item => item.gananciaTotal)
                                    }).ToList();
            }
            else
            {
                gananciasPeriodo = (from ganancias in gananciasPorFechas
                                    group ganancias by ganancias.fecha.ToString("dd-MMM-yyyy")
                                     into listGanancias
                                    select new gananciasPeriodo
                                    {
                                        period = listGanancias.Key,
                                        ventasNetas = listGanancias.Sum(item => item.montoTotal),
                                        gananciasNetas = listGanancias.Sum(item => item.gananciaTotal)
                                    }).ToList();
            }
        }
    }
}
