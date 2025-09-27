using System.Text.Json.Serialization;

namespace Currency_Exchange.Models
{
    public class Currency
    {
        
    }
    public class FixerCurrenciesMapResponse
    {
        //[JsonPropertyName("success")]
        //public bool success { get; set; }

        [JsonPropertyName("symbols")]
        public Dictionary<string, string> Symbols { get; set; } = new();
    }

}
