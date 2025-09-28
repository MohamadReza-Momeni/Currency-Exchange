namespace Currency_Exchange.Exceptions
{
    public class ExternalApiException: Exception
    {
        public int? ErrorCode { get; }
        public ExternalApiException(string message, int? errorcode) : base(message) {
            this.ErrorCode = errorcode;
        }
    }
}
