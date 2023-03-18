namespace task1.Shipping;

public class Driver : IShippingMember
{
    private string _name = "", _surname = "";
    private ulong _age;
    public Driver(string[] input) => InputFromStr(input);
    
    public void InputFromStr(string[] input) =>
        (_name, _surname, _age) = (input[0], input[1], ulong.Parse(input[2]));

    public override string ToString() => $"{_name} {_surname}, {_age} y.o.";
    
    public string GetRepresentation() => $"{_name} {_surname} {_age}";
}