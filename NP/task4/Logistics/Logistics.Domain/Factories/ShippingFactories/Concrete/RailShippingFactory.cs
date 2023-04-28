using Logistics.Domain.Factories.ShippingFactories.Abstract;
using Logistics.Domain.Transport.Abstract;
using Logistics.Domain.Transport.Concrete;

namespace Logistics.Domain.Factories.ShippingFactories.Concrete;

public class RailShippingFactory : IShippingFactory
{
    public ITransport CreateTransport() => new Train();
}