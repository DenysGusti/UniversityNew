using Logistics.Domain.Repositories.Abstract;

namespace Logistics.Domain.Factories.RepositoryFactories.Abstract;

public interface IRepositoryFactory<T> where T : EntityBase
{
    IRepository<T> CreateRepository();
}