using task1.Transport;

namespace task1.Factory;

public class RoadShippingFactory : IShippingFactory
{
    public ITransport CreateTransport() => new Truck();
}