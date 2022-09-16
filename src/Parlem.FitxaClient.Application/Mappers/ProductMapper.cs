namespace Parlem.FitxaClient.Application.Mappers
{
    using Parlem.FitxaClient.Domain.Models;
    using Parlem.FitxaClient.Application.Models;
    using System.Collections.Generic;

    public class ProductMapper : IProductMapper
    {
        public IEnumerable<ProductDto> MapFrom(IEnumerable<Product> products)
        {
            var productsDto = new List<ProductDto>();

            if (products.Any())
            {
                products.ToList().ForEach(product =>
                {
                    productsDto.Add(MapFrom(product));
                });
            }

            return productsDto;
        }

        private ProductDto MapFrom(Product product)
        {
            return new ProductDto(product.Id, product.ProductName, product.ProductTypeName, product.NumeracioTerminal, product.SoldAt, product.CustomerId);
        }
    }
}
