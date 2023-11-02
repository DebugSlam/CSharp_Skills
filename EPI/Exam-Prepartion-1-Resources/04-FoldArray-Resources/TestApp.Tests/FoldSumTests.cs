using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{

    [TestCase(new int[] { 1, 2, 3, 4 }, "3 7")]

    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]

    [TestCase(new int[] { 2, 2, 2, 2 }, "4 4")]

    [TestCase(new int[] { 2, 1, 6, 9 }, "3 15")]

    [TestCase(new int[] { 6, 2, 6, 2 }, "8 8")]

    //[TestCase()]
    //[TestCase()]
    //[TestCase()]
    //[TestCase()]

    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        

        //act

        string result = FoldSum.FoldArray(arr);

        //assert

        Assert.AreEqual(expected, result);
    }
}
