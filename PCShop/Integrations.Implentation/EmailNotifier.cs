using Integrations.Contracts;
using Models.Contracts;
using Models.Contracts.ClientOrder;
using System;
using System.Diagnostics;

namespace Integrations.Implentation
{
    public class EmailNotifier : INotifier
    {
        public void Notify(Client client, string message)
        {
            Trace.WriteLine($"Sends an email to {client.Email} message: {message}");
        }
    }
}
