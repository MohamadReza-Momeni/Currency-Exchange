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
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<CurrenciesResponse>> GetCurrencies()
        {
            _logger.LogInformation("Fetching currencies list");
            var currenciesList = await _currencyService.GetCurrenciesList();
            _logger.LogInformation("Fetched currencies list successfully");
            return Ok(currenciesList);

        }

        [HttpGet("exchange/{fromCurrency}/{toCurrency}/{amount}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ExchangeResponse>> GetExchangeAmount(string fromCurrency, string toCurrency, int amount)
        {
            _logger.LogInformation("Fetching currency exchange");
            var exchangeResponse = await _currencyService.GetExchangeResponse(fromCurrency, toCurrency, amount);
            return Ok(exchangeResponse);
        }

        [HttpGet("exchange/{fromCurrency}/{toCurrency}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ExchangeResponse>> GetExchange(string fromCurrency, string toCurrency)
        {
            _logger.LogInformation("Fetching currency exchange");
            var exchangeResponse = await _currencyService.GetExchangeResponse(fromCurrency, toCurrency, 1);
            return Ok(exchangeResponse);
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
