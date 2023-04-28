using Logistics.Domain.Convertor;

namespace Logistics.Domain.ShippingMembers;

public class Goods : IConvert<Goods>
{
    public string Name { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    
    public Goods() {}
    
    public Goods(string name, decimal quantity) => (Name, Quantity) = (name, quantity);
    
    public Goods Convert(string[] args)
    {
        (Name, Quantity) = (args[0], decimal.Parse(args[1]));
        return this;
    }
    
    public override string ToString() => $"{Name}, {Quantity}t";
    
    public string GetRepresentation() => $"{Name} {Quantity}";
}