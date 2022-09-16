using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Application.Mappers;
using Parlem.FitxaClient.Application.Models;
using Parlem.FitxaClient.Infrastructure.Contracts;

namespace Parlem.FitxaClient.Application.Implementations
{
    public class GetCustomerProducts : IGetCustomerProducts
    {
        private readonly IProductMapper pruductMapper;
        private readonly IProductRepository productRepository;

        public GetCustomerProducts(IProductRepository productRepository, IProductMapper pruductMapper)
        {
            this.pruductMapper = pruductMapper;
            this.productRepository = productRepository;
        }

        public IEnumerable<ProductDto>? GetByCustomerId(long customerId)
        {
            var products = productRepository.GetCustomerProductsByCustomerId(customerId);

            if (products.Any())
            {
                return pruductMapper.MapFrom(products);
            }

            return null;
        }
    }
}
