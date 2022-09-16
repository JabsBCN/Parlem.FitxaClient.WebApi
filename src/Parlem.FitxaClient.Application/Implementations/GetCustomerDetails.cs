using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Application.Mappers;
using Parlem.FitxaClient.Application.Models;
using Parlem.FitxaClient.Infrastructure.Contracts;

namespace Parlem.FitxaClient.Application.Implementations
{
    public class GetCustomerDetails : IGetCustomerDetails
    {
        private readonly ICustomerMapper customerMapper;
        private readonly ICustomerRepository customerRepository;

        public GetCustomerDetails(ICustomerMapper customerMapper, ICustomerRepository customerRepository)
        {
            this.customerMapper = customerMapper;
            this.customerRepository = customerRepository;
        }

        public CustomerDto GetById(long id)
        {
            var customer = this.customerRepository.GetCustomerById(id);

            if (customer == null) return null;

            return customerMapper.MapFrom(customer);
        }
    }
}
