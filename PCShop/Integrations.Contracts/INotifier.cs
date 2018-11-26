using Models.Contracts;
using System;

namespace Integrations.Contracts
{
    public interface INotifier
    {
        void Notify(Client client, string message);
    }
}
