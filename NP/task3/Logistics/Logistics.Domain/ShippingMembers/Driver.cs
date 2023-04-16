
using Logistics.Domain.Convertor;

namespace Logistics.Domain.ShippingMembers;

public class Driver : IConvert<Driver>
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public ulong Age { get; set; }
    
    public Driver() {}
    
    public Driver(string name, string surname, ulong age) => (Name, Surname, Age) = (name, surname, age);
    
    public override string ToString() => $"{Name} {Surname}, {Age} y.o.";
    
    public Driver Convert(string[] args)
    {
        (Name, Surname, Age) = (args[0], args[1], ulong.Parse(args[2]));
        return this;
    }
    
    public string GetRepresentation() => $"{Name} {Surname} {Age}";
}