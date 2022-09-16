using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Infrastructure.Contracts;
using Newtonsoft.Json;

namespace Parlem.FitxaClient.Infrastructure.Implementations
{
    public class ClientRepository : IClientRepository
    {
        public Client GetClientById(long id)
        {
            var clients = ReadClientsFromStorage();

            return clients.First<Client>(client => client.Id == id);

        }
            
        private IEnumerable<Client> ReadClientsFromStorage()
        {
            var clientsJsonContent = File.ReadAllText("../Parlem.FitxaClient.Infrastructure/Data/clients.json");

            if (string.IsNullOrEmpty(clientsJsonContent)) return new List<Client>();

            return JsonConvert.DeserializeObject<List<Client>>(clientsJsonContent);

        }
    }
}
