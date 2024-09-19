using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace pointSalesv1.MailServices
{
   public abstract class MasterMailServices
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmptClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }
        public async Task sendEmail(CancellationToken token, string subject, string body, List<string> recipientMail)
        {

            using (var mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                //SUSPENDE EL PROCESO Y CUANDO TERMINA LO REANUDA
                //USAMOS METODO ASINCRONO PARA EVITAR CUELLO DE BOTELLA
                if (token.IsCancellationRequested)
                {
                    smtpClient.Dispose();
                    token.ThrowIfCancellationRequested();
                }
                await smtpClient.SendMailAsync(mailMessage);//ESPERAMOS EL RESULTADO             
            }
            smtpClient.Dispose();
        }
    }
}
