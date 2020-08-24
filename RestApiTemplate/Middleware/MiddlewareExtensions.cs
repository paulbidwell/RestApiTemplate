using Microsoft.AspNetCore.Builder;

namespace RestApiTemplate.Middleware
{
    public static class MiddlewareExtensions
    {
        public static void ConfigureExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}