using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Repository.ORMDataModelCode;
using System.Data;
using MySql.Data.MySqlClient;

namespace pointSalesv1.Repository.Reporting
{
   public class OrderDao: ORMDataModelCode.repository
    {
        public DataTable getSaleOrder(DateTime fechaInicio, DateTime fechaFinal)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select b.codigo,b.fecha,d.nombre as cliente,
                                                   group_concat(insert(' X ', 1, 1, idProductos), c.nombre separator ' - ') as productos,
                                                   sum(a.cantidad * a.precioUnitario)
                                                   from detalle_venta a inner join venta b on b.idVenta = a.id_venta
                                                   inner join productos c on c.idProductos = a.id_prod
                                                   inner join clientes d on d.idClientes = b.id_cliente
                                                   where b.fecha BETWEEN @fechaInicio AND @fechaFinal
                                                   group by a.id_venta,b.fecha,d.nombre
                                                    order BY a.id_venta";
                    command.Parameters.Add("@fechaInicio", MySqlDbType.Date).Value = fechaInicio;
                    command.Parameters.Add("@fechaFinal", MySqlDbType.Date).Value = fechaFinal;
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
