namespace Parlem.FitxaClient.Application.Tests.Integration
{
    using FluentAssertions;
    using NSubstitute;
    using Parlem.FitxaClient.Application.Mappers;
    using Parlem.FitxaClient.Application.Models;
    using Parlem.FitxaClient.Domain.Services;

    public class CustomerMapperShould
    {
        [Fact]
        public void MapCustomer()
        {
            //Arrange
            var clientMapper = new CustomerMapper();
            var customerService = Substitute.For<CustomerService>();
            var customer = customerService.Create(555555, "nif", "11223344E", "it@parlem.com", 11111, "Enriqueta", "Parlem", 668668668);
            var expectedCustomerDto = new CustomerDto(555555, "nif", "11223344E", "it@parlem.com", 11111, "Enriqueta", "Parlem", 668668668);

            //Action
            var customerDto = clientMapper.MapFrom(customer);

            //Assert
            customerDto.Should().BeEquivalentTo(expectedCustomerDto);
        }
    }
}