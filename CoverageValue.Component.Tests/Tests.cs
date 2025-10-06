using CoverageValue.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace CoverageValue.Component.Tests;

public class Tests
{
    [Test]
    public void ControllerIsDerivedFromControllerBase()
    {
        var logger = new Logger<WeatherForecastController>(new LoggerFactory());
        var controller = new WeatherForecastController(logger);

        Assert.That(controller, Is.InstanceOf<ControllerBase>());
    }
}
