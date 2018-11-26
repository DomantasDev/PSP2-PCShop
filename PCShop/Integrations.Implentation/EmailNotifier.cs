using Integrations.Contracts;
using Models.Contracts;
using System;

namespace Integrations.Implentation
{
    public class EmailNotifier : INotifier
    {
        public void Notify(Client client, string message)
        {
            Console.WriteLine($"Sends an email to {client.Email} message: {message}");
        }
    }
}
