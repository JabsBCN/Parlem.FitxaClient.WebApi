using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Application.Contracts
{
    public interface IGetCustomerDetails
    {
        Customer GetById(long id);
    }
}
