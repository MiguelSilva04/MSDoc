using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "mdoc29694@gmail.com";
            password = "guesilva2004";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            intializeSmtpClient();
        }
    }
}
