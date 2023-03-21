using Logistics.Domain.Enums;
using Logistics.Domain.Factories.ShippingFactories.Abstract;

namespace Logistics.Domain.Factories.ShippingFactories.Concrete;

public class ShippingFactoryProvider
{
    private readonly ShippingFactoryType _type;
    public ShippingFactoryProvider(string type) => _type = Enum.Parse<ShippingFactoryType>(type);
    public IShippingFactory ConfigureFactory() => _type switch
    {
        ShippingFactoryType.Sea => new SeaShippingFactory(),
        ShippingFactoryType.Road => new RoadShippingFactory(),
        ShippingFactoryType.Rail => new RailShippingFactory(),
        ShippingFactoryType.Air => new AirShippingFactory(),
        _ => throw new ArgumentException($"unexpected type: {_type}", nameof(_type))
    };
}