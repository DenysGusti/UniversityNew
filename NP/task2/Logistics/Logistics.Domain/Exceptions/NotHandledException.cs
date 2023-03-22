namespace Logistics.Domain.Exceptions;

public class NotHandledException: Exception
{
    public NotHandledException(string message) : base(message) {}
}