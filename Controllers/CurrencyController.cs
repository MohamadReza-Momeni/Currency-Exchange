using Currency_Exchange.Services;
using Microsoft.AspNetCore.Mvc;

namespace Currency_Exchange.Controllers
{
    [ApiController]
    [Route("api")]

    public class CurrenciesController : ControllerBase

    {
        private readonly ICurrencyService _currencyService;
        private readonly ILogger<CurrenciesController> _logger;

        public CurrenciesController(ICurrencyService currencyService, ILogger<CurrenciesController> logger)
        {
            _currencyService = currencyService;
            _logger = logger;
        }


        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns>API status</returns>
        [HttpGet("currencies")]
        public async Task<ActionResult<Dictionary<string, string>>> Currencies()
        {
            var currenciesList = await _currencyService.GetCurrenciesList();
            return Ok(currenciesList);

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
