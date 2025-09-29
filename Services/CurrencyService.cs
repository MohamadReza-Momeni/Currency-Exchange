using Currency_Exchange.Models;
using Currency_Exchange.Exceptions;
//using Newtonsoft.Json;
using System.Text.Json;

namespace Currency_Exchange.Services
{
    public interface ICurrencyService
    {
        Task<CurrenciesResponse> GetCurrenciesList();
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

            var currencyItems = fixerResponse.Symbols.Select(s => new CurrencyItem
            {
                Code = s.Key,
                Name = s.Value,
                Symbol = "",
                Country = "",
                IsActive = true,
                IsMajor = false
            }).ToList();

            currencyItems = CurrencyMetadata.MapToMetadata(currencyItems);

            var result = new CurrenciesResponse
            {
                Currencies = currencyItems,
                TotalCount = currencyItems.Count,
                MajorCurrencies = currencyItems.Count(c => c.IsMajor),
                LastUpdated = DateTime.UtcNow,
                Success = true
            };

            return result;
        }
    }
}
