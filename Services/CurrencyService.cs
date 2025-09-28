using Currency_Exchange.Models;
using Currency_Exchange.Exceptions;
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
            var url = $"https://data.fixer.io/api/symbols?access_key=0a194f278518d59ff64363cd7e3f9be";
            var response = await _httpClient.GetAsync(url);
            //response.EnsureSuccessStatusCode();
            //Console.WriteLine(response.Content.ReadAsStringAsync());
            var responseJson = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responseJson);l
            var json = JsonSerializer.Deserialize<FixerCurrenciesMapResponse>(responseJson);
            if (!json.success)
            {
                throw new ExternalApiException(
                    json.Error?.Info ?? "Unknown Fixer error",
                    json.Error?.Code);
            }
            return json;
        }
    }
}
