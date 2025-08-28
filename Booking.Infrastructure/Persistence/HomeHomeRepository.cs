using System.Collections.Concurrent;
using Booking.Domain.Entities;
using Booking.Domain.Interfaces;
using Booking.Infrastructure.Persistence.Seeders;

namespace Booking.Infrastructure.Persistence;

public class HomeHomeRepository : IHomeRepository
{
    private readonly ConcurrentDictionary<int, Home> _homes;

    public HomeHomeRepository()
    {
        var homes = DataSeeder.SeedHomes().ToDictionary(h => h.Id);
        _homes = new ConcurrentDictionary<int, Home>(homes);
    }
    
    public Task<List<Home>> GetAvailableHomes(DateTime from, DateTime to)
    {
        var requiredDates = new List<DateTime>();
        for (var date = from; date <= to; date = date.AddDays(1))
        {
            requiredDates.Add(date);
        }
        
        var result = _homes.Values
            .AsParallel()
            .Where(home => requiredDates.All(date => home.AvailableSlots.Contains(date)))
            .ToList();

        return Task.FromResult(result);
    }
}