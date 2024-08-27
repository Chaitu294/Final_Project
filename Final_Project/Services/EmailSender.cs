using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;

namespace Final_Project.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var FromMail = "raaajroy2233@gmail.com";
            var FromPassword = "vqdnfudejulbwbej";

            var message = new MailMessage();
            message.From = new MailAddress(FromMail);
            message.Subject = subject;
            message.To.Add(email);
            message.Body = $"<html><body>{htmlMessage}</body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FromMail, FromPassword)
            };

            smtpClient.Send(message);
        }
    }
}
