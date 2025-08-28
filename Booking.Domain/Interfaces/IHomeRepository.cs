using Booking.Domain.Entities;

namespace Booking.Domain.Interfaces;

public interface IHomeRepository
{
    Task<List<Home>> GetAvailableHomes(DateTime from, DateTime to);
}