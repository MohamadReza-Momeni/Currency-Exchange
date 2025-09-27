using Microsoft.AspNetCore.Mvc;

namespace Currency_Exchange.Controllers
{
    [ApiController]
    [Route("api")]

    public class CurrenciesController : ControllerBase

    {
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns>API status</returns>
        [HttpGet("currencies")]
        public ActionResult<object> Currencies()
        {
            //return Ok(new { currencies = new[] { "USD", "EUR", "GBP", "JPY", "AUD" } });
            return Ok(new { status = "Hi" });
        }

    }

    [ApiController]
    [Route("api")]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns>API status</returns>
        [HttpGet("health")]
        public ActionResult<object> Health()
        {
            return Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
        }
    }
}
