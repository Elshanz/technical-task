namespace Booking.Application.Models;

public record HomeModel(int Id, string Name, List<DateTime> availableSlots);