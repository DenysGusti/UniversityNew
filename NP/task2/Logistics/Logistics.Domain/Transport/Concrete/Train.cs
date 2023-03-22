using Logistics.Domain.Enums;
using Logistics.Domain.Transport.Abstract;

namespace Logistics.Domain.Transport.Concrete;

public class Train : ITransport
{
    public ShippingFactoryType Type => ShippingFactoryType.Rail;
    
    public override string ToString() => "Train";
    
    public string Deliver() => "Delivered by train.";
}