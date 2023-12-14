using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        //arrange
        string name = "oranges";
        double price = 1.50;
        int quantity = 4;
        //act

        this._inventory.AddProduct(name, price, quantity);
        string result = this._inventory.DisplayInventory();
        //assert

        Assert.That(result.Contains($"{name} - Price: ${price:f2} - Quantity: {quantity}"));

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //arrange
        //act

      
        string result = this._inventory.DisplayInventory();
        //assert

        Assert.That(result, Is.EqualTo("Product Inventory:"));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        //arrange
        string name = "oranges";
        double price = 1.50;
        int quantity = 4;
        string name2 = "Bananas";
        double price2 = 10;
        int quantity2 = 100;
        //act

        this._inventory.AddProduct(name, price, quantity);
        this._inventory.AddProduct(name2, price2, quantity2);
        string result = this._inventory.DisplayInventory();
        //assert

        Assert.That(result.Contains("Product Inventory:"));
        Assert.That(result.Contains($"{name} - Price: ${price:f2} - Quantity: {quantity}"));
        Assert.That(result.Contains($"{name2} - Price: ${price2:f2} - Quantity: {quantity2}"));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        //arrange
    
        //act

        var result = this._inventory.CalculateTotalValue();
        //assert

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        //arrange
        string name = "oranges";
        double price = 1.50;
        int quantity = 4;
        string name2 = "Bananas";
        double price2 = 10;
        int quantity2 = 100;

        //act

        this._inventory.AddProduct(name, price, quantity);
        this._inventory.AddProduct(name2, price2, quantity2);

        double result = this._inventory.CalculateTotalValue();
        double expected = price * quantity + price2 * quantity2;
        //assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
