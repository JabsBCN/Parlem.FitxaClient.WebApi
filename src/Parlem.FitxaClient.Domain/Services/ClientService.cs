namespace Parlem.FitxaClient.Domain.Services
{
    using Parlem.FitxaClient.Domain.Models;

    public class ClientService : IClientService
    {
        public Client Create(long id, string docType, string docNum, string email, long customerId, string givenName, string familyName1, long phone)
        {
            return new Client(id, docType, docNum, email, customerId, givenName, familyName1, phone);
        }        
    }
}
