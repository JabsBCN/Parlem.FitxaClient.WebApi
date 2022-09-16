using Parlem.FitxaClient.Application.Models;

namespace Parlem.FitxaClient.Application.Contracts
{
    public interface IGetCustomerProducts
    {
        IEnumerable<ProductDto> GetByCustomerId(long customerId);
    }
}
