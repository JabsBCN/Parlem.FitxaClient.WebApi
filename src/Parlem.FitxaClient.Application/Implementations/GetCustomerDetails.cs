using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Domain.Models;
using Parlem.FitxaClient.Domain.Services;
using Parlem.FitxaClient.Infrastructure.Contracts;

namespace Parlem.FitxaClient.Application.Implementations
{
    public class GetCustomerDetails : IGetCustomerDetails
    {
        private readonly ICustomerService customerService;
        private readonly ICustomerRepository customerRepository;

        public GetCustomerDetails(ICustomerService customerService, ICustomerRepository customerRepository)
        {
            this.customerService = customerService;
            this.customerRepository = customerRepository;
        }

        public Customer GetById(long id)
        {
            var customer = this.customerRepository.GetCustomerById(id);

            if (customer == null) return null;

            return customerService.Create(customer.Id, customer.DocType, customer.DocNum, customer.Email, customer.CustomerId, customer.GivenName, customer.FamilyName1, customer.Phone);
        }
    }
}
