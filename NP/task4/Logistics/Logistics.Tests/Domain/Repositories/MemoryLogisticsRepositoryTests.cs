using Logistics.Domain.Models;
using Logistics.Domain.Repositories.Concrete;
using Logistics.Domain.ShippingMembers;
using Logistics.Domain.Transport.Concrete;

namespace Logistics.Tests.Domain.Repositories;

[TestClass]
public class MemoryLogisticsRepositoryTests
{
    [TestMethod]
    public void TestAddShipping_ReturnsAddedShipping()
    {
        MemoryRepository<Shipping> memoryRepository = new();
        
        Shipping shippingToAdd = new (4, 2, new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane());
        
        memoryRepository.Create(shippingToAdd);

        var shippingAdded = memoryRepository.GetById(4);

        Assert.AreEqual(shippingToAdd, shippingAdded);
    }
}