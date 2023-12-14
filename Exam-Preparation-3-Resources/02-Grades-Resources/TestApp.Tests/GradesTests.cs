using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        //arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            {"Mathe", 4},
            {"geograph", 5},
            {"physik", 3},
            { "bulgar", 6}
        };

        
        //act

        string result = Grades.GetBestStudents(input);
        string expected = "bulgar with average grade 6.00\ngeograph with average grade 5.00\n" +
            "Mathe with average grade 4.00";

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        //arrange
        Dictionary<string, int> input = new Dictionary<string, int>();


        //act

        string result = Grades.GetBestStudents(input);
        string expected = string.Empty;

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        //arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            {"Mathe", 5},
            {"physik", 3},
         
        };


        //act

        string result = Grades.GetBestStudents(input);
        string expected = "Mathe with average grade 5.00\nphysik with average grade 3.00";

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        //arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            {"Mathe", 6},
            {"geograph", 6},
            {"physik", 3},
            { "bulgar", 6}
        };


        //act

        string result = Grades.GetBestStudents(input);
        string expected = "bulgar with average grade 6.00\ngeograph with average grade 6.00\n" +
            "Mathe with average grade 6.00";

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }
}
