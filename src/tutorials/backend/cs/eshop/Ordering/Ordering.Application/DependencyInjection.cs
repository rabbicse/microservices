using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Application.Common.Behaviours;
using System.Globalization;
using System.Reflection;

namespace Ordering.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            // Configure mediatR
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                //cfg.RegisterServicesFromAssemblyContaining(typeof(Assembly.GetExecutingAssembly()));

                //cfg.AddOpenBehavior(typeof(LoggingBehavior<,>));
                //cfg.AddOpenBehavior(typeof(ValidatorBehavior<,>));
                //cfg.AddOpenBehavior(typeof(TransactionBehavior<,>));
            });
            return services;
        }
    }
}
