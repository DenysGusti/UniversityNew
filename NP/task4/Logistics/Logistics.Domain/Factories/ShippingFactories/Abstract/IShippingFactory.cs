using Logistics.Domain.Transport.Abstract;

namespace Logistics.Domain.Factories.ShippingFactories.Abstract;

public interface IShippingFactory
{
    public ITransport CreateTransport();
}