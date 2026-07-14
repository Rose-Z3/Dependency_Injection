namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService Service = new EmailService();
            OrderProcessor orderProcessorWithEmail = new OrderProcessor(Service);
            orderProcessorWithEmail.ProcessOrder("user@example.com", 101);

            Service = new SmsService();
            OrderProcessor orderProcessorWithSms = new OrderProcessor(Service);
            orderProcessorWithSms.ProcessOrder("+123456789", 102);

            FakeNotificationService fakeService = new FakeNotificationService();
            OrderProcessor testingProcessor = new OrderProcessor(fakeService);
            testingProcessor.ProcessOrder("test_user@test.com", 999);

            // Verification: Verify that the message was saved properly in the list
            if (fakeService.SavedMessages.Count > 0)
            {
                Console.WriteLine("\n[Verification Success]: Notification caught successfully in memory without internet!");
            }
            else
            {
                Console.WriteLine("\n[Verification Failed]: Notification was not recorded.");
            }
        }
    }
}
