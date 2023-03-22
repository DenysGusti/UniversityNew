namespace Logistics.Domain.Exceptions;

public class ExitException: Exception
{
    public ExitException(string message) : base(message) {}
}