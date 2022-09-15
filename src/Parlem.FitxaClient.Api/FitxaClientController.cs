namespace Parlem.FitxaClient.Api
{
    using Application.Models;
    using Microsoft.AspNetCore.Mvc;

    public class FitxaClientController : ControllerBase
    {
        public FitxaClientController()
        {

        }

        public ActionResult<ClientDto> Get(long clientId)
        {
            return Ok(new ClientDto(555555, "nif", "11223344E", "it@parlem.com", 11111, "Enriqueta", "Parlem", 668668668));
        }
    }
}