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
               Name = "Cozy Mountain Cabin",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 15),
                   new DateTime(2025, 07, 16),
                   new DateTime(2025, 07, 17),
                   new DateTime(2025, 07, 20),
                   new DateTime(2025, 07, 21)
               }
           },
           new Home
           {
               Id = 2,
               Name = "Seaside Villa",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 17),
                   new DateTime(2025, 07, 18),
                   new DateTime(2025, 07, 19),
                   new DateTime(2025, 07, 25),
                   new DateTime(2025, 07, 26)
               }
           },
           new Home
           {
               Id = 3,
               Name = "Urban Loft",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 10),
                   new DateTime(2025, 07, 11),
                   new DateTime(2025, 07, 12),
                   new DateTime(2025, 07, 13),
                   new DateTime(2025, 07, 14)
               }
           },
           new Home
           {
               Id = 4,
               Name = "Countryside Cottage",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 15),
                   new DateTime(2025, 07, 16),
                   new DateTime(2025, 07, 22),
                   new DateTime(2025, 07, 23),
                   new DateTime(2025, 07, 24)
               }
           },
           new Home
           {
               Id = 5,
               Name = "Luxury Penthouse",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 18),
                   new DateTime(2025, 07, 19),
                   new DateTime(2025, 07, 20),
                   new DateTime(2025, 07, 27),
                   new DateTime(2025, 07, 28)
               }
           },
           new Home
           {
               Id = 6,
               Name = "Forest Retreat",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 12),
                   new DateTime(2025, 07, 13),
                   new DateTime(2025, 07, 14),
                   new DateTime(2025, 07, 15),
                   new DateTime(2025, 07, 29),
                   new DateTime(2025, 07, 30)
               }
           },
           new Home
           {
               Id = 7,
               Name = "Beach House",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 16),
                   new DateTime(2025, 07, 17),
                   new DateTime(2025, 07, 21),
                   new DateTime(2025, 07, 22),
                   new DateTime(2025, 07, 31)
               }
           },
           new Home
           {
               Id = 8,
               Name = "Historic Mansion",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 11),
                   new DateTime(2025, 07, 12),
                   new DateTime(2025, 07, 19),
                   new DateTime(2025, 07, 20),
                   new DateTime(2025, 07, 26),
                   new DateTime(2025, 07, 27)
               }
           },
           new Home
           {
               Id = 9,
               Name = "Modern Apartment",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 13),
                   new DateTime(2025, 07, 14),
                   new DateTime(2025, 07, 15),
                   new DateTime(2025, 07, 23),
                   new DateTime(2025, 07, 24),
                   new DateTime(2025, 07, 25)
               }
           },
           new Home
           {
               Id = 10,
               Name = "Lakeside Lodge",
               AvailableSlots = new HashSet<DateTime>
               {
                   new DateTime(2025, 07, 10),
                   new DateTime(2025, 07, 11),
                   new DateTime(2025, 07, 17),
                   new DateTime(2025, 07, 18),
                   new DateTime(2025, 07, 28),
                   new DateTime(2025, 07, 29),
                   new DateTime(2025, 07, 30)
               }
           }
        };
    }
}