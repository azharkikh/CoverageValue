using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace CoverageValue.Integration.Tests;

public class Tests : WebApplicationFactory<Program>
{
    private readonly HttpClient _httpClient;

    public Tests()
    {
        var factory = new WebApplicationFactory<Program>();
        _httpClient = factory.CreateClient();
    }

    [Test]
    public async Task GetForecast_MustReturn()
    {
        var forecast = await _httpClient.GetAsync("WeatherForecast");
        Assert.That(forecast.IsSuccessStatusCode);
    }
}
