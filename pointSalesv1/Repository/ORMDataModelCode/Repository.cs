using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace pointSalesv1.Repository.ORMDataModelCode
{
    public  class repository
    {
        protected MySqlConnection getConnection()
        {
            return new MySqlConnection("Server=localhost; Database=puntoVenta;Uid=root;Pwd=xc0d312;");
        }
        public MySqlConnection backupConnection()
        {
            return new MySqlConnection("Server=localhost; Database=puntoVenta;Uid=root;Pwd=xc0d312;");

        }
    }
}
