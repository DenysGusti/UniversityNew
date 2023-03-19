namespace task_02;

internal static class Program
{
    private static void PrintMatrix(float[,] matrix)
    {
        var n = matrix.GetLength(0);
        var path = new List<(int i, int j)> {(0, 0)};

        for (var step = 1; step < n; ++step)
        {
            var p = (step + 1) % 2;
            path.Add((path[^1].i + p, path[^1].j + (p + 1) % 2));
            for (var k = 0; k < step; ++k)
            {
                path.Add((path[^1].i - 2 * p + 1, path[^1].j + 2 * p - 1));
            }
        }
        path.AddRange(path.Take(path.Count - n).Reverse().Select(x => (n - 1 - x.i, n - 1 - x.j)));
        
        foreach (var (i, j) in path)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Enter n = ");
        var n = int.Parse(Console.ReadLine()!);
        var matrix = new float[n, n];
        for (var i = 0; i < matrix.GetLength(0); ++i)
        {
            foreach (var (v, j) in Console.ReadLine()!.Split().Select((v, j) => (float.Parse(v), j)))
            {
                matrix[i, j] = v;
            }
        }

        Console.WriteLine();
        for (var i = 0; i < matrix.GetLength(0); ++i)
        {
            for (var j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        PrintMatrix(matrix);
    }
}