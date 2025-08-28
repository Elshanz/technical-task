using Booking.Domain.Interfaces;
using Booking.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.IntegrationTests;

public class TestWebApplicationFactory: WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(IHomeRepository));
            if (descriptor != null)
            {
                services.Remove(descriptor);
            }

            services.AddSingleton<IHomeRepository, HomeHomeRepository>();

            var serviceDescriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(Application.Services.IHomeService));
            if (serviceDescriptor != null)
            {
                services.Remove(serviceDescriptor);
            }

            services.AddSingleton<Application.Services.IHomeService, Application.Services.HomeService>();
        });
    }
}