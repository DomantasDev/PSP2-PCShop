using Models.Contracts;
using Models.Contracts.ClientOrder;
using System;

namespace Integrations.Contracts
{
    public interface INotifier
    {
        void Notify(Client client, string message);
    }
}
