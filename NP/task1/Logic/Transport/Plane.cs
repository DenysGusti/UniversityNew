namespace task1.Transport;

public class Plane : ITransport
{
    public string Type => "Plane";

    public string Deliver() => "Delivered by plane.";
}