using task1.Transport;

namespace task1.Factory;

public class RailShippingFactory : IShippingFactory
{
    public ITransport CreateTransport() => new Train();
}