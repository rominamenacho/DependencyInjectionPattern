using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    interface IEmailService
    {
        void send(string subject, string body, string email);
    }
}
