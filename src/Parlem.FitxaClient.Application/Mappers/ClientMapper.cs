namespace Parlem.FitxaClient.Application.Mappers
{
    using Parlem.FitxaClient.Domain.Models;
    using Parlem.FitxaClient.Application.Models;

    public class ClientMapper
    {
        public ClientDto MapFrom(Client client) {
            return new ClientDto(client.Id, client.DocType, client.DocNum, client.Email, client.CustomerId, client.GivenName, client.FamilyName1, client.Phone);
        }
    }
}
