namespace task1.Transport;

public class Truck : ITransport
{
    public string Type => "Truck";

    public string Deliver() => "Delivered by truck.";
}