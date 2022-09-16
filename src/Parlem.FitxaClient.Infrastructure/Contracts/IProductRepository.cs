using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Infrastructure.Contracts
{
    public  interface IProductRepository
    {
        Product GetCustomerProductsByCustomerId(long customerId);
    }
}
