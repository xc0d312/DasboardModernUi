using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace pointSalesv1.MailServices
{
    public class SystemSupportMail:MasterMailServices
    {
        public SystemSupportMail()
        {
            senderMail = "geovannysoporte12@gmail.com";
            password = "ivpsipksuyjhsufm";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmptClient();
        }
        public void notification()
        {

        }
        public async Task recoveryPassword(string nombre, string password, string mail, CancellationToken token)
        {
            await sendEmail(token, subject: "SYSTEM: RECUPERAR CUENTA ",
                                  body: " Hola, " + nombre + "\nSu Clave de Recuperacion de Usuario es :" + password +
                                  ",  le pedimos que confirme la Clave de Recuperacion. \n"
                                  + "sin embargo le pedimos que cambie su clave cuando acceda al sistema"
                                  , recipientMail: new List<string> { mail });
        }
    }
}
