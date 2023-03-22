
using Logistics.Domain.Convertor;

namespace Logistics.Domain.ShippingMembers;

public class Driver : IConvert<Driver>
{
    private string _name = string.Empty;
    private string _surname = string.Empty;
    private ulong _age;
    
    public Driver() {}
    
    public Driver(string name, string surname, ulong age) => (_name, _surname, _age) = (name, surname, age);
    
    public override string ToString() => $"{_name} {_surname}, {_age} y.o.";
    
    public Driver Convert(string[] args)
    {
        (_name, _surname, _age) = (args[0], args[1], ulong.Parse(args[2]));
        return this;
    }
    
    public string GetRepresentation() => $"{_name} {_surname} {_age}";
}