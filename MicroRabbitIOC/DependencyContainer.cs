using MicroRabbit.Bus;
using MicroRabbit.Domain.Core.Bus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
            services.Configure<RabbitMQSettings>( c => configuration.GetSection("RabbitMQSettings"));
        }
    }
}
