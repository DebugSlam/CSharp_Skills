using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("abc", 2, "aBcaBc")]
    [TestCase("abc", 3, "aBcaBcaBc")]
    [TestCase("abc", 1, "aBc")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input,
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        //Arrange
        string input = "";
        int repetitionFactor = 2;
        // Act
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor),
            Throws.ArgumentException);}



    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "";
        int repetitionFactor = -2;
        // Act

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor),
            Throws.ArgumentException);
    }


    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "";
        int repetitionFactor = 0;
        // Act
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor),
             Throws.ArgumentException);

    }
}