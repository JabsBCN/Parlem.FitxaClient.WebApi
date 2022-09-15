namespace Parlem.FitxaClient.Api
{
    using Application.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;

    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public ClientController()
        {
        }

        [HttpGet]
        [Route("{id:int}/details")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public ActionResult<ClientDto> Get(long clientId)
        {
            return Ok(new ClientDto(555555, "nif", "11223344E", "it@parlem.com", 11111, "Enriqueta", "Parlem", 668668668));
        }
    }
}