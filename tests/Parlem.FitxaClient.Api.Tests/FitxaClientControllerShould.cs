using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Parlem.FitxaClient.Api.Tests
{
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
            result.Should().BeOfType<OkResult>().Which.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }
    }
}