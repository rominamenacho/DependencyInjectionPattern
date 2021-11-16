using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    class OrderService
    {
        private IEmailService emailService;

        public IEmailService EmailService {
            get
            {
                return emailService;
            }
        }
        public OrderService(IEmailService _emailService)
        {
            emailService = _emailService;
        }

    }
}
