using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace LeagueExpress.Services
{
    // send emails to anyone
    public class MailService : IMailService
    {

        private string _body = string.Empty;
        private string _emailFrom = string.Empty;
        private string _EmailTo = string.Empty;
        private string _Subject = string.Empty;
        private string _Host = string.Empty;

        public string Body
        {
            get
            {
                return _body;
            }

            set
            {
                _body = value;
            }
        }

        public string EmailFrom
        {
            get
            {
                return _emailFrom;
            }

            set
            {
                _emailFrom = value;
            }
        }

        public string EmailTo
        {
            get
            {
                return _EmailTo;
            }

            set
            {
                _EmailTo = value;
            }
        }

        public string Host
        {
            get
            {
                return _Host;
            }

            set
            {
                _Host = value;
            }
        }

        public string Subject
        {
            get
            {
                return _Subject;
            }

            set
            {
                _Subject = value;
            }
        }

        public void SendEmail()
        {
            MailService createEmail = new MailService();

            MailMessage message = new MailMessage();
            message.From = new MailAddress( _emailFrom);
            message.To.Add(new MailAddress(_EmailTo));
            message.Subject = _Subject;
            message.Body = _body;
            message.Priority = MailPriority.Low;
          

            SmtpClient client = new SmtpClient();
            try
            {
                client.Host = "relay-hosting.secureserver.net";
                client.Send(message);
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            

        }


    }
}