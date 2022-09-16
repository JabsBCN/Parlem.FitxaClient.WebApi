using System.Text.Json.Serialization;

namespace Parlem.FitxaClient.Domain.Models
{
    public class Product
    {
        [JsonPropertyName("_id")]
        public long Id { get; set; }

        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        [JsonPropertyName("productTypeName")]
        public string ProductTypeName { get; set; }

        [JsonPropertyName("numeracioTerminal")]
        public long NumeracioTerminal { get; set; }

        [JsonPropertyName("soldAt")]
        public DateTime SoldAt { get; set; }

        [JsonPropertyName("customerId")]
        public long CustomerId { get; set; }


        public Product()
        {
        }

        internal Product(long id, string productName, string docNum, string numeracioTerminal, DateTime soldAt, long customerId)
        {
            Id = id;
            ProductName = productName;
            ProductTypeName = docNum;
            NumeracioTerminal = numeracioTerminal;
            SoldAt = soldAt;
            CustomerId = customerId;
        }
    }
}