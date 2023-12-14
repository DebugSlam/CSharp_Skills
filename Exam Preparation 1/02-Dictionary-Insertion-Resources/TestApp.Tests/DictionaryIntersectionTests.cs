using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();

        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);
        //assert

        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //arrange
        //arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"baby", 1},
            {"hot",  2},
            {"mad", 3}
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);
        //assert

        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"baby", 1},
            {"hot",  2},
            {"mad", 3}
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            {"lego", 6},
            {"gore6to",  7},
            {"mnogo", 4}
        };

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);
        //assert

        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"baby", 1},
            {"hot",  2},
            {"mad", 3}
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            {"baby", 1},
            {"hot",  2},
            {"mnogo", 4}
        };

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);
        //assert
        Assert.IsTrue(result.ContainsKey("baby"));
        Assert.AreEqual(1, result["baby"]);

        Assert.IsTrue(result.ContainsKey("hot"));
        Assert.AreEqual(2, result["hot"]);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"baby", 1},
            {"hot",  2},
            {"mad", 3}
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            {"baby", 4},
            {"hot",  5},
            {"mnogo", 4}
        };

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);
        //assert
        Assert.IsEmpty(result);
    }
}
