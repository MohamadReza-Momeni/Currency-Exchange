using Currency_Exchange.Models;
using Currency_Exchange.Exceptions;
using System.Text.Json;

namespace Currency_Exchange.Services
{
    public interface ICurrencyService
    {
        Task<CurrenciesResponse> GetCurrenciesList();
        Task<ExchangeResponse> GetExchangeResponse(string fromCurrency, string toCurrency, int amount);
    }
    public class CurrencyService : ICurrencyService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _apiKey;

        public CurrencyService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _apiKey = _configuration["FixerMap:Api Key"] ?? throw new ArgumentNullException("API key is missing");
        }
        public async Task<CurrenciesResponse> GetCurrenciesList()
        {
            var url = $"https://data.fixer.io/api/symbols?access_key={_apiKey}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseJson = await response.Content.ReadAsStringAsync();
            var fixerResponse = JsonSerializer.Deserialize<FixerCurrenciesMapResponse>(responseJson,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (fixerResponse is null || !fixerResponse.success)
            {
                throw new ExternalApiException(
                    fixerResponse.Error?.Info ?? "Unknown Fixer error",
                    fixerResponse.Error?.Code);
            }

            return fixerResponse.ToCurrenciesResponse();
        }

        public async Task<ExchangeResponse> GetExchangeResponse(string fromCurrency, string toCurrency, int amount)
        {
            var url = $"https://v6.exchangerate-api.com/v6/19bd0da239a47b55c1750246/pair/{fromCurrency}/{toCurrency}/{amount}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseJson = await response.Content.ReadAsStringAsync();
            var exchangeRateApiResponse = JsonSerializer.Deserialize<ExchangeRateApiResponse>(responseJson,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return exchangeRateApiResponse.ToExchangeResponse();
        }
    }
}
