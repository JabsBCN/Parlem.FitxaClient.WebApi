namespace Parlem.FitxaClient.Application.Models
{
    public class ProductDto
    {
        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string ProductTypeName { get; private set; }
        public long NumeracioTerminal { get; private set; }
        public DateTime SoldAt { get; private set; }
        public string CustomerId { get; private set; }

        public ProductDto(long id, string productName, string productTypeName, long numeracioTerminal, DateTime soldAt, string customerId)
        {
            Id = id;
            ProductName = productName;
            ProductTypeName = productTypeName;
            NumeracioTerminal = numeracioTerminal;
            SoldAt = soldAt;
            CustomerId = customerId;
        }
    }
}
