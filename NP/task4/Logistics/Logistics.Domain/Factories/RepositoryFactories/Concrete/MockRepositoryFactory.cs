using Logistics.Domain.Convertor;
using Logistics.Domain.Factories.RepositoryFactories.Abstract;
using Logistics.Domain.Repositories.Abstract;
using Logistics.Domain.Repositories.Concrete;

namespace Logistics.Domain.Factories.RepositoryFactories.Concrete;

public class MockRepositoryFactory<T> : IRepositoryFactory<T> where T : EntityBase, IConvert<T>, new()
{
    public IRepository<T> CreateRepository() => new MockRepository<T>();
}