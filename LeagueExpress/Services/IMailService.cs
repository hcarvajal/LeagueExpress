using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueExpress.Services
{
    interface IMailService
    {
        string Body { get; set; }
        string Subject { get; set; }
        string EmailTo { get; set; }
        string EmailFrom { get; set; }
        string Host { get; set; }

        void SendEmail();
    }
}
