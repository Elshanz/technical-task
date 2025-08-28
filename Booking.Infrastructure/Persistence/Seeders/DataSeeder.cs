using Booking.Domain.Entities;

namespace Booking.Infrastructure.Persistence.Seeders;

public static class DataSeeder
{
    public static List<Home> SeedHomes()
    {
        return new List<Home>
        {
            new Home
            {
                Id = 1,
                Name = "Home 1",
                AvailableSlots = new List<DateTime>
                {
                    new DateTime(2025, 07, 15),
                    new DateTime(2025, 07, 16),
                    new DateTime(2025, 07, 17)
                }
            },
            new Home
            {
                Id = 2,
                Name = "Home 2",
                AvailableSlots = new List<DateTime>
                {
                    new DateTime(2025, 07, 17),
                    new DateTime(2025, 07, 18)
                }
            }
        };
    }
}
