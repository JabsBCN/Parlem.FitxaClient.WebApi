namespace Parlem.FitxaClient.Api.Tests
{
    using Application.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;

    public class FitxaClientControllerShould
    {
        private const long CLIENT_ID = 555555;

        [Fact]
        public void RetrieveOK()
        {
            //Arrange
            var fitxaClientController = new FitxaClientController();

            //Act
            var result = fitxaClientController.Get(CLIENT_ID);

            //Assert
            result.Should().BeOfType<ActionResult<ClientDto>>();
            result.Result.Should().BeOfType<OkObjectResult>().Which.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        public void RetrieveFitxaClient()
        {
            //Arrange
            var fitxaClientController = new FitxaClientController();

            var expectedFitxaClient = new
            {
                Id = 555555,
                DocType = "nif",
                DocNum = "11223344E",
                Email = "it@parlem.com",
                CustomerId = 11111,
                GivenName = "Enriqueta",
                FamilyName1 = "Parlem",
                Phone = 668668668
            };

            //Act
            var result = fitxaClientController.Get(CLIENT_ID).Result;

            //Assert
            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().BeEquivalentTo(expectedFitxaClient);
        }
    }
}