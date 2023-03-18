namespace task1.Transport;

public interface ITransport
{
    public string Type { get; }

    public string Deliver();
}