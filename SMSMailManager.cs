using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SMSMailManager : MailManager
    {
        public override IMailService CreateMailService(string identifier, string content)
        {
            return new SMSMailSender(identifier, content);
        }

    }
}
