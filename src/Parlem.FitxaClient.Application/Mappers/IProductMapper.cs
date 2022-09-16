using Parlem.FitxaClient.Application.Models;
using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Application.Mappers
{
    public interface IProductMapper
    {
        IEnumerable<ProductDto> MapFrom(IEnumerable<Product> customer);
    }
}
