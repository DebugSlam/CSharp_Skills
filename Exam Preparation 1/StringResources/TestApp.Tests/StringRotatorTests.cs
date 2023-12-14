using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //arrange
        string input = string.Empty;
        int startIndex = 5;
        //act

        string result = StringRotator.RotateRight(input, startIndex);
        //assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //arrange
        string input = "Say hello to my little friend";
        int startIndex = 0;
        //act

        string result = StringRotator.RotateRight(input, startIndex);
        //assert
        Assert.That(result, Is.EqualTo("Say hello to my little friend"));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //arrange
        string input = "Say hello to my little friend";
        int startIndex = 5;
        //act

        string result = StringRotator.RotateRight(input, startIndex);
        //assert
        Assert.That(result, Is.EqualTo("riendSay hello to my little f"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //arrange
        string input = "Say hello to my little friend";
        int startIndex = -4;
        //act

        string result = StringRotator.RotateRight(input, startIndex);
        //assert
        Assert.That(result, Is.EqualTo("iendSay hello to my little fr"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //arrange
        string input = "Say hello";
        int startIndex = 10;
        //act

        string result = StringRotator.RotateRight(input, startIndex);
        //assert
        Assert.That(result, Is.EqualTo("oSay hell"));
    }
}
