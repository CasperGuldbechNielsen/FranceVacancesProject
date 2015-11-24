using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EASendMailRT;

namespace Hamburger_Heaven_Challenge
{
    class email
    {

        public async Task Send_Email(string toMail, string toSubject, string toMessage)
        {
            String Result = "";
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();

                // Set your gmail email address
                oMail.From = new MailAddress("vancanfrance@gmail.com");

                // Add recipient email address, please change it to yours
                oMail.To.Add(new MailAddress(toMail));

                // Set email subject and email body text
                oMail.Subject = toSubject;
                oMail.TextBody = toMessage;

                // Gmail SMTP server
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // User and password for ESMTP authentication           
                oServer.User = "vancanfrance@gmail.com";
                oServer.Password = "123123fv";

                // Enable TLS connection on 25 port, please add this line
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                await oSmtp.SendMailAsync(oServer, oMail);
                Result = "Email was sent successfully!";
            }
            catch (Exception ep)
            {
                Result = String.Format("Failed to send email with the following error: {0}", ep.Message);
            }

            // Display Result by Diaglog box
            Windows.UI.Popups.MessageDialog dlg = new
                Windows.UI.Popups.MessageDialog(Result);

            await dlg.ShowAsync();



        }
    }
}