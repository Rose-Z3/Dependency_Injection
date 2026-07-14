using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class OrderProcessor
    {
        private readonly INotificationService _notificationService;

        // Constructor Injection
        public OrderProcessor(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void ProcessOrder(string customerContact, int orderId)
        {
            Console.WriteLine($"Processing Order #{orderId}...");

            _notificationService.Send(customerContact, $"Your order #{orderId} has been successfully processed!");
        }
    }
}
