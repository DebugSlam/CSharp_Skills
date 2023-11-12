using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] banned = { "fuck", "sow", "mean"};
        string input = "You are awsome women.";

        // Act
        string result = TextFilter.Filter(banned, input);

        // Assert
        Assert.That(result, Is.EqualTo("You are awsome women."));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] banned = { "fuck", "sam"};
        string input = "fuck you mea, sam.";

        // Act
        string result = TextFilter.Filter(banned, input);

        // Assert
        Assert.That(result, Is.EqualTo("**** you mea, ***."));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] banned = {};
        string input = "Fuck you mr anderson.";

        // Act
        string result = TextFilter.Filter(banned, input);

        // Assert
        Assert.That(result, Is.EqualTo("Fuck you mr anderson."));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] banned = { "fuck " };
        string input = "fuck you";

        // Act
        string result = TextFilter.Filter(banned, input);

        // Assert
        Assert.That(result, Is.EqualTo("*****you"));
    }
}
