using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace cv_custom_middleware.Middlewares
{
    public class MyCustomMiddlewareForLogger
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public MyCustomMiddlewareForLogger(RequestDelegate next, ILoggerFactory logger)
        {
            _next = next;
            _logger = logger.CreateLogger("MyCustomMiddlewareForLogger");
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("Middleware executing... before controller", null);
            await _next(httpContext);
            _logger.LogInformation("Middleware executing... after controller", null);
        }
    }
}