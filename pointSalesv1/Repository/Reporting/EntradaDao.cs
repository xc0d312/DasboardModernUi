using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using pointSalesv1.Repository.ORMDataModelCode;


namespace pointSalesv1.Repository.Reporting
{
    public class EntradaDao: ORMDataModelCode.repository
    {
        public DataTable getEntryOrder(DateTime fechaInicio, DateTime fechaFinal)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select id_entrada,fecha,empresa,
                                        group_concat(insert(' X ',1,1,idProductos),c.nombre separator ' - ') as productos,
                                        b.total
                                     from detalle_entrada a 
                                     inner join entrada b on a.id_entrada=b.idEntrada
                                     inner join productos c on a.id_prod=c.idProductos
                                     inner join proveedores d on b.id_proveedor=d.idProveedores
                                     where b.fecha between @fechaInicio and @fechaFinal
                                     group by id_entrada,fecha,empresa
                                     order by idEntrada asc";
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
