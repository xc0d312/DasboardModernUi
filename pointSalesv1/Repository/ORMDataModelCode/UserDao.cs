using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Models.puntoVenta;
using MySql.Data;
using MySql.Data.MySqlClient;
using pointSalesv1.Repository;
using System.Data;

namespace pointSalesv1.Repository.ORMDataModelCode
{
    public class UserDao:repository
    {
        public void editProfile(int id, string userName, string password, string fullName, string rol, string mail)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"update usuarios set userName=@userName,
                                        password=@password, fullName=@fullName, rol=@rol, email=@mail
                                        where idUsuarios=@id";
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@rol", rol);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
