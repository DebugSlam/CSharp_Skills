using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {        
        // Arrange
        string input = "";
        List<string> expected = new();

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string input = "No valid URLs";
        //List<string> expected = new();

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string input = "https://judge.softuni.org";
        List<string> expected = new() { "https://judge.softuni.org" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string input = "https://judge.softuni.org, https://stackoverflow.com";
        List<string> expected = new() { "https://judge.softuni.org", "https://stackoverflow.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string input = "Url is in quotes \"https://stackoverflow.com\"";
        List<string> expected = new() { "https://stackoverflow.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
