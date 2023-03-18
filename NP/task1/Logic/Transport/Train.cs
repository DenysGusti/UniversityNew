namespace task1.Transport;

public class Train : ITransport
{
    public string Type => "Train";

    public string Deliver() => "Delivered by train.";
}