using Parlem.FitxaClient.Application.Models;
using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Application.Mappers
{
    public interface IProductMapper
    {
        ProductDto MapFrom(Product customer);
    }
}
