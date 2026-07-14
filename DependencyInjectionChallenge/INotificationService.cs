using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface INotificationService
    {
        void Send(string to, string msg);
    }
}
