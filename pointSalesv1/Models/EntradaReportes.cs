using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Repository.Reporting;
using System.Data;

namespace pointSalesv1.Models
{
        public class EntradaReportes
        {
            public DateTime fechaInforme { get; private set; }
            public DateTime fechaInicio { get; private set; }
            public DateTime fechaFin { get; private set; }
            public List<EntradasList> listadoEntradas { get; private set; }
            public List<EntradasPeriodo> EntradasPorPeriodo { get; private set; }
            public Double entradasNetasTotales { get; private set; }

            public void createEntradasReporte(DateTime inicioFecha, DateTime hastaFecha)
            {
                //implementas fechas
                fechaInforme = DateTime.Now;
                fechaInicio = inicioFecha;
                fechaFin = hastaFecha;
                //crear entradas listas

                var objEntrada = new EntradaDao();
                var result = objEntrada.getEntryOrder(inicioFecha, hastaFecha);
                listadoEntradas = new List<EntradasList>();
                foreach (DataRow row in result.Rows)
                {
                    var entradasModel = new EntradasList()
                    {
                        idEntrada = Convert.ToInt32(row[0]),
                        fechaEntrada = Convert.ToDateTime(row[1]),
                        proveedor = Convert.ToString(row[2]),
                        productos = Convert.ToString(row[3]),
                        montoTotal = Convert.ToDouble(row[4])
                    };
                    listadoEntradas.Add(entradasModel);
                    entradasNetasTotales += Convert.ToDouble(row[4]);
                }

                var entradasPorFechas = (from entradas in listadoEntradas
                                         group entradas by entradas.fechaEntrada
                                         into listadoEntradas
                                         select new
                                         {
                                             fecha = listadoEntradas.Key,
                                             montoTotal = listadoEntradas.Sum(item => item.montoTotal)
                                         });

                int totalDias = Convert.ToInt32((hastaFecha - fechaInicio).Days);

                if (totalDias <= 7)
                {
                    EntradasPorPeriodo = (from entradas in entradasPorFechas
                                          group entradas by entradas.fecha
                                         into listaEntradas
                                          select new EntradasPeriodo
                                          {
                                              period = listaEntradas.Key.ToShortDateString(),
                                              entradasNetas = listaEntradas.Sum(item => item.montoTotal)
                                          }).ToList();
                }
                if (totalDias <= 30)
                {
                    EntradasPorPeriodo = (from entradas in entradasPorFechas
                                          group entradas by
                                           System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                            entradas.fecha, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                         into listaEntradas
                                          select new EntradasPeriodo
                                          {
                                              period = "week" + listaEntradas.Key.ToString(),
                                              entradasNetas = listaEntradas.Sum(item => item.montoTotal)
                                          }).ToList();
                }
                if (totalDias <= 365)
                {
                    EntradasPorPeriodo = (from entradas in entradasPorFechas
                                          group entradas by entradas.fecha.ToString("MMM-yyyy")
                                         into listaEntradas
                                          select new EntradasPeriodo
                                          {
                                              period = listaEntradas.Key,
                                              entradasNetas = listaEntradas.Sum(item => item.montoTotal)
                                          }).ToList();
                }
                else
                {
                    EntradasPorPeriodo = (from entrada in entradasPorFechas
                                          group entrada by entrada.fecha.ToString("dd-MMM-yyyy")
                                         into listaVentas
                                          select new EntradasPeriodo
                                          {
                                              period = listaVentas.Key,
                                              entradasNetas = listaVentas.Sum(item => item.montoTotal)
                                          }).ToList();
                
            }
        }
    }
}
