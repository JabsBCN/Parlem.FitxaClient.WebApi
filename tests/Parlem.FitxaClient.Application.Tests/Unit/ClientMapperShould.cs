namespace Parlem.FitxaClient.Application.Tests.Integration
{
    using FluentAssertions;
    using NSubstitute;
    using Parlem.FitxaClient.Application.Mappers;
    using Parlem.FitxaClient.Application.Models;
    using Parlem.FitxaClient.Domain.Services;

    public class ClientMapperShould
    {
        [Fact]
        public void MapClient()
        {
            //Arrange
            var clientMapper = new ClientMapper();
            var clientservice = Substitute.For<ClientService>();
            var client = clientservice.CreateClient(555555, "nif", "11223344E", "it@parlem.com", 11111, "Enriqueta", "Parlem", 668668668);
            var expectedClientDto = new ClientDto(555555, "nif", "11223344E", "it@parlem.com", 11111, "Enriqueta", "Parlem", 668668668);

            //Action
            var clientDto = clientMapper.MapFrom(client);

            //Assert
            clientDto.Should().BeEquivalentTo(expectedClientDto);
        }
    }
}