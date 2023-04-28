using Logistics.Domain.Enums;
using Logistics.Domain.Transport.Abstract;

namespace Logistics.Domain.Transport.Concrete;

public class Plane : ITransport
{
    public ShippingFactoryType Type => ShippingFactoryType.Air;
    
    public override string ToString() => "Plane";
    
    public string Deliver() => "Delivered by plane.";
}