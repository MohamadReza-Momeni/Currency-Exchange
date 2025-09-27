using Currency_Exchange.Models;
//using Newtonsoft.Json;
using System.Text.Json;

namespace Currency_Exchange.Services
{
    public interface ICurrencyService
    {
        Task<FixerCurrenciesMapResponse> GetCurrenciesList();
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
        public async Task<FixerCurrenciesMapResponse> GetCurrenciesList()
        {
            try {
                var url = $"https://data.fixer.io/api/symbols?access_key=0a194f278518d59ff64363cd7e3f9bee";
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var responseJson = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseJson);
                return JsonSerializer.Deserialize<FixerCurrenciesMapResponse>(responseJson);
            }
            catch(HttpRequestException ex)
            {
                throw new InvalidOperationException($"Failed to retrieve currencies list", ex);
            }
            catch(JsonException ex)
            {
                throw new InvalidOperationException($"Failed to parse currencies list", ex);
            }

        }
    }
}
