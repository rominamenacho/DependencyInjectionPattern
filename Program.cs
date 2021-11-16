using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            OrderService orderService = new OrderService(new  MailchimpService());
            orderService.EmailService.send("subject 10", "body 10", "mumi123@gmail.com");

            OrderService orderService2 = new OrderService(new SendInBlueService());
            orderService2.EmailService.send("subject 10", "body 10", "mumi123@gmail.com");

            Console.ReadKey();
        }
    }
}
