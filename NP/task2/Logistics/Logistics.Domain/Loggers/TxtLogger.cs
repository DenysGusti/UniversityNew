namespace Logistics.Domain.Loggers;

public sealed class TxtLogger
{
    public string? File { get; init; }
    
    private TxtLogger() {}
    
    private static TxtLogger? _instance;

    private static readonly object Lock = new();
    
    public static TxtLogger GetInstance(string file)
    {
        if (_instance != null) return _instance;
        lock (Lock) 
        {
            _instance ??= new TxtLogger {File = file};
        }
        return _instance;
    }

    public void LogError(Exception e)
    {
        using StreamWriter sw = new(File!, append: true);
        sw.WriteLine($"{DateTime.Now}\t{e.Message}");
    }
}