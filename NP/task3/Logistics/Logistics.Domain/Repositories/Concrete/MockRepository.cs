using Logistics.Domain.Convertor;
using Logistics.Domain.Models;
using Logistics.Domain.Repositories.Abstract;
using Logistics.Domain.ShippingMembers;
using Logistics.Domain.Transport.Concrete;

namespace Logistics.Domain.Repositories.Concrete;

public class MockRepository<T> : IRepository<T> where T : EntityBase, IConvert<T>, new()
{
    private Dictionary<int, Shipping> _entities = new ()
    {
        {1, new Shipping(1, 3,  new Goods("Honey", 16.5m),
            new Warehouse("Sklad_5", "Lviv", 250m),
            new Warehouse("Depot_7", "Amsterdam", 2000m),
            new Driver("Oleksandr", "Kovalenko", 34), new Truck())},
        
        {2, new Shipping(2, 10,  new Goods("Fruits", 10m),
            new Warehouse("Sklad_1", "Odesa", 100m),
            new Warehouse("Depot_1", "London", 300m),
            new Driver("Oleg", "Liber", 22), new Ship())},
        
        {3, new Shipping(3, 89,  new Goods("Hoe", 43m),
            new Warehouse("Sklad_2", "Paris", 500m),
            new Warehouse("Depot_2", "Berlin", 100m),
            new Driver("Ivan", "Libnov", 12), new Truck())},
        
        {4, new Shipping(4, 2,  new Goods("Hoe", 2m),
            new Warehouse("Sklad_3", "New_York", 1000m),
            new Warehouse("Depot_3", "Warsaw", 800m),
            new Driver("Peter", "Morgan", 52), new Plane())},
        
        {5, new Shipping(5, 7,  new Goods("Phones", 4m),
            new Warehouse("Sklad_4", "Beijing", 2000m),
            new Warehouse("Depot_4", "London", 500m),
            new Driver("Fart", "Gartfunkel", 24), new Train())},
    };
    
    public T GetById(int id) => (_entities[id] as T)!;
    
    public void Create(T entity) => _entities.Add(entity.Id, (entity as Shipping)!);
    
    public void Update(T entity) => _entities[entity.Id] = (entity as Shipping)!;
    
    public void Delete(T entity) => _entities.Remove(entity.Id);
    
    public T[] GetAll() => (_entities.Values.ToArray() as T[])!;
}