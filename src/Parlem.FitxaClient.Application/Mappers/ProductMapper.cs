namespace Parlem.FitxaClient.Application.Mappers
{
    using Parlem.FitxaClient.Domain.Models;
    using Parlem.FitxaClient.Application.Models;

    public class ProductMapper : IProductMapper
    {
        public ProductDto MapFrom(Product product) {
            return new ProductDto(product.Id, product.ProductName, product.ProductTypeName, product.NumeracioTerminal, product.SoldAt, product.CustomerId);
        }
    }
}
