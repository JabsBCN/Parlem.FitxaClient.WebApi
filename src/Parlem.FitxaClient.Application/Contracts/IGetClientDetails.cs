using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Application.Contracts
{
    public interface IGetClientDetails
    {
        Client GetById(long id);
    }
}
