namespace Parlem.FitxaClient.Api
{
    using Application.Models;
    using Microsoft.AspNetCore.Mvc;
    using Parlem.FitxaClient.Application.Contracts;
    using System.Net;

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IGetCustomerDetails getCustomerDetails;

        public CustomerController(IGetCustomerDetails getCustomerDetails)
        {
            this.getCustomerDetails = getCustomerDetails;
        }

        [HttpGet]
        [Route("{customerId:long}/details")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult<CustomerDto> Get(long customerId)
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