using Logistics.Domain.Models;

namespace Logistics.Tests.Domain.Models;

[TestClass]
public class ShippingTests
{
    [TestMethod]
    public void TestTooShortRepresentationStringShipping_ReturnsException() =>
        Assert.ThrowsException<IndexOutOfRangeException>(() => 
            new Shipping().Convert(
                "1 Honey 16,5 Sklad_5 Lviv 250 Depot_7 Amsterdam 2000 Oleksandr Kovalenko 34 3".Split()));
    
    [TestMethod]
    public void TestWrongTransportRepresentationStringShipping_ReturnsException() =>
        Assert.ThrowsException<ArgumentException>(() => 
            new Shipping().Convert(
                "1 Honey 16,5 Sklad_5 Lviv 250 Depot_7 Amsterdam 2000 Oleksandr Kovalenko 34 3 road".Split()));
    
    [TestMethod]
    public void TestWrongFormatRepresentationStringShipping_ReturnsException() =>
        Assert.ThrowsException<FormatException>(() => 
            new Shipping().Convert(
                "1 Honey 16.5 Sklad_5 Lviv 250 Depot_7 Amsterdam 2000 Oleksandr Kovalenko 34 3 road".Split()));
}