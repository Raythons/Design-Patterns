<<<<<<< HEAD:SMSMailSender.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SMSMailSender: IMailService
    {
        public SMSMailSender(string identifier, string content)
        {
            Identifier = identifier;
            Content = content;
        }
        public string Identifier { get; }
        public string Content { get; }

        public void SendMail()
        {
            Console.WriteLine($"Sending Mail To  ${Identifier}  using {{SMS}} Content is : ${Content}");
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class SMSMailSender : IMailService
    {
        public SMSMailSender(string identifier, string content)
        {
            Identifier = identifier;
            Content = content;
        }
        public string Identifier { get; }
        public string Content { get; }

        public void SendMail()
        {
            Console.WriteLine($"Sending Mail To  ${Identifier} Content is : ${Content}");
        }
    }
}
>>>>>>> 543d4c98a1cffeac1116343d2e1582db16edf7d7:Factory/SMSMailSender.cs
