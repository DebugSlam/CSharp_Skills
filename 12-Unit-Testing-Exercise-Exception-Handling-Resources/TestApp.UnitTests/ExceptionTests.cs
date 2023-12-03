using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Linq;


namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Ivan123";
        string expected = "321navI";
        // Act

        string result = this._exceptions.ArgumentNullReverse(input);



        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        // Act & Assert


        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal totalPrice = 20.00m;

        decimal discount = 10.00m;

        decimal expected = 18.00m;
        // Act 
        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        //Assert
        Assert.AreEqual(expected, result);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 20.00m;

        decimal discount = -10.00m;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);

    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array= new int[] { 23, 5, 64};

        int index = 2;

        int expected = 64;
        // Act 
        int result = this._exceptions.IndexOutOfRangeGetElement(array, index);

        //Assert
        Assert.AreEqual(expected, result);
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = new int[] { 23, 5, 64 };

        int index = 3;
        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());

    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());


    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoged = true;
        string expected = "User logged in.";
        // Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoged);
        // Assert

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoged = false;
        string expected = "User logged in.";

        // Act & Assert
       Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoged), Throws.InstanceOf<InvalidOperationException>());
      
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "23";
        int expected = 23;
        // Act
        int result = this._exceptions.FormatExceptionParseInt(input);
        // Assert

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "wrong input";
        
        // Act
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());

    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "abc", 1 },
            { "cdv", 2 },
            { "gdp", 3 }    
        };
        string key= "cdv";
        int expected = 2;

        // Act

        int result = this._exceptions.KeyNotFoundFindValueByKey(input, key);

        //Assert

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "abc", 1 },
            { "cdv", 2 },
            { "gdp", 3 }
        };
        string key = "fds";
        // Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(input, key), Throws.InstanceOf<KeyNotFoundException>());



    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 4;
        int b = 7;
        int expected = 11;


        // Act

        int result = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
        
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 2000000000;
    


        // Act

       

        // Assert
        Assert.That(() =>
        {
            try
            {
                this._exceptions.OverflowAddNumbers(a, b);
            }
            catch (OverflowException ex)
            {
                throw;

            }

            }, Throws.InstanceOf<OverflowException>());
        }
    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowExceptionBA()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 2000000000;



        // Act



        // Assert
        Assert.That(() =>
        {
            try
            {
                this._exceptions.OverflowAddNumbers(b, a);
            }
            catch (OverflowException ex)
            {
                throw;

            }

        }, Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = -2000000000;
        int b = int.MinValue;



        // Act



        // Assert
        Assert.That(() =>
        {
            try
            {
                this._exceptions.OverflowAddNumbers(a, b);
            }
            catch (OverflowException ex)
            {
                throw;

            }

        }, Throws.InstanceOf<OverflowException>());
    
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowExceptionBA()
    {
        // Arrange
        int a = -2000000000;
        int b = int.MinValue;



        // Act



        // Assert
        Assert.That(() =>
        {
            try
            {
                this._exceptions.OverflowAddNumbers(b, a);
            }
            catch (OverflowException ex)
            {
                throw;

            }

        }, Throws.InstanceOf<OverflowException>());

    }



    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int a = 8;
        int b = 4;
        int expected = 2;


        // Act

        int result = this._exceptions.DivideByZeroDivideNumbers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 8;
        int b = 0;


        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(a, b), Throws.InstanceOf<DivideByZeroException>());

    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = new int[] { 23, 5, 64 };

        int index = 2;

        int expected = collection.Sum(n => n);

        //Act
        int result = this._exceptions.SumCollectionElements(collection, index);

        //Assert

            Assert.AreEqual(expected, result);

    }
    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] collection = null;

        int index = 2;

        //Act & Assert

        Assert.That(()=> this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {

        // Arrange
        int[] collection = new int[] { 23, 5, 64 };

        int index = 5;

        //Act & Assert

        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());

    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>
        {
            { "abc", "1" },
            { "cdv", "2" },
            { "gdp", "3" }
        };
        string key = "cdv";
        int expected = 2;

        // Act

        int result = this._exceptions.GetElementAsNumber(input, key);

        //Assert

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>
        {
            { "abc", "1" },
            { "cdv", "2" },
            { "gdp", "3" }
        };
        string key = "fdsf";


        // Act & Assert

        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>
        {
            { "abc", "fds" },
            { "cdv", "2" },
            { "gdp", "3" }
        };
        string key = "abc";


        // Act & Assert

        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<FormatException>());
    }
}

