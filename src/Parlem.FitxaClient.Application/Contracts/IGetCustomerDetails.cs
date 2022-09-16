using Parlem.FitxaClient.Application.Models;

namespace Parlem.FitxaClient.Application.Contracts
{
    public interface IGetCustomerDetails
    {
        CustomerDto GetById(long id);
    }
}
