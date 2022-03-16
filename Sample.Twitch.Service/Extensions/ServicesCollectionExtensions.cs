using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Twitch.Service.Extensions
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddMessageBroker(this IServiceCollection services)
        {
            services.AddMediator(m =>
            {
                //m.AddConsumer<SubmitOrderConsumer>();
                //m.AddRequestClient<SubmitOrder>();
                //m.ConfigureMediator((context, mcfg) =>
                //{
                //    mcfg.UseSendFilter(typeof(ValidateOrderFilter<>), context);
                //});
            });

            return services;
        }
    }
}
