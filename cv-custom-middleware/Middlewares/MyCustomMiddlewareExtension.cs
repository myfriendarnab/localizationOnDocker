using Microsoft.AspNetCore.Builder;

namespace cv_custom_middleware.Middlewares
{
    public static class MyCustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddlewareForLogger
            (this IApplicationBuilder builder)
                => builder.UseMiddleware<MyCustomMiddlewareForLogger>();        
    }
}