namespace Desert_Orca.Domain.Tests;
using Desert.Orca.Domain;
using Desert.Orca.Domain.Orders.Item;
using Desert.Orca.Domain.Catalog.Rat;
using Desert.Orca.Domain.Catalog;
using Desert.Orca.Domain.Orders;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        var item = new Item("Name", "Description", "Brand", 10.00m);

        Assert.AreEqual("Name", item.Name);
        Assert.AreEqual("Description", item.Description);
        Assert.AreEqual("Brand", item.Brand);
        Assert.AreEqual(10.00m, item.Price);
    }

    [TestMethod] 
    public void Can_Create_Add_Rating()
    {
        // Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m); 
        var rating = new Rating (5, "Name", "Review");

        // Act
        item.AddRating(rating);

        // Assert 
        Assert.AreEqual(rating, item.Ratings[0]);
    }
}