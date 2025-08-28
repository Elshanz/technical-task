using System.Text.Json.Serialization;

namespace Booking.IntegrationTests.Models;

public class Response
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("homes")]
    public List<HomeResponse> Homes { get; set; }
}

public class HomeResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("availableSlots")]
    public HashSet<DateTime> AvailableSlots { get; set; }
}