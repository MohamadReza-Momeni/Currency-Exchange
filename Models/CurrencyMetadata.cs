using System.Collections.Generic;

namespace Currency_Exchange.Models
{
    public class CurrencyMetadata
    {
        public static readonly Dictionary<string, CurrencyItem> Currencies = new()
        {
            // Major Currencies
            ["USD"] = new() { Code = "USD", Name = "US Dollar", Symbol = "$", Country = "United States", IsMajor = true },
            ["EUR"] = new() { Code = "EUR", Name = "Euro", Symbol = "€", Country = "European Union", IsMajor = true },
            ["GBP"] = new() { Code = "GBP", Name = "British Pound Sterling", Symbol = "£", Country = "United Kingdom", IsMajor = true },
            ["JPY"] = new() { Code = "JPY", Name = "Japanese Yen", Symbol = "¥", Country = "Japan", IsMajor = true },
            ["CHF"] = new() { Code = "CHF", Name = "Swiss Franc", Symbol = "CHF", Country = "Switzerland", IsMajor = true },
            ["CAD"] = new() { Code = "CAD", Name = "Canadian Dollar", Symbol = "C$", Country = "Canada", IsMajor = true },
            ["AUD"] = new() { Code = "AUD", Name = "Australian Dollar", Symbol = "A$", Country = "Australia", IsMajor = true },
            ["CNY"] = new() { Code = "CNY", Name = "Chinese Yuan", Symbol = "¥", Country = "China", IsMajor = true },

            // Other Popular Currencies
            ["INR"] = new() { Code = "INR", Name = "Indian Rupee", Symbol = "₹", Country = "India", IsMajor = false },
            ["BRL"] = new() { Code = "BRL", Name = "Brazilian Real", Symbol = "R$", Country = "Brazil", IsMajor = false },
            ["RUB"] = new() { Code = "RUB", Name = "Russian Ruble", Symbol = "₽", Country = "Russia", IsMajor = false },
            ["KRW"] = new() { Code = "KRW", Name = "South Korean Won", Symbol = "₩", Country = "South Korea", IsMajor = false },
            ["MXN"] = new() { Code = "MXN", Name = "Mexican Peso", Symbol = "$", Country = "Mexico", IsMajor = false },
            ["SGD"] = new() { Code = "SGD", Name = "Singapore Dollar", Symbol = "S$", Country = "Singapore", IsMajor = false },
            ["HKD"] = new() { Code = "HKD", Name = "Hong Kong Dollar", Symbol = "HK$", Country = "Hong Kong", IsMajor = false },
            ["NOK"] = new() { Code = "NOK", Name = "Norwegian Krone", Symbol = "kr", Country = "Norway", IsMajor = false },
            ["SEK"] = new() { Code = "SEK", Name = "Swedish Krona", Symbol = "kr", Country = "Sweden", IsMajor = false },
            ["DKK"] = new() { Code = "DKK", Name = "Danish Krone", Symbol = "kr", Country = "Denmark", IsMajor = false },
            ["PLN"] = new() { Code = "PLN", Name = "Polish Zloty", Symbol = "zł", Country = "Poland", IsMajor = false },
            ["CZK"] = new() { Code = "CZK", Name = "Czech Koruna", Symbol = "Kč", Country = "Czech Republic", IsMajor = false },
            ["HUF"] = new() { Code = "HUF", Name = "Hungarian Forint", Symbol = "Ft", Country = "Hungary", IsMajor = false },
            ["ILS"] = new() { Code = "ILS", Name = "Israeli New Shekel", Symbol = "₪", Country = "Israel", IsMajor = false },
            ["ZAR"] = new() { Code = "ZAR", Name = "South African Rand", Symbol = "R", Country = "South Africa", IsMajor = false },
            ["TRY"] = new() { Code = "TRY", Name = "Turkish Lira", Symbol = "₺", Country = "Turkey", IsMajor = false },
            ["AED"] = new() { Code = "AED", Name = "UAE Dirham", Symbol = "د.إ", Country = "United Arab Emirates", IsMajor = false },
            ["SAR"] = new() { Code = "SAR", Name = "Saudi Riyal", Symbol = "﷼", Country = "Saudi Arabia", IsMajor = false },
            ["EGP"] = new() { Code = "EGP", Name = "Egyptian Pound", Symbol = "£", Country = "Egypt", IsMajor = false },
            ["THB"] = new() { Code = "THB", Name = "Thai Baht", Symbol = "฿", Country = "Thailand", IsMajor = false },
            ["MYR"] = new() { Code = "MYR", Name = "Malaysian Ringgit", Symbol = "RM", Country = "Malaysia", IsMajor = false },

            // Additional currencies from JSON
            ["AFN"] = new() { Code = "AFN", Name = "Afghan Afghani", Symbol = "؋", Country = "Afghanistan", IsMajor = false },
            ["ALL"] = new() { Code = "ALL", Name = "Albanian Lek", Symbol = "L", Country = "Albania", IsMajor = false },
            ["AMD"] = new() { Code = "AMD", Name = "Armenian Dram", Symbol = "֏", Country = "Armenia", IsMajor = false },
            ["ANG"] = new() { Code = "ANG", Name = "Netherlands Antillean Guilder", Symbol = "ƒ", Country = "Netherlands Antilles", IsMajor = false },
            ["AOA"] = new() { Code = "AOA", Name = "Angolan Kwanza", Symbol = "Kz", Country = "Angola", IsMajor = false },
            ["ARS"] = new() { Code = "ARS", Name = "Argentine Peso", Symbol = "$", Country = "Argentina", IsMajor = false },
            ["AWG"] = new() { Code = "AWG", Name = "Aruban Florin", Symbol = "ƒ", Country = "Aruba", IsMajor = false },
            ["AZN"] = new() { Code = "AZN", Name = "Azerbaijani Manat", Symbol = "₼", Country = "Azerbaijan", IsMajor = false },
            ["BAM"] = new() { Code = "BAM", Name = "Bosnia-Herzegovina Convertible Mark", Symbol = "KM", Country = "Bosnia and Herzegovina", IsMajor = false },
            ["BBD"] = new() { Code = "BBD", Name = "Barbadian Dollar", Symbol = "$", Country = "Barbados", IsMajor = false },
            ["BDT"] = new() { Code = "BDT", Name = "Bangladeshi Taka", Symbol = "৳", Country = "Bangladesh", IsMajor = false },
            ["BGN"] = new() { Code = "BGN", Name = "Bulgarian Lev", Symbol = "лв", Country = "Bulgaria", IsMajor = false },
            ["BHD"] = new() { Code = "BHD", Name = "Bahraini Dinar", Symbol = ".د.ب", Country = "Bahrain", IsMajor = false },
            ["BIF"] = new() { Code = "BIF", Name = "Burundian Franc", Symbol = "FBu", Country = "Burundi", IsMajor = false },
            ["BMD"] = new() { Code = "BMD", Name = "Bermudan Dollar", Symbol = "$", Country = "Bermuda", IsMajor = false },
            ["BND"] = new() { Code = "BND", Name = "Brunei Dollar", Symbol = "$", Country = "Brunei", IsMajor = false },
            ["BOB"] = new() { Code = "BOB", Name = "Bolivian Boliviano", Symbol = "Bs", Country = "Bolivia", IsMajor = false },
            ["BSD"] = new() { Code = "BSD", Name = "Bahamian Dollar", Symbol = "$", Country = "Bahamas", IsMajor = false },
            ["BTC"] = new() { Code = "BTC", Name = "Bitcoin", Symbol = "₿", Country = "Global", IsMajor = false },
            ["BTN"] = new() { Code = "BTN", Name = "Bhutanese Ngultrum", Symbol = "Nu", Country = "Bhutan", IsMajor = false },
            ["BWP"] = new() { Code = "BWP", Name = "Botswanan Pula", Symbol = "P", Country = "Botswana", IsMajor = false },
            ["BYN"] = new() { Code = "BYN", Name = "New Belarusian Ruble", Symbol = "Br", Country = "Belarus", IsMajor = false },
            ["BYR"] = new() { Code = "BYR", Name = "Belarusian Ruble", Symbol = "Br", Country = "Belarus", IsMajor = false },
            ["BZD"] = new() { Code = "BZD", Name = "Belize Dollar", Symbol = "$", Country = "Belize", IsMajor = false },
            ["CDF"] = new() { Code = "CDF", Name = "Congolese Franc", Symbol = "FC", Country = "Democratic Republic of Congo", IsMajor = false },
            ["CLF"] = new() { Code = "CLF", Name = "Chilean Unit of Account (UF)", Symbol = "UF", Country = "Chile", IsMajor = false },
            ["CLP"] = new() { Code = "CLP", Name = "Chilean Peso", Symbol = "$", Country = "Chile", IsMajor = false },
            ["CNH"] = new() { Code = "CNH", Name = "Chinese Yuan Offshore", Symbol = "¥", Country = "China", IsMajor = false },
            ["COP"] = new() { Code = "COP", Name = "Colombian Peso", Symbol = "$", Country = "Colombia", IsMajor = false },
            ["CRC"] = new() { Code = "CRC", Name = "Costa Rican Colón", Symbol = "₡", Country = "Costa Rica", IsMajor = false },
            ["CUC"] = new() { Code = "CUC", Name = "Cuban Convertible Peso", Symbol = "$", Country = "Cuba", IsMajor = false },
            ["CUP"] = new() { Code = "CUP", Name = "Cuban Peso", Symbol = "$", Country = "Cuba", IsMajor = false },
            ["CVE"] = new() { Code = "CVE", Name = "Cape Verdean Escudo", Symbol = "$", Country = "Cape Verde", IsMajor = false },
            ["DJF"] = new() { Code = "DJF", Name = "Djiboutian Franc", Symbol = "Fdj", Country = "Djibouti", IsMajor = false },
            ["DOP"] = new() { Code = "DOP", Name = "Dominican Peso", Symbol = "$", Country = "Dominican Republic", IsMajor = false },
            ["DZD"] = new() { Code = "DZD", Name = "Algerian Dinar", Symbol = "د.ج", Country = "Algeria", IsMajor = false },
            ["ERN"] = new() { Code = "ERN", Name = "Eritrean Nakfa", Symbol = "Nfk", Country = "Eritrea", IsMajor = false },
            ["ETB"] = new() { Code = "ETB", Name = "Ethiopian Birr", Symbol = "Br", Country = "Ethiopia", IsMajor = false },
            ["FJD"] = new() { Code = "FJD", Name = "Fijian Dollar", Symbol = "$", Country = "Fiji", IsMajor = false },
            ["FKP"] = new() { Code = "FKP", Name = "Falkland Islands Pound", Symbol = "£", Country = "Falkland Islands", IsMajor = false },
            ["GEL"] = new() { Code = "GEL", Name = "Georgian Lari", Symbol = "₾", Country = "Georgia", IsMajor = false },
            ["GGP"] = new() { Code = "GGP", Name = "Guernsey Pound", Symbol = "£", Country = "Guernsey", IsMajor = false },
            ["GHS"] = new() { Code = "GHS", Name = "Ghanaian Cedi", Symbol = "₵", Country = "Ghana", IsMajor = false },
            ["GIP"] = new() { Code = "GIP", Name = "Gibraltar Pound", Symbol = "£", Country = "Gibraltar", IsMajor = false },
            ["GMD"] = new() { Code = "GMD", Name = "Gambian Dalasi", Symbol = "D", Country = "Gambia", IsMajor = false },
            ["GNF"] = new() { Code = "GNF", Name = "Guinean Franc", Symbol = "FG", Country = "Guinea", IsMajor = false },
            ["GTQ"] = new() { Code = "GTQ", Name = "Guatemalan Quetzal", Symbol = "Q", Country = "Guatemala", IsMajor = false },
            ["GYD"] = new() { Code = "GYD", Name = "Guyanaese Dollar", Symbol = "$", Country = "Guyana", IsMajor = false },
            ["HNL"] = new() { Code = "HNL", Name = "Honduran Lempira", Symbol = "L", Country = "Honduras", IsMajor = false },
            ["HRK"] = new() { Code = "HRK", Name = "Croatian Kuna", Symbol = "kn", Country = "Croatia", IsMajor = false },
            ["HTG"] = new() { Code = "HTG", Name = "Haitian Gourde", Symbol = "G", Country = "Haiti", IsMajor = false },
            ["IDR"] = new() { Code = "IDR", Name = "Indonesian Rupiah", Symbol = "Rp", Country = "Indonesia", IsMajor = false },
            ["IMP"] = new() { Code = "IMP", Name = "Manx pound", Symbol = "£", Country = "Isle of Man", IsMajor = false },
            ["IQD"] = new() { Code = "IQD", Name = "Iraqi Dinar", Symbol = "ع.د", Country = "Iraq", IsMajor = false },
            ["IRR"] = new() { Code = "IRR", Name = "Iranian Rial", Symbol = "﷼", Country = "Iran", IsMajor = false },
            ["ISK"] = new() { Code = "ISK", Name = "Icelandic Króna", Symbol = "kr", Country = "Iceland", IsMajor = false },
            ["JEP"] = new() { Code = "JEP", Name = "Jersey Pound", Symbol = "£", Country = "Jersey", IsMajor = false },
            ["JMD"] = new() { Code = "JMD", Name = "Jamaican Dollar", Symbol = "$", Country = "Jamaica", IsMajor = false },
            ["JOD"] = new() { Code = "JOD", Name = "Jordanian Dinar", Symbol = "د.ا", Country = "Jordan", IsMajor = false },
            ["KES"] = new() { Code = "KES", Name = "Kenyan Shilling", Symbol = "KSh", Country = "Kenya", IsMajor = false },
            ["KGS"] = new() { Code = "KGS", Name = "Kyrgystani Som", Symbol = "с", Country = "Kyrgyzstan", IsMajor = false },
            ["KHR"] = new() { Code = "KHR", Name = "Cambodian Riel", Symbol = "៛", Country = "Cambodia", IsMajor = false },
            ["KMF"] = new() { Code = "KMF", Name = "Comorian Franc", Symbol = "CF", Country = "Comoros", IsMajor = false },
            ["KPW"] = new() { Code = "KPW", Name = "North Korean Won", Symbol = "₩", Country = "North Korea", IsMajor = false },
            ["KWD"] = new() { Code = "KWD", Name = "Kuwaiti Dinar", Symbol = "د.ك", Country = "Kuwait", IsMajor = false },
            ["KYD"] = new() { Code = "KYD", Name = "Cayman Islands Dollar", Symbol = "$", Country = "Cayman Islands", IsMajor = false },
            ["KZT"] = new() { Code = "KZT", Name = "Kazakhstani Tenge", Symbol = "₸", Country = "Kazakhstan", IsMajor = false },
            ["LAK"] = new() { Code = "LAK", Name = "Laotian Kip", Symbol = "₭", Country = "Laos", IsMajor = false },
            ["LBP"] = new() { Code = "LBP", Name = "Lebanese Pound", Symbol = "ل.ل", Country = "Lebanon", IsMajor = false },
            ["LKR"] = new() { Code = "LKR", Name = "Sri Lankan Rupee", Symbol = "₨", Country = "Sri Lanka", IsMajor = false },
            ["LRD"] = new() { Code = "LRD", Name = "Liberian Dollar", Symbol = "$", Country = "Liberia", IsMajor = false },
            ["LSL"] = new() { Code = "LSL", Name = "Lesotho Loti", Symbol = "L", Country = "Lesotho", IsMajor = false },
            ["LTL"] = new() { Code = "LTL", Name = "Lithuanian Litas", Symbol = "Lt", Country = "Lithuania", IsMajor = false },
            ["LVL"] = new() { Code = "LVL", Name = "Latvian Lats", Symbol = "Ls", Country = "Latvia", IsMajor = false },
            ["LYD"] = new() { Code = "LYD", Name = "Libyan Dinar", Symbol = "ل.د", Country = "Libya", IsMajor = false },
            ["MAD"] = new() { Code = "MAD", Name = "Moroccan Dirham", Symbol = "د.م.", Country = "Morocco", IsMajor = false },
            ["MDL"] = new() { Code = "MDL", Name = "Moldovan Leu", Symbol = "L", Country = "Moldova", IsMajor = false },
            ["MGA"] = new() { Code = "MGA", Name = "Malagasy Ariary", Symbol = "Ar", Country = "Madagascar", IsMajor = false },
            ["MKD"] = new() { Code = "MKD", Name = "Macedonian Denar", Symbol = "ден", Country = "North Macedonia", IsMajor = false },
            ["MMK"] = new() { Code = "MMK", Name = "Myanma Kyat", Symbol = "K", Country = "Myanmar", IsMajor = false },
            ["MNT"] = new() { Code = "MNT", Name = "Mongolian Tugrik", Symbol = "₮", Country = "Mongolia", IsMajor = false },
            ["MOP"] = new() { Code = "MOP", Name = "Macanese Pataca", Symbol = "MOP$", Country = "Macau", IsMajor = false },
            ["MRU"] = new() { Code = "MRU", Name = "Mauritanian Ouguiya", Symbol = "UM", Country = "Mauritania", IsMajor = false },
            ["MUR"] = new() { Code = "MUR", Name = "Mauritian Rupee", Symbol = "₨", Country = "Mauritius", IsMajor = false },
            ["MVR"] = new() { Code = "MVR", Name = "Maldivian Rufiyaa", Symbol = "Rf", Country = "Maldives", IsMajor = false },
            ["MWK"] = new() { Code = "MWK", Name = "Malawian Kwacha", Symbol = "MK", Country = "Malawi", IsMajor = false },
            ["MZN"] = new() { Code = "MZN", Name = "Mozambican Metical", Symbol = "MT", Country = "Mozambique", IsMajor = false },
            ["NAD"] = new() { Code = "NAD", Name = "Namibian Dollar", Symbol = "$", Country = "Namibia", IsMajor = false },
            ["NGN"] = new() { Code = "NGN", Name = "Nigerian Naira", Symbol = "₦", Country = "Nigeria", IsMajor = false },
            ["NIO"] = new() { Code = "NIO", Name = "Nicaraguan Córdoba", Symbol = "C$", Country = "Nicaragua", IsMajor = false },
            ["NPR"] = new() { Code = "NPR", Name = "Nepalese Rupee", Symbol = "₨", Country = "Nepal", IsMajor = false },
            ["NZD"] = new() { Code = "NZD", Name = "New Zealand Dollar", Symbol = "$", Country = "New Zealand", IsMajor = false },
            ["OMR"] = new() { Code = "OMR", Name = "Omani Rial", Symbol = "﷼", Country = "Oman", IsMajor = false },
            ["PAB"] = new() { Code = "PAB", Name = "Panamanian Balboa", Symbol = "B/.", Country = "Panama", IsMajor = false },
            ["PEN"] = new() { Code = "PEN", Name = "Peruvian Nuevo Sol", Symbol = "S/.", Country = "Peru", IsMajor = false },
            ["PGK"] = new() { Code = "PGK", Name = "Papua New Guinean Kina", Symbol = "K", Country = "Papua New Guinea", IsMajor = false },
            ["PHP"] = new() { Code = "PHP", Name = "Philippine Peso", Symbol = "₱", Country = "Philippines", IsMajor = false },
            ["PKR"] = new() { Code = "PKR", Name = "Pakistani Rupee", Symbol = "₨", Country = "Pakistan", IsMajor = false },
            ["PYG"] = new() { Code = "PYG", Name = "Paraguayan Guarani", Symbol = "₲", Country = "Paraguay", IsMajor = false },
            ["QAR"] = new() { Code = "QAR", Name = "Qatari Rial", Symbol = "﷼", Country = "Qatar", IsMajor = false },
            ["RON"] = new() { Code = "RON", Name = "Romanian Leu", Symbol = "lei", Country = "Romania", IsMajor = false },
            ["RSD"] = new() { Code = "RSD", Name = "Serbian Dinar", Symbol = "дин", Country = "Serbia", IsMajor = false },
            ["RWF"] = new() { Code = "RWF", Name = "Rwandan Franc", Symbol = "FRw", Country = "Rwanda", IsMajor = false },
            ["SBD"] = new() { Code = "SBD", Name = "Solomon Islands Dollar", Symbol = "$", Country = "Solomon Islands", IsMajor = false },
            ["SCR"] = new() { Code = "SCR", Name = "Seychellois Rupee", Symbol = "₨", Country = "Seychelles", IsMajor = false },
            ["SDG"] = new() { Code = "SDG", Name = "South Sudanese Pound", Symbol = "£", Country = "South Sudan", IsMajor = false },
            ["SHP"] = new() { Code = "SHP", Name = "Saint Helena Pound", Symbol = "£", Country = "Saint Helena", IsMajor = false },
            ["SLE"] = new() { Code = "SLE", Name = "Sierra Leonean Leone", Symbol = "Le", Country = "Sierra Leone", IsMajor = false },
            ["SLL"] = new() { Code = "SLL", Name = "Sierra Leonean Leone", Symbol = "Le", Country = "Sierra Leone", IsMajor = false },
            ["SOS"] = new() { Code = "SOS", Name = "Somali Shilling", Symbol = "S", Country = "Somalia", IsMajor = false },
            ["SRD"] = new() { Code = "SRD", Name = "Surinamese Dollar", Symbol = "$", Country = "Suriname", IsMajor = false },
            ["STD"] = new() { Code = "STD", Name = "São Tomé and Príncipe Dobra", Symbol = "Db", Country = "São Tomé and Príncipe", IsMajor = false },
            ["STN"] = new() { Code = "STN", Name = "São Tomé and Príncipe Dobra", Symbol = "Db", Country = "São Tomé and Príncipe", IsMajor = false },
            ["SVC"] = new() { Code = "SVC", Name = "Salvadoran Colón", Symbol = "₡", Country = "El Salvador", IsMajor = false },
            ["SYP"] = new() { Code = "SYP", Name = "Syrian Pound", Symbol = "£", Country = "Syria", IsMajor = false },
            ["SZL"] = new() { Code = "SZL", Name = "Swazi Lilangeni", Symbol = "L", Country = "Eswatini", IsMajor = false },
            ["TJS"] = new() { Code = "TJS", Name = "Tajikistani Somoni", Symbol = "ЅМ", Country = "Tajikistan", IsMajor = false },
            ["TMT"] = new() { Code = "TMT", Name = "Turkmenistani Manat", Symbol = "T", Country = "Turkmenistan", IsMajor = false },
            ["TND"] = new() { Code = "TND", Name = "Tunisian Dinar", Symbol = "د.ت", Country = "Tunisia", IsMajor = false },
            ["TOP"] = new() { Code = "TOP", Name = "Tongan Paʻanga", Symbol = "T$", Country = "Tonga", IsMajor = false },
            ["TTD"] = new() { Code = "TTD", Name = "Trinidad and Tobago Dollar", Symbol = "$", Country = "Trinidad and Tobago", IsMajor = false },
            ["TWD"] = new() { Code = "TWD", Name = "New Taiwan Dollar", Symbol = "NT$", Country = "Taiwan", IsMajor = false },
            ["TZS"] = new() { Code = "TZS", Name = "Tanzanian Shilling", Symbol = "TSh", Country = "Tanzania", IsMajor = false },
            ["UAH"] = new() { Code = "UAH", Name = "Ukrainian Hryvnia", Symbol = "₴", Country = "Ukraine", IsMajor = false },
            ["UGX"] = new() { Code = "UGX", Name = "Ugandan Shilling", Symbol = "USh", Country = "Uganda", IsMajor = false },
            ["UYU"] = new() { Code = "UYU", Name = "Uruguayan Peso", Symbol = "$", Country = "Uruguay", IsMajor = false },
            ["UZS"] = new() { Code = "UZS", Name = "Uzbekistan Som", Symbol = "so'm", Country = "Uzbekistan", IsMajor = false },
            ["VES"] = new() { Code = "VES", Name = "Sovereign Bolivar", Symbol = "Bs.S", Country = "Venezuela", IsMajor = false },
            ["VND"] = new() { Code = "VND", Name = "Vietnamese Dong", Symbol = "₫", Country = "Vietnam", IsMajor = false },
            ["VUV"] = new() { Code = "VUV", Name = "Vanuatu Vatu", Symbol = "VT", Country = "Vanuatu", IsMajor = false },
            ["WST"] = new() { Code = "WST", Name = "Samoan Tala", Symbol = "T", Country = "Samoa", IsMajor = false },
            ["XAF"] = new() { Code = "XAF", Name = "CFA Franc BEAC", Symbol = "FCFA", Country = "Central Africa", IsMajor = false },
            ["XAG"] = new() { Code = "XAG", Name = "Silver (troy ounce)", Symbol = "XAG", Country = "Global", IsMajor = false },
            ["XAU"] = new() { Code = "XAU", Name = "Gold (troy ounce)", Symbol = "XAU", Country = "Global", IsMajor = false },
            ["XCD"] = new() { Code = "XCD", Name = "East Caribbean Dollar", Symbol = "$", Country = "Eastern Caribbean", IsMajor = false },
            ["XCG"] = new() { Code = "XCG", Name = "Caribbean Guilder", Symbol = "ƒ", Country = "Caribbean", IsMajor = false },
            ["XDR"] = new() { Code = "XDR", Name = "Special Drawing Rights", Symbol = "XDR", Country = "IMF", IsMajor = false },
            ["XOF"] = new() { Code = "XOF", Name = "CFA Franc BCEAO", Symbol = "CFA", Country = "West Africa", IsMajor = false },
            ["XPF"] = new() { Code = "XPF", Name = "CFP Franc", Symbol = "₣", Country = "French Pacific", IsMajor = false },
            ["YER"] = new() { Code = "YER", Name = "Yemeni Rial", Symbol = "﷼", Country = "Yemen", IsMajor = false },
            ["ZMK"] = new() { Code = "ZMK", Name = "Zambian Kwacha (pre-2013)", Symbol = "ZK", Country = "Zambia", IsMajor = false },
            ["ZMW"] = new() { Code = "ZMW", Name = "Zambian Kwacha", Symbol = "ZK", Country = "Zambia", IsMajor = false },
            ["ZWL"] = new() { Code = "ZWL", Name = "Zimbabwean Dollar", Symbol = "$", Country = "Zimbabwe", IsMajor = false }
        };

        public static List<CurrencyItem> MapToMetadata(List<CurrencyItem> currencyItems)
        {
            var result = new List<CurrencyItem>();

            foreach (var currencyItem in currencyItems)
            {
                if (Currencies.ContainsKey(currencyItem.Code))
                {
                    var metadata = Currencies[currencyItem.Code];

                    // Create new object with combined data
                    result.Add(new CurrencyItem
                    {
                        Code = metadata.Code,
                        Name = currencyItem.Name, // Keep API name or use metadata.Name
                        Symbol = metadata.Symbol,
                        Country = metadata.Country,
                        IsMajor = metadata.IsMajor,
                        IsActive = metadata.IsActive
                    });
                }
                else
                {
                    // Keep original if no metadata found
                    result.Add(currencyItem);
                }
            }

            return result;
        }
       
        
    }
}

