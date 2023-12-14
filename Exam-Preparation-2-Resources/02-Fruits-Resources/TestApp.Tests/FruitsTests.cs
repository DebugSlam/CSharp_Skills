using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        //arrange
        string input = "orange";
        Dictionary<string, int> fruits = new Dictionary<string, int>
        

        {
            {"banana", 1},
            { "orange", 2},
            {"kiwi", 3}
        };
        //act

        int  result = Fruits.GetFruitQuantity(fruits, input);


        //assert
        Assert.That(result, Is.EqualTo(2));

    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        //arrange
        string input = "tomato";
        Dictionary<string, int> fruits = new Dictionary<string, int>


        {
            {"banana", 1},
            { "orange", 2},
            {"kiwi", 3}
        };
        //act

        int result = Fruits.GetFruitQuantity(fruits, input);


        //assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        //arrange
        string input = "tomato";
        Dictionary<string, int> fruits = new Dictionary<string, int>();
        //act

        int result = Fruits.GetFruitQuantity(fruits, input);


        //assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        //arrange
        string input = "tomato";
        Dictionary<string, int> fruits = null;
        //act

        int result = Fruits.GetFruitQuantity(fruits, input);


        //assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        //arrange
        string input = null;
        Dictionary<string, int> fruits = new Dictionary<string, int>


        {
            {"banana", 1},
            { "orange", 2},
            {"kiwi", 3}
        };
        //act

        int result = Fruits.GetFruitQuantity(fruits, input);


        //assert
        Assert.That(result, Is.EqualTo(0));
    }
}
