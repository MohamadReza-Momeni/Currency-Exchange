using Currency_Exchange.Exceptions;
using System.Net;
using System.Text.Json;

namespace Currency_Exchange.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate requestDelegate, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = requestDelegate;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ExternalApiException ex)
            {
                _logger.LogWarning(ex, "External API error");
                await HandleExceptionAsync(context, ex.ErrorCode switch
                {
                    101 => HttpStatusCode.Unauthorized,
                    104 => (HttpStatusCode)429,
                    _ => HttpStatusCode.BadGateway // 502 for upstream errors
                }, ex.Message);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogWarning(ex, "HttpRequestException");
                await HandleExceptionAsync(context, ex.StatusCode, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Unknown Error");
                await HandleExceptionAsync(context, HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        private static Task HandleExceptionAsync(HttpContext context, HttpStatusCode? statusCode, string message)
        {
            var response = new { error = message };
            var payload = JsonSerializer.Serialize(response);

            context.Response.ContentType = "application/json";
            
            if(statusCode == null) { statusCode = HttpStatusCode.InternalServerError; }

            context.Response.StatusCode = (int)statusCode;

            return context.Response.WriteAsync(payload);
        }
    }
}
