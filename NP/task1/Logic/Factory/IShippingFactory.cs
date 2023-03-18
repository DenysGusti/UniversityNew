using task1.Transport;

namespace task1.Factory;

public interface IShippingFactory
{
    public ITransport CreateTransport();
}