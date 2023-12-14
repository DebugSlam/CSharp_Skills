using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        //arrange
        string input = "";
        //act
        string[] result = CsvParser.ParseCsv(input);

        string[] expected = {};
        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //arrange
        string input = "haha";
        //act
        string[] result = CsvParser.ParseCsv(input);

        string[] expected = new string[] { "haha" };
        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //arrange
        string input = "haha,woman,man,child";
        //act
        string[] result = CsvParser.ParseCsv(input);

        string[] expected = new string[] { "haha", "woman", "man", "child" };
        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        //arrange
        string input = "   haha    , woman      ,man ,   child ";
        //act
        string[] result = CsvParser.ParseCsv(input);

        string[] expected = new string[] { "haha", "woman", "man", "child" };
        //assert

        Assert.That(result, Is.EqualTo(expected));
    }
}
