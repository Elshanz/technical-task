using Booking.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.Application;

public static class Startup
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IHomeService, HomeService>();
    }
}