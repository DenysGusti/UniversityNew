using Logistics.Domain.Convertor;
using Logistics.Domain.Repositories.Abstract;

namespace Logistics.Domain.Repositories.Concrete;

public class MemoryRepository<T> : IRepository<T> where T : EntityBase, IConvert<T>, new()
{
    private Dictionary<int, T> _entities = new ();
    
    public T GetById(int id) => _entities[id];
    
    public void Create(T entity) => _entities.Add(entity.Id, entity);
    
    public void Update(T entity) => _entities[entity.Id] = entity;
    
    public void Delete(T entity) => _entities.Remove(entity.Id);
    
    public T[] GetAll() => _entities.Values.ToArray();
}