using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Models.puntoVenta;


namespace pointSalesv1.Cache
{
    public static class UserActive
    {
        public static int idUsuario { get; set; }

        public static string userName { get; set; }

        public static string password { get; set; }

        public static string fullname { get; set; }

        public static string rol { get; set; }

        public static string email { get; set; }
        public static UserObject GetUserActiveObject()
        {
            return new UserObject
            {
                IdUsuario = idUsuario,
                UserName = userName,
                Password = password,
                Fullname = fullname,
                Rol = rol,
                Email = email
            };
        }
    }
    public class UserObject
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
    }

}

