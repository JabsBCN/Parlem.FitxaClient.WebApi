using Newtonsoft.Json;
using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Infrastructure.Contracts;

namespace Parlem.FitxaClient.Infrastructure.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetCustomerProductsByCustomerId(long customerId)
        {
            var products = ReadProductsFromStorage();

            return products.Where(customer => customer.CustomerId == customerId);
        }

        private IEnumerable<Product> ReadProductsFromStorage()
        {
            var productsJsonContent = File.ReadAllText("../Parlem.FitxaClient.Infrastructure/Data/products.json");

            if (string.IsNullOrEmpty(productsJsonContent)) return new List<Product>();

            return JsonConvert.DeserializeObject<List<Product>>(productsJsonContent);

        }
    }
}
