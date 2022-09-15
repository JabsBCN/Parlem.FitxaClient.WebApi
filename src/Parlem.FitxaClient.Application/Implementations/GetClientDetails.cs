using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Domain.Services;

namespace Parlem.FitxaClient.Application.Implementations
{
    public class GetClientDetails : IGetClientDetails
    {
        private readonly IClientService clientService;

        public GetClientDetails(IClientService clientService)
        {
            this.clientService = clientService;
        }

        public Client GetById(long id)
        {
            //return clientService.Create();
            throw new NotImplementedException();
        }
    }
}
