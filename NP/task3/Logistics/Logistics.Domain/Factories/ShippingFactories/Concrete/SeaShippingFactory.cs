using Logistics.Domain.Factories.ShippingFactories.Abstract;
using Logistics.Domain.Transport.Abstract;
using Logistics.Domain.Transport.Concrete;

namespace Logistics.Domain.Factories.ShippingFactories.Concrete;

public class SeaShippingFactory : IShippingFactory
{
    public ITransport CreateTransport() => new Ship();
}