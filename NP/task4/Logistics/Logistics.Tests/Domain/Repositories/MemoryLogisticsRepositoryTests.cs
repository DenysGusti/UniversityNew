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
        
        var shippingAdded = memoryRepository.GetAll()[^1];

        Assert.AreEqual(shippingToAdd, shippingAdded);
    }
    
    [TestMethod]
    public void TestEditShipping_ReturnsAddedShipping()
    {
        MemoryRepository<Shipping> memoryRepository = new();
        
        Shipping shippingToAdd = new (4, 2, new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane());
        
        memoryRepository.Create(shippingToAdd);

        Shipping shippingEdited = new (4, 222, new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane());
        
        memoryRepository.Update(shippingEdited);

        Assert.AreEqual(shippingEdited, memoryRepository.GetById(4));
    }
    
    [TestMethod]
    public void TestDeleteShipping_ReturnsLength()
    {
        MemoryRepository<Shipping> memoryRepository = new();
        
        Shipping shipping = new (4, 2, new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane());

        memoryRepository.Create(shipping);

        Assert.AreEqual(1, memoryRepository.GetAll().Length);

        memoryRepository.Delete(shipping);

        Assert.AreEqual(0, memoryRepository.GetAll().Length);
    }
    
    [TestMethod]
    public void TestGetById_ReturnsShipping()
    {
        MemoryRepository<Shipping> memoryRepository = new();
        
        Shipping shipping = new (4, 2, new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane());

        memoryRepository.Create(shipping);

        Assert.AreEqual(shipping, memoryRepository.GetById(shipping.Id));
    }
    
    [TestMethod]
    public void TestGetAll_ReturnsShippingArray()
    {
        MemoryRepository<Shipping> memoryRepository = new();
        
        Shipping shipping1 = new (1, 2, new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane());

        Shipping shipping2 = new(4, 2, new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane());

        memoryRepository.Create(shipping1);
        memoryRepository.Create(shipping2);

        Assert.AreEqual(memoryRepository.GetAll()[^1], memoryRepository.GetById(shipping2.Id));
        Assert.AreEqual(2, memoryRepository.GetAll().Length);
    }
}