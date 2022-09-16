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
        private readonly IGetClientDetails getCustomerDetails;

        public ClientController(IGetClientDetails getClientDetails)
        {
            this.getCustomerDetails = getClientDetails;
        }

        [HttpGet]
        [Route("{customerId:long}/details")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult<ClientDto> Get(long customerId)
        {
            var customer = getCustomerDetails.GetById(customerId);

            if (customer == null)
            {
                return base.NotFound();
            }
            return base.Ok(customer);
        }
    }
}