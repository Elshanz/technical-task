using Booking.Domain.Interfaces;
using Booking.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.Infrastructure;

public static class Startup
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IHomeRepository, HomeHomeRepository>();
    }
}