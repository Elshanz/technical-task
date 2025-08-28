using System.Net;
using Booking.Application.Models;
using Booking.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Endpoints;

public static class HomeEndpoint
{
    private const string TagName = "Home";

    public static void MapHomeEndpoints(this WebApplication app)
    {
        app.MapGet("/api/available-homes",
                async (DateTime startDate, DateTime endDate, [FromServices] IHomeService service) =>
                {
                    var homes = await service.GetAvailableHomes(startDate, endDate);
                    return Results.Ok(new HomeOutputModel(nameof(HttpStatusCode.OK), homes));
                })
            .WithTags(TagName)
            .WithOpenApi(operation =>
            {
                operation.Summary = "Gets all homes available in a given date range";
                operation.Description = "Returns a list of homes available for booking between startDate and endDate.";
                return operation;
            });
    }
}