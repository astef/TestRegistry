using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRegistry.Controllers;
using Shouldly;
using System.Linq;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class WeatherServiceTests
    {
        [TestMethod]
        public void TestGetForecasts()
        {
            var result = WeatherService.GetForecasts().ToArray();
            result.Length.ShouldBe(5);
            foreach (var f in result)
            {
                f.Date.ShouldBeGreaterThanOrEqualTo(DateTime.Now);
                f.TemperatureC.ShouldBeGreaterThan(-100);
                f.TemperatureC.ShouldBeLessThan(100);
            }
        }
    }
}
