using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;

namespace Currency_Exchange.Models
{
    public class Currency
    {
        
    }

    public class ExchangeResponse
    {
        public CurrencyItem FromCurrency { get; set; }
        public CurrencyItem ToCurrency { get; set; }
        public double ExchangeRate { get; set; }
        public double Amount { get; set; }
        public double ConvertedAmount { get; set; }
        public string FormattedAmount { get; set; }
        public string FormattedConvertedAmount { get; set; }
        //public double ChangePercentage { get; set; }
        public CalculationInfo Calculation { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Source { get; set; }
        public bool Success { get; set; }

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

        public void MapToMetadata()
        {

            if (CurrencyMetadata.Currencies.ContainsKey(this.Code))
            {
                var metadata = CurrencyMetadata.Currencies[this.Code];

                this.Code = metadata.Code;
                this.Name = metadata.Name; 
                this.Symbol = metadata.Symbol;
                this.Country = metadata.Country;
                this.IsMajor = metadata.IsMajor;
                this.IsActive = true;
            }
            
        }
    }

    public class CalculationInfo
    {
        public string Formula { get; set; }
        public bool RoundingApplied { get; set; }
        public int Precision { get; set; }
    }


    public class FixerCurrenciesMapResponse
    {
        [JsonPropertyName("success")]
        public bool success { get; set; }


        [JsonPropertyName("symbols")]
        public Dictionary<string, string> Symbols { get; set; } = new();

        [JsonPropertyName("error")]
        public ApiError Error { get; set; }

        public CurrenciesResponse ToCurrenciesResponse()
        {
            var currencyItems = this.Symbols.Select(s => new CurrencyItem
            {
                Code = s.Key,
                Name = s.Value,
                Symbol = "",
                Country = "",
                IsActive = true,
                IsMajor = false
            }).ToList();

            foreach (CurrencyItem currencyItem in currencyItems)
            {
                currencyItem.MapToMetadata();
            }

            return new CurrenciesResponse
            {
                Currencies = currencyItems,
                TotalCount = currencyItems.Count,
                MajorCurrencies = currencyItems.Count(c => c.IsMajor),
                LastUpdated = DateTime.UtcNow,
                Success = true
            };
        }
    }

    public class FixerExchangeResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("query")]
        public QueryInfo Query { get; set; }

        [JsonPropertyName("info")]
        public InfoInfo Info { get; set; }

        [JsonPropertyName("historical")]
        public string Historical { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("result")]
        public double Result { get; set; }

        [JsonPropertyName("error")]
        public ApiError Error { get; set; }
    }

    public class QueryInfo
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }
    }

    public class InfoInfo
    {
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("rate")]
        public double Rate { get; set; }
    }

    public class ApiError
    {
        [JsonPropertyName("info")]
        public string Info { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }
    }


    public class ExchangeRateApiResponse
    {
        [JsonPropertyName("result")]
        public string Result { get; set; }

        //[JsonPropertyName("documentation")]
        //public string Documentation { get; set; }

        //[JsonPropertyName("terms_of_use")]
        //public string TermsOfUse { get; set; }

        [JsonPropertyName("time_last_update_unix")]
        public long TimeLastUpdateUnix { get; set; }

        [JsonPropertyName("time_last_update_utc")]
        public string TimeLastUpdateUtc { get; set; }

        [JsonPropertyName("time_next_update_unix")]
        public long TimeNextUpdateUnix { get; set; }

        [JsonPropertyName("time_next_update_utc")]
        public string TimeNextUpdateUtc { get; set; }

        [JsonPropertyName("base_code")]
        public string BaseCode { get; set; }

        [JsonPropertyName("target_code")]
        public string TargetCode { get; set; }

        [JsonPropertyName("conversion_rate")]
        public double ConversionRate { get; set; }

        [JsonPropertyName("conversion_result")]
        public double ConversionResult { get; set; }

        public ExchangeResponse ToExchangeResponse()
        {
            CurrencyItem fromCurrency = new CurrencyItem {
                Code = this.BaseCode
            };

            CurrencyItem toCurrency = new CurrencyItem
            {
                Code = this.TargetCode
            };

            fromCurrency.MapToMetadata();
            toCurrency.MapToMetadata();

            int amount = (int)Math.Round(this.ConversionResult/this.ConversionRate);

            return new ExchangeResponse
            {
                FromCurrency = fromCurrency,
                ToCurrency = toCurrency,
                ExchangeRate = this.ConversionRate,
                Amount = amount,
                ConvertedAmount = this.ConversionResult,
                FormattedAmount = $"{amount} {fromCurrency.Code}",
                FormattedConvertedAmount = $"{this.ConversionResult:0.00} {toCurrency.Code}",
                Calculation = new CalculationInfo
                {
                    Formula = $"{amount} {fromCurrency.Code} * {this.ConversionRate} = {this.ConversionResult} {toCurrency.Code}",
                    RoundingApplied = false,
                    Precision = BitConverter.GetBytes(decimal.GetBits((decimal)this.ConversionRate)[3])[2]
                },
                LastUpdated = DateTime.UtcNow,
                Source = "ExchangeRate-API",
                Success = this.Result == "success"
            };
        }
    }

}


