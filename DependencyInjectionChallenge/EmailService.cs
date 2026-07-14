using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class EmailService : INotificationService
    {
        public void Send(string to, string msg)
        {
            Console.WriteLine($"[Email Sent] To: {to} | Message: {msg}");
        }
    }

    public class SmsService : INotificationService
    {
        public void Send(string to, string msg)
        {
            Console.WriteLine($"[SMS Sent] To: {to} | Message: {msg}");
        }
    }

}
