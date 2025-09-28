using Currency_Exchange.Exceptions;
using Currency_Exchange.Models;
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
        /// Get a list of supported currencies
        /// </summary>
        /// <returns>Currencies list</returns>
        [HttpGet("currencies")]
        [ProducesResponseType(typeof(CurrenciesResponse), 200)]

        [ProducesResponseType(500)]
        public async Task<ActionResult<CurrenciesResponse>> Currencies()
        {
            _logger.LogInformation("Fetching currencies list");
            var currenciesList = await _currencyService.GetCurrenciesList();
            _logger.LogInformation("Fetched currencies list successfully");
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
