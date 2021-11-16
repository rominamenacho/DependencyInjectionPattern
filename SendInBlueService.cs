using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
   public class SendInBlueService : IEmailService
    {
       public SendInBlueService()
        {
           
        }

        public void send(string subject, string body, string email)
        {
            Console.WriteLine("$Im SendInBlueService sending an email to {0}", subject);
        }
    }
}
