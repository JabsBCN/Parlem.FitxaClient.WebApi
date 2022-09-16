using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Infrastructure.Contracts
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(long customerId);
    }
}
