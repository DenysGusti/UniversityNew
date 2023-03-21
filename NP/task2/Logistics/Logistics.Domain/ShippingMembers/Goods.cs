using Logistics.Domain.Convertor;

namespace Logistics.Domain.ShippingMembers;

public class Goods : IConvert<Goods>
{
    private string _name = string.Empty;
    private decimal _quantity;
    
    public Goods() {}

    public Goods(string name, decimal quantity) => (_name, _quantity) = (name, quantity);

    public Goods Convert(string[] args)
    {
        (_name, _quantity) = (args[0], decimal.Parse(args[1]));
        return this;
    }

    public override string ToString() => $"{_name}, {_quantity}t";
    
    public string GetRepresentation() => $"{_name} {_quantity}";
}