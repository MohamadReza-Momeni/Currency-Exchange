using System.Text.Json.Serialization;

namespace Currency_Exchange.Models
{
    public class Currency
    {
        
    }

    public class CurrenciesResponse
    {
        public List<CurrencyItem> Currencies { get; set; }
        public int TotalCount { get; set; }
        public int MajorCurrencies { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool Success { get; set; }
    }



    public class CurrencyItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public bool IsMajor { get; set; }
    }


    public class FixerCurrenciesMapResponse
    {
        [JsonPropertyName("success")]
        public bool success { get; set; }


        [JsonPropertyName("symbols")]
        public Dictionary<string, string> Symbols { get; set; } = new();

        [JsonPropertyName("error")]
        public ApiError Error { get; set; }
    }

    public class ApiError
    {
        [JsonPropertyName("info")]
        public string Info { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }
    }

}
