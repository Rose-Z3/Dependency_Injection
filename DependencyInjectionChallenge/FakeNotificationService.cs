using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class FakeNotificationService : INotificationService
    {
        // Public list to allow verification/assertions in step 6
        public List<string> SavedMessages { get; } = new List<string>();

        public void Send(string to, string msg)
        {
            string record = $"To: {to}, Msg: {msg}";
            SavedMessages.Add(record);
            Console.WriteLine($"[Fake Notification Service] {record}");
        }
    }
}
