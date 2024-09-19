using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace pointSalesv1.Repository.Charts
{
   public class ChartsDao:Repository.ORMDataModelCode.repository
    {
       public MySqlDataReader getChartxProductoPreferidos()
        {
                var connection = getConnection();
            
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_productosPreferidos";
                    command.CommandType = CommandType.StoredProcedure;
                    return command.ExecuteReader(CommandBehavior.CloseConnection);
                }
            
        }
        public MySqlDataReader getChartProductosxCategoria()
        {
            var connection = getConnection();
            connection.Open();
            using (var command = new MySqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "sp_productoPorCategoria";
                command.CommandType = CommandType.StoredProcedure;
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

    }
}
