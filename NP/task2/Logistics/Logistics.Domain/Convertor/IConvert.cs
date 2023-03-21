namespace Logistics.Domain.Convertor;

public interface IConvert<out T> where T : new()
{
    T Convert(string[] args);
    string GetRepresentation();
}
