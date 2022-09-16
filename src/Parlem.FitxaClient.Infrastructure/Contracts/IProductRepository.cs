using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Infrastructure.Contracts
{
    public  interface IProductRepository
    {
        IEnumerable<Product> GetCustomerProductsByCustomerId(long customerId);
    }
}
