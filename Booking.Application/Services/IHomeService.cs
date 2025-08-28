using Booking.Application.Models;

namespace Booking.Application.Services;

public interface IHomeService
{
    Task<List<HomeModel>> GetAvailableHomes(DateTime from, DateTime to);
}