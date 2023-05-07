using System.Diagnostics;

namespace task_07;

internal static class Program {

    public static void Main(string[] args)
    {
        using var process = new Process {StartInfo = new ProcessStartInfo
        {
            FileName = "chmod",
            Arguments = string.Join(' ', args),
            UseShellExecute = false,
            RedirectStandardOutput = true
        }};
        process.Start();

        // Synchronously read the standard output of the spawned process.
        var reader = process.StandardOutput;
        var output = reader.ReadToEnd();

        // Write the redirected output to this application's window.
        Console.WriteLine(output);

        process.WaitForExit();

        // Console.WriteLine("\n\nPress any key to exit.");
        // Console.ReadLine();
    }
}