using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using System.Threading.Tasks;
using EASendMailRT;




// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Contact : Page
    {
        public Contact()
        {
            this.InitializeComponent();
        }

        private async void SendBtn_Click(object sender, RoutedEventArgs e)
        {

            SendBtn.IsEnabled = false;
            await Send_Email();
            SendBtn.IsEnabled = true;
        }

       

        private async Task Send_Email()
        {
            String Result = "";
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();

                // Set your gmail email address
                oMail.From = new MailAddress("vancanfrance@gmail.com");

                // Add recipient email address, please change it to yours
                oMail.To.Add(new MailAddress("vancanfrance@gmail.com"));

                // Set email subject and email body text
                oMail.Subject = Subject.Text;
                oMail.TextBody = Message.Text;

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
