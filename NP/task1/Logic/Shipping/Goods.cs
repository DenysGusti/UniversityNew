namespace task1.Shipping;

public class Goods : IShippingMember
{
    private string _name = "";
    private decimal _quantity;

    public Goods(string[] input) => InputFromStr(input);

    public void InputFromStr(string[] input) =>
        (_name, _quantity) = (input[0], decimal.Parse(input[1]));
    
    public override string ToString() => $"{_name}, {_quantity}t";
    
    public string GetRepresentation() => $"{_name} {_quantity}";
}