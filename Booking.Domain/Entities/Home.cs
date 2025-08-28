namespace Booking.Domain.Entities;

public class Home
{
    public int Id { get; set; }
    public string Name { get; set; }
    public HashSet<DateTime> AvailableSlots { get; set; } = new();
}