using pointSalesv1.Repository.ORMDataModelCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using pointSalesv1.MailServices;

namespace pointSalesv1.Models
{
    public class UsersModels
    {
        UserDao userDao = new UserDao();
        int id;
        string userName;
        string password;
        string fullName;
        string rol;
        string email;

        public UsersModels(int id, string userName, string password, string fullName, string rol, string email)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
            this.rol = rol;
            this.email = email;
        }
        public UsersModels()
        {

        }
        public void editProfile()
        {
            userDao.editProfile(id, userName, password, fullName, rol, email);

        }
        public async Task<string> getRecoveryAccount(string nombre, string password, string mail, CancellationToken token)
        {

            try
            {
                var mailServices = new SystemSupportMail();

                await mailServices.recoveryPassword(nombre, password, mail, token);

                return "Hola Usuario, " + nombre +
                "\nSolicitastes Recuperar tu Contraseña.\n" +
                     "Porfavor Revise Su Correo Electronico: ";
            }
            catch (System.Net.Mail.SmtpException)
            {
                return "!!Error al enviar Correo,\n porfavor Revise su conexion";
                throw;
            }
            catch (OperationCanceledException)
            {
                return "se agoto el tiempo de espera:(";
            }


        }
    }
}
