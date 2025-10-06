using CoverageValue.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace CoverageValue.Unit.Tests;

public class Tests
{
    [Test]
    public void GetForecast()
    {
        var logger = new Logger<WeatherForecastController>(new LoggerFactory());
        var controller = new WeatherForecastController(logger);

        var wf = controller.Get();
        Assert.That(wf.Count() == 5);
    }
}
