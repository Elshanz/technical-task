namespace Booking.IntegrationTests;

public class IntegrationTestBase: IClassFixture<TestWebApplicationFactory>
{
    protected readonly HttpClient _client;

    public IntegrationTestBase(TestWebApplicationFactory factory)
    {
        _client = factory.CreateClient();
    }
}