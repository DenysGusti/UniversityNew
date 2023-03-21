using Logistics.Domain.Convertor;

namespace Logistics.Domain.ShippingMembers;

public class Warehouse : IConvert<Warehouse>
{
    private string _name = string.Empty;
    private string _city = string.Empty;
    private decimal _capacity;
    
    public Warehouse() {}
    
    public Warehouse(string name, string city, decimal capacity) => (_name, _city, _capacity) = (name, city, capacity);
    
    public Warehouse Convert(string[] args)
    {
        (_name, _city, _capacity) = (args[0], args[1], decimal.Parse(args[2]));
        return this;
    }
    
    public override string ToString() => $"{_name}, {_city}, {_capacity}t";


    public string GetRepresentation() => $"{_name} {_city} {_capacity}";
}