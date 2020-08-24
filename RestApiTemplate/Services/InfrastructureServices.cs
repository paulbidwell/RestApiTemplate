using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using RestApiTemplate.Core;

namespace RestApiTemplate.Services
{
    public static partial class ServiceExtensions
    {
        public static void InfrastructureServices(this IServiceCollection services, Assembly assemblyInfrastructure)
        {
            foreach (var type in assemblyInfrastructure.ExportedTypes.Select(t => t.GetTypeInfo()).Where(t => t.IsClass && !t.IsAbstract))
            {
                var interfaces = type.ImplementedInterfaces.Select(i => i.GetTypeInfo());

                foreach (var handlerType in interfaces.Where(v => v.ImplementedInterfaces.Any(v => v.GetTypeInfo() == typeof(IQuery) || v.GetTypeInfo() == typeof(ICommand))))
                {
                    services.AddTransient(handlerType.AsType(), type.AsType());
                }
            }
        }
    }
}