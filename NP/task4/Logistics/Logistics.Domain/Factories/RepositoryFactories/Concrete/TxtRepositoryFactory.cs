using Logistics.Domain.Convertor;
using Logistics.Domain.Factories.RepositoryFactories.Abstract;
using Logistics.Domain.Repositories.Abstract;
using Logistics.Domain.Repositories.Concrete;
using static Logistics.Domain.GlobalSettings.GlobalSettings;

namespace Logistics.Domain.Factories.RepositoryFactories.Concrete;

public class TxtRepositoryFactory<T> : IRepositoryFactory<T> where T : EntityBase, IConvert<T>, new()
{
    public IRepository<T> CreateRepository() => new TxtRepository<T>(TxtFile);
}