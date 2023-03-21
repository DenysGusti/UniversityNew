using Logistics.Domain.Enums;
using Logistics.Domain.Transport.Abstract;

namespace Logistics.Domain.Transport.Concrete;

public class Truck : ITransport
{
    public ShippingFactoryType Type => ShippingFactoryType.Road;
    
    public override string ToString() => "Truck";

    public string Deliver() => "Delivered by truck.";
}