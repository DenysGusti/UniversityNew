namespace task1.Shipping;

public class Warehouse : IShippingMember
{
    private string _name = "", _city = "";
    private decimal _capacity;

    public Warehouse(string[] input) => InputFromStr(input);

    public void InputFromStr(string[] input) =>
        (_name, _city, _capacity) = (input[0], input[1], decimal.Parse(input[2]));
    
    public override string ToString() => $"{_name}, {_city}, {_capacity}t";
    
    public string GetRepresentation() => $"{_name} {_city} {_capacity}";
}