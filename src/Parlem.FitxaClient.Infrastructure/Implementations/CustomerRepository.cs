using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Infrastructure.Contracts;
using Newtonsoft.Json;

namespace Parlem.FitxaClient.Infrastructure.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerById(long id)
        {
            var customers = ReadCustomersFromStorage();

            return customers.FirstOrDefault(customer => customer.CustomerId == id);

        }
            
        private IEnumerable<Customer> ReadCustomersFromStorage()
        {
            var customersJsonContent = File.ReadAllText("../Parlem.FitxaClient.Infrastructure/Data/customers.json");

            if (string.IsNullOrEmpty(customersJsonContent)) return new List<Customer>();

            return JsonConvert.DeserializeObject<List<Customer>>(customersJsonContent);

        }
    }
}
