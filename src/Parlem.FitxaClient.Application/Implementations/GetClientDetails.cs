using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Domain.Services;
using Parlem.FitxaClient.Infrastructure.Contracts;

namespace Parlem.FitxaClient.Application.Implementations
{
    public class GetClientDetails : IGetClientDetails
    {
        private readonly IClientService clientService;
        private readonly IClientRepository clientRepository;

        public GetClientDetails(IClientService clientService, IClientRepository clientRepository)
        {
            this.clientService = clientService;
            this.clientRepository = clientRepository;
        }

        public Client GetById(long id)
        {
            var client = this.clientRepository.GetClientById(id);

            if (client == null) throw new NullReferenceException();

            return clientService.Create(client.Id, client.DocType, client.DocNum, client.Email, client.CustomerId, client.GivenName, client.FamilyName1, client.Phone);
        }
    }
}
