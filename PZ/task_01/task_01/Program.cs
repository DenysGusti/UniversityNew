namespace task_01;

internal static class Program
{
    private static float GetNumber()
    {
        return float.TryParse(Console.ReadLine(), out var n) ? n : float.NaN;
    }

    private static string GetRepresentation(float n)
    {
        unsafe
        {
            var representation  = Convert.ToString(*(uint*) &n, 2).PadLeft(32, '0');
            
            var result = Enumerable
                .Range(0, 4)
                .Select(i => representation.Substring(i * 8, 8))
                .Aggregate((a, b) => $"{a} {b}");

            return result;
        }
    }

    private static int CountOnes(float n)
    {
        // sign - 1 {0, 1}, exponent - 8 [2^0 - 2^128], mantissa - 23 [1.0 - 2.0)
        unsafe
        {
            var count = 0;
            for (var bits = *(uint*) &n; bits > 0; bits >>= 1)
                count += (int)(bits & 1);
            return count;
        } 
    }
    
    public static void Main(string[] args)
    {
        var number = GetNumber();
        Console.WriteLine(float.IsNaN(number) ? "NaN" : float.IsInfinity(number) ? "Infinity" : number);

        if (float.IsNaN(number) || float.IsInfinity(number)) return;

        var rep = GetRepresentation(number);
        Console.WriteLine(rep);

        var ans = CountOnes(number);
        
        var expected = rep.Count(c => c == '1');

        Console.WriteLine(ans != expected ? $"Error: got {ans}, expected {expected}" : $"{expected} ones");
    }
}