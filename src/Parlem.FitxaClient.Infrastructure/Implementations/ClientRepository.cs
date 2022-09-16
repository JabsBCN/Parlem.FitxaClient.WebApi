using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Infrastructure.Contracts;
using Newtonsoft.Json;

namespace Parlem.FitxaClient.Infrastructure.Implementations
{
    public class ClientRepository : IClientRepository
    {
        public Client GetClientById(long id)
        {
            var clients = ReadCustomersFromStorage();

            return clients.FirstOrDefault<Client>(customer => customer.CustomerId == id);

        }
            
        private IEnumerable<Client> ReadCustomersFromStorage()
        {
            var customersJsonContent = File.ReadAllText("../Parlem.FitxaClient.Infrastructure/Data/clients.json");

            if (string.IsNullOrEmpty(customersJsonContent)) return new List<Client>();

            return JsonConvert.DeserializeObject<List<Client>>(customersJsonContent);

        }
    }
}
