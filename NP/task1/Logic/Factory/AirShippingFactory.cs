using task1.Transport;

namespace task1.Factory;

public class AirShippingFactory : IShippingFactory
{
    public ITransport CreateTransport() => new Plane();
}