namespace Parlem.FitxaClient.Api
{
    using Application.Models;
    using Microsoft.AspNetCore.Mvc;
    using Parlem.FitxaClient.Application.Contracts;
    using System.Net;

    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IGetClientDetails getClientDetails;

        public ClientController(IGetClientDetails getClientDetails)
        {
            this.getClientDetails = getClientDetails;
        }

        [HttpGet]
        [Route("{clientId:long}/details")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public ActionResult<ClientDto> Get(long clientId)
        {
            return Ok(getClientDetails.GetById(clientId));
        }
    }
}