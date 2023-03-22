using Logistics.Domain.Enums;
using Logistics.Domain.Transport.Abstract;

namespace Logistics.Domain.Transport.Concrete;

public class Ship : ITransport
{
    public ShippingFactoryType Type => ShippingFactoryType.Sea;
    
    public override string ToString() => "Ship";
    
    public string Deliver() => "Delivered by ship.";
}