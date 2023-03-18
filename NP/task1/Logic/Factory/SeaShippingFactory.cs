using task1.Transport;

namespace task1.Factory;

public class SeaShippingFactory : IShippingFactory
{
    public ITransport CreateTransport() => new Ship();
}