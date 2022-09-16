namespace Parlem.FitxaClient.Api
{
    using Application.Models;
    using Microsoft.AspNetCore.Mvc;
    using Parlem.FitxaClient.Application.Contracts;
    using System.Net;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGetCustomerProducts getCustomerProducts;

        public ProductController(IGetCustomerProducts getCustomerProducts)
        {
            this.getCustomerProducts = getCustomerProducts;
        }

        [HttpGet]
        [Route("{customerId:long}/products")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult<IEnumerable<ProductDto>> Get(long customerId)
        {
            var products = getCustomerProducts.GetByCustomerId(customerId);

            if (products == null)
            {
                return base.NotFound();
            }
            return base.Ok(products);
        }
    }
}