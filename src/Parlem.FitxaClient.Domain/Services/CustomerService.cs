namespace Parlem.FitxaClient.Domain.Services
{
    using Parlem.FitxaClient.Domain.Models;

    public class CustomerService : ICustomerService
    {
        public Customer Create(long id, string docType, string docNum, string email, long customerId, string givenName, string familyName1, long phone)
        {
            return new Customer(id, docType, docNum, email, customerId, givenName, familyName1, phone);
        }        
    }
}
