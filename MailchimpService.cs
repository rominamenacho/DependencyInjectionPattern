using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
   public class MailchimpService:IEmailService
    {
       public MailchimpService()
        {
           
        }

        public void send(string subject, string body, string email)
        {
            Console.WriteLine("$Im MailChipService sending an email to {0}", subject);
        }
    }
}
