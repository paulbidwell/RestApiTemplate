using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestApiTemplate.Core;

namespace RestApiTemplate.Services
{
    public static partial class ServiceExtensions
    {
        public static void CoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApiVersioning(options => options.ApiVersionReader = new HeaderApiVersionReader("api-version"));

            services.AddTransient<ICommandFactory>(serviceProvider => new CommandFactory(serviceProvider.GetService));
            services.AddTransient<IQueryFactory>(serviceProvider => new QueryFactory(serviceProvider.GetService));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}