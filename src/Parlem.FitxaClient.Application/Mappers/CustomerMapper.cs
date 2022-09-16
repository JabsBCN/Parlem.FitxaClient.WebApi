namespace Parlem.FitxaClient.Application.Mappers
{
    using Parlem.FitxaClient.Domain.Models;
    using Parlem.FitxaClient.Application.Models;

    public class CustomerMapper : ICustomerMapper
    {
        public CustomerDto MapFrom(Customer customer) {
            return new CustomerDto(customer.Id, customer.DocType, customer.DocNum, customer.Email, customer.CustomerId, customer.GivenName, customer.FamilyName1, customer.Phone);
        }
    }
}
