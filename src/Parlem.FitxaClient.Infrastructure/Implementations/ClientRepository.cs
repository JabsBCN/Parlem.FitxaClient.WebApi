using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Infrastructure.Contracts;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            var clientsFileContent = File.ReadAllText("../Parlem.FitxaClient.Infrastructure/Data/clients.json");

            if (string.IsNullOrEmpty(clientsFileContent)) return new List<Client>();

            return JsonSerializer.Deserialize<Client[]>(clientsFileContent);

        }
    }
}
