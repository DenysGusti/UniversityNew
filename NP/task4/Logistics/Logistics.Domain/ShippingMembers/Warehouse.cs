using Logistics.Domain.Convertor;

namespace Logistics.Domain.ShippingMembers;

public class Warehouse : IConvert<Warehouse>
{
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public decimal Capacity { get; set; }
    
    public Warehouse() {}
    
    public Warehouse(string name, string city, decimal capacity) => (Name, City, Capacity) = (name, city, capacity);
    
    public Warehouse Convert(string[] args)
    {
        (Name, City, Capacity) = (args[0], args[1], decimal.Parse(args[2]));
        return this;
    }
    
    public override string ToString() => $"{Name}, {City}, {Capacity}t";
    
    public string GetRepresentation() => $"{Name} {City} {Capacity}";
}