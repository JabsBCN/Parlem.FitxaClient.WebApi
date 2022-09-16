using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Domain.Services
{
    public interface ICustomerService
    {
        Customer Create(long id, string docType, string docNum, string email, long customerId, string givenName, string familyName1, long phone);
    }
}
