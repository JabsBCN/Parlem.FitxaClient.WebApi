namespace Parlem.FitxaClient.Api
{
    using Microsoft.AspNetCore.Mvc;

    public class FitxaClientController : ControllerBase
    {
        public FitxaClientController()
        {

        }

        public ActionResult Get(long clientId)
        {
            return Ok();
        }
    }
}