using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Application.Models;

namespace Parlem.FitxaClient.Application.Implementations
{
    public class GetCustomerProducts : IGetCustomerProducts
    {
        public IEnumerable<ProductDto> GetByCustomerId(long customerId)
        {
            throw new NotImplementedException();
        }
    }
}
