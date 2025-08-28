using Booking.Application.Models;
using Booking.Domain.Interfaces;

namespace Booking.Application.Services;

public class HomeService : IHomeService
{
    private readonly IHomeRepository _homeRepository;

    public HomeService(IHomeRepository homeRepository)
    {
        _homeRepository = homeRepository;
    }

    public async Task<List<HomeModel>> GetAvailableHomes(DateTime from, DateTime to)
    {
        var homes = await _homeRepository.GetAvailableHomes(from, to);

        return homes.Select(h => new HomeModel(h.Id, h.Name, h.AvailableSlots)).ToList();
    }
}