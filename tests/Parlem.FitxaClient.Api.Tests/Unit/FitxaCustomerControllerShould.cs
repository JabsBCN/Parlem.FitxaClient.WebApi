namespace Parlem.FitxaClient.Api.Tests.Unit
{
    using Application.Models;
    using AutoFixture;
    using Microsoft.AspNetCore.Mvc;
    using NSubstitute.ReturnsExtensions;
    using Parlem.FitxaClient.Application.Contracts;
    using System.Net;

    public class FitxaCustomerControllerShould
    {
        private const long CUSTOMER_ID = 11111;
        private readonly IGetCustomerDetails getCustomerDetails;

        public FitxaCustomerControllerShould()
        {
            getCustomerDetails = Substitute.For<IGetCustomerDetails>();
        }

        [Fact]
        public void RetrieveOK()
        {
            //Arrange
            var fitxaClientController = new CustomerController(getCustomerDetails);
            var fixture = new Fixture();
            var customer = fixture.Create<CustomerDto>();
            getCustomerDetails.GetById(CUSTOMER_ID).Returns(customer);

            //Act
            var result = fitxaClientController.Get(CUSTOMER_ID);

            //Assert
            result.Should().BeOfType<ActionResult<CustomerDto>>();
            result.Result.Should().BeOfType<OkObjectResult>().Which.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        public void RetrieveNotFoundWhenCustomerNotExists()
        {
            //Arrange
            var fitxaClientController = new CustomerController(getCustomerDetails);
            getCustomerDetails.GetById(CUSTOMER_ID).ReturnsNull();

            //Act
            var result = fitxaClientController.Get(CUSTOMER_ID).Result;

            //Assert
            result.Should().BeOfType<NotFoundResult>().Which.StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }
    }
}