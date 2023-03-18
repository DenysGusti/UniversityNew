namespace task1.Transport;

public class Ship : ITransport
{
    public string Type => "Ship";

    public string Deliver() => "Delivered by ship.";
}