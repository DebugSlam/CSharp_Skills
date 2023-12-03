using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PlanetTests
{
    // TODO: finish test
    
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        Planet earth = new("Earth", 12742, 149600000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        // Act
        double result = earth.CalculateGravity(mass);

        // Assert

        Assert.AreEqual(expectedGravity, result);

    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        Planet earth = new("Earth", 12742, 149600000, 1);

        // Act
        string expected = "Planet: Earth\nDiameter: 12742 km\n" +
             "Distance from the Sun: 149600000 km\n" +
             "Number of Moons: 1";
       string result = earth.GetPlanetInfo();     

        // Assert

        Assert.AreEqual(expected, result);
    }
}
