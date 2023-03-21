using Logistics.Domain.Convertor;
using Logistics.Domain.Repositories.Abstract;

namespace Logistics.Domain.Repositories.Concrete;

public class TxtRepository<T> : IRepository<T> where T : EntityBase, IConvert<T>, new()
{
    private Dictionary<int, T> _entities = new();
    private readonly string _file;

    public TxtRepository(string file)
    {
        _file = file;
        ReadFromFile();
    }
    
    public T GetById(int id) => _entities[id];

    public void Create(T entity)
    {
        _entities.Add(entity.Id, entity);
        WriteToFile();
    }

    public void Update(T entity) => _entities[entity.Id] = entity;

    public void Delete(T entity) => _entities.Remove(entity.Id);
    
    public T[] GetAll()
    {
        ReadFromFile();
        return _entities.Values.ToArray();
    }

    private void ReadFromFile()
    {
        _entities.Clear();
        using StreamReader sr = new(_file);
        while (!sr.EndOfStream)
        {
            var entity = new T().Convert(sr.ReadLine()!.Split());
            _entities[entity.Id] = entity;
        }
    }
    
    private void WriteToFile()
    {
        using StreamWriter sw = new(_file);
        foreach (var entity in _entities.Values)
        {
            sw.WriteLine(entity.GetRepresentation());
        }
    }
}