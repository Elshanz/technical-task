using System.Net;
using System.Text.Json;
using Booking.IntegrationTests.Models;

namespace Booking.IntegrationTests;

public class HomeEndpointTests : IntegrationTestBase
{
    public HomeEndpointTests(TestWebApplicationFactory factory) : base(factory) { }

    [Fact]
    public async Task GetAvailableHomes_ReturnsOk_WhenHomesExist()
    {
        // Arrange
        var startDate = "2025-07-15";
        var endDate = "2025-07-16";
        var url = $"/api/available-homes?startDate={startDate}&endDate={endDate}";

        // Act
        var response = await _client.GetAsync(url);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<Response>(json);

        Assert.Equal("OK", result!.Status);
        Assert.NotEmpty(result.Homes);
    }
    
    [Fact]
    public async Task GetAvailableHomes_ReturnsOkWithEmptyList_WhenNoHomesExist()
    {
        // Arrange
        var startDate = "2099-01-01";
        var endDate = "2099-01-02";
        var url = $"/api/available-homes?startDate={startDate}&endDate={endDate}";

        // Act
        var response = await _client.GetAsync(url);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<Response>(json);

        Assert.Equal("OK", result!.Status);
        Assert.Empty(result.Homes);
    }
}