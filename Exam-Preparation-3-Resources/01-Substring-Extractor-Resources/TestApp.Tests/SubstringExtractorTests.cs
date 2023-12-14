using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        //arrange
        string input = "Hello world";
        string startMarker = "e";
        string endMarker = "d";

        //act

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //assert

        Assert.That(result, Is.EqualTo("llo worl"));

    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        //arrange
        string input = "Hello world";
        string startMarker = "ff";
        string endMarker = "ld";

        //act

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //assert

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        //arrange
        string input = "Hello world";
        string startMarker = "He";
        string endMarker = "poe";

        //act

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //assert

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        //arrange
        string input = "Hello world";
        string startMarker = "Fuc";
        string endMarker = "poe";

        //act

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //assert

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        //arrange
        string input = "";
        string startMarker = "Fuc";
        string endMarker = "poe";

        //act

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //assert

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        //arrange
        string input = "Fucoritopoe";
        string startMarker = "Fuc";
        string endMarker = "corit";

        //act

        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //assert

        Assert.That(result, Is.EqualTo("Substring not found"));
    }
}
