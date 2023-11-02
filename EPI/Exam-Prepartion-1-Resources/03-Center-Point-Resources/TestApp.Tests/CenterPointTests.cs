using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        //arrange
        double firstPointX = 1;

        double firstPointY = 1;

        double secondPointX = 2;

        double secondPointY = 1;

        //act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        //assert

        Assert.AreEqual(result, "(1, 1)");



    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        //arrange
        double firstPointX = 1;

        double firstPointY = 2;

        double secondPointX = 1;

        double secondPointY = 1;

        //act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        //assert

        Assert.AreEqual(result, "(1, 1)");
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        //arrange
        double firstPointX = 1;

        double firstPointY = 1;

        double secondPointX = 1;

        double secondPointY = 1;

        //act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        //assert

        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        //arrange
        double firstPointX = -1;

        double firstPointY = 1;

        double secondPointX = 2;

        double secondPointY = 1;

        //act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        //assert

        Assert.AreEqual("(-1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        //arrange
        double firstPointX = 1;

        double firstPointY = 1;

        double secondPointX = -1;

        double secondPointY = -1;

        //act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        //assert

        Assert.AreEqual("(-1, -1)", result);
    }
}
