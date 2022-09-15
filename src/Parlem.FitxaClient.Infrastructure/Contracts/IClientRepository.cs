using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Infrastructure.Contracts
{
    public interface IClientRepository
    {
        Client GetClientById(long id);
    }
}
