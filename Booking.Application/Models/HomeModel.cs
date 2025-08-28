namespace Booking.Application.Models;

public record HomeModel(int Id, string Name, HashSet<DateTime> availableSlots);