using Logistics.Domain.Convertor;
using Logistics.Domain.Enums;
using Logistics.Domain.Factories.RepositoryFactories.Abstract;
using Logistics.Domain.Repositories.Abstract;

namespace Logistics.Domain.Factories.RepositoryFactories.Concrete;

public class RepositoryFactoryProvider<T> where T : EntityBase, IConvert<T>, new()
{
    private readonly RepositoryFactoryType _type;
    
    public RepositoryFactoryProvider(RepositoryFactoryType type) => _type = type;
    
    public IRepositoryFactory<T> ConfigureFactory() => _type switch
    {
        RepositoryFactoryType.Txt => new TxtRepositoryFactory<T>(),
        _ => throw new ArgumentException($"unexpected type: {_type}", nameof(_type))
    };
}