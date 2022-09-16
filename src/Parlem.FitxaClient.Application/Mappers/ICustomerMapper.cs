using Parlem.FitxaClient.Application.Models;
using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Application.Mappers
{
    public interface ICustomerMapper
    {
        CustomerDto MapFrom(Customer customer);
    }
}
