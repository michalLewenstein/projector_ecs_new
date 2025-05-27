using Microsoft.Extensions.Options;
using projector_ecs_new.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using projector_ecs_new.Core.Dto;

namespace projector_ecs_new.Service
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                var smtpClient = new SmtpClient(_emailSettings.SmtpHost, _emailSettings.SmtpPort)
                {
                    Credentials = new NetworkCredential(_emailSettings.FromAddress, _emailSettings.Password),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_emailSettings.FromAddress, _emailSettings.SenderName),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                };
                //foreach (var address in to.Split(',', StringSplitOptions.RemoveEmptyEntries))
                //{
                //    var mailMessage1 = new MailMessage
                //    {
                //        From = new MailAddress(_emailSettings.FromAddress),
                //        Subject = subject,
                //        Body = body,
                //        IsBodyHtml = false
                //    };

                //    mailMessage.To.Add(address.Trim());
                //    smtpClient.Send(mailMessage);
                //}
                mailMessage.To.Add(to);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                // לוג או טיפול בשגיאה
                throw new InvalidOperationException("Failed to send email.", ex);
            }
        }
    }
    }
