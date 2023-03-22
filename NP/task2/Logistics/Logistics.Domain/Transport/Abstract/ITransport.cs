using Logistics.Domain.Enums;

namespace Logistics.Domain.Transport.Abstract;

public interface ITransport
{
    public ShippingFactoryType Type { get; }
    
    public string Deliver();
}