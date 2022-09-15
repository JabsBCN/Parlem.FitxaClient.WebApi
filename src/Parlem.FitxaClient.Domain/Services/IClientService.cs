using Parlem.FitxaClient.Domain.Models;

namespace Parlem.FitxaClient.Domain.Services
{
    public interface IClientService
    {
        Client Create(long id, string docType, string docNum, string email, long customerId, string givenName, string familyName1, long phone);
    }
}
